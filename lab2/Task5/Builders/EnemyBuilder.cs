using System.Collections.Generic;
using Task5.Interfaces;
using Task5.Products;

namespace Task5.Builders
{
    public class EnemyBuilder : ICharacterBuilder
    {
        private Character _character;

        public EnemyBuilder() { Reset(); }

        public ICharacterBuilder Reset()
        {
            _character = new Character { Type = "Найзапекліший Ворог" };
            return this;
        }

        public ICharacterBuilder SetName(string name) { _character.Name = name; return this; }
        public ICharacterBuilder SetAppearance(string height, string bodyType, string hairColor, string eyeColor)
        {
            _character.Height = height; _character.BodyType = bodyType;
            _character.HairColor = hairColor; _character.EyeColor = eyeColor;
            return this;
        }
        public ICharacterBuilder SetClothing(string clothing) { _character.Clothing = clothing; return this; }
        public ICharacterBuilder AddInventory(List<string> items) { _character.Inventory.AddRange(items); return this; }

        // Специфічна логіка: Ворог робить лише злі справи
        public ICharacterBuilder PerformDeed(string deed)
        {
            _character.EvilDeeds.Add(deed);
            return this;
        }

        public Character GetCharacter() => _character;
    }
}