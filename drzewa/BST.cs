using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drzewa
{
    internal class BST
    {
        public NodeT root;

        public void Add(int liczba)
        {
            var dziecko = new NodeT(liczba);
            if (this.root == null)
            {
                this.root = dziecko;
                return;
            }
            else
            {
                var rodzic = this.findParent(dziecko);
                dziecko.rodzic = rodzic;
                rodzic.connect(dziecko);
            }
        }

        public NodeT findParent(NodeT dziecko)
        {
            var temp = this.root;
            while (true)
            {
                if (temp.data > dziecko.data)
                {
                    if (temp.lewe == null)
                    {
                        return temp;
                    }
                    else
                    {
                        temp = temp.lewe;
                    }
                }
                else
                {
                    if (temp.prawe == null)
                    {
                        return temp;
                    }
                    else
                    {
                        temp = temp.prawe;
                    }
                }
            }
        }

        public void RemoveElement0(NodeT n)
        {
            if (n == null)
            {
                return;
            }
            else
            {
                if (this.root == n)
                {
                    this.root = null;
                }
                else
                {
                    if (n.rodzic.lewe == n)
                    {
                        n.rodzic.lewe = null;
                    }
                    else if (n.rodzic.prawe == n)
                    {
                        n.rodzic.prawe = null;
                    }
                    n.rodzic = null;
                }
            }
        }

        public NodeT RemoveElement1(NodeT n)
        {
            NodeT dziecko = null;
            if (n.lewe != null)
            {
                dziecko = n.lewe;
            }
            else if (n.prawe != null)
            {
                dziecko = n.prawe;
            }
            this.RemoveElement0(dziecko);
            return dziecko;
        }

        public NodeT Min(NodeT n)
        {
            var temp = n;
            while (temp.lewe != null)
            {
                temp = temp.lewe;
            }
            return temp;
        }

        public void RemoveElement(NodeT n)
        {
            switch (n.LiczbaDzieci())
            {
                case 0:
                    RemoveElement0(n);
                    break;
                case 1:
                    if (n == root)
                    {
                        RemoveElement0(n);
                        break;
                    }
                    else
                    {
                        var dziecko = this.RemoveElement1(n);
                        var rodzic = n.rodzic;
                        this.RemoveElement0(n);
                        if (rodzic == n)
                        {
                            rodzic.PolaczPrawe(dziecko);
                        }
                        else
                        {
                            rodzic.PolaczLewe(dziecko);
                        }
                        break;
                    }
                case 2:
                    var temp = this.Min(n.prawe);
                    this.RemoveElement(temp);
                    temp.rodzic = n.rodzic;
                    n.rodzic = null;
                    temp.lewe = n.lewe;
                    n.lewe = null;
                    temp.prawe = n.prawe;
                    n.prawe = null;
                    break;
            }
        }

        public NodeT FindNode(NodeT current, int value)
        {
            if (current == null)
                return null;

            if (current.data == value)
                return current;

            if (value < current.data)
                return FindNode(current.lewe, value);
            else
                return FindNode(current.prawe, value);
        }


        public List<int> InOrder(NodeT wezel)
        {
            var result = new List<int>();
            if (wezel == null) return result;

            result.AddRange(InOrder(wezel.lewe));
            result.Add(wezel.data);
            result.AddRange(InOrder(wezel.prawe));

            return result;
        }
        public List<int> PreOrder(NodeT wezel)
        {
            var result = new List<int>();
            if (wezel == null) return result;

            result.Add(wezel.data);
            result.AddRange(PreOrder(wezel.lewe));
            result.AddRange(PreOrder(wezel.prawe));

            return result;
        }

        public List<int> PostOrder(NodeT wezel)
        {
            var result = new List<int>();
            if (wezel == null) return result;

            result.AddRange(PostOrder(wezel.lewe));
            result.AddRange(PostOrder(wezel.prawe));
            result.Add(wezel.data);

            return result;
        }
    }
}
