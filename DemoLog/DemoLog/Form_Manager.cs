using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoLog
{
    public partial class FromManager : Form
    {
        public FromManager()
        {
            InitializeComponent();
        }
     
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FromEmp femp = new FromEmp();
            femp.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormInventory fxd = new FormInventory();
            fxd.Show();
            this.Hide();
        }

        
    }
}
