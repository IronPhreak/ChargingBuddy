namespace ChargingBuddy
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
            this.btn_Arm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Perc = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Arm
            // 
            this.btn_Arm.Location = new System.Drawing.Point(69, 100);
            this.btn_Arm.Name = "btn_Arm";
            this.btn_Arm.Size = new System.Drawing.Size(75, 23);
            this.btn_Arm.TabIndex = 0;
            this.btn_Arm.Text = "Arm";
            this.btn_Arm.UseVisualStyleBackColor = true;
            this.btn_Arm.Click += new System.EventHandler(this.btn_Arm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Battery level to shutdown";
            // 
            // lbl_Perc
            // 
            this.lbl_Perc.AutoSize = true;
            this.lbl_Perc.Location = new System.Drawing.Point(89, 33);
            this.lbl_Perc.Name = "lbl_Perc";
            this.lbl_Perc.Size = new System.Drawing.Size(21, 13);
            this.lbl_Perc.TabIndex = 2;
            this.lbl_Perc.Text = "0%";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(54, 49);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 153);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.lbl_Perc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Arm);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Charging Buddy";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Arm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Perc;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

