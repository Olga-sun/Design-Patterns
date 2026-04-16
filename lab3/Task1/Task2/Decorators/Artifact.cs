using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructuralPatternsLab.Task2.Interfaces;

namespace StructuralPatternsLab.Task2.Decorators
{
    public class Artifact : HeroDecorator
    {
        private string _artifactName;
        private int _powerBonus;

        public Artifact(IHero hero, string artifactName, int powerBonus) : base(hero)
        {
            _artifactName = artifactName;
            _powerBonus = powerBonus;
        }

        public override string GetDescription() => $"{_hero.GetDescription()} + артефакт [{_artifactName}]";
        public override int GetAttack() => _hero.GetAttack() + _powerBonus;
        public override int GetDefense() => _hero.GetDefense() + _powerBonus;
    }
}
