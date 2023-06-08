using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exemple_mostenire.product;
using Microsoft.VisualBasic;

namespace exemple_mostenire.product.model
{
    public class Instrument : Product
    {
        private string _instrumentType;
        private bool _isElectronic;

        // Constructors

        public Instrument(int id, double price, string name, string instrumentType, bool isElectronic) : base(id, name, price, "Instrument")
        {
            _instrumentType = instrumentType;
            _isElectronic = isElectronic;
        }

        public Instrument(string text) : base(text)
        {
            string[] data = text.Split('/');

            _instrumentType = data[4];
            _isElectronic = Boolean.Parse(data[5]);
        }

        // Accessors

        public string InstrumentType
        {
            get { return _instrumentType; }
            set
            {
                _instrumentType = value;
            }
        }

        public bool IsElectronic
        {
            get { return _isElectronic; }
            set
            {
                _isElectronic = value;
            }
        }

        // Methods

        public string InstrumentDescription()
        {
            string desc = base.Description();

            desc += $"Instrument type : {_instrumentType}\n";
            desc += $"Is electronic : {_isElectronic}\n";

            return desc;
        }
    }
}
