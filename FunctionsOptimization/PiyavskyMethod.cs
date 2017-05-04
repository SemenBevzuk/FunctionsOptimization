using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsOptimization
{
    class PiyavskyMethod : GeneralMethod
    {
        protected override void SetIntervalCharacteristic(int i)
        {
            double a = 0.5 * m * (list_of_Trials[i].GetPoint() - list_of_Trials[i - 1].GetPoint());
            double b = 0.5 * (list_of_Trials[i].GetFunctionValue() +
                            list_of_Trials[i - 1].GetFunctionValue());
            list_of_interval_characteristic.Add(a - b);
        }
    }
}
