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
using static System.Net.WebRequestMethods;

namespace MovieViewerApp {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private const string AppLogoURL = "https://images.vexels.com/media/users/3/318492/isolated/preview/4c3ef0e5fa3ca32df0c01597a95e3a5a-icono-azul-de-la-claqueta-de-cine.png";
        private const string AppName = "Movie Viewer";
        public MainWindow() {
            InitializeComponent();
            Icon = (ImageSource?)new ImageSourceConverter().ConvertFromString(AppLogoURL); 
            Title = AppName;
        }
    }
}
