using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turbo.az
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(maskedTextBox1.Text=="(050) 682-30-05")
            {
                Admin admin = new Admin();
                admin.Show();
                this.Hide();
            }
            else
            {
                label3.Visible = true;
            }
        }
    }
}
