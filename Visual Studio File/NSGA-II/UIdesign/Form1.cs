using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIdesign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            password.PasswordChar = '*';
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (username.Text == "admin" && password.Text == "123123")
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else
                MessageBox.Show("用户名或密码错误");
        }

    }
}
