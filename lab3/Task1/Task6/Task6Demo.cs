using System;
using System.IO;
using StructuralPatternsLab.Task5.Enums;
using StructuralPatternsLab.Task5.Nodes;
using StructuralPatternsLab.Task6.Flyweight;

namespace StructuralPatternsLab.Task6
{
    public class Task6Demo
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Завдання 6: Легковаговик (Парсинг книги) ---\n");

            string bookPath = "book.txt";
            CreateMockBookIfNotExists(bookPath);
            string[] lines = File.ReadAllLines(bookPath);

            Console.WriteLine($"Прочитано {lines.Length} рядків з книги.\nБудуємо дерева...\n");

            // --- ТЕСТ 1: БЕЗ ЛЕГКОВАГОВИКА (Task 5) ---
            long memoryBeforeHeavy = GC.GetTotalMemory(true);
            LightElementNode heavyRoot = new LightElementNode("div", DisplayType.Block, ClosingType.Paired);
            ParseBookHeavy(lines, heavyRoot);
            long memoryAfterHeavy = GC.GetTotalMemory(true);
            double heavyMb = (memoryAfterHeavy - memoryBeforeHeavy) / 1048576.0; // Конвертуємо байти в Мегабайти

            Console.WriteLine($"Пам'ять БЕЗ Легковаговика: {heavyMb:F2} MB");

            // Очищаємо пам'ять перед другим тестом
            heavyRoot = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();

            // --- ТЕСТ 2: З ЛЕГКОВАГОВИКОМ (Task 6) ---
            long memoryBeforeFlyweight = GC.GetTotalMemory(true);
            FlyweightElementNode flyweightRoot = new FlyweightElementNode("div", DisplayType.Block, ClosingType.Paired);
            ParseBookFlyweight(lines, flyweightRoot);
            long memoryAfterFlyweight = GC.GetTotalMemory(true);
            double flyweightMb = (memoryAfterFlyweight - memoryBeforeFlyweight) / 1048576.0;

            Console.WriteLine($"Пам'ять З Легковаговиком:  {flyweightMb:F2} MB");

            // Результат
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nЕкономія оперативної пам'яті: {heavyMb - flyweightMb:F2} MB");
            Console.ResetColor();

            Console.WriteLine("\nНатисніть Enter для продовження...");
            Console.ReadLine();
        }

        // Парсинг за правилами за допомогою старого важкого вузла
        private static void ParseBookHeavy(string[] lines, LightElementNode root)
        {
            bool isFirst = true;
            foreach (string line in lines)
            {
                LightElementNode node;
                if (isFirst) { node = new LightElementNode("h1", DisplayType.Block, ClosingType.Paired); isFirst = false; }
                else if (line.Length < 20) node = new LightElementNode("h2", DisplayType.Block, ClosingType.Paired);
                else if (line.StartsWith(" ")) node = new LightElementNode("blockquote", DisplayType.Block, ClosingType.Paired);
                else node = new LightElementNode("p", DisplayType.Block, ClosingType.Paired);

                node.Add(new LightTextNode(line));
                root.Add(node);
            }
        }

        // Парсинг за правилами за допомогою оптимізованого вузла (Flyweight)
        private static void ParseBookFlyweight(string[] lines, FlyweightElementNode root)
        {
            bool isFirst = true;
            foreach (string line in lines)
            {
                FlyweightElementNode node;
                if (isFirst) { node = new FlyweightElementNode("h1", DisplayType.Block, ClosingType.Paired); isFirst = false; }
                else if (line.Length < 20) node = new FlyweightElementNode("h2", DisplayType.Block, ClosingType.Paired);
                else if (line.StartsWith(" ")) node = new FlyweightElementNode("blockquote", DisplayType.Block, ClosingType.Paired);
                else node = new FlyweightElementNode("p", DisplayType.Block, ClosingType.Paired);

                node.Add(new LightTextNode(line));
                root.Add(node);
            }
        }

        // Автоматична генерація тестової книги на 1 мільйон рядків!
        private static void CreateMockBookIfNotExists(string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("Створюємо тестову книгу на 1 000 000 рядків (зачекайте секунду)...");
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine("Romeo and Juliet"); // h1
                    for (int i = 0; i < 1000000; i++)
                    {
                        if (i % 10 == 0) writer.WriteLine("ACT " + (i / 10)); // h2 (менше 20 символів)
                        else if (i % 5 == 0) writer.WriteLine("  Dramatis Personae"); // blockquote (починається з пробілу)
                        else writer.WriteLine("ESCALUS, Prince of Verona. MERCUTIO, kinsman to the Prince."); // p
                    }
                }
            }
        }
    }
}