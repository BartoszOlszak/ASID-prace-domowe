using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytm_Huffmana
{
    internal class NodeGS:NodeG
    {
        public char symbol;

        public NodeGS(int data, char symbol) : base(data)
        {
            this.symbol = symbol;
        }
    }
}
