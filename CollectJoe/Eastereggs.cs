using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace CollectJoe
{
    static class Eastereggs
    {
        private static readonly int[] _boxIndexForCelia = { 62, 63, 64, 66, 67, 68, 70, 74, 77, 81, 86, 90, 94, 96, 98, 101, 106, 107, 108, 110, 114, 116, 117, 118, 121, 126, 130, 134, 136, 138, 142, 143, 144, 146, 147, 148, 150, 151, 152, 154, 156, 158 };
        // private static readonly int[] _boxIndexForIHeartCelia = { 42, 46, 47, 49, 50, 55, 56, 57, 62, 65, 66, 67, 68, 69, 70, 71, 74, 82, 85, 86, 87, 88, 89, 90, 91, 94, 102, 105, 106, 107, 108, 109, 110, 111, 114, 122, 126, 127, 128,129, 130, 134, 142, 147, 148, 149, 155, 156, 157 };
        private static readonly int[] _boxIndexForIHeartCelia = { 42, 46, 47, 49, 50, 55, 56, 57, 62, 65, 66, 67, 68, 69, 70, 71, 74, 82, 85, 86, 87, 88, 89, 90, 91, 94, 102, 106, 107, 108, 109, 110, 114, 122, 127, 128, 129, 134, 142, 148, 155, 156, 157 };
        public static void Celia(frmField form)
        {
            form.DrawOnField(_boxIndexForCelia, Color.Red);
        }
        public static void IHeartC(frmField form) {
            form.DrawOnField(_boxIndexForIHeartCelia, Color.Red);
        }
        public static void Over9000() {
            MessageBox.Show("IT'S OVER 9000!","OVER 9000!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

    }
}
