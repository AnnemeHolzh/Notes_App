using Notes_App.MVVM.Model;
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

namespace Notes_App.MVVM.View
{
    /// <summary>
    /// Interaction logic for NewNotePage.xaml
    /// </summary>
    public partial class NewNotePage : UserControl
    {
        public NewNotePage()
        {
            InitializeComponent();
        }

        public void AutoSave ()
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


    }
}
