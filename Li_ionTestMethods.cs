namespace Simple_Monitor
{
    class Li_ionTestMethods : Li_ionBattries
    {
        static Li_ionBattries li_Ion = new Li_ionBattries();
        static int Main()
        {
            ExpectTrueTestMethod();
            ExpectFalseTestMethod();
            return 0;
        }

        private static void ExpectTrueTestMethod()
        {
            Expect(li_Ion.batteryIsOk(25, 70, 0.7f));
            string.Format("All ok").printMessage();
        }
        private static void ExpectFalseTestMethod()
        {
            Expect(li_Ion.batteryIsOk(50, 85, 0.0f));
            string.Format("All not ok").printMessage();
        }
    }
}
