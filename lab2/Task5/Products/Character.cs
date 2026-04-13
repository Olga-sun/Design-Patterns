using System;
using System.Collections.Generic;

namespace Task5.Products
{
    public class Character
    {
        public string Type { get; set; } // Герой чи Ворог
        public string Name { get; set; }
        public string Height { get; set; }
        public string BodyType { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string Clothing { get; set; }
        public List<string> Inventory { get; set; } = new List<string>();

        // Списки для добрих і злих справ (як вимагає завдання)
        public List<string> GoodDeeds { get; set; } = new List<string>();
        public List<string> EvilDeeds { get; set; } = new List<string>();

        public void ShowInfo()
        {
            Console.WriteLine($"\n=== {Type.ToUpper()}: {Name} ===");
            Console.WriteLine($"Зовнішність: {Height}, {BodyType}, волосся: {HairColor}, очі: {EyeColor}");
            Console.WriteLine($"Одяг: {Clothing}");
            Console.WriteLine($"Інвентар: {string.Join(", ", Inventory)}");

            if (GoodDeeds.Count > 0)
                Console.WriteLine($"Добрі справи: {string.Join(", ", GoodDeeds)}");
            if (EvilDeeds.Count > 0)
                Console.WriteLine($"Злі справи: {string.Join(", ", EvilDeeds)}");
        }
    }
}