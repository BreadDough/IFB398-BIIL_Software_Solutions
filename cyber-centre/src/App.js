//import logo from './logo.svg';
import './App.css';
import React, { useState} from 'react';
import Navbar from './components/Navbar.jsx'
import Banner from './components/Banner.jsx'
import Services from './components/Services.jsx'
import Cards from './components/Cards'
import Footer from './components/Footer'
import Signup from './components/Signup'
import Login from './components/Login'

function App() {

  const [currentPage, setCurrentPage] = useState('home');

  const handlePageChange = (pageName) => {
    setCurrentPage(pageName);
  };


  return (
    <>
     <Navbar onPageChange={handlePageChange} />
    {currentPage === 'home' && <Banner />}
    {currentPage === 'home' && <Services />}
    {currentPage === 'home' && <Cards />}
    {currentPage === 'home' && <Footer />}
    {currentPage === 'signup' && <Signup />}
    {currentPage === 'signup' && <Footer />}
    {currentPage === 'login' && <Login />}
    {currentPage === 'login' && <Footer />}
    </>
  );
}

export default App;
