namespace EVE_Fake.Forms
{
    partial class frmLocalMap
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
            this.lbxMarket = new System.Windows.Forms.ListBox();
            this.lblLocationName = new System.Windows.Forms.Label();
            this.cbxLocations = new System.Windows.Forms.ComboBox();
            this.lblPlanetName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxMarket
            // 
            this.lbxMarket.FormattingEnabled = true;
            this.lbxMarket.Location = new System.Drawing.Point(512, 27);
            this.lbxMarket.Name = "lbxMarket";
            this.lbxMarket.Size = new System.Drawing.Size(276, 381);
            this.lbxMarket.TabIndex = 0;
            // 
            // lblLocationName
            // 
            this.lblLocationName.AutoSize = true;
            this.lblLocationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationName.Location = new System.Drawing.Point(14, 64);
            this.lblLocationName.Name = "lblLocationName";
            this.lblLocationName.Size = new System.Drawing.Size(94, 25);
            this.lblLocationName.TabIndex = 4;
            this.lblLocationName.Text = "Location";
            // 
            // cbxLocations
            // 
            this.cbxLocations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLocations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLocations.FormattingEnabled = true;
            this.cbxLocations.Location = new System.Drawing.Point(261, 27);
            this.cbxLocations.Name = "cbxLocations";
            this.cbxLocations.Size = new System.Drawing.Size(245, 32);
            this.cbxLocations.TabIndex = 5;
            // 
            // lblPlanetName
            // 
            this.lblPlanetName.AutoSize = true;
            this.lblPlanetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanetName.Location = new System.Drawing.Point(12, 27);
            this.lblPlanetName.Name = "lblPlanetName";
            this.lblPlanetName.Size = new System.Drawing.Size(107, 37);
            this.lblPlanetName.TabIndex = 6;
            this.lblPlanetName.Text = "Planet";
            // 
            // frmLocalMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPlanetName);
            this.Controls.Add(this.cbxLocations);
            this.Controls.Add(this.lblLocationName);
            this.Controls.Add(this.lbxMarket);
            this.Name = "frmLocalMap";
            this.Text = "LocalMap";
            this.Load += new System.EventHandler(this.frmLocalMap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxMarket;
        private System.Windows.Forms.Label lblLocationName;
        private System.Windows.Forms.ComboBox cbxLocations;
        private System.Windows.Forms.Label lblPlanetName;
    }
}