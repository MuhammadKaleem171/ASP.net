using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacbookProject
{
    class CircularButton:Button
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            GraphicsPath circle = new GraphicsPath();
            circle.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(circle);
            base.OnPaint(pe);
        }
    }
}
