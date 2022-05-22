using System;

namespace Vehicles {
    class Vehicle {

        protected string sSPZ;
        protected float fMaxFuel;
        private float fConsumption;// L/100km
        private float fMaxSpeed;
        protected float fSpeed;
        protected float fFuel;
        protected float fDistanceDriven = 0.0f;

        public Vehicle(string sSPZ, float fMaxFuel, float fConsumption, float fMaxSpeed) {
            this.sSPZ = sSPZ;
            this.fMaxFuel = fMaxFuel;
            this.fConsumption = fConsumption;
            this.fMaxSpeed = fMaxSpeed;
            fFuel = fMaxFuel;
        }

        public string SPZ {
            get => sSPZ;
        }

        public float Fuel {
            get => fFuel;
        }
        public float FuelConsumption {
            get => fConsumption;
        }

        public float Speed {
            get => fSpeed;
            set {
                if (fSpeed + value > fMaxSpeed)
                    fSpeed = fMaxSpeed;
                else
                    fSpeed += value;
            }
        }

        public float DistanceDriven {
            get => fDistanceDriven;
        }

        public float MaxDistance {
            get => fFuel / (fConsumption / 100);
        }

        // Vrátí počet ujetých kilometrů
        protected float DriveDistance(float fDistance) {
            float maxDist = this.MaxDistance;
            if (this.MaxDistance < fDistance) {
                this.fFuel = 0.0f;
                return maxDist;
            } else {
                this.fFuel -= CalculateFuel(fDistance);
                return fDistance;
            }
        }

        // Vrátí počet doplněních litrů
        protected float RefuelLiters(float fLiters) {
            if (this.fFuel + fLiters > fMaxFuel) {
                float fFuelReplentish = this.fMaxFuel - this.fFuel;
                this.fFuel = fMaxFuel;
                return fFuelReplentish;
            } else {
                this.fFuel += fLiters;
                return fLiters;
            }

        }

        private float CalculateFuel(float fDistance) {
            return (fConsumption / 100) * fDistance;
        }

        public void Drive() {
            bool bSuccess;
            float fDistance;
            do {
                Console.Write("V nádrži máš {0}L. Můžeš maximálně ujet {1}km. Jak daleko chceš jet? --> ", Fuel, MaxDistance);
                bSuccess = float.TryParse(Console.ReadLine(), out fDistance);
            } while (!bSuccess);

            fDistance = DriveDistance(fDistance);
            this.fDistanceDriven += fDistance;
            Console.WriteLine("Auto s SPZ {0} ujelo {1}km", sSPZ, fDistance);
            Console.ReadKey();
        }

        public void Refuel() {
            bool bSuccess;
            float fLiters;
            do {
                Console.Write("V nádrži máš {0}L z {1}L. Kolik chceš dotankovat? --> ", Fuel, fMaxFuel);
                bSuccess = float.TryParse(Console.ReadLine(), out fLiters);
            } while (!bSuccess);

            fLiters = RefuelLiters(fLiters);
            Console.WriteLine("Auto s SPZ {0} dotankovalo {1}L", sSPZ, fLiters);
            Console.ReadKey();
        }
    }

    class Car : Vehicle {

        public string sBrand;

        public Car(string sSPZ, float fMaxFuel, float fConsumption, float fMaxSpeed, string sBrand) : base(sSPZ, fMaxFuel, fConsumption, fMaxSpeed) {
            this.sBrand = sBrand;
        }


        public new void Drive(float fDistance) {
            fDistance = DriveDistance(fDistance);
            this.fDistanceDriven += fDistance;
            Console.WriteLine("Auto s SPZ {0} značky {1} ujelo {2}km", sSPZ, sBrand, fDistance);
        }
    }
}
