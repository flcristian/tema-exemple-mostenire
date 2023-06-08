using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemple_mostenire.vehicle.model
{
    public class Plane : Vehicle
    {
        private int _maxHeight;
        private int _maxWeight;
        private int _maxSpeed;
        private int _centreOfGravity;

        // Constructors

        public Plane(int id, string make, string model, int maxHeight, int maxWeight, int maxSpeed, int centreOfGravity) : base(id, make, model, "Car")
        {
            _maxHeight = maxHeight;
            _maxWeight = maxWeight;
            _maxSpeed = maxSpeed;
            _centreOfGravity = centreOfGravity;
        }

        public Plane(string text) : base(text)
        {
            string[] data = text.Split('/');

            _maxHeight = Int32.Parse(data[4]);
            _maxWeight = Int32.Parse(data[5]);
            _maxSpeed = Int32.Parse(data[6]);
            _centreOfGravity = Int32.Parse(data[7]);
        }

        // Accessors

        public int MaxHeight
        {
            get { return _maxHeight; }
            set
            {
                _maxHeight = value;
            }
        }

        public int MaxWeight
        {
            get { return _maxWeight; }
            set
            {
                _maxWeight = value;
            }
        }

        public int MaxSpeed
        {
            get { return _maxSpeed; }
            set
            {
                _maxSpeed = value;
            }
        }

        public int CentreOfGravity
        {
            get { return _centreOfGravity; }
            set
            {
                _centreOfGravity = value;
            }
        }

        // Methods

        public string PlaneDescription()
        {
            string desc = base.Description();

            desc += $"Max height : {_maxHeight}\n";
            desc += $"Max weight : {_maxWeight}\n";
            desc += $"Max speed : {_maxSpeed}\n";
            desc += $"Centre of gravity : {_centreOfGravity}\n";

            return desc;
        }
    }
}
