using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IF_Statements
{
    public partial class frmDemo : Form
    {
        public frmDemo()
        {
            InitializeComponent();
        }

        private void btnChecking_Click(object sender, EventArgs e)
        {
            // Check your Name 
            string name;

            name = txtName.Text;

            // Simple if Statement 

            if(name == "Ali")
            {
                MessageBox.Show("Hello mr." + name);
            }
        }
    }
}
