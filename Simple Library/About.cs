using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Library
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Timer timer = new Timer();

        private void About_Load(object sender, EventArgs e)
        {

            Opacity = 0;
            timer.Interval = 50;
            timer.Tick += new EventHandler(fadeIn);
            timer.Start();

        }

        void fadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
                timer.Stop();
            else
                Opacity += 0.05;
        }
    }
}
