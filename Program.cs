using System;
using System.Linq;
using System.Text;
using Unit4.CollectionsLib;

namespace none8
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static Node<int> twoNodesMizoog (Node<int> n1, Node<int> n2)
        {
            Node<int> s = new Node<int>;
            Node<int> temp1 = n1;
            Node<int> temp2 = n2;
            while (temp1 != null && temp2 != null)
            {
                if (temp1.GetInfo() < temp2.GetInfo())
                {
                    s.SetInfo(temp1.GetInfo());
                    temp1 = temp1.GetNext();
                    s = s.GetNext();
                }
                else
                {
                    s.SetInfo(temp2.GetInfo());
                    temp2 = temp2.GetNext();
                    s = s.GetNext();
                }
            }

        }
    }
}
