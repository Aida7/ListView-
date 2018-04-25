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
using System.Diagnostics;
using System.Data;

namespace Processes
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenProcesses_Clik(object sender, RoutedEventArgs e)
        {
            List<ProcessList> lists = new List<ProcessList>();
            Process[] processes = Process.GetProcesses();
            ProcessList process;
            foreach (var pro in processes)
            {
                process= new ProcessList{ Id = pro.Id, MachineName = pro.MachineName,ProcessName=pro.ProcessName };
                lists.Add(process); 
            }

            listView.ItemsSource= lists.ToList();
        }
    }
}
