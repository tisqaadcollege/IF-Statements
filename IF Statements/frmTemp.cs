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
    public partial class frmTemp : Form
    {
        public frmTemp()
        {
            InitializeComponent();
        }

        private void btnTemp_Click(object sender, EventArgs e)
        {
            // IF and Else Statement 
            double temp;

            temp = Convert.ToDouble(txtTemp.Text);

            if(temp >= 40 )
            {
                MessageBox.Show("Temp is Hot");
            }
            else
            {
                MessageBox.Show("Temp is Normal");
            }
        }
    }
}
