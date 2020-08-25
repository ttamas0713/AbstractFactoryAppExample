using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryAppExample
{
    class ConcreteProductA2 : IProduct2
    {
        public ConcreteProductA2()
        {
            Console.WriteLine("ProductA2 has been created");
        }
        public void doSomething()
        {
            throw new NotImplementedException();
        }
    }
}
