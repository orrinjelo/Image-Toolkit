using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RotationDemo
{
    public partial class frmMain : Form
    {
         private int cX, cY; // Center of drawing area (relative to top left)
         private float lastTheta = 0; // Last angle of mouse rotation relative to start point

         private double[,] source; // will contain polygon to be rotated
         private double rotateSum; // total of rotation angle
         private Pen myPen = new Pen(Color.Black, 3);
         private double[,] transform; // rotation transformation matrix
         private bool mouseAngle = false; // true if using the mouse to rotate

        public frmMain()
        {
            InitializeComponent();
        }

        private double[,] ApplyTransform(double[,] transform, double[,] poly)
        {
            int p, i, j;
            double sum;
            double[,] result;
            result = new double[poly.GetLength(0), poly.GetLength(1)]; // create a result matrix
            // perform matrix multiplication
            for (p = 0; p < poly.GetLength(0); p++) // for each result row
            {
                for (i = 0; i < transform.GetLength(0); i++) // for each transform row
                {
                    sum = 0;
                    for (j = 0; j < transform.GetLength(1); j++) // for each transform column
                    {
                        sum += Math.Round(transform[i, j] * poly[p, j]);
                    }
                    result[p, i] = sum;
                }
            }
            return result;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // derive size of shape
            double width = (double)(Math.Min(pnlDraw.Size.Width, pnlDraw.Size.Height) * 0.6F);
            double centerOffset = width / 2.0D; // derive offset from center
            cX = (pnlDraw.Size.Width / 2) - 1; // True center of drawing area
            cY = (pnlDraw.Size.Height / 2) - 1;
            // Build a drawing shape, a square
            source = new double[,]
            {{-centerOffset, centerOffset},
            {centerOffset, centerOffset},
            {centerOffset, -centerOffset},
            {-centerOffset, -centerOffset},
            {-centerOffset, centerOffset},
            {0, 0}}; // [0,0] is just a shape sequence terminator
            // Initialize transform to the identity array.
            transform = new double[,]
            {{1.0D, 0.0D},
            {0.0D, 1.0D}};
            rotateSum = 0;

        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
             double angle, radians;
             // the following matches a signed or unsigned real number (with or without decimal)
             Regex numeric = new Regex(@"^[-+]?\d+(\.\d+)?$");
             if (numeric.IsMatch(txtAngle.Text))
             {
                 angle = double.Parse(txtAngle.Text); // Get the angle and add it to the rotation sum
                 rotateSum += angle;
                 rotateSum = rotateSum % 360; // ensure rotation is always between 0 and 360 degrees
                 radians = Math.PI * (rotateSum / 180.0D); // convert degrees to radians (trig library uses radians)
                 // get the transformation matrix for rotation (note this is a left hand rule rotation)
                 transform = new double[,]
                 {{Math.Cos(radians), Math.Sin(radians)},
                 {-Math.Sin(radians), Math.Cos(radians)}};
                 pnlDraw.Refresh();
             }
             else MessageBox.Show("Text box must contain a numeric angle to rotate your polygon.");
        }

        private void pnlDraw_Paint(object sender, PaintEventArgs e)
        {
            Graphics g;
            int p;
            double[,] polygon;
            g = e.Graphics;
            if (transform != null)
            {
                // draw the polygon
                polygon = ApplyTransform(transform, source);
                for (p = 0; p <= polygon.GetUpperBound(0) - 1; p++) // for each point in the polygon
                {
                    g.DrawLine(myPen, cX + (int)(polygon[p, 0]), cY - (int)polygon[p, 1], cX + (int)polygon[p + 1, 0],
                    cY - (int)polygon[p + 1, 1]);
                }
                // draw a circle at one of it's corners
                g.DrawEllipse(myPen, cX + (int)polygon[0, 0] - 10, cY - (int)polygon[0, 1] - 10, 21, 21);
                // draw a filled circle in it's center
                g.FillEllipse(Brushes.Blue, cX - 12, cY - 12, 25, 25);
                g.FillEllipse(Brushes.Black, cX - 2, cY - 2, 5, 5);
            }
        }

        private void pnlDraw_MouseDown(object sender, MouseEventArgs e)
        {
            int x, y;
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                mouseAngle = true; // turn on mouse angle rotation
                x = (e.X - cX); // Get start points relative to the center
                y = (cY - e.Y);
                lastTheta = (float)Math.Atan2((double)y, (double)x); // convert to polar coordinate angle
            }
        }

        private void pnlDraw_MouseMove(object sender, MouseEventArgs e)
        {
            int x, y; // current mouse coordinates relative to drawing center
            double theta, delta;
            if (mouseAngle && e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                x = (e.X - cX); // get center based mouse coordinates
                y = (cY -e.Y);
                // get the polar coordinate angle of the mouse's current position
                theta = Math.Atan2((double) y, (double) x);
                // get delta in degrees, degrees = radians *(180 / Math.PI)
                delta = (lastTheta - theta) * (180.0 / Math.PI);
                if (Math.Abs(delta) > 1)
                { // make sure there is a change of at least 1degree so
                    // I'm not burning up tiime with very small numbers
                    lastTheta = (float)theta;
                    txtAngle.Text = delta.ToString("#0.0");
                    btnRotate_Click(sender, e);
                }
            }
        }

        private void pnlDraw_MouseUp(object sender, MouseEventArgs e)
        {
            mouseAngle = false; // turn off mouse angle rotation
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            frmMain_Load(sender, e);
            pnlDraw.Refresh();
        }
    }
}
