import React from "react";
import Footer from "./components/Footer/Footer";
import Navbar from "./components/Navbar/Navbar";
import Layout from "./layout/Layout";
import Home from "./pages/Home/Home";

function App() {
  return (
    <>
      <Layout>
        <Navbar />
        <Home />
      </Layout>
      <Footer />
    </>
  );
}

export default App;
