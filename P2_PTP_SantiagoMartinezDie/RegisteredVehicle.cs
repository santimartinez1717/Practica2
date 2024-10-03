using System;
namespace P2_PTP_SantiagoMartinezDie

{
    abstract class RegisteredVehicle : Vehicle
    {
        private string typeOfVehicle;
        private string plate;

        public RegisteredVehicle(string typeOfVehicle, string plate) : base(typeOfVehicle)
        {
            this.typeOfVehicle = typeOfVehicle;
            this.plate = plate;
        }

        public override string ToString()
        {
            return $"{GetTypeOfVehicle()} with plate {GetPlate()}";
        }

        public virtual string GetPlate()
        {
            return plate;
        }
    }
}
