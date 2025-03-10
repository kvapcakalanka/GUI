import React from 'react';
import { Link } from 'react-router-dom';
import './navigationbar.css';

const NavigationBar = () => {
  return (
    <nav className="navbar">
      <div className="logo">Travel Planner</div>
      <ul className="nav-links">
        <li><Link to="/">Home</Link></li>
        <li><Link to="/destinations">Destinations</Link></li>
        <li><Link to="/bookings">Bookings</Link></li>
        <li><Link to="/login">Login</Link></li>
      </ul>
    </nav>
  );
};

export default NavigationBar;
