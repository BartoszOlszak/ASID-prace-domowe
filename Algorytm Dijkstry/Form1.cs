using System.Windows.Forms;

namespace Algorytm_Dijkstry
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

            Element element1 = new Element(node2, 4, node1);
            Element element2 = new Element(node3, 2, node1);
            Element element3 = new Element(node1, 4, node2);
            Element element4 = new Element(node3, 1, node2);
            Element element5 = new Element(node4, 5, node2);
            Element element6 = new Element(node5, 10, node2);
            Element element7 = new Element(node1, 2, node3);
            Element element8 = new Element(node2, 1, node3);
            Element element9 = new Element(node4, 3, node3);
            Element element10 = new Element(node6, 7, node3);
            Element element11 = new Element(node7, 6, node3);
            Element element12 = new Element(node5, 2, node4);
            Element element13 = new Element(node6, 4, node4);

            Graf1 graf = new Graf1();
            graf.Add(element1);
            graf.Add(element2);
            graf.Add(element3);
            graf.Add(element4);
            graf.Add(element5);
            graf.Add(element6);
            graf.Add(element7);
            graf.Add(element8);
            graf.Add(element9);
            graf.Add(element10);
            graf.Add(element11);
            graf.Add(element12);
            graf.Add(element13);

            var wynik = graf.ADijkstry(node1);
            foreach (var item in wynik)
            {
               listBox1.Items.Add($"Wêze³ {item.Key.data}: Dystans = {item.Value}");
            }
        }
    }
}
