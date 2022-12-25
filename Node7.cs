using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4.CollectionsLib;

namespace node7
{
    class Node7
    {
        public static void DoS(Node<char> c)
        {
            Node<char> p = c;
            Node<char> p1;
            while (p != null)
            {
                p1 = p.GetNext();
                if (p1.GetInfo() == p.GetInfo() && p1 != null)
                {
                    p.SetNext(p1.GetNext());
                    p1.SetNext(null);
                }
                else p = p1;
            }
        }
    }
}
