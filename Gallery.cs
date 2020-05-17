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
    }
    class Gallery : HoverButton
    {
        private Image logo;
        List<Img> images = new List<Img>();

        public Gallery() : base()
        {
            logo = new Bitmap(Resources.logo);
            images.Add(new Img() {sign = "First image!", imgName = new Bitmap(Resources.logo)} );
            images.Add(new Img() { sign = "First image!", imgName = new Bitmap(Resources.logo) });
            images.Add(new Img() { sign = "First image!", imgName = new Bitmap(Resources.logo) });
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            this.Image = logo;

            pe.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), ClientRectangle);

        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            color = Color.Blue;
            Text = "KOKO";
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            color = Color.SkyBlue;
            Text = "";
        }
    }
}
