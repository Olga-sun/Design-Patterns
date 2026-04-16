using System.IO;
using StructuralPatternsLab.Task4.Interfaces;

namespace StructuralPatternsLab.Task4.Readers
{
    public class SmartTextReader : ITextReader
    {
        public char[][] ReadText(string filePath)
        {
            // Читаємо всі рядки з файлу
            string[] lines = File.ReadAllLines(filePath);

            // Створюємо двомірний масив: зовнішній - рядки
            char[][] result = new char[lines.Length][];

            for (int i = 0; i < lines.Length; i++)
            {
                // Внутрішній - символи у відповідному рядку
                result[i] = lines[i].ToCharArray();
            }

            return result;
        }
    }
}