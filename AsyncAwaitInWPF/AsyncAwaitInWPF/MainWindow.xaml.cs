using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace AsyncAwaitInWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // async void <== Nur in Ausnahmefällen machen !
        // async Task
        // async Task<T>

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Start");

            //Task t1 = FülleProgressBarAsync();
            //// ...
            //await t1; // Man kann auch "später" warten
            Task t1 = FülleProgressBarAsync();
            Thread.Sleep(1000);
            Task t2 = FülleProgressBarAsync();

            try
            {
                await t1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //StreamReader sr = new StreamReader("demo.txt");

            //string zeile = sr.ReadLineAsync().Result; // Synchon und blockiert
            //string zeile2 = await sr.ReadLineAsync(); // Asynchron, blockiert nicht

            MessageBox.Show("Ende");
        }

        private Task FülleProgressBarAsync()
        {
            return Task.Run(() =>
            {
                for (int i = 0; i <= 100; i++)
                {
                    Dispatcher.Invoke(() => progressBarWert.Value = i);
                    Thread.Sleep(100);
                    if (i == 50)
                        throw new FormatException();
                }
            });
        }
    }
}
