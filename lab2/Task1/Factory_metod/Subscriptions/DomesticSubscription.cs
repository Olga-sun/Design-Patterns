using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab1.Factory_metod.Interfaces;

namespace lab1.Factory_metod.Subscriptions
{
    public class DomesticSubscription : ISubscription
    {
        public double MonthlyFee => 120.50; // Твоя ціна
        public int MinimumPeriod => 1;      // Твій термін
        public List<string> Channels => new List<string> { "Discovery", "National Geographic" };
    }
}
