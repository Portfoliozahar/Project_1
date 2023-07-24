using Newtonsoft.Json;
using Project.Exceptions;
using Project.Model;
using Project.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows;

namespace Project.Data
{
    
    public class LocalDatabase
    {





        private static LocalDatabase instance;
        private LocalDatabase()
        { }
        public static LocalDatabase GetInstance()
        {
            if (instance == null)
            {
                instance = new LocalDatabase();
                Incomings = new ObservableCollection<Incoming>();
                Accounts = new ObservableCollection<Account>();
                Expenses = new ObservableCollection<Expense>();
               
                CategoryGroups = new ObservableCollection<CategoryGroup>();
                Categories = new ObservableCollection<Category>();
                
                LoadAccounts();
                LoadExpenses();
                LoadIncomings();
                LoadCategories();
            }
            return instance;
        }

        #region FILES
        private static readonly string incommingsFile = "incomings.json";
        private static readonly string accountsFile = "accounts.json";
        private static readonly string expensesFile = "expenses.json";
     
        private static readonly string categoryGroupsFile = "categoryGroups.json";

        private static readonly string categoriesFile = "categories.json";
        #endregion

        #region LISTS
        private static ObservableCollection<Incoming> Incomings { get; set; }
        private static ObservableCollection<Expense> Expenses { get; set; }
        private static ObservableCollection<Account> Accounts { get; set; }
       
        private static ObservableCollection<Category> Categories { get; set; }
        private static ObservableCollection<CategoryGroup> CategoryGroups { get; set; }
        #endregion

        #region DELETE
        internal void DeleteExpense(Expense expense)
        {
            Expenses.Remove(expense);
            SaveExpenses();
            SaveAccounts();
        }
       
        internal void DeleteIncoming(Incoming incoming)
        {
            Incomings.Remove(incoming);
            SaveIncomings();
            SaveAccounts();
        }
        internal void DeleteAccount(AccountItemViewModel accountItem)
        {
            var account = accountItem.Account;
           
            var totali = (from i in Incomings
                          where i.Account.Name.Equals(account.Name)
                          select i).Count();
            var totale = (from e in Expenses
                          where e.Account.Name.Equals(account.Name)
                          select e).Count();

            if (totale == 0 && totali == 0)
            {
                Accounts.Remove(account);
                SaveAccounts();
            }
            else
                throw new Exep();
        }
        #endregion

        #region ADD
        
        internal void AddAccount(string name, double initialAmount)
        {
            Accounts.Add(new Account(name, initialAmount));
            SaveAccounts();
        }
        
        internal void AddExpense(double value, DateTime date, Account account, ItemCategory category , string comment)
        {
            var expense = new Expense(date, account, value, category, comment);
            Expenses.Add(expense);
            expense.Move(value);
            SaveAccounts();
            SaveExpenses();
        }
        internal void AddIncoming(double value, DateTime date, Account account, ItemCategory category,string comment)
        {
            var incoming = new Incoming(date, account, value, category, comment);
            Incomings.Add(incoming);
            incoming.Move(value);
            SaveAccounts();
            SaveIncomings();
        }
      
        #endregion

        #region UPDATE
        


        internal void UpdateAccount()
        {
            SaveAccounts();
        }

        public void UpdateTransaction()
        {
            SaveExpenses();
            SaveIncomings();
            
        }
        #endregion

        #region LOAD
        private static void LoadIncomings()
        {
            FileInfo f = new FileInfo(incommingsFile);
            if (f.Exists)
            {
                StreamReader sr = new StreamReader(incommingsFile);

                var incomingsJson = sr.ReadToEnd();

                var IncomingsBD = JsonConvert.DeserializeObject<ObservableCollection<Incoming>>(incomingsJson);

                Incomings = IncomingsBD;

                sr.Dispose();
                sr.Close();
            }
        }
        private static void LoadAccounts()
        {
            FileInfo f = new FileInfo(accountsFile);
            //if (f.Exists)
            //{
                StreamReader sr = new StreamReader(accountsFile);

                var accountsJson = sr.ReadToEnd();

                var AccountsBD = JsonConvert.DeserializeObject<ObservableCollection<Account>>(accountsJson);

                Accounts = AccountsBD;

                sr.Dispose();
                sr.Close();
            //}
            //else
            //{
            //    Accounts.Add(new Account("Личный кошелёк", 0.00));
            //    var df = JsonConvert.SerializeObject(Accounts);

            //    StreamWriter sr = new StreamWriter(accountsFile);

            //    sr.Write(df);
            //    sr.Flush();
            //    sr.Close();
            //}
        }
       
