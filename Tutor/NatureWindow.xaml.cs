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

namespace Tutor
{
    /// <summary>
    /// Interaction logic for NatureWindow.xaml
    /// </summary>
    public partial class NatureWindow : Window
    {
        public NatureWindow()
        {
            InitializeComponent();
            RegionsInit();
        }
        public void RegionsInit()
        {
            cbRegion.Items.Add("Europe");
            cbRegion.Items.Add("Asia");
            cbRegion.Items.Add("Africa");
            cbRegion.Items.Add("North America");
            cbRegion.Items.Add("South America");
            cbRegion.Items.Add("Australia");
        }

        public void CountriesInit()
        {
            cbCountry.Items.Add("Great Britain");
            cbCountry.Items.Add("France");
            cbCountry.Items.Add("Ukraine");
        }

    }
}
