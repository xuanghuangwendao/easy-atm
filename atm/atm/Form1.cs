using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atm
{
    public partial class Form1 : Form
    {
        Info info = new Info();
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(Info info)
        {
            InitializeComponent();
            this.info = info;
        }

        public void getInfo(Info info)
        {
            this.info = info;
        }

        private void ok_Click(object sender, EventArgs e)
        {
            string id = this.textBox1.Text;
            string password = this.textBox2.Text;
            User user = info.login(id,password);
            if(user != null)
            {
                Form2 form2 = new Form2(this,info, user);
                form2.Show();
                this.Hide();
                this.textBox1.Text = "";
                this.textBox2.Text = "";
            }
            else 
            {
                MessageBox.Show("账号密码错误");
            }
           
        }
    }
}
