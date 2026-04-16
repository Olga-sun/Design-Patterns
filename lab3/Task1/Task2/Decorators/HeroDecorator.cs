
using StructuralPatternsLab.Task2.Interfaces;
namespace StructuralPatternsLab.Task2.Decorators
{
    public abstract class HeroDecorator : IHero
    {
        protected IHero _hero;

        public HeroDecorator(IHero hero)
        {
            _hero = hero;
        }

        public virtual string GetDescription() => _hero.GetDescription();
        public virtual int GetAttack() => _hero.GetAttack();
        public virtual int GetDefense() => _hero.GetDefense();
    }
}