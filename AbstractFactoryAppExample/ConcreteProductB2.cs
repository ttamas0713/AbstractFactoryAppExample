using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryAppExample
{
    class ConcreteProductB2 : IProduct2
    {
        public ConcreteProductB2()
        {
            Console.WriteLine("ProductB2 has been created");
        }
        public void doSomething()
        {
            throw new NotImplementedException();
        }
    }
}
