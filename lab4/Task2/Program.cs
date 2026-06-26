using DesignPatterns.Mediator;
using System;
using System.Text;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Runway[] runway = { new Runway(), new Runway() };

            CommandCentre dispatcher= new CommandCentre(runway);
            Aircraft plane1 = new Aircraft("Boeing",dispatcher);
            plane1.Land();
            Aircraft planet2 = new Aircraft("MRIA", dispatcher);
            planet2.Land();
            Aircraft planet3 = new Aircraft("Airbus", dispatcher);
            planet3.Land();

        }
    }
}