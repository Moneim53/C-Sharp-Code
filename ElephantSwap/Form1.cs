using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElephantSwap
{
    public partial class Form1 : Form
    {
        private Elephant Lloyd;
        private Elephant Lucinda;

        public Form1()
        {
            Lloyd = new Elephant()
            {
                Name = "Lloyd",
                EarSize = 33
            };
            Lucinda = new Elephant() { Name = "Lucinda", EarSize = 40 };
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lloyd.WhoAmI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lucinda.WhoAmI();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elephant Fool;//we don't need to creat a new instance we just want to creat referance to hold the object from grpage collactor after the referance of it move
            Fool = Lloyd;
            Lloyd = Lucinda;
            Lucinda = Fool;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lloyd.tellMe("Hi", Lucinda);
            Lloyd.speakTo(Lucinda, "Hello");
            Lloyd = Lucinda;
            Lloyd.EarSize = 234;
            Lloyd.WhoAmI();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Elephant[] elephants = new Elephant[7];
            elephants[0] = new Elephant() { Name = "Lloyed", EarSize = 40 };
            elephants[1] = new Elephant() { Name = "Lucinda", EarSize = 36 };
            elephants[2] = new Elephant() { Name = "Larry", EarSize = 42 };
            elephants[3] = new Elephant() { Name = "Lucille", EarSize = 32 };
            elephants[4] = new Elephant() { Name = "Lars", EarSize = 44 };
            elephants[5] = new Elephant() { Name = "Linda", EarSize = 37 };
            elephants[6] = new Elephant() { Name = "Humphary", EarSize = 45 };

            Elephant biggestEar = elephants[5];
            for (int i = 0; i < elephants.Length; i++)
            {
                if (elephants[i].EarSize > biggestEar.EarSize)
                {
                    biggestEar = elephants[i];
                }
            }
            MessageBox.Show(biggestEar.EarSize.ToString());

        }
    }
}
