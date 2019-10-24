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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Tree MyTree;
        public int StepCounter = 1;
        public Window1(Tree MyTree)
        {
            InitializeComponent();
            this.MyTree = MyTree;
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void LeftBtn_Click(object sender, RoutedEventArgs e)
        {
            MyTree.Branch.Add(false);
            LoadIconSet();
            
        }

        private void RightBtn_Click(object sender, RoutedEventArgs e)
        {
            MyTree.Branch.Add(true);
            LoadIconSet();

        }

        private void LoadIconSet()
        {
            switch (StepCounter)
            {
                case 1:
                    LeftImg.Source = new BitmapImage(new Uri(@"/images/dice.png", UriKind.Relative));
                    RightImg.Source = new BitmapImage(new Uri(@"/images/action.png", UriKind.Relative));
                    break;
                case 2:
                    LeftImg.Source = new BitmapImage(new Uri(@"/images/drake.png", UriKind.Relative));
                    RightImg.Source = new BitmapImage(new Uri(@"/images/scifi.png", UriKind.Relative));
                    break;
                case 3:
                    if (MyTree.Branch[2] == true) { 
                    LeftImg.Source = new BitmapImage(new Uri(@"/images/cosmos.png", UriKind.Relative));
                     RightImg.Source = new BitmapImage(new Uri(@"/images/postapo.png", UriKind.Relative));
                    }
                    else
                    {
                        LeftImg.Source = new BitmapImage(new Uri(@"/images/heroic.png", UriKind.Relative));
                        RightImg.Source = new BitmapImage(new Uri(@"/images/dark.png", UriKind.Relative));
                    }
                    break;
                case 4:
                    this.Close();
                    ShowCover();
                    break;
                default:
                    break;
            }
            StepCounter++;
        }

        private void ShowCover()
        {
            var cover1 = new Cover(MyTree.Result());
           cover1.LoadCover();
            cover1.Show();
        }
    }
}
