using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace playgroundManager
{
    public partial class login : Form
    {
        Thread th;
        public login()
        {
            InitializeComponent();
        }

        private void signin_btn_Click(object sender, EventArgs e)
        {
            if (name_txt.Text == "")
            {
                MessageBox.Show("Please enter your user name");
            }
            else if (password_txt.Text == "")
            {
                MessageBox.Show("Please enter your password");
            }
            else
            {
                if (name_txt.Text == "sameen.nasir" && password_txt.Text == "beeftacosoup")
                {
                    this.Close();
                    th = new Thread(opennewform);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else
                {
                    MessageBox.Show("Incorrect UserName or Password!");
                }
            }
        }
        private void opennewform(object obj)
        {
            Application.Run(new welcome());
        }
    }
}
