using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorytm_Huffmana
{
    internal class NodeG
    {
        public NodeG rodzic;
        public NodeG lewe;
        public NodeG prawe;
        public int data;

        public NodeG(int data)
        {
            this.data = data;
        }
    }
}
