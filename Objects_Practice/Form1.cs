using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPS_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  // This is essential to load the controls
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            Employee employeeDetails = new Employee();
            employeeDetails.EmpName = textBox2.Text;
            employeeDetails.Age = Convert.ToInt32(textBox3.Text);
            employeeDetails.Position = textBox4.Text;

            FrmEmpDetails frm = new FrmEmpDetails();
            frm.label2.Text = employeeDetails.EmpName;
            frm.label3.Text = employeeDetails.Age.ToString();
            frm.label4.Text = employeeDetails.Position;

            frm.ShowDialog();
        }
    }
}
