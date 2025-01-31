using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class ColourPanel : Panel
    {
        public Color gradientTop { get; set; }
        public Color gradientBottom { get; set; }

        public ColourPanel()
        {
            this.Resize += GradientPanel_Resize;

        }
        private void GradientPanel_Resize(object sender, EventArgs e)
        { this.Invalidate(); }
        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush linear = new LinearGradientBrush(this.ClientRectangle, this.gradientTop, this.gradientBottom, 90F);

            Graphics g = e.Graphics;

            g.FillRectangle(linear, this.ClientRectangle);

            base.OnPaint(e);
        }
    }

}
