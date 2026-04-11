using System;
using Task2.Interfaces;

namespace Task2.Products.Balaxy
{
    public class BalaxySmartphone : ISmartphone
    {
        public void MakeCall() => Console.WriteLine("[Balaxy Smartphone] Здійснення надшвидкого дзвінка через мережу 5G...");
    }
}