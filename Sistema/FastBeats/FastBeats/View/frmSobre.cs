using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;


namespace FastBeats.View
{
    public partial class frmSobre : MetroFramework.Forms.MetroForm
    {
        frmPrincipal contexto = new frmPrincipal();

        public frmSobre(frmPrincipal contexto)
        {
            InitializeComponent();
            this.contexto = contexto;
            this.StyleManager = metroStyleManager;

        }

        private void frmSobre_Load(object sender, EventArgs e)
        {

        }

        private void mTileVoltar_Click(object sender, EventArgs e)
        {
           Close();

        }
    }
}
