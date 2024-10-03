using System;
namespace P2_PTP_SantiagoMartinezDie
{
    class Scooter : UnregisteredVehicle
    {
        private static string typeOfVehicle = "Scooter";

        public Scooter() : base(typeOfVehicle)  // Los patinetes no tienen matrícula
        {
            SetSpeed(15.0f); // La velocidad inicial del patinete
        }

        public void StartRide()
        {
            SetSpeed(25.0f); // Aumenta la velocidad durante el viaje
            Console.WriteLine(WriteMessage("starts riding."));
        }

        public void StopRide()
        {
            SetSpeed(0.0f); // El patinete se detiene
            Console.WriteLine(WriteMessage("stopped riding."));
        }

    }
}
