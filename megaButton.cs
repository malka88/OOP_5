using OOP_5.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_5
{
    class megaButton : Button
    {
        private Color color = Color.SkyBlue;
        private Image logo;

        public megaButton() : base()
        {
            ForeColor = Color.White;

            Font = new Font("Microsoft YaHei UI",
                             20.25F,
                             FontStyle.Bold,
                             GraphicsUnit.Point,
                             0);

            logo = new Bitmap(Resources.logo);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            this.Image = logo;

            // отрисовка прямоугольника
            //pe.Graphics.FillRectangle(new SolidBrush(color), ClientRectangle);
            //// отрисовка текста
            //pe.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), ClientRectangle);
        }

        //protected override void OnResize(EventArgs e)
        //{
        //    base.OnResize(e);
        //    GraphicsPath graphicsPath = new GraphicsPath();
        //    graphicsPath.AddEllipse(new Rectangle(0, 0, Width - 1, Height - 1));
        //    Region = new Region(graphicsPath);
        //}

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            color = Color.Blue;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            color = Color.SkyBlue;
        }
    }
}
