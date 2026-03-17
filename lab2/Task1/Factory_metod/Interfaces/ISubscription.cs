using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Factory_metod.Interfaces
{
    public interface ISubscription
    {
        double MonthlyFee { get; }
        int MinimumPeriod { get; }     
        List<string> Channels { get; } 
    }
}