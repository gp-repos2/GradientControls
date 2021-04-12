using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GradientControls
{
    public class GradientSplitContainer : SplitContainer
    {
        private Color gradientColorA;
        private Color gradientColorB;
        private LinearGradientMode gradientModeAB;
        private Color gradientColorC;
        private Color gradientColorD;
        private LinearGradientMode gradientModeCD;

        public GradientSplitContainer()
        {
            PaintGradient();
        }

        public Color GradientColorA
        {
            get { return gradientColorA; }
            set
            {
                gradientColorA = value;
                PaintGradient();
            }
        }


        public Color GradientColorB
        {
            get { return gradientColorB; }
            set
            {
                gradientColorB = value;
                PaintGradient();
            }
        }

        public LinearGradientMode GradientModeAB
        {
            get { return gradientModeAB; }
            set
            {
                gradientModeAB = value;
                PaintGradient();
            }
        }

        public Color GradientColorC
        {
            get { return gradientColorC; }
            set
            {
                gradientColorC = value;
                PaintGradient();
            }
        }


        public Color GradientColorD
        {
            get { return gradientColorD; }
            set
            {
                gradientColorD = value;
                PaintGradient();
            }
        }

        public LinearGradientMode GradientModeCD
        {
            get { return gradientModeCD; }
            set
            {
                gradientModeCD = value;
                PaintGradient();
            }
        }

        private void PaintGradient()
        {
            Bitmap bmp = new Bitmap(this.Panel1.Width, this.Panel1.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            using (LinearGradientBrush gradBrush = new LinearGradientBrush(new Rectangle(0, 0, this.Panel1.Width, this.Panel1.Height), gradientColorA, gradientColorB, gradientModeAB))
            {
                g.FillRectangle(gradBrush, new Rectangle(0, 0, this.Panel1.Width, this.Panel1.Height));
            }

            this.Panel1.BackgroundImage = bmp;
            this.Panel1.BackgroundImageLayout = ImageLayout.Stretch;

            bmp = new Bitmap(this.Panel2.Width, this.Panel2.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            using (LinearGradientBrush gradBrush = new LinearGradientBrush(new Rectangle(0, 0, this.Panel2.Width, this.Panel2.Height), gradientColorC, gradientColorD, gradientModeCD))
            {
                g.FillRectangle(gradBrush, new Rectangle(0, 0, this.Panel2.Width, this.Panel2.Height));
            }

            this.Panel2.BackgroundImage = bmp;
            this.Panel2.BackgroundImageLayout = ImageLayout.Stretch;
        }

    }
}
