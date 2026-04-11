using System;
using Task2.Interfaces;

namespace Task2.Products.Balaxy
{
    public class BalaxyEBook : IEBook
    {
        public void OpenBook() => Console.WriteLine("[Balaxy EBook] Читання книги з комфортного E-Ink екрану...");
    }
}