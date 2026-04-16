using StructuralPatternsLab.Task1;
using StructuralPatternsLab.Task2;
using StructuralPatternsLab.Task3;
using StructuralPatternsLab.Task4;
using StructuralPatternsLab.Task5;
using StructuralPatternsLab.Task6;
using System;

namespace StructuralPatternsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("\n=== Лабораторна робота №3 ===");
                Console.WriteLine("1. Завдання 1 (Адаптер)");
                Console.WriteLine("2. Завдання 2 (Декоратор)");
                Console.WriteLine("3. Завдання 3 (Міст)");
                Console.WriteLine("4. Завдання 4 (Проксі)");
                Console.WriteLine("5. Завдання 5 (Компонувальник)");
                Console.WriteLine("6. Завдання 6 (Легковаговик)");
                Console.WriteLine("0. Вихід");
                Console.Write("Оберіть завдання: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Task1Demo.Run();// Викликаємо код з першої папки
                        break;
                    case "2":
                        Console.Clear();
                        Task2Demo.Run(); // Викликаємо код з другої папки
                        break;
                    case "3":                      // Новий кейс
                        Console.Clear();
                        Task3Demo.Run();
                        break;
                    case "4":
                        Console.Clear();
                        Task4Demo.Run();
                        break;
                    case "5":
                        Console.Clear();
                        Task5Demo.Run();
                        break;
                    case "6":
                        Console.Clear();
                        Task6Demo.Run();
                        break;
                    case "0":
                        return; // Вихід з програми
                    default:
                        Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                        break;
                }
            }
        }
    }
}