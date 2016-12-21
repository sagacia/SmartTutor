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
using Tutor.Authorization.ViewModel;

namespace Tutor
{
    /// <summary>
    /// Interaction logic for AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        AuthorizationViewModel model;
        public AuthorizationWindow()
        {
            InitializeComponent();
            model = new AuthorizationViewModel();
            this.DataContext = model;
        }
    }
}
