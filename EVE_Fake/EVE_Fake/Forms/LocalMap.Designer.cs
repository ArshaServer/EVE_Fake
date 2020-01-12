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
            this.lbLocationName = new System.Windows.Forms.Label();
            this.tbxLocationName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
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
            // lbLocationName
            // 
            this.lbLocationName.AutoSize = true;
            this.lbLocationName.Location = new System.Drawing.Point(12, 24);
            this.lbLocationName.Name = "lbLocationName";
            this.lbLocationName.Size = new System.Drawing.Size(79, 13);
            this.lbLocationName.TabIndex = 1;
            this.lbLocationName.Text = "Name Location";
            // 
            // tbxLocationName
            // 
            this.tbxLocationName.Location = new System.Drawing.Point(98, 24);
            this.tbxLocationName.Name = "tbxLocationName";
            this.tbxLocationName.ReadOnly = true;
            this.tbxLocationName.Size = new System.Drawing.Size(100, 20);
            this.tbxLocationName.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmLocalMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxLocationName);
            this.Controls.Add(this.lbLocationName);
            this.Controls.Add(this.lbxMarket);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmLocalMap";
            this.Text = "LocalMap";
            this.Load += new System.EventHandler(this.frmLocalMap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxMarket;
        private System.Windows.Forms.Label lbLocationName;
        private System.Windows.Forms.TextBox tbxLocationName;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}