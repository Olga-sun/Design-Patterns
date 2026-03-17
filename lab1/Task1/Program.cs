using System;
using lab1.Factory_metod.Subscriptions; 
using lab1.Factory_metod.Interfaces;
using lab1.Factory_metod.Factories;

namespace lab1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Для коректних літер 'і', 'ї', 'є'

            // Масив різних фабрик для перевірки всіх каналів продажу
            SubscriptionFactory[] factories = new SubscriptionFactory[]
            {
        new WebSite(),
        new MobileApp(),
        new ManagerCall()
            };

            string[] types = { "domestic", "educational", "premium" };

            Console.WriteLine("======= ТЕСТУВАННЯ СИСТЕМИ ПІДПИСОК =======");

            foreach (var factory in factories)
            {
                Console.WriteLine($"\n>>> Створення через: {factory.GetType().Name}");

                foreach (var type in types)
                {
                    try
                    {
                        ISubscription sub = factory.CreateSubscription(type);
                        Console.WriteLine($"[{type}] - Ціна: {sub.MonthlyFee} грн, Каналів: {sub.Channels.Count}");
                    }
                    catch (Exception ex)
                    {
                        // Тут ми побачимо помилку для MobileApp, де ми спеціально не додали educational
                        Console.WriteLine($"[{type}] - Помилка: {ex.Message}");
                    }
                }
            }

            Console.WriteLine("\n===========================================");
            Console.WriteLine("Натисніть будь-яку клавішу для виходу...");
            Console.ReadKey();
        }
    }
}