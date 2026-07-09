using System;
using lab4.Handlers;
using System.Text;

class Program
{

    static void Main(string[] args)

    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        // 1. Створюємо об'єкти кожного рівня
        CallRequestHandler callHandler = new CallRequestHandler();
        TariffHandler tariffHandler = new TariffHandler();
        TechSupportHandler techHandler = new TechSupportHandler();
        OperatorHandler operatorHandler = new OperatorHandler();

        // 2. Зв'язуємо їх у єдиний ланцюжок
        callHandler.SetNext(tariffHandler);
        tariffHandler.SetNext(techHandler);
        techHandler.SetNext(operatorHandler);

        // 3. Запускаємо ланцюжок з першого елемента
        callHandler.Handle();
    }
}