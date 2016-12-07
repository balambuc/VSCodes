using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazsinak
{
    class Program
    {
        static void Main(string[] args)
        {
            Otos huzas = new Otos( );
            Console.WriteLine(huzas.ToString( ));
            Console.ReadLine( );
        }
    }

    class Otos
    {
        private SortedSet<int> huzas = new SortedSet<int>();
        private Random szam = new Random( );
        private bool sorsolt = false;
        public int[] sorsol()
        {
            while (huzas.Count<5)
                huzas.Add(szam.Next(91));
            sorsolt = true;
            return this.huzas.ToArray();
        }

        public override string ToString()
        {
            if (!sorsolt)
                this.sorsol( );
            string s = "";
            for (int i = 0; i < 4; i++)
                s += huzas.ToArray()[i] + ", ";
            
            return s + huzas.ToArray()[4];
        }
        
    }
}
