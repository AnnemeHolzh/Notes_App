using Notes_App.MVVM.Model;
using Notes_App.MVVM.ViewModel;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Notes_App.MVVM.View
{
    /// <summary>
    /// Interaction logic for ViewAllNotesView.xaml
    /// </summary>
    public partial class ViewAllNotesView : UserControl
    {
        /// <summary>
        /// constructor
        /// </summary>
        public ViewAllNotesView()
        {
            InitializeComponent();
        }
        //___________________________________________________________________________________________________________

        /// <summary>
        /// Event handler for when a note is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Button ClickedButton = (Button)sender;

            String NoteTitle = ClickedButton.Content.ToString();

            ViewAllNotesViewModel viewModel = (ViewAllNotesViewModel)DataContext;
            NotesClass SelectedNote = viewModel.Notes.FirstOrDefault(note => note.GetTitle() == NoteTitle);

            if (SelectedNote != null)
            {
                MessageBox.Show($"You clicked {NoteTitle}");// make click open view with selected note
            }
            //___________________________________________________________________________________________________________
        }
    }
}
//____________________________________EOF_________________________________________________________________________