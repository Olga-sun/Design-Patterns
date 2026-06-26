
namespace DesignPatterns.Mediator
{
    class Aircraft
    {
        public string Name;
        public Runway? CurrentRunway { get; set; }
        public bool IsTakingOff { get; set; }

        private CommandCentre _commandCentre;
        public Aircraft(string name, CommandCentre commandCentre)
        {
            this.Name = name;
            this._commandCentre = commandCentre;
        }
        public void Land()
        {
            Console.WriteLine($"Aircraft {this.Name} is asking for landing.");
            _commandCentre.RequestLanding(this);
        }
        public void TakeOff()
        {
            Console.WriteLine($"Aircraft {this.Name} is asking for take off.");
            _commandCentre.RequestTakeOff(this);
        }
    }
}