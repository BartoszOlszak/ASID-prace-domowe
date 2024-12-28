using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace przeszukiwanie_Grafu
{
    internal class NodeG
    {
        public List<NodeG> sasiedzi = new List<NodeG>();
        public int data;

        public NodeG(int liczba)
        {
            this.data = liczba;
        }

        public override string ToString()
        {
            return this.data.ToString();
        }

        public void dodajSasiada(NodeG A)
        {
            sasiedzi.Add(A);
        }
    }
}
