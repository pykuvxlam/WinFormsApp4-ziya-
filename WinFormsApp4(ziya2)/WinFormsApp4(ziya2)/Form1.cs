using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace WinFormsApp4__ziya_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss"); 
        }
    }
}
