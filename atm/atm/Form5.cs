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
    public partial class Form5 : Form
    {
        Info info = new Info();
        User user = new User();
        Form2 form2 = new Form2();
        public Form5()
        {
            InitializeComponent();
        }
        public Form5(Form2 form2, Info info, User user)
        {
            this.form2 = form2;
            this.info = info;
            this.user = user;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string distId = this.textBox1.Text;
            string s = this.textBox2.Text;
            string password = this.textBox3.Text;

            User distUser = null;

            foreach(User temp in info.list)
            {
                if (temp.CardId.Equals(distId))
                {
                    distUser = temp;
                    break;
                }
                
            }

            if(distUser == user)
            {
                MessageBox.Show("请输入正确银行卡号。");
                return;
            }

            decimal money;
            if (decimal.TryParse(s,out money)){
            }
            else
            {
                MessageBox.Show("请输入正确转账金额。");
                return;

            }

            if (password.Equals(user.Password))
            {
               
            }
            else
            {
                MessageBox.Show("请输入正确密码。");
                return;

            }

            if (money > user.Amount)
            {
                MessageBox.Show("余额不足。");
                return;

            }

            info.deposit(distUser, money);
            info.withdrawal(user, money);
            MessageBox.Show("转账成功。");
            this.Close();
            form2.Show();

        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            form2.Show();
        }
    }
}
