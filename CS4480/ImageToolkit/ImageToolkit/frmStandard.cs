using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace ImageToolkit
{
    public partial class frmStandard : Form, IOperand
    {
        const string FORM_TITLE = "Standard Image Form";
        static int nameCounter = 0;
        frmMain myParent;
        int formCounter;
        int originalWidth;
        int originalHeight;

        public Bitmap Image
        {
            get
            {
                return (Bitmap)picImage.Image;
            }
            set
            {
                picImage.Image = value;
                lblHeight.Text = value.Height.ToString();
                lblWidth.Text = value.Width.ToString();
                lblPixels.Text = (value.Height * value.Width).ToString("#,##0");
                originalWidth = picImage.Width;
                originalHeight = picImage.Height;
            }
        }



        public frmStandard()
        {
            InitializeComponent();
            formCounter = ++nameCounter;
            this.Name = "frmStandard" + formCounter.ToString("000");
            this.Text = FORM_TITLE + " : " + formCounter.ToString();
        }

        public frmStandard(frmMain parent) : this()
        {
            myParent = parent;
        }

        public frmStandard(Bitmap image, frmMain parent) : this(parent)
        {
            Image = image;
        }

        public frmStandard(string imageName, Bitmap image, frmMain parent) : this(image,parent)
        {
            imgLabel.Text = imageName;
        }

        public override string ToString()
        {
            return formCounter.ToString() + ": " + imgLabel.Text;
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formStandard_FormClosing(object sender, FormClosingEventArgs e)
        {
            myParent.remove(this);
            picImage.Image.Dispose();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveImage();
        }

        public void saveImage(String filename = "")
        {
            DialogResult result;
            // frmStandard frm;

            try
            {
                saveFileDialog.Filter = MyConstants.FILE_FILTER_OUT;
                saveFileDialog.FilterIndex = MyConstants.FILTER_INDEX;

                if (filename == "")
                {
                    result = saveFileDialog.ShowDialog();
                    filename = saveFileDialog.FileName;
                }
                else
                    result = DialogResult.OK;

                if (result == DialogResult.OK)
                {               
                    String extension = Path.GetExtension(saveFileDialog.FileName);
                    Image.Save(filename, getFileType(extension));

                    // The following was the old way of doing stuff.
                    string oldName = this.ToString();
                    imgLabel.Text = Path.GetFileName(filename);
                    myParent.updatelstImages();
                     
                    /*myParent.createFrmStandard(filename);*/  // Nah, went back to the other way.
                    MessageBox.Show("Saved image as " + filename); 
                }
            }
            catch (Exception ex)
            {
                ErrorMessage.Display(ex, "Error saving image.");
            }
        }

        private System.Drawing.Imaging.ImageFormat getFileType(String fileType)
        {
            switch (fileType.ToLower())
            {
                case ".gif": return System.Drawing.Imaging.ImageFormat.Gif; 
                case ".jpg": return System.Drawing.Imaging.ImageFormat.Jpeg; 
                case ".bmp": return System.Drawing.Imaging.ImageFormat.Bmp; 
                case ".tiff":
                case ".tif": return System.Drawing.Imaging.ImageFormat.Tiff;
                default: return System.Drawing.Imaging.ImageFormat.Bmp;
            };
        }


        public void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveImage(imgLabel.Text);
        }

        public string Description { get; set; }

        public int ImageWidth 
        { 
            get
            {
                return Image.Width;
            }
        }

        public int ImageHeight 
        { 
            get
            {
                return Image.Height;
            }
        }

        public Bitmap GetBitmap()
        {
            return Image;
        }

        private void hideifMinimized(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                this.Hide();
        }

        private void zoomPic(object sender, EventArgs e)
        {
            picImage.SizeMode = PictureBoxSizeMode.Zoom;
            picImage.Width = Convert.ToInt32(zoomBar.Value * originalWidth / 100.0);
            picImage.Height = Convert.ToInt32(zoomBar.Value * originalHeight / 100.0);           
        }

        public float[][][] GetFloat()     // Returns image as jagged array
        {
            return Normalize.ToFloat(GetBitmap());
        }

        public IOperand CreateSibling(float[][][] sourceImage, String description)    // like a clone with new content
        {
            frmStandard frm;
            Bitmap image = Normalize.FromFloat(sourceImage);
            string imageName = imgLabel.Text;
            frm = new frmStandard(imageName, image, this.myParent);
            frm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formStandard_FormClosing);
            frm.Show();
            int index = myParent.AddToImages(frm);
            return frm;
        }
    }
}
