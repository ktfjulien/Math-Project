namespace Math_Project {
    partial class MathClass {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.QuadraticButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CubicButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QuadraticButton
            // 
            this.QuadraticButton.Location = new System.Drawing.Point(12, 12);
            this.QuadraticButton.Name = "QuadraticButton";
            this.QuadraticButton.Size = new System.Drawing.Size(92, 23);
            this.QuadraticButton.TabIndex = 0;
            this.QuadraticButton.Text = "Quadratic";
            this.QuadraticButton.UseVisualStyleBackColor = true;
            this.QuadraticButton.Click += new System.EventHandler(this.QuadraticButtonClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Linear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CubicButton
            // 
            this.CubicButton.Location = new System.Drawing.Point(12, 70);
            this.CubicButton.Name = "CubicButton";
            this.CubicButton.Size = new System.Drawing.Size(92, 23);
            this.CubicButton.TabIndex = 2;
            this.CubicButton.Text = "Cubic";
            this.CubicButton.UseVisualStyleBackColor = true;
            // 
            // MathClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 371);
            this.Controls.Add(this.CubicButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.QuadraticButton);
            this.Name = "MathClass";
            this.Text = "Math";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button QuadraticButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CubicButton;
    }
}