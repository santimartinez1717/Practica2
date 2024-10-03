using System;
namespace P2_PTP_SantiagoMartinezDie
{
    class PoliceCar : RegisteredVehicle
    {
        //constant string as TypeOfVehicle wont change allong PoliceCar instances
        private const string typeOfVehicle = "Police Car";
        private bool isPatrolling;
        private SpeedRadar? speedRadar;
        private bool isChasing;
        private PoliceStation policeStation;

        public PoliceCar(string plate, PoliceStation station, SpeedRadar? radar = null) : base(typeOfVehicle, plate)
        {
            isPatrolling = false;
            speedRadar =  radar;
            isChasing = false;
            policeStation = station;
        }

        public void UseRadar(Taxi vehicle)
        {
            if (isPatrolling)
            {
                if (speedRadar == null)
                {
                    Console.WriteLine(WriteMessage("No radar available."));
                }
                else
                {
                    speedRadar.TriggerRadar(vehicle);
                    string meassurement = speedRadar.GetLastReading();
                    Console.WriteLine(WriteMessage($"Triggered radar. Result: {meassurement}"));

                    if (speedRadar.IsOverSpeedLimit())
                    {
                        this.ChaseCar(vehicle);
                        isChasing = true;
                        policeStation.ActivateAlert(vehicle);

                    }
                }


            }
            else
            {
                Console.WriteLine(WriteMessage($"has no active radar."));
            }
        }

        public bool IsPatrolling()
        {
            return isPatrolling;
        }

        public void StartPatrolling()
        {
            if (!isPatrolling)
            {
                isPatrolling = true;
                Console.WriteLine(WriteMessage("started patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("is already patrolling."));
            }
        }

        public void EndPatrolling()
        {
            if (isPatrolling)
            {
                isPatrolling = false;
                Console.WriteLine(WriteMessage("stopped patrolling."));
            }
            else
            {
                Console.WriteLine(WriteMessage("was not patrolling."));
            }
        }
        public void ChaseCar(RegisteredVehicle vehicle)
        {
            if (!isChasing)
                Console.WriteLine(WriteMessage($"chasing vehicle with plate {vehicle.GetPlate()}."));
            isChasing = true;
        }

        public void PrintRadarHistory()
        {
            if (speedRadar != null)
            {
                Console.WriteLine(WriteMessage("Radar speed history report:"));
                foreach (float speed in speedRadar.SpeedHistory)
                {
                    Console.WriteLine(speed);
                }
            }
            else
            {
                Console.WriteLine(WriteMessage("No radar history available."));
            }
        }
    }
}