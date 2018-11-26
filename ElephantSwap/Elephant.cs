using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElephantSwap
{
    public class Elephant
    {
        public int EarSize;
        public string Name;

        public void WhoAmI()
        {
            MessageBox.Show("My Ears Are " + EarSize + " Inches Tall", Name + " says...");
        }

        public void tellMe(string message, Elephant whoSaidThIt)
        {
            MessageBox.Show(whoSaidThIt.Name + " Says: " + message);
        }

        public void speakTo(Elephant WhoToTalkTO, string message)
        {
            WhoToTalkTO.tellMe(message, this);
        }
    }
}
