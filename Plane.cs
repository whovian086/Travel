using System;
using System.Collections.Generic;

namespace Travel
{
    class Plane
    {
        public List<Passenger> passengers;
        public int id;

        public Plane(int id)
        {
            this.id = id;
            passengers = new List<Passenger>();
        }

        public void AddPassenger(Passenger passenger)
        {
            passengers.Add(passenger);
        }
    }
}