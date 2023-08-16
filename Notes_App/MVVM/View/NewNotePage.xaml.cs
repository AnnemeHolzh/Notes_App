using Notes_App.MVVM.Model;
using System;
using System.Windows.Controls;

namespace Notes_App.MVVM.View
{
    /// <summary>
    /// Interaction logic for NewNotePage.xaml
    /// </summary>
    public partial class NewNotePage : UserControl
    {
        //___________________________________________________________________________________________________________
        //__________________________________________Constructors_____________________________________________________
        //___________________________________________________________________________________________________________

        /// <summary>
        /// default constructor for initializing components
        /// </summary>
        public NewNotePage()
        {
            InitializeComponent();
        }
        //___________________________________________________________________________________________________________

        //___________________________________________________________________________________________________________
        //_____________________________________________Methods_______________________________________________________
        //___________________________________________________________________________________________________________

        /// <summary>
        /// Method to save notes if the user navigates somewhere else
        /// </summary>
        public void AutoSave()
        {
            var title = TitleTB.Text;
            var content = ContentTB.Text;

            if (title != String.Empty && content != String.Empty)
            {
                var note = new NotesClass
                {
                    NoteTitle = title,
                    NoteContent = content,
                };
                NotesListClass.AddNote(note);
                TitleTB.Text = String.Empty;
                ContentTB.Text = String.Empty;
            }
            else if (content != String.Empty)
            {
                var note = new NotesClass
                {
                    NoteTitle = "Untitled",
                    NoteContent = content,
                };
                NotesListClass.AddNote(note);
                TitleTB.Text = String.Empty;
                ContentTB.Text = String.Empty;
            }
        }
        //___________________________________________________________________________________________________________
    }
}
//____________________________________EOF_________________________________________________________________________