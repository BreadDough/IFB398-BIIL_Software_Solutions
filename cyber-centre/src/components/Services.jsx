import React from 'react';
import infographic1 from '../assets/infographic1.PNG'

const Services = () => {
    return (
    <div className="justify-center flex p-20">
            <div className="w-1/2">
            <img src={infographic1} alt="Logo" className="w-[800px] h-[600px] ml-[200px] mt-[200px] mb-[200px]" />
      </div>
      <div className="w-1/2 mt-[200px] ml-[50px]">
        <p className="text-4xl font-semibold tracking-wide pb-6 border-b-2 w-[700px] mb-6 text-[#DE4646]" >Why Cyber Centre?</p>
        <p className="text-gray-600 w-[700px]">         
        Tired of carrying around piles of important documents and sensitive personal information every time you need to prove your identity? Frustrated with the hassle of sharing these documents securely with trusted organizations? look no further! We've got the perfect solution for you.
        <br />
        <br />
        At Cyber Centre, we've revolutionized the way you manage and share your identity assets. Our cutting-edge platform offers you a safe, secure, and encrypted storage solution that's tailor-made for your convenience.</p>
      </div>
    </div>
    );
};

export default Services