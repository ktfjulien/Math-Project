using System.Drawing;

namespace Math_Project {
    partial class Quadratic {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        

        public void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quadratic));
            this.ALabel = new System.Windows.Forms.Label();
            this.ATextBox = new System.Windows.Forms.TextBox();
            this.BTextBox = new System.Windows.Forms.TextBox();
            this.BLabel = new System.Windows.Forms.Label();
            this.CTextBox = new System.Windows.Forms.TextBox();
            this.CLabel = new System.Windows.Forms.Label();
            this.SolveButton = new System.Windows.Forms.Button();
            this.AOSLabel = new System.Windows.Forms.Label();
            this.AOSTextBox = new System.Windows.Forms.TextBox();
            this.VertexLabel = new System.Windows.Forms.Label();
            this.VertexTextBox = new System.Windows.Forms.TextBox();
            this.DiscriminantLabel = new System.Windows.Forms.Label();
            this.DiscriminantTextBox = new System.Windows.Forms.TextBox();
            this.NumOfZeroesLabel = new System.Windows.Forms.Label();
            this.NumOfZeroesTextBox = new System.Windows.Forms.TextBox();
            this.SolutionsLabel = new System.Windows.Forms.Label();
            this.SolutionsTextBox = new System.Windows.Forms.TextBox();
            this.FactorsTextBox = new System.Windows.Forms.TextBox();
            this.FactorsLabel = new System.Windows.Forms.Label();
            this.YMinLabel = new System.Windows.Forms.Label();
            this.YMinTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.YMaxTextBox = new System.Windows.Forms.TextBox();
            this.XMinLabel = new System.Windows.Forms.Label();
            this.XMaxLabel = new System.Windows.Forms.Label();
            this.XMinTextBox = new System.Windows.Forms.TextBox();
            this.XMaxTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GetXTextBox = new System.Windows.Forms.TextBox();
            this.GetYTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.QuadraticChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.QuadraticChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ALabel
            // 
            this.ALabel.AutoSize = true;
            this.ALabel.Location = new System.Drawing.Point(113, 31);
            this.ALabel.Name = "ALabel";
            this.ALabel.Size = new System.Drawing.Size(22, 13);
            this.ALabel.TabIndex = 0;
            this.ALabel.Text = "a =";
            // 
            // ATextBox
            // 
            this.ATextBox.Location = new System.Drawing.Point(149, 28);
            this.ATextBox.Name = "ATextBox";
            this.ATextBox.Size = new System.Drawing.Size(106, 20);
            this.ATextBox.TabIndex = 1;
            this.ATextBox.TextChanged += new System.EventHandler(this.AnythingTextChanged);
            // 
            // BTextBox
            // 
            this.BTextBox.Location = new System.Drawing.Point(149, 72);
            this.BTextBox.Name = "BTextBox";
            this.BTextBox.Size = new System.Drawing.Size(106, 20);
            this.BTextBox.TabIndex = 3;
            this.BTextBox.TextChanged += new System.EventHandler(this.AnythingTextChanged);
            // 
            // BLabel
            // 
            this.BLabel.AutoSize = true;
            this.BLabel.Location = new System.Drawing.Point(113, 75);
            this.BLabel.Name = "BLabel";
            this.BLabel.Size = new System.Drawing.Size(22, 13);
            this.BLabel.TabIndex = 2;
            this.BLabel.Text = "b =";
            // 
            // CTextBox
            // 
            this.CTextBox.Location = new System.Drawing.Point(149, 116);
            this.CTextBox.Name = "CTextBox";
            this.CTextBox.Size = new System.Drawing.Size(106, 20);
            this.CTextBox.TabIndex = 5;
            this.CTextBox.TextChanged += new System.EventHandler(this.AnythingTextChanged);
            // 
            // CLabel
            // 
            this.CLabel.AutoSize = true;
            this.CLabel.Location = new System.Drawing.Point(113, 119);
            this.CLabel.Name = "CLabel";
            this.CLabel.Size = new System.Drawing.Size(22, 13);
            this.CLabel.TabIndex = 4;
            this.CLabel.Text = "c =";
            // 
            // SolveButton
            // 
            this.SolveButton.Location = new System.Drawing.Point(135, 451);
            this.SolveButton.Name = "SolveButton";
            this.SolveButton.Size = new System.Drawing.Size(75, 23);
            this.SolveButton.TabIndex = 6;
            this.SolveButton.Text = "Solve";
            this.SolveButton.UseVisualStyleBackColor = true;
            this.SolveButton.Click += new System.EventHandler(this.SolveButton_Click);
            // 
            // AOSLabel
            // 
            this.AOSLabel.AutoSize = true;
            this.AOSLabel.Location = new System.Drawing.Point(21, 210);
            this.AOSLabel.Name = "AOSLabel";
            this.AOSLabel.Size = new System.Drawing.Size(89, 13);
            this.AOSLabel.TabIndex = 7;
            this.AOSLabel.Text = "Axis of Symmetry:";
            // 
            // AOSTextBox
            // 
            this.AOSTextBox.Location = new System.Drawing.Point(171, 207);
            this.AOSTextBox.Name = "AOSTextBox";
            this.AOSTextBox.ReadOnly = true;
            this.AOSTextBox.Size = new System.Drawing.Size(178, 20);
            this.AOSTextBox.TabIndex = 8;
            this.AOSTextBox.Enter += new System.EventHandler(this.DontFocus);
            // 
            // VertexLabel
            // 
            this.VertexLabel.AutoSize = true;
            this.VertexLabel.Location = new System.Drawing.Point(21, 243);
            this.VertexLabel.Name = "VertexLabel";
            this.VertexLabel.Size = new System.Drawing.Size(40, 13);
            this.VertexLabel.TabIndex = 9;
            this.VertexLabel.Text = "Vertex:";
            // 
            // VertexTextBox
            // 
            this.VertexTextBox.Location = new System.Drawing.Point(171, 239);
            this.VertexTextBox.Name = "VertexTextBox";
            this.VertexTextBox.ReadOnly = true;
            this.VertexTextBox.Size = new System.Drawing.Size(178, 20);
            this.VertexTextBox.TabIndex = 10;
            this.VertexTextBox.Enter += new System.EventHandler(this.DontFocus);
            // 
            // DiscriminantLabel
            // 
            this.DiscriminantLabel.AutoSize = true;
            this.DiscriminantLabel.Location = new System.Drawing.Point(21, 276);
            this.DiscriminantLabel.Name = "DiscriminantLabel";
            this.DiscriminantLabel.Size = new System.Drawing.Size(67, 13);
            this.DiscriminantLabel.TabIndex = 11;
            this.DiscriminantLabel.Text = "Discriminant:";
            // 
            // DiscriminantTextBox
            // 
            this.DiscriminantTextBox.Location = new System.Drawing.Point(171, 273);
            this.DiscriminantTextBox.Name = "DiscriminantTextBox";
            this.DiscriminantTextBox.ReadOnly = true;
            this.DiscriminantTextBox.Size = new System.Drawing.Size(178, 20);
            this.DiscriminantTextBox.TabIndex = 12;
            this.DiscriminantTextBox.Enter += new System.EventHandler(this.DontFocus);
            // 
            // NumOfZeroesLabel
            // 
            this.NumOfZeroesLabel.AutoSize = true;
            this.NumOfZeroesLabel.Location = new System.Drawing.Point(21, 308);
            this.NumOfZeroesLabel.Name = "NumOfZeroesLabel";
            this.NumOfZeroesLabel.Size = new System.Drawing.Size(143, 13);
            this.NumOfZeroesLabel.TabIndex = 13;
            this.NumOfZeroesLabel.Text = "Number of Zeroes/Solutions:";
            // 
            // NumOfZeroesTextBox
            // 
            this.NumOfZeroesTextBox.Location = new System.Drawing.Point(171, 305);
            this.NumOfZeroesTextBox.Name = "NumOfZeroesTextBox";
            this.NumOfZeroesTextBox.ReadOnly = true;
            this.NumOfZeroesTextBox.Size = new System.Drawing.Size(178, 20);
            this.NumOfZeroesTextBox.TabIndex = 14;
            this.NumOfZeroesTextBox.Enter += new System.EventHandler(this.DontFocus);
            // 
            // SolutionsLabel
            // 
            this.SolutionsLabel.AutoSize = true;
            this.SolutionsLabel.Location = new System.Drawing.Point(21, 373);
            this.SolutionsLabel.Name = "SolutionsLabel";
            this.SolutionsLabel.Size = new System.Drawing.Size(97, 13);
            this.SolutionsLabel.TabIndex = 15;
            this.SolutionsLabel.Text = "Solution(s)/Zero(s):";
            // 
            // SolutionsTextBox
            // 
            this.SolutionsTextBox.AllowDrop = true;
            this.SolutionsTextBox.Location = new System.Drawing.Point(171, 369);
            this.SolutionsTextBox.Name = "SolutionsTextBox";
            this.SolutionsTextBox.ReadOnly = true;
            this.SolutionsTextBox.Size = new System.Drawing.Size(178, 20);
            this.SolutionsTextBox.TabIndex = 16;
            this.SolutionsTextBox.Enter += new System.EventHandler(this.DontFocus);
            // 
            // FactorsTextBox
            // 
            this.FactorsTextBox.AllowDrop = true;
            this.FactorsTextBox.Location = new System.Drawing.Point(171, 337);
            this.FactorsTextBox.Name = "FactorsTextBox";
            this.FactorsTextBox.ReadOnly = true;
            this.FactorsTextBox.Size = new System.Drawing.Size(178, 20);
            this.FactorsTextBox.TabIndex = 18;
            this.FactorsTextBox.Click += new System.EventHandler(this.DontFocus);
            // 
            // FactorsLabel
            // 
            this.FactorsLabel.AutoSize = true;
            this.FactorsLabel.Location = new System.Drawing.Point(21, 341);
            this.FactorsLabel.Name = "FactorsLabel";
            this.FactorsLabel.Size = new System.Drawing.Size(45, 13);
            this.FactorsLabel.TabIndex = 17;
            this.FactorsLabel.Text = "Factors:";
            // 
            // YMinLabel
            // 
            this.YMinLabel.AutoSize = true;
            this.YMinLabel.Location = new System.Drawing.Point(447, 417);
            this.YMinLabel.Name = "YMinLabel";
            this.YMinLabel.Size = new System.Drawing.Size(37, 13);
            this.YMinLabel.TabIndex = 20;
            this.YMinLabel.Text = "Y-Min:";
            // 
            // YMinTextBox
            // 
            this.YMinTextBox.Location = new System.Drawing.Point(490, 413);
            this.YMinTextBox.Name = "YMinTextBox";
            this.YMinTextBox.Size = new System.Drawing.Size(100, 20);
            this.YMinTextBox.TabIndex = 21;
            this.YMinTextBox.TextChanged += new System.EventHandler(this.YMinTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Y-Max:";
            // 
            // YMaxTextBox
            // 
            this.YMaxTextBox.Location = new System.Drawing.Point(490, 439);
            this.YMaxTextBox.Name = "YMaxTextBox";
            this.YMaxTextBox.Size = new System.Drawing.Size(100, 20);
            this.YMaxTextBox.TabIndex = 23;
            this.YMaxTextBox.TextChanged += new System.EventHandler(this.YMaxTextBox_TextChanged);
            // 
            // XMinLabel
            // 
            this.XMinLabel.AutoSize = true;
            this.XMinLabel.Location = new System.Drawing.Point(666, 417);
            this.XMinLabel.Name = "XMinLabel";
            this.XMinLabel.Size = new System.Drawing.Size(37, 13);
            this.XMinLabel.TabIndex = 24;
            this.XMinLabel.Text = "X-Min:";
            // 
            // XMaxLabel
            // 
            this.XMaxLabel.AutoSize = true;
            this.XMaxLabel.Location = new System.Drawing.Point(666, 443);
            this.XMaxLabel.Name = "XMaxLabel";
            this.XMaxLabel.Size = new System.Drawing.Size(40, 13);
            this.XMaxLabel.TabIndex = 25;
            this.XMaxLabel.Text = "X-Max:";
            // 
            // XMinTextBox
            // 
            this.XMinTextBox.Location = new System.Drawing.Point(714, 413);
            this.XMinTextBox.Name = "XMinTextBox";
            this.XMinTextBox.Size = new System.Drawing.Size(100, 20);
            this.XMinTextBox.TabIndex = 26;
            this.XMinTextBox.TextChanged += new System.EventHandler(this.XMinTextBox_TextChanged);
            // 
            // XMaxTextBox
            // 
            this.XMaxTextBox.Location = new System.Drawing.Point(714, 439);
            this.XMaxTextBox.Name = "XMaxTextBox";
            this.XMaxTextBox.Size = new System.Drawing.Size(100, 20);
            this.XMaxTextBox.TabIndex = 27;
            this.XMaxTextBox.TextChanged += new System.EventHandler(this.XMaxTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(447, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Get a specific point:";
            // 
            // GetXTextBox
            // 
            this.GetXTextBox.Location = new System.Drawing.Point(578, 471);
            this.GetXTextBox.Name = "GetXTextBox";
            this.GetXTextBox.Size = new System.Drawing.Size(100, 20);
            this.GetXTextBox.TabIndex = 30;
            // 
            // GetYTextBox
            // 
            this.GetYTextBox.Location = new System.Drawing.Point(714, 471);
            this.GetYTextBox.Name = "GetYTextBox";
            this.GetYTextBox.Size = new System.Drawing.Size(100, 20);
            this.GetYTextBox.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(693, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(557, 475);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "x:";
            // 
            // QuadraticChart
            // 
            chartArea1.Name = "ChartArea1";
            this.QuadraticChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.QuadraticChart.Legends.Add(legend1);
            this.QuadraticChart.Location = new System.Drawing.Point(395, 28);
            this.QuadraticChart.Name = "QuadraticChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            this.QuadraticChart.Series.Add(series1);
            this.QuadraticChart.Size = new System.Drawing.Size(485, 361);
            this.QuadraticChart.TabIndex = 35;
            this.QuadraticChart.Text = "chart1";
            // 
            // Quadratic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(892, 519);
            this.Controls.Add(this.QuadraticChart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GetYTextBox);
            this.Controls.Add(this.GetXTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.XMaxTextBox);
            this.Controls.Add(this.XMinTextBox);
            this.Controls.Add(this.XMaxLabel);
            this.Controls.Add(this.XMinLabel);
            this.Controls.Add(this.YMaxTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YMinTextBox);
            this.Controls.Add(this.YMinLabel);
            this.Controls.Add(this.FactorsTextBox);
            this.Controls.Add(this.FactorsLabel);
            this.Controls.Add(this.SolutionsTextBox);
            this.Controls.Add(this.SolutionsLabel);
            this.Controls.Add(this.NumOfZeroesTextBox);
            this.Controls.Add(this.NumOfZeroesLabel);
            this.Controls.Add(this.DiscriminantTextBox);
            this.Controls.Add(this.DiscriminantLabel);
            this.Controls.Add(this.VertexTextBox);
            this.Controls.Add(this.VertexLabel);
            this.Controls.Add(this.AOSTextBox);
            this.Controls.Add(this.AOSLabel);
            this.Controls.Add(this.SolveButton);
            this.Controls.Add(this.CTextBox);
            this.Controls.Add(this.CLabel);
            this.Controls.Add(this.BTextBox);
            this.Controls.Add(this.BLabel);
            this.Controls.Add(this.ATextBox);
            this.Controls.Add(this.ALabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Quadratic";
            this.Text = "Quadratic";
            this.Load += new System.EventHandler(this.Quadratic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuadraticChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        
        private System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1;
        private System.Windows.Forms.DataVisualization.Charting.Legend legend1;
        private System.Windows.Forms.DataVisualization.Charting.Series series1;
        private System.Windows.Forms.Label ALabel;
        private System.Windows.Forms.TextBox ATextBox;
        private System.Windows.Forms.TextBox BTextBox;
        private System.Windows.Forms.Label BLabel;
        private System.Windows.Forms.TextBox CTextBox;
        private System.Windows.Forms.Label CLabel;
        private System.Windows.Forms.Button SolveButton;
        private System.Windows.Forms.Label AOSLabel;
        private System.Windows.Forms.TextBox AOSTextBox;
        private System.Windows.Forms.Label VertexLabel;
        private System.Windows.Forms.TextBox VertexTextBox;
        private System.Windows.Forms.Label DiscriminantLabel;
        private System.Windows.Forms.TextBox DiscriminantTextBox;
        private System.Windows.Forms.Label NumOfZeroesLabel;
        private System.Windows.Forms.Label SolutionsLabel;
        private System.Windows.Forms.TextBox SolutionsTextBox;
        private System.Windows.Forms.TextBox NumOfZeroesTextBox;
        private System.Windows.Forms.TextBox FactorsTextBox;
        private System.Windows.Forms.Label FactorsLabel;
        private System.Windows.Forms.Label YMinLabel;
        private System.Windows.Forms.TextBox YMinTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox YMaxTextBox;
        private System.Windows.Forms.Label XMinLabel;
        private System.Windows.Forms.Label XMaxLabel;
        private System.Windows.Forms.TextBox XMinTextBox;
        private System.Windows.Forms.TextBox XMaxTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GetXTextBox;
        private System.Windows.Forms.TextBox GetYTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart QuadraticChart;
    }
}