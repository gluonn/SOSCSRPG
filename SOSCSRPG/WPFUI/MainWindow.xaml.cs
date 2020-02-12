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
using Engine.ViewModels;

namespace WPFUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Set as private variable to make it more strict as no other class will use properties from Engine.ViewModels from MainWindow
        // Set private inside class but not accessible out the function
        // _gameSession is the name of the variable, based on normal naming convention
        private GameSession _gameSession;
        public MainWindow()
        {
            InitializeComponent();
            // Instantiate new GameSession object and store it into a variable
            _gameSession = new GameSession();
            // DataContext is what the xaml file will refer to for the values
            DataContext = _gameSession;
        }
    }
}