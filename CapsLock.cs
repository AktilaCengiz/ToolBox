using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolBox_Widget
{
    public partial class CapsLock : Form
    {
        public CapsLock()
        {
            InitializeComponent();
        }
        public void ChangeText(string text)
        {
            this.label1.Text = text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
