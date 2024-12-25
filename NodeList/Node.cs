using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeList
{
    internal class Node
    {
        public Node next;
        public Node prev;
        public int data;

        public Node(int data)
        {
            this.next = null;
            this.prev = null;
            this.data = data;
        }

        public String NodeToString()
        {
            return data.ToString();
        }

    }
}
