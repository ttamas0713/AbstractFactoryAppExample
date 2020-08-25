using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryAppExample
{
    class ConcreteFactoryB : IAbstractFactory
    {
        public ConcreteFactoryB()
        {
            Console.WriteLine("FactoryB started");
        }
        public IProduct1 createProduct1()
        {
            IProduct1 productB = new ConcreteProductB1();
            return productB;
        }

        public IProduct2 createProduct2()
        {
            IProduct2 productB2 = new ConcreteProductB2();
            return productB2;
        }
    }
}
