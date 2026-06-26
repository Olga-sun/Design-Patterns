namespace DesignPatterns.Mediator
{
    class CommandCentre
    {
        private List<Runway> _runways = new List<Runway>();
    

        public CommandCentre(Runway[] runways)
        {
            this._runways.AddRange(runways);
            
        }

        public void RequestLanding(Aircraft aircraft)
        {
            Console.WriteLine($"CommandCentre: шукаю вільну смугу для літака {aircraft.Name}...");
            foreach (Runway runway in _runways)
            {
                if (runway.IsBusy == false) // Якщо смуга вільна
                {
                    runway.IsBusy = true; // Займаємо смугу
                    aircraft.CurrentRunway = runway; // Літак запам'ятовує, де він сів
                    runway.HighLightRed(); // Вмикаємо червоне світло
                    Console.WriteLine($"CommandCentre: Літак {aircraft.Name} успішно сів.");
                    return;
                }
            }
            Console.WriteLine($"CommandCentre: Усі смуги зайняті. Літак {aircraft.Name} очікує.");
        }

        public void RequestTakeOff(Aircraft aircraft)
        {
            Console.WriteLine($"CommandCentre: Літак {aircraft.Name} готується до зльоту...");
            if (aircraft.CurrentRunway != null)
            {
                aircraft.CurrentRunway.IsBusy = false; // Звільняємо смугу
                aircraft.CurrentRunway.HighLightGreen(); // Вмикаємо зелене світло
                aircraft.CurrentRunway = null; // Літак більше не на смузі
                Console.WriteLine($"CommandCentre: Літак {aircraft.Name} успішно злетів.");
            }
        }
    }
}