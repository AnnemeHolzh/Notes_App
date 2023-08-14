using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes_App.MVVM.Model
{
    internal class QuotesClass
    {
        public string Quote { get; set; } = string.Empty;

        public string Author { get; set; } = string.Empty;

        public QuotesClass(string QC, string QA) 
        { 
            this.Quote = QC;
            this.Author = QA;
        }

        public QuotesClass()
        {
        }

        private string AlignmentString()
        {
            int spacerLength = Math.Max(0, Quote.Length - Author.Length);
            return new string(' ', spacerLength);
        }

        /// <summary>
        /// prints the quote and author in a formated way
        /// </summary>
        /// <returns></returns>
        public string PrintQuote()
        {
            return this.Quote + "\r\n" + this.AlignmentString() + "-" + this.Author;
        }

    }
}
//____________________________________EOF_________________________________________________________________________