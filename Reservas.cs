using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Prueba_Intuito
{
    public partial class Reservas : Form
    {
        private Conexion mConexion;
        private DataTable dt;

        public Reservas()
        {
            InitializeComponent();
            mConexion = new Conexion();
        }

        private void Reservas_Load(object sender, EventArgs e)
        {
            showReservas();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Cancelar_reserva(int id_reserva)
        {
            MySqlConnection connection = mConexion.getConnection();
            MySqlCommand command = connection.CreateCommand();

            try
            {

                //Obtengo la butaca asociada a la reserva
                command.CommandText = "SELECT id_asiento FROM entidad_reserva WHERE id_reserva = @id_reserva";
                command.Parameters.AddWithValue("@id_reserva", id_reserva);
                int id_asiento = Convert.ToInt32(command.ExecuteScalar());

                //Inhabilito la butaca
                command.CommandText = "UPDATE entidad_asiento SET Estado = 0 WHERE id_asiento = @id_asiento";
                command.Parameters.AddWithValue("@id_asiento", id_asiento);
                command.ExecuteNonQuery();

                //Cancelo la reserva
                command.CommandText = "DELETE FROM entidad_reserva WHERE id_reserva = @id_reserva";
                command.ExecuteNonQuery();

                showReservas();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                command.Dispose();
                connection.Close();
                connection.Dispose();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (dgv_reservas.SelectedRows != null)
            {
                int id_reserva = Convert.ToInt32(dgv_reservas.SelectedRows[0].Cells["id_reserva"].Value);
                Cancelar_reserva(id_reserva);
                MessageBox.Show("Reserva cancelada con exito");
            }
            else
            {
                MessageBox.Show("Asegurate de escoger antes una reserva");
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //showReservas();
        }

        private void showReservas()
        {
            dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `prueba_intuito`.`entidad_reserva`", mConexion.getConnection());
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    dt.Columns.Add(reader.GetName(i), reader.GetFieldType(i));
                }

                DataRow row = dt.NewRow();

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    row[i] = reader[i];
                }

                dt.Rows.Add(row);
            }

            reader.Close();

            dgv_reservas.DataSource = dt;
        }
    }
}
