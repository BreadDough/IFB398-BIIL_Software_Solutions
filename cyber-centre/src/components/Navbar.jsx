import React, {useState, useEffect} from 'react';
import { CgMenuBoxed } from 'react-icons/cg'
import { AiOutlineCloseSquare } from 'react-icons/ai'
import Cyber from '../assets/Cyber.png';


const Navbar = ({ onPageChange }) => {
  const [nav, setNav] = useState(true);
  const [navFixed, setFix] = useState(false);

  const handleNav = () => {
    setNav(!nav);
  };

  useEffect(() => {
    const handleScroll = () => {
      // Get the scroll position
      const scrollY = window.scrollY;

      // Determine if the navbar should be fixed or not
      if (scrollY > 0) {
        setFix(true);
      } else {
        setFix(false);
      }
    };

    // Add a scroll event listener to handle the scrolling
    window.addEventListener('scroll', handleScroll);

    // Remove the event listener when the component unmounts
    return () => {
      window.removeEventListener('scroll', handleScroll);
    };
  }, []);

  
  

  return (
    <div className={`${ navFixed ? 'fixed top-0 left-0 w-full' : '' }
     bg-gray-300 py-4 h-20 flex justify-between border-b border-r-gray-900 bg-gradient-to-r from-white`}>
      {/* Left Section */}
      <div className="flex items-center text-[#DE4646] ">
        {/* Add your left-side components here */}
        <img  onClick={() => onPageChange('home')} src={Cyber} alt="Logo" className="w-20 h-20 ml-6 mr-3 " />
        <h1 className=" text-3xl font-bold pt-2 mx-4">CYBER CENTRE</h1>
        <div onClick={handleNav} className="pt-8 mx-2">
          {!nav ? <AiOutlineCloseSquare size={40}/> : <CgMenuBoxed size={40} />}
            <CgMenuBoxed size={30} className="pr-8" />
        </div>
        <div className={!nav ? "fixed left-0 top-20 w-[270px] h-full border-r border-r-gray-300 bg-gray-100 ease-in-out duration-500" : "fixed left-[-100%]"}>
            <ul className="justify-center">
              <ul className="hover:bg-white">
                <li className="uppercase font-semibold border-t border-gray-300 p-4">Services</li>
                <li className='border-b border-gray-300 text-sm px-4 text-[#8C8888] pb-4'>Find our wide range of services we offer here!</li>
              </ul>
              <ul className="hover:bg-white">
                <li className="uppercase font-semibold p-4">Login</li>
                <li className='border-b border-gray-300 text-sm px-4 text-[#8C8888] pb-4'>You can login to your account here.</li>
              </ul>
              <ul className="hover:bg-white">
                <li className="uppercase font-semibold p-4">Sign Up</li>
                <li className='border-b border-gray-300 text-sm px-4 text-[#8C8888] pb-4'>if you don't have an account already sign up and register here!</li>
              </ul>
            </ul>
        </div>
      </div>

      {/* Middle Section */}
      <div className="flex items-center">
        {/* Add your middle components here */}
      </div>

      {/* Right Section */}
      <div className="flex items-center space-x-4 text-[#DE4646]">
        {/* Add your right-side components here */}
        <ul className="flex text-lg">
            <li className="p-4 pr-8">Home</li>
            <li className="p-4">Services</li>
        </ul>
        <div className='mr-4'>
          <button  onClick={() => onPageChange('login')} className='bg-transparent px-6 py-3 text-[#DE4646]'>Login</button>
          <button onClick={() => onPageChange('signup')} className='px-6 py-3 float-right text-white'>Sign Up</button>
        </div>
      </div>
    </div>

  )
};


export default Navbar;
