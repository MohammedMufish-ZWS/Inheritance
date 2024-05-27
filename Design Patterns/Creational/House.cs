using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Design_Patterns.Creational
{
    public class House
    {
        public string Walls { get; set; }
        public string Roof { get; set; }
        public string Doors { get; set; }
        public string Windows { get; set; }

        public override string ToString()
        {
            return $"House with {Walls} walls, {Roof} roof, {Doors} doors, and {Windows} windows.";
        }
    }
    public class HouseBuilder
    {
        private House _house = new House();

        public HouseBuilder BuildWalls(string walls)
        {
            _house.Walls = walls;
            return this;
        }

        public HouseBuilder BuildRoof(string roof)
        {
            _house.Roof = roof;
            return this;
        }

        public HouseBuilder BuildDoors(string doors)
        {
            _house.Doors = doors;
            return this;
        }

        public HouseBuilder BuildWindows(string windows)
        {
            _house.Windows = windows;
            return this;
        }

        public House Build()
        {
            return _house;
        }
    }

}
