namespace Simple_Monitor
{
    class checker : Li_ionBattries
    {
        static Li_ionBattries li_Ion = new Li_ionBattries();
        public static int Main()
        {
            ExpectTrueTestMethod();
            ExpectFalseTestMethod();
            return 0;
        }

        private static void ExpectTrueTestMethod()
        {
            BatteryChecker.Expect(li_Ion.batteryIsOk(25, 70, 0.7f));
            string.Format("All ok").printMessage();
        }
        private static void ExpectFalseTestMethod()
        {
            BatteryChecker.Expect(li_Ion.batteryIsOk(50, 85, 0.0f));
            string.Format("All not ok").printMessage();
        }
    }
}
