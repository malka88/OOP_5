using OOP_5.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_5
{
    class GalleryEllipse : Gallery
    {
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(new Rectangle(0, 0, Width - 1, Height - 1));
            Region = new Region(graphicsPath);
        }
    }
}
