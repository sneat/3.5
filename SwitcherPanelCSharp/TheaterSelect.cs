using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SwitcherPanelCSharp
{
    public partial class TheaterSelect : Form
    {
        public TheaterSelect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Theater8 t8 = new Theater8();
            t8.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Theater9 t8 = new Theater9();
            t8.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Theater10 t8 = new Theater10();
            t8.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VideoTalk t8 = new VideoTalk();
            t8.Show();
            this.Hide();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            SwitcherPanel ps = new SwitcherPanel();
            ps.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
