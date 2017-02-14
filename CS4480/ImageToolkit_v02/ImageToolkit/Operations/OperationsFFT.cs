using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using AForge.Math;
using AForge.Imaging;

namespace ImageToolkit.Operations
{

    public static class OperationsFFT
    {
        public static void RegisterOperations()
        {
            //OperationRegistry.RegisterOperation(new Operation("Frequency Domain Filters", "DFT (SLOW!)", "DFT(X)", DFT, true));
            OperationRegistry.RegisterOperation(new Operation("Frequency Domain Filters", "FFT", "FFT(X)", FFT, true));
            OperationRegistry.RegisterOperation(new Operation("Frequency Domain Filters", "Inverse FFT", "IFFT(X)", IFFT, true));

            //OperationRegistry.RegisterOperation(new Operation("Frequency Domain Filters", "Inverse DFT (SLOW!)", "IDFT(X)", IDFT, true));
        }

        public static void FFT()
        {
            FFT(null);
        }

         public static void IFFT()
        {
            IFFT(null);
        }

        public static void FFT(IOperand x = null, bool spawn = true)
        {
            if (x == null) x = ExecutionStack.X;
            if (x == null) return;
            Bitmap bmp = x.GetBitmap();
            float[][][] img = Normalize.ToFloat(bmp);

            int H = bmp.Height, W = bmp.Width;

            img = Pad(img,H,W);

            ComplexImage ci = ComplexImage.FromBitmap(ColorToGrayscale(Normalize.FromFloat(img)));
            ci.ForwardFourierTransform();

            

            img = Normalize.ToFloat(ci.ToBitmap());


            if (spawn) ((frmStandard)x).CreateSibling(img, "FFT of " + bmp.ToString(), ci);
            else
            {
                ((frmStandard)x).Image = Normalize.FromFloat(img);
                ((frmStandard)x).cData = ci;
            }
        }

 
        public static void IFFT(IOperand x = null, bool spawn = true)
        {
            if (x == null) x = ExecutionStack.X;
            if (x == null) return;
            Bitmap bmp = x.GetBitmap();
            float[][][] img = Normalize.ToFloat(bmp);
            ComplexImage ci = ((frmStandard)x).cData;

            int H = bmp.Height, W = bmp.Width;

            img = Pad(img, H, W);
            if (ci == null) ci = ComplexImage.FromBitmap(ColorToGrayscale(Normalize.FromFloat(img)));
            ci.BackwardFourierTransform();
            
            img = Normalize.ToFloat(ci.ToBitmap());

            if (spawn) x.CreateSibling(img, "Inverse FFT of " + bmp.ToString());
            else ((frmStandard)x).Image = Normalize.FromFloat(img);
        }

