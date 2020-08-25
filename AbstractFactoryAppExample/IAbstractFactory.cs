using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace AbstractFactoryAppExample
{
    interface IAbstractFactory
    {
        IProduct1 createProduct1();
        IProduct2 createProduct2();
    }
}
