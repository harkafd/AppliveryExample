﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MovieViewerApp {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        public App() {
            //Restart Event
            this.Exit += App_Exit;
        }

        private void App_Exit(object sender, ExitEventArgs e) {
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(5));
            Process.Start(System.Reflection.Assembly.GetEntryAssembly().Location);
        }
    }
}
