using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atm
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]

        



        static void Main()
        {
            Info info = new Info();
            User user1 = new User("1001", "王振华", "666", true, 100.0m);
            User user2 = new User("1002", "张振华", "666", true, 100.0m);
            User user3 = new User("1003", "李振华", "666", true, 100.0m);
            User user4 = new User("1004", "赵振华", "666", true, 100.0m);
            info.add(user1); info.add(user2); info.add(user3); info.add(user4);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(info));
        }
    }
}
