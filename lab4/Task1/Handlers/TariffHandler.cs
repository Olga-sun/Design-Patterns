using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Handlers
{
    public class TariffHandler : BaseHandler
    {
        public override void Handle()

        { 
            Console.WriteLine("Якщо ви хочете змінити тариф натисніть 1 інакше 0");
            string choice = Console.ReadLine();
            if (choice != null)
            {
                if (choice == "1")
                {
                    Console.WriteLine("Ваш тариф змінено");
                }
                else if (choice == "0")
                {
                    if (_nextHandler != null)
                    {
                        _nextHandler.Handle();
                    }
                    else
                    {
                      
                        Console.WriteLine("На жаль, ми не змогли розпізнати ваш запит. Зв'яжіться з нами пізніше.");
                    }
                }
            }
        }
    }
}
