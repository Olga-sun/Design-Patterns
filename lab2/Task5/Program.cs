using System;
using Task5.Builders;
using Task5.Directors;
using Task5.Products;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Director director = new Director();

            // 1. Створюємо нашого героя
            HeroBuilder heroBuilder = new HeroBuilder();
            director.ConstructDreamHero(heroBuilder);
            Character dreamHero = heroBuilder.GetCharacter();
            dreamHero.ShowInfo();

            // 2. Створюємо ворога
            EnemyBuilder enemyBuilder = new EnemyBuilder();
            director.ConstructArchenemy(enemyBuilder);
            Character archenemy = enemyBuilder.GetCharacter();
            archenemy.ShowInfo();

            // 3. Демонстрація гнучкості Будівельника (можемо працювати без Директора)
            Console.WriteLine("\n=== КАСТОМНИЙ NPC (Без Директора) ===");
            HeroBuilder customBuilder = new HeroBuilder();
            customBuilder.Reset()
                         .SetName("Звичайний мандрівник")
                         .SetAppearance("Низький", "Худий", "Світле", "Блакитні")
                         .SetClothing("Плащ")
                         .AddInventory(new System.Collections.Generic.List<string> { "Карта", "Яблуко" });

            customBuilder.GetCharacter().ShowInfo();

            Console.ReadLine();
        }
    }
}