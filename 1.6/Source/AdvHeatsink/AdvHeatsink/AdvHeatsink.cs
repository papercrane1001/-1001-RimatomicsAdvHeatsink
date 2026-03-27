using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvHeatsink
{
    public class AdvCoolingSystem:Rimatomics.CoolingSystem
    {
        public override void Tick()
        {
            base.Tick();
            if (CoolingNet.CoolingLoopRatio > 0f)
            {
                //Bit of a hacky way to remove excessive fuel use
                fuel?.Refuel(WaterUsage / 60f);
                //fuel?.ConsumeFuel(WaterUsage / 60f);
            }
        }
    }
}
