using System.Collections.Generic;
using Task5.Interfaces;

namespace Task5.Directors
{
    public class Director
    {
        // Метод для створення Героїні мрії
        public void ConstructDreamHero(ICharacterBuilder builder)
        {
            builder.Reset()
                   .SetName("Чародійка")
                   .SetAppearance("Середній зріст", "Спортивна", "Каштанове", "Голубі")
                   .SetClothing("Сарафан")
                   .AddInventory(new List<string> { "Ноутбук", "Зілля" })
                   .PerformDeed("Врятувала світ")
                   .PerformDeed("Зробила всі лаби");
        }

        // Метод для створення Ворога
        public void ConstructArchenemy(ICharacterBuilder builder)
        {
            builder.Reset()
                   .SetName("Лінька")
                   .SetAppearance("Височезний", "Кремезний", "Чорне", "Червоні")
                   .SetClothing("Темна піксельна броня")
                   .AddInventory(new List<string> { "Блоки TNT", "Зілля шкоди" })
                   .PerformDeed("Зруйнував чужу базу")
                   .PerformDeed("Стер збереження гри");
        }
    }
}