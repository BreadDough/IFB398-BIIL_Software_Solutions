import React from 'react';
import Single from '../assets/infographic1.PNG'


const Cards = () => {
  return (
    <div className='w-full py-[10rem] px-4 bg-gray-100'>
      <div className='max-w-[1240px] mx-auto grid md:grid-cols-2 gap-8'>
          <div className='w-full shadow-xl flex flex-col p-4 my-4 rounded-lg hover:scale-105 duration-300'>
              <img className='w-20 mx-auto mt-[-3rem] bg-white' src={Single} alt="/" />
              <h2 className='text-2xl font-bold text-center py-8'>Service 1</h2>
              <div className='text-center font-medium'>
                  <p className='py-2 border-b mx-8'>Here at Cyber Centre we offer secure holding of sensitive data as a service, our garentee is once your data has been uploaded it is unaccessible from the rest of the world unless you share your assets via a package.</p>
              </div>
          </div>
          <div className='w-full shadow-xl flex flex-col p-4 my-4 rounded-lg hover:scale-105 duration-300'>
              <img className='w-20 mx-auto mt-[-3rem] bg-transparent' src={Single} alt="/" />
              <h2 className='text-2xl font-bold text-center py-8'>Service 2</h2>
              <div className='text-center font-medium'>
                  <p className='py-2 border-b mx-8'>Here at Cyber Centre we offer secure holding of sensitive data as a service, our garentee is once your data has been uploaded it is unaccessible from the rest of the world unless you share your assets via a package.</p>
              </div>
          </div>
          <div className='w-full shadow-xl flex flex-col p-4 my-4 rounded-lg hover:scale-105 duration-300'>
              <img className='w-20 mx-auto mt-[-3rem] bg-white' src={Single} alt="/" />
              <h2 className='text-2xl font-bold text-center py-8'>Service 3</h2>
              <div className='text-center font-medium'>
                  <p className='py-2 border-b mx-8'>Here at Cyber Centre we offer secure holding of sensitive data as a service, our garentee is once your data has been uploaded it is unaccessible from the rest of the world unless you share your assets via a package.</p>
              </div>
          </div>
          <div className='w-full shadow-xl flex flex-col p-4 my-4 rounded-lg hover:scale-105 duration-300'>
              <img className='w-20 mx-auto mt-[-3rem] bg-white' src={Single} alt="/" />
              <h2 className='text-2xl font-bold text-center py-8'>Service 4</h2>
              <div className='text-center font-medium'>
                  <p className='py-2 border-b mx-8'>Here at Cyber Centre we offer secure holding of sensitive data as a service, our garentee is once your data has been uploaded it is unaccessible from the rest of the world unless you share your assets via a package.</p>
              </div>
          </div>
          <div className='w-full shadow-xl flex flex-col p-4 my-4 rounded-lg hover:scale-105 duration-300'>
              <img className='w-20 mx-auto mt-[-3rem] bg-white' src={Single} alt="/" />
              <h2 className='text-2xl font-bold text-center py-8'>Service 4</h2>
              <div className='text-center font-medium'>
                  <p className='py-2 border-b mx-8'>Here at Cyber Centre we offer secure holding of sensitive data as a service, our garentee is once your data has been uploaded it is unaccessible from the rest of the world unless you share your assets via a package.</p>
              </div>
          </div>
          <div className='w-full shadow-xl flex flex-col p-4 my-4 rounded-lg hover:scale-105 duration-300'>
              <img className='w-20 mx-auto mt-[-3rem] bg-white' src={Single} alt="/" />
              <h2 className='text-2xl font-bold text-center py-8'>Service 4</h2>
              <div className='text-center font-medium'>
                  <p className='py-2 border-b mx-8'>Here at Cyber Centre we offer secure holding of sensitive data as a service, our garentee is once your data has been uploaded it is unaccessible from the rest of the world unless you share your assets via a package.</p>
              </div>
          </div>
      </div>
    </div>
  );
};

export default Cards;