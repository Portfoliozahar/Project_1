using MySql.Data.MySqlClient;
using Project.Data;
using Project.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Project.Control
{
    class ControlExpense
    {
        LocalDatabase database;

        public DateTime ActualDate { get; internal set; }

        public ControlExpense()
        {
            ActualDate = DateTime.Now;

            database = LocalDatabase.GetInstance();
        }

        public List<Expense> GetExpenseList()
        {
            var expenses = database.GetExpenses();
            return (from e in expenses
                    where e.Date.Year.Equals(ActualDate.Year) && e.Date.Month.Equals(ActualDate.Month)
                    select e).OrderByDescending(e => e.Date).ToList();
        }

        public List<Account> GetAccountList() => database.GetAccounts().Where(a => a.Enabled).ToList();





        public void CreateExpTable()
        {
            string connsrring = "server=localhost;uid=root;pwd=12345;database=db";
            using (MySqlConnection con = new MySqlConnection(connsrring))
            {
                con.Open();

                string createTableQuery = @"
                CREATE TABLE IF NOT EXISTS exp (
                    id INT AUTO_INCREMENT PRIMARY KEY,
                    value DOUBLE,
                    date DATE,
                    account VARCHAR(255),
                    category VARCHAR(255),
                    comment VARCHAR(255)
                )";

                using (MySqlCommand cmd = new MySqlCommand(createTableQuery, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }


        private void UpdateUserAccount(Account account, double value)
        {
            string connsrring = "server=localhost;uid=root;pwd=12345;database=db";
            using (MySqlConnection con = new MySqlConnection(connsrring))
            {
                con.Open();

                string updateQuery = @"
        UPDATE user
        SET initialAmount = initialAmount - @value
        WHERE name = @name";

                using (MySqlCommand cmd = new MySqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@name", account.Name);
                    cmd.Parameters.AddWithValue("@value", value);

                    cmd.ExecuteNonQuery();
                }
            }
        }


        internal void SaveExpense(double value, DateTime date, object account, object category, string comment)
        {
            var acc = (from a in GetAccountList()
                       where a.Name.Equals(((Account)account).Name)
                       select a).FirstOrDefault();

            acc.Debit(value);

            database.AddExpense(value, date, acc, (ItemCategory)category, comment);

            // Сохраняем обновленный баланс счета в таблице 'user'
            UpdateUserAccount(acc, value);

            Account selectedAccount = (Account)account;
            ItemCategory selectedCategory = (ItemCategory)category;

            string connsrring = "server=localhost;uid=root;pwd=12345;database=db";
            using (MySqlConnection con = new MySqlConnection(connsrring))
            {
                con.Open();

                string insertQuery = @"
                INSERT INTO exp (value, date, account, category, comment)
                VALUES (@value, @date, @account, @category, @comment)";

                using (MySqlCommand cmd = new MySqlCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@value", value);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@account", selectedAccount.Name);
                    cmd.Parameters.AddWithValue("@category", selectedCategory.Name);
                    cmd.Parameters.AddWithValue("@comment", comment);

                    cmd.ExecuteNonQuery();
                }
            }
        }




        internal void NextMonth() => ActualDate = ActualDate.AddMonths(1);

        public ListCollectionView GetCategoryList()
        {
            var categories = database.GetCategories().ToList();
            List<ItemCategory> items = new List<ItemCategory>();

            foreach (var item in categories)
            {
                items.Add(new ItemCategory { Group = item.Group.Name, Name = item.Name });
            }

            ListCollectionView lcv = new ListCollectionView(items);
            lcv.GroupDescriptions.Add(new PropertyGroupDescription("Group"));

            return lcv;
        }

        internal void PreviousMonth() => ActualDate = ActualDate.AddMonths(-1);



        internal void Delete(object expense)
        {
            var e = (Expense)expense;
            var account = (from a in database.GetAccounts()
                           where a.Name.Equals(e.Account.Name)
                           select a).FirstOrDefault();
            account.Credit(e.Value);
            database.DeleteExpense(e);
        }
    }
}