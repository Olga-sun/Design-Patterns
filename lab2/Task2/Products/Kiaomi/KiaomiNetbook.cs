using System;
using Task2.Interfaces;

namespace Task2.Products.Kiaomi
{
    public class KiaomiNetbook : INetbook
    {
        public void OpenWebBrowser() => Console.WriteLine("[Kiaomi Netbook] Відкриття браузера Google Chrome...");
    }
}