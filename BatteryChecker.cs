using System;
using System.Diagnostics;
using Xunit;
using static paradigm_shift_csharp.BatteryCheckerHelper;

namespace paradigm_shift_csharp
{
    internal class BatteryChecker
    {
        static int Main()
        {
            Assert.True(BatteryIsOk(25, 70, 0.7f));
            Assert.True(BatteryIsOk(0, 80, 0.7f));
            Assert.True(BatteryIsOk(45, 20, 0.7f));
            Assert.False(BatteryIsOk(-1, 80, 0.7f));
            Assert.False(BatteryIsOk(10, 85, 0.7f));
            Assert.False(BatteryIsOk(50, 70, 0.0f));
            Assert.False(BatteryIsOk(30, 70, 0.9f));
            Console.WriteLine("All ok");
            return 0;
        }
    }
}
