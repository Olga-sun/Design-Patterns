using System;

namespace DesignPatterns.Mediator
{
    public class Runway
    {
        public readonly Guid Id = Guid.NewGuid();

        // Ось наша нова змінна статусу!
        public bool IsBusy = false;

        public void HighLightRed()
        {
            Console.WriteLine($"Runway {this.Id} is busy!");
        }

        public void HighLightGreen()
        {
            Console.WriteLine($"Runway {this.Id} is free!");
        }
    }
}