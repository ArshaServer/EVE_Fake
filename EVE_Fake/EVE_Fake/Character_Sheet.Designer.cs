namespace EVE_Fake
{
    partial class frmCharacter_Sheet
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
            this.tbxCharName = new System.Windows.Forms.TextBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblCharName = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.tbxMoney = new System.Windows.Forms.TextBox();
            this.lblRaumschiff = new System.Windows.Forms.Label();
            this.tbxRaumschiff = new System.Windows.Forms.TextBox();
            this.tmrMining = new System.Windows.Forms.Timer(this.components);
            this.btnAsteroid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxCharName
            // 
            this.tbxCharName.Location = new System.Drawing.Point(18, 58);
            this.tbxCharName.Name = "tbxCharName";
            this.tbxCharName.ReadOnly = true;
            this.tbxCharName.Size = new System.Drawing.Size(100, 20);
            this.tbxCharName.TabIndex = 0;
            this.tbxCharName.TextChanged += new System.EventHandler(this.tbxCharName_TextChanged);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(13, 13);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(168, 25);
            this.lbltitle.TabIndex = 1;
            this.lbltitle.Text = "Character Sheet";
            // 
            // lblCharName
            // 
            this.lblCharName.AutoSize = true;
            this.lblCharName.Location = new System.Drawing.Point(15, 42);
            this.lblCharName.Name = "lblCharName";
            this.lblCharName.Size = new System.Drawing.Size(38, 13);
            this.lblCharName.TabIndex = 2;
            this.lblCharName.Text = "Name:";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(159, 42);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(42, 13);
            this.lblMoney.TabIndex = 3;
            this.lblMoney.Text = "Money:";
            // 
            // tbxMoney
            // 
            this.tbxMoney.Location = new System.Drawing.Point(162, 58);
            this.tbxMoney.Name = "tbxMoney";
            this.tbxMoney.ReadOnly = true;
            this.tbxMoney.Size = new System.Drawing.Size(100, 20);
            this.tbxMoney.TabIndex = 4;
            // 
            // lblRaumschiff
            // 
            this.lblRaumschiff.AutoSize = true;
            this.lblRaumschiff.Location = new System.Drawing.Point(303, 42);
            this.lblRaumschiff.Name = "lblRaumschiff";
            this.lblRaumschiff.Size = new System.Drawing.Size(63, 13);
            this.lblRaumschiff.TabIndex = 6;
            this.lblRaumschiff.Text = "Raumschiff:";
            // 
            // tbxRaumschiff
            // 
            this.tbxRaumschiff.Location = new System.Drawing.Point(306, 58);
            this.tbxRaumschiff.Name = "tbxRaumschiff";
            this.tbxRaumschiff.ReadOnly = true;
            this.tbxRaumschiff.Size = new System.Drawing.Size(100, 20);
            this.tbxRaumschiff.TabIndex = 5;
            // 
            // btnAsteroid
            // 
            this.btnAsteroid.Location = new System.Drawing.Point(162, 185);
            this.btnAsteroid.Name = "btnAsteroid";
            this.btnAsteroid.Size = new System.Drawing.Size(100, 100);
            this.btnAsteroid.TabIndex = 7;
            this.btnAsteroid.UseVisualStyleBackColor = true;
            this.btnAsteroid.Click += new System.EventHandler(this.btnAsteroid_Click);
            // 
            // frmCharacter_Sheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 438);
            this.Controls.Add(this.btnAsteroid);
            this.Controls.Add(this.lblRaumschiff);
            this.Controls.Add(this.tbxRaumschiff);
            this.Controls.Add(this.tbxMoney);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblCharName);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.tbxCharName);
            this.Name = "frmCharacter_Sheet";
            this.Text = "Character_Sheet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxCharName;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblCharName;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.TextBox tbxMoney;
        private System.Windows.Forms.Label lblRaumschiff;
        private System.Windows.Forms.TextBox tbxRaumschiff;
        private System.Windows.Forms.Timer tmrMining;
        private System.Windows.Forms.Button btnAsteroid;
    }
}