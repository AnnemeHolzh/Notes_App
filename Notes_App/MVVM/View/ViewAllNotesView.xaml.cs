using Notes_App.Core;
using Notes_App.MVVM.Model;
using System.Collections.ObjectModel;
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

        private ObservableCollection<NotesClass> notes;

        Style style = Application.Current.FindResource("Button_ButtonStyle.xaml") as Style; //this ithe line that sets the style for the buttos but it does not work at the moment



        /// <summary>
        /// constructor
        /// </summary>
        public ViewAllNotesView()
        {
            notes = new ObservableCollection<NotesClass>(NotesListClass.ReturnNotes());
            this.ButtonMaker();
            InitializeComponent();
        }
        //___________________________________________________________________________________________________________

        public void ButtonMaker()
        {
            if (buttonContainer1 != null)
            {
                buttonContainer1.Children.Clear();
            }
            

            foreach (var note in notes)
            {
                Button button = new Button();
                button.Content = $"{note.GetTitle()}";
                button.Click += Button_Click;
                //button.Style = style;
                buttonContainer1.Children.Add(button);
            }
        }

        public void RefreshData()
        {
            notes = new ObservableCollection<NotesClass>(NotesListClass.ReturnNotes());
            ButtonMaker();
        }

        /// <summary>
        /// Event handler for when a note is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                string selectedNoteTitle = button.Content.ToString();

                // Find the corresponding note in the collection
                NotesClass selectedNote = notes.FirstOrDefault(note => note.GetTitle() == selectedNoteTitle);

                // Now you can do whatever you want with the selected note, like displaying its content.
                // For demonstration purposes, let's show a message box with the note content.
                if (selectedNote != null)
                {
                    MessageBox.Show(selectedNote.GetContent(), "Note Content");
                }
            }
        }
    }
}
//____________________________________EOF_________________________________________________________________________