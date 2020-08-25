using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryAppExample
{
    class ConcreteProductA1 : IProduct1
    {
        public ConcreteProductA1()
        {
            Console.WriteLine("ProductA1 has been created");
        }
        public void doSomething()
        {
            Console.WriteLine("Something... by ProductA");
        }
    }
}
