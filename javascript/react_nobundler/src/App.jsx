function App() {
  return (
    <div>
      <Hello />
      <p>This is an app using React without bundling or compilation.</p>
    </div>
  );
}

ReactDOM.render(<App />, document.getElementById('app'));