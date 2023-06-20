﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Modul_3_PVE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operator Filter = new Operator();
            Filter.TopLeft = Convert.ToInt16(textBoxK11.Text);
            Filter.TopMid = Convert.ToInt16(textBoxK12.Text);
            Filter.TopRight = Convert.ToInt16(textBoxK13.Text);
            Filter.MidLeft = Convert.ToInt16(textBoxK21.Text);
            Filter.Pixel = Convert.ToInt16(textBoxK22.Text);
            Filter.MidRight = Convert.ToInt16(textBoxK23.Text);
            Filter.BottomLeft = Convert.ToInt16(textBoxK31.Text);
            Filter.BottomMid = Convert.ToInt16(textBoxK32.Text);
            Filter.BottomRight = Convert.ToInt16(textBoxK33.Text);
            Filter.Factor = Convert.ToInt16(textBoxFaktor.Text);
            Filter.Offset = Convert.ToInt16(textBoxOffset.Text);
            pictureBoxHasil.Image = (Bitmap)Konvolusi((Bitmap)pictureBoxAsli.Image, Filter);
        }
    }

    public class Operator
    {
    public int TopLeft = 0 , TopMid = 0 , TopRight = 0 ;
    public int MidLeft = 0 , Pixel = 1 , MidRight = 0 ;
    public int BottomLeft = 0 , BottomMid = 0 , BottomRight = 0 ;
    public int Factor = 1;
    public int Offset = 0 ;
    public void SetAll(int nVal)
        {
        TopLeft = TopMid = TopRight = MidLeft = Pixel = MidRight = BottomLeft = BottomMid = BottomRight = nVal;
        }
    }

    
    public static Bitmap Konvolusi ( Bitmap b , Operator m)
    {
        Bitmap bSrc = (Bitmap)b.Clone();
        if(m.Factor == 0 ) return b;
        BitmapData bmData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
        BitmapData bmSrc = bSrc.LockBits(new Rectangle(0, 0, bSrc.Width, bSrc.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
        int stride = bmData.Stride;
    int stride2 = stride*2;
    System.IntPtr Scan0 = bmData.Scan0;
    System.IntPtr SrcScan0 = bmSrc.Scan0;
    unsafe
        {
        byte * p = (byte *) (void*) Scan0;
        byte * pSrc = (byte *)(void*) SrcScan0;
        int nOffset = stride + 6 - b.Width * 3;
        int nWidth = b.Width - 2;
        int nHeight = b.Height - 2;
        int nPixel;
            for (int y = 0; y < nHeight; ++y)
            {
            for (int x = 0; x < nWidth; ++x)
                {
                nPixel = ((((pSrc[2] * m.TopLeft ) +(pSrc[5] * m.TopMid ) +(pSrc[8] * m.TopRight ) +(pSrc[2 + stride] * m.MidLeft) + (pSrc[5+stride] * m.Pixel) +(pSrc[8 +stride] * m.MidRight ) +(pSrc[2 + stride2] * m.BottomLeft) + (pSrc[5 + stride2] * m.BottomMid) +(pSrc[8 + stride2] * m.BottomRight ) ) /m.Factor) +m.Offset);
                if(nPixel< 0 ) nPixel = 0;
                if(nPixel > 255) nPixel = 255;
                p[5 + stride] = (byte)nPixel;
                nPixel = ((((pSrc[1] * m.TopLeft ) +(pSrc[4] * m.TopMid ) +(pSrc[7] * m.TopRight ) +(pSrc[1 + stride] * m.MidLeft) + (pSrc[4+ stride] * m.Pixel ) +(pSrc[7 +stride] * m.MidRight) +(pSrc[1 + stride2] * m.BottomLeft) + (pSrc[4 + stride2] * m.BottomMid ) +(pSrc[7 + stride2] * m.BottomRight ) ) /m.Factor) +m.Offset);
                if(nPixel< 0 ) nPixel = 0;
                if(nPixel > 255 ) nPixel = 255;
                p[4 + stride] = (byte)nPixel;
                nPixel =((((pSrc[0] * m.TopLeft ) +(pSrc[3] * m.TopMid ) +(pSrc[6] * m.TopRight ) +(pSrc[0 + stride] * m.MidLeft) + (pSrc[3+ stride] * m.Pixel) +(pSrc[6 +stride] * m.MidRight ) +(pSrc[0 + stride2] * m.BottomLeft) + (pSrc[3 + stride2] * m.BottomMid ) +(pSrc[6 + stride2] * m.BottomRight ) ) /m.Factor) +m.Offset) ;
                if(nPixel < 0 ) nPixel = 0;
                if(nPixel > 255) nPixel =255;
                p[3 + stride] = (byte)nPixel;
                p += 3;
                pSrc += 3;
                }
            p += nOffset;
            pSrc += nOffset;
             }
        }
        b.UnlockBits(bmData);
        bSrc.UnlockBits(bmSrc);
        return b;

        }        
      
        
    
}
