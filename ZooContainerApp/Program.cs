using LionPlugin;
using System;

namespace ZooContainerApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var animal1 = new Lion();
            animal1.Add();
            animal1.Sleep();

            Console.WriteLine("END");
        }
    }
}