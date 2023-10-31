using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_Intuito
{
    public partial class Carteleras : Form
    {
        private Conexion mConexion;
        private DataTable dtCarteleras;
        public Carteleras()
        {
            InitializeComponent();
            mConexion = new Conexion();
        }

        private void Carteleras_Load(object sender, EventArgs e)
        {
            showCartelera();
        }

        public void CancelBillboard(int billboardId)
        {
            MySqlConnection connection = mConexion.getConnection();
            MySqlCommand command = connection.CreateCommand();
            MySqlTransaction transaction = null;

            try
            {

                // Obtener el ID de la sala asociada a la cartelera
                command.CommandText = "SELECT id_Sala FROM entidad_cartelera WHERE id_cartelera = @id_cartelera";
                command.Parameters.AddWithValue("@id_cartelera", billboardId);
                int salaId = Convert.ToInt32(command.ExecuteScalar());

                // Comienza una transacción
                transaction = connection.BeginTransaction();

                // Cancelar todas las reservas de la sala
                command.CommandText = "DELETE FROM entidad_reserva WHERE id_asiento IN (SELECT id_asiento FROM entidad_asiento WHERE id_sala = @id_sala)";
                command.Parameters.AddWithValue("@id_sala", salaId);
                command.ExecuteNonQuery();

                // Habilitar todas las butacas de la sala
                command.CommandText = "UPDATE entidad_asiento SET Estado = 1 WHERE id_sala = @id_sala";
                command.ExecuteNonQuery();

                // Eliminar la cartelera
                command.CommandText = "DELETE FROM entidad_cartelera WHERE id_cartelera = @id_cartelera";
                command.ExecuteNonQuery();

                // Confirmar la transacción
                transaction.Commit();
            }
            catch (Exception ex)
            {
                // Revertir la transacción en caso de error
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                throw ex;
            }
            finally
            {
                if (transaction != null)
                {
                    transaction.Dispose();
                }
                command.Dispose();
                connection.Close();
                connection.Dispose();
            }
        }

        private void showCartelera()
        {
            dtCarteleras = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `entidad_cartelera`", mConexion.getConnection());
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    dtCarteleras.Columns.Add(reader.GetName(i), reader.GetFieldType(i));
                }

                DataRow row = dtCarteleras.NewRow();

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    row[i] = reader[i];
                }

                dtCarteleras.Rows.Add(row);
            }

            reader.Close();

            dgvCarteleras.DataSource = dtCarteleras;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (dgvCarteleras.SelectedRows != null)
            {
                int id_reserva = Convert.ToInt32(dgvCarteleras.SelectedRows[0].Cells["id_cartelera"].Value);
                CancelBillboard(id_reserva);
                MessageBox.Show("Cartelera cancelada con exito");
                showCartelera();
            }
            else
            {
                MessageBox.Show("Asegurate de escoger una reserva");
            }
        }
    }
}
