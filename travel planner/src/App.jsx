import { useState } from 'react'
import reactLogo from './assets/react.svg'
import viteLogo from '/vite.svg'
import './App.css'

function App() {


  return (
    <div className="home-container">
      <header className="hero-section">
        <h1>Plan Your Perfect Trip</h1>
        <p>Discover destinations, book accommodations, and create your dream itinerary.</p>
        <button className="cta-button">Get Started</button>
      </header>

      <section className="features">
        <div className="feature-card">
          <h2>Personalized Itineraries</h2>
          <p>Customize your travel plans with ease.</p>
        </div>
        <div className="feature-card">
          <h2>Accommodation Booking</h2>
          <p>Find and book the best places to stay.</p>
        </div>
        <div className="feature-card">
          <h2>Local Attractions</h2>
          <p>Discover must-visit spots and experiences.</p>
        </div>
      </section>
    </div>
  );
};

export default App;
