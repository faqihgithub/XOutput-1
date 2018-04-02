﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using XOutput.Input;
using XOutput.UI.Component;
using XOutput.UI.View;

namespace XOutput.UI.Component
{
    /// <summary>
    /// Interaction logic for ControllerView.xaml
    /// </summary>
    public partial class ControllerView : UserControl, IViewBase<ControllerViewModel, ControllerModel>
    {
        protected readonly ControllerViewModel viewModel;
        public ControllerViewModel ViewModel => viewModel;

        public ControllerView(ControllerViewModel viewModel)
        {
            this.viewModel = viewModel;
            DataContext = viewModel;
            InitializeComponent();
        }
        private void OpenClick(object sender, RoutedEventArgs e)
        {
            viewModel.Edit();
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            viewModel.StartStop();
        }
    }
}
