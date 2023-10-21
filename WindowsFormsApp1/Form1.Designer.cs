namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.infinity_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sacrificeBuy = new System.Windows.Forms.Button();
            this.galaxyCost = new System.Windows.Forms.Label();
            this.dimBoostCost = new System.Windows.Forms.Label();
            this.galaxyBuy = new System.Windows.Forms.Button();
            this.boostBuy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 25;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.infinity_button);
            this.panel1.Location = new System.Drawing.Point(13, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 478);
            this.panel1.TabIndex = 19;
            // 
            // infinity_button
            // 
            this.infinity_button.Location = new System.Drawing.Point(4, 21);
            this.infinity_button.Name = "infinity_button";
            this.infinity_button.Size = new System.Drawing.Size(163, 49);
            this.infinity_button.TabIndex = 0;
            this.infinity_button.Text = "Infinity";
            this.infinity_button.UseVisualStyleBackColor = true;
            this.infinity_button.Click += new System.EventHandler(this.infinityMenu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sacrificeBuy);
            this.panel2.Controls.Add(this.galaxyCost);
            this.panel2.Controls.Add(this.dimBoostCost);
            this.panel2.Controls.Add(this.galaxyBuy);
            this.panel2.Controls.Add(this.boostBuy);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(199, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(579, 478);
            this.panel2.TabIndex = 20;
            // 
            // sacrificeBuy
            // 
            this.sacrificeBuy.Enabled = false;
            this.sacrificeBuy.Location = new System.Drawing.Point(12, 7);
            this.sacrificeBuy.Name = "sacrificeBuy";
            this.sacrificeBuy.Size = new System.Drawing.Size(140, 38);
            this.sacrificeBuy.TabIndex = 42;
            this.sacrificeBuy.Text = "button9";
            this.sacrificeBuy.UseVisualStyleBackColor = true;
            this.sacrificeBuy.Visible = false;
            this.sacrificeBuy.Click += new System.EventHandler(this.sacrificeBuy_Click);
            // 
            // galaxyCost
            // 
            this.galaxyCost.AutoSize = true;
            this.galaxyCost.Location = new System.Drawing.Point(327, 404);
            this.galaxyCost.Name = "galaxyCost";
            this.galaxyCost.Size = new System.Drawing.Size(101, 13);
            this.galaxyCost.TabIndex = 41;
            this.galaxyCost.Text = "Universe boost cost";
            // 
            // dimBoostCost
            // 
            this.dimBoostCost.AutoSize = true;
            this.dimBoostCost.Location = new System.Drawing.Point(29, 404);
            this.dimBoostCost.Name = "dimBoostCost";
            this.dimBoostCost.Size = new System.Drawing.Size(84, 13);
            this.dimBoostCost.TabIndex = 40;
            this.dimBoostCost.Text = "world boost cost";
            // 
            // galaxyBuy
            // 
            this.galaxyBuy.Location = new System.Drawing.Point(330, 420);
            this.galaxyBuy.Name = "galaxyBuy";
            this.galaxyBuy.Size = new System.Drawing.Size(231, 42);
            this.galaxyBuy.TabIndex = 39;
            this.galaxyBuy.Text = "Boost universe";
            this.galaxyBuy.UseVisualStyleBackColor = true;
            this.galaxyBuy.Click += new System.EventHandler(this.galaxyBuy_Click);
            // 
            // boostBuy
            // 
            this.boostBuy.Location = new System.Drawing.Point(23, 420);
            this.boostBuy.Name = "boostBuy";
            this.boostBuy.Size = new System.Drawing.Size(215, 42);
            this.boostBuy.TabIndex = 38;
            this.boostBuy.Text = "reset worlds to unlock the next world";
            this.boostBuy.UseVisualStyleBackColor = true;
            this.boostBuy.Click += new System.EventHandler(this.boostBuy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "World 1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(194, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Antimatter: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 34);
            this.button1.TabIndex = 19;
            this.button1.Text = "World 1 buy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buy1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "World 2";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(401, 340);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(139, 34);
            this.button8.TabIndex = 35;
            this.button8.Text = "world 8 buy";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.buy8_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "World 3";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(401, 300);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(139, 34);
            this.button7.TabIndex = 34;
            this.button7.Text = "world 7 buy";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.buy7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "World 4";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(401, 258);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(139, 34);
            this.button6.TabIndex = 33;
            this.button6.Text = "world 6 buy";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.MouseCaptureChanged += new System.EventHandler(this.buy6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "World 5";
            this.label5.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(401, 217);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 34);
            this.button5.TabIndex = 32;
            this.button5.Text = "world 5 buy";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.MouseCaptureChanged += new System.EventHandler(this.buy5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "World 6";
            this.label6.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(401, 177);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 34);
            this.button4.TabIndex = 31;
            this.button4.Text = "world 4 buy";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.MouseCaptureChanged += new System.EventHandler(this.buy4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "World 7";
            this.label7.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(401, 137);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 34);
            this.button3.TabIndex = 30;
            this.button3.Text = "world 3 buy";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buy3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "World 8";
            this.label8.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(401, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 34);
            this.button2.TabIndex = 29;
            this.button2.Text = "world 2  buy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buy2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 508);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button infinity_button;
        private System.Windows.Forms.Button galaxyBuy;
        private System.Windows.Forms.Button boostBuy;
        private System.Windows.Forms.Label dimBoostCost;
        private System.Windows.Forms.Label galaxyCost;
        private System.Windows.Forms.Button sacrificeBuy;
    }
}

