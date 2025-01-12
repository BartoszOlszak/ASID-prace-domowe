namespace NodeList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List lista = new List();
        public String wynik;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String tekst = textBox2.Text;
                int liczba = Convert.ToInt32(tekst);
                lista.AddFirst(liczba);
                wynik = lista.ListToString();
                textBox1.Text = wynik;
            }
            catch (Exception)
            {
                MessageBox.Show("Wprowadz liczbe");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String tekst = textBox2.Text;
                int liczba = Convert.ToInt32(tekst);
                lista.AddLast(liczba);
                wynik = lista.ListToString();
                textBox1.Text = wynik;
            }
            catch (Exception)
            {
                MessageBox.Show("Wprowadz liczbe");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lista.RemoveFirst();
            wynik = lista.ListToString();
            textBox1.Text = wynik;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lista.RemoveLast();
            wynik = lista.ListToString();
            textBox1.Text = wynik;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                String tekst = textBox2.Text;
                int index = Convert.ToInt32(tekst);
                int liczba = lista.Get(index);
                wynik = liczba.ToString();
                textBox3.Text = wynik;
            }
            catch (Exception)
            {
                MessageBox.Show("Wprowadz poprawny index");
            }
        }
    }
}
