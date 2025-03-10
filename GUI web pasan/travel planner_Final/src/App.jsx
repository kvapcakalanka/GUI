import React from 'react';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import NavigationBar from './navigationbar/navigationbar.jsx';
import HomePage from './home/homepage.jsx';
import Booking from './booking/booking.jsx';
import Destination from './destination/destination.jsx';
import LoginPage from './login/LoginPage.jsx';  

function App() {
  return (
    <Router>
      <NavigationBar />
      <Routes>
        <Route path="/" element={<HomePage />} />
        <Route path="/bookings" element={<Booking />} />
        <Route path="/destinations" element={<Destination />} />
        <Route path="/login" element={<LoginPage />} />  
      </Routes>
    </Router>
  );
}

export default App;