        public static Bitmap ColorToGrayscale(Bitmap bmp)
        {
            int w = bmp.Width,
                h = bmp.Height,
                r, ic, oc, bmpStride, outputStride, bytesPerPixel;
            PixelFormat pfIn = bmp.PixelFormat;
            ColorPalette palette;
            Bitmap output;
            BitmapData bmpData, outputData;

            //Create the new bitmap
            output = new Bitmap(w, h, PixelFormat.Format8bppIndexed);

            //Build a grayscale color Palette
            palette = output.Palette;
            for (int i = 0; i < 256; i++)
            {
                Color tmp = Color.FromArgb(255, i, i, i);
                palette.Entries[i] = Color.FromArgb(255, i, i, i);
            }
            output.Palette = palette;

            //No need to convert formats if already in 8 bit
            if (pfIn == PixelFormat.Format8bppIndexed)
            {
                output = (Bitmap)bmp.Clone();

                //Make sure the palette is a grayscale palette and not some other
                //8-bit indexed palette
                output.Palette = palette;

                return output;
            }

            //Get the number of bytes per pixel
            switch (pfIn)
            {
                case PixelFormat.Format24bppRgb: bytesPerPixel = 3; break;
                case PixelFormat.Format32bppArgb: bytesPerPixel = 4; break;
                case PixelFormat.Format32bppRgb: bytesPerPixel = 4; break;
                default: throw new InvalidOperationException("Image format not supported");
            }

            //Lock the images
            bmpData = bmp.LockBits(new Rectangle(0, 0, w, h), ImageLockMode.ReadOnly,
                                   pfIn);
            outputData = output.LockBits(new Rectangle(0, 0, w, h), ImageLockMode.WriteOnly,
                                         PixelFormat.Format8bppIndexed);
            bmpStride = bmpData.Stride;
            outputStride = outputData.Stride;

            //Traverse each pixel of the image
            unsafe
            {
                byte* bmpPtr = (byte*)bmpData.Scan0.ToPointer(),
                outputPtr = (byte*)outputData.Scan0.ToPointer();

                if (bytesPerPixel == 3)
                {
                    //Convert the pixel to it's luminance using the formula:
                    // L = .299*R + .587*G + .114*B
                    //Note that ic is the input column and oc is the output column
                    for (r = 0; r < h; r++)
                        for (ic = oc = 0; oc < w; ic += 3, ++oc)
                            outputPtr[r * outputStride + oc] = (byte)(int)
                                (0.299f * bmpPtr[r * bmpStride + ic] +
                                 0.587f * bmpPtr[r * bmpStride + ic + 1] +
                                 0.114f * bmpPtr[r * bmpStride + ic + 2]);
                }
                else //bytesPerPixel == 4
                {
                    //Convert the pixel to it's luminance using the formula:
                    // L = alpha * (.299*R + .587*G + .114*B)
                    //Note that ic is the input column and oc is the output column
                    for (r = 0; r < h; r++)
                        for (ic = oc = 0; oc < w; ic += 4, ++oc)
                            outputPtr[r * outputStride + oc] = (byte)(int)
                                ((bmpPtr[r * bmpStride + ic] / 255.0f) *
                                (0.299f * bmpPtr[r * bmpStride + ic + 1] +
                                 0.587f * bmpPtr[r * bmpStride + ic + 2] +
                                 0.114f * bmpPtr[r * bmpStride + ic + 3]));
                }
            }

            //Unlock the images
            bmp.UnlockBits(bmpData);
            output.UnlockBits(outputData);

            return output;
        }

        public static int PowerOfTwo(int x)
        {
            int n = 0;
            while (Math.Pow(2, n) < x)
            {
                n++;
            }
            return (int)Math.Pow(2, n);
        }

        public static float[][][] Pad(float[][][] f, int H, int W)
        {
            int N = PowerOfTwo(H > W ? H : W);
            float[][][] img = new float[3][][];
            for (int c=0; c<3; c++)
            {
                img[c] = new float[N][];
                for (int h=0; h<N; h++)
                {
                    img[c][h] = new float[N];
                    for (int w=0; w<W; w++)
                    {
                        if (h < H && w < W)
                            img[c][h][w] = f[c][h][w];
                        else
                            img[c][h][w] = 0f;
                    }
                }
            }
            return img;
        }
    
        public static Complex[,] DFT2( Complex[,] data, int H, int W, int direction=1)
        {
            int n = W,  //Rows
                m = H;  //Cols
            float arg, cos, sin;
            Complex[] dst = new Complex[System.Math.Max(H, W)];


            // Go through rows
            for (int i=0; i<n; i++)
            {
                for (int j=0; j<m; j++)
                {
                    dst[j].Im = 0f;
                    dst[j].Re = 0f;
                    arg = -(float)(direction * 2.0 * System.Math.PI * (float)j / (float)m);
                    for (int k=0; k<m; k++)
                    {
                        cos = (float)System.Math.Cos(k * arg);
                        sin = (float)System.Math.Cos(k * arg);
                        dst[j].Re += (data[i, k].Re * cos - data[i, k].Im * sin);
                        dst[j].Im += (data[i, k].Re * sin + data[i, k].Im * cos);
                    }
                }


                for (int j=0; j<m; j++)
                {
                    data[i, j].Re = dst[j].Re / (direction == 1 ? m : 1f);
                    data[i, j].Re = dst[j].Im / (direction == 1 ? m : 1f);
                }

            }

            // Go through cols
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    dst[i].Im = 0f;
                    dst[i].Re = 0f;
                    arg = -(float)(direction * 2.0 * System.Math.PI * (float)i / (float)n);
                    for (int k = 0; k < n; k++)
                    {
                        cos = (float)System.Math.Cos(k * arg);
                        sin = (float)System.Math.Cos(k * arg);
                        dst[i].Re += (data[k, j].Re * cos - data[k, j].Im * sin);
                        dst[i].Im += (data[k, j].Re * sin + data[k, j].Im * cos);
                    }
                }


