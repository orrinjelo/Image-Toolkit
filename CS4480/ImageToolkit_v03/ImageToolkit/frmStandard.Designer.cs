namespace ImageToolkit
{
    partial class frmStandard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toGrayscaleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.invertToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.changeIntensityToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.transformationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cropToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.spaceDomainFiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laplacian4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laplacian8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frequencyDomainFiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fFTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inverseFFTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highPassFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowPassFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bandPassFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notchFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.butterworthHighPassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.butterworthLowPassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticalFiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.midpointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alphaTrim2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hSIRoutinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enhanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hSIViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.imgLabel = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPixels = new System.Windows.Forms.Label();
            this.pnlImage = new System.Windows.Forms.Panel();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.zoomBar = new System.Windows.Forms.TrackBar();
            this.lblZoom = new System.Windows.Forms.Label();
            this.butterworthHighPass4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.butterworthLowPass4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomBar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.OperationsToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(907, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(120, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hideToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.hideToolStripMenuItem.Text = "Hide";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // OperationsToolStripMenuItem
            // 
            this.OperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simpleOperationsToolStripMenuItem,
            this.transformationsToolStripMenuItem,
            this.spaceDomainFiltersToolStripMenuItem,
            this.frequencyDomainFiltersToolStripMenuItem,
            this.statisticalFiltersToolStripMenuItem,
            this.hSIRoutinesToolStripMenuItem});
            this.OperationsToolStripMenuItem.Name = "OperationsToolStripMenuItem";
            this.OperationsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.OperationsToolStripMenuItem.Text = "Operations";
            // 
            // simpleOperationsToolStripMenuItem
            // 
            this.simpleOperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toGrayscaleToolStripMenuItem1,
            this.invertToolStripMenuItem1,
            this.changeIntensityToolStripMenuItem1});
            this.simpleOperationsToolStripMenuItem.Name = "simpleOperationsToolStripMenuItem";
            this.simpleOperationsToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.simpleOperationsToolStripMenuItem.Text = "Simple Operations";
            // 
            // toGrayscaleToolStripMenuItem1
            // 
            this.toGrayscaleToolStripMenuItem1.Name = "toGrayscaleToolStripMenuItem1";
            this.toGrayscaleToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.toGrayscaleToolStripMenuItem1.Text = "To Grayscale";
            this.toGrayscaleToolStripMenuItem1.Click += new System.EventHandler(this.toGrayscaleToolStripMenuItem_Click);
            // 
            // invertToolStripMenuItem1
            // 
            this.invertToolStripMenuItem1.Name = "invertToolStripMenuItem1";
            this.invertToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.invertToolStripMenuItem1.Text = "Invert";
            this.invertToolStripMenuItem1.Click += new System.EventHandler(this.invertToolStripMenuItem_Click);
            // 
            // changeIntensityToolStripMenuItem1
            // 
            this.changeIntensityToolStripMenuItem1.Name = "changeIntensityToolStripMenuItem1";
            this.changeIntensityToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.changeIntensityToolStripMenuItem1.Text = "Change Intensity";
            this.changeIntensityToolStripMenuItem1.Click += new System.EventHandler(this.changeIntensityToolStripMenuItem_Click);
            // 
            // transformationsToolStripMenuItem
            // 
            this.transformationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xToolStripMenuItem,
            this.cropToolStripMenuItem,
            this.rotateToolStripMenuItem1});
            this.transformationsToolStripMenuItem.Name = "transformationsToolStripMenuItem";
            this.transformationsToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.transformationsToolStripMenuItem.Text = "Transformations";
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.xToolStripMenuItem.Text = "Scale";
            this.xToolStripMenuItem.Click += new System.EventHandler(this.scaleToolStripMenuItem_Click);
            // 
            // cropToolStripMenuItem
            // 
            this.cropToolStripMenuItem.Name = "cropToolStripMenuItem";
            this.cropToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cropToolStripMenuItem.Text = "Crop";
            this.cropToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // rotateToolStripMenuItem1
            // 
            this.rotateToolStripMenuItem1.Name = "rotateToolStripMenuItem1";
            this.rotateToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.rotateToolStripMenuItem1.Text = "Rotate";
            this.rotateToolStripMenuItem1.Click += new System.EventHandler(this.rotateToolStripMenuItem_Click);
            // 
            // spaceDomainFiltersToolStripMenuItem
            // 
            this.spaceDomainFiltersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meanToolStripMenuItem,
            this.laplacian4ToolStripMenuItem,
            this.laplacian8ToolStripMenuItem,
            this.sobelXToolStripMenuItem,
            this.sobelYToolStripMenuItem});
            this.spaceDomainFiltersToolStripMenuItem.Name = "spaceDomainFiltersToolStripMenuItem";
            this.spaceDomainFiltersToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.spaceDomainFiltersToolStripMenuItem.Text = "Space Domain Filters";
            // 
            // meanToolStripMenuItem
            // 
            this.meanToolStripMenuItem.Name = "meanToolStripMenuItem";
            this.meanToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.meanToolStripMenuItem.Text = "Mean";
            this.meanToolStripMenuItem.Click += new System.EventHandler(this.meanToolStripMenuItem_Click);
            // 
            // laplacian4ToolStripMenuItem
            // 
            this.laplacian4ToolStripMenuItem.Name = "laplacian4ToolStripMenuItem";
            this.laplacian4ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.laplacian4ToolStripMenuItem.Text = "Laplacian 4";
            this.laplacian4ToolStripMenuItem.Click += new System.EventHandler(this.laplacian4ToolStripMenuItem_Click);
            // 
            // laplacian8ToolStripMenuItem
            // 
            this.laplacian8ToolStripMenuItem.Name = "laplacian8ToolStripMenuItem";
            this.laplacian8ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.laplacian8ToolStripMenuItem.Text = "Laplacian 8";
            this.laplacian8ToolStripMenuItem.Click += new System.EventHandler(this.laplacian8ToolStripMenuItem_Click);
            // 
            // sobelXToolStripMenuItem
            // 
            this.sobelXToolStripMenuItem.Name = "sobelXToolStripMenuItem";
            this.sobelXToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.sobelXToolStripMenuItem.Text = "Sobel X";
            this.sobelXToolStripMenuItem.Click += new System.EventHandler(this.sobelXToolStripMenuItem_Click);
            // 
            // sobelYToolStripMenuItem
            // 
            this.sobelYToolStripMenuItem.Name = "sobelYToolStripMenuItem";
            this.sobelYToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.sobelYToolStripMenuItem.Text = "Sobel Y";
            this.sobelYToolStripMenuItem.Click += new System.EventHandler(this.sobelYToolStripMenuItem_Click);
            // 
            // frequencyDomainFiltersToolStripMenuItem
            // 
            this.frequencyDomainFiltersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fFTToolStripMenuItem,
            this.inverseFFTToolStripMenuItem,
            this.highPassFilterToolStripMenuItem,
            this.lowPassFilterToolStripMenuItem,
            this.bandPassFilterToolStripMenuItem,
            this.notchFilterToolStripMenuItem,
            this.butterworthHighPassToolStripMenuItem,
            this.butterworthLowPassToolStripMenuItem,
            this.butterworthHighPass4ToolStripMenuItem,
            this.butterworthLowPass4ToolStripMenuItem});
            this.frequencyDomainFiltersToolStripMenuItem.Name = "frequencyDomainFiltersToolStripMenuItem";
            this.frequencyDomainFiltersToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.frequencyDomainFiltersToolStripMenuItem.Text = "Frequency Domain Filters";
            this.frequencyDomainFiltersToolStripMenuItem.Click += new System.EventHandler(this.frequencyDomainFiltersToolStripMenuItem_Click);
            // 
            // fFTToolStripMenuItem
            // 
            this.fFTToolStripMenuItem.Name = "fFTToolStripMenuItem";
            this.fFTToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.fFTToolStripMenuItem.Text = "FFT";
            this.fFTToolStripMenuItem.Click += new System.EventHandler(this.fFTToolStripMenuItem_Click);
            // 
            // inverseFFTToolStripMenuItem
            // 
            this.inverseFFTToolStripMenuItem.Name = "inverseFFTToolStripMenuItem";
            this.inverseFFTToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.inverseFFTToolStripMenuItem.Text = "Inverse FFT";
            this.inverseFFTToolStripMenuItem.Click += new System.EventHandler(this.inverseFFTToolStripMenuItem_Click);
            // 
            // highPassFilterToolStripMenuItem
            // 
            this.highPassFilterToolStripMenuItem.Name = "highPassFilterToolStripMenuItem";
            this.highPassFilterToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.highPassFilterToolStripMenuItem.Text = "High Pass Filter";
            this.highPassFilterToolStripMenuItem.Click += new System.EventHandler(this.highPassFilterToolStripMenuItem_Click);
            // 
            // lowPassFilterToolStripMenuItem
            // 
            this.lowPassFilterToolStripMenuItem.Name = "lowPassFilterToolStripMenuItem";
            this.lowPassFilterToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.lowPassFilterToolStripMenuItem.Text = "Low Pass Filter";
            this.lowPassFilterToolStripMenuItem.Click += new System.EventHandler(this.lowPassFilterToolStripMenuItem_Click);
            // 
            // bandPassFilterToolStripMenuItem
            // 
            this.bandPassFilterToolStripMenuItem.Name = "bandPassFilterToolStripMenuItem";
            this.bandPassFilterToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.bandPassFilterToolStripMenuItem.Text = "Band Pass Filter";
            this.bandPassFilterToolStripMenuItem.Click += new System.EventHandler(this.bandPassFilterToolStripMenuItem_Click);
            // 
            // notchFilterToolStripMenuItem
            // 
            this.notchFilterToolStripMenuItem.Name = "notchFilterToolStripMenuItem";
            this.notchFilterToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.notchFilterToolStripMenuItem.Text = "Notch Filter";
            this.notchFilterToolStripMenuItem.Click += new System.EventHandler(this.notchFilterToolStripMenuItem_Click);
            // 
            // butterworthHighPassToolStripMenuItem
            // 
            this.butterworthHighPassToolStripMenuItem.Name = "butterworthHighPassToolStripMenuItem";
            this.butterworthHighPassToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.butterworthHighPassToolStripMenuItem.Text = "Butterworth High Pass";
            this.butterworthHighPassToolStripMenuItem.Click += new System.EventHandler(this.butterworthHighPassToolStripMenuItem_Click);
            // 
            // butterworthLowPassToolStripMenuItem
            // 
            this.butterworthLowPassToolStripMenuItem.Name = "butterworthLowPassToolStripMenuItem";
            this.butterworthLowPassToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.butterworthLowPassToolStripMenuItem.Text = "Butterworth Low Pass";
            this.butterworthLowPassToolStripMenuItem.Click += new System.EventHandler(this.butterworthLowPassToolStripMenuItem_Click);
            // 
            // statisticalFiltersToolStripMenuItem
            // 
            this.statisticalFiltersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medianToolStripMenuItem,
            this.minToolStripMenuItem,
            this.maxToolStripMenuItem,
            this.midpointToolStripMenuItem,
            this.alphaTrim2ToolStripMenuItem});
            this.statisticalFiltersToolStripMenuItem.Name = "statisticalFiltersToolStripMenuItem";
            this.statisticalFiltersToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.statisticalFiltersToolStripMenuItem.Text = "Statistical Filters";
            // 
            // medianToolStripMenuItem
            // 
            this.medianToolStripMenuItem.Name = "medianToolStripMenuItem";
            this.medianToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.medianToolStripMenuItem.Text = "Median";
            this.medianToolStripMenuItem.Click += new System.EventHandler(this.medianToolStripMenuItem_Click);
            // 
            // minToolStripMenuItem
            // 
            this.minToolStripMenuItem.Name = "minToolStripMenuItem";
            this.minToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.minToolStripMenuItem.Text = "Min";
            this.minToolStripMenuItem.Click += new System.EventHandler(this.minToolStripMenuItem_Click);
            // 
            // maxToolStripMenuItem
            // 
            this.maxToolStripMenuItem.Name = "maxToolStripMenuItem";
            this.maxToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.maxToolStripMenuItem.Text = "Max";
            this.maxToolStripMenuItem.Click += new System.EventHandler(this.maxToolStripMenuItem_Click);
            // 
            // midpointToolStripMenuItem
            // 
            this.midpointToolStripMenuItem.Name = "midpointToolStripMenuItem";
            this.midpointToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.midpointToolStripMenuItem.Text = "Midpoint";
            this.midpointToolStripMenuItem.Click += new System.EventHandler(this.midpointToolStripMenuItem_Click);
            // 
            // alphaTrim2ToolStripMenuItem
            // 
            this.alphaTrim2ToolStripMenuItem.Name = "alphaTrim2ToolStripMenuItem";
            this.alphaTrim2ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.alphaTrim2ToolStripMenuItem.Text = "Alpha Trim (2)";
            this.alphaTrim2ToolStripMenuItem.Click += new System.EventHandler(this.alphaTrim2ToolStripMenuItem_Click);
            // 
            // hSIRoutinesToolStripMenuItem
            // 
            this.hSIRoutinesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enhanceToolStripMenuItem});
            this.hSIRoutinesToolStripMenuItem.Name = "hSIRoutinesToolStripMenuItem";
            this.hSIRoutinesToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.hSIRoutinesToolStripMenuItem.Text = "HSI Routines";
            // 
            // enhanceToolStripMenuItem
            // 
            this.enhanceToolStripMenuItem.Name = "enhanceToolStripMenuItem";
            this.enhanceToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.enhanceToolStripMenuItem.Text = "Enhance Color";
            this.enhanceToolStripMenuItem.Click += new System.EventHandler(this.enhanceToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWinToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // newWinToolStripMenuItem
            // 
            this.newWinToolStripMenuItem.Checked = true;
            this.newWinToolStripMenuItem.CheckOnClick = true;
            this.newWinToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.newWinToolStripMenuItem.Name = "newWinToolStripMenuItem";
            this.newWinToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.newWinToolStripMenuItem.Text = "Operation New Window";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histogramToolToolStripMenuItem,
            this.hSIViewerToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // histogramToolToolStripMenuItem
            // 
            this.histogramToolToolStripMenuItem.Name = "histogramToolToolStripMenuItem";
            this.histogramToolToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.histogramToolToolStripMenuItem.Text = "Histogram Tool";
            this.histogramToolToolStripMenuItem.Click += new System.EventHandler(this.histogramToolToolStripMenuItem_Click);
            // 
            // hSIViewerToolStripMenuItem
            // 
            this.hSIViewerToolStripMenuItem.Name = "hSIViewerToolStripMenuItem";
            this.hSIViewerToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.hSIViewerToolStripMenuItem.Text = "HSI Viewer";
            this.hSIViewerToolStripMenuItem.Click += new System.EventHandler(this.hSIViewerToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Width:";
            // 
            // imgLabel
            // 
            this.imgLabel.BackColor = System.Drawing.Color.White;
            this.imgLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgLabel.Location = new System.Drawing.Point(15, 28);
            this.imgLabel.Name = "imgLabel";
            this.imgLabel.Size = new System.Drawing.Size(880, 23);
            this.imgLabel.TabIndex = 2;
            this.imgLabel.Text = "New Image";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(62, 56);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(45, 13);
            this.lblWidth.TabIndex = 3;
            this.lblWidth.Text = "lblWidth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Height:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(169, 56);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(48, 13);
            this.lblHeight.TabIndex = 5;
            this.lblHeight.Text = "lblHeight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(225, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pixels:";
            // 
            // lblPixels
            // 
            this.lblPixels.AutoSize = true;
            this.lblPixels.Location = new System.Drawing.Point(275, 56);
            this.lblPixels.Name = "lblPixels";
            this.lblPixels.Size = new System.Drawing.Size(44, 13);
            this.lblPixels.TabIndex = 7;
            this.lblPixels.Text = "lblPixels";
            // 
            // pnlImage
            // 
            this.pnlImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlImage.AutoScroll = true;
            this.pnlImage.Controls.Add(this.picImage);
            this.pnlImage.Location = new System.Drawing.Point(15, 88);
            this.pnlImage.Name = "pnlImage";
            this.pnlImage.Size = new System.Drawing.Size(880, 330);
            this.pnlImage.TabIndex = 8;
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(0, 0);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(100, 50);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            // 
            // zoomBar
            // 
            this.zoomBar.LargeChange = 10;
            this.zoomBar.Location = new System.Drawing.Point(371, 54);
            this.zoomBar.Maximum = 200;
            this.zoomBar.Minimum = 30;
            this.zoomBar.Name = "zoomBar";
            this.zoomBar.Size = new System.Drawing.Size(521, 45);
            this.zoomBar.TabIndex = 9;
            this.zoomBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.zoomBar.Value = 100;
            this.zoomBar.ValueChanged += new System.EventHandler(this.zoomPic);
            // 
            // lblZoom
            // 
            this.lblZoom.AutoSize = true;
            this.lblZoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZoom.Location = new System.Drawing.Point(327, 56);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(38, 13);
            this.lblZoom.TabIndex = 10;
            this.lblZoom.Text = "Zoom";
            // 
            // butterworthHighPass4ToolStripMenuItem
            // 
            this.butterworthHighPass4ToolStripMenuItem.Name = "butterworthHighPass4ToolStripMenuItem";
            this.butterworthHighPass4ToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.butterworthHighPass4ToolStripMenuItem.Text = "Butterworth High Pass (4)";
            this.butterworthHighPass4ToolStripMenuItem.Click += new System.EventHandler(this.butterworthHighPass4ToolStripMenuItem_Click);
            // 
            // butterworthLowPass4ToolStripMenuItem
            // 
            this.butterworthLowPass4ToolStripMenuItem.Name = "butterworthLowPass4ToolStripMenuItem";
            this.butterworthLowPass4ToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.butterworthLowPass4ToolStripMenuItem.Text = "Butterworth Low Pass(4)";
            this.butterworthLowPass4ToolStripMenuItem.Click += new System.EventHandler(this.butterworthLowPass4ToolStripMenuItem_Click);
            // 
            // frmStandard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 430);
            this.Controls.Add(this.lblZoom);
            this.Controls.Add(this.pnlImage);
            this.Controls.Add(this.lblPixels);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.imgLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.zoomBar);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmStandard";
            this.Text = "Standard Image Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formStandard_FormClosing);
            this.Resize += new System.EventHandler(this.hideifMinimized);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlImage.ResumeLayout(false);
            this.pnlImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoomBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label imgLabel;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPixels;
        private System.Windows.Forms.Panel pnlImage;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TrackBar zoomBar;
        private System.Windows.Forms.Label lblZoom;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpleOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toGrayscaleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem invertToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem changeIntensityToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem transformationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cropToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem spaceDomainFiltersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laplacian4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laplacian8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frequencyDomainFiltersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fFTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inverseFFTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highPassFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowPassFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bandPassFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notchFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem butterworthHighPassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem butterworthLowPassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticalFiltersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem midpointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alphaTrim2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hSIViewerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hSIRoutinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enhanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem butterworthHighPass4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem butterworthLowPass4ToolStripMenuItem;
    }
}