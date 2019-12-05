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
    public partial class Form3 : Form
    {
        Info info = new Info();
        User user = new User();
        Form2 form2 = new Form2();
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(Form2 form2,Info info, User user)
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
            if(decimal.TryParse(text, out money))
            {
                MessageBox.Show(user.Amount.ToString());
                info.deposit(user, money);
                MessageBox.Show("存款成功！" + user.Amount.ToString());
                this.Close();
                form2.Show();
            }
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {

            form2.Show();
        }
    }
}
