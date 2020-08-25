using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryAppExample
{
    class ConcreteProductB1 : IProduct1
    {
        public ConcreteProductB1()
        {
            Console.WriteLine("ProductB1 has been created");
        }
        public void doSomething()
        {
            Console.WriteLine("Something... by ProductB");
        }
    }
}
