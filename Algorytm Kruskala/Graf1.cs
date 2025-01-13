using Algorytm_Kruskala;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytm_Kruskala
{
    internal class Graf1
    {
        public List<NodeG1> nodes = new List<NodeG1>();
        public List<Edge> edges = new List<Edge>();

        public Graf1()
        {
        }

        public Graf1(Edge k)
        {
            this.Add(k);
        }

        public void Add(Edge k)
        {
            this.edges.Add(k);
            if (!this.nodes.Contains(k.start))
            {
                this.nodes.Add(k.start);
            }
            if (!this.nodes.Contains(k.end))
            {
                this.nodes.Add(k.end);
            }
        }

        public int ileNowychWezlow(Edge k)
        {
            int wynik = 0;
            if (!this.nodes.Contains(k.start))
            {
                wynik++;
            }
            if (!this.nodes.Contains(k.end))
            {
                wynik++;
            }
            return wynik;
        }


        void Join(Graf1 graf)
        {
            for (int i = 0; i < graf.edges.Count; i++)
            {
                this.Add(graf.edges[i]);
            }
        }


        public Graf1 algKruskala()
        {
            List<Graf1> temp = new List<Graf1>();
            temp.Add(new Graf1());

            var krawedzie = edges.OrderBy(k => k.weight).ToList();

            foreach (var krawedz in krawedzie)
            {
                if (temp[0].ileNowychWezlow(krawedz) == 2)
                {
                    Graf1 nowyGraf = new Graf1();
                    nowyGraf.Add(krawedz);
                    temp.Add(nowyGraf);
                    temp[0].Join(nowyGraf);
                }
                else if (temp[0].ileNowychWezlow(krawedz) == 1)
                {
                    foreach (var graf in temp.ToList())
                    {
                        if (graf.nodes.Contains(krawedz.start) || graf.nodes.Contains(krawedz.end))
                        {
                            graf.Add(krawedz);
                            break;
                        }
                    }
                }
                else if (temp[0].ileNowychWezlow(krawedz) == 0)
                {
                    continue;
                }
            }   
            return temp[0];
        }
    }
}