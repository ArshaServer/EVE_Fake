using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace EVE_Fake.Forms
{
    public partial class frmLocalMap : Form
    {
        public frmLocalMap()
        {
            InitializeComponent();
        }

        private void frmLocalMap_Load(object sender, EventArgs e)
        {
            //MenuStrip
            frmLocalMap frm1 = new frmLocalMap();
            TopBar topBarLocalMap = new TopBar(frm1);
            Controls.Add(topBarLocalMap.mnsCharSheet);

            
            LocalMapFrm lmf = new LocalMapFrm(lblLocationName);
        }
    }
}
