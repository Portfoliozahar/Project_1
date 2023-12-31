﻿using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace Project
{
   
    public partial class UserControlItemMonthlyIncome : UserControl
    {
        public UserControlItemMonthlyIncome(MonthlyIncome item, double maximum)
        {
            InitializeComponent();

            DataContext = item;
            var incomings = item.Incomings;

            if (incomings < 0)
            {
                incomings = 0;
            }

            GridIncoming.Height = (incomings * 130) / maximum;
        }
    }
}
