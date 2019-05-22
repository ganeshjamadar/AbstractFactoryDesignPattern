﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    /// <summary>

    /// MainApp startup class for Structural

    /// Abstract Factory Design Pattern.

    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Abstract factory #1

            AbstractFactory factory1 = new ConcreteFactory1();
            Client client1 = new Client(factory1);
            client1.Run();

            // Abstract factory #2 Changes dfsddsgdsg

            AbstractFactory factory2 = new ConcreteFactory2();
            Client client2 = new Client(factory2);
            client2.Run();

            // Wait for user input

            Console.ReadKey();
        }
    }
}
