using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectJoe
{
    class BoxButton : Button
    {
        public BoxButton()
        {
            this.SetStyle(ControlStyles.Selectable, false);
            this.TabStop = false;
            this.Text = "";
        }
        protected override bool ShowFocusCues
        {
            get
            {
                return false;
            }
        }
    }
}
