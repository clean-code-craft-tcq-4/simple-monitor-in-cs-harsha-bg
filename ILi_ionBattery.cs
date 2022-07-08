namespace Simple_Monitor
{
    interface ILi_ionBattery
    {
        public bool chargeRateCheck(float chargeRate);
        public bool socCheck(float soc);
        public bool temperatureCheck(float temperature);
    }
}
