using System;
using System.Text.RegularExpressions;
using StructuralPatternsLab.Task4.Interfaces;

namespace StructuralPatternsLab.Task4.Proxies
{
    public class SmartTextReaderLocker : ITextReader
    {
        private readonly ITextReader _reader;
        private readonly Regex _regex;

        public SmartTextReaderLocker(ITextReader reader, string regexPattern)
        {
            _reader = reader;
            _regex = new Regex(regexPattern);
        }

        public char[][] ReadText(string filePath)
        {
            // Якщо ім'я файлу співпадає з регулярним виразом заборони
            if (_regex.IsMatch(filePath))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Access denied!");
                Console.ResetColor();
                return null; // Або можна повернути порожній масив: new char[0][]
            }
            else
            {
                // Якщо все добре, передаємо роботу далі
                return _reader.ReadText(filePath);
            }
        }
    }
}