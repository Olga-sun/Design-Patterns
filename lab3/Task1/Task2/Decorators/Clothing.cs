using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructuralPatternsLab.Task2.Interfaces;

namespace StructuralPatternsLab.Task2.Decorators
{
    public class Clothing : HeroDecorator
    {
        private string _clothingName;
        private int _defenseBonus;

        public Clothing(IHero hero, string clothingName, int defenseBonus) : base(hero)
        {
            _clothingName = clothingName;
            _defenseBonus = defenseBonus;
        }

        public override string GetDescription() => $"{_hero.GetDescription()} + одяг [{_clothingName}]";
        public override int GetDefense() => _hero.GetDefense() + _defenseBonus;
    }
}