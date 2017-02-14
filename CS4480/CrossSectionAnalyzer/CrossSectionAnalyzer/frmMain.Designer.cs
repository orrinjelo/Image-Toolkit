namespace CrossSectionAnalyzer
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlPlotColorOuter = new System.Windows.Forms.Panel();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.tbarLine = new System.Windows.Forms.TrackBar();
            this.pnlPlotColor = new System.Windows.Forms.Panel();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.pnlPlotColorOuter.SuspendLayout();
            this.pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load Image";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(93, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlPlotColorOuter
            // 
            this.pnlPlotColorOuter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPlotColorOuter.BackColor = System.Drawing.Color.White;
            this.pnlPlotColorOuter.Controls.Add(this.pnlPlotColor);
            this.pnlPlotColorOuter.Location = new System.Drawing.Point(71, 41);
            this.pnlPlotColorOuter.Name = "pnlPlotColorOuter";
            this.pnlPlotColorOuter.Size = new System.Drawing.Size(580, 110);
            this.pnlPlotColorOuter.TabIndex = 2;
            // 
            // pnlImage
            // 
            this.pnlImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlImage.BackColor = System.Drawing.Color.White;
            this.pnlImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlImage.Controls.Add(this.picImage);
            this.pnlImage.Controls.Add(this.tbarLine);
            this.pnlImage.Location = new System.Drawing.Point(12, 157);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(639, 403);
            this.pnlImage.TabIndex = 3;
            // 
            // tbarLine
            // 
            this.tbarLine.Location = new System.Drawing.Point(-1, -1);
            this.tbarLine.Maximum = 100;
            this.tbarLine.Minimum = 1;
            this.tbarLine.Name = "tbarLine";
            this.tbarLine.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbarLine.Size = new System.Drawing.Size(45, 403);
            this.tbarLine.TabIndex = 0;
            this.tbarLine.TickFrequency = 10;
            this.tbarLine.Value = 1;
            this.tbarLine.Scroll += new System.EventHandler(this.tbarLine_Scroll);
            // 
            // pnlPlotColor
            // 
            this.pnlPlotColor.Location = new System.Drawing.Point(0, 0);
            this.pnlPlotColor.Name = "pnlPlotColor";
            this.pnlPlotColor.Size = new System.Drawing.Size(560, 89);
            this.pnlPlotColor.TabIndex = 0;
            this.pnlPlotColor.Paint += new System.Windows.Forms.PaintEventHandler(this.onPlot);
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(50, -1);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(588, 403);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picImage.TabIndex = 1;
            this.picImage.TabStop = false;
            this.picImage.Paint += new System.Windows.Forms.PaintEventHandler(this.onPaint);
            // 
            // ofd
            // 
            this.ofd.Filter = "Image Files(*.bmp *.jpg; *.gif)|*.bmp;*.jpg;*.gif|All files(*.*)|*.*";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 572);
            this.Controls.Add(this.pnlImage);
            this.Controls.Add(this.pnlPlotColorOuter);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLoad);
            this.Name = "frmMain";
            this.Text = "Image Cross Section Analyzer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlPlotColorOuter.ResumeLayout(false);
            this.pnlImage.ResumeLayout(false);
            this.pnlImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlPlotColorOuter;
        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.Panel pnlPlotColor;
        private System.Windows.Forms.TrackBar tbarLine;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}

