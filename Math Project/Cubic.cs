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

namespace Math_Project {
    public partial class Cubic : Form {

        double a;
        double b;
        double c;
        double d;

        int YMin;
        int YMax;
        int XMin;
        int XMax;

        static double s1;
        static double s2;
        static string Solution;

        private static Random rand = new Random();
        private static DataPoint CurrentPoint;

        private static double cube(double x) {
            return x * x * x;
        }

        private static double GetDiscriminant(double a, double b, double c, double d) {
            double x = (18 * a * b * c * d - 4 * cube(3) * d + square(b) * square(c) - 4 * a * cube(3) - 27 * square(a) * square(d));
            return x;
        }

        private static int NumberOfRealSolution(double disc) {
            if (disc > 0) {
                return 3;
            } if (disc == 0) {
                return 2;
            } else {
                return 1;
            }
        }

        private static void Solve(double a, double b, double c, double d, int swag) {
            double s1, s2, s3;
            double zero, one;
            if (swag == 3) {
                zero = (square(b) - (3 * a * c));
                one = ((2 * cube(b)) - (9 * a * b * c) + (27 * square(a) * d));
            }
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

        public Cubic() {
            InitializeComponent();
        }
    }
}