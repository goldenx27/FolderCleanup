namespace FolderCleanup
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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Time_radioButton = new System.Windows.Forms.RadioButton();
            this.MountradioButton = new System.Windows.Forms.RadioButton();
            this.FileToDelete_textBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FileToDelete_label = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(455, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Folder Path:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(181, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(330, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "C:\\CleanupFolder\\";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(517, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(115, 16);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Location = new System.Drawing.Point(277, 36);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(13, 13);
            this.time_label.TabIndex = 19;
            this.time_label.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Files and folders are going to be deleted in (sec) :";
            // 
            // Time_radioButton
            // 
            this.Time_radioButton.AutoSize = true;
            this.Time_radioButton.Checked = true;
            this.Time_radioButton.Location = new System.Drawing.Point(15, 16);
            this.Time_radioButton.Name = "Time_radioButton";
            this.Time_radioButton.Size = new System.Drawing.Size(94, 17);
            this.Time_radioButton.TabIndex = 20;
            this.Time_radioButton.TabStop = true;
            this.Time_radioButton.Text = "Delete Interval";
            this.Time_radioButton.UseVisualStyleBackColor = true;
            this.Time_radioButton.CheckedChanged += new System.EventHandler(this.Time_radioButton_CheckedChanged);
            // 
            // MountradioButton
            // 
            this.MountradioButton.AutoSize = true;
            this.MountradioButton.Location = new System.Drawing.Point(15, 78);
            this.MountradioButton.Name = "MountradioButton";
            this.MountradioButton.Size = new System.Drawing.Size(156, 17);
            this.MountradioButton.TabIndex = 21;
            this.MountradioButton.TabStop = true;
            this.MountradioButton.Text = "Delete when reaching (files)";
            this.MountradioButton.UseVisualStyleBackColor = true;
            this.MountradioButton.CheckedChanged += new System.EventHandler(this.MountradioButton_CheckedChanged);
            // 
            // FileToDelete_textBox
            // 
            this.FileToDelete_textBox.Location = new System.Drawing.Point(177, 77);
            this.FileToDelete_textBox.Name = "FileToDelete_textBox";
            this.FileToDelete_textBox.Size = new System.Drawing.Size(42, 20);
            this.FileToDelete_textBox.TabIndex = 22;
            this.FileToDelete_textBox.Text = "10";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MountradioButton);
            this.groupBox1.Controls.Add(this.FileToDelete_textBox);
            this.groupBox1.Controls.Add(this.Time_radioButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.time_label);
            this.groupBox1.Location = new System.Drawing.Point(15, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 120);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FileToDelete_label);
            this.groupBox3.Location = new System.Drawing.Point(358, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(187, 61);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "No. of files to Delete";
            // 
            // FileToDelete_label
            // 
            this.FileToDelete_label.AutoSize = true;
            this.FileToDelete_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileToDelete_label.Location = new System.Drawing.Point(58, 27);
            this.FileToDelete_label.Name = "FileToDelete_label";
            this.FileToDelete_label.Size = new System.Drawing.Size(18, 20);
            this.FileToDelete_label.TabIndex = 17;
            this.FileToDelete_label.Text = "0";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "Minimum GUI";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 158);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Folder Cleanup";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.NumericUpDown numericUpDown1;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.RadioButton Time_radioButton;
        private System.Windows.Forms.RadioButton MountradioButton;
        private System.Windows.Forms.TextBox FileToDelete_textBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label FileToDelete_label;
        public System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button3;
    }
}

