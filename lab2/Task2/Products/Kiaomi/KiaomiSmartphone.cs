using System;
using Task2.Interfaces;

namespace Task2.Products.Kiaomi
{
    public class KiaomiSmartphone : ISmartphone
    {
        public void MakeCall() => Console.WriteLine("[Kiaomi Smartphone] Здійснення звичайного мобільного дзвінка...");
    }
}