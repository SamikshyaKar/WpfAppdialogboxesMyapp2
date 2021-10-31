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

namespace WpfAppdialogboxesMyapp2
{
    /// <summary>
    /// Interaction logic for EnterWindow.xaml
    /// </summary>
    public partial class EnterWindow : Window
    {

        public delegate void Namelistener(object sender, NameEventEventArgs e);
        public class NameEventEventArgs:EventArgs
        {
            private Name name;

            public NameEventEventArgs( Name name)
            {
                this.name = name;
            }

            public Name Name
            {
                get { return name; }

            }

        }

        public event Namelistener Name_entered;

        public EnterWindow()
        {
            InitializeComponent();
        }

        private void BtnOKEnter_Click(object sender, RoutedEventArgs e)
        {
            string firstname = TxtFirstName.Text.Trim();
            string lastname = TxtLastName.Text.Trim();

            if(firstname.Length>0 && lastname.Length>0)
            {
                if(Name_entered !=null)
                {

                    Name_entered(this, new NameEventEventArgs(new Name(firstname, lastname)));
                }
                TxtFirstName.Clear();
                TxtLastName.Clear();
                TxtFirstName.Focus();
            }

            else { MessageBox.Show("Enter Both"); }
        }

        private void BtnCloseEnter_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
