using System;

namespace Notes_App.MVVM.Model
{
    /// <summary>
    /// used to make Quote objects that can be displayed in the main view
    /// </summary>
    internal class QuotesClass
    {
        //___________________________________________________________________________________________________________
        //__________________________________________Parameters_______________________________________________________
        //___________________________________________________________________________________________________________

        /// <summary>
        /// stores the Quote
        /// </summary>
        public string Quote { get; set; } = string.Empty;
        //___________________________________________________________________________________________________________

        /// <summary>
        /// stores the quotes Autor
        /// </summary>
        public string Author { get; set; } = string.Empty;
        //___________________________________________________________________________________________________________

        //___________________________________________________________________________________________________________
        //__________________________________________Constructors_____________________________________________________
        //___________________________________________________________________________________________________________

        /// <summary>
        /// Constructor used to create QuoteClass objects
        /// </summary>
        /// <param name="QC"></param>
        /// <param name="QA"></param>
        public QuotesClass(string QC, string QA)
        {
            this.Quote = QC;
            this.Author = QA;
        }
        //___________________________________________________________________________________________________________

        /// <summary>
        /// Default constructor
        /// </summary>
        public QuotesClass()
        {
        }
        //___________________________________________________________________________________________________________

        //___________________________________________________________________________________________________________
        //_____________________________________________Methods_______________________________________________________
        //___________________________________________________________________________________________________________

        /// <summary>
        /// method creates a string of concatenated space char to align the quotes and author strings when printing
        /// </summary>
        /// <returns></returns>
        private string AlignmentString()
        {
            int spacerLength = Math.Max(0, Quote.Length - Author.Length);
            return new string(' ', spacerLength);
        }
        //___________________________________________________________________________________________________________

        /// <summary>
        /// prints the quote and author in a formatted way
        /// </summary>
        /// <returns></returns>
        public string PrintQuote()
        {
            return this.Quote + "\r\n" + this.AlignmentString() + "-" + this.Author;
        }
        //___________________________________________________________________________________________________________
    }
}
//____________________________________EOF_________________________________________________________________________