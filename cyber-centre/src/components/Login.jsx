import React from 'react'
import Cyber from '../assets/Cyber.png';

const Login = ({ onPageChange }) => {
    return (
    <div className="min-h-screen flex flex-col justify-center items-center bg-white">
      {/* The main parent div */}
      
      <div className="bg-white p-10 rounded items-center text-center">
        <img  onClick={() => onPageChange('home')} src={Cyber} alt="Logo" className="w-[200px] h-[200px] mx-16 " />
        <h1 className="text-5xl font-semibold m-6 ">Login</h1>
        <div className="bg-white p-10 rounded shadow-md">
        <form>
          <div className="mb-4 relative">
            <label htmlFor="name" className="text-gray-600 placeholder-gray-300 text-xs font-semibold absolute top-[-5px] left-3 bg-white p-1">
              Email
            </label>
            <input
              type="text"
              id="name"
              name="name"
              placeholder="Example@gmail.com"
              className="w-full px-3 py-3 my-2 text-center border border-gray-900 rounded focus:outline-none focus:border-[#DE4646]"
            />
          </div>
          <div className="mb-4 relative">
            <label htmlFor="name" className="text-gray-600 placeholder-gray-300 text-xs font-semibold absolute top-[-5px] left-3 bg-white p-1">
              Password
            </label>
            <input
              type="text"
              id="name"
              name="name"
              placeholder = "Password"
              className="w-full px-3 py-3 my-2 text-center border border-gray-900 rounded focus:outline-none focus:border-[#DE4646]"
            />
          </div>
          
          <button
            type="submit"
            className="bg-[#DE4646] ml-[0px] text-white w-full px-3 py-2 mt-7 rounded"
          >
            Login
          </button>
        </form>
        <div className='mt-6'>
            <p>
                Dont have an Account? Sign up.
            </p>
        </div>
      </div>
      </div>
    </div>
  );
}


export default Login