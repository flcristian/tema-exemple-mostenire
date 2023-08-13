using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exemple_mostenire.product;
using exemple_mostenire.product.model;
using exemple_mostenire.product.service;

namespace exemple_mostenire.product
{
    public class ProductService
    {
        List<IProduct> _list;

        // Constructors

        public ProductService()
        {
            ReadList();
        }

        public ProductService(List<IProduct> list)
        {
            _list = list;
        }

        // Accessors

        public List<IProduct> List
        {
            get { return _list; }
            set
            {
                _list = value;
            }
        }

        // Methods

        public void ReadList()
        {
            _list = new List<IProduct>();
            StreamReader sr = new StreamReader("D:\\mycode\\csharp\\mostenirea\\teme\\exemple-mostenire\\exemple-mostenire\\resources\\products.txt");

            while (!sr.EndOfStream)
            {
                IProductFactory productFactory = new ProductFactory();
                
                _list.Add(productFactory.createProduct(sr.ReadLine()));
            }sr.Close();
        }

        public void Afisare()
        {
            foreach (Product product in _list)
            {
                string desc = "";

                switch (product.Type)
                {
                    case "Toy":
                        Toy toy = product as Toy;
                        desc = toy.ToyDescription();
                        break;
                    case "Instrument":
                        Instrument instrument = product as Instrument;
                        desc = instrument.InstrumentDescription();
                        break;
                    case "Decoration":
                        Decoration decoration = product as Decoration;
                        desc = decoration.DecorationDescription();
                        break;
                    case "Tool":
                        Tool tool = product as Tool;
                        desc = tool.ToolDescription();
                        break;
                    case "Book":
                        Book book = product as Book;
                        desc = book.BookDescription();
                        break;
                    default:
                        break;
                }

                Console.WriteLine(desc);
            }
        }
    }
}
