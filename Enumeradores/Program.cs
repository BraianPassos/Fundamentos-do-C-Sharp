using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            var Keyboard = new Product(1,"Keyboard", 20, EProductType.Product);
            var ManutencaoTi = new Product(2, "Manutenção de computadores", 60, EProductType.Service);

            Console.WriteLine($"Id: {Keyboard.Id}\nName: {Keyboard.Name}\nPrice: {Keyboard.Price:f2}\nType: {Keyboard.Type}\n");
            Console.WriteLine($"Id: {ManutencaoTi.Id}\nName: {ManutencaoTi.Name}\nPrice: {ManutencaoTi.Price:f2}\nType: {ManutencaoTi.Type}");
        }  
    }

    struct Product
    {
        public int Id;
        public string Name;
        public double Price;
        public EProductType Type;

        public Product(int id,string name, double price, EProductType type)
        {
            Id = id;
            Name = name;
            Price = princeInDolar(price);
            Type = type;
        }
        public double princeInDolar(double price, double dolar = 5.66f)
        {
            return price * dolar;
        }
    }

    enum EProductType
    {
        Product = 1,
        Service = 2
    }
}
