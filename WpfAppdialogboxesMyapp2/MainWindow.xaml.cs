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

namespace WpfAppdialogboxesMyapp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private List<Name> names = new List<Name>();

        private ListWindow listdiag = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnEnterName_Click(object sender, RoutedEventArgs e)
        {
            EnterWindow EnterDialg = new EnterWindow();
            EnterDialg.Name_entered += NewName;
            if(listdiag !=null)
            {

                EnterDialg.Name_entered += listdiag.NewName;
            }
            EnterDialg.ShowDialog();
        }

        public void NewName(object sender, EnterWindow.NameEventEventArgs e)
        {
            names.Add(e.Name);
        }

        private void BtnShowList_Click(object sender, RoutedEventArgs e)
        {
            if(listdiag==null)
            {
                listdiag = new ListWindow(names);
                listdiag.ListCleared += LListCleared;
                listdiag.ListClosed += LListClosed;

                listdiag.Show();

            }

            //listdiag.Show();

        }

        private void LListClosed(object sender, EventArgs e)
        {
            listdiag = null;
        }

      

        public void LListCleared(object sender, EventArgs e)
        {
            names.Clear();
            listdiag.NewName(this, null);
        }
    }
}
