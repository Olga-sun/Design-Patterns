using System;
using Task2.Interfaces;

namespace Task2.Products.IProne
{
    public class IProneSmartphone : ISmartphone
    {
        public void MakeCall() => Console.WriteLine("[IProne Smartphone] Здійснення дзвінка через FaceTime...");
    }
}