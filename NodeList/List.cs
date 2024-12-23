using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NodeList
{
    internal class List
    {
        public Node head;
        public Node tail;
        public int count;

        public List()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        public void AddFirst(int liczba)
        {
            Node node = new Node(liczba);
            count++;
            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                node.next = head;
                head.prev = node;
                head = node;
            }
        }

        public void AddLast(int liczba)
        {
            Node node = new Node(liczba);
            count++;
            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.next = node;
                node.prev = tail;
                tail = node;
            }
        }

        public void RemoveFirst()
        {
            if (head == null)
            {
                return;
            }
            if (head == tail)
            {
                head = null;
                tail = null;
                count--;
            }
            else
            {
                head = head.next;
                head.prev = null;
                count--;
            }
        }

        public void RemoveLast()
        {
            if (head == null)
            {
                return;
            }
            if (head == tail)
            {
                head = null;
                tail = null;
                count--;
            }
            else
            {
                tail = tail.prev;
                tail.next = null;
                count--;
            }
        }

        public String ListToString()
        {
            if (head == null)
            {
                return "";
            }
            StringBuilder sb = new StringBuilder();
            Node node = head;

            while (node != null)
            {
                sb.Append(node.data);
                if (node.next != null)
                {
                    sb.Append(", ");
                }
                node = node.next;
            }
            return sb.ToString();
        }

        public int Get(int index)
        {
            if (index < 0 || index >= count)
            {
                MessageBox.Show("index", "Wprowadzono nieprawidłowy indeks.");
            }

            int i = 0;
            Node temp = head;
            while (i < index)
            {
                temp = temp.next;
                i++;
            }

            return temp.data;
        }
    }
}

