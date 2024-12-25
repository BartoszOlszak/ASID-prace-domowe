
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drzewa
{
    internal class NodeT
    {
        public NodeT rodzic;
        public NodeT lewe;
        public NodeT prawe;
        public int data;

        public NodeT(int data)
        {
            this.data = data;
        }
        public void connect(NodeT dziecko)
        {
            dziecko.rodzic = this;
            if (dziecko.data < this.data)
            {
                this.lewe = dziecko;
            }
            else
            {
                this.prawe = dziecko;
            }
        }
        public int LiczbaDzieci()
        {
            int wynik = 0;
            if (this.lewe != null)
            {
                wynik++;
            }
            if (this.prawe != null)
            {
                wynik++;
            }
            return wynik;
        }

        public void PolaczLewe(NodeT dziecko)
        {
            this.lewe = dziecko;
            if (dziecko != null)
            {
                dziecko.rodzic = this;
            }
        }
        public void PolaczPrawe(NodeT dziecko)
        {
            this.prawe = dziecko;
            if (dziecko != null)
            {
                dziecko.rodzic = this;
            }
        }
    }
}
