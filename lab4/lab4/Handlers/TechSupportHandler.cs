using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Handlers
{
    public class TechSupportHandler : BaseHandler
    {
                public override void Handle()
        {
            Console.WriteLine("Якщо ви хочете зв'язатися з технічною підтримкою натисніть 1 інакше 0");
            string choice = Console.ReadLine();
            if (choice != null)
            {
                if (choice == "1")
                {
                    Console.WriteLine("Зв'язуємося з технічною підтримкою");
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
