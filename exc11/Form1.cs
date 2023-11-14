namespace exc11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void forrmatarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void letraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("Arial", 12, FontStyle.Bold); // Substitua "Arial" pelo tipo de letra desejado
            label1.ForeColor = Color.Blue; // Substitua Color.Blue pela cor desejada
        }
    }

}