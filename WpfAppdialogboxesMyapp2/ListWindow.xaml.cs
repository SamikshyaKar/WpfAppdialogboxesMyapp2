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
using static WpfAppdialogboxesMyapp2.EnterWindow;

namespace WpfAppdialogboxesMyapp2
{
    /// <summary>
    /// Interaction logic for ListWindow.xaml
    /// </summary>
    /// 
    public delegate void CloseListener(object sender, EventArgs e);
    public delegate void ClearListener(object sender, EventArgs e);

    public partial class ListWindow : Window
    {
        private readonly List<Name> names;

        public event CloseListener ListClosed;

        public event ClearListener ListCleared;

        public ListWindow( List<Name> names)
        {
            InitializeComponent();
            this.names = names;
            ListShowDialg.ItemsSource = names;
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            if(ListCleared !=null)
            {

                ListCleared(this, new EventArgs());
            }
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        public void NewName(object sender , NameEventEventArgs e)
        {
            ListShowDialg.ItemsSource = null;
            ListShowDialg.ItemsSource = names;

        }

        private void Window_Closed(object sender, EventArgs e)
        {
            if (ListClosed!=null)
            {
                ListClosed(this, new EventArgs());
            }
        }
    } 

}
