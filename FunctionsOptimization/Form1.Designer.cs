namespace FunctionsOptimization
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_A_param = new System.Windows.Forms.TextBox();
            this.textBox_B_param = new System.Windows.Forms.TextBox();
            this.textBox_C_param = new System.Windows.Forms.TextBox();
            this.textBox_D_param = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.radioButton_iteration_stop = new System.Windows.Forms.RadioButton();
            this.radioButton_accuracy_stop = new System.Windows.Forms.RadioButton();
            this.button_start = new System.Windows.Forms.Button();
            this.chart_function = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.radioButton_uniform_search = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_accuracy = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_number_steps = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_r_piyavsky = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_number_segments = new System.Windows.Forms.TextBox();
            this.radioButton_strongin = new System.Windows.Forms.RadioButton();
            this.radioButton_piyavsky = new System.Windows.Forms.RadioButton();
            this.richTextBox_log = new System.Windows.Forms.RichTextBox();
            this.chart_points = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox_r_strongin = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_drow_function = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart_function)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_points)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(776, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Параметры функции:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1003, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "A = ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1003, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "B = ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1201, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "D = ";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1201, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "C = ";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1314, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 6;
            // 
            // textBox_A_param
            // 
            this.textBox_A_param.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_A_param.Location = new System.Drawing.Point(1046, 129);
            this.textBox_A_param.Name = "textBox_A_param";
            this.textBox_A_param.Size = new System.Drawing.Size(65, 26);
            this.textBox_A_param.TabIndex = 7;
            this.textBox_A_param.Text = "1";
            // 
            // textBox_B_param
            // 
            this.textBox_B_param.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_B_param.Location = new System.Drawing.Point(1046, 168);
            this.textBox_B_param.Name = "textBox_B_param";
            this.textBox_B_param.Size = new System.Drawing.Size(65, 26);
            this.textBox_B_param.TabIndex = 8;
            this.textBox_B_param.Text = "1";
            // 
            // textBox_C_param
            // 
            this.textBox_C_param.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_C_param.Location = new System.Drawing.Point(1244, 129);
            this.textBox_C_param.Name = "textBox_C_param";
            this.textBox_C_param.Size = new System.Drawing.Size(65, 26);
            this.textBox_C_param.TabIndex = 9;
            this.textBox_C_param.Text = "1";
            // 
            // textBox_D_param
            // 
            this.textBox_D_param.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_D_param.Location = new System.Drawing.Point(1244, 168);
            this.textBox_D_param.Name = "textBox_D_param";
            this.textBox_D_param.Size = new System.Drawing.Size(65, 26);
            this.textBox_D_param.TabIndex = 10;
            this.textBox_D_param.Text = "1";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(776, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Границы отрезка:";
            // 
            // textBox_b
            // 
            this.textBox_b.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_b.Location = new System.Drawing.Point(1244, 237);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(65, 26);
            this.textBox_b.TabIndex = 15;
            this.textBox_b.Text = "2";
            // 
            // textBox_a
            // 
            this.textBox_a.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_a.Location = new System.Drawing.Point(1046, 237);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(65, 26);
            this.textBox_a.TabIndex = 14;
            this.textBox_a.Text = "0";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1201, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "b = ";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1003, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "a = ";
            // 
            // radioButton_iteration_stop
            // 
            this.radioButton_iteration_stop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_iteration_stop.AutoSize = true;
            this.radioButton_iteration_stop.Location = new System.Drawing.Point(46, 27);
            this.radioButton_iteration_stop.Name = "radioButton_iteration_stop";
            this.radioButton_iteration_stop.Size = new System.Drawing.Size(191, 24);
            this.radioButton_iteration_stop.TabIndex = 17;
            this.radioButton_iteration_stop.TabStop = true;
            this.radioButton_iteration_stop.Text = "Остановка по шагам";
            this.radioButton_iteration_stop.UseVisualStyleBackColor = true;
            // 
            // radioButton_accuracy_stop
            // 
            this.radioButton_accuracy_stop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_accuracy_stop.AutoSize = true;
            this.radioButton_accuracy_stop.Location = new System.Drawing.Point(46, 55);
            this.radioButton_accuracy_stop.Name = "radioButton_accuracy_stop";
            this.radioButton_accuracy_stop.Size = new System.Drawing.Size(213, 24);
            this.radioButton_accuracy_stop.TabIndex = 18;
            this.radioButton_accuracy_stop.TabStop = true;
            this.radioButton_accuracy_stop.Text = "Остановка по точности";
            this.radioButton_accuracy_stop.UseVisualStyleBackColor = true;
            // 
            // button_start
            // 
            this.button_start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_start.Location = new System.Drawing.Point(780, 885);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(597, 81);
            this.button_start.TabIndex = 19;
            this.button_start.Text = "Пуск";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // chart_function
            // 
            this.chart_function.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea1.Name = "ChartArea1";
            this.chart_function.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_function.Legends.Add(legend1);
            this.chart_function.Location = new System.Drawing.Point(42, 37);
            this.chart_function.Name = "chart_function";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_function.Series.Add(series1);
            this.chart_function.Size = new System.Drawing.Size(709, 640);
            this.chart_function.TabIndex = 20;
            this.chart_function.Text = "chart1";
            // 
            // radioButton_uniform_search
            // 
            this.radioButton_uniform_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_uniform_search.AutoSize = true;
            this.radioButton_uniform_search.Location = new System.Drawing.Point(46, 35);
            this.radioButton_uniform_search.Name = "radioButton_uniform_search";
            this.radioButton_uniform_search.Size = new System.Drawing.Size(183, 24);
            this.radioButton_uniform_search.TabIndex = 22;
            this.radioButton_uniform_search.TabStop = true;
            this.radioButton_uniform_search.Text = "Равномерная сетка";
            this.radioButton_uniform_search.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.textBox_accuracy);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBox_number_steps);
            this.groupBox1.Controls.Add(this.radioButton_iteration_stop);
            this.groupBox1.Controls.Add(this.radioButton_accuracy_stop);
            this.groupBox1.Location = new System.Drawing.Point(779, 374);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 108);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условие остановки";
            // 
            // textBox_accuracy
            // 
            this.textBox_accuracy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_accuracy.Location = new System.Drawing.Point(496, 55);
            this.textBox_accuracy.Name = "textBox_accuracy";
            this.textBox_accuracy.Size = new System.Drawing.Size(88, 26);
            this.textBox_accuracy.TabIndex = 28;
            this.textBox_accuracy.Text = "0,01";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(378, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "Точность:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(378, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 20);
            this.label12.TabIndex = 26;
            this.label12.Text = "Число шагов:";
            // 
            // textBox_number_steps
            // 
            this.textBox_number_steps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_number_steps.Location = new System.Drawing.Point(496, 25);
            this.textBox_number_steps.Name = "textBox_number_steps";
            this.textBox_number_steps.Size = new System.Drawing.Size(88, 26);
            this.textBox_number_steps.TabIndex = 19;
            this.textBox_number_steps.Text = "100";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox_r_strongin);
            this.groupBox2.Controls.Add(this.textBox_r_piyavsky);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textBox_number_segments);
            this.groupBox2.Controls.Add(this.radioButton_strongin);
            this.groupBox2.Controls.Add(this.radioButton_piyavsky);
            this.groupBox2.Controls.Add(this.radioButton_uniform_search);
            this.groupBox2.Location = new System.Drawing.Point(779, 503);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(598, 174);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выбор метода";
            // 
            // textBox_r_piyavsky
            // 
            this.textBox_r_piyavsky.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_r_piyavsky.Location = new System.Drawing.Point(465, 74);
            this.textBox_r_piyavsky.Name = "textBox_r_piyavsky";
            this.textBox_r_piyavsky.Size = new System.Drawing.Size(100, 26);
            this.textBox_r_piyavsky.TabIndex = 28;
            this.textBox_r_piyavsky.Text = "2";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(313, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 20);
            this.label14.TabIndex = 27;
            this.label14.Text = "Надёжность(r) = ";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(313, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Число отрезков:";
            // 
            // textBox_number_segments
            // 
            this.textBox_number_segments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_number_segments.Location = new System.Drawing.Point(465, 33);
            this.textBox_number_segments.Name = "textBox_number_segments";
            this.textBox_number_segments.Size = new System.Drawing.Size(100, 26);
            this.textBox_number_segments.TabIndex = 25;
            this.textBox_number_segments.Text = "100";
            // 
            // radioButton_strongin
            // 
            this.radioButton_strongin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_strongin.AutoSize = true;
            this.radioButton_strongin.Location = new System.Drawing.Point(46, 115);
            this.radioButton_strongin.Name = "radioButton_strongin";
            this.radioButton_strongin.Size = new System.Drawing.Size(170, 24);
            this.radioButton_strongin.TabIndex = 24;
            this.radioButton_strongin.TabStop = true;
            this.radioButton_strongin.Text = "Метод Стронгина";
            this.radioButton_strongin.UseVisualStyleBackColor = true;
            // 
            // radioButton_piyavsky
            // 
            this.radioButton_piyavsky.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_piyavsky.AutoSize = true;
            this.radioButton_piyavsky.Location = new System.Drawing.Point(46, 76);
            this.radioButton_piyavsky.Name = "radioButton_piyavsky";
            this.radioButton_piyavsky.Size = new System.Drawing.Size(169, 24);
            this.radioButton_piyavsky.TabIndex = 23;
            this.radioButton_piyavsky.TabStop = true;
            this.radioButton_piyavsky.Text = "Метод Пиявского";
            this.radioButton_piyavsky.UseVisualStyleBackColor = true;
            // 
            // richTextBox_log
            // 
            this.richTextBox_log.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox_log.Location = new System.Drawing.Point(780, 690);
            this.richTextBox_log.Name = "richTextBox_log";
            this.richTextBox_log.Size = new System.Drawing.Size(597, 189);
            this.richTextBox_log.TabIndex = 25;
            this.richTextBox_log.Text = "";
            // 
            // chart_points
            // 
            this.chart_points.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea2.Name = "ChartArea1";
            this.chart_points.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_points.Legends.Add(legend2);
            this.chart_points.Location = new System.Drawing.Point(42, 690);
            this.chart_points.Name = "chart_points";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_points.Series.Add(series2);
            this.chart_points.Size = new System.Drawing.Size(709, 276);
            this.chart_points.TabIndex = 26;
            this.chart_points.Text = "chart2";
            // 
            // textBox_r_strongin
            // 
            this.textBox_r_strongin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_r_strongin.Location = new System.Drawing.Point(466, 112);
            this.textBox_r_strongin.Name = "textBox_r_strongin";
            this.textBox_r_strongin.Size = new System.Drawing.Size(100, 26);
            this.textBox_r_strongin.TabIndex = 32;
            this.textBox_r_strongin.Text = "2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(775, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(588, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // button_drow_function
            // 
            this.button_drow_function.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_drow_function.Location = new System.Drawing.Point(775, 291);
            this.button_drow_function.Name = "button_drow_function";
            this.button_drow_function.Size = new System.Drawing.Size(602, 65);
            this.button_drow_function.TabIndex = 28;
            this.button_drow_function.Text = "Построить график";
            this.button_drow_function.UseVisualStyleBackColor = true;
            this.button_drow_function.Click += new System.EventHandler(this.button_drow_function_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Надёжность(r) = ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1410, 1006);
            this.Controls.Add(this.button_drow_function);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chart_points);
            this.Controls.Add(this.richTextBox_log);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart_function);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.textBox_b);
            this.Controls.Add(this.textBox_a);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_D_param);
            this.Controls.Add(this.textBox_C_param);
            this.Controls.Add(this.textBox_B_param);
            this.Controls.Add(this.textBox_A_param);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart_function)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_points)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_A_param;
        private System.Windows.Forms.TextBox textBox_B_param;
        private System.Windows.Forms.TextBox textBox_C_param;
        private System.Windows.Forms.TextBox textBox_D_param;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radioButton_iteration_stop;
        private System.Windows.Forms.RadioButton radioButton_accuracy_stop;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_function;
        private System.Windows.Forms.RadioButton radioButton_uniform_search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_strongin;
        private System.Windows.Forms.RadioButton radioButton_piyavsky;
        private System.Windows.Forms.RichTextBox richTextBox_log;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_number_segments;
        private System.Windows.Forms.TextBox textBox_accuracy;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_number_steps;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_points;
        private System.Windows.Forms.TextBox textBox_r_piyavsky;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_r_strongin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_drow_function;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

