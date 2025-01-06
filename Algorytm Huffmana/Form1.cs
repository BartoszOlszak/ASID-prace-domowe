namespace Algorytm_Huffmana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Dictionary<char, int> slownik = new Dictionary<char, int>();
        List<NodeG> lista = new List<NodeG>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GenerujKody(NodeG wezel, string kod, Dictionary<char, string> kody)
        {
            if (wezel is NodeGS nodeGS)
            {
                kody[nodeGS.symbol] = kod;
            }
            else
            {
                if (wezel.lewe != null)
                {
                    GenerujKody(wezel.lewe, kod + "1", kody);
                }

                if (wezel.prawe != null)
                {
                    GenerujKody(wezel.prawe, kod + "0", kody);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            slownik.Clear();
            lista.Clear();
            textBox2.Clear();

            String tekst = textBox1.Text;

            for (int i = 0; i < tekst.Length; i++)
            {
                if (slownik.ContainsKey(tekst[i]))
                {
                    slownik[tekst[i]]++;
                }
                else
                {
                    slownik.Add(tekst[i], 1);
                }
            }

            textBox2.Clear();
            foreach (var i in slownik)
            {
                lista.Add(new NodeGS(i.Value, i.Key));
            }

            while (lista.Count > 1)
            {
                lista = lista.OrderBy(n => n.data).ToList();

                NodeG lewe = lista[0];
                NodeG prawe = lista[1];

                lista.RemoveAt(0);
                lista.RemoveAt(0);

                NodeG rodzic = new NodeG(lewe.data + prawe.data)
                {
                    lewe = lewe,
                    prawe = prawe
                };
                lista.Add(rodzic);
            }

            NodeG korzen = lista[0];

            Dictionary<char, string> kody = new Dictionary<char, string>();
            GenerujKody(korzen, "", kody);

            foreach (var item in kody)
            {
                string symbol = item.Key == ' ' ? "|_|" : item.Key.ToString();
                textBox2.AppendText($" {symbol}: {item.Value}\n");
            }
        }
    }
}
