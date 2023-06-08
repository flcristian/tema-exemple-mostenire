using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exemple_mostenire.product;
using exemple_mostenire.product.model;

namespace exemple_mostenire.product
{
    public class ProductService
    {
        List<Product> _list;

        // Constructors

        public ProductService()
        {
            this.ReadList();
        }

        public ProductService(List<Product> list)
        {
            _list = list;
        }

        // Accessors

        public List<Product> List
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
            _list = new List<Product>();
            StreamReader sr = new StreamReader("D:\\mycode\\csharp\\mostenirea\\teme\\exemple-mostenire\\exemple-mostenire\\resources\\products.txt");

            while (!sr.EndOfStream)
            {
                string text = sr.ReadLine();
                string type = text.Split('/')[0];

                switch (type)
                {
                    case "Toy":
                        Toy toy = new Toy(text);
                        _list.Add(toy);
                        break;
                    case "Instrument":
                        Instrument instrument = new Instrument(text);
                        _list.Add(instrument);
                        break;
                    case "Decoration":
                        Decoration decoration = new Decoration(text);
                        _list.Add(decoration);
                        break;
                    case "Tool":
                        Tool tool = new Tool(text);
                        _list.Add(tool);
                        break;
                    case "Book":
                        Book book = new Book(text);
                        _list.Add(book);
                        break;
                    default:
                        break;
                }
            }
            sr.Close();
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
