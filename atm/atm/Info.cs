using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm
{
    public class Info
    {
        public List<User> list = new List<User>();

        public Info(List<User> list)
        {
            this.list = list;
            
        }
        public Info()
        {

        }


        public void add(User user)
        {
            list.Add(user);
        }

        public void deposit(User user, decimal money)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (user.CardId.Equals(list[i].CardId))
                {
                    list[i].Amount += money;
                    return;
                }
            }
        }
        public void withdrawal(User user, decimal money)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (user.CardId.Equals(list[i].CardId))
                {
                    list[i].Amount -= money;
                    return;
                }
            }
        }

        public User login(string id,string password)
        {

            foreach(User temp in list)
            {
                if (id.Equals(temp.CardId))
                {
                    if (password.Equals(temp.Password))
                    {
                        return temp;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            return null;
           
        }


    }
}
