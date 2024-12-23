namespace Wszystkie_sortowania
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] tab = { };

        public void BubbleSort(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 1; j < tab.Length; j++)
                {
                    if (tab[j] < tab[j - 1])
                    {
                        int temp = tab[j];
                        tab[j] = tab[j - 1];
                        tab[j - 1] = temp;
                    }
                }
            }
        }

        public void InsertionSort(int[] tab)
        {
            for (int i = 1; i < tab.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (tab[j] < tab[j - 1])
                    {
                        int temp = tab[j];
                        tab[j] = tab[j - 1];
                        tab[j - 1] = temp;
                    }
                }
            }
        }

        public void MergeSort(int[] tab, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSort(tab, left, middle);
                MergeSort(tab, middle + 1, right);
                Scal(tab, left, middle, right);
            }
        }

        public void Scal(int[] tab, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            int[] tabL = new int[n1];
            int[] tabR = new int[n2];

            for (int i = 0; i < n1; i++)
            {
                tabL[i] = tab[left + i];
            }
            for (int i = 0; i < n2; i++)
            {
                tabR[i] = tab[middle + 1 + i];
            }

            int ileft = 0; int iright = 0; int k = left;
            while (ileft < n1 && iright < n2)
            {
                if (tabL[ileft] <= tabR[iright])
                {
                    tab[k] = tabL[ileft];
                    ileft++;
                }
                else
                {
                    tab[k] = tabR[iright];
                    iright++;
                }
                k++;
            }
            while (ileft < n1)
            {
                tab[k] = tabL[ileft];
                ileft++;
                k++;
            }
            while (iright < n2)
            {
                tab[k] = tabR[iright];
                iright++;
                k++;
            }
        }

        public void QuickSort(int[] tab, int start, int end)
        {
            if (end <= start)
            {
                return;
            }
            int pivot = pom(tab, start, end);
            QuickSort(tab, start, pivot - 1);
            QuickSort(tab, pivot + 1, end);
        }

        public int pom(int[] tab, int start, int end)
        {
            int pivot = tab[end];
            int i = start - 1;
            for (int j = start; j <= end - 1; j++)
            {
                if (pivot > tab[j])
                {
                    i++;
                    int temp = tab[i];
                    tab[i] = tab[j];
                    tab[j] = temp;
                }
            }
            i++;
            int temp2 = tab[i];
            tab[i] = tab[end];
            tab[end] = temp2;
            return i;
        }

        public void CountingSort(int[] tab)
        {
            int max = tab[0];
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] > max)
                {
                    max = tab[i];
                }
            }

            int[] temp = new int[max + 1];
            for (int i = 0; i < tab.Length; i++)
            {
                temp[tab[i]]++;
            }

            int index = 0;
            for (int i = 0; i <= max; i++)
            {
                while (temp[i] > 0)
                {
                    tab[index] = i;
                    index++;
                    temp[i]--;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BubbleSort(tab);
            string wynik = string.Join(',', tab);
            textBox2.Text = wynik;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InsertionSort(tab);
            string wynik = string.Join(',', tab);
            textBox2.Text = wynik;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MergeSort(tab, 0, tab.Length - 1);
            string wynik = string.Join(',', tab);
            textBox2.Text = wynik;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            QuickSort(tab, 0, tab.Length - 1);
            string wynik = string.Join(',', tab);
            textBox2.Text = wynik;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CountingSort(tab);
            string wynik = string.Join(',', tab);
            textBox2.Text = wynik;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int temp = (int)numericUpDown1.Value;
            tab = new int[temp];
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = random.Next(0, 101);
            }
            string wynik = string.Join(',', tab);
            textBox1.Text = wynik;
        }
    }
}
