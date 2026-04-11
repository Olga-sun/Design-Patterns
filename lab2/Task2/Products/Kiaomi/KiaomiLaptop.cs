using System;
using Task2.Interfaces;

namespace Task2.Products.Kiaomi
{
    public class KiaomiLaptop : ILaptop
    {
        public string GetModelName() => "Kiaomi MiBook";
        public void GetSpecs() => Console.WriteLine($"[{GetModelName()}] 8GB RAM, Intel i5");
    }
}