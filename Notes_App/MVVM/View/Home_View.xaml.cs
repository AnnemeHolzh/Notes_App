using Notes_App.MVVM.Model;
using Notes_App.MVVM.ViewModel;
using System;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace Notes_App.MVVM.View
{
    /// <summary>
    /// Interaction logic for Home_View.xaml
    /// </summary>
    public partial class Home_View : UserControl
    {
        public Home_View()
        {
            InitializeComponent();
        }

        public void reset()
        {
            var HomeVM = new Home_ViewModel();
            HomeVM.ResetHomeView();
            DataContext = HomeVM;
        }
    }
}
