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

namespace Robots_inc
{
    /// <summary>
    /// Interaction logic for UcWorkers.xaml
    /// </summary>
    public partial class UcWorkers : UserControl
    {
        public UcWorkers(Worker worker)
        {
            InitializeComponent();
            this.DataContext = worker;
            if(worker.BirthDate.Day == DateTime.Now.Day && worker.BirthDate.Month == DateTime.Now.Month)
            {
                bday.Content = bday.Content + " 🎂🎂🎂";
            }
            if(worker is OperationManager)
            {
                grid.Background = Brushes.Khaki;
                brMain.BorderThickness = new Thickness(6);
            }
            else if(worker is GeneralManager)
            {
                grid.Background = Brushes.DarkCyan;
                brMain.BorderThickness = new Thickness(12);
            }
            else
            {
                grid.Background = Brushes.DarkGray;
                
            }
            lbRole.Content = "Role: " + worker.GetType().Name;
        }
    }
}
