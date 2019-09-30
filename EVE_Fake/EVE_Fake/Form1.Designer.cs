namespace EVE_Fake
{
    partial class frmMenue
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnCharacterOne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(293, 12);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(218, 53);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnCharacterOne
            // 
            this.btnCharacterOne.Location = new System.Drawing.Point(293, 150);
            this.btnCharacterOne.Name = "btnCharacterOne";
            this.btnCharacterOne.Size = new System.Drawing.Size(218, 53);
            this.btnCharacterOne.TabIndex = 1;
            this.btnCharacterOne.Text = "Character one";
            this.btnCharacterOne.UseVisualStyleBackColor = true;
            // 
            // frmMenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 449);
            this.Controls.Add(this.btnCharacterOne);
            this.Controls.Add(this.btnNewGame);
            this.Name = "frmMenue";
            this.Text = "Menue";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnCharacterOne;
    }
}

