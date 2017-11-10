using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Project {
    public partial class MathClass : Form {
        public MathClass() {
            InitializeComponent();
        }

        private void QuadraticButtonClicked(object sender, EventArgs e) {
            Quadratic Quadratic = new Quadratic();
            Quadratic.ShowDialog();
        }

        private void CubicButtonClicked(object sender, EventArgs e) {
            
        }
    }
}