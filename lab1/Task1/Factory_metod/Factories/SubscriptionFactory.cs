using lab1.Factory_metod.Interfaces;

namespace lab1.Factory_metod.Factories
{
    public abstract class SubscriptionFactory
    {
        // Фабричний метод
        public abstract ISubscription CreateSubscription(string type);
    }
}