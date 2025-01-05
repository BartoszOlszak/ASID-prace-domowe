using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Algorytm_Dijkstry
{
    internal class Graf1
    {
        public List<NodeG1> nodes = new List<NodeG1>();
        public List<Element> elements = new List<Element>();

        public Graf1()
        {
        }

        public void Add(Element k)
        {
            this.elements.Add(k);
            if (!this.nodes.Contains(k.wezel))
            {
                this.nodes.Add(k.wezel);
            }
            if (!this.nodes.Contains(k.poprzednik))
            {
                this.nodes.Add(k.poprzednik);
            }
        }

        public Dictionary<NodeG1, int> PrzygotujTabelke(NodeG1 node)
        {
            Dictionary<NodeG1, int> slownik = new Dictionary<NodeG1, int>();
            foreach (NodeG1 wezel in this.nodes)
            {
                slownik.Add(wezel, int.MaxValue);
            }
            slownik[node] = 0;
            return slownik;
        }

        public Dictionary<NodeG1, int> ADijkstry(NodeG1 start) {
            var tabelka = this.PrzygotujTabelke(start);
            var odwiedzone = new List<NodeG1>();
            var wszystkie = new List<NodeG1>(this.nodes);

            while (wszystkie.Count > 0)
            {
                NodeG1 u = wszystkie.OrderBy(e => tabelka[e]).First();
                odwiedzone.Add(u);
                wszystkie.Remove(u);

                foreach (var element in elements)
                {
                    if (element.poprzednik == u && !odwiedzone.Contains(element.wezel))
                    {
                        int nowyDystans = tabelka[u] + element.dystans;
                        if (nowyDystans < tabelka[element.wezel])
                        {
                            tabelka[element.wezel] = nowyDystans;
                        }
                    }
                }
            }

            return tabelka;
        }    
    }
}
