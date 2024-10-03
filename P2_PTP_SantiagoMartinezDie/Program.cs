using P2_PTP_SantiagoMartinezDie;

namespace practica2_PTP
{
    internal class Program
    {
        static void Main()
        {
            // Creación de la ciudad
            City myCity = new City("Madrid");

            // Creación de la comisaría de policía
            PoliceStation policeStation1 = new PoliceStation("Comisaría Central", myCity);
            myCity.AddPoliceStation(policeStation1);

            // Registro de varios taxis en la ciudad
            Taxi taxi1 = new Taxi("0001 AAA");
            Taxi taxi2 = new Taxi("0002 BBB");
            Taxi taxi3 = new Taxi("0003 CCC");

            myCity.RegisterLicense(taxi1);
            myCity.RegisterLicense(taxi2);
            myCity.RegisterLicense(taxi3);

            // Registro de varios coches de policía
            SpeedRadar radar1 = new SpeedRadar();
            SpeedRadar radar2 = new SpeedRadar();
            SpeedRadar radar3 = new SpeedRadar();
            PoliceCar policeCar1 = new PoliceCar("0001 CNP", policeStation1, radar1); // con radar
            PoliceCar policeCar2 = new PoliceCar("0002 CNP", policeStation1, radar2);
            PoliceCar policeCar3 = new PoliceCar("0003 CNP", policeStation1, radar3);
            PoliceCar policeCar4 = new PoliceCar("0004 CNP", policeStation1); // sin radar

            policeStation1.RegisterPoliceCar(policeCar1);
            policeStation1.RegisterPoliceCar(policeCar2);
            policeStation1.RegisterPoliceCar(policeCar3);
            policeStation1.RegisterPoliceCar(policeCar4);

            // Inicio de patrullaje
            policeCar1.StartPatrolling();
            policeCar2.StartPatrolling();
            policeCar3.StartPatrolling();
            policeCar4.StartPatrolling();

            // Intento de utilizar el radar en un coche de policía que no tiene radar
            policeCar2.UseRadar(taxi1);

            // Uso del radar en un coche con radar
            taxi1.StartRide();
            policeCar1.UseRadar(taxi1);
        }
    }
}