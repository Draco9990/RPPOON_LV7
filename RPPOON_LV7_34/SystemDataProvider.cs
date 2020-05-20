using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV7_34
{
    class SystemDataProvider : SimpleSystemDataProvider
    {
        private float previousCPULoad;
        private float previousRAMAvailable;
        public SystemDataProvider() : base()
        {
            this.previousCPULoad = this.CPULoad;
            this.previousRAMAvailable = this.AvailableRAM;
        }
        public float GetCPULoad()
        {
            float currentLoad = this.CPULoad;
            if (Math.Abs(currentLoad-previousCPULoad)<=10/*currentLoad != this.previousCPULoad*/)
            {
                this.Notify();
            }
            this.previousCPULoad = currentLoad;
            return currentLoad;
        }
        public float GetAvailableRAM()
        {
            float availableRAM = this.AvailableRAM;
            float diff = previousRAMAvailable * 0.1f;
            if (availableRAM > previousRAMAvailable + diff || availableRAM < previousRAMAvailable - diff/*availableRAM != this.previousRAMAvailable*/)
            {
                this.Notify();
            }
            this.previousRAMAvailable = availableRAM;
            return availableRAM;
        }
    }
}
