using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace student_analysis
{
    public partial class aboutForm : Form
    {
        public aboutForm()
        {
            InitializeComponent();
            Text = info.progname + " - про програму";
            Size = new Size(512, 256);
            okBtn.Location = new Point(384 - okBtn.Width / 2, ClientSize.Height - okBtn.Height - 13);
            pictureBox1.BackgroundImage = Properties.Resources.student;
            label1.MaximumSize = new Size(256, ClientSize.Height - 13);
            label1.Width = label1.MaximumSize.Width;
            label1.Text = info.progname + ". Версія 1.0\n\nЦей програмний продукт є дипломним проектом Олексія Беньковського,\nстудента IV курсу групи РПЗ-13к.";
        }

        private void aboutForm_Load(object sender, EventArgs e)
        {

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
