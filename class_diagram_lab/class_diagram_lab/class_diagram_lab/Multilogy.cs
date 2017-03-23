using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace class_diagram_lab
{
    public class Multilogy : Novel
    {
        public Multilogy(): this("","","")
        {

        }

        public Multilogy(string name) : this("", name, "")
        {

        }

        public Multilogy(string content, string name, string author) : this(content, name, author, EGenre.eUnknown)
        {
        }

        public Multilogy(string content, string name, string author, EGenre ganre) : base(content, name, author)
        {
            novels = new List<Novel>();
        }

        List<Novel> novels;

        public int Count
        {
            get
            {
                return novels.Count;
            }
            private set { }
        }

        public Novel this[int key]
        {
            get
            {
                return novels[key];
            }
            set
            {
                novels[key] = value;
            }
        }

        public Novel this[string novelName]
        {
            get
            {
                foreach (Novel n in novels)
                {
                    if (n.Name == novelName)
                        return n;
                }
                return null;
            }
            private set
            {
            }
        }

        public void addNovel(Novel novel)
        {
            novels.Add(novel);
        }


        public void addNovel(params Novel[] list)
        {
            novels.AddRange(list);
        }

        override public string ToString()
        {
            return $"Multilogy by name  {Name}, contains {novels.Count} novels";
        }


    }
}