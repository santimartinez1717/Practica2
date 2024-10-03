using System;
namespace P2_PTP_SantiagoMartinezDie
{
    class City
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




        public void AddPoliceStation(PoliceStation station)
        {
            PoliceStations.Add(station);
        }
        public void RegisterLicense(Taxi car)
        {

            Taxis.Add(car);
            car.NewLicense();

        }
        public void WithdrawLicense(Taxi car)
        {
            Taxis.Remove(car);
            car.LoseLicense();
        }

    }
}