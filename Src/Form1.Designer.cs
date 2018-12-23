namespace Lab7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tbStart = new System.Windows.Forms.TextBox();
            this.tbEnd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.z2tbd = new System.Windows.Forms.TextBox();
            this.z2tbo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.z2tbr = new System.Windows.Forms.TextBox();
            this.z2b = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbBSr = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbStart
            // 
            this.tbStart.Location = new System.Drawing.Point(32, 36);
            this.tbStart.Margin = new System.Windows.Forms.Padding(2);
            this.tbStart.Name = "tbStart";
            this.tbStart.Size = new System.Drawing.Size(139, 20);
            this.tbStart.TabIndex = 0;
            // 
            // tbEnd
            // 
            this.tbEnd.Location = new System.Drawing.Point(184, 36);
            this.tbEnd.Margin = new System.Windows.Forms.Padding(2);
            this.tbEnd.Name = "tbEnd";
            this.tbEnd.Size = new System.Drawing.Size(139, 20);
            this.tbEnd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "До";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "От";
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(337, 70);
            this.bStart.Margin = new System.Windows.Forms.Padding(2);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(137, 32);
            this.bStart.TabIndex = 4;
            this.bStart.Text = "Начать";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(594, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "От";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(746, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "До";
            // 
            // z2tbd
            // 
            this.z2tbd.Location = new System.Drawing.Point(749, 36);
            this.z2tbd.Margin = new System.Windows.Forms.Padding(2);
            this.z2tbd.Name = "z2tbd";
            this.z2tbd.Size = new System.Drawing.Size(139, 20);
            this.z2tbd.TabIndex = 7;
            // 
            // z2tbo
            // 
            this.z2tbo.Location = new System.Drawing.Point(597, 36);
            this.z2tbo.Margin = new System.Windows.Forms.Padding(2);
            this.z2tbo.Name = "z2tbo";
            this.z2tbo.Size = new System.Drawing.Size(139, 20);
            this.z2tbo.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(900, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Размер массива";
            // 
            // z2tbr
            // 
            this.z2tbr.Location = new System.Drawing.Point(903, 36);
            this.z2tbr.Margin = new System.Windows.Forms.Padding(2);
            this.z2tbr.Name = "z2tbr";
            this.z2tbr.Size = new System.Drawing.Size(139, 20);
            this.z2tbr.TabIndex = 10;
            // 
            // z2b
            // 
            this.z2b.Location = new System.Drawing.Point(903, 70);
            this.z2b.Margin = new System.Windows.Forms.Padding(2);
            this.z2b.Name = "z2b";
            this.z2b.Size = new System.Drawing.Size(137, 32);
            this.z2b.TabIndex = 13;
            this.z2b.Text = "Начать";
            this.z2b.UseVisualStyleBackColor = true;
            this.z2b.Click += new System.EventHandler(this.z2b_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Размер массива";
            // 
            // tbBSr
            // 
            this.tbBSr.Location = new System.Drawing.Point(337, 36);
            this.tbBSr.Margin = new System.Windows.Forms.Padding(2);
            this.tbBSr.Name = "tbBSr";
            this.tbBSr.Size = new System.Drawing.Size(139, 20);
            this.tbBSr.TabIndex = 14;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(32, 107);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(444, 543);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(597, 107);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(445, 527);
            this.chart2.TabIndex = 17;
            this.chart2.Text = "chart2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 693);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbBSr);
            this.Controls.Add(this.z2b);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.z2tbr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.z2tbd);
            this.Controls.Add(this.z2tbo);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEnd);
            this.Controls.Add(this.tbStart);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbStart;
        private System.Windows.Forms.TextBox tbEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox z2tbd;
        private System.Windows.Forms.TextBox z2tbo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox z2tbr;
        private System.Windows.Forms.Button z2b;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbBSr;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}