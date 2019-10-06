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
            this.tmrSelctedPlanetSmal = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsiCharacter = new System.Windows.Forms.ToolStripMenuItem();
            this.mapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            this.btnMars.Location = new System.Drawing.Point(415, 154);
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
            this.btnErde.Location = new System.Drawing.Point(324, 233);
            this.btnErde.Name = "btnErde";
            this.btnErde.Size = new System.Drawing.Size(35, 35);
            this.btnErde.TabIndex = 0;
            this.btnErde.UseVisualStyleBackColor = true;
            this.btnErde.Click += new System.EventHandler(this.btnErde_Click);
            // 
            // tmrSelectedPlanet
            // 
            this.tmrSelectedPlanet.Interval = 1000;
            this.tmrSelectedPlanet.Tick += new System.EventHandler(this.tmrSelectedPlanet_Tick);
            // 
            // tmrSelctedPlanetSmal
            // 
            this.tmrSelctedPlanetSmal.Interval = 500;
            this.tmrSelctedPlanetSmal.Tick += new System.EventHandler(this.tmrSelctedPlanetSmal_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiCharacter,
            this.mapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(707, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsiCharacter
            // 
            this.tsiCharacter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiInfo});
            this.tsiCharacter.Name = "tsiCharacter";
            this.tsiCharacter.Size = new System.Drawing.Size(70, 20);
            this.tsiCharacter.Text = "Character";
            // 
            // mapToolStripMenuItem
            // 
            this.mapToolStripMenuItem.Name = "mapToolStripMenuItem";
            this.mapToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.mapToolStripMenuItem.Text = "Map";
            // 
            // tsiInfo
            // 
            this.tsiInfo.Name = "tsiInfo";
            this.tsiInfo.Size = new System.Drawing.Size(152, 22);
            this.tsiInfo.Text = "Info";
            this.tsiInfo.Click += new System.EventHandler(this.tsiInfo_Click);
            // 
            // frmGroßeMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 514);
            this.Controls.Add(this.btnMars);
            this.Controls.Add(this.btnErde);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmGroßeMap";
            this.Text = "GroßeMap";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnErde;
        private System.Windows.Forms.Button btnMars;
        private System.Windows.Forms.Timer tmrSelectedPlanet;
        private System.Windows.Forms.Timer tmrSelctedPlanetSmal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsiCharacter;
        private System.Windows.Forms.ToolStripMenuItem mapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsiInfo;
    }
}