using System;

namespace AbstractFactoryAppExample
{
    class Program
    {
        /// <summary>
        /// This program is an example of the abstract factory pattern
        /// </summary>
        static void Main()
        {
            new ConcreteFactoryA().createProduct1();
            new ConcreteFactoryA().createProduct2();

            new ConcreteFactoryB().createProduct1();
            new ConcreteFactoryB().createProduct2();

            Console.ReadKey();
        }
    }
}
