using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolStrip
{
    public partial class Form1 : Form
    {
        int size = 12;
        public Form1()
        {
            InitializeComponent();
        }

        private void tsTextBox_Click(object sender, EventArgs e)
        {

        }

        private void tsTextBox_TextChanged(object sender, EventArgs e)
        {
            this.label1.Text= tsTextBox.Text;   
        }

        private void tsPlus_Click(object sender, EventArgs e)
        {
            this.label1.Font = new Font("tahoma", size);
            size += 4;
        }

        private void tsMinas_Click(object sender, EventArgs e)
        {
            this.label1.Font = new Font("tahoma", size);
            size -= 4;
        }
    }
}
