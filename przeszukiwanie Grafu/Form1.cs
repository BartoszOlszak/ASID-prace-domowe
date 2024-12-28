namespace przeszukiwanie_Grafu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NodeG A = new NodeG(1);
        NodeG B = new NodeG(2);
        NodeG C = new NodeG(3);
        NodeG D = new NodeG(4);
        NodeG E = new NodeG(5);
        NodeG F = new NodeG(6);
        NodeG G = new NodeG(7);

        private void Form1_Load(object sender, EventArgs e)
        {
            A.dodajSasiada(B);
            A.dodajSasiada(C);
            B.dodajSasiada(D);
            B.dodajSasiada(E);
            C.dodajSasiada(D);
            C.dodajSasiada(F);
            D.dodajSasiada(F);
            E.dodajSasiada(F);
            F.dodajSasiada(G);

            Graf graf = new Graf();
            graf.concat(A);
            graf.concat(B);
            graf.concat(C);
            graf.concat(D);
            graf.concat(E);
            graf.concat(F);
            graf.concat(G);

            var lista = graf.Wszerz(A);
            String wynik = "";
            for (int i = 0; i < lista.Count; i++)
            {
                wynik += lista[i].data.ToString() + " ";
            }
            MessageBox.Show("Przeszukanie wszerz: " + wynik);

            var listaPusta = new List<NodeG>();
            var lista1 = graf.Wglab(A, listaPusta);
            String wynik1 = "";
            for (int i = 0; i < lista1.Count; i++)
            {
                wynik1 += lista1[i].data.ToString() + " ";
            }
            MessageBox.Show("Przeszukanie wg³¹b: " + wynik1);
        }
    }
}
