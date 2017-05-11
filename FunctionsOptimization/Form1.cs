using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FunctionsOptimization
{
    delegate double FunkDelegate(double X);

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            chart_function.Legends.Clear();
            chart_points.Legends.Clear();
            pictureBox1.Load("../../function.jpg");
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            //try
            //{
            Function Func = new Function();
            Func.SetFunction(Convert.ToDouble(textBox_A_param.Text), Convert.ToDouble(textBox_B_param.Text),
                Convert.ToDouble(textBox_C_param.Text), Convert.ToDouble(textBox_D_param.Text));
            FunkDelegate function = Func.FunctionValue;

            DrawObjectiveFunction(chart_function, function);

            chart_points.Series.Clear();
            chart_points.Legends.Clear();
            //chart_points.ChartAreas[0].AxisX.Enabled = AxisEnabled.False; // отображение подписей по ОХ в точках
            Series SeriesOfPointsTests = new Series("Испытания");
            SeriesOfPointsTests.ChartType = SeriesChartType.Line;
            SeriesOfPointsTests.Color = Color.Red;
            SeriesOfPointsTests.BorderWidth = 1;
            double y = 0;
            double y_delta = 0.1; // шаг вверх для визуализации точек испытаний
            SeriesOfPointsTests.Points.AddXY(Convert.ToDouble(textBox_a.Text),0);
            SeriesOfPointsTests.Points.AddXY(Convert.ToDouble(textBox_b.Text),0);


            if (radioButton_uniform_search.Checked)
            {
                if (!radioButton_iteration_stop.Checked && !radioButton_accuracy_stop.Checked)
                    richTextBox_log.AppendText("Не выбрано условие остановки.\n");
                if (radioButton_accuracy_stop.Checked)
                {
                    UniformSearchMethodEps usm_eps = new UniformSearchMethodEps();
                    usm_eps.Init(function, Convert.ToDouble(textBox_a.Text), Convert.ToDouble(textBox_b.Text),
                        Convert.ToDouble(textBox_accuracy.Text));
                    usm_eps.Run();

                    for (int i = 0; i < usm_eps.list_of_test_points.Count; i++)
                    {
                        SeriesOfPointsTests.Points.AddXY(usm_eps.list_of_test_points[i], y);
                        y = y + y_delta;
                    }

                    richTextBox_log.AppendText("Равномерная сетка по точности: \n");
                    richTextBox_log.AppendText("    Min x = " + usm_eps.BestTrial.GetPoint() + "\n");
                    richTextBox_log.AppendText("    Min Func = " + usm_eps.BestTrial.GetFunctionValue() + "\n");
                    //richTextBox_log.AppendText("    Интервал неопределенности = " + usm.uncertainty_interval + "\n");
                    richTextBox_log.AppendText("    Погрешность = " + usm_eps.error + "\n");
                    richTextBox_log.AppendText("    Число измерений функции = " + usm_eps.measurement_counterer + "\n");
                    richTextBox_log.AppendText("\n");
                }
                if (radioButton_iteration_stop.Checked)
                {
                    UniformSearchMethod usm = new UniformSearchMethod();
                    usm.Init(function, Convert.ToDouble(textBox_a.Text), Convert.ToDouble(textBox_b.Text),
                        Convert.ToInt32(textBox_number_steps.Text));
                    usm.Run();

                    for (int i = 0; i < usm.list_of_test_points.Count; i++)
                    {
                        SeriesOfPointsTests.Points.AddXY(usm.list_of_test_points[i], y);
                        y = y + y_delta;
                    }

                    richTextBox_log.AppendText("Равномерная сетка по шагам: \n");
                    richTextBox_log.AppendText("    Min x = " + usm.BestTrial.GetPoint() + "\n");
                    richTextBox_log.AppendText("    Min Func = " + usm.BestTrial.GetFunctionValue() + "\n");
                    //richTextBox_log.AppendText("    Интервал неопределенности = " + usm.uncertainty_interval + "\n");
                    richTextBox_log.AppendText("    Погрешность = " + usm.error + "\n");
                    richTextBox_log.AppendText("    Число измерений функции = " + usm.measurement_counterer + "\n");
                    richTextBox_log.AppendText("\n");
                }
            }

            if (radioButton_piyavsky.Checked)
            {
                if (!radioButton_iteration_stop.Checked && !radioButton_accuracy_stop.Checked)
                    richTextBox_log.AppendText("Не выбрано условие остановки.\n");
                if (radioButton_accuracy_stop.Checked)
                {
                    PiyavskyMethod pm = new PiyavskyMethod();
                    pm.Init(function, Convert.ToDouble(textBox_a.Text), Convert.ToDouble(textBox_b.Text),
                        Convert.ToInt32(textBox_r_piyavsky.Text), Convert.ToDouble(textBox_accuracy.Text));
                    pm.Run();

                    for (int i = 0; i < pm.list_of_test_points.Count; i++)
                    {
                        SeriesOfPointsTests.Points.AddXY(pm.list_of_test_points[i], y);
                        y = y + y_delta;
                    }
                    richTextBox_log.AppendText("Пиявский c остановкой по точности: \n");
                    richTextBox_log.AppendText("    Min x = " + pm.BestTrial.GetPoint() + "\n");
                    richTextBox_log.AppendText("    Min Func = " + pm.BestTrial.GetFunctionValue() + "\n");
                    richTextBox_log.AppendText("    Число измерений функции = " + pm.measurement_counterer + "\n");
                    richTextBox_log.AppendText("\n");
                }
                if (radioButton_iteration_stop.Checked)
                {
                    PiyavskyMethodFixed pm = new PiyavskyMethodFixed();
                    pm.Init(function, Convert.ToInt32(textBox_number_steps.Text),
                        Convert.ToDouble(textBox_a.Text), Convert.ToDouble(textBox_b.Text),
                        Convert.ToInt32(textBox_r_piyavsky.Text));
                    pm.Run();

                    for (int i = 0; i < pm.list_of_test_points.Count; i++)
                    {
                        SeriesOfPointsTests.Points.AddXY(pm.list_of_test_points[i], y);
                        y = y + y_delta;
                    }
                    richTextBox_log.AppendText("Пиявский с фиксированным числом шагов: \n");
                    richTextBox_log.AppendText("    Min x = " + pm.BestTrial.GetPoint() + "\n");
                    richTextBox_log.AppendText("    Min Func = " + pm.BestTrial.GetFunctionValue() + "\n");
                    richTextBox_log.AppendText("    Число измерений функции = " + pm.measurement_counterer + "\n");
                    richTextBox_log.AppendText("\n");
                }
            }

            if (radioButton_strongin.Checked)
            {
                if (!radioButton_iteration_stop.Checked && !radioButton_accuracy_stop.Checked)
                    richTextBox_log.AppendText("Не выбрано условие остановки.\n");
                if (radioButton_accuracy_stop.Checked)
                {
                    StronginMethod sm = new StronginMethod();
                    sm.Init(function, Convert.ToDouble(textBox_a.Text), Convert.ToDouble(textBox_b.Text),
                            Convert.ToInt32(textBox_r_piyavsky.Text), Convert.ToDouble(textBox_accuracy.Text));
                    sm.Run();


                    for (int i = 0; i < sm.list_of_test_points.Count; i++)
                    {
                        SeriesOfPointsTests.Points.AddXY(sm.list_of_test_points[i], y);
                        y = y + y_delta;
                    }
                    richTextBox_log.AppendText("Стронгин: \n");
                    richTextBox_log.AppendText("    Min x = " + sm.BestTrial.GetPoint() + "\n");
                    richTextBox_log.AppendText("    Min Func = " + sm.BestTrial.GetFunctionValue() + "\n");
                    richTextBox_log.AppendText("    Число измерений функции = " + sm.measurement_counterer + "\n");
                    richTextBox_log.AppendText("\n");
                }
                if (radioButton_iteration_stop.Checked)
                {
                    StronginMethodFixed sm = new StronginMethodFixed();
                    sm.Init(function, Convert.ToInt32(textBox_number_steps.Text),
                        Convert.ToDouble(textBox_a.Text), Convert.ToDouble(textBox_b.Text),
                        Convert.ToInt32(textBox_r_piyavsky.Text));
                    sm.Run();

                    for (int i = 0; i < sm.list_of_test_points.Count; i++)
                    {
                        SeriesOfPointsTests.Points.AddXY(sm.list_of_test_points[i], y);
                        y = y + y_delta;
                    }
                    richTextBox_log.AppendText("Стронгин с фиксированным числом шагов: \n");
                    richTextBox_log.AppendText("    Min x = " + sm.BestTrial.GetPoint() + "\n");
                    richTextBox_log.AppendText("    Min Func = " + sm.BestTrial.GetFunctionValue() + "\n");
                    richTextBox_log.AppendText("    Число измерений функции = " + sm.measurement_counterer + "\n");
                    richTextBox_log.AppendText("\n");
                }
            }

            chart_points.Series.Add(SeriesOfPointsTests);
            richTextBox_log.SelectionStart = richTextBox_log.Text.Length;
            richTextBox_log.ScrollToCaret();
            //}
            //catch (Exception error)
            //{
            //    MessageBox.Show(error.Message);
            //}
        }
        private void button_drow_function_Click(object sender, EventArgs e)
        {
            try
            {
                Function Func = new Function();
                Func.SetFunction(Convert.ToDouble(textBox_A_param.Text), Convert.ToDouble(textBox_B_param.Text),
                    Convert.ToDouble(textBox_C_param.Text), Convert.ToDouble(textBox_D_param.Text));
                FunkDelegate function = Func.FunctionValue;

                DrawObjectiveFunction(chart_function, function);
                richTextBox_log.AppendText("График построен.\n");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void DrawObjectiveFunction(object sender, FunkDelegate f)
        {
            var myChart = sender as Chart;
            myChart.Series.Clear();
            Series SeriesOfPoints = new Series("Целевая функция");
            SeriesOfPoints.ChartType = SeriesChartType.Line;
            SeriesOfPoints.Color = Color.Black;
            SeriesOfPoints.BorderWidth = 1;
            for (double i = Convert.ToDouble(textBox_a.Text);
                 i < Convert.ToDouble(textBox_b.Text); i = i + 0.01)
            {
                SeriesOfPoints.Points.AddXY(i, f(i));
            }
            myChart.Series.Add(SeriesOfPoints);
        }

        private void CheckFunction()
        {
            double num = 0.0;
            double a = 0.0;
            double b = 0.0;
            if (double.TryParse(textBox_A_param.Text, out num) &&
                double.TryParse(textBox_B_param.Text, out num) &&
                double.TryParse(textBox_C_param.Text, out num) &&
                double.TryParse(textBox_D_param.Text, out num))
            {
                richTextBox_log.Text = "Параметры функции корректны.\n";
            }
            else
            {
                richTextBox_log.Text = "Ошибка в параметрах функции!\n";
                throw new Exception("Ошибка в параметрах функции!");
            }

            if (double.TryParse(textBox_a.Text, out num) &&
                double.TryParse(textBox_a.Text, out num) &&
                (b > a))
            {
                richTextBox_log.Text = "Отрезок корректный.\n";
            }
            else
            {
                richTextBox_log.Text = "Ошибка в границах отрезка!\n";
                throw new Exception("Ошибка в границах отрезка!");
            }
        }
    }
}
