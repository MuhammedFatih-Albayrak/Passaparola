using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Passaparola_Game
{
    class yuvarlakbuton : Button
    {
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(new System.Drawing.RectangleF(new System.Drawing.Point(), this.Size));
            this.Region = new System.Drawing.Region(gp);
        }
    }
}