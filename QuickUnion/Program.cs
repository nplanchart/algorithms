

//https://www.coursera.org/learn/algorithms-part1/

using System;

namespace QuickUnion
{
    class Program
    {
        static void Main(string[] args)
        {
            QuickUnionUF qf = new QuickUnionUF(20);
            qf.Union(1,2);
            qf.Union(3,2);
            Console.WriteLine(qf.Conected(2,3).ToString());
            Console.WriteLine(qf.Conected(1,2).ToString());
            Console.WriteLine(qf.Conected(1,10).ToString());
        }
    }

    public class QuickUnionUF
    {

        private int [] id;
     
        public QuickUnionUF (int n)
        {
            id = new int[n];
            for (int i=0;i<n;i++)
            {
                id[i] = i;
            }
        }
        private int root(int i)
        {
            while(i != id[i])
            {
               i = id[i] ;
            }
            return i;
        }
        public Boolean Conected (int p, int q)
        {
            return root(p) == root(q);
        }

        public void Union (int p, int q)
        {
            int i = root(p);
            int j = root(q);
            
            id[i] = j;
        }

    }
    
}
