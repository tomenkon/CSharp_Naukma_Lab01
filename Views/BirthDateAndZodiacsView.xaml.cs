﻿using Lab1.ViewModels;
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

namespace Lab1.Views
{
    /// <summary>
    /// Interaction logic for BirthDateAndZodiacsView.xaml
    /// </summary>
    public partial class BirthDateAndZodiacsView: UserControl
    {
        private BirthDateAndZodiacsViewModel _viewModel;
        
        public BirthDateAndZodiacsView()
        {
            InitializeComponent();
            DataContext = _viewModel = new BirthDateAndZodiacsViewModel();
        }

    }
}
