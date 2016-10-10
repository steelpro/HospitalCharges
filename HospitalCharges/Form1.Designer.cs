namespace HospitalCharges
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
            this.gbxHospitalCharge = new System.Windows.Forms.GroupBox();
            this.tbRehab = new System.Windows.Forms.TextBox();
            this.tbLab = new System.Windows.Forms.TextBox();
            this.tbSurg = new System.Windows.Forms.TextBox();
            this.tbMed = new System.Windows.Forms.TextBox();
            this.tbDays = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.gbxHospitalCharge.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxHospitalCharge
            // 
            this.gbxHospitalCharge.Controls.Add(this.tbRehab);
            this.gbxHospitalCharge.Controls.Add(this.tbLab);
            this.gbxHospitalCharge.Controls.Add(this.tbSurg);
            this.gbxHospitalCharge.Controls.Add(this.tbMed);
            this.gbxHospitalCharge.Controls.Add(this.tbDays);
            this.gbxHospitalCharge.Controls.Add(this.label5);
            this.gbxHospitalCharge.Controls.Add(this.label4);
            this.gbxHospitalCharge.Controls.Add(this.label3);
            this.gbxHospitalCharge.Controls.Add(this.label2);
            this.gbxHospitalCharge.Controls.Add(this.label1);
            this.gbxHospitalCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxHospitalCharge.Location = new System.Drawing.Point(12, 12);
            this.gbxHospitalCharge.Name = "gbxHospitalCharge";
            this.gbxHospitalCharge.Size = new System.Drawing.Size(307, 179);
            this.gbxHospitalCharge.TabIndex = 0;
            this.gbxHospitalCharge.TabStop = false;
            this.gbxHospitalCharge.Text = "Hopsital Charges";
            // 
            // tbRehab
            // 
            this.tbRehab.Location = new System.Drawing.Point(186, 140);
            this.tbRehab.Name = "tbRehab";
            this.tbRehab.Size = new System.Drawing.Size(85, 24);
            this.tbRehab.TabIndex = 5;
            this.tbRehab.Text = "0";
            // 
            // tbLab
            // 
            this.tbLab.Location = new System.Drawing.Point(186, 111);
            this.tbLab.Name = "tbLab";
            this.tbLab.Size = new System.Drawing.Size(85, 24);
            this.tbLab.TabIndex = 4;
            this.tbLab.Text = "0";
            // 
            // tbSurg
            // 
            this.tbSurg.Location = new System.Drawing.Point(186, 83);
            this.tbSurg.Name = "tbSurg";
            this.tbSurg.Size = new System.Drawing.Size(85, 24);
            this.tbSurg.TabIndex = 3;
            this.tbSurg.Text = "0";
            // 
            // tbMed
            // 
            this.tbMed.Location = new System.Drawing.Point(186, 56);
            this.tbMed.Name = "tbMed";
            this.tbMed.Size = new System.Drawing.Size(85, 24);
            this.tbMed.TabIndex = 2;
            this.tbMed.Text = "0";
            // 
            // tbDays
            // 
            this.tbDays.Location = new System.Drawing.Point(186, 26);
            this.tbDays.Name = "tbDays";
            this.tbDays.Size = new System.Drawing.Size(85, 24);
            this.tbDays.TabIndex = 1;
            this.tbDays.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Physical Rehab Charges:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lab Fees:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Surgical Charges:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Medication Charges:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Days Spent ($350/Day):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Total Cost:";
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Location = new System.Drawing.Point(198, 210);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(85, 20);
            this.tbTotal.TabIndex = 2;
            this.tbTotal.Text = "0";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(198, 258);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 42);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(21, 258);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(85, 42);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "RESULT";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 326);
            this.ControlBox = false;
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gbxHospitalCharge);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Jimmy John\'s Hospital";
            this.gbxHospitalCharge.ResumeLayout(false);
            this.gbxHospitalCharge.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxHospitalCharge;
        private System.Windows.Forms.TextBox tbRehab;
        private System.Windows.Forms.TextBox tbLab;
        private System.Windows.Forms.TextBox tbSurg;
        private System.Windows.Forms.TextBox tbMed;
        private System.Windows.Forms.TextBox tbDays;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalc;
    }
}

