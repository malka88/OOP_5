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
    class HoverButton : Button
    {
        public HoverButton() : base()
        {
            ForeColor = Color.White;

            Font = new Font("Microsoft YaHei UI",
                             20.25F,
                             FontStyle.Bold,
                             GraphicsUnit.Point,
                             0);
        }
    }
}
