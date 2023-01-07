using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAB
{
    class CheckTargetForPredators : ICheckTarget
    {
        public bool CheckTarget(GameObject target, ObjectWhoCanLookAround animal)
        {
            if (target is Preys || animal.PairingTargetTest(target))
            {
                animal.target = target;
                return true;
            }
            return false;
        }
    }
}
