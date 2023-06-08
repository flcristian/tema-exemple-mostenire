using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemple_mostenire.vehicle.model
{
    public class Bicycle : Vehicle
    {
        private string _color;
        private bool _isElectric;

        // Constructors

        public Bicycle(int id, string make, string model, string color, bool isElectric) : base(id, make, model, "Car")
        {
            _color = color;
            _isElectric = isElectric;
        }

        public Bicycle(string text) : base(text)
        {
            string[] data = text.Split('/');

            _color = data[4];
            _isElectric = Boolean.Parse(data[5]);
        }

        // Accessors

        public string Color
        {
            get { return _color; }
            set
            {
                _color = value;
            }
        }

        public bool IsElectric
        {
            get { return _isElectric; }
            set
            {
                _isElectric = value;
            }
        }

        // Methods

        public string BicycleDescription()
        {
            string desc = base.Description();

            desc += $"Color : {_color}\n";
            desc += $"Is electric : {_isElectric}\n";

            return desc;
        }
    }
}
