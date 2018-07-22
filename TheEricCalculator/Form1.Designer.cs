namespace TheEricCalculator
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addtxt1 = new System.Windows.Forms.TextBox();
            this.subtxt2 = new System.Windows.Forms.TextBox();
            this.multtxt1 = new System.Windows.Forms.TextBox();
            this.divtxt2 = new System.Windows.Forms.TextBox();
            this.multtxt2 = new System.Windows.Forms.TextBox();
            this.subtxt1 = new System.Windows.Forms.TextBox();
            this.divtxt1 = new System.Windows.Forms.TextBox();
            this.addtxt2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.addresult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.subresult = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.multresult = new System.Windows.Forms.Label();
            this.dividesign = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.divresult = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // addtxt1
            // 
            this.addtxt1.Location = new System.Drawing.Point(23, 35);
            this.addtxt1.Name = "addtxt1";
            this.addtxt1.Size = new System.Drawing.Size(42, 20);
            this.addtxt1.TabIndex = 1;
            // 
            // subtxt2
            // 
            this.subtxt2.Location = new System.Drawing.Point(90, 177);
            this.subtxt2.Name = "subtxt2";
            this.subtxt2.Size = new System.Drawing.Size(42, 20);
            this.subtxt2.TabIndex = 2;
            // 
            // multtxt1
            // 
            this.multtxt1.Location = new System.Drawing.Point(427, 44);
            this.multtxt1.Name = "multtxt1";
            this.multtxt1.Size = new System.Drawing.Size(42, 20);
            this.multtxt1.TabIndex = 3;
            // 
            // divtxt2
            // 
            this.divtxt2.Location = new System.Drawing.Point(489, 177);
            this.divtxt2.Name = "divtxt2";
            this.divtxt2.Size = new System.Drawing.Size(42, 20);
            this.divtxt2.TabIndex = 4;
            // 
            // multtxt2
            // 
            this.multtxt2.Location = new System.Drawing.Point(489, 44);
            this.multtxt2.Name = "multtxt2";
            this.multtxt2.Size = new System.Drawing.Size(42, 20);
            this.multtxt2.TabIndex = 5;
            // 
            // subtxt1
            // 
            this.subtxt1.Location = new System.Drawing.Point(23, 177);
            this.subtxt1.Name = "subtxt1";
            this.subtxt1.Size = new System.Drawing.Size(42, 20);
            this.subtxt1.TabIndex = 6;
            // 
            // divtxt1
            // 
            this.divtxt1.Location = new System.Drawing.Point(427, 177);
            this.divtxt1.Name = "divtxt1";
            this.divtxt1.Size = new System.Drawing.Size(42, 20);
            this.divtxt1.TabIndex = 7;
            // 
            // addtxt2
            // 
            this.addtxt2.Location = new System.Drawing.Point(90, 35);
            this.addtxt2.Name = "addtxt2";
            this.addtxt2.Size = new System.Drawing.Size(42, 20);
            this.addtxt2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 22);
            this.button1.TabIndex = 9;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(157, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 22);
            this.button2.TabIndex = 10;
            this.button2.Text = "=";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(549, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 22);
            this.button3.TabIndex = 11;
            this.button3.Text = "=";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(549, 175);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(26, 22);
            this.button4.TabIndex = 12;
            this.button4.Text = "=";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // addresult
            // 
            this.addresult.AutoSize = true;
            this.addresult.Location = new System.Drawing.Point(20, 84);
            this.addresult.Name = "addresult";
            this.addresult.Size = new System.Drawing.Size(0, 13);
            this.addresult.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "-";
            // 
            // subresult
            // 
            this.subresult.AutoSize = true;
            this.subresult.Location = new System.Drawing.Point(20, 219);
            this.subresult.Name = "subresult";
            this.subresult.Size = new System.Drawing.Size(0, 13);
            this.subresult.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "x";
            // 
            // multresult
            // 
            this.multresult.AutoSize = true;
            this.multresult.Location = new System.Drawing.Point(424, 105);
            this.multresult.Name = "multresult";
            this.multresult.Size = new System.Drawing.Size(0, 13);
            this.multresult.TabIndex = 17;
            // 
            // dividesign
            // 
            this.dividesign.AutoSize = true;
            this.dividesign.Location = new System.Drawing.Point(471, 180);
            this.dividesign.Name = "dividesign";
            this.dividesign.Size = new System.Drawing.Size(12, 13);
            this.dividesign.TabIndex = 18;
            this.dividesign.Text = "/";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "+";
            // 
            // divresult
            // 
            this.divresult.AutoSize = true;
            this.divresult.Location = new System.Drawing.Point(424, 219);
            this.divresult.Name = "divresult";
            this.divresult.Size = new System.Drawing.Size(0, 13);
            this.divresult.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.divresult);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dividesign);
            this.Controls.Add(this.multresult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.subresult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addresult);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addtxt2);
            this.Controls.Add(this.divtxt1);
            this.Controls.Add(this.subtxt1);
            this.Controls.Add(this.multtxt2);
            this.Controls.Add(this.divtxt2);
            this.Controls.Add(this.multtxt1);
            this.Controls.Add(this.subtxt2);
            this.Controls.Add(this.addtxt1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "The Eric Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox addtxt1;
        private System.Windows.Forms.TextBox subtxt2;
        private System.Windows.Forms.TextBox multtxt1;
        private System.Windows.Forms.TextBox divtxt2;
        private System.Windows.Forms.TextBox multtxt2;
        private System.Windows.Forms.TextBox subtxt1;
        private System.Windows.Forms.TextBox divtxt1;
        private System.Windows.Forms.TextBox addtxt2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label addresult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label subresult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label multresult;
        private System.Windows.Forms.Label dividesign;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label divresult;
    }
}

