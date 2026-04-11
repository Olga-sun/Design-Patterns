using System;
using Task2.Interfaces;

namespace Task2.Products.Balaxy
{
    public class BalaxyLaptop : ILaptop
    {
        public string GetModelName() => "Balaxy Book Ultra";
        public void GetSpecs() => Console.WriteLine($"[{GetModelName()}] 32GB RAM, Intel i9");
    }
}