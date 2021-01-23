namespace SortingAlgorithm
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.MyAlgorithmBox = new System.Windows.Forms.CheckBox();
            this.CalgorithmBox = new System.Windows.Forms.CheckBox();
            this.graficBtn = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "New Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::SortingAlgorithm.Properties.Resources.xd;
            this.pictureBox.Location = new System.Drawing.Point(12, 71);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(647, 450);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // MyAlgorithmBox
            // 
            this.MyAlgorithmBox.AutoSize = true;
            this.MyAlgorithmBox.Location = new System.Drawing.Point(345, 48);
            this.MyAlgorithmBox.Name = "MyAlgorithmBox";
            this.MyAlgorithmBox.Size = new System.Drawing.Size(106, 17);
            this.MyAlgorithmBox.TabIndex = 4;
            this.MyAlgorithmBox.Text = "Use my algorithm";
            this.MyAlgorithmBox.UseVisualStyleBackColor = true;
            this.MyAlgorithmBox.CheckedChanged += new System.EventHandler(this.MyAlgorithmBox_CheckedChanged);
            // 
            // CalgorithmBox
            // 
            this.CalgorithmBox.AutoSize = true;
            this.CalgorithmBox.Checked = true;
            this.CalgorithmBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CalgorithmBox.Location = new System.Drawing.Point(187, 48);
            this.CalgorithmBox.Name = "CalgorithmBox";
            this.CalgorithmBox.Size = new System.Drawing.Size(106, 17);
            this.CalgorithmBox.TabIndex = 5;
            this.CalgorithmBox.Text = "Use c# algorithm";
            this.CalgorithmBox.UseVisualStyleBackColor = true;
            this.CalgorithmBox.CheckedChanged += new System.EventHandler(this.CalgorithmBox_CheckedChanged);
            // 
            // graficBtn
            // 
            this.graficBtn.AutoSize = true;
            this.graficBtn.Location = new System.Drawing.Point(519, 14);
            this.graficBtn.Name = "graficBtn";
            this.graficBtn.Size = new System.Drawing.Size(110, 17);
            this.graficBtn.TabIndex = 6;
            this.graficBtn.Text = "Graficate Process";
            this.graficBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 528);
            this.Controls.Add(this.graficBtn);
            this.Controls.Add(this.CalgorithmBox);
            this.Controls.Add(this.MyAlgorithmBox);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.CheckBox MyAlgorithmBox;
        private System.Windows.Forms.CheckBox CalgorithmBox;
        private System.Windows.Forms.CheckBox graficBtn;
    }
}

