using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul_4_PVE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float Sudut = (float)Convert.ToSingle(textBoxAngle.Text );
            PointF PusatRotasi = new PointF((float)Convert.ToSingle(
            textBoxPusatX.Text), (float)Convert.ToSingle(textBoxPusatY.
            Text));
            pictureBoxHasil.Image = (Bitmap)RotateImage((Bitmap)
            pictureBoxAsli.Image, PusatRotasi, Sudut);

        }

        private static Bitmap RotateImage(Image image, PointF offset , float angle )
        {
        var rotatedBmp = new Bitmap(image.Width, image.Height);
        rotatedBmp.SetResolution(image.HorizontalResolution , image.VerticalResolution);
        var g = Graphics.FromImage(rotatedBmp );
        g.TranslateTransform(offset.X,offset.Y);
        g.RotateTransform(angle);
        g.TranslateTransform(- offset.X, - offset.Y);
        g.DrawImage(image, new PointF( 0 , 0 ) ) ;
        return rotatedBmp ;
        }
}
}
