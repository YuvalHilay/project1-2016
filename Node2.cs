using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4.CollectionsLib;

namespace node2
{
    class Node2
    {
        public static bool IsNodeInNode2(Node<int> Ca, Node<int> Cb)
        {
            Node<int> p = Ca;
            Node<int> s = Cb;
            while (s != null)
            {
                while (p != null && !s.GetInfo().Equals(p.GetInfo()))
                {
                    p = p.GetNext();
                }
                if (p == null)
                {
                    return false;
                }
                p = Ca;
                s = s.GetNext();
            }
            return true;
        }
        public static bool IsNodeInNode(Node<int> Ca, Node<int> Cb)
        {
            Node<int> p = Ca;
            Node<int> s = Cb;
            while (s != null && p != null)
            {
                if (s.GetInfo().Equals(p.GetInfo()))
                {
                    p = p.GetNext();
                    s = s.GetNext();
                }
                else
                {
                    p = p.GetNext();
                }
            }
            if (p == null && s != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static void duplicateNode(Node<int> c)
        {
            int num = 0;
            Node<int> p = c;
            while (p != null)
            {
                num++;
                p = p.GetNext();
            }
            Node<int> b = c;
            while (b.GetNext() != null)
            {
                b = b.GetNext();
            }
            Node<int> a = c;
            for (int i = 1; i <= num; i++)
            {
              
               
               
                Node<int> last = new Node<int>(a.GetInfo());
                b.SetNext(last);
                a = a.GetNext();
                b = b.GetNext();
            }
        }
    }
}
