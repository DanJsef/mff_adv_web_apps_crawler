import "./App.css";
import Home from "./pages/Home";
import { Routes, Route } from "react-router-dom";

function App() {
  return (
    <div className="App">
      <h1>Welcome tosddddddddddddddddddddddddd React Router!</h1>
      <Routes>
        <Route path="/" element={<Home />} />
      </Routes>
    </div>
  );
}

export default App;
