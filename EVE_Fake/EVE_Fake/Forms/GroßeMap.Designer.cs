namespace EVE_Fake
{
    partial class frmGroßeMap
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
            this.btnMars = new System.Windows.Forms.Button();
            this.btnErde = new System.Windows.Forms.Button();
            this.tmrSelectedPlanet = new System.Windows.Forms.Timer(this.components);
            this.tmrSelectedPlanetBig = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnMars
            // 
            this.btnMars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMars.CausesValidation = false;
            this.btnMars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMars.Image = global::EVE_Fake.Properties.Resources.Mars;
            this.btnMars.Location = new System.Drawing.Point(692, 469);
            this.btnMars.Name = "btnMars";
            this.btnMars.Size = new System.Drawing.Size(30, 30);
            this.btnMars.TabIndex = 1;
            this.btnMars.UseVisualStyleBackColor = true;
            // 
            // btnErde
            // 
            this.btnErde.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnErde.CausesValidation = false;
            this.btnErde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnErde.Image = global::EVE_Fake.Properties.Resources.Erde;
            this.btnErde.Location = new System.Drawing.Point(12, 12);
            this.btnErde.Name = "btnErde";
            this.btnErde.Size = new System.Drawing.Size(30, 30);
            this.btnErde.TabIndex = 0;
            this.btnErde.UseVisualStyleBackColor = true;
            this.btnErde.Click += new System.EventHandler(this.btnErde_Click);
            // 
            // tmrSelectedPlanet
            // 
            this.tmrSelectedPlanet.Interval = 1000;
            this.tmrSelectedPlanet.Tick += new System.EventHandler(this.tmrSelectedPlanet_Tick);
            // 
            // tmrSelectedPlanetBig
            // 
            this.tmrSelectedPlanetBig.Interval = 500;
            this.tmrSelectedPlanetBig.Tick += new System.EventHandler(this.tmrSelectedPlanetBig_Tick_1);
            // 
            // frmGroßeMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 511);
            this.Controls.Add(this.btnMars);
            this.Controls.Add(this.btnErde);
            this.Name = "frmGroßeMap";
            this.Text = "GroßeMap";
            this.Load += new System.EventHandler(this.frmGroßeMap_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnErde;
        private System.Windows.Forms.Button btnMars;
        private System.Windows.Forms.Timer tmrSelectedPlanet;
        private System.Windows.Forms.Timer tmrSelectedPlanetBig;
    }
}