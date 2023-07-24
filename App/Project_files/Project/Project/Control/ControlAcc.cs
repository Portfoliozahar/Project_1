using MySql.Data.MySqlClient;
using Project.Data;
using Project.Model;
using Project.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project.Control
{
    public class ControlAcc
    {
        LocalDatabase database;

        public ControlAcc()
        {
            database = LocalDatabase.GetInstance();
        }

        public List<AccountItemViewModel> GetAccountList()
        {
            List<AccountItemViewModel> accountsVM = new List<AccountItemViewModel>();
            var accounts = database.GetAccounts().OrderByDescending(a => a.Amount).ToList();
            foreach (var item in accounts)
            {
                var account = new AccountItemViewModel(item);
                accountsVM.Add(account);
            }

            return accountsVM;
        }




        public void CreateUserTable()
        {
            string connsrring = "server=localhost;uid=root;pwd=12345;database=db";
            using (MySqlConnection con = new MySqlConnection(connsrring))
            {
                con.Open();

                string createTableQuery = @"
                CREATE TABLE IF NOT EXISTS user (
                    id INT AUTO_INCREMENT PRIMARY KEY,
                    name VARCHAR(255) NOT NULL,
                    initialAmount DOUBLE
                )";

                using (MySqlCommand cmd = new MySqlCommand(createTableQuery, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        internal void SaveAccount(string name, double initialAmount)
        {
            database.AddAccount(name, initialAmount);



            string connsrring = "server=localhost;uid=root;pwd=12345;database=db";
            using (MySqlConnection con = new MySqlConnection(connsrring))
            {
                con.Open();

                string insertQuery = @"
            INSERT INTO user (name, initialAmount)
            VALUES (@name, @initialAmount)";

                using (MySqlCommand cmd = new MySqlCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@initialAmount", initialAmount);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        internal void Delete(object account)
        {
            database.DeleteAccount((AccountItemViewModel)account);

        }



 
    }
}
