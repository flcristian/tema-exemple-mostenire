using exemple_mostenire.product.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemple_mostenire.product.service
{
    internal interface IProductFactory
    {
        IProduct createProduct(string text);
    }
}
