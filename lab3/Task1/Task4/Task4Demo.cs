using System;
using System.IO;
using StructuralPatternsLab.Task4.Interfaces;
using StructuralPatternsLab.Task4.Readers;
using StructuralPatternsLab.Task4.Proxies;

namespace StructuralPatternsLab.Task4
{
    public class Task4Demo
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Завдання 4: Проксі (Робота з файлами) ---\n");

            // Підготовка: створюємо два тестових файли для перевірки
            string openFile = "public_data.txt";
            string secretFile = "secret_data.txt";
            File.WriteAllText(openFile, "Це публічний файл.\nВін має два рядки.");
            File.WriteAllText(secretFile, "Це секретний файл, його читати не можна!");

            // Створюємо базову читалку
            ITextReader realReader = new SmartTextReader();

            Console.WriteLine("=== 1. Перевірка SmartTextChecker (Логування) ===");
            // Обгортаємо читалку в логер
            ITextReader checkerProxy = new SmartTextChecker(realReader);
            checkerProxy.ReadText(openFile);


            Console.WriteLine("\n=== 2. Перевірка SmartTextReaderLocker (Обмеження доступу) ===");
            // Обгортаємо логер в обмежувач (регулярний вираз блокує всі файли, що містять "secret")
            // Таким чином ми комбінуємо обидва проксі!
            ITextReader lockerProxy = new SmartTextReaderLocker(checkerProxy, @"secret.*\.txt$");

            Console.WriteLine("\nСпроба прочитати дозволений файл:");
            lockerProxy.ReadText(openFile);

            Console.WriteLine("\nСпроба прочитати заборонений файл:");
            lockerProxy.ReadText(secretFile);

            Console.WriteLine("\nНатисніть Enter для продовження...");
            Console.ReadLine();
        }
    }
}