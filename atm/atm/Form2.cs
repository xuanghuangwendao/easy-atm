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
    public partial class Form2 : Form
    {
        public Info info = new Info();
        public User user = new User();
        Form1 form1 = new Form1();
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 form1,Info info, User user)
        {
            this.form1 = form1;
            this.info = info;
            this.user = user;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("当前余额为" + user.Amount + "元");
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            form1.Show();
            form1.getInfo(info);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this,info,user);
            this.Hide();
            form3.Show();

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
              
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(this, info, user);
            this.Hide();
            form4.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(this, info, user);
            this.Hide();
            form5.Show();
        }
    }
}
