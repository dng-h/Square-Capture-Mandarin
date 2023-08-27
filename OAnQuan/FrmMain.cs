using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OAnQuan
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPlay play = new FrmPlay();
            play.ShowDialog();
            this.Close();
        }

        private void btnGuide_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("guideline.txt");
            string guide = sr.ReadToEnd();
            MessageBox.Show(guide, "Hướng dẫn chơi");
        }
    }
}