        private static void LoadExpenses()
        {
            FileInfo f = new FileInfo(expensesFile);
            if (f.Exists)
            {
                StreamReader sr = new StreamReader(expensesFile);

                var expensesJson = sr.ReadToEnd();

                var ExpensesBD = JsonConvert.DeserializeObject<ObservableCollection<Expense>>(expensesJson);

                Expenses = ExpensesBD;

                sr.Dispose();
                sr.Close();
            }
        }
       
        private static void LoadCategories()
        {
            LoadCategoryGroups();

            FileInfo f = new FileInfo(categoriesFile);
            if (f.Exists)
            {
                StreamReader sr = new StreamReader(categoriesFile);

                var categoriesJson = sr.ReadToEnd();

                var CategoriesBD = JsonConvert.DeserializeObject<ObservableCollection<Category>>(categoriesJson);

                Categories = CategoriesBD;

                sr.Dispose();
                sr.Close();
            }
            else
            {
                var group = (from cg in CategoryGroups
                             where cg.Name.Equals("Доходы")
                             select cg).FirstOrDefault();
                Categories.Add(new Category("Заработная плата", group));
                Categories.Add(new Category("Доход с сдачи в аренду недвижимости;", group));
                Categories.Add(new Category("Иные доходы", group));
                

                group = (from cg in CategoryGroups
                         where cg.Name.Equals("Расходы")
                         select cg).FirstOrDefault();
                Categories.Add(new Category("Продукты питания", group));
                Categories.Add(new Category("Транспорт", group));
                Categories.Add(new Category("Мобильная связь", group));
                Categories.Add(new Category("Интернет", group));
                Categories.Add(new Category("Развлеченение", group));
                Categories.Add(new Category("Другое", group));


                var df = JsonConvert.SerializeObject(Categories);

                StreamWriter sr = new StreamWriter(categoriesFile);

                sr.Write(df);
                sr.Flush();
                sr.Close();
            }
        }
        private static void LoadCategoryGroups()
        {
            FileInfo f = new FileInfo(categoryGroupsFile);
            if (f.Exists)
            {
                StreamReader sr = new StreamReader(categoryGroupsFile);

                var categoryGroupsJson = sr.ReadToEnd();

                var CategoryGroupsBD = JsonConvert.DeserializeObject<ObservableCollection<CategoryGroup>>(categoryGroupsJson);

                CategoryGroups = CategoryGroupsBD;

                sr.Dispose();
                sr.Close();
            }
            else
            {
                CategoryGroups.Add(new CategoryGroup("Доходы"));
                CategoryGroups.Add(new CategoryGroup("Расходы"));
     

                var df = JsonConvert.SerializeObject(CategoryGroups);

                StreamWriter sr = new StreamWriter(categoryGroupsFile);

                sr.Write(df);
                sr.Flush();
                sr.Close();
            }
        }
        #endregion

        #region SAVE
        private void SaveIncomings()
        {
            var df = JsonConvert.SerializeObject(Incomings);

            StreamWriter sr = new StreamWriter(incommingsFile);

            sr.Write(df);
            sr.Flush();
            sr.Close();
        }
        private void SaveAccounts()
        {
            var df = JsonConvert.SerializeObject(Accounts);

            StreamWriter sr = new StreamWriter(accountsFile);

            sr.Write(df);
            sr.Flush();
            sr.Close();
        }
        private void SaveExpenses()
        {
            var df = JsonConvert.SerializeObject(Expenses);

            StreamWriter sr = new StreamWriter(expensesFile);

            sr.Write(df);
            sr.Flush();
            sr.Close();
        }
        
        #endregion

        #region GET
        
        internal ObservableCollection<Expense> GetExpenses() => Expenses;
        internal ObservableCollection<Incoming> GetIncomings() => Incomings;
        internal ObservableCollection<Account> GetAccounts() => Accounts;
        internal ObservableCollection<Category> GetCategories() => Categories;
        #endregion
    }





}
