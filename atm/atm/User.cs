using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm
{
    public class User
    {
        private string cardId;
        private string userName;
        private string password;
        private bool control;
        private decimal amount;

        public User(string cardId, string userName, string password, bool control, decimal amount)
        {
            this.cardId = cardId;
            this.userName = userName;
            this.password = password;
            this.control = control;
            this.amount = amount;
        }
        public User()
        {

        }

        public string CardId { get => cardId; set => cardId = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public bool Control { get => control; set => control = value; }
        public decimal Amount { get => amount; set => amount = value; }

    }
}
