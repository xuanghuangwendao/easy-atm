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
    public partial class Form4 : Form
    {
        Info info = new Info();
        User user = new User();
        Form2 form2 = new Form2();
        public Form4()
        {
            InitializeComponent();
        }
        public Form4(Form2 form2, Info info, User user)
        {
            this.form2 = form2;
            this.info = info;
            this.user = user;
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string text = this.textBox1.Text;
            decimal money;
            if (decimal.TryParse(text, out money))
            {
                if (user.Amount < money)
                {
                    MessageBox.Show("余额不足");
                    return;
                }

                info.withdrawal(user, money);
                MessageBox.Show("取款成功！");
                this.Close();
                
                form2.Show();
            
            }



        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            form2.Show();
        }
    }
}
