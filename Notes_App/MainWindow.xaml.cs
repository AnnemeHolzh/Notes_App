using Notes_App.MVVM.Model;
using Notes_App.UI_Code;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
using System.Windows.Threading;

namespace Notes_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private DispatcherTimer timer;

        QuotesListClass quotes;

        public MainWindow()
        {
            InitializeComponent();
            this.displayQuotesTimer();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void displayQuotesTimer()
        {
            quotes = new QuotesListClass();
            Random random = new Random();
            var Index = random.Next(30);
            ThoughtCloudTB.Text = quotes.DisplayQuote(Index);
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(15);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            quotes = new QuotesListClass();
            Random random = new Random();
            var Index = random.Next(30);

            ThoughtCloudTB.Text = quotes.DisplayQuote(Index);
        }
    }
}
