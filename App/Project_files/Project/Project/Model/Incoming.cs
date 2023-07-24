using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model
{
    public class Incoming : Transaction
    {
        public Account Account { get; private set; }

        public Incoming(DateTime date, Account account, double value, ItemCategory category, string comment)
        {
            Description = account.Name;
            Date = date;
            Account = account;
            Value = value;
            Category = category;
            Comment = comment;
        }

        public override void Move(double value)
        {
            Account.Credit(value);
        }
    }
}
