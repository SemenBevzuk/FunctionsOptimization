using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsOptimization
{
    class StronginMethod : GeneralMethod
    {
        protected override void SetIntervalCharacteristic(int i)
        {
            double delta_x = list_of_Trials[i].GetPoint() - list_of_Trials[i - 1].GetPoint();
            double delta_y = list_of_Trials[i].GetFunctionValue() - list_of_Trials[i - 1].GetFunctionValue();
            double a = m * delta_x;
            double b = (delta_y * delta_y) / (m * delta_x);
            double c = 2*(list_of_Trials[i].GetFunctionValue() + list_of_Trials[i - 1].GetFunctionValue());

            list_of_interval_characteristic.Add(a + b - c);
        }
    }
}
