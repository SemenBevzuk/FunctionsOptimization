using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunctionsOptimization
{
    class SearchInformationElement
    {
        private double x;
        private double y;
        public SearchInformationElement()
        {
            x = 0;
            y = 0;
        }
        public SearchInformationElement(double _x, double _y)
        {
            x = _x;
            y = _y;
        }
        public void SetPoint(double _x, double _y)
        {
            x = _x;
            y = _y;
        }
        public double GetPoint()
        {
            return x;
        }
        public double GetFunctionValue()
        {
            return y;
        }
    }

    class GeneralMethod
    {
        // Доступные поля
        public SearchInformationElement BestTrial;
        public List<double> list_of_test_points;
        public int measurement_counterer;

        // Приватные поля
        protected double a;
        protected double b;
        protected int r;
        protected double eps;
        protected FunkDelegate f;

        protected double M;
        protected double m;
        protected List<SearchInformationElement> list_of_Trials;
        protected List<double> list_of_interval_characteristic;
        protected int index_Max_Interval_Characteristic;
        protected int MAX_TRIALS = 10000;

        public virtual void Run()
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
                Calculate_M_and_m();
                Calculate_R();
                double new_point_x = Find_Next_Point();
                MakeTrial(new_point_x);
                list_of_test_points.Add(new_point_x);
            }
        }
        public virtual void Init(FunkDelegate _f, double left, double right,
                                 int _r = 2, double _eps = 0.01)
        {
            f = _f;
            a = left;
            b = right;
            r = _r;
            eps = _eps;
            BestTrial = new SearchInformationElement();
            list_of_Trials = new List<SearchInformationElement>();
            list_of_interval_characteristic = new List<double>();
            index_Max_Interval_Characteristic = 0;
            list_of_test_points = new List<double>();
            measurement_counterer = 0;
        }

        protected virtual void Calculate_M_and_m()
        {
            double tempM;
            for (int i = 1; i < list_of_Trials.Count; i++)
            {
                tempM = Math.Abs((list_of_Trials[i].GetFunctionValue() - list_of_Trials[i - 1].GetFunctionValue()) /
                                 (list_of_Trials[i].GetPoint() - list_of_Trials[i - 1].GetPoint()));
                if (tempM > M)
                {
                    M = tempM;
                }
            }

            if (M == 0)
                m = 1;
            if (M > 0)
                m = r * M;
        }
        protected void Calculate_R()
        {
            double max;
            list_of_interval_characteristic.Clear();

            SetIntervalCharacteristic(1);
            max = list_of_interval_characteristic[0];
            index_Max_Interval_Characteristic = 1;
            for (int i = 2; i < list_of_Trials.Count; i++)
            {
                SetIntervalCharacteristic(i);
                if (list_of_interval_characteristic[i - 1] > max)
                {
                    max = list_of_interval_characteristic[i - 1];
                    index_Max_Interval_Characteristic = i;
                }
            }
        }
        protected virtual void SetIntervalCharacteristic(int i) { }

        protected double Find_Next_Point()
        {
            double delta_x = list_of_Trials[index_Max_Interval_Characteristic].GetPoint()
                        + list_of_Trials[index_Max_Interval_Characteristic - 1].GetPoint();
            double delta_y = list_of_Trials[index_Max_Interval_Characteristic].GetFunctionValue()
                        - list_of_Trials[index_Max_Interval_Characteristic - 1].GetFunctionValue();
            double res = 0.5 * delta_x - 0.5 * (delta_y / m);

            return res;
        }
        protected virtual bool Need_Stop()
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

        protected void MakeTrial(double _x)
        {
            double value = f(_x);
            list_of_Trials.Add(new SearchInformationElement(_x, value));
            if (value < BestTrial.GetFunctionValue())
            {
                BestTrial.SetPoint(_x, value);
            }
            measurement_counterer++;
        }

        protected void quickSort(int l, int r)
        {
            double x = list_of_Trials[l + (r - l) / 2].GetPoint();
            int i = l;
            int j = r;
            while (i <= j)
            {
                while (list_of_Trials[i].GetPoint() < x) i++;
                while (list_of_Trials[j].GetPoint() > x) j--;
                if (i <= j)
                {
                    SearchInformationElement temp = list_of_Trials[i];
                    list_of_Trials[i] = list_of_Trials[j];
                    list_of_Trials[j] = temp;
                    i++;
                    j--;
                }
            }
            if (i < r)
                quickSort(i, r);

            if (l < j)
                quickSort(l, j);
        }

        protected void SortSearchInformation()
        {
            quickSort(0, list_of_Trials.Count - 1);
        }
    }
}
