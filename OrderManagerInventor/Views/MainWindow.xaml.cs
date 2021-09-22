﻿using OrderInvAddin.ViewModels;
using System.Windows;

namespace OrderInvAddin.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowViewModel viewModel = new MainWindowViewModel();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = viewModel;

            if (viewModel.CloseAction == null)
                viewModel.CloseAction = () => this.Close();
        }
    }
}
