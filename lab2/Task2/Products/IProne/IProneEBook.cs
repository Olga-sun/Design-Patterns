using System;
using Task2.Interfaces;

namespace Task2.Products.IProne
{
    public class IProneEBook : IEBook
    {
        public void OpenBook() => Console.WriteLine("[IProne EBook] Читання книги у додатку iBooks...");
    }
}