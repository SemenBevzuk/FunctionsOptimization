using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsOptimization
{
    class UniformSearchMethod : GeneralMethod
    {
        public double uncertainty_interval;
        public double error;
        private int n; // число шагов
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
        }

        public override void Run()
        {
            BestTrial.SetPoint(a, f(a));
            MakeTrial(a);
            list_of_test_points.Add(a);
            double current_x = a;

            for (int i = 1; i < n; i++)
            {
                current_x = a + i * (b - a) / n;
                MakeTrial(current_x);
                list_of_test_points.Add(current_x);
            }

            uncertainty_interval = 2 * (b - a) / (n);
            error = (b - a) / (n);
        }
    }
}
