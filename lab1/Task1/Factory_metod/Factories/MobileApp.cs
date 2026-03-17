using lab1.Factory_metod.Interfaces;
using lab1.Factory_metod.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Factory_metod.Factories
{
    public class MobileApp : SubscriptionFactory
    {
        public override ISubscription CreateSubscription(string type)
        {
        
            switch (type.ToLower())
            {
                case "domestic":
                    return new DomesticSubscription();
                case "premium":
                    return new PremiumSubscription();
                default:
                    throw new ArgumentException("Цей тип недоступний у додатку");
            }
        }
    }
}
