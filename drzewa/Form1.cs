namespace drzewa
{
    public partial class Form1 : Form
    {
        private BST tree = new BST();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void WyswietlDrzewo()
        {
            treeView1.Nodes.Clear();

            if (tree.root != null)
            {
                TreeNode rootNode = PrzeksztalcNaTreeNode(tree.root);
                treeView1.Nodes.Add(rootNode);
                treeView1.ExpandAll();
            }
        }

        private TreeNode PrzeksztalcNaTreeNode(NodeT current)
        {
            if (current == null)
                return null;

            TreeNode node = new TreeNode(current.data.ToString());

            if (current.lewe != null)
                node.Nodes.Add(PrzeksztalcNaTreeNode(current.lewe));

            if (current.prawe != null)
                node.Nodes.Add(PrzeksztalcNaTreeNode(current.prawe));

            return node;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                tree.Add(int.Parse(textBox1.Text));
            }
            catch
            {
                MessageBox.Show("b³¹d");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int liczba))
            {
                var node = tree.FindNode(tree.root, liczba);
                if (node != null)
                {
                    tree.RemoveElement(node);
                    WyswietlDrzewo();
                }
                else
                {
                    MessageBox.Show("b³¹d");
                }
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("b³¹d");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WyswietlDrzewo();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tree.root != null)
            {
                var PreOrder = tree.PreOrder(tree.root);
                textBox2.Text = string.Join(", ", PreOrder);
            }
            else
            {
                textBox2.Text = "Drzewo jest puste.";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tree.root != null)
            {
                var InOrder = tree.InOrder(tree.root);
                textBox2.Text = string.Join(", ", InOrder);
            }
            else
            {
                textBox2.Text = "Drzewo jest puste.";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (tree.root != null)
            {
                var PostOrder = tree.PostOrder(tree.root);
                textBox2.Text = string.Join(", ", PostOrder);
            }
            else
            {
                textBox2.Text = "Drzewo jest puste.";
            }
        }
    }
}
