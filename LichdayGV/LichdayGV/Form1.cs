using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LichdayGV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void phânCôngLịchDạyGiảngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ldgv = new FormLDGV();
            ldgv.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("F:/C#/LichdayGV/LichdayGV/Resources/hou.jpg");
            
          
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private bool closeForm = true;

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeForm = false;
            this.Close();
            Login sh = new Login();
            sh.Show();
        }

        private void quảnLýLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var lop = new FormLop();
            lop.Show();
            this.Hide();
        }

        private void quảnLýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mon = new FormMon();
            mon.Show();
            this.Hide();
        }

        private void quảnLýGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gv = new FormGiangvien();
            gv.Show();
            this.Hide();

        }
    }
}
