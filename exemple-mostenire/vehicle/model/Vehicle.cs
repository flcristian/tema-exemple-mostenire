using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace exemple_mostenire.vehicle.model
{
    public class Vehicle
    {
        private int _id;
        private string _make;
        private string _model;
        private string _type;

        // Constructors

        public Vehicle(int id, string make, string model, string type)
        {
            _id = id;
            _make = make;
            _model = model;
            _type = type;
        }

        public Vehicle(string text)
        {
            string[] data = text.Split('/');

            _type = data[0];
            _id = Int32.Parse(data[1]);
            _make = data[2];
            _model = data[3];
        }

        // Accessors

        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }

        public string Make
        {
            get { return _make; }
            set
            {
                _make = value;
            }
        }

        public string Model
        {
            get { return _model; }
            set
            {
                _model = value;
            }
        }

        public string Type
        {
            get { return _type; }
            set
            {
                _type = value;
            }
        }

        // Methods

        public string Description()
        {
            string desc = "";

            desc += $"Id : {_id}\n";
            desc += $"Make : {_make}$\n";
            desc += $"Model : {_model}\n";

            return desc;
        }
    }
}
