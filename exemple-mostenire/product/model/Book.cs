using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exemple_mostenire.product;
using Microsoft.VisualBasic;

namespace exemple_mostenire.product.model
{
    public class Book : Product
    {
        private string _author;
        private string _category;

        // Constructors

        public Book(int id, double price, string name, string author, string category) : base(id, name, price, "Book")
        {
            _author = author;
            _category = category;
        }

        public Book(string text) : base(text)
        {
            string[] data = text.Split('/');

            _author = data[4];
            _category = data[5];
        }

        // Accessors

        public string Author
        {
            get { return _author; }
            set
            {
                _author = value;
            }
        }

        public string Category
        {
            get { return _category; }
            set
            {
                _category = value;
            }
        }

        // Methods

        public string BookDescription()
        {
            string desc = base.Description();

            desc += $"Author : {_author}\n";
            desc += $"Category : {_category}\n";

            return desc;
        }
    }
}
