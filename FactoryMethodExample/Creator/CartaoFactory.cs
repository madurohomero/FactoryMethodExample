using FactoryMethodExample.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodExample.Creator
{
    public abstract class CartaoFactory
    {
        public abstract CartaoCredito BuscarCartaoCredito();
    }
}
