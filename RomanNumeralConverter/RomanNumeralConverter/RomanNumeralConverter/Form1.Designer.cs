namespace RomanNumeralConverter
{
    partial class Roman
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
            this.romanNumeralTB = new System.Windows.Forms.TextBox();
            this.outputLB = new System.Windows.Forms.Label();
            this.calculateBTN = new System.Windows.Forms.Button();
            this.lblRoman = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.converterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arabicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // romanNumeralTB
            // 
            this.romanNumeralTB.AccessibleName = "Enter a Roman Numeral";
            this.romanNumeralTB.Location = new System.Drawing.Point(98, 105);
            this.romanNumeralTB.Name = "romanNumeralTB";
            this.romanNumeralTB.Size = new System.Drawing.Size(85, 20);
            this.romanNumeralTB.TabIndex = 1;
            // 
            // outputLB
            // 
            this.outputLB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputLB.Location = new System.Drawing.Point(98, 128);
            this.outputLB.Name = "outputLB";
            this.outputLB.Size = new System.Drawing.Size(85, 32);
            this.outputLB.TabIndex = 2;
            // 
            // calculateBTN
            // 
            this.calculateBTN.AccessibleDescription = "Converts the Roman Numeral to Arabic";
            this.calculateBTN.AccessibleName = "Convert Button";
            this.calculateBTN.Location = new System.Drawing.Point(98, 163);
            this.calculateBTN.Name = "calculateBTN";
            this.calculateBTN.Size = new System.Drawing.Size(85, 23);
            this.calculateBTN.TabIndex = 2;
            this.calculateBTN.Text = "Convert";
            this.calculateBTN.UseVisualStyleBackColor = true;
            this.calculateBTN.Click += new System.EventHandler(this.calculateBTN_Click);
            // 
            // lblRoman
            // 
            this.lblRoman.AccessibleDescription = "Continue to the text box";
            this.lblRoman.AccessibleName = "Roman Numeral Label";
            this.lblRoman.AutoSize = true;
            this.lblRoman.Location = new System.Drawing.Point(80, 89);
            this.lblRoman.Name = "lblRoman";
            this.lblRoman.Size = new System.Drawing.Size(120, 13);
            this.lblRoman.TabIndex = 7;
            this.lblRoman.Text = "Enter a Roman Numeral";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.converterToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(283, 24);
            this.msMenu.TabIndex = 9;
            this.msMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.toolStripSeparator1,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.homeToolStripMenuItem.Text = "&Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "&Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // converterToolStripMenuItem
            // 
            this.converterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arabicToolStripMenuItem});
            this.converterToolStripMenuItem.Name = "converterToolStripMenuItem";
            this.converterToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.converterToolStripMenuItem.Text = "Con&verter";
            // 
            // arabicToolStripMenuItem
            // 
            this.arabicToolStripMenuItem.Name = "arabicToolStripMenuItem";
            this.arabicToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.arabicToolStripMenuItem.Text = "&Arabic";
            this.arabicToolStripMenuItem.Click += new System.EventHandler(this.arabicToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getHelpToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // getHelpToolStripMenuItem
            // 
            this.getHelpToolStripMenuItem.Name = "getHelpToolStripMenuItem";
            this.getHelpToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.getHelpToolStripMenuItem.Text = "&Get Help!";
            this.getHelpToolStripMenuItem.Click += new System.EventHandler(this.getHelpToolStripMenuItem_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(196, 247);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // Roman
            // 
            this.AcceptButton = this.calculateBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 286);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblRoman);
            this.Controls.Add(this.calculateBTN);
            this.Controls.Add(this.outputLB);
            this.Controls.Add(this.romanNumeralTB);
            this.Controls.Add(this.msMenu);
            this.MainMenuStrip = this.msMenu;
            this.Name = "Roman";
            this.Text = "Roman Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox romanNumeralTB;
        private System.Windows.Forms.Label outputLB;
        private System.Windows.Forms.Button calculateBTN;
        private System.Windows.Forms.Label lblRoman;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem converterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arabicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

