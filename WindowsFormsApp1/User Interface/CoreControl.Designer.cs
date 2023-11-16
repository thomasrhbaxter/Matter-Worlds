
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
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.boostBuy = new System.Windows.Forms.Button();
            this.galaxyBuy = new System.Windows.Forms.Button();
            this.dimBoostCost = new System.Windows.Forms.Label();
            this.sacrificeBuy = new System.Windows.Forms.Button();
            this.TickSpeedBuy = new System.Windows.Forms.Button();
            this.galaxyCost = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.autobuyer6 = new System.Windows.Forms.Button();
            this.autobuyer5 = new System.Windows.Forms.Button();
            this.autobuyer4 = new System.Windows.Forms.Button();
            this.autobuyer7 = new System.Windows.Forms.Button();
            this.autobuyer2 = new System.Windows.Forms.Button();
            this.autobuyer3 = new System.Windows.Forms.Button();
            this.autobuyer8 = new System.Windows.Forms.Button();
            this.autobuyer1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AutoTickUpgrade = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.ABTUnlock = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "World 4";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "World 3";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "World 2";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "World 1";
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
            // dimBoostCost
            // 
            this.dimBoostCost.AutoSize = true;
            this.dimBoostCost.Location = new System.Drawing.Point(23, 387);
            this.dimBoostCost.Name = "dimBoostCost";
            this.dimBoostCost.Size = new System.Drawing.Size(84, 13);
            this.dimBoostCost.TabIndex = 40;
            this.dimBoostCost.Text = "world boost cost";
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
            // galaxyCost
            // 
            this.galaxyCost.AutoSize = true;
            this.galaxyCost.Location = new System.Drawing.Point(321, 387);
            this.galaxyCost.Name = "galaxyCost";
            this.galaxyCost.Size = new System.Drawing.Size(101, 13);
            this.galaxyCost.TabIndex = 41;
            this.galaxyCost.Text = "Universe boost cost";
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
            // autobuyer6
            // 
            this.autobuyer6.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.autobuyer6.FlatAppearance.BorderSize = 2;
            this.autobuyer6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autobuyer6.Location = new System.Drawing.Point(399, 223);
            this.autobuyer6.Name = "autobuyer6";
            this.autobuyer6.Size = new System.Drawing.Size(139, 34);
            this.autobuyer6.TabIndex = 50;
            this.autobuyer6.Text = "autobuyer 6";
            this.autobuyer6.UseVisualStyleBackColor = true;
            // 
            // autobuyer5
            // 
            this.autobuyer5.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.autobuyer5.FlatAppearance.BorderSize = 2;
            this.autobuyer5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autobuyer5.Location = new System.Drawing.Point(399, 183);
            this.autobuyer5.Name = "autobuyer5";
            this.autobuyer5.Size = new System.Drawing.Size(139, 34);
            this.autobuyer5.TabIndex = 49;
            this.autobuyer5.Text = "autobuyer 5";
            this.autobuyer5.UseVisualStyleBackColor = true;
            // 
            // autobuyer4
            // 
            this.autobuyer4.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.autobuyer4.FlatAppearance.BorderSize = 2;
            this.autobuyer4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autobuyer4.Location = new System.Drawing.Point(399, 142);
            this.autobuyer4.Name = "autobuyer4";
            this.autobuyer4.Size = new System.Drawing.Size(139, 34);
            this.autobuyer4.TabIndex = 48;
            this.autobuyer4.Text = "autobuyer 4";
            this.autobuyer4.UseVisualStyleBackColor = true;
            // 
            // autobuyer7
            // 
            this.autobuyer7.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.autobuyer7.FlatAppearance.BorderSize = 2;
            this.autobuyer7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autobuyer7.Location = new System.Drawing.Point(399, 265);
            this.autobuyer7.Name = "autobuyer7";
            this.autobuyer7.Size = new System.Drawing.Size(139, 34);
            this.autobuyer7.TabIndex = 51;
            this.autobuyer7.Text = "autobuyer 7";
            this.autobuyer7.UseVisualStyleBackColor = true;
            // 
            // autobuyer2
            // 
            this.autobuyer2.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.autobuyer2.FlatAppearance.BorderSize = 2;
            this.autobuyer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autobuyer2.Location = new System.Drawing.Point(399, 62);
            this.autobuyer2.Name = "autobuyer2";
            this.autobuyer2.Size = new System.Drawing.Size(139, 34);
            this.autobuyer2.TabIndex = 46;
            this.autobuyer2.Text = "autobuyer 2";
            this.autobuyer2.UseVisualStyleBackColor = true;
            // 
            // autobuyer3
            // 
            this.autobuyer3.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.autobuyer3.FlatAppearance.BorderSize = 2;
            this.autobuyer3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autobuyer3.Location = new System.Drawing.Point(399, 102);
            this.autobuyer3.Name = "autobuyer3";
            this.autobuyer3.Size = new System.Drawing.Size(139, 34);
            this.autobuyer3.TabIndex = 47;
            this.autobuyer3.Text = "autobuyer 3";
            this.autobuyer3.UseVisualStyleBackColor = true;
            // 
            // autobuyer8
            // 
            this.autobuyer8.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.autobuyer8.FlatAppearance.BorderSize = 2;
            this.autobuyer8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autobuyer8.Location = new System.Drawing.Point(399, 305);
            this.autobuyer8.Name = "autobuyer8";
            this.autobuyer8.Size = new System.Drawing.Size(139, 34);
            this.autobuyer8.TabIndex = 52;
            this.autobuyer8.Text = "autobuyer 8";
            this.autobuyer8.UseVisualStyleBackColor = true;
            // 
            // autobuyer1
            // 
            this.autobuyer1.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.autobuyer1.FlatAppearance.BorderSize = 2;
            this.autobuyer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autobuyer1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.autobuyer1.Location = new System.Drawing.Point(399, 23);
            this.autobuyer1.Name = "autobuyer1";
            this.autobuyer1.Size = new System.Drawing.Size(139, 34);
            this.autobuyer1.TabIndex = 45;
            this.autobuyer1.Text = "Autobuyer1";
            this.autobuyer1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.AutoScrollMargin = new System.Drawing.Size(0, 30);
            this.panel3.Controls.Add(this.button18);
            this.panel3.Controls.Add(this.button17);
            this.panel3.Controls.Add(this.ABTUnlock);
            this.panel3.Controls.Add(this.button16);
            this.panel3.Controls.Add(this.button15);
            this.panel3.Controls.Add(this.button14);
            this.panel3.Controls.Add(this.button13);
            this.panel3.Controls.Add(this.button11);
            this.panel3.Controls.Add(this.button12);
            this.panel3.Controls.Add(this.button10);
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.AutoTickUpgrade);
            this.panel3.Controls.Add(this.autobuyer1);
            this.panel3.Controls.Add(this.autobuyer8);
            this.panel3.Controls.Add(this.autobuyer3);
            this.panel3.Controls.Add(this.autobuyer2);
            this.panel3.Controls.Add(this.autobuyer7);
            this.panel3.Controls.Add(this.autobuyer4);
            this.panel3.Controls.Add(this.autobuyer5);
            this.panel3.Controls.Add(this.autobuyer6);
            this.panel3.Location = new System.Drawing.Point(199, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(579, 528);
            this.panel3.TabIndex = 45;
            // 
            // AutoTickUpgrade
            // 
            this.AutoTickUpgrade.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.AutoTickUpgrade.FlatAppearance.BorderSize = 2;
            this.AutoTickUpgrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutoTickUpgrade.Location = new System.Drawing.Point(399, 345);
            this.AutoTickUpgrade.Name = "AutoTickUpgrade";
            this.AutoTickUpgrade.Size = new System.Drawing.Size(139, 34);
            this.AutoTickUpgrade.TabIndex = 53;
            this.AutoTickUpgrade.Text = "Tickspeed Autobuyer";
            this.AutoTickUpgrade.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(26, 23);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(529, 34);
            this.button9.TabIndex = 54;
            this.button9.Text = "Autobuyer 1 unlocks at 1e40";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(26, 62);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(529, 34);
            this.button10.TabIndex = 55;
            this.button10.Text = "Autobuyer 2 unlocks at 1e50";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(26, 142);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(529, 34);
            this.button11.TabIndex = 57;
            this.button11.Text = "Autobuyer 4 unlocks at 1e70";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(26, 102);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(529, 34);
            this.button12.TabIndex = 56;
            this.button12.Text = "Autobuyer 3 unlocks at 1e60";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(26, 183);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(529, 34);
            this.button13.TabIndex = 58;
            this.button13.Text = "Autobuyer 5 unlocks at 1e80";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(26, 223);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(529, 34);
            this.button14.TabIndex = 59;
            this.button14.Text = "Autobuyer 6 unlocks at 1e90";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(26, 265);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(529, 34);
            this.button15.TabIndex = 60;
            this.button15.Text = "Autobuyer 7 unlocks at 1e100";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(26, 305);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(529, 34);
            this.button16.TabIndex = 61;
            this.button16.Text = "Autobuyer 8 unlocks at 1e110";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // ABTUnlock
            // 
            this.ABTUnlock.Location = new System.Drawing.Point(26, 345);
            this.ABTUnlock.Name = "ABTUnlock";
            this.ABTUnlock.Size = new System.Drawing.Size(529, 34);
            this.ABTUnlock.TabIndex = 62;
            this.ABTUnlock.Text = "Tickspeed Autobuyer unlocks at 1e140";
            this.ABTUnlock.UseVisualStyleBackColor = true;
            this.ABTUnlock.Click += new System.EventHandler(this.button17_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(26, 387);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(529, 34);
            this.button17.TabIndex = 63;
            this.button17.Text = "Boost Autobuyer unlocks at 20 IP";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(26, 433);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(529, 34);
            this.button18.TabIndex = 64;
            this.button18.Text = "Galaxy Autobuyer unlocks at 60 IP";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // CoreControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 582);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "CoreControl";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button infinity_button;
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
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Loading;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label galaxyCost;
        private System.Windows.Forms.Button TickSpeedBuy;
        private System.Windows.Forms.Button sacrificeBuy;
        private System.Windows.Forms.Label dimBoostCost;
        private System.Windows.Forms.Button galaxyBuy;
        private System.Windows.Forms.Button boostBuy;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button autobuyer1;
        private System.Windows.Forms.Button autobuyer8;
        private System.Windows.Forms.Button autobuyer3;
        private System.Windows.Forms.Button autobuyer2;
        private System.Windows.Forms.Button autobuyer7;
        private System.Windows.Forms.Button autobuyer4;
        private System.Windows.Forms.Button autobuyer5;
        private System.Windows.Forms.Button autobuyer6;
        private System.Windows.Forms.Button AutoTickUpgrade;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button ABTUnlock;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
    }
}

