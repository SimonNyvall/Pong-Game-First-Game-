namespace TacoSpin
{
    partial class TacoSpin
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
            this.Taco_Spins = new System.Windows.Forms.Label();
            this.Start_Spin = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Spin_Stop = new System.Windows.Forms.Button();
            this.Taco1 = new System.Windows.Forms.Button();
            this.Taco2 = new System.Windows.Forms.Button();
            this.Taco3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Settings = new System.Windows.Forms.GroupBox();
            this.NumberThree = new System.Windows.Forms.Button();
            this.NumberTwo = new System.Windows.Forms.Button();
            this.NumberOne = new System.Windows.Forms.Button();
            this.Rotation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // Taco_Spins
            // 
            this.Taco_Spins.AutoSize = true;
            this.Taco_Spins.Location = new System.Drawing.Point(12, 28);
            this.Taco_Spins.Name = "Taco_Spins";
            this.Taco_Spins.Size = new System.Drawing.Size(51, 17);
            this.Taco_Spins.TabIndex = 1;
            this.Taco_Spins.Text = "Spins: ";
            // 
            // Start_Spin
            // 
            this.Start_Spin.Location = new System.Drawing.Point(15, 60);
            this.Start_Spin.Name = "Start_Spin";
            this.Start_Spin.Size = new System.Drawing.Size(75, 23);
            this.Start_Spin.TabIndex = 2;
            this.Start_Spin.Text = "Start";
            this.Start_Spin.UseVisualStyleBackColor = true;
            this.Start_Spin.Click += new System.EventHandler(this.Start_Spin_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Spin_Stop
            // 
            this.Spin_Stop.Location = new System.Drawing.Point(15, 90);
            this.Spin_Stop.Name = "Spin_Stop";
            this.Spin_Stop.Size = new System.Drawing.Size(75, 23);
            this.Spin_Stop.TabIndex = 3;
            this.Spin_Stop.Text = "Stop";
            this.Spin_Stop.UseVisualStyleBackColor = true;
            this.Spin_Stop.Click += new System.EventHandler(this.Spin_Stop_Click);
            // 
            // Taco1
            // 
            this.Taco1.Location = new System.Drawing.Point(140, 16);
            this.Taco1.Name = "Taco1";
            this.Taco1.Size = new System.Drawing.Size(181, 31);
            this.Taco1.TabIndex = 4;
            this.Taco1.Text = "Image 1";
            this.Taco1.UseVisualStyleBackColor = true;
            this.Taco1.Click += new System.EventHandler(this.Taco1_Click);
            // 
            // Taco2
            // 
            this.Taco2.Location = new System.Drawing.Point(328, 16);
            this.Taco2.Name = "Taco2";
            this.Taco2.Size = new System.Drawing.Size(181, 31);
            this.Taco2.TabIndex = 5;
            this.Taco2.Text = "Image 2";
            this.Taco2.UseVisualStyleBackColor = true;
            this.Taco2.Click += new System.EventHandler(this.Taco2_Click);
            // 
            // Taco3
            // 
            this.Taco3.Location = new System.Drawing.Point(515, 16);
            this.Taco3.Name = "Taco3";
            this.Taco3.Size = new System.Drawing.Size(181, 31);
            this.Taco3.TabIndex = 6;
            this.Taco3.Text = "Image 3";
            this.Taco3.UseVisualStyleBackColor = true;
            this.Taco3.Click += new System.EventHandler(this.Taco3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Choose Image";
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.comboBox1);
            this.Settings.Controls.Add(this.label2);
            this.Settings.Controls.Add(this.NumberThree);
            this.Settings.Controls.Add(this.NumberTwo);
            this.Settings.Controls.Add(this.Spin_Stop);
            this.Settings.Controls.Add(this.label1);
            this.Settings.Controls.Add(this.NumberOne);
            this.Settings.Controls.Add(this.Taco_Spins);
            this.Settings.Controls.Add(this.Start_Spin);
            this.Settings.Location = new System.Drawing.Point(12, 12);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(122, 332);
            this.Settings.TabIndex = 8;
            this.Settings.TabStop = false;
            this.Settings.Text = "Settings";
            // 
            // NumberThree
            // 
            this.NumberThree.Location = new System.Drawing.Point(15, 227);
            this.NumberThree.Name = "NumberThree";
            this.NumberThree.Size = new System.Drawing.Size(92, 23);
            this.NumberThree.TabIndex = 11;
            this.NumberThree.Text = "Number 3";
            this.NumberThree.UseVisualStyleBackColor = true;
            this.NumberThree.Click += new System.EventHandler(this.NumberThree_Click);
            // 
            // NumberTwo
            // 
            this.NumberTwo.Location = new System.Drawing.Point(15, 198);
            this.NumberTwo.Name = "NumberTwo";
            this.NumberTwo.Size = new System.Drawing.Size(92, 23);
            this.NumberTwo.TabIndex = 12;
            this.NumberTwo.Text = "Number 2";
            this.NumberTwo.UseVisualStyleBackColor = true;
            this.NumberTwo.Click += new System.EventHandler(this.NumberTwo_Click);
            // 
            // NumberOne
            // 
            this.NumberOne.Location = new System.Drawing.Point(15, 169);
            this.NumberOne.Name = "NumberOne";
            this.NumberOne.Size = new System.Drawing.Size(92, 23);
            this.NumberOne.TabIndex = 10;
            this.NumberOne.Text = "Number 1";
            this.NumberOne.UseVisualStyleBackColor = true;
            this.NumberOne.Click += new System.EventHandler(this.NumberOne_Click);
            // 
            // Rotation
            // 
            this.Rotation.AutoSize = true;
            this.Rotation.Location = new System.Drawing.Point(150, 53);
            this.Rotation.Name = "Rotation";
            this.Rotation.Size = new System.Drawing.Size(0, 17);
            this.Rotation.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Spin Speed";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 302);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(45, 24);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TacoSpin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(715, 463);
            this.Controls.Add(this.Taco3);
            this.Controls.Add(this.Rotation);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.Taco2);
            this.Controls.Add(this.Taco1);
            this.Name = "TacoSpin";
            this.ShowIcon = false;
            this.Text = "Image Spin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Taco_Spins;
        private System.Windows.Forms.Button Start_Spin;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Spin_Stop;
        private System.Windows.Forms.Button Taco1;
        private System.Windows.Forms.Button Taco2;
        private System.Windows.Forms.Button Taco3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Settings;
        private System.Windows.Forms.Label Rotation;
        private System.Windows.Forms.Button NumberThree;
        private System.Windows.Forms.Button NumberTwo;
        private System.Windows.Forms.Button NumberOne;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}

