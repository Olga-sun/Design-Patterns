using System;
using Task2.Interfaces;

namespace Task2.Products.IProne
{
    public class IProneLaptop : ILaptop
    {
        public string GetModelName() => "IProne Book Pro";
        public void GetSpecs() => Console.WriteLine($"[{GetModelName()}] 16GB RAM, M2 Chip");
    }
}