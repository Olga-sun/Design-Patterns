using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructuralPatternsLab.Task2.Interfaces;
namespace StructuralPatternsLab.Task2.Heroes
{
    public class Palladin : IHero
    {
        public string GetDescription() => "Паладин";
        public int GetAttack() => 15;
        public int GetDefense() => 15;
    }
}