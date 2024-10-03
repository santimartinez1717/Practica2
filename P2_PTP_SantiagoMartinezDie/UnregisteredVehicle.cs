using System;
namespace P2_PTP_SantiagoMartinezDie
{
    abstract class UnregisteredVehicle : Vehicle
    {
        private string typeOfVehicle;

        public UnregisteredVehicle(string typeOfVehicle) : base(typeOfVehicle)
        {
            this.typeOfVehicle = typeOfVehicle;
        }

        public override string ToString()
        {
            return $"{GetTypeOfVehicle()} ";
        }


    }
}

