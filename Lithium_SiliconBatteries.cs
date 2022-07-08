using System;

namespace Simple_Monitor
{
    class Lithium_SiliconBatteries : ILithium_SiliconBattery
    {
        public bool batteryIsOk(float temperature, float soc, float chargeRate, float doc, float coc)
        {
            throw new NotImplementedException();
        }
        public bool socCheck(float soc)
        {
            throw new NotImplementedException();
        }
        public bool temperatureCheck(float temperature)
        {
            throw new NotImplementedException();
        }
        public bool chargeRateCheck(float chargeRate)
        {
            throw new NotImplementedException();
        }
        public bool ChargingControl(float volt)
        {
            throw new NotImplementedException();
        }
        public bool DischargingControl(float volt)
        {
            throw new NotImplementedException();
        }
    }
}
