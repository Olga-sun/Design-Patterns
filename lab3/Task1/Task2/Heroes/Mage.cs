
using StructuralPatternsLab.Task2.Interfaces;
namespace StructuralPatternsLab.Task2.Heroes
{
    public class Mage : IHero
    {
        public string GetDescription() => "Маг";
        public int GetAttack() => 25;
        public int GetDefense() => 5;
    }
}