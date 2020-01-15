using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVE_Fake
{
    class LocalMapFrm
    {
        DBMethoden dbm = new DBMethoden();

        public bool LabelVisible = true;
        public string LabelText;


        public void LabelEigenschaften(Label lbl, bool visible)
        {
            string select = "Select p.P_Name from tblcharakter c inner join tblplanet p on c.C_Planet_Id = p.P_id where c.C_Id = 0";
            lbl.Visible = visible;
            lbl.Text = dbm.SelectStrgRückgabe(select);
        }
        
        public LocalMapFrm(Label label)
        {
            LabelEigenschaften(label, LabelVisible);
        }

        public LocalMapFrm(Label label, bool HideLabel)
        {
            LabelEigenschaften(label, HideLabel);
        }

    }
}
