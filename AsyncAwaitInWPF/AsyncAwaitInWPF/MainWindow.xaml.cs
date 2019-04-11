using System;
using System.Collections.Generic;
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
            ProgressBarIstVoll += Callback;
        }

        private void Callback()
        {
            MessageBox.Show("Ende");
        }

        private event Action ProgressBarIstVoll;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Start");

            Task t1 = Task.Run(new Action(FülleProgressBar));
        }

        private void FülleProgressBar()
        {
            for (int i = 0; i <= 100; i++)
            {
                Dispatcher.Invoke(() => progressBarWert.Value = i);
                Thread.Sleep(100);
            }
            ProgressBarIstVoll?.Invoke();
        }
    }
}
