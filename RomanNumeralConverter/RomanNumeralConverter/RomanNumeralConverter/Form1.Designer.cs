namespace RomanNumeralConverter
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
            this.inputTB = new System.Windows.Forms.TextBox();
            this.outputLB = new System.Windows.Forms.Label();
            this.calculateBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTB
            // 
            this.inputTB.Location = new System.Drawing.Point(50, 63);
            this.inputTB.Name = "inputTB";
            this.inputTB.Size = new System.Drawing.Size(182, 20);
            this.inputTB.TabIndex = 0;
            // 
            // outputLB
            // 
            this.outputLB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputLB.Location = new System.Drawing.Point(50, 86);
            this.outputLB.Name = "outputLB";
            this.outputLB.Size = new System.Drawing.Size(182, 32);
            this.outputLB.TabIndex = 1;
            // 
            // calculateBTN
            // 
            this.calculateBTN.Location = new System.Drawing.Point(108, 138);
            this.calculateBTN.Name = "calculateBTN";
            this.calculateBTN.Size = new System.Drawing.Size(75, 23);
            this.calculateBTN.TabIndex = 2;
            this.calculateBTN.Text = "Calculate";
            this.calculateBTN.UseVisualStyleBackColor = true;
            this.calculateBTN.Click += new System.EventHandler(this.calculateBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 221);
            this.Controls.Add(this.calculateBTN);
            this.Controls.Add(this.outputLB);
            this.Controls.Add(this.inputTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTB;
        private System.Windows.Forms.Label outputLB;
        private System.Windows.Forms.Button calculateBTN;
    }
}

