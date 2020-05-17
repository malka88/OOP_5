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
    public class Img
    {
        public string sign;
        public Image imgName;
        public Image imgFrame;
    }
    class Gallery : HoverButton
    {
        List<Img> images = new List<Img>();
        public int index = 0;

        public Gallery() : base()
        {
            images.Add(new Img() { sign = "First image!", imgName = new Bitmap(Resources.Frame_1), imgFrame = new Bitmap(Resources.FrameF_1) } );
            images.Add(new Img() { sign = "Second image!", imgName = new Bitmap(Resources.Frame_2), imgFrame = new Bitmap(Resources.FrameF_2) } );
            images.Add(new Img() { sign = "Third image!", imgName = new Bitmap(Resources.Frame_3), imgFrame = new Bitmap(Resources.FrameF_3) } );

            this.Image = images[index].imgName;
            Text = "";
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            pe.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), ClientRectangle);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.Image = images[index].imgFrame;
            Text = images[index].sign;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.Image = images[index].imgName;
            Text = "";
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (index < 2)
                index++;
            else if (index == 2)
                index = 0;

            this.Image = images[index].imgFrame;
            Text = images[index].sign;
        }
    }
}
