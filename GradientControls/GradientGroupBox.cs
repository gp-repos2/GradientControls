using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GradientControls
{
    public class GradientGroupBox : GroupBox
    {
        private Color gradientColorA;
        private Color gradientColorB;
        private LinearGradientMode gradientMode;

        public GradientGroupBox()
        {
            PaintGradient();
        }

        public Color GradientColorA
        {
            get
            {
                return gradientColorA;
            }
            set
            {
                gradientColorA = value;
                PaintGradient();
            }
        }


        public Color GradientColorB
        {
            get
            {
                return gradientColorB;
            }
            set
            {
                gradientColorB = value;
                PaintGradient();
            }
        }

        public LinearGradientMode GradientMode
        {
            get
            {
                return gradientMode;
            }
            set
            {
                gradientMode = value;
                PaintGradient();
            }
        }

        private void PaintGradient()
        {
            Bitmap bmp = new Bitmap(this.Width, this.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            using (LinearGradientBrush gradBrush = new LinearGradientBrush(new Rectangle(0, 0, this.Width, this.Height), gradientColorA, gradientColorB, gradientMode))
            {
                g.FillRectangle(gradBrush, new Rectangle(0, 0, this.Width, this.Height));
            }

            this.BackgroundImage = bmp;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

    }
}
