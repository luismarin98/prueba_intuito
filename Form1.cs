using MySql.Data.MySqlClient;

namespace Prueba_Intuito
{
    public partial class Form1 : Form
    {
        private Conexion mConexion;
        public Form1()
        {
            InitializeComponent();
            mConexion = new Conexion();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VeryConn.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reservas reservas = new Reservas();
            reservas.Show();
            this.Hide();
        }

        private void VeryConn_Tick(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = mConexion.getConnection();
            if (cmd.Connection != null) { lbl_verify.Text = "DB_Connection: ✅"; } else { lbl_verify.Text = "DB_Connection: ❌"; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_carteleras_Click(object sender, EventArgs e)
        {
            Carteleras carteleras = new Carteleras();
            carteleras.Show();
            this.Hide();
        }
    }
}