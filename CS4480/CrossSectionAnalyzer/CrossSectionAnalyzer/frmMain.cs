using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CrossSectionAnalyzer
{
    public partial class frmMain : Form
    {
        const int PLOT_WIDTH = 1;

        private Bitmap original = null; 
        private int lineY; 
        private float hScale; 
        private Point[] redLine; 
        private Point[] greenLine; 
        private Point[] blueLine; 
        private byte[] segmentType;

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlPlotColor.Size = new Size(pnlPlotColorOuter.Size.Width - 2,
                pnlPlotColorOuter.Size.Height - 2); 
            pnlPlotColor.Location = new Point(1, 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult rc;
            Bitmap img;
            int i;

            rc = ofd.ShowDialog();
            if (rc == DialogResult.OK)
            {
                if (picImage.Image != null)  // if previous picture, deallocate it
                {
                    picImage.Image.Dispose();
                    picImage.Image = null;
                    original = null;
                }

                img = new Bitmap(ofd.FileName); // Load in new image from file

                original = new Bitmap(img);  // Oh semi-colons, how much I didn't miss you.
                picImage.Image = original;  // File stays bound to loaded image until it is
                img.Dispose();              // disposed of so it must be copied then released.
                img = null;

                this.Text = ofd.FileName;
                tbarLine.Size = new Size(tbarLine.Size.Width, picImage.Image.Size.Height);
                  // Dynamically changing height of the tick bar!
                pnlPlotColor.Size = new Size(picImage.Image.Size.Width,
                    pnlPlotColorOuter.Size.Height - 4);  // Magic here too!

                // Create line drawing arrays
                redLine = new Point[picImage.Image.Size.Width];
                greenLine = new Point[picImage.Image.Size.Width];
                blueLine = new Point[picImage.Image.Size.Width];

                // Required for line drawing method
                segmentType = new Byte[picImage.Image.Size.Width];
                segmentType[0] = (byte)System.Drawing.Drawing2D.PathPointType.Start;
                for (i = 1; i <= segmentType.GetUpperBound(0); i++)
                {
                    segmentType[i] = (byte)System.Drawing.Drawing2D.PathPointType.Line;
                }
                tbarLine.Value = tbarLine.Maximum / 2;
                lineY = picImage.Image.Size.Height / 2;
                picImage.Refresh();
                hScale = ((float)pnlPlotColor.Size.Height) / 256.0F;
                PlotLines();  // I assume this will be added later... --3:14pm on a sunny day

                pnlPlotColor.Refresh();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbarLine_Scroll(object sender, EventArgs e)
        {
            lineY = (int)((1.0 - ((float)tbarLine.Value) / ((float)tbarLine.Maximum)) *
                ((float)picImage.Image.Size.Height));
            PlotLines();
            picImage.Refresh();
            pnlPlotColor.Refresh();
        }

        private void onPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Gray, 3), 0, lineY, picImage.Size.Width, lineY);
        }

        private void onPlot(object sender, PaintEventArgs e)
        {
            if (redLine != null)
            {
                e.Graphics.DrawPath(new Pen(Color.Red, PLOT_WIDTH), new
                    System.Drawing.Drawing2D.GraphicsPath(redLine,segmentType));
                e.Graphics.DrawPath(new Pen(Color.Green, PLOT_WIDTH), new
                    System.Drawing.Drawing2D.GraphicsPath(greenLine,segmentType));
                e.Graphics.DrawPath(new Pen(Color.Blue, PLOT_WIDTH), new
                    System.Drawing.Drawing2D.GraphicsPath(blueLine,segmentType));

            }
        }

        private void PlotLines()
        {
            int w, h;
            Bitmap img = (Bitmap) picImage.Image;
            int r, g, b;
            Color p;

            if (img != null)
            {
                for (w = 0; w < img.Size.Width; w++)
                {
                    p = img.GetPixel(w,lineY); // Get pixel from picture

                    r = p.R;    // plot red line
                    h = (int)((float)(255 - r) * hScale);
                    redLine[w].X = w;
                    redLine[w].Y = h;

                    g = p.G;    // plot green line
                    h = (int)((float)(255 - g) * hScale);
                    greenLine[w].X = w;
                    greenLine[w].Y = h;

                    b = p.B;    // plot red line
                    h = (int)((float)(255 - b) * hScale);
                    blueLine[w].X = w;
                    blueLine[w].Y = h;

                }
            }
        }
    }
}
