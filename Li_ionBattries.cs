namespace Simple_Monitor
{
    class Li_ionBattries : ILi_ionBattery
    {
        public bool batteryIsOk(float temperature, float soc, float chargeRate)
        {
            if (!temperatureCheck(temperature))
                return false;

            if (!socCheck(soc))
                return false;

            if (!chargeRateCheck(chargeRate))
                return false;

            return true;
        }
        public bool temperatureCheck(float temperature)
        {
            if (temperature < 0 || temperature > 45)
            {
                string.Format("Temperature {0} is out of range!", temperature).printMessage();
                return false;
            }
            return true;
        }
        public bool socCheck(float soc)
        {
            if (soc < 20 || soc > 80)
            {
                string.Format("State of Charge {0} is out of range!", soc).printMessage();
                return false;
            }
            return true;
        }
        public bool chargeRateCheck(float chargeRate)
        {
            if (chargeRate > 0.8)
            {
                string.Format("Charge Rate {0} is out of range!", chargeRate).printMessage();
                return false;
            }
            return true;
        }
    }
}
