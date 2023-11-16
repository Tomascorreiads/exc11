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

        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
        }

        private void vermelhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void aumentarALetraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("Arial", 30, FontStyle.Bold);
        }

        private void diminuirALetraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("Arial", 6, FontStyle.Bold);
        }
    }

}