using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass2
{
    class House
    {
        public double numRooms;
        public int numStories;
        private string color;
        private bool lightsOn;
        private int occupants;
        
        public void Display()
        {
            Console.WriteLine($"House:\nnumRooms={numRooms}\ncolor={color}\nstories={numStories}\nlightsOn={lightsOn}\noccupants={occupants}");
        }

        
        

    }
}
