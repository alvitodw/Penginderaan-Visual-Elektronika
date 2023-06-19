using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul_1_PVE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                dataGridView1.Rows.Add("width", $"{pictureBox1.Width}");
                dataGridView1.Rows.Add("image", $"{pictureBox1.Image}");
                dataGridView1.Rows.Add("location", $"{pictureBox1.Location}");
                dataGridView1.Rows.Add("name", $"{pictureBox1.Name}");
                dataGridView1.Rows.Add("visible", $"{pictureBox1.Visible}");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = " Image Files ( ∗.jpg ; ∗ .bmp) | ∗ .jpg ; ∗ .bmp";
            if (open.ShowDialog() == DialogResult.OK) ;
            {
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
