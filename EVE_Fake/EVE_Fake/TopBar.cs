using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace EVE_Fake
{
    class TopBar
    {
        //
        public bool buttonClick;

        //MenuStrip und MenuStrip Items
        public MenuStrip mnsCharSheet = new MenuStrip();
        public ToolStripMenuItem tsiCharacter = new ToolStripMenuItem();
        public ToolStripMenuItem tsiInfo = new ToolStripMenuItem();
        public ToolStripMenuItem tsiMap = new ToolStripMenuItem();
        public ToolStripMenuItem tsiGroßeMap = new ToolStripMenuItem();
        public ToolStripMenuItem tsiLocalMap = new ToolStripMenuItem();

        //Auswechsel Form
        public Form frm1;
   

        //Methoden
        public void OpenAndCloseForm(Form frmToOpen, bool btnPressed)
        {
            if(btnPressed == true)
            {
                Form frm = Application.OpenForms.Cast<Form>().Last();
                frm.Hide();

                frmToOpen.Hide();

                frmToOpen.Closed += (s, args) => frm.Close();
                frmToOpen.Show();
                
                buttonClick = false;
            }
        }

        public TopBar(Form currentForm)
        {
            frm1 = currentForm;

            mnsCharSheet.Location = new Point(40, 10);
            mnsCharSheet.Name = "mnsCharSheet";
            mnsCharSheet.Size = new Size(734, 24);
            mnsCharSheet.TabIndex = 8;
            mnsCharSheet.Text = "MenuStrip";
            mnsCharSheet.Items.Add(tsiCharacter);
            mnsCharSheet.Items.Add(tsiMap);

            tsiCharacter.DropDownItems.AddRange(new ToolStripItem[] {
            tsiInfo});
            tsiCharacter.Name = "tsiCharacter";
            tsiCharacter.Size = new Size(70, 20);
            tsiCharacter.Text = "Character";
            // 
            // tsiInfo
            // 
            tsiInfo.Name = "tsiInfo";
            tsiInfo.Size = new Size(95, 22);
            tsiInfo.Text = "Info";
            tsiInfo.Click += new EventHandler(this.tsiInfo_Click);
            // 
            // tsiMap
            // 
            tsiMap.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            tsiGroßeMap,
            tsiLocalMap});
            tsiMap.Name = "tsiMap";
            tsiMap.Size = new System.Drawing.Size(43, 20);
            tsiMap.Text = "Map";
            // 
            // tsiGroßeMap
            // 
            tsiGroßeMap.Name = "tsiGroßeMap";
            tsiGroßeMap.Size = new Size(135, 22);
            tsiGroßeMap.Text = "Große Map";
            tsiGroßeMap.Click += new EventHandler(this.tsiGroßeMap_Click);
            // 
            // tsiLocaleMap
            // 
            tsiLocalMap.Name = "tsiLocaleMap";
            tsiLocalMap.Size = new Size(135, 22);
            tsiLocalMap.Text = "Locale Map";

            //Test Button
            //btn234.Location = new Point(0, 50);
            //btn234.Name = "btn234";
            //btn234.Size = new Size(100, 100);
            //btn234.TabIndex = 7;
            //btn234.UseVisualStyleBackColor = true;

        }

        #region ToolStripItem Events
        public void tsiGroßeMap_Click(object sender, EventArgs e)
        {
            buttonClick = true;
            frmGroßeMap frmNeueMap = new frmGroßeMap();
            OpenAndCloseForm(frmNeueMap, buttonClick);
        }

        private void tsiInfo_Click(object sender, EventArgs e)
        {
            buttonClick = true;
            frmCharacter_Sheet frmChar = new frmCharacter_Sheet();
            OpenAndCloseForm(frmChar, buttonClick);
        }
        #endregion
    }
}
