import sys
import ffmpeg
from PySide6.QtWidgets import (
    QApplication, QMainWindow, QWidget, QVBoxLayout,
    QHBoxLayout, QListWidget, QComboBox, QLabel, QPushButton, QStatusBar, QPlainTextEdit, QFileDialog, QGridLayout
)
from PySide6.QtCore import Qt, QThread, Signal
from PySide6.QtGui import QDropEvent
import subprocess

class ConversionThread(QThread):
    log_signal = Signal(str)
    status_signal = Signal(str)

    def __init__(self, input_file, output_file, video_codec, audio_codec, video_bitrate, audio_bitrate):
        super().__init__()
        self.input_file = input_file
        self.output_file = output_file
        self.video_codec = video_codec
        self.audio_codec = audio_codec
        self.video_bitrate = video_bitrate
        self.audio_bitrate = audio_bitrate

    def run(self):
        # Compile FFmpeg command
        ffmpeg_command = (
            ffmpeg
            .input(self.input_file)
            .output(self.output_file, vcodec=self.video_codec, acodec=self.audio_codec, 
                    video_bitrate=self.video_bitrate, audio_bitrate=self.audio_bitrate)
            .compile()
        )

        # Run the FFmpeg command as a subprocess
        process = subprocess.Popen(ffmpeg_command, stderr=subprocess.PIPE, text=True)
        for line in process.stderr:
            self.log_signal.emit(line.strip())
        process.wait()  # Wait for FFmpeg to finish

        # Send status update based on success or failure
        if process.returncode == 0:
            self.status_signal.emit(f"Successfully converted: {self.input_file}")
        else:
            self.status_signal.emit(f"Error converting {self.input_file}")

class VideoConverterApp(QMainWindow):
    def __init__(self):
        super().__init__()
        self.setWindowTitle("Video Converter with FFmpeg")
        self.setGeometry(300, 300, 600, 500)
        
        # Central widget
        central_widget = QWidget(self)
        self.setCentralWidget(central_widget)
        main_layout = QVBoxLayout(central_widget)
        
        # Horizontal layout for file list and buttons
        file_layout = QHBoxLayout()
        
        # File List
        self.file_list_widget = QListWidget(self)
        self.file_list_widget.setAcceptDrops(True)
        self.file_list_widget.setDragDropMode(QListWidget.InternalMove)
        file_layout.addWidget(self.file_list_widget)

        # Button layout on the right side
        button_layout = QVBoxLayout()
        
        # Add Files button
        self.add_files_button = QPushButton("Add Files", self)
        self.add_files_button.clicked.connect(self.open_file_dialog)
        button_layout.addWidget(self.add_files_button)
        
        # Remove selected file button
        self.remove_file_button = QPushButton("Remove Selected", self)
        self.remove_file_button.clicked.connect(self.remove_selected_file)
        button_layout.addWidget(self.remove_file_button)
        
        # Clear all files button
        self.clear_files_button = QPushButton("Clear All", self)
        self.clear_files_button.clicked.connect(self.clear_all_files)
        button_layout.addWidget(self.clear_files_button)
        
        button_layout.addStretch()  # Add stretch to align buttons at the top
        file_layout.addLayout(button_layout)
        
        main_layout.addLayout(file_layout)
        
        # Codec and Bitrate Options in a Grid Layout
        grid_layout = QGridLayout()
        
        # Video Codec Selector
        self.video_codec_combo = QComboBox(self)
        self.video_codec_combo.addItems(["libx264", "libx265", "vp9"])
        grid_layout.addWidget(QLabel("Video Codec"), 0, 0)
        grid_layout.addWidget(self.video_codec_combo, 0, 1)
        
        # Audio Codec Selector
        self.audio_codec_combo = QComboBox(self)
        self.audio_codec_combo.addItems(["aac", "mp3", "vorbis"])
        grid_layout.addWidget(QLabel("Audio Codec"), 1, 0)
        grid_layout.addWidget(self.audio_codec_combo, 1, 1)
        
        # Video Bitrate Selector
        self.video_bitrate_combo = QComboBox(self)
        self.video_bitrate_combo.addItems(["1M", "2M", "3M", "5M"])  # Adjust bitrates as needed
        grid_layout.addWidget(QLabel("Video Bitrate"), 0, 2)
        grid_layout.addWidget(self.video_bitrate_combo, 0, 3)
        
        # Audio Bitrate Selector
        self.audio_bitrate_combo = QComboBox(self)
        self.audio_bitrate_combo.addItems(["128k", "192k", "256k", "320k"])  # Adjust bitrates as needed
        grid_layout.addWidget(QLabel("Audio Bitrate"), 1, 2)
        grid_layout.addWidget(self.audio_bitrate_combo, 1, 3)
        
        # Add the grid layout to the main layout
        main_layout.addLayout(grid_layout)
        
        # Start Button
        self.start_button = QPushButton("Start Conversion", self)
        self.start_button.clicked.connect(self.start_conversion)
        main_layout.addWidget(self.start_button)

        # Status bar
        self.status_bar = QStatusBar(self)
        self.setStatusBar(self.status_bar)

        # Log Viewer
        self.log_viewer = QPlainTextEdit(self)
        self.log_viewer.setReadOnly(True)
        main_layout.addWidget(self.log_viewer)
        
        # Thread placeholder
        self.thread = None

    def open_file_dialog(self):
        # Open file dialog as an alternative to drag-and-drop
        file_dialog = QFileDialog(self)
        file_dialog.setFileMode(QFileDialog.ExistingFiles)
        if file_dialog.exec():
            files = file_dialog.selectedFiles()
            for file in files:
                self.file_list_widget.addItem(file)
    
    def remove_selected_file(self):
        # Remove the selected file from the list
        selected_items = self.file_list_widget.selectedItems()
        for item in selected_items:
            self.file_list_widget.takeItem(self.file_list_widget.row(item))
    
    def clear_all_files(self):
        # Clear all items from the file list
        self.file_list_widget.clear()
    
    def dragEnterEvent(self, event: QDropEvent):
        if event.mimeData().hasUrls():
            event.acceptProposedAction()
    
    def dropEvent(self, event: QDropEvent):
        for url in event.mimeData().urls():
            if url.isLocalFile():
                self.file_list_widget.addItem(url.toLocalFile())
    
    def start_conversion(self):
        video_codec = self.video_codec_combo.currentText()
        audio_codec = self.audio_codec_combo.currentText()
        video_bitrate = self.video_bitrate_combo.currentText()
        audio_bitrate = self.audio_bitrate_combo.currentText()

        for index in range(self.file_list_widget.count()):
            input_file = self.file_list_widget.item(index).text()
            output_file = input_file.rsplit(".", 1)[0] + "_converted.mp4"
            
            # Update status bar
            self.status_bar.showMessage(f"Converting {input_file}...")
            
            # Start conversion in a separate thread
            self.thread = ConversionThread(input_file, output_file, video_codec, audio_codec, video_bitrate, audio_bitrate)
            self.thread.log_signal.connect(self.log_viewer.appendPlainText)
            self.thread.status_signal.connect(self.update_status)
            self.thread.start()
    
    def update_status(self, message):
        self.status_bar.showMessage(message)
        self.log_viewer.appendPlainText(message)

if __name__ == "__main__":
    app = QApplication(sys.argv)
    window = VideoConverterApp()
    window.show()
    sys.exit(app.exec())
