import React from 'react';
import landing from '../assets/landing.jpg'
import { TypeAnimation } from 'react-type-animation'

const Banner = () => {
    return (
    <div className="h-[1210px] flex items-center justify-center" style={{ backgroundImage: `url(${landing})` }}>
    {/* Your content goes here */}
    <div className='max-w-[800px] mt-[-96px] w-full h-screen mx-auto text-center flex flex-col justify-center'>
        <p className='text-white font-bold p-2'>
          
        </p>
        <h1 className='text-white md:text-7xl sm:text-6xl text-4xl font-bold md:py-6 border-b-2 border-gray-100'>
         <TypeAnimation
      sequence={[
        // Same substring at the start will only be typed out once, initially
        'Save',
        100, // wait 1s before replacing "Mice" with "Hamsters"
        'Secure',
        100,
        'Share',
        100,
        'Save-Secure-Share',
        100
  
      ]}
      wrapper="span"
      speed={50}
      className="text-white"
      repeat={Infinity}
    />
        </h1>
        <div className='flex justify-center items-center'>
          <p className='text-[#FFFFFF] md:text-4xl sm:text-xl text-2xl font-bold py-4'>
          Cyber Centre, secure document storage<br/> 
          &<br/>
          sharing
          </p>
        </div>
        <p className='md:text-xl text-xl font-bold text-gray-300 border-b-2 border-white pb-6'>Your one vault for all personal identifying assets, find out what services we could provide you or your organisation.</p>
        <button className='bg-[#DE4646] w-[200px] rounded-md font-medium my-6 mx-auto py-3 text-white'>Get Started</button>
        
      </div>
    </div>
    );
};

export default Banner