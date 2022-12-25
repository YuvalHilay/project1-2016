using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using Unit4.CollectionsLib;

namespace node3
{
    class node3
    {
        public static bool IsNodeInNode(Node<int> Ca, Node<int> Cb)
        {
            Node<int> p = Ca;
            Node<int> s = Cb;
            while (s != null&& p!=null)
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
    }
}
