using System;
using Task2.Interfaces;
using Task2.Factories;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== Виробництво IProne ===");
            TestDeviceProduction(new IProneFactory());

            Console.WriteLine("\n=== Виробництво Kiaomi ===");
            TestDeviceProduction(new KiaomiFactory());

            Console.WriteLine("\n=== Виробництво Balaxy ===");
            TestDeviceProduction(new BalaxyFactory());

            Console.ReadLine();
        }

        // Цей метод працює лише з інтерфейсами. Він не знає, які саме 
        // конкретні класи сюди передаються. Це і є магія Абстрактної фабрики.
        static void TestDeviceProduction(IDeviceFactory factory)
        {
            // 1. Створюємо продукти
            ILaptop laptop = factory.CreateLaptop();
            INetbook netbook = factory.CreateNetbook();
            IEBook ebook = factory.CreateEBook();
            ISmartphone smartphone = factory.CreateSmartphone();

            // 2. Демонструємо їхню роботу
            laptop.GetSpecs();
            netbook.OpenWebBrowser();
            ebook.OpenBook();
            smartphone.MakeCall();
        }
    }
}