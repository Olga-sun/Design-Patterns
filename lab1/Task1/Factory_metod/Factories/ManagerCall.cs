using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab1.Factory_metod.Interfaces;
using lab1.Factory_metod.Subscriptions;

namespace lab1.Factory_metod.Factories
{
    public class ManagerCall : SubscriptionFactory
    {
        public override ISubscription CreateSubscription(string type)
        {
            // Використовуємо класичний switch для сумісності з C# 7.3
            switch (type.ToLower())
            {
                case "domestic":
                    return new DomesticSubscription();
                case "educational":
                    return new EducationalSubscription();
                case "premium":
                    return new PremiumSubscription();
                default:
                    throw new ArgumentException("Менеджер не знайшов таку підписку");
            }
        }
    }
}
