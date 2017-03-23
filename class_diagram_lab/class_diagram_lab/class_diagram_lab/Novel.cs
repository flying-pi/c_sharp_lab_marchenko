using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace class_diagram_lab
{
    public class Novel : LiteraryWork
    {

        public Novel():this("","","")
        {

        }

        public Novel(string content, string name, string author) : this(content, name, author, EGenre.eUnknown)
        {

        }


        public Novel(string content, string name, string author, EGenre ganre) : base(content, name, author)
        {
            this.ganre = ganre;
        }

        private EGenre ganre = EGenre.eUnknown;
        public EGenre Ganre
        {
            get
            {
                return ganre;
            }
            set
            {
                ganre = value;
            }
        }

        private string illustrator = "";

        public string Illustrator
        {
            get
            {
                return illustrator;
            }
            set
            {
                Illustrator = value;
            }
        }
        override public string ToString()
        {
            return base.ToString() + $"\tganre = {ganre}";
        }
    }
}