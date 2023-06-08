using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exemple_mostenire.product;

namespace exemple_mostenire.product.model
{
    public class Toy : Product
    {
        private int _minimumAge;
        private string _information;
        private string _disclaimer;

        // Constructors

        public Toy(int id, double price, string name, int minimumAge, string information, string disclaimer):base(id, name, price, "Toy")
        {
            _minimumAge = minimumAge;
            _information = information;
            _disclaimer = disclaimer;
        }

        public Toy(string text) : base(text)
        {
            string[] data = text.Split('/');

            _minimumAge = Int32.Parse(data[4]);
            _information = data[5];
            _disclaimer = data[6];
        }

        // Accessors

        public int MinimumAge
        {
            get { return _minimumAge; }
            set
            {
                _minimumAge = value;
            }
        }
        
        public string Information
        {
            get { return _information; }
            set
            {
                _information = value;
            }
        }

        public string Disclaimer
        {
            get { return _disclaimer; }
            set
            {
               _disclaimer = value; 
            }
        }

        // Methods

        public string ToyDescription()
        {
            string desc = base.Description();

            desc += $"Minimum age : {_minimumAge}\n";
            desc += $"Information : {_information}\n";
            desc += $"Disclaimer : {_disclaimer}\n";

            return desc;
        }
    }
}
