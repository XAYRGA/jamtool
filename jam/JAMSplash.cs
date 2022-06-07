using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jam
{
    public partial class JAMSplash : Form
    {
        public JAMSplash()
        {
            InitializeComponent();
        }

        private void JAMSplash_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var b = new JamMain();
           
            timer1.Enabled = false;
            this.Hide();
            b.ShowDialog();
            Application.Exit();

            //Application.Run(new Form1());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
