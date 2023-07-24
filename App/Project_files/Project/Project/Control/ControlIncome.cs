using MySql.Data.MySqlClient;
using Project.Data;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Project.Control
{
    class ControlIncome
    {
        LocalDatabase database;

        public DateTime ActualDate { get; private set; }

        public ControlIncome()
        {
            ActualDate = DateTime.Now;

            database = LocalDatabase.GetInstance();
        }

        public List<Incoming> GetIncomingList()
        {
            var incomings = database.GetIncomings();
            return (from i in incomings
                    where i.Date.Year.Equals(ActualDate.Year) && i.Date.Month.Equals(ActualDate.Month)
                    select i).OrderByDescending(i => i.Date).ToList();
        }

        public List<Account> GetAccountList()
        {
            return database.GetAccounts().Where(a => a.Enabled).ToList();
        }




        public void CreateInTable()
        {
            string connsrring = "server=localhost;uid=root;pwd=12345;database=db";
            using (MySqlConnection con = new MySqlConnection(connsrring))
            {
                con.Open();

                string createTableQuery = @"
                CREATE TABLE IF NOT EXISTS Income (
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

        private void UpdateUserAcc(Account account, double value)
        {
            string connsrring = "server=localhost;uid=root;pwd=12345;database=db";
            using (MySqlConnection con = new MySqlConnection(connsrring))
            {
                con.Open();

                string updateQuery = @"
        UPDATE user
        SET initialAmount = initialAmount + @value
        WHERE name = @name";

                using (MySqlCommand cmd = new MySqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@name", account.Name);
                    cmd.Parameters.AddWithValue("@value", value);

                    cmd.ExecuteNonQuery();
                }
            }
        }



        internal void SaveIncoming(double value, DateTime date, object account, object category, string comment)
        {
            var acc = (from a in GetAccountList()
                      where a.Name.Equals(((Account)account).Name)
                      select a).FirstOrDefault();

            database.AddIncoming(value, date, acc, (ItemCategory)category, comment);


           
            UpdateUserAcc(acc, value);

            Account selectedAccount = (Account)account;
            ItemCategory selectedCategory = (ItemCategory)category;

            string connsrring = "server=localhost;uid=root;pwd=12345;database=db";
            using (MySqlConnection con = new MySqlConnection(connsrring))
            {
                con.Open();

                string insertQuery = @"
                INSERT INTO Income (value, date, account, category, comment)
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

        internal void NextMonth()
        {
            ActualDate = ActualDate.AddMonths(1);
        }

        internal void PreviousMonth()
        {
            ActualDate = ActualDate.AddMonths(-1);
        }

        internal void Delete(object incoming)
        {
            var i = (Incoming)incoming;
            var account = (from a in database.GetAccounts()
                           where a.Name.Equals(i.Account.Name)
                           select a).FirstOrDefault();
            account.Debit(i.Value);
            database.DeleteIncoming(i);
        }

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
    }
}