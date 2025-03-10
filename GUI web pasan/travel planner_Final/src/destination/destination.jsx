import React from 'react';
import './destination.css';

const destinations = [
  { name: 'Paris', description: 'The city of love and lights.', image: 'Paris.jpg' },
  { name: 'Bali', description: 'Tropical paradise for relaxation.', image: 'Bali.jpg' },
  { name: 'New York', description: 'The city that never sleeps.', image: 'New_York.jpg' }
];

const Destination = () => {
  return (
    <div className="destination-container">
      <h1>Explore Destinations</h1>
      <p>Find the best places to visit around the world.</p>
      <div className="destination-list">
        {destinations.map((dest, index) => (
          <div key={index} className="destination-card">
            
            <img src={`/${dest.image}`} alt={dest.name} className="destination-image" />
            <h2>{dest.name}</h2>
            <p>{dest.description}</p>
          </div>
        ))}
      </div>
    </div>
  );
};

export default Destination;
