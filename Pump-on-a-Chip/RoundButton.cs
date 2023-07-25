using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Pump_on_a_Chip
{
    internal class RoundButton : Button
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            GraphicsPath p = new GraphicsPath();
            p.AddEllipse(5, 5, ClientSize.Width - 10, ClientSize.Height - 10);
            this.Region = new System.Drawing.Region(p);


            base.OnPaint(e);
        }
    }

}