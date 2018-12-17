using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw.src.GUI
{
    public partial class InitialForm : Form
    {
        public InitialForm()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void LoadForm()
        {
            MainForm mainForm = new MainForm();
            newBtn.Hide();
            exitBtn.Hide();
            mainForm.MdiParent = this;
            mainForm.Show();
            WindowState = FormWindowState.Maximized;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
