using System;
using System.Collections.Generic;

namespace ClassesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var magic = new Team();
            magic.City = "Orlando";
            magic.Colors = new string [] { "Blue", "Black" };
            magic.Name = "Magic";
            magic.TeamSize = 12;
            magic.Mascot = "Stuff";

            magic.Draft("Someone", 3.1);
            magic.Play();

            var cellphone = new Product();
            cellphone.Name = "Android";
            cellphone.Name = 1200000;

            var diablo = new Product();
            diablo.Colors  = "blue";
            diablo.Price = 800.00;

            var products = new List<Product>();
            products.Add(cellphone);
            products.Add(diablo);

            foreach(var product in products)
            {
                Console.WriteLine($"{product.Colors} $ {product.Price}");
            }

            var lab = new Dog();
            var dogs = new List<Dog>();
        }
    }
}
