using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructuralPatternsLab.Task2.Interfaces;
namespace StructuralPatternsLab.Task2.Heroes
{
    public class Warrior : IHero
    {
        public string GetDescription() { return "Воїн"; }
        public int GetAttack() { return 15; }
        public int GetDefense() { return 20; }
    }
}
