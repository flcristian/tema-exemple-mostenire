using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exemple_mostenire.product;
using Microsoft.VisualBasic;

namespace exemple_mostenire.product.model
{
    public class Decoration : Product
    {
        private string _category;
        private string _manufacturer;

        // Constructors

        public Decoration(int id, double price, string name, string category, string manufacturer) : base(id, name, price, "Decoration")
        {
            _category = category;
            _manufacturer = manufacturer;
        }

        public Decoration(string text) : base(text)
        {
            string[] data = text.Split('/');

            _category = data[4];
            _manufacturer = data[5];
        }

        // Accessors

        public string Category
        {
            get { return _category; }
            set
            {
                _category = value;
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

        public string DecorationDescription()
        {
            string desc = base.Description();

            desc += $"Category : {_category}\n";
            desc += $"Manufacturer : {_manufacturer}\n";

            return desc;
        }
    }
}
