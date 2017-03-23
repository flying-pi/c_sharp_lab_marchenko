using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_diagram_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            LiteraryWork simpleWork = new LiteraryWork("some long textsome long textsome long textsome long textsome long textsome long text", "tort2", "krot");

            Novel novel = new Novel("some time ago***", "tort1", "krot");
            novel.Ganre = EGenre.ePsychological;

            Multilogy multylogy = new Multilogy("protr");
            multylogy.addNovel(multylogy);
            multylogy.addNovel(new Multilogy("some time ago***", "tort2", "krot"));

            Drama drama = new Drama("ttrtt","faslsad","ssd");

            Console.WriteLine(drama);

            Console.WriteLine(multylogy);

            Console.WriteLine(simpleWork);
            Console.WriteLine(novel);

            Console.WriteLine("________________________");
            Container container = new Container();
            container.add(simpleWork);
            container.add(novel);
            container.add(multylogy);
            container.add(drama);
            Console.WriteLine(container);
            container.sortByName();
            Console.WriteLine(container);
            Console.ReadKey();
        }
    }
}
