using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace class_diagram_lab
{
    public class Container
    {
        private List<LiteraryWork> books;

        public Container()
        {
            books = new List<LiteraryWork>();
        }

        public int Count
        {
            get
            {
                return books.Count;
            }
            private set { }
        }

        public LiteraryWork this[int key]
        {
            get
            {
                return books[key];
            }
            set
            {
                books[key] = value;
            }
        }

        public void add(LiteraryWork item)
        {
            books.Add(item);
        }


        public void add(params LiteraryWork[] items)
        {
            books.AddRange(items);
        }


        public void remove(int itemIndex)
        {
            if (itemIndex >= books.Count) return;
            books.RemoveAt(itemIndex);
        }

        public void sortByName()
        {
            books.Sort((x, y) => x.Name.CompareTo(y.Name));
        }

        public override string ToString()
        {
            return "Books :: \n\t"+books.Collapse(new StringBuilder(), (i, value, builder) => builder.Append(value).Append("\n\t")).ToString();
        }
    }
}