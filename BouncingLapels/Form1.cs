using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncingLapels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        labelBouncing[] Bouncer = new labelBouncing[3];

        private void ToggleBouncing(int index, Label labelToBouncing)
        {
            if(Bouncer[index] == null)
            {
                Bouncer[index] = new labelBouncing();
                Bouncer[index].MyLabel = labelToBouncing;
            }
            else
            {
                Bouncer[index] = null;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToggleBouncing(0, label1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ToggleBouncing(1, label2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ToggleBouncing(2, label3);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < 3; i++)
            {
                if(Bouncer[i] != null)
                {
                    Bouncer[i].Move();
                }
            }
        }
    }
}
