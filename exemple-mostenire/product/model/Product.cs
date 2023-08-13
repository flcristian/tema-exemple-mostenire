using exemple_mostenire.product.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemple_mostenire.product
{
    public class Product : IProduct
    {
        private int _id;
        private double _price;
        private string _name;
        private string _type;

        // Constructors

        public Product(int id, string name, double price, string type)
        {
            _id = id;
            _name = name;
            _price = price;
            _type = type;
        }

        public Product(string text)
        {
            string[] data = text.Split('/');

            _type = data[0];
            _id = Int32.Parse(data[1]);
            _price = Double.Parse(data[2]);
            _name = data[3];
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

        public double Price
        {
            get { return _price; }
            set
            {
                _price = value;
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
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
            desc += $"Price : {_price}$\n";
            desc += $"Name : {_name}\n";

            return desc;
        }
    }
}
