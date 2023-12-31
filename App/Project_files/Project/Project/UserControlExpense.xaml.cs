﻿using Project.Control;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using System.Linq.Expressions;

namespace Project
{

    public partial class UserControlExpense : UserControl
    {
        ControlExpense control;

        public UserControlExpense()
        {
            InitializeComponent();
            control = new ControlExpense();
            control.CreateExpTable();


            ChangeMonth();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            var accounts = control.GetAccountList();
            if (accounts.Count > 0)
                ComboBoxAccounts.ItemsSource = accounts;

           

            ComboBoxCategory.ItemsSource = control.GetCategoryList();
            ComboBoxCategory.SelectedIndex = -1;
            LoadExpenses();

           

        }

        private void LoadExpenses()
        {
            var transactions = control.GetExpenseList();
            if (transactions.Count > 0)
            {
                ListViewTransactions.ItemsSource = transactions;
            }
            else
            {
                ListViewTransactions.ItemsSource = null;
            }

            var group = transactions
                .GroupBy(e => e.Category != null ? e.Category.Name : null)
                .Select(t => new
                {
                    Category = t.First().Category != null ? t.First().Category.Name : "БЕЗ КАТЕГОРИИ",
                    Total = t.Sum(e => e.Value).ToString("c")
                }).ToList();


            

            TextBlockTotal.Text = transactions.Sum(t => t.Value).ToString("c");

            TextBlockExpensesEmpty.Visibility = transactions.Count > 0 ? Visibility.Collapsed : Visibility.Visible;
        }

        private void ButtonAddExpense_Click(object sender, RoutedEventArgs e)
        {
            var messageQueue = SnackbarThree.MessageQueue;
            if (TextBoxValue.Text == string.Empty)
            {
                TextBoxValue.Focus();
                Task.Factory.StartNew(() => messageQueue.Enqueue("Введите сумму"));
                return;
            }

            if (DatePickerData.Text == string.Empty)
            {
                DatePickerData.Focus();
                Task.Factory.StartNew(() => messageQueue.Enqueue("Введите дату"));
                return;
            }

            if (ComboBoxCategory.Text == string.Empty)
            {
                ComboBoxCategory.Focus();
                Task.Factory.StartNew(() => messageQueue.Enqueue("Выберете категорию"));
                return;
            }

            if (ComboBoxAccounts.Text == string.Empty)
            {
                ComboBoxAccounts.Focus();
                Task.Factory.StartNew(() => messageQueue.Enqueue("Выберете источник счёта"));
                return;
            }


            Double value = Double.Parse(TextBoxValue.Text, NumberStyles.Currency);
            DateTime date = DatePickerData.SelectedDate ?? DateTime.Now;
            var account = ComboBoxAccounts.SelectedItem;

            var category = ComboBoxCategory.SelectedItem;
            var comment = ComboBoxComment.Text;


            control.SaveExpense(value, date, account, category, comment);
            LoadExpenses();

            TextBoxValue.Text = string.Empty;
            ComboBoxAccounts.SelectedIndex = -1;
            DatePickerData.Text = string.Empty;
            ComboBoxCategory.SelectedIndex = -1;
            ComboBoxComment.Text = string.Empty;




            }

        private void TextBoxValue_LostFocus(object sender, RoutedEventArgs e)
        {
            var messageQueue = SnackbarThree.MessageQueue;
            Double.TryParse(TextBoxValue.Text, out double result);

            if (!(new Regex(@"\d+(,\d{1,2})?")).Match(result.ToString()).Success || result <= 0)
            {
                TextBoxValue.Text = string.Empty;
                Task.Factory.StartNew(() => messageQueue.Enqueue("Ошибка"));
            }
            else
            {
                TextBoxValue.Text = result.ToString("C");
            }
        }

        private void TextBoxValue_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBoxValue.Text = string.Empty;
        }

        private void ButtonPreviousMonth_Click(object sender, RoutedEventArgs e)
        {
            control.PreviousMonth();
            LoadExpenses();
            ChangeMonth();
        }

        private void ChangeMonth()
        {
            TextBlockYear.Text = control.ActualDate.Year.ToString();
            TextBlockMonth.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(control.ActualDate.Month);
        }

        private void ButtonNextMonth_Click(object sender, RoutedEventArgs e)
        {
            control.NextMonth();
            LoadExpenses();
            ChangeMonth();
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            control.Delete(((Button)sender).DataContext);
            LoadExpenses();
        }

    private void ButtonEdit_Click(object sender, RoutedEventArgs e)
    {
            WindowEditTransaction transaction = new WindowEditTransaction(((Button)sender).DataContext);
            transaction.ShowDialog();

            LoadExpenses();
     }
   }
}
