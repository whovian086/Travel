using System;
using System.IO;
using Newtonsoft.Json;

namespace Travel
{
    class Program
    {
        const string PlaneFile = "Plane.json";
        static void Main(string[] args)
        {
            Plane plane = null;
        
            if (File.Exists(PlaneFile))
            {
                var fileText = File.ReadAllText(PlaneFile);
                plane = JsonConvert.DeserializeObject<Plane>(fileText);
            }
            else
            {
                plane = new Plane(1);            
            }

            var random = new Random();

            var passenger = new Passenger(random.Next());
            passenger.lastUpdtated = DateTime.UtcNow;

            plane.AddPassenger(passenger);

            Console.WriteLine($"The Plane #{plane.id} has {plane.passengers.Count} passenger(s).");

            var text = JsonConvert.SerializeObject(plane, Formatting.Indented);

            File.WriteAllText(PlaneFile, text);
        }
    }
}
