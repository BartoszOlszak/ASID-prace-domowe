﻿using System;
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

        public Node RemoveLast()
        {
            if (this.head == null)
            {
                return null;
            }
            Node wynik = this.tail;
            if (this.head == this.tail)
            {
                this.head = null;
                this.tail = null;
            }
            else
            {
                this.tail = this.tail.prev;
                this.tail.next = null;
                wynik.prev = null;
            }
            this.count--;
            return wynik;
        }

        public override string ToString()
        {
            String wynik = "";
            var temp = this.head;
            while (temp != null)
            {
                wynik += " " + temp.data;

                temp = temp.next;
            }
            return wynik.Trim();
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
                throw new ArgumentOutOfRangeException(nameof(index), "Wprowadzono nieprawidłowy indeks.");
            }
            else
            {
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
}

