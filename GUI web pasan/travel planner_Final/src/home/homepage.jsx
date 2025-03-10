import { useState } from 'react';
import './homepage.css';

function HomePage() {
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

      
      <footer className="bottom-nav">
        <div className="contact-info">
          <p>Contact us: <strong>+1 234 567 890</strong></p>
          <p>Email: <strong>contact@yourwebsite.com</strong></p>
        </div>
        <div className="website-description">
          <p>Your ultimate travel companion, helping you plan the best trips with ease.</p>
        </div>
      </footer>
    </div>
  );
}

export default HomePage;
