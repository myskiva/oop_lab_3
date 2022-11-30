using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone("Apple", "Iphone", 13);
            phone.Print();

            Information smartphone = new Information("Apple", "Iphone", 14, "512 gb");
            smartphone.PrintInf();
        }
    }

    class Phone
    {
        public string Brand { get; set; }
        public string Gadget { get; set; }
        public int Model { get; set; }

        public Phone(string brand, string gadget, int model)
        {

            Brand = brand;
            Gadget = gadget;
            Model = model;

        }


        public void Print()
        {

            Console.WriteLine("Brand: " + Brand + ", Gadget: " + Gadget + " " + Model);

        }
    }


    class Information : Phone
    {

        public string Memory { get; set; }
        public Information(string brand, string gadget, int model, string memory)

            : base(brand, gadget, model)

        {

            Console.WriteLine("Information of Smartphone");
            Memory = memory;

        }

        public void PrintInf()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Brand: " + Brand);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Gadget: " + Gadget + " " + Model);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Memory: " + Memory);
        }
    }
}