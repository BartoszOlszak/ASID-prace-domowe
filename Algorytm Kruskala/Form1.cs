namespace Algorytm_Kruskala
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            NodeG1 node1 = new NodeG1(1);
            NodeG1 node2 = new NodeG1(2);
            NodeG1 node3 = new NodeG1(3);
            NodeG1 node4 = new NodeG1(4);
            NodeG1 node5 = new NodeG1(5);
            NodeG1 node6 = new NodeG1(6);
            NodeG1 node7 = new NodeG1(7);

            Edge edge1 = new Edge(node1, node2, 5);
            Edge edge2 = new Edge(node1, node3, 8);
            Edge edge3 = new Edge(node2, node3, 4);
            Edge edge4 = new Edge(node2, node4, 3);
            Edge edge5 = new Edge(node3, node4, 6);
            Edge edge6 = new Edge(node2, node5, 5);
            Edge edge7 = new Edge(node4, node6, 9);
            Edge edge8 = new Edge(node5, node6, 2);
            Edge edge9 = new Edge(node6, node7, 3);

            Graf1 graf = new Graf1();
            graf.Add(edge1);
            graf.Add(edge2);
            graf.Add(edge3);
            graf.Add(edge4);
            graf.Add(edge5);
            graf.Add(edge6);
            graf.Add(edge7);
            graf.Add(edge8);
            graf.Add(edge9);
            Graf1 wynik = graf.algKruskala();

            listBox1.Items.Clear();
            foreach (var edge in wynik.edges)
            {
                listBox1.Items.Add($"KrawêdŸ: {edge.start.data} - {edge.end.data}, Waga: {edge.weight}");
            }
        }
    }
}
