using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsOptimization
{
    class UniformSearchMethodEps:UniformSearchMethod
    {
        public  void Init(FunkDelegate _f, double left, double right, double _eps)
        {
            f = _f;
            a = left;
            b = right;
            eps = _eps;
            BestTrial = new SearchInformationElement();
            list_of_Trials = new List<SearchInformationElement>();
            list_of_test_points = new List<double>();
            measurement_counterer = 0;

            list_of_interval_characteristic = new List<double>();
            index_Max_Interval_Characteristic = 0;
        }
        protected override bool Need_Stop()
        {
            // ограничение на число испытаний
            if (list_of_Trials.Count == MAX_TRIALS)
            {
                return true;
            }

            // остановка по точности
            double x1 = list_of_Trials[index_Max_Interval_Characteristic].GetPoint();
            double x0 = list_of_Trials[index_Max_Interval_Characteristic - 1].GetPoint();
            if ((x1 - x0) < eps)
            {
                return true;
            }
            return false;
        }
    }
}
