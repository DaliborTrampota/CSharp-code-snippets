using System;
using Vehicles;

class App {

    static void Main() {

        Car car = CreateCar();
        bool bContinue;
        do {
            Console.Clear();
            bContinue = Menu(ref car);
        } while(!bContinue);

        Console.ReadKey();
    }

    static bool Menu(ref Car car) {

        
        string sDistance = ("  Ujetá vzdálenost: " + car.DistanceDriven.ToString() + "km").PadRight(30);
        string sFuel = ("  Litrů paliva: " + car.Fuel + "L").PadRight(30);
        string sFuelConsumption = ("  Spotřeba paliva: " + car.FuelConsumption + "L/100km").PadRight(30);

        //šířka 30 + 2x |
        Console.WriteLine("+------------------------------+");
        Console.WriteLine("|          Statistiky          |");
        Console.WriteLine("+------------------------------+");
        Console.WriteLine("|{0}|", sDistance);
        Console.WriteLine("|{0}|", sFuel);
        Console.WriteLine("|{0}|", sFuelConsumption);
        Console.WriteLine("+------------------------------+");
        Console.WriteLine("|            Akce              |");
        Console.WriteLine("+------------------------------+");
        Console.WriteLine("|  1. Jet                      |");
        Console.WriteLine("|  2. Natankovat               |");
        Console.WriteLine("|  3. Zaparkovat               |");
        Console.WriteLine("+------------------------------+");
        Console.Write("\t--> ");

        short iOpt;
        bool bSuccess;
        do {
            bSuccess = short.TryParse(Console.ReadLine(), out iOpt);
        } while (!bSuccess);

        switch (iOpt) {
            case 1:
                car.Drive();
                return false;

            case 2:
                car.Refuel();
                return false;

            case 3:
                Park(car);
                return true;

            default:
                return false;
        }

    }

    static Car CreateCar() {

        string sSPZ, sBrand;
        float fMaxFuel, fConsumption, fMaxSpeed;
        bool bSuccess;

        Console.Write("Zadej SPZ vašeho auta --> ");
        sSPZ = Console.ReadLine();
        Console.Write("Zadej značku vašeho auta --> ");
        sBrand = Console.ReadLine();

        do {
            Console.Write("Zadej kapacitu nádrže --> ");
            bSuccess = float.TryParse(Console.ReadLine(), out fMaxFuel);
        } while (!bSuccess);

        do {
            Console.Write("Zadej spotřebu na 100km --> ");
            bSuccess = float.TryParse(Console.ReadLine(), out fConsumption);
        } while (!bSuccess);

        do {
            Console.Write("Zadej maximální rychlost auta --> ");
            bSuccess = float.TryParse(Console.ReadLine(), out fMaxSpeed);
        } while (!bSuccess);
        
        return new Car(sSPZ, fMaxFuel, fConsumption, fMaxSpeed, sBrand);
    }

    static void Park(Car car) {
        Console.WriteLine("Zaparkoval jsi auto s SPZ {0} značky {1}.", car.SPZ, car.sBrand);
    }


    /*static string PadRight(this string sText, short iWidth) {

        int iSpaces = sText.Length - iWidth;
        for (int i = 0; i < iSpaces; i++)
            sText += " ";

        return sText;
    }*/
}