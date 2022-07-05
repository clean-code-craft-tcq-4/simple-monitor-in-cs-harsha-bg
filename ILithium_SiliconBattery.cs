namespace Simple_Monitor
{
    interface ILithium_SiliconBattery : ILi_ionBattery
    {
        public bool DischargingControl(float volt);
        public bool ChargingControl(float volt);
    }
}
