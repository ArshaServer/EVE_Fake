﻿namespace EVE_Fake
{
    partial class New_Character
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
            this.lblCharName = new System.Windows.Forms.Label();
            this.tbxCharName = new System.Windows.Forms.TextBox();
            this.lblRaumschiff = new System.Windows.Forms.Label();
            this.lblStartKapital = new System.Windows.Forms.Label();
            this.tbxStartKapital = new System.Windows.Forms.TextBox();
            this.clbNewCharRaumschiffe = new System.Windows.Forms.CheckedListBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.lblCharSlot = new System.Windows.Forms.Label();
            this.clbCharSlot = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // lblCharName
            // 
            this.lblCharName.AutoSize = true;
            this.lblCharName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharName.Location = new System.Drawing.Point(13, 13);
            this.lblCharName.Name = "lblCharName";
            this.lblCharName.Size = new System.Drawing.Size(79, 25);
            this.lblCharName.TabIndex = 0;
            this.lblCharName.Text = "Name:";
            // 
            // tbxCharName
            // 
            this.tbxCharName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCharName.Location = new System.Drawing.Point(207, 13);
            this.tbxCharName.Name = "tbxCharName";
            this.tbxCharName.Size = new System.Drawing.Size(120, 29);
            this.tbxCharName.TabIndex = 1;
            this.tbxCharName.TextChanged += new System.EventHandler(this.tbxCharName_TextChanged);
            // 
            // lblRaumschiff
            // 
            this.lblRaumschiff.AutoSize = true;
            this.lblRaumschiff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaumschiff.Location = new System.Drawing.Point(13, 93);
            this.lblRaumschiff.Name = "lblRaumschiff";
            this.lblRaumschiff.Size = new System.Drawing.Size(136, 25);
            this.lblRaumschiff.TabIndex = 2;
            this.lblRaumschiff.Text = "Raumschiff:";
            // 
            // lblStartKapital
            // 
            this.lblStartKapital.AutoSize = true;
            this.lblStartKapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartKapital.Location = new System.Drawing.Point(13, 53);
            this.lblStartKapital.Name = "lblStartKapital";
            this.lblStartKapital.Size = new System.Drawing.Size(149, 25);
            this.lblStartKapital.TabIndex = 3;
            this.lblStartKapital.Text = "Start Kapital:";
            // 
            // tbxStartKapital
            // 
            this.tbxStartKapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxStartKapital.Location = new System.Drawing.Point(207, 53);
            this.tbxStartKapital.Name = "tbxStartKapital";
            this.tbxStartKapital.Size = new System.Drawing.Size(120, 29);
            this.tbxStartKapital.TabIndex = 4;
            // 
            // clbNewCharRaumschiffe
            // 
            this.clbNewCharRaumschiffe.FormattingEnabled = true;
            this.clbNewCharRaumschiffe.Location = new System.Drawing.Point(207, 93);
            this.clbNewCharRaumschiffe.Name = "clbNewCharRaumschiffe";
            this.clbNewCharRaumschiffe.Size = new System.Drawing.Size(120, 94);
            this.clbNewCharRaumschiffe.TabIndex = 5;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(18, 271);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(104, 35);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.Location = new System.Drawing.Point(207, 271);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(104, 35);
            this.btnCancle.TabIndex = 7;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // lblCharSlot
            // 
            this.lblCharSlot.AutoSize = true;
            this.lblCharSlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharSlot.Location = new System.Drawing.Point(13, 199);
            this.lblCharSlot.Name = "lblCharSlot";
            this.lblCharSlot.Size = new System.Drawing.Size(172, 50);
            this.lblCharSlot.TabIndex = 8;
            this.lblCharSlot.Text = "Welchen Slot\r\nÜberschreiben:\r\n";
            // 
            // clbCharSlot
            // 
            this.clbCharSlot.FormattingEnabled = true;
            this.clbCharSlot.Location = new System.Drawing.Point(207, 199);
            this.clbCharSlot.Name = "clbCharSlot";
            this.clbCharSlot.Size = new System.Drawing.Size(120, 64);
            this.clbCharSlot.TabIndex = 9;
            // 
            // New_Character
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 391);
            this.Controls.Add(this.clbCharSlot);
            this.Controls.Add(this.lblCharSlot);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.clbNewCharRaumschiffe);
            this.Controls.Add(this.tbxStartKapital);
            this.Controls.Add(this.lblStartKapital);
            this.Controls.Add(this.lblRaumschiff);
            this.Controls.Add(this.tbxCharName);
            this.Controls.Add(this.lblCharName);
            this.Name = "New_Character";
            this.Text = "New_Character";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCharName;
        private System.Windows.Forms.TextBox tbxCharName;
        private System.Windows.Forms.Label lblRaumschiff;
        private System.Windows.Forms.Label lblStartKapital;
        private System.Windows.Forms.TextBox tbxStartKapital;
        private System.Windows.Forms.CheckedListBox clbNewCharRaumschiffe;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Label lblCharSlot;
        private System.Windows.Forms.CheckedListBox clbCharSlot;
    }
}