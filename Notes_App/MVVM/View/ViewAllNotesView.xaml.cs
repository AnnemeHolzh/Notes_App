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
                buttonContainer2.Children.Clear();
                buttonContainer3.Children.Clear();
            }

            var i = 0;

            foreach (var note in notes)
            {
                if (i < notes.Count)
                {
                    i++;
                    if (i == 1)
                    {
                        Button button1 = new Button();
                        button1.Content = $"{note.GetTitle()}";
                        button1.Click += Button_Click;
                        button1.Style = (Style)FindResource("AppButtonStyle");
                        buttonContainer1.Children.Add(button1);
                    }
                    else if (i == 2)
                    {
                        Button button2 = new Button();
                        button2.Content = $"{note.GetTitle()}";
                        button2.Click += Button_Click;
                        button2.Style = (Style)FindResource("AppButtonStyle");
                        buttonContainer2.Children.Add(button2);
                    }
                    else if (i == 3)
                    {
                        Button button3 = new Button();
                        button3.Content = $"{note.GetTitle()}";
                        button3.Click += Button_Click;
                        button3.Style = (Style)FindResource("AppButtonStyle");
                        buttonContainer3.Children.Add(button3);
                        i = 0;
                    }
                }

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