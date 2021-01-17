using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello World");
            int i = 100;
            Action o = delegate ()
            {
                MessageBox.Show(i.ToString());
            };
            o();
        }

        //void dosomething()
        //{
        //    messagebox.show(i.tostring());
        //}
    }
}
