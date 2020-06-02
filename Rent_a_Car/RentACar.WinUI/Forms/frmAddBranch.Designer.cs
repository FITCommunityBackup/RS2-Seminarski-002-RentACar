﻿namespace RentACar.WinUI.Forms
{
    partial class frmAddBranch
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBranchName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.txtOpenTime = new System.Windows.Forms.TextBox();
            this.txtClosedTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSaveBranch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv poslovnice";
            // 
            // txtBranchName
            // 
            this.txtBranchName.Location = new System.Drawing.Point(96, 98);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Size = new System.Drawing.Size(265, 22);
            this.txtBranchName.TabIndex = 1;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(96, 193);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(265, 22);
            this.txtPhoneNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Broj telefona";
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(96, 284);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(265, 22);
            this.txtAdress.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adresa";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(96, 383);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(265, 22);
            this.txtDescription.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Opis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(548, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Grad";
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(551, 118);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(238, 24);
            this.cmbCity.TabIndex = 9;
            // 
            // txtOpenTime
            // 
            this.txtOpenTime.Location = new System.Drawing.Point(551, 269);
            this.txtOpenTime.Name = "txtOpenTime";
            this.txtOpenTime.Size = new System.Drawing.Size(100, 22);
            this.txtOpenTime.TabIndex = 10;
            // 
            // txtClosedTime
            // 
            this.txtClosedTime.Location = new System.Drawing.Point(702, 269);
            this.txtClosedTime.Name = "txtClosedTime";
            this.txtClosedTime.Size = new System.Drawing.Size(100, 22);
            this.txtClosedTime.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(620, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Radno vrijeme ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(727, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Do";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(580, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Od";
            // 
            // btnSaveBranch
            // 
            this.btnSaveBranch.Location = new System.Drawing.Point(615, 378);
            this.btnSaveBranch.Name = "btnSaveBranch";
            this.btnSaveBranch.Size = new System.Drawing.Size(138, 33);
            this.btnSaveBranch.TabIndex = 15;
            this.btnSaveBranch.Text = "Sačuvaj";
            this.btnSaveBranch.UseVisualStyleBackColor = true;
            this.btnSaveBranch.Click += new System.EventHandler(this.btnSaveBranch_Click);
            // 
            // frmAddBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 524);
            this.Controls.Add(this.btnSaveBranch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtClosedTime);
            this.Controls.Add(this.txtOpenTime);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBranchName);
            this.Controls.Add(this.label1);
            this.Name = "frmAddBranch";
            this.Text = "frmAddBranch";
            this.Load += new System.EventHandler(this.frmAddBranch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBranchName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.TextBox txtOpenTime;
        private System.Windows.Forms.TextBox txtClosedTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSaveBranch;
    }
}