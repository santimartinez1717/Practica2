using System;
namespace P2_PTP_SantiagoMartinezDie
{
    class PoliceStation
    {
        public string name;
        public List<PoliceCar> PoliceCars { get; private set; }
        public City city;

        public PoliceStation(string name, City newCity)
        {
            this.name = name;
            PoliceCars = new List<PoliceCar>();
            city = newCity;


        }


        public void RegisterPoliceCar(PoliceCar car)
        {
            PoliceCars.Add(car);
        }

        public void ActivateAlert(Taxi infractor)
        {
            foreach (var car in PoliceCars)
            {
                if (car.IsPatrolling())
                {
                    Console.WriteLine(car.WriteMessage($"has been advised of the infraction {infractor.GetPlate()}."));
                    car.ChaseCar(infractor);
                }
            }
            city.WithdrawLicense(infractor);
        }


    }
}