
using StructuralPatternsLab.Task2.Interfaces;
using StructuralPatternsLab.Task2.Heroes;
using StructuralPatternsLab.Task2.Decorators;
using System;
namespace StructuralPatternsLab.Task2
{
    public class Task2Demo
    {
        public static void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;


            Console.WriteLine("\n\n--- Завдання 2: Декоратор (RPG Гра) ---");

            IHero myMage = new Mage();
            PrintHeroStats(myMage, "Створено базового Мага:");

            myMage = new Clothing(myMage, "Мантія Невидимки", defenseBonus: 10);
            PrintHeroStats(myMage, "Маг одягнув мантію:");

            myMage = new Weapon(myMage, "Посох Вогню", attackBonus: 20);
            PrintHeroStats(myMage, "Маг взяв посох:");

            myMage = new Artifact(myMage, "Кільце Сили", powerBonus: 5);
            PrintHeroStats(myMage, "Маг знайшов артефакт:");

            Console.WriteLine("\n--- Інший приклад ---");
            // Ми можемо обгорнути героя в усі предмети одразу в один рядок:
            IHero palladin = new Artifact(
                                new Weapon(
                                    new Clothing(new Palladin(), "Важка броня", 25),
                                "Святий Меч", 15),
                             "Амулет Світла", 10);

            PrintHeroStats(palladin, "Паладин у повному екіпіруванні:");

            Console.ReadLine();
        }

        static void PrintHeroStats(IHero hero, string action)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n{action}");
            Console.ResetColor();
            Console.WriteLine($"Опис:  {hero.GetDescription()}");
            Console.WriteLine($"Атака: {hero.GetAttack()} | Захист: {hero.GetDefense()}");
        }
    }
}