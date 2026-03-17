using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab1.Factory_metod.Interfaces;

namespace lab1.Factory_metod.Subscriptions
{
    public class EducationalSubscription : ISubscription
    {
        public double MonthlyFee => 50; 
        public int MinimumPeriod => 3;      // Твій термін
        public List<string> Channels => new List<string> { "Discovery", "History", "National Geographic" };
    }
}
