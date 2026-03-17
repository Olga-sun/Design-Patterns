using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab1.Factory_metod.Interfaces;

namespace lab1.Factory_metod.Subscriptions
{
  public class PremiumSubscription : ISubscription
    {
        public double MonthlyFee => 200; 
        public int MinimumPeriod => 12;
        public List<string> Channels => new List<string> { "Всі канали", "4K Video", "Без реклами" };
    }
}
