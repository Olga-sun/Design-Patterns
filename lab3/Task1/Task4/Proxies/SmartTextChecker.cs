using System;
using StructuralPatternsLab.Task4.Interfaces;

namespace StructuralPatternsLab.Task4.Proxies
{
    public class SmartTextChecker : ITextReader
    {
        private readonly ITextReader _reader;

        public SmartTextChecker(ITextReader reader)
        {
            _reader = reader;
        }

        public char[][] ReadText(string filePath)
        {
            Console.WriteLine($"[SmartTextChecker]: Відкриття файлу '{filePath}'...");

            // Викликаємо реальний метод
            char[][] result = _reader.ReadText(filePath);

            Console.WriteLine($"[SmartTextChecker]: Файл успішно прочитано.");

            int lineCount = result.Length;
            int charCount = 0;

            foreach (var line in result)
            {
                charCount += line.Length;
            }

            Console.WriteLine($"[SmartTextChecker]: Загальна кількість рядків: {lineCount}");
            Console.WriteLine($"[SmartTextChecker]: Загальна кількість символів: {charCount}");
            Console.WriteLine($"[SmartTextChecker]: Закриття файлу '{filePath}'.");

            return result;
        }
    }
}