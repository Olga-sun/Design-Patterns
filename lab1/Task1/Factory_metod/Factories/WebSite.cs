using lab1.Factory_metod.Interfaces;
using lab1.Factory_metod.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Factory_metod.Factories
{
    public class WebSite : SubscriptionFactory
    {
        public override ISubscription CreateSubscription(string type)
        {
            switch (type.ToLower())
            {
                case "domestic":
                    return new DomesticSubscription();
                case "educational":
                    return new EducationalSubscription();
                case "premium":
                    return new PremiumSubscription();
                default:
                    throw new ArgumentException("Невідомий тип");
            }
        }
    }
}
