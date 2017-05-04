using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunctionsOptimization
{
    class Function
    {
        private double A;
        private double B;
        private double C;
        private double D;

        public void SetFunction(double _A, double _B, double _C, double _D)
        {
            A = _A;
            B = _B;
            C = _C;
            D = _D;
        }

        public double FunctionValue(double x)
        {
            double y;
            y = A*Math.Sin(B*x) + C*Math.Cos(D*x);
            //y = A*x*x*x + B*x*x+C*x+D;
            return y;
        }
    }
}
