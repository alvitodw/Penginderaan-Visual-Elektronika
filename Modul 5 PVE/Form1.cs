using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Modul_5_PVE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bmp1 = (Bitmap)pictureBoxImg1.Image;
            Bitmap bmp2 = (Bitmap)pictureBoxImg2.Image;
            pictureBoxImgResult.Image = Subtraction(bmp2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bmp1 = (Bitmap)pictureBoxImg1.Image;
            Bitmap bmp2 = (Bitmap)pictureBoxImg2.Image;
            pictureBoxImgResult.Image = SubtractionGDI(bmp2);
        }

        Bitmap bmp1;
        public Bitmap Subtraction(Bitmap bmp2)
        {
         BitmapData bmpData1 = bmp1.LockBits(new Rectangle( 0 , 0 , bmp1.Width , bmp1.Height) , ImageLockMode.ReadWrite , PixelFormat.Format24bppRgb ) ;
         BitmapData bmpData2 = bmp2.LockBits(new Rectangle( 0 , 0 , bmp2.Width , bmp2.Height) , ImageLockMode.ReadWrite , PixelFormat.Format24bppRgb ) ;
        int width = bmpData1.Width;
        int height = bmpData1.Height ;
            Bitmap bmpresult = new Bitmap(width , height);
        BitmapData bmpData3 = bmpresult.LockBits(new Rectangle( 0 , 0 ,bmpresult.Width , bmpresult.Height) , ImageLockMode.ReadWrite ,PixelFormat.Format24bppRgb ) ;
         unsafe
            {
             int remain1 = bmpData1.Stride - bmpData1.Width * 3 ;
             int remain2 = bmpData2.Stride - bmpData2.Width * 3 ;
             int remain3 = bmpData3.Stride - bmpData3.Width * 3 ;
             byte * ptr1 = (byte *) bmpData1.Scan0 ;
             byte * ptr2 = (byte *) bmpData2.Scan0 ;
            byte * ptr3 = (byte *) bmpData3.Scan0 ;
                for (int i = 0 ; i<height; i++)
                  {
                    for (int j = 0 ; j<width *3 ; j++)
                  {
                    ptr3 [ 0 ] = (byte ) Math.Max((ptr1 [ 0 ] - ptr2 [ 0 ] ) , 0 ) ;
                    ++ptr1 ;
                    ++ptr2 ;
                    ++ptr3 ;
                    }
                    ptr1 += remain1 ;
                    ptr2 += remain2 ;
                    ptr3 += remain3 ;
                   }
                }
            bmp1.UnlockBits ( bmpData1 ) ;
            bmp2.UnlockBits ( bmpData2 ) ;
            bmpresult.UnlockBits( bmpData3 ) ;
            return bmpresult ;
    }
          public Bitmap SubtractionGDI(Bitmap bmp2)
          {
            int width = bmp1.Width;
            int height = bmp1.Height ;
            int r, g, b;
            Bitmap bmpresult = new Bitmap(width , height );
            for (int i = 0 ; i<height ; i++)
                {
                for (int j = 0 ; j<width ; j++)
            {
                r=Math.Max(bmp1.GetPixel(i , j ).R-bmp2.GetPixel(i , j ).R, 0 ) ;
                g=Math.Max(bmp1.GetPixel(i , j ).G-bmp2.GetPixel(i , j ).G, 0 ) ;
                b=Math.Max(bmp1.GetPixel(i , j ).B-bmp2.GetPixel(i , j ).B, 0 ) ;
                bmpresult.SetPixel(i, j, Color.FromArgb (r, g, b) );
            }
            }
            return bmpresult ;
            }

    }
}
