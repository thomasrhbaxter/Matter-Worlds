
namespace MatterWorlds.Control
{
    partial class CoreControl
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
            this.Save = new System.Windows.Forms.Button();
            this.Loading = new System.Windows.Forms.Button();
            this.automator_button = new System.Windows.Forms.Button();
            this.infinity_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.galaxyCost = new System.Windows.Forms.Label();
            this.TickSpeedBuy = new System.Windows.Forms.Button();
            this.sacrificeBuy = new System.Windows.Forms.Button();
            this.dimBoostCost = new System.Windows.Forms.Label();
            this.galaxyBuy = new System.Windows.Forms.Button();
            this.boostBuy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.label10 = new System.Windows.Forms.Label();
            this.Dim1Automator = new System.Windows.Forms.Timer(this.components);
            this.Dim2Automater = new System.Windows.Forms.Timer(this.components);
            this.Dim3Automator = new System.Windows.Forms.Timer(this.components);
            this.Dim4Automator = new System.Windows.Forms.Timer(this.components);
            this.Dim5Automator = new System.Windows.Forms.Timer(this.components);
            this.Dim6Automator = new System.Windows.Forms.Timer(this.components);
            this.Dim7Automator = new System.Windows.Forms.Timer(this.components);
            this.Dim8Automator = new System.Windows.Forms.Timer(this.components);
            this.BoostAutomator = new System.Windows.Forms.Timer(this.components);
            this.GalaxyAutomator = new System.Windows.Forms.Timer(this.components);
            this.TickspeedAutomator = new System.Windows.Forms.Timer(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
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
            this.panel1.Controls.Add(this.Save);
            this.panel1.Controls.Add(this.Loading);
            this.panel1.Controls.Add(this.automator_button);
            this.panel1.Controls.Add(this.infinity_button);
            this.panel1.Location = new System.Drawing.Point(13, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 554);
            this.panel1.TabIndex = 19;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(4, 447);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(163, 49);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Loading
            // 
            this.Loading.Location = new System.Drawing.Point(4, 502);
            this.Loading.Name = "Loading";
            this.Loading.Size = new System.Drawing.Size(163, 49);
            this.Loading.TabIndex = 2;
            this.Loading.Text = "Load";
            this.Loading.UseVisualStyleBackColor = true;
            this.Loading.Click += new System.EventHandler(this.Load_Click);
            // 
            // automator_button
            // 
            this.automator_button.Location = new System.Drawing.Point(4, 76);
            this.automator_button.Name = "automator_button";
            this.automator_button.Size = new System.Drawing.Size(163, 49);
            this.automator_button.TabIndex = 1;
            this.automator_button.Text = "Autobuyers";
            this.automator_button.UseVisualStyleBackColor = true;
            this.automator_button.Click += new System.EventHandler(this.automator_button_Click);
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
            this.panel2.AutoScroll = true;
            this.panel2.AutoScrollMargin = new System.Drawing.Size(0, 30);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.galaxyCost);
            this.panel2.Controls.Add(this.TickSpeedBuy);
            this.panel2.Controls.Add(this.sacrificeBuy);
            this.panel2.Controls.Add(this.dimBoostCost);
            this.panel2.Controls.Add(this.galaxyBuy);
            this.panel2.Controls.Add(this.boostBuy);
            this.panel2.Controls.Add(this.label1);
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
            this.panel2.Location = new System.Drawing.Point(199, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(579, 534);
            this.panel2.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(375, 448);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "label9";
            // 
            // galaxyCost
            // 
            this.galaxyCost.AutoSize = true;
            this.galaxyCost.Location = new System.Drawing.Point(321, 387);
            this.galaxyCost.Name = "galaxyCost";
            this.galaxyCost.Size = new System.Drawing.Size(101, 13);
            this.galaxyCost.TabIndex = 41;
            this.galaxyCost.Text = "Universe boost cost";
            // 
            // TickSpeedBuy
            // 
            this.TickSpeedBuy.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.TickSpeedBuy.FlatAppearance.BorderSize = 2;
            this.TickSpeedBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TickSpeedBuy.Location = new System.Drawing.Point(348, 465);
            this.TickSpeedBuy.Name = "TickSpeedBuy";
            this.TickSpeedBuy.Size = new System.Drawing.Size(186, 38);
            this.TickSpeedBuy.TabIndex = 43;
            this.TickSpeedBuy.Text = "Tickspeed++";
            this.TickSpeedBuy.UseVisualStyleBackColor = true;
            this.TickSpeedBuy.Click += new System.EventHandler(this.TickSpeedBuy_Click);
            // 
            // sacrificeBuy
            // 
            this.sacrificeBuy.Enabled = false;
            this.sacrificeBuy.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.sacrificeBuy.FlatAppearance.BorderSize = 2;
            this.sacrificeBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sacrificeBuy.Location = new System.Drawing.Point(58, 465);
            this.sacrificeBuy.Name = "sacrificeBuy";
            this.sacrificeBuy.Size = new System.Drawing.Size(140, 38);
            this.sacrificeBuy.TabIndex = 42;
            this.sacrificeBuy.Text = "sacrifice";
            this.sacrificeBuy.UseVisualStyleBackColor = true;
            this.sacrificeBuy.Visible = false;
            this.sacrificeBuy.Click += new System.EventHandler(this.sacrificeBuy_Click);
            // 
            // dimBoostCost
            // 
            this.dimBoostCost.AutoSize = true;
            this.dimBoostCost.Location = new System.Drawing.Point(23, 387);
            this.dimBoostCost.Name = "dimBoostCost";
            this.dimBoostCost.Size = new System.Drawing.Size(84, 13);
            this.dimBoostCost.TabIndex = 40;
            this.dimBoostCost.Text = "world boost cost";
            // 
            // galaxyBuy
            // 
            this.galaxyBuy.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.galaxyBuy.FlatAppearance.BorderSize = 2;
            this.galaxyBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.galaxyBuy.Location = new System.Drawing.Point(324, 403);
            this.galaxyBuy.Name = "galaxyBuy";
            this.galaxyBuy.Size = new System.Drawing.Size(231, 42);
            this.galaxyBuy.TabIndex = 39;
            this.galaxyBuy.Text = "Boost universe";
            this.galaxyBuy.UseVisualStyleBackColor = true;
            this.galaxyBuy.Click += new System.EventHandler(this.galaxyBuy_Click);
            // 
            // boostBuy
            // 
            this.boostBuy.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.boostBuy.FlatAppearance.BorderSize = 2;
            this.boostBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boostBuy.Location = new System.Drawing.Point(17, 403);
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
            this.label1.Location = new System.Drawing.Point(59, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "World 1";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(399, 23);
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
            this.label2.Location = new System.Drawing.Point(59, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "World 2";
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button8.FlatAppearance.BorderSize = 2;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(399, 305);
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
            this.label3.Location = new System.Drawing.Point(59, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "World 3";
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button7.FlatAppearance.BorderSize = 2;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(399, 265);
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
            this.label4.Location = new System.Drawing.Point(59, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "World 4";
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button6.FlatAppearance.BorderSize = 2;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(399, 223);
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
            this.label5.Location = new System.Drawing.Point(59, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "World 5";
            this.label5.Visible = false;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(399, 183);
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
            this.label6.Location = new System.Drawing.Point(59, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "World 6";
            this.label6.Visible = false;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(399, 142);
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
            this.label7.Location = new System.Drawing.Point(59, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "World 7";
            this.label7.Visible = false;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(399, 102);
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
            this.label8.Location = new System.Drawing.Point(59, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "World 8";
            this.label8.Visible = false;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(399, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 34);
            this.button2.TabIndex = 29;
            this.button2.Text = "world 2  buy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buy2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(381, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Antimatter: ";
            // 
            // Dim1Automator
            // 
            this.Dim1Automator.Interval = 1000;
            this.Dim1Automator.Tick += new System.EventHandler(this.AutoDim1);
            // 
            // Dim2Automater
            // 
            this.Dim2Automater.Interval = 1000;
            this.Dim2Automater.Tick += new System.EventHandler(this.AutoDim2);
            // 
            // Dim3Automator
            // 
            this.Dim3Automator.Interval = 1000;
            this.Dim3Automator.Tick += new System.EventHandler(this.AutoDim3);
            // 
            // Dim4Automator
            // 
            this.Dim4Automator.Interval = 1000;
            this.Dim4Automator.Tick += new System.EventHandler(this.AutoDim4);
            // 
            // Dim5Automator
            // 
            this.Dim5Automator.Interval = 1000;
            this.Dim5Automator.Tick += new System.EventHandler(this.AutoDim5);
            // 
            // Dim6Automator
            // 
            this.Dim6Automator.Interval = 1000;
            this.Dim6Automator.Tick += new System.EventHandler(this.AutoDim6);
            // 
            // Dim7Automator
            // 
            this.Dim7Automator.Interval = 1000;
            this.Dim7Automator.Tick += new System.EventHandler(this.AutoDim7);
            // 
            // Dim8Automator
            // 
            this.Dim8Automator.Interval = 1000;
            this.Dim8Automator.Tick += new System.EventHandler(this.AutoDim8);
            // 
            // BoostAutomator
            // 
            this.BoostAutomator.Interval = 1000;
            this.BoostAutomator.Tick += new System.EventHandler(this.AutoBoost);
            // 
            // GalaxyAutomator
            // 
            this.GalaxyAutomator.Interval = 1000;
            this.GalaxyAutomator.Tick += new System.EventHandler(this.AutoGalaxy);
            // 
            // TickspeedAutomator
            // 
            this.TickspeedAutomator.Interval = 1000;
            this.TickspeedAutomator.Tick += new System.EventHandler(this.AutoTickspeed);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.AutoScrollMargin = new System.Drawing.Size(0, 30);
            this.panel3.Location = new System.Drawing.Point(199, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(579, 531);
            this.panel3.TabIndex = 45;
            // 
            // CoreControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 582);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "CoreControl";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button TickSpeedBuy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer Dim1Automator;
        private System.Windows.Forms.Timer Dim2Automater;
        private System.Windows.Forms.Timer Dim3Automator;
        private System.Windows.Forms.Timer Dim4Automator;
        private System.Windows.Forms.Timer Dim5Automator;
        private System.Windows.Forms.Timer Dim6Automator;
        private System.Windows.Forms.Timer Dim7Automator;
        private System.Windows.Forms.Timer Dim8Automator;
        private System.Windows.Forms.Timer BoostAutomator;
        private System.Windows.Forms.Timer GalaxyAutomator;
        private System.Windows.Forms.Timer TickspeedAutomator;
        private System.Windows.Forms.Button automator_button;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Loading;
    }
}