                for (int i = 0; i < n; i++)
                {
                    data[i, j].Re = dst[i].Re / (direction == 1 ? m : 1f);
                    data[i, j].Re = dst[i].Im / (direction == 1 ? m : 1f);
                }

            }
            return data;
        }

        public static void DFT()
        {
            DFT(null, true, 1);
        }

        public static void IDFT()
        {
            DFT(null, true, -1);  // Doesn't seem to....work...
        }

        public static void DFT(IOperand x = null, bool spawn = true, int direction=1)
        {
            if (x == null) x = ExecutionStack.X;
            if (x == null) return;
            Bitmap bmp = x.GetBitmap();
            float[][][] img = Normalize.ToFloat(bmp);
            float[][][] fftimg = new float[3][][];
            float[][][] fftlog = new float[3][][];
            float[][][] fftphaselog = new float[3][][];
            float[][][] fmagnitude = new float[3][][];
            float[][][] fphase = new float[3][][];
//            float[][][] fnorm = new float[3][][];
//            float[][][] fphasenorm = new float[3][][];

            int W = bmp.Width, H = bmp.Height;
            Complex[,] Fourier = new Complex[H, W];
            Complex[,] Output = new Complex[H, W];


            for (int i = 0; i < W; i++)
                for (int j = 0; j < H; j++)
                {
                    Fourier[j, i].Re = 0f;
                    Fourier[j, i].Im = 0f;
                }

            for (int c = 0; c < 3; c++)
            {
                fftimg[c] = new float[H][];
                fftlog[c] = new float[H][];
                fftphaselog[c] = new float[H][];
                fmagnitude[c] = new float[H][];
                fphase[c] = new float[H][];
//                fnorm[c] = new float[H][];
//                fphasenorm[c] = new float[H][];

                for (int j = 0; j < H; j++)
                {
                    fftimg[c][j] = new float[W];
                    fftlog[c][j] = new float[W];
                    fftphaselog[c][j] = new float[W];
                    fmagnitude[c][j] = new float[W];
                    fphase[c][j] = new float[W];
//                    fnorm[c][j] = new float[W];
//                    fphasenorm[c][j] = new float[W];
                    for (int i = 0; i < W; i++)
                    {
                        Fourier[j, i].Re += img[c][j][i] * (float)Math.Pow(H * W,direction) / 3f;
                    }
                }
            }
            //MessageBox.Show("Starting DFT...");
            Output = DFT2(Fourier, H, W, direction);
            //MessageBox.Show("Finished DFT...");
            float max = 0f;
            for (int c = 0; c < 3; c++)
                for (int j = 0; j < H; j++)
                    for (int i = 0; i < W; i++)
                    {
                        fmagnitude[c][j][i] = (float)Output[j, i].Magnitude;
                        fphase[c][j][i] = (float)Output[j, i].Phase;
                        fftlog[c][j][i] = (float)Math.Log(1 + fmagnitude[c][j][i]);
                        fftphaselog[c][j][i] = (float)Math.Log(1 + Math.Abs(fphase[c][j][i]));
                    }

            max = fftlog[0][1][0];
            for (int i = 0; i < W; i++)
                for (int j = 0; j < H; j++)
                {
                    if (fftlog[0][j][i] > max) max = fftlog[0][j][i];
                }

            for (int c = 0; c < 3; c++)
                for (int j = 0; j < H; j++)
                    for (int i = 0; i < W; i++)
                    {
                        fftimg[c][(j+H/2)%H][(i+W/2)%W] = fftlog[c][j][i] / max;
                    }
            

            if (spawn) x.CreateSibling(fftimg, "DFT of " + bmp.ToString());
            else ((frmStandard)x).Image = Normalize.FromFloat(fftimg);
        }
    }
        /*
        public static float[] cosTable;
        public static float[] sinTable;
        public static int A { get; set; }
                                                                                       
        public static int B { get; set; } 

        public static Complex[,] DFT2( Complex[,] data, int H, int W, int direction=1)
        {
            int n = W,  //Rows
                m = H;  //Cols
            float arg, cos, sin;
            Complex[] dst = new Complex[System.Math.Max(H, W)];


            // Go through rows
            for (int i=0; i<n; i++)
            {
                for (int j=0; j<m; j++)
                {
                    dst[j].imag = 0f;
                    dst[j].real = 0f;
                    arg = -(float)(direction * 2.0 * System.Math.PI * (float)j / (float)m);
                    for (int k=0; k<m; k++)
                    {
                        cos = (float)System.Math.Cos(k * arg);
                        sin = (float)System.Math.Cos(k * arg);
                        dst[j].real += (data[i, k].real * cos - data[i, k].imag * sin);
                        dst[j].imag += (data[i, k].real * sin + data[i, k].imag * cos);
                    }
                }


                for (int j=0; j<m; j++)
                {
                    data[i, j].real = dst[j].real / (direction == 1 ? m : 1f);
                    data[i, j].real = dst[j].imag / (direction == 1 ? m : 1f);
                }

            }

            // Go through cols
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    dst[i].imag = 0f;
                    dst[i].real = 0f;
                    arg = -(float)(direction * 2.0 * System.Math.PI * (float)i / (float)n);
                    for (int k = 0; k < n; k++)
                    {
                        cos = (float)System.Math.Cos(k * arg);
                        sin = (float)System.Math.Cos(k * arg);
                        dst[i].real += (data[k, j].real * cos - data[k, j].imag * sin);
                        dst[i].imag += (data[k, j].real * sin + data[k, j].imag * cos);
                    }
                }


                for (int i = 0; i < n; i++)
                {
                    data[i, j].real = dst[i].real / (direction == 1 ? m : 1f);
                    data[i, j].real = dst[i].imag / (direction == 1 ? m : 1f);
                }

            }
            return data;
        }

        public static void DFT()
        {
            DFT(null, true, 1);
        }

        public static void IDFT()
        {
            DFT(null, true, -1);  // Doesn't seem to....work...
        }

        public static void DFT(IOperand x = null, bool spawn = true, int direction=1)
        {
            if (x == null) x = ExecutionStack.X;
            if (x == null) return;
            Bitmap bmp = x.GetBitmap();
            float[][][] img = Normalize.ToFloat(bmp);
            float[][][] fftimg = new float[3][][];
            float[][][] fftlog = new float[3][][];
            float[][][] fftphaselog = new float[3][][];
            float[][][] fmagnitude = new float[3][][];
            float[][][] fphase = new float[3][][];
//            float[][][] fnorm = new float[3][][];
//            float[][][] fphasenorm = new float[3][][];

            int W = bmp.Width, H = bmp.Height;
            Complex[,] Fourier = new Complex[H, W];
            Complex[,] Output = new Complex[H, W];


            for (int i = 0; i < W; i++)
                for (int j = 0; j < H; j++)
                {
                    Fourier[j, i].real = 0f;
                    Fourier[j, i].imag = 0f;
                }

            for (int c = 0; c < 3; c++)
            {
                fftimg[c] = new float[H][];
                fftlog[c] = new float[H][];
                fftphaselog[c] = new float[H][];
                fmagnitude[c] = new float[H][];
                fphase[c] = new float[H][];
//                fnorm[c] = new float[H][];
//                fphasenorm[c] = new float[H][];

                for (int j = 0; j < H; j++)
                {
                    fftimg[c][j] = new float[W];
                    fftlog[c][j] = new float[W];
                    fftphaselog[c][j] = new float[W];
                    fmagnitude[c][j] = new float[W];
                    fphase[c][j] = new float[W];
//                    fnorm[c][j] = new float[W];
//                    fphasenorm[c][j] = new float[W];
                    for (int i = 0; i < W; i++)
                    {
                        Fourier[j, i].real += img[c][j][i] * (float)Math.Pow(H * W,direction) / 3f;
                    }
                }
            }
            //MessageBox.Show("Starting DFT...");
            Output = DFT2(Fourier, H, W, direction);
            //MessageBox.Show("Finished DFT...");
            float max = 0f;
            for (int c = 0; c < 3; c++)
                for (int j = 0; j < H; j++)
                    for (int i = 0; i < W; i++)
                    {
                        fmagnitude[c][j][i] = Output[j, i].Magnitude();
                        fphase[c][j][i] = Output[j, i].Phase();
                        fftlog[c][j][i] = (float)Math.Log(1 + fmagnitude[c][j][i]);
                        fftphaselog[c][j][i] = (float)Math.Log(1 + Math.Abs(fphase[c][j][i]));
                    }

            max = fftlog[0][1][0];
            for (int i = 0; i < W; i++)
                for (int j = 0; j < H; j++)
                {
                    if (fftlog[0][j][i] > max) max = fftlog[0][j][i];
                }

            for (int c = 0; c < 3; c++)
                for (int j = 0; j < H; j++)
                    for (int i = 0; i < W; i++)
                    {
                        fftimg[c][(j+H/2)%H][(i+W/2)%W] = fftlog[c][j][i] / max;
                    }
            

            if (spawn) x.CreateSibling(fftimg, "DFT of " + bmp.ToString());
            else ((frmStandard)x).Image = Normalize.FromFloat(fftimg);
        }

        public static void FFT()
        {
            FFT(null, true, 1);
        }

        public static void FFT(IOperand x = null, bool spawn = true, int direction = 1)
        {
            if (x == null) x = ExecutionStack.X;
            if (x == null) return;
            Bitmap bmp = x.GetBitmap();
            float[][][] img = Normalize.ToFloat(bmp);
            float[][][] fftimg = new float[3][][];

            int H = bmp.Height, W = bmp.Width;
            
 
            for (int c = 0; c < 3; c++)
            {
                fftimg[c] = new float[H][];

                int N = (H > W) ? H : W;

                Complex[] temp;
                Complex[,] cimg = new Complex[N, N];

               
                for (int h = 0; h < H; h++)
                {
                    temp = ToComplex(img[c][h],W);

                    temp = FFT1D(temp, N);
                    for (int i = 0; i < W; i++) cimg[h, i] = temp[i];
                    //fftimg[c][h] = FromComplex(temp, W);
                }

                //fftimg[c] = Transpose(fftimg[c], H, W);
                cimg = Transpose(cimg, N,N);

                for (int h = 0; h < N; h++)
                {
                    //temp = ToComplex(fftimg[c][h], H);
                    temp = new Complex[N];
                    for (int i = 0; i < N; i++) temp[i] = cimg[h, i];
                    temp = FFT1D(temp, N);
                    fftimg[c][h] = FromComplex(temp, H);
                }

                fftimg[c] = Transpose(fftimg[c], W, H);

            }

            if (spawn) x.CreateSibling(fftimg, "FFT of " + bmp.ToString());
            else ((frmStandard)x).Image = Normalize.FromFloat(fftimg);
        }



        public static Complex[] FFT1D(Complex[] c, int N, int direction=1)
        {
            int N2 = PowerOfTwo(N);
            Complex[] c2 = new Complex[N2];
            int size = c.GetLength(0);
            //if ((N & (N-1)) != 0)  // Is it a power of 2?
           // {

                for (int i = 0; i < N2; i++)
                    if (i < size)
                    {
                        c2[i].real = c[i].real;
                        c2[i].imag = c[i].imag;
                    }
                    else
                    {
                        c2[i].real = 0f;
                        c2[i].imag = 0f;
                    }
                //N = N2;
                //c = c2;
          //  }
          //  else
          //  {
          //      c2 = c;
          //  }
            
            Complex[] X = new Complex[N2];
            Complex[] d, D, e, E;

            if (N2 == 1)
            {
                X[0] = c2[0];
                return X;
            }

            e = new Complex[N / 2];
            d = new Complex[N / 2];

            for (int k = 0; k < N / 2; k++)
            {
                e[k] = c2[2 * k];
                d[k] = c2[2 * k + 1];
            }

            D = FFT1D(d, N/2, direction);
            E = FFT1D(e, N/2, direction);

            for (int k=0; k<N/2; k++)
            {
                float r = 1f;
                float theta = direction * -2f * (float)Math.PI * k / N;
                Complex temp;
                temp.real = r * (float)Math.Cos(theta);
                temp.imag = r * (float)Math.Sin(theta);
                D[k].real *= temp.real;
                D[k].imag *= temp.imag;
            }

            for (int k=0; k < N/2; k++)
            {
                X[k].real = E[k].real + D[k].real;
                X[k].imag = E[k].imag + E[k].imag;
                X[k + N / 2].real = E[k].real - D[k].real;
                X[k + N / 2].imag = E[k].imag - D[k].imag;
            }

            return X;

        }

        public static Complex[,] ToComplex(float[][] img, int H, int W)
        {
            Complex[,] c = new Complex[H,W];
            for (int h = 0; h < H; h++)
                for (int w = 0; w < W; w++)
                {
                    c[h, w].real = img[h][w];
                    c[h, w].imag = 0f;
                }
            return c;
        }

        public static Complex[] ToComplex(float[] img, int W)
        {
            Complex[] c = new Complex[W];
            for (int w=0; w<W; w++)
            {
                c[w].real = img[w];
                c[w].imag = 0f;
            }
            return c;
        }

        public static float[][] FromComplex(Complex[,] c, int H, int W)
        {
            float[][] f = new float[H][];
            for (int h=0; h<H; h++)
            {
                f[h] = new float[W];
                for (int w=0; w<W; w++)
                {
                    f[h][w] = c[h, w].real;
                }
            }
            return f;
        }

        public static float[] FromComplex(Complex[] c, int W)
        {
            float[] f = new float[W];
            for (int w = 0; w < W; w++)
            {
                f[w] = c[w].real;
            }
            return f;
        }

        public static int PowerOfTwo(int x)
        {
            int n = 0;
            while (Math.Pow(2,n) < x)
            {
                n++;
            }
            return (int)Math.Pow(2, n);
        }

        public static float[][] Transpose(float[][] img, int H, int W)
        {
            float[][] newimg = new float[W][];
                for (int w=0; w<W; w++)
                {
                    newimg[w] = new float[H];
                    for (int h = 0; h < H; h++) newimg[w][h] = img[h][w];
                }
            
            return newimg;
        }

        public static Complex[,] Transpose(Complex[,] img, int H, int W)
        {
            Complex[,] newimg = new Complex[H,W];
            
            for (int w = 0; w < W; w++)
                for (int h = 0; h < H; h++) newimg[w,h] = img[h,w];

            
            return newimg;
        }

        public static float[][] Magnitude(Complex[,] img, int W)
        {
            float[][] f = new float[W][];
            for (int i=0; i<W; i++)
            {
                f[i] = new float[W];
                for (int j=0; j<W; j++)
                {
                    f[i][j] = (float)Math.Sqrt(img[i, j].real * img[i, j].real + img[i, j].imag * img[i, j].imag);
                }
            }
            return f;
        }
    }
    /*
    public struct Complex
    {
        public float real, imag;
        public Complex(float x, float y)
        {
            real = x;
            imag = y;
        }

        public float Magnitude()
        {
            return ((float)Math.Sqrt(real * real + imag * imag));
        }

        public float Phase()
        {
            return ((float)Math.Atan(imag / real));
        }
    }*/

}
