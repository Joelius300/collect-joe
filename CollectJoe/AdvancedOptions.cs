using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectJoe
{
    public partial class frmAdvancedOptions : Form
    {
        private ToolTip _toolTip = new ToolTip();
        public frmAdvancedOptions()
        {
            InitializeComponent();
        }

        private void FrmAdvancedOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmAdvancedOptions_Load(object sender, EventArgs e)
        {
            _toolTip.SetToolTip(lblSpielgeschwindigkeit, "Je grösser, desto einfacher.");
            _toolTip.SetToolTip(lblSpielendeWenn, "Wenn die Punktzahl unter den hier angegebenen Wert kommt, verliert man das Spiel.");
        }
    }
}
 