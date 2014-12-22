﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DailyHelper.Models;

namespace DailyHelper
{
    /// <summary>
    /// Interaction logic for WindowFeeEdit.xaml
    /// </summary>
    public partial class WindowFeeEdit : Window
    {
        public WindowFeeEdit()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            FeeDB fdb = new FeeDB();
            List<Fee> fees = fdb.GetFeeList();
            lstFee.ItemsSource = fees;
            if (lstFee.Items.Count>0)
            {
                lstFee.SelectedIndex = 0;
            }
        }
    }
}
