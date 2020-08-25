using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryAppExample
{
    class ConcreteFactoryA : IAbstractFactory
    {
        public ConcreteFactoryA()
        {
            Console.WriteLine("FactoryA started");
        }
        public IProduct1 createProduct1()
        {
            IProduct1 concreteProductA = new ConcreteProductA1();
            return concreteProductA;
        }

        public IProduct2 createProduct2()
        {
            IProduct2 concreteProductA2 = new ConcreteProductA2();
            return concreteProductA2;
        }
    }
}
