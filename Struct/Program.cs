using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            var Keyboard = new Product(1,"Keyboard", 20);

            Console.WriteLine($"Id: {Keyboard.Id}\nName: {Keyboard.Name}\nPrice: {Keyboard.Price:f2}");
        }  
    }
}