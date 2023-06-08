using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using exemple_mostenire.product;
using Microsoft.VisualBasic;

namespace exemple_mostenire.product.model
{
    public class Tool : Product
    {
        private int _powerConsumption;
        private string _usage;
        private string _manufacturer;

        // Constructors

        public Tool(int id, double price, string name, int powerConsumption, string usage, string manufacturer) : base(id, name, price, "Tool")
        {
            _powerConsumption = powerConsumption;
            _usage = usage;
            _manufacturer = manufacturer;
        }

        public Tool(string text) : base(text)
        {
            string[] data = text.Split('/');

            _powerConsumption = Int32.Parse(data[4]);
            _usage = data[5];
            _manufacturer = data[6];
        }

        // Accessors

        public int PowerConsumption
        {
            get { return _powerConsumption; }
            set
            {
                _powerConsumption = value;
            }
        }

        public string Usage
        {
            get { return _usage; }
            set
            {
                _usage = value;
            }
        }

        public string Manufacturer
        {
            get { return _manufacturer; }
            set
            {
                _manufacturer = value;
            }
        }

        // Methods

        public string ToolDescription()
        {
            string desc = base.Description();

            desc += $"Power consumption : {_powerConsumption}\n";
            desc += $"Usage : {_usage}\n";
            desc += $"Manufacturer : {_manufacturer}\n";

            return desc;
        }
    }
}
