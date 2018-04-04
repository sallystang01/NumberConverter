namespace RomanNumeralConverter
{
    partial class Arabic_Converter
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
            this.calculate2BTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.arabicNumeralTB = new System.Windows.Forms.TextBox();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.converterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.romanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblInvalid = new System.Windows.Forms.Label();
            this.lblOne = new System.Windows.Forms.Label();
            this.labelThree = new System.Windows.Forms.Label();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculate2BTN
            // 
            this.calculate2BTN.Location = new System.Drawing.Point(98, 157);
            this.calculate2BTN.Name = "calculate2BTN";
            this.calculate2BTN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.calculate2BTN.Size = new System.Drawing.Size(85, 23);
            this.calculate2BTN.TabIndex = 8;
            this.calculate2BTN.Text = "Convert";
            this.calculate2BTN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.calculate2BTN.UseVisualStyleBackColor = true;
            this.calculate2BTN.Click += new System.EventHandler(this.calculate2BTN_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(98, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 32);
            this.label3.TabIndex = 5;
            // 
            // arabicNumeralTB
            // 
            this.arabicNumeralTB.Location = new System.Drawing.Point(98, 99);
            this.arabicNumeralTB.Name = "arabicNumeralTB";
            this.arabicNumeralTB.Size = new System.Drawing.Size(85, 20);
            this.arabicNumeralTB.TabIndex = 6;
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.converterToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(284, 24);
            this.msMenu.TabIndex = 10;
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
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.homeToolStripMenuItem.Text = "&Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logoutToolStripMenuItem.Text = "&Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // converterToolStripMenuItem
            // 
            this.converterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.romanToolStripMenuItem});
            this.converterToolStripMenuItem.Name = "converterToolStripMenuItem";
            this.converterToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.converterToolStripMenuItem.Text = "Con&verter";
            // 
            // romanToolStripMenuItem
            // 
            this.romanToolStripMenuItem.Name = "romanToolStripMenuItem";
            this.romanToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.romanToolStripMenuItem.Text = "&Roman";
            this.romanToolStripMenuItem.Click += new System.EventHandler(this.romanToolStripMenuItem_Click);
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
            this.btnExit.Location = new System.Drawing.Point(197, 227);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblInvalid
            // 
            this.lblInvalid.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvalid.ForeColor = System.Drawing.Color.Red;
            this.lblInvalid.Location = new System.Drawing.Point(12, 42);
            this.lblInvalid.Name = "lblInvalid";
            this.lblInvalid.Size = new System.Drawing.Size(260, 32);
            this.lblInvalid.TabIndex = 15;
            this.lblInvalid.Text = "Number exceeded 3999!";
            this.lblInvalid.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblInvalid.Visible = false;
            // 
            // lblOne
            // 
            this.lblOne.AutoSize = true;
            this.lblOne.Location = new System.Drawing.Point(74, 102);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(13, 13);
            this.lblOne.TabIndex = 16;
            this.lblOne.Text = "1";
            // 
            // labelThree
            // 
            this.labelThree.AutoSize = true;
            this.labelThree.Location = new System.Drawing.Point(189, 102);
            this.labelThree.Name = "labelThree";
            this.labelThree.Size = new System.Drawing.Size(31, 13);
            this.labelThree.TabIndex = 17;
            this.labelThree.Text = "3999";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // Arabic_Converter
            // 
            this.AcceptButton = this.calculate2BTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.labelThree);
            this.Controls.Add(this.lblOne);
            this.Controls.Add(this.lblInvalid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.msMenu);
            this.Controls.Add(this.calculate2BTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.arabicNumeralTB);
            this.Name = "Arabic_Converter";
            this.Text = "Arabic_Converter";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculate2BTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox arabicNumeralTB;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem converterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem romanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Label lblInvalid;
        private System.Windows.Forms.Label lblOne;
        private System.Windows.Forms.Label labelThree;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}