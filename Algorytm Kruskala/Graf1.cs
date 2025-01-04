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


        void Join(Graf1 g1)
        {
            for (int i = 0; i < g1.edges.Count; i++)
            {
                this.Add(g1.edges[i]);
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
                    // Dodajemy nowy graf z krawędzią, ponieważ są to zupełnie nowe wierzchołki
                    var nowyGraf = new Graf1();
                    nowyGraf.Add(krawedz);
                    temp.Add(nowyGraf);
                    temp[0].Join(nowyGraf);
                }
                else if (temp[0].ileNowychWezlow(krawedz) == 1)
                {
                    foreach (var graf in temp.ToList())
                    {
                        // Sprawdzamy, czy jeden z wierzchołków krawędzi należy do istniejącego grafu
                        if (graf.nodes.Contains(krawedz.start) || graf.nodes.Contains(krawedz.end))
                        {
                            graf.Add(krawedz);

                            foreach (var Graf2 in temp.ToList())
                            {
                                // Łączymy grafy, jeżeli to konieczne
                                if (Graf2 != graf && (Graf2.nodes.Contains(krawedz.start) || Graf2.nodes.Contains(krawedz.end)))
                                {
                                    graf.Join(Graf2);
                                    temp.Remove(Graf2);
                                }
                            }
                            break;
                        }
                    }
                }
                else if (temp[0].ileNowychWezlow(krawedz) == 0)
                {
                    // Sprawdzamy, w którym grafie znajduje się start i end krawędzi
                    Graf1 grafStart = null;
                    Graf1 grafEnd = null;

                    foreach (var graf in temp)
                    {
                        if (graf.nodes.Contains(krawedz.start))
                        {
                            grafStart = graf;
                        }
                        if (graf.nodes.Contains(krawedz.end))
                        {
                            grafEnd = graf;
                        }
                    }

                    // Jeśli krawędź nie tworzy cyklu, łączymy grafy
                    if (grafStart != grafEnd)
                    {
                        grafStart.Join(grafEnd);  // Łączymy grafy
                        temp.Remove(grafEnd);     // Usuwamy połączony graf
                        grafStart.Add(krawedz);   // Dodajemy krawędź do wynikowego grafu
                    }
                    else
                    {
                        continue;  // Jeżeli grafy są już połączone, pomijamy dodanie krawędzi
                    }
                }
            }

            return temp[0];  // Zwracamy wynikowy graf
        }
    }
}
