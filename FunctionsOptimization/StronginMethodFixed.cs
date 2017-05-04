using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsOptimization
{
    class StronginMethodFixed : StronginMethod
    {
        public void Init(FunkDelegate _f, int max_steps, double left, double right, int _r = 2) 
        {
            f = _f;
            MAX_TRIALS = max_steps;
            a = left;
            b = right;
            r = _r;
            BestTrial = new SearchInformationElement();
            list_of_Trials = new List<SearchInformationElement>();
            list_of_interval_characteristic = new List<double>();
            index_Max_Interval_Characteristic = 0;
            list_of_test_points = new List<double>();
            measurement_counterer = 0;
        }
        protected override bool Need_Stop()
        {
            // ограничение на число испытаний
            if (list_of_Trials.Count == MAX_TRIALS)
            {
                return true;
            }
            return false;
        }
    }
}
