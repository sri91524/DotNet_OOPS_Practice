using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dellcomputers dell = new Dellcomputers();
            dell.GetDesktops();
            dell.GetMark();

            string allValues = "";
            allValues = dell.Name + Environment.NewLine;
            allValues += dell.Price + Environment.NewLine;
            allValues += dell.Mark + Environment.NewLine;

            textBox1.Text = allValues;
        }
    }
}
