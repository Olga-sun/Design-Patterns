using System;
using Task2.Interfaces;

namespace Task2.Products.IProne
{
    public class IProneNetbook : INetbook
    {
        public void OpenWebBrowser() => Console.WriteLine("[IProne Netbook] Відкриття браузера Safari...");
    }
}