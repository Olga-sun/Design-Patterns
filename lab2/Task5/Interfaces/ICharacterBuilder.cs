using System.Collections.Generic;
using Task5.Products;

namespace Task5.Interfaces
{
    public interface ICharacterBuilder
    {
        ICharacterBuilder Reset();
        ICharacterBuilder SetName(string name);
        ICharacterBuilder SetAppearance(string height, string bodyType, string hairColor, string eyeColor);
        ICharacterBuilder SetClothing(string clothing);
        ICharacterBuilder AddInventory(List<string> items);
        ICharacterBuilder PerformDeed(string deed); // Загальний метод для справ
        Character GetCharacter();
    }
}