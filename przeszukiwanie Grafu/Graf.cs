using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace przeszukiwanie_Grafu
{
    internal class Graf
    {
        public List<NodeG> nodes = new List<NodeG>();

        public void concat(NodeG node)
        {
            nodes.Add(node);
        }

        public List<NodeG> Wszerz(NodeG start)
        {
            List<NodeG> lista = new List<NodeG>() { start };
            for (int i = 0; i < lista.Count; i++)
            {
                var temp = lista[i];
                for (int j = 0; j < temp.sasiedzi.Count; j++)
                {
                    if (!lista.Contains(temp.sasiedzi[j]))
                    {
                        lista.Add(temp.sasiedzi[j]);
                    }
                }
            }
            return lista;
        }
        public List<NodeG> Wglab(NodeG start, List<NodeG> lista)
        {
            if (!lista.Contains(start))
            {
                lista.Add(start);
                foreach (var sasiad in start.sasiedzi)
                {
                    Wglab(sasiad, lista);
                }
            }
            return lista;
        }
    }
}

