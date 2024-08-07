using static paradigm_shift_csharp.BatteryCheckerHelper;

namespace paradigm_shift_csharp
{
    internal class BatteryCheckerTests
{
    public static void BatteryCheckTests()
    {
        ExpectTrue(BatteryIsOk(25, 70, 0.7f));
        ExpectTrue(BatteryIsOk(0, 80, 0.7f));
        ExpectTrue(BatteryIsOk(45, 20, 0.7f));
        ExpectFalse(BatteryIsOk(-1, 80, 0.7f));
        ExpectFalse(BatteryIsOk(10, 85, 0.7f));
        ExpectFalse(BatteryIsOk(50, 70, 0.0f));
        ExpectFalse(BatteryIsOk(30, 70, 0.9f));
        Console.WriteLine("All ok");
    }

    private static void ExpectTrue(bool batteryCondition)
    {
        if (!batteryCondition) 
        {
            Console.WriteLine("Expected true, but got false");
        }
    }

    public static void ExpectFalse(bool expression)
    {
        if (expression)
        {
            Console.WriteLine("Expected false, but got true");
        }
    }
}
}
