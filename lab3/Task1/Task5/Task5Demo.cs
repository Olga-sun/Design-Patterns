using System;
using System.Collections.Generic;
using StructuralPatternsLab.Task5.Nodes;
using StructuralPatternsLab.Task5.Enums;

namespace StructuralPatternsLab.Task5
{
    public class Task5Demo
    {
        public static void Run()
        {
            Console.WriteLine("\n--- Завдання 5: Компонувальник (LightHTML) ---\n");

            // Створюємо головний контейнер
            LightElementNode div = new LightElementNode("div", DisplayType.Block, ClosingType.Paired, new List<string> { "container", "main-box" });

            // Створюємо заголовок
            LightElementNode h1 = new LightElementNode("h1", DisplayType.Block, ClosingType.Paired);
            h1.Add(new LightTextNode("Моя перша сторінка на LightHTML!"));

            // Створюємо список
            LightElementNode ul = new LightElementNode("ul", DisplayType.Block, ClosingType.Paired, new List<string> { "menu", "styled" });

            LightElementNode li1 = new LightElementNode("li", DisplayType.Block, ClosingType.Paired);
            li1.Add(new LightTextNode("Перший пункт"));

            LightElementNode li2 = new LightElementNode("li", DisplayType.Block, ClosingType.Paired);
            li2.Add(new LightTextNode("Другий пункт"));

            ul.Add(li1);
            ul.Add(li2);

            // Створюємо картинку (одинарний тег)
            LightElementNode img = new LightElementNode("img", DisplayType.Inline, ClosingType.Single, new List<string> { "avatar", "rounded" });

            // Збираємо все до купи (додаємо в головний div)
            div.Add(h1);
            div.Add(ul);
            div.Add(img);

            Console.WriteLine("=== Вивід OuterHTML всього DIV контейнера ===");
            Console.WriteLine(div.OuterHTML());

            Console.WriteLine("=== Вивід InnerHTML тільки для списку UL ===");
            Console.WriteLine(ul.InnerHTML());
            Console.WriteLine(); // Пустий рядок для краси

            Console.WriteLine("Натисніть Enter для продовження...");
            Console.ReadLine();
        }
    }
}