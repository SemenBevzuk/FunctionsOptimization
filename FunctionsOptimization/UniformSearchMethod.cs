using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsOptimization
{
    class UniformSearchMethod : GeneralMethod
    {
        public double error;
        protected int n; // число шагов
        public  void Init(FunkDelegate _f, double left, double right, int _n)
        {
            f = _f;
            a = left;
            b = right;
            n = _n;
            BestTrial = new SearchInformationElement();
            list_of_Trials = new List<SearchInformationElement>();
            list_of_test_points = new List<double>();
            measurement_counterer = 0;

            list_of_interval_characteristic = new List<double>();
            index_Max_Interval_Characteristic = 0;
        }
        public override void Run()
        {
            BestTrial.SetPoint(a, f(a));
            MakeTrial(a);
            MakeTrial(b);
            list_of_test_points.Add(a);
            list_of_test_points.Add(b);
            index_Max_Interval_Characteristic = 1;

            while (!Need_Stop())
            {
                SortSearchInformation();
                Calculate_R();
                double new_point_x = Find_Next_Point();
                MakeTrial(new_point_x);
                list_of_test_points.Add(new_point_x);
            }
        }
        protected override void SetIntervalCharacteristic(int i)
        {
            double delta_x = list_of_Trials[i].GetPoint() - list_of_Trials[i - 1].GetPoint();
            list_of_interval_characteristic.Add(delta_x);
        }
        protected double Find_Next_Point()
        {
            double delta_x = list_of_Trials[index_Max_Interval_Characteristic].GetPoint()
                        + list_of_Trials[index_Max_Interval_Characteristic - 1].GetPoint();
            double res = 0.5 * delta_x;

            return res;
        }
        protected override bool Need_Stop()
        {
            // ограничение на число испытаний
            if (list_of_Trials.Count == n)
            {
                return true;
            }
            return false;
        }
    }
}
