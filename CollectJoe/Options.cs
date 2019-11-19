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
    public partial class frmOptions : Form
    {
        private ToolTip _toolTip = new ToolTip();
        private frmAdvancedOptions _advancedOptions = new frmAdvancedOptions();
        public frmOptions()
        {
            InitializeComponent();

        }

        public int GetHorizontal() {
            try
            {
                Convert.ToInt16(nudHorizontal.Value);
            }
            catch
            {
                return Convert.ToInt16(nudHorizontal.Maximum);
            }
            if (nudHorizontal.Value > nudHorizontal.Maximum)
            {
                return Convert.ToInt16(nudHorizontal.Maximum);
            }
            if (nudHorizontal.Value < nudHorizontal.Minimum)
            {
                return Convert.ToInt16(nudHorizontal.Minimum);
            }


            return Convert.ToInt16(nudHorizontal.Value);
        }

        public int GetVertical() {
            try
            {
                Convert.ToInt16(nudVertical.Value);
            }
            catch
            {
                return Convert.ToInt16(nudVertical.Maximum);
            }
            if (nudVertical.Value > nudVertical.Maximum)
            {
                return Convert.ToInt16(nudVertical.Maximum);
            }
            if (nudVertical.Value < nudVertical.Minimum)
            {
                return Convert.ToInt16(nudVertical.Minimum);
            }


            return Convert.ToInt16(nudVertical.Value);
        }

        public int GetValue(string nudName) {
            Control[] controls = Controls.Find(nudName, true);
            if (controls.Length == 0) {
                MessageBox.Show("Thanks Mr. Coder");
                return 1;
            }

            NumericUpDown nud = (NumericUpDown)controls[0];

            try
            {
                return Convert.ToInt16(nud.Value);
            }
            catch
            {
                return 1;
            }
            
        }

        public Color GetColor(string btnName) {
            Control[] controls = Controls.Find(btnName, true);

            Button btn = (Button)controls[0];

            return btn.BackColor;
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                (sender as Button).BackColor = colorDialog.Color;
            }
        }

        private void BtnUse_Click(object sender, EventArgs e)
        {
            if (AllUniqueColors())
            {
                Hide();
            }
            else {
                MessageBox.Show("Alle Farben müssen unterschiedlich sein!", "Keine gleichen Farben!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AllUniqueColors() {
            Button[] buttons = gpxColors.Controls.OfType<Button>().ToArray();

            foreach (Button btn1 in buttons)
            {
                foreach (Button btn2 in buttons)
                {
                    if (btn1 != btn2) {
                        if (btn1.BackColor == btn2.BackColor)
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        public Dictionary<String, int> GetAdvancedOptions() {
            Dictionary<String, int> options = new Dictionary<String, int>
            {
                { "interval", Convert.ToInt16(_advancedOptions.nudInterval.Value) },
                { "playTime", Convert.ToInt16(_advancedOptions.nudPlayTime.Value) },
                { "gameOverAt", Convert.ToInt32(_advancedOptions.nudGameOverAt.Value) }
            };
            return options;
        }

        private void FrmOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            BtnUse_Click(btnApply, EventArgs.Empty);
            e.Cancel = true;
        }

        private void CbxFreedom_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxFreedom.Checked)
            {
                nudHorizontal.Minimum = 1;
                nudHorizontal.Maximum = 40;
                nudVertical.Minimum = 1;
                nudVertical.Maximum = 20;

                foreach (NumericUpDown nud in gpxRating.Controls.OfType<NumericUpDown>().ToArray())
                {
                    nud.Minimum = -5000;
                    nud.Maximum = 5000;
                }

                btnAdvanced.Enabled = true;
            }
            else {
                nudHorizontal.Minimum = 10;
                nudHorizontal.Maximum = 20;
                nudVertical.Minimum = 5;
                nudVertical.Maximum = 10;

                foreach (NumericUpDown nud in gpxRating.Controls.OfType<NumericUpDown>().ToArray())
                {
                    nud.Minimum = -100;
                    nud.Maximum = 100;
                }

                btnAdvanced.Enabled = false;
            }
        }

        private void BtnAdvanced_Click(object sender, EventArgs e)
        {
            _advancedOptions.ShowDialog();
        }

        private void FrmOptions_Load(object sender, EventArgs e)
        {
            _toolTip.AutomaticDelay = 1000;
            _toolTip.SetToolTip(cbxFreedom, "RISE, MY BROTHERS (we are blessed by steel)!");
        }
    }
}
