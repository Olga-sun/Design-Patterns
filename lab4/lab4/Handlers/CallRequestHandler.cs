using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Handlers
{
    public class CallRequestHandler : BaseHandler
    {
        public override void Handle()
        {

            Console.WriteLine("Якщо ви хочете змінити абонплату написніть 1 інакше 2");
            string choice = Console.ReadLine();
            if (choice != null)
            {
                if (choice == "1")
                {
                    Console.WriteLine("Змінюємо абонентну плату");
                }
                else if (choice == "0")
                {
                    if (_nextHandler != null)
                    {
                        _nextHandler.Handle(); // Передаємо естафету йому
                    }
                    else
                    {
                        // Якщо це кінець ланцюжка і ніхто не зміг допомогти
                        Console.WriteLine("На жаль, ми не змогли розпізнати ваш запит. Зв'яжіться з нами пізніше.");
                    }
                }
               
        }
 
    } 
}}
