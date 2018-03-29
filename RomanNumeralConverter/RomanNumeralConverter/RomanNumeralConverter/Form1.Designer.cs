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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.arabicTB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inputTB
            // 
            this.inputTB.Location = new System.Drawing.Point(12, 42);
            this.inputTB.Name = "inputTB";
            this.inputTB.Size = new System.Drawing.Size(85, 20);
            this.inputTB.TabIndex = 0;
            // 
            // outputLB
            // 
            this.outputLB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputLB.Location = new System.Drawing.Point(12, 65);
            this.outputLB.Name = "outputLB";
            this.outputLB.Size = new System.Drawing.Size(85, 32);
            this.outputLB.TabIndex = 1;
            // 
            // calculateBTN
            // 
            this.calculateBTN.Location = new System.Drawing.Point(12, 109);
            this.calculateBTN.Name = "calculateBTN";
            this.calculateBTN.Size = new System.Drawing.Size(85, 23);
            this.calculateBTN.TabIndex = 2;
            this.calculateBTN.Text = "Convert";
            this.calculateBTN.UseVisualStyleBackColor = true;
            this.calculateBTN.Click += new System.EventHandler(this.calculateBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Convert to Arabic";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Convert to Roman";
            // 
            // arabicTB
            // 
            this.arabicTB.Location = new System.Drawing.Point(186, 109);
            this.arabicTB.Name = "arabicTB";
            this.arabicTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.arabicTB.Size = new System.Drawing.Size(85, 23);
            this.arabicTB.TabIndex = 6;
            this.arabicTB.Text = "Convert";
            this.arabicTB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.arabicTB.UseVisualStyleBackColor = true;
            this.arabicTB.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(186, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 32);
            this.label3.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(186, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 20);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 221);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.arabicTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button arabicTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

