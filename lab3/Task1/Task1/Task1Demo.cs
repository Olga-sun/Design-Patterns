
using StructuralPatternsLab.Task1.Adapters;
using StructuralPatternsLab.Task1.Interfaces;
using StructuralPatternsLab.Task1.Loggers;
using StructuralPatternsLab.Task1.Utils;
using System;

namespace StructuralPatternsLab.Task1
{
    public class Task1Demo
    {
        public static void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("--- Робота звичайного консольного логера ---");
            ILogger consoleLogger = new Logger();
            consoleLogger.Log("Програма успішно запущена.");
            consoleLogger.Warn("Зверніть увагу: налаштування за замовчуванням.");
            consoleLogger.Error("Не вдалося підключитися до бази даних!");

            Console.WriteLine("\n--- Робота файлового логера (через Адаптер) ---");

            // Використовуємо FileWriter з папки Utils
            FileWriter writer = new FileWriter("log_output.txt");

            // Використовуємо адаптер з папки Adapters
            ILogger fileLogger = new FileLoggerAdapter(writer);

            fileLogger.Log("Цей запис збережено у файл.");
            fileLogger.Warn("Попередження збережено у файл.");
            fileLogger.Error("Помилку записано у файл.");

            Console.WriteLine("Дані успішно записані у файл log_output.txt. Перевірте папку з проєктом.");
            Console.ReadLine();
        }
    }
}