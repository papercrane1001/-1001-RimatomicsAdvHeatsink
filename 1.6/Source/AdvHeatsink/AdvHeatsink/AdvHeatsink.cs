using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvHeatsink
{
    public class AdvCoolingSystem:Rimatomics.CoolingTower
    {
        public override void Tick()
        {
            base.Tick();
            if (CoolingNet.CoolingLoopRatio > 0f)
            {
                fuel?.Refuel(WaterUsage / 60f);
                //fuel?.ConsumeFuel(WaterUsage / 60f);
            }
        }
    }
}
