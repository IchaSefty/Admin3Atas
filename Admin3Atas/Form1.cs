namespace Admin3Atas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tambah_Buku tambah_Buku = new Tambah_Buku();
            tambah_Buku.Show();
        }
    }
}
