using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threads_0
{
    
    class threprog
    {
        public static void Main()
        {
        Program pg = new Program();
            Thread thread0 = new Thread(pg.WorkThreadFunction);
            Thread thread1 = new Thread(pg.WorkThreadFunction);
            thread0.Start("C#-trådning er nemt!");
            thread0.Join();
            thread1.Start("Også med flere tråde...");
            thread1.Join();
            Console.ReadLine();
        }
    }
    class Program
    {
        public void WorkThreadFunction(object threadname)
        {
            string tn = threadname as string;
            for (int i = 0; i < 5; i++)
            {
                if (tn != null)
                {
                Console.WriteLine(tn);
                    Thread.Sleep(1000);
                }
            }
            Console.WriteLine();
        }
    }
}
