using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemple_mostenire.vehicle.model
{
    public class Car : Vehicle
    {
        private int _topSpeed;
        private string _color;

        // Constructors

        public Car(int id, string make, string model, int topSpeed, string color) : base(id, make, model, "Car")
        {
            _topSpeed = topSpeed;
            _color = color;
        }
        
        public Car(string text) : base(text)
        {
            string[] data = text.Split('/');

            _topSpeed = Int32.Parse(data[4]);
            _color = data[5];
        }

        // Accessors

        public int TopSpeed
        {
            get { return _topSpeed; }
            set
            {
                _topSpeed = value;
            }
        }

        public string Color
        {
            get { return _color; }
            set
            {
                _color = value;
            }
        }

        // Methods

        public string CarDescription()
        {
            string desc = base.Description();

            desc += $"Top speed : {_topSpeed}\n";
            desc += $"Color : {_color}\n";

            return desc;
        }
    }
}
