using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructuralPatternsLab.Task2.Interfaces;
namespace StructuralPatternsLab.Task2.Decorators
{
    public class Weapon : HeroDecorator
    {
        private string _weaponName;
        private int _attackBonus;

        public Weapon(IHero hero, string weaponName, int attackBonus) : base(hero)
        {
            _weaponName = weaponName;
            _attackBonus = attackBonus;
        }

        public override string GetDescription() => $"{_hero.GetDescription()} + зброя [{_weaponName}]";
        public override int GetAttack() => _hero.GetAttack() + _attackBonus;
    }
}