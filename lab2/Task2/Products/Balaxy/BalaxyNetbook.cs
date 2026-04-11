using System;
using Task2.Interfaces;

namespace Task2.Products.Balaxy
{
    public class BalaxyNetbook : INetbook
    {
        public void OpenWebBrowser() => Console.WriteLine("[Balaxy Netbook] Відкриття браузера Samsung Internet...");
    }
}