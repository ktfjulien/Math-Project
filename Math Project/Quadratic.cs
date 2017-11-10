using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.SqlClient;

namespace Math_Project {
    public partial class Quadratic : Form {

        double a;
        double b;
        double c;

        int YMin;
        int YMax;
        int XMin;
        int XMax;

        static double s1;
        static double s2;
        static string Solution;


        private static Random rand = new Random();
        private static DataPoint CurrentPoint;
        
        
        public Quadratic() {
            InitializeComponent();
            //series1 = new Series();
            //chartArea1 = new ChartArea();
            //QuadraticChart.Series["Series1"] = new Series();
            ATextBox.Text = Convert.ToString(1);
            BTextBox.Text = Convert.ToString(1);
            CTextBox.Text = Convert.ToString(-6);
        }

        private double GetAnyYValue(double a, double b, double c, int x) {
            return (a * square(x)) + (b * x) + c;
        }

        private static string GetFactors(double a1, double a2, string swag) {
            string Factors = "";

            switch (swag) {
                case "0":
                    break;
                case "1":
                    if (a1 >= 0) {
                        Factors = "( x " + "- " + a1 + " )";
                    } else {
                        string t1 = a1.ToString().Substring(1);
                        Factors = "( x " + "+ " + t1 + " )";
                    }
                    break;
                case "2":
                    if (a1 >= 0 && a2 >= 0) {
                        Factors = "( x - " + a1 + " ), " + "( x - " + a2 + " )";
                    } else if (a1 > 0 && a2 < 0) {
                        string t2 = a2.ToString().Substring(1);
                        Factors = "( x - " + a1 + " ), " + "( x + " + t2 + " )";
                    } else {
                        string t1 = a1.ToString().Substring(1);
                        Factors = "( x + " + t1 + " ), " + "( x - " + a2 + " )";
                    }
                    
                    break;
            }

            return Factors;
        }

        private static void Solve(double a, double b, double c, int swag) {
            if (swag < 0) {
                Solution = "";
            } else if (swag == 0) {
                s1 = (-b + Math.Sqrt(square(b) - 4 * a * c)) / (2 * a);
                Solution = s1.ToString();
            } else {
                s1 = (-b + Math.Sqrt(square(b) - 4 * a * c)) / (2 * a);
                s2 = (-b - Math.Sqrt(square(b) - 4 * a * c)) / (2 * a);
                Solution = s1.ToString() + " , " + s2.ToString();
                
            }
            
        }

        private static double GetAOS(double a, double b, double c) {
            return (-b) / (2 * a);
        }

        private static double GetDiscriminant(double a, double b, double c) {
            return (square(b) - 4 * a * c);
        }

        private static double square(double x) {
            return (x * x);
        }

        private static double square(int x) {
            return (x * x);
        }

        private static double square(float x) {
            return (x * x);
        }

        private static double GetY(double a, double b, double c) {
            double x = GetAOS(a, b, c);
            return (a * square(x)) + (b * x) + c;
        }

        private static string GetVertex(double a, double b, double c) {
            return "(" + GetAOS(a, b, c).ToString() + ", " + GetY(a, b, c).ToString() + ")";
        }

        private void DontFocus(object sender, EventArgs e) {
            ATextBox.Focus();
        }

        private void Quadratic_Load(object sender, EventArgs e) {
            AcceptButton = SolveButton;
        }

        private void AnythingTextChanged(object sender, EventArgs e) {
            AnythingTextChanged();
        }

        private void AnythingTextChanged() {
            AOSTextBox.Text = "";
            VertexTextBox.Text = "";
            DiscriminantTextBox.Text = "";
            NumOfZeroesTextBox.Text = "";
            SolutionsTextBox.Text = "";
            FactorsTextBox.Text = "";
            ClearChart();
        }

        private void ClearChart() {
            try {
                QuadraticChart.Series["Series1"].Points.Clear();
            } catch {

            }
            
        }

        private void CheckForEmptyVars() {
            if (ATextBox.Text == "") {
                MessageBox.Show("This equation is not quadratic. It is linear.", "Non-Quadratic Equation");
                return;
            }
            if (BTextBox.Text == "") {
                BTextBox.Text = "0";
            }
            if (CTextBox.Text == "") {
                CTextBox.Text = "0";
            }
            if (YMinTextBox.Text == "") {
                YMinTextBox.Text = "-10";
            }
            if (YMaxTextBox.Text == "") {
                YMaxTextBox.Text = "10";
            }
            if (XMinTextBox.Text == "") {
                XMinTextBox.Text = "-10";
            }
            if (XMaxTextBox.Text == "") {
                XMaxTextBox.Text = "10";
            }
        }

