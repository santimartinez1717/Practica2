using System;
namespace P2_PTP_SantiagoMartinezDie
{
    class PoliceStation : IMessageWritter
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
        public string GetName()
        {
            return this.name;
        }

        public override string ToString()
        {
            return $"Police station  {GetName()}";
        }

        public void RegisterPoliceCar(PoliceCar car)
        {
            PoliceCars.Add(car);
            Console.WriteLine(WriteMessage($"police car with plate {car.GetPlate()} registered in this "));
        }

        public void ActivateAlert(Taxi infractor)
        {
            Console.WriteLine(WriteMessage($"Alert: vehicle with plate {infractor.GetPlate()} caught above legal speed."));
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

        public string WriteMessage(string message)
        {
            return $"{this}: {message}";
        }
    }
}

