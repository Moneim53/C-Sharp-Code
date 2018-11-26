using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flashy_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (Visible)/*The outer loop keeps running as long as the form is visible. As soon as it’s closed, Visible is false, and the while will stop looping*/
            {

                for (int c = 0; c < 254 && Visible; c++) /*We fixed the extra delay by using the && operator to make each of the for loops also check Visible. That way the loop ends as soon as Visible turns false.*/
                {
                    this.BackColor = Color.FromArgb(c, 255 - c, c);
                    Application.DoEvents();     //stop the loop momentraliy
                    System.Threading.Thread.Sleep(9); // slow down the application
                }
                for (int c = 255; c > 0 && Visible; c--) //reverse loop
                {
                    this.BackColor = Color.FromArgb(c, 255 - c, c);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(9);
                }
            }
        }
    }
}
