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
using System.Windows.Shapes;

namespace Pick_an_RPG
{
    /// <summary>
    /// Logika interakcji dla klasy Cover.xaml
    /// </summary>
    public partial class Cover : Window
    {
        string CoverPath = "";

        public Cover(string result)
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            this.CoverPath = result;

        }

        public void LoadCover()
        {
            CoverImg.Source = new BitmapImage(new Uri(@"/images/covers/" + CoverPath, UriKind.Relative));
        }

    }
}
