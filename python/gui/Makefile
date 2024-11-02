.PHONY: build clean run deps

deps:
	@pip3 install -r requirements.txt

clean:
	@rm -rf build dist __pycache__ main.spec

build:
	@pyinstaller --onefile --noconsole main.py

run:
	@python3 main.py