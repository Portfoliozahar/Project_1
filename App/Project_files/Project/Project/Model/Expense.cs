using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model
{
    class Expense : Transaction
    {
        public Account Account { get; set; }
        public Expense(DateTime date, Account account, double value, ItemCategory category, string comment)
        {
            Description = account.Name;
            Date = date;
            Account = account;
            Value = value;
            Category = category;
            Comment = comment ;
        }

        public override void Move(Double value)
        {
            Account.Debit(value);
        }
    }
}
