using System;
using System.Diagnostics;
namespace paradigm_shift_csharp
{
class Checker
    {
        static bool BatteryIsOk(float temperature, float soc, float chargeRate)
        {
            return IsTemperatureOk(temperature) && IsSocOk(soc) && IsChargeRateOk(chargeRate);
        }

        static bool IsTemperatureOk(float temperature)
        {
            if (temperature < 0)
            {
                Console.WriteLine("Temperature is too low!");
                return false;
            }
            else if(temperature > 45)
            {
                Console.WriteLine("Temperature is too high!");
                return false;
            }

            return true;
        }

        static bool IsSocOk(float soc)
        {
            if (soc < 20)
            {
                Console.WriteLine("State of Charge is too low!");
                return false;
            }
            else if (soc > 80)
            {
                Console.WriteLine("State of Charge is too high!");
                return false;
            }

            return true;
        }

        static bool IsChargeRateOk(float chargeRate)
        {
            if (chargeRate > 0.8)
            {
                Console.WriteLine("Charge Rate is out of range!");
                return false;
            }

            return true;
        }

        static void ExpectTrue(bool expression)
        {
            if (!expression)
            {
                Console.WriteLine("Expected true, but got false");
                Environment.Exit(1);
            }
        }
        static void ExpectFalse(bool expression)
        {
            if (expression)
            {
                Console.WriteLine("Expected false, but got true");
                Environment.Exit(1);
            }
        }
        static int Main()
        {
            ExpectTrue(BatteryIsOk(25, 70, 0.7f));
            ExpectTrue(BatteryIsOk(0, 80, 0.7f));
            ExpectTrue(BatteryIsOk(45, 20, 0.7f));
            ExpectFalse(BatteryIsOk(-1, 80, 0.7f));
            ExpectFalse(BatteryIsOk(10, 85, 0.7f));
            ExpectFalse(BatteryIsOk(50, 70, 0.0f));
            ExpectFalse(BatteryIsOk(30, 70, 0.9f));
            Console.WriteLine("All ok");
            return 0;
        }

    }
}
