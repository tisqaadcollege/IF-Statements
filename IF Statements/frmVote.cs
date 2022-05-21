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
    public partial class frmVote : Form
    {
        public frmVote()
        {
            InitializeComponent();
        }

        private void btnVote_Click(object sender, EventArgs e)
        {
            // Check if user can vote 
            int age;

            age = Convert.ToInt32(txtAge.Text);

            if(age >= 15)
            {
                MessageBox.Show("You Can Vote!");
            }
        }
    }
}
