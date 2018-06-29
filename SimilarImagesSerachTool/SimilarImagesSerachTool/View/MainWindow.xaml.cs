﻿using System;
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
using System.Windows.Forms;

namespace SimilarImagesSerachTool.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private ViewModel.MainWindowViewModel _vm;

        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(ViewModel.MainWindowViewModel vm)
        {
            InitializeComponent();
            this.DataContext = vm;
            _vm = vm;
        }

        private void RootFolderSelectButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new FolderBrowserDialog {Description = @"類似画材検索する対象フォルダを選択して下さい"};
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _vm.SetRootPath(dialog.SelectedPath);
            }
        }
    }
}
