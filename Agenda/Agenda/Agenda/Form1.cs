using Agenda.ConexionDB;
using System.Data.SqlClient;
using System.Data;

namespace Agenda
{
    public partial class Form1 : Form
    {
        int idSeleccionado = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarContactos();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Conexion con = new Conexion();

            SqlConnection cn = con.conectar();


            string query =
            "INSERT INTO Contactos VALUES(@Nombre,@Apellido,@Fecha,@Direccion,@Genero,@Estado,@Movil,@Telefono,@Correo)";


            SqlCommand cmd = new SqlCommand(query, cn);


            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text);
            cmd.Parameters.AddWithValue("@Fecha", dtNacimiento.Value);
            cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
            cmd.Parameters.AddWithValue("@Genero", cmbGenero.Text);
            cmd.Parameters.AddWithValue("@Estado", cmbEstado.Text);
            cmd.Parameters.AddWithValue("@Movil", txtMovil.Text);
            cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);
            cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text);


            cn.Open();

            cmd.ExecuteNonQuery();

            cn.Close();


            MessageBox.Show("Registro guardado");
            MostrarContactos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Conexion con = new Conexion();

            SqlConnection cn = con.conectar();


            SqlDataAdapter da =
            new SqlDataAdapter(
            "SELECT * FROM Contactos WHERE Nombre LIKE @Nombre",
            cn);


            da.SelectCommand.Parameters.AddWithValue(
                "@Nombre",
                "%" + txtNombre.Text + "%"
            );


            DataTable dt = new DataTable();


            da.Fill(dt);


            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No existe ningún registro con ese nombre",
                "Búsqueda",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);


                dgvContactos.DataSource = null;
            }
            else
            {
                dgvContactos.DataSource = dt;
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un contacto");
                return;
            }


            Conexion con = new Conexion();

            SqlConnection cn = con.conectar();


            string sql = @"
                UPDATE Contactos SET

                Nombre=@Nombre,
                Apellido=@Apellido,
                FechaNacimiento=@Fecha,
                Direccion=@Direccion,
                Genero=@Genero,
                EstadoCivil=@Estado,
                Movil=@Movil,
                Telefono=@Telefono,
                Correo=@Correo

                WHERE Id=@Id";


            SqlCommand cmd = new SqlCommand(sql, cn);


            cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);

            cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text);

            cmd.Parameters.AddWithValue("@Fecha", dtNacimiento.Value);

            cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);

            cmd.Parameters.AddWithValue("@Genero", cmbGenero.Text);

            cmd.Parameters.AddWithValue("@Estado", cmbEstado.Text);

            cmd.Parameters.AddWithValue("@Movil", txtMovil.Text);

            cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);

            cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text);

            cmd.Parameters.AddWithValue("@Id", idSeleccionado);



            cn.Open();

            cmd.ExecuteNonQuery();

            cn.Close();


            MessageBox.Show("Registro actualizado");


            MostrarContactos();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Conexion con = new Conexion();

            SqlConnection cn = con.conectar();


            string sql =
            "DELETE FROM Contactos WHERE Id=@Id";


            SqlCommand cmd =
            new SqlCommand(sql, cn);


            cmd.Parameters.AddWithValue("@Id",
            dgvContactos.CurrentRow.Cells["Id"].Value);



            cn.Open();

            cmd.ExecuteNonQuery();

            cn.Close();


            MessageBox.Show("Registro eliminado");
            MostrarContactos();
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtMovil.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();

           
            cmbGenero.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;

            dtNacimiento.Value = DateTime.Now;

            
            dgvContactos.ClearSelection();
            MostrarContactos();
        }

        private void MostrarContactos()
        {
            Conexion con = new Conexion();

            SqlConnection cn = con.conectar();


            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT * FROM Contactos",
                cn
            );


            DataTable dt = new DataTable();

            da.Fill(dt);


            dgvContactos.DataSource = dt;
        }
        private void dgvContactos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idSeleccionado = Convert.ToInt32(
                    dgvContactos.Rows[e.RowIndex].Cells[0].Value
                );


                Conexion con = new Conexion();
                SqlConnection cn = con.conectar();


                SqlCommand cmd = new SqlCommand(
                "SELECT * FROM Contactos WHERE Id=@Id", cn);


                cmd.Parameters.AddWithValue("@Id", idSeleccionado);


                cn.Open();


                SqlDataReader dr = cmd.ExecuteReader();


                if (dr.Read())
                {

                    txtNombre.Text = dr["Nombre"].ToString();

                    txtApellido.Text = dr["Apellido"].ToString();

                    dtNacimiento.Value = Convert.ToDateTime(
                        dr["FechaNacimiento"]
                    );

                    txtDireccion.Text = dr["Direccion"].ToString();


                    cmbGenero.Text = dr["Genero"].ToString();

                    cmbEstado.Text = dr["EstadoCivil"].ToString();


                    txtMovil.Text = dr["Movil"].ToString();

                    txtTelefono.Text = dr["Telefono"].ToString();

                    txtCorreo.Text = dr["Correo"].ToString();

                }


                cn.Close();

            }


        }

       
    }
}
