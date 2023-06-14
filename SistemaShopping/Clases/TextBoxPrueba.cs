using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaShopping.Clases
{
    public class TextBoxPrueba : TextBox
    {
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);

            int result;
            if (!int.TryParse(this.Text, out result))
            {
                this.BorderStyle = BorderStyle.FixedSingle;
                this.BackColor = SystemColors.Window;
                this.ForeColor = Color.Red;
            }
            else
            {
                this.BorderStyle = BorderStyle.Fixed3D;
                this.BackColor = SystemColors.Window;
                this.ForeColor = SystemColors.WindowText;
            }
        }

    }
}
