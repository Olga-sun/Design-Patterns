using System;
using System.Collections.Generic;

namespace Task4
{
    public interface IPrototype
    {
        // Метод Clone повертає новий екземпляр такого ж типу
        Virus Clone();
    }

    public class Virus : IPrototype
    {
        public double Weight { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        // Масив дітей (використовуємо List для зручності роботи з колекцією)
        public List<Virus> Children { get; set; }

        // Конструктор
        public Virus(double weight, int age, string name, string type)
        {
            Weight = weight;
            Age = age;
            Name = name;
            Type = type;
            Children = new List<Virus>(); // Ініціалізуємо порожній список при створенні
        }

        // Реалізація методу клонування
        public Virus Clone()
        {
            // Використовуємо вбудований механізм (MemberwiseClone)
            Virus clone = (Virus)this.MemberwiseClone();

            // 2. Робимо ГЛИБОКЕ копіювання для дітей (виконання пункту №4 завдання)
            // Якщо цього не зробити, клон і оригінал будуть ділити один і той самий масив дітей у пам'яті.
            clone.Children = new List<Virus>();

            foreach (var child in this.Children)
            {
                // Рекурсивно клонуємо кожну дитину і додаємо в новий масив клону
                clone.Children.Add(child.Clone());
            }

            return clone;
        }

        public void PrintFamilyTree(string indent = "")
        {
            Console.WriteLine($"{indent} Вірус '{Name}' [Вид: {Type} | Вік: {Age} | Вага: {Weight}]");
            foreach (var child in Children)
            {
                // Додаємо пробіли для візуального відображення поколінь
                child.PrintFamilyTree(indent + "   ");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // 1-ше покоління
            Virus grandParentVirus = new Virus(1.5, 10, "Alpha-01", "Коронавірус");

            // 2-ге покоління
            Virus parentVirus1 = new Virus(1.2, 5, "Beta-01", "Коронавірус-Мутант");
            Virus parentVirus2 = new Virus(1.3, 4, "Beta-02", "Коронавірус-Мутант");

            // 3-тє покоління
            Virus childVirus1 = new Virus(0.5, 1, "Gamma-01", "Коронавірус-Штам");
            Virus childVirus2 = new Virus(0.6, 1, "Gamma-02", "Коронавірус-Штам");
            Virus childVirus3 = new Virus(0.4, 0, "Gamma-03", "Коронавірус-Штам");

            // Будуємо родинні зв'язки
            parentVirus1.Children.Add(childVirus1);
            parentVirus1.Children.Add(childVirus2);
            parentVirus2.Children.Add(childVirus3);

            grandParentVirus.Children.Add(parentVirus1);
            grandParentVirus.Children.Add(parentVirus2);

            // --- ДЕМОНСТРАЦІЯ РОБОТИ ---
            Console.WriteLine("=== ОРИГІНАЛЬНА СІМ'Я ВІРУСІВ ===");
            grandParentVirus.PrintFamilyTree();

            Console.WriteLine("\n... Клонування головного вірусу ...\n");

            // Клонуємо дідуся (клонується все дерево)
            Virus clonedFamily = grandParentVirus.Clone();

            Console.WriteLine("=== СКЛОНОВАНА СІМ'Я ВІРУСІВ ===");
            clonedFamily.PrintFamilyTree();

            // --- ПЕРЕВІРКА ГЛИБОКОГО КОПІЮВАННЯ ---
            Console.WriteLine("\n=== ПЕРЕВІРКА (Змінюємо оригінал) ===");
            Console.WriteLine("Змінюємо ім'я оригіналу та додаємо йому нову дитину...");

            grandParentVirus.Name = "ОРИГІНАЛ-МУТАНТ";
            grandParentVirus.Children[0].Children[0].Name = "ЗМІНЕНА ДИТИНА"; // Змінюємо ім'я дитини в 3-му поколінні
            grandParentVirus.Children.Add(new Virus(0.1, 0, "Новий Несподіваний Вірус", "Невідомий"));

            Console.WriteLine("\nСтан ОРИГІНАЛУ після змін:");
            grandParentVirus.PrintFamilyTree();

            Console.WriteLine("\nСтан КЛОНУ після змін в оригіналі (має залишитись без змін!):");
            clonedFamily.PrintFamilyTree();

            Console.ReadLine();
        }
    }
}