using System;

namespace Simple_Monitor
{
    internal class BatteryChecker
    {
        public static void Expect(bool expression)
        {
            if (expression)
                string.Format("Expected false, but got true").printMessage();
            else
                string.Format("Expected true, but got false").printMessage();
        }
    }
}