        private void ParseVars() {
            try { 
                a = double.Parse(ATextBox.Text.Trim());
                b = double.Parse(BTextBox.Text.Trim());
                c = double.Parse(CTextBox.Text.Trim());
            } catch {
                MessageBox.Show("Please enter valid numbers into the text boxes", "Error");
                VertexTextBox.Text = "swagger";
                //ClearChart();
                //AnythingTextChanged();
            }

            try {
                YMin = Int32.Parse(YMinTextBox.Text.Trim());
                YMax = Int32.Parse(YMaxTextBox.Text.Trim());
                XMin = Int32.Parse(XMinTextBox.Text.Trim());
                XMax = Int32.Parse(XMaxTextBox.Text.Trim());
            } catch {
                YMin = -10;
                YMax = 10;
                XMin = -10;
                XMax = 10;
            }
        }

        private void DisplaySolutions() {
            AOSTextBox.Text = Convert.ToString(GetAOS(a, b, c));

            VertexTextBox.Text = GetVertex(a, b, c).ToString();
            DiscriminantTextBox.Text = GetDiscriminant(a, b, c).ToString();

            if (GetDiscriminant(a, b, c) < 0) {
                NumOfZeroesTextBox.Text = 0.ToString();
            } else if (GetDiscriminant(a, b, c) == 0) {
                NumOfZeroesTextBox.Text = 1.ToString();
            } else {
                NumOfZeroesTextBox.Text = 2.ToString();
            }


            Solve(a, b, c, Int32.Parse(NumOfZeroesTextBox.Text));
            SolutionsTextBox.Text = Solution;

            switch (SolutionsTextBox.Text) {
                case "NaN":
                    SolutionsTextBox.Text = "No Real Solutions";
                    break;
                default:
                    break;
            }

            FactorsTextBox.Text = GetFactors(s1, s2, NumOfZeroesTextBox.Text);

        }

        private void Graph() {
            //series1.Name = a + "x² " + b + "x" + c;
            for (int x = XMin; x <= XMax; x++) {
                CurrentPoint = new DataPoint(x, GetAnyYValue(a, b, c, x));
                QuadraticChart.Series["Series1"].Points.Add(CurrentPoint);
            }
            QuadraticChart.ChartAreas["ChartArea1"].AxisY.Minimum = YMin;
            QuadraticChart.ChartAreas["ChartArea1"].AxisY.Maximum = YMax;
            QuadraticChart.ChartAreas["ChartArea1"].AxisX.Minimum = XMin;
            QuadraticChart.ChartAreas["ChartArea1"].AxisX.Maximum = XMax;
        }

        private void GetPointChanged(object sender, EventArgs e) {

        }

        private void CheckDatabase(double a, double b, double c) {
            using (SqlConnection conn = new SqlConnection()) {
                conn.ConnectionString = "Server=Server; Database=Database; User Id=Boolean; Password=cisco;";
            }
        }

        private void SolveButton_Click(object sender, EventArgs e) {
            //a = Convert.ToDouble(ATextBox.Text);
            //b = Convert.ToDouble(BTextBox.Text);
            //c = Convert.ToDouble(CTextBox.Text);
            ParseVars();
            DisplaySolutions();
            Graph();
        }

        private void QuadraticChart_Click(object sender, EventArgs e)
        {

        }

        private void XMinTextBox_TextChanged(object sender, EventArgs e) {
            try {
                XMin = Convert.ToInt32(XMinTextBox.Text);
                ClearChart();
                Graph();
            } catch {

            }
        }

        private void XMaxTextBox_TextChanged(object sender, EventArgs e) {
            try {
                XMax = Convert.ToInt32(XMaxTextBox.Text);
                ClearChart();
                Graph();
            } catch {

            }
        }

        private void YMaxTextBox_TextChanged(object sender, EventArgs e) {
            try {
                YMax = Convert.ToInt32(YMaxTextBox.Text);
                ClearChart();
                Graph();
            } catch {

            }
        }

        private void YMinTextBox_TextChanged(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(YMinTextBox.Text.Trim())) {
                YMin = 0;
                return;
            }
            try {
                YMin = Convert.ToInt32(YMinTextBox.Text);
                ClearChart();
                Graph();
            } catch {}
        }
    }
}