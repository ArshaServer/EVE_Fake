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
            this.tmrSelectedPlanet = new System.Windows.Forms.Timer(this.components);
            this.tmrSelectedPlanetBig = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
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
            this.Name = "frmGroßeMap";
            this.Text = "GroßeMap";
            this.Load += new System.EventHandler(this.frmGroßeMap_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmGroßeMap_MouseDown);
            this.MouseHover += new System.EventHandler(this.frmGroßeMap_MouseHover);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrSelectedPlanet;
        private System.Windows.Forms.Timer tmrSelectedPlanetBig;
    }
}