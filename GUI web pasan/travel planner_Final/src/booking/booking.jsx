import React, { useState } from 'react';
import './booking.css';

const Booking = () => {
  const [formData, setFormData] = useState({
    destination: '',
    checkIn: '',
    checkOut: '',
    guests: 1
  });

  const handleChange = (e) => {
    setFormData({ ...formData, [e.target.name]: e.target.value });
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    if (!formData.destination || !formData.checkIn || !formData.checkOut || formData.guests < 1) {
      alert('Please fill in all fields correctly.');
      return;
    }
    console.log('Booking Details:', formData);
    alert('Booking submitted successfully!');
  };

  return (
    <div className="booking-container">
      <h1>Book Your Stay</h1>
      <p>Find the best accommodations for your trip.</p>
      <form className="booking-form" onSubmit={handleSubmit}>
        <label htmlFor="destination">Destination:</label>
        <input type="text" name="destination" id="destination" placeholder="Enter destination" value={formData.destination} onChange={handleChange} required />

        <label htmlFor="checkIn">Check-in Date:</label>
        <input type="date" name="checkIn" id="checkIn" value={formData.checkIn} onChange={handleChange} required />

        <label htmlFor="checkOut">Check-out Date:</label>
        <input type="date" name="checkOut" id="checkOut" value={formData.checkOut} onChange={handleChange} required />

        <label htmlFor="guests">Guests:</label>
        <input type="number" name="guests" id="guests" min="1" value={formData.guests} onChange={handleChange} required />

        <button type="submit">Search</button>
      </form>
    </div>
  );
};

export default Booking;
