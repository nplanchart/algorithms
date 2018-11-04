

//https://www.coursera.org/learn/algorithms-part1/

using System;

namespace QuickFind
{
    class Program
    {
        static void Main(string[] args)
        {
            QuickFindUF qf = new QuickFindUF(5);
            qf.Union(1,2);
            qf.Union(3,2);
            Console.WriteLine(qf.Conected(2,3).ToString());
            Console.WriteLine(qf.Conected(1,2).ToString());
        }
    }

    public class QuickFindUF
    {

        private int [] id;
     
        public QuickFindUF (int n)
        {
            id = new int[n];
            for (int i=0;i<n;i++)
            {
                id[i] = i;
            }
        }
        
        public Boolean Conected (int p, int q)
        {
            return id[p] == id[q];
        }

        public void Union (int p, int q)
        {
            int pid= id[p];
            int piq= id[q];
            
            for (int i=0;i<id.Length;i++)
            {
                if(id[i] == pid)
                {
                    id[i] = piq;
                }        
            }
        }

    }
    
}
