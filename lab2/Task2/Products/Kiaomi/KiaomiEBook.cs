using System;
using Task2.Interfaces;

namespace Task2.Products.Kiaomi
{
    public class KiaomiEBook : IEBook
    {
        public void OpenBook() => Console.WriteLine("[Kiaomi EBook] Читання книги у додатку MiReader...");
    }
}