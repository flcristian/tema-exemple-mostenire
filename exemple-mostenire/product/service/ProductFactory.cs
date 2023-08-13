using exemple_mostenire.product.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemple_mostenire.product.service
{
    public  class ProductFactory : IProductFactory
    {
        public IProduct createProduct(string text)
        {
            string type = text.Split('/')[0];
            switch (type)
            {
                case "Book":
                    return new Book(text);
                case "Decoration":
                    return new Decoration(text);
                case "Instrument":
                    return new Instrument(text);
                case "Tool":
                    return new Tool(text);
                case "Toy":
                    return new Toy(text);
                default:
                    return null;
            }
        }
    }
}