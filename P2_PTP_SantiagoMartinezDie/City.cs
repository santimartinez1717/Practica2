using System;
namespace P2_PTP_SantiagoMartinezDie

{
    class City : IMessageWritter
    {
        public string name;
        public List<PoliceStation> PoliceStations { get; private set; }
        public List<Taxi> Taxis { get; private set; }
        public City(string name)
        {
            this.name = name;
            PoliceStations = new List<PoliceStation>();
            Taxis = new List<Taxi>();
        }

        public string GetName()
        {
            return this.name;
        }

        public override string ToString()
        {
            return $"City  {GetName()}";
        }



        public void AddPoliceStation(PoliceStation station)
        {
            PoliceStations.Add(station);
            Console.WriteLine(WriteMessage($"station {station.name} is in the city"));
        }
        public void RegisterLicense(Taxi car)
        {

            Taxis.Add(car);
            Console.WriteLine(WriteMessage($"taxi with  plate {car.GetPlate()} has had his license registered"));
            car.NewLicense();

        }
        public void WithdrawLicense(Taxi car)
        {
            Taxis.Remove(car);
            Console.WriteLine(WriteMessage($"taxi with  plate {car.GetPlate()} has had his license withdrawn"));
            car.LoseLicense();
        }
        public string WriteMessage(string message)
        {
            return $"{this}: {message}";
        }
    }
}

