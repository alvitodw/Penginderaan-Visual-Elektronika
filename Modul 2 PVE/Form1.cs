using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul_2_PVE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap bmp;
        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(textBoxX.Text);
            int y = Convert.ToInt16(textBoxY.Text);
            bmp = (Bitmap)pictureBox1.Image;
            int r = bmp.GetPixel(x , y ).R;
            int g = bmp.GetPixel(x , y ).G;
            int b = bmp.GetPixel(x , y ).B;
            textBoxR.Text=r.ToString();
            textBoxG.Text=g.ToString();
            textBoxB.Text=b.ToString();

        }

        Bitmap bmpAsli, bmpHasil; 
        private void button2_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt16(textBoxBrightness.Text);
            int i, j;
            int nilaiR , nilaiG, nilaiB;
            bmpAsli = (Bitmap)pictureBox1. Image;
            int baris = bmpAsli.Width;
            int kolom = bmpAsli.Height;
            bmpHasil = new Bitmap(baris, kolom);
            Cursor = Cursors.WaitCursor;
            for (i = 0; i < baris; i++) 
            for (j = 0; j < kolom; j++) 
                {
                nilaiR = bmpAsli.GetPixel(i,j).R + k;
                nilaiG = bmpAsli.GetPixel(i,j).G + k;
                nilaiB = bmpAsli.GetPixel(i,j).B + k;
                if(nilaiR > 255 ) nilaiR = 255;
                if(nilaiG > 255 ) nilaiG = 255;
                if(nilaiB > 255 ) nilaiB = 255;
                if(nilaiR < 0 ) nilaiR = 0;
                if(nilaiG < 0 ) nilaiG = 0;
                if(nilaiB < 0 ) nilaiB = 0;
                bmpHasil.SetPixel(i, j, Color.FromArgb(nilaiR,nilaiG,nilaiB));
                 }
            pictureBoxHasil.Image = bmpHasil;
            Cursor = Cursors.Default;
        }
    }
}
