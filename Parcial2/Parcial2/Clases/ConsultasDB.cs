using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing;

namespace Parcial2.Clases
{
    internal class ConsultasDB
    {
    // definir metodos que se usaran 
        private int stock;
        MetodosGenerales metodos = new MetodosGenerales();
        Log log = new Log();

        // agregar nuevo dato a la base de datos
        public void AgregarDato (string nombre, int cantidad, double precio, PictureBox pb)
        {
            using (ConexionDB dB = new ConexionDB())
            {
                try
                {
                    dB.Conectar();
                    string query = "INSERT INTO medicamentos (nombre, cantidad, precio, foto)VALUES (@nombre, @cantidad, @precio, @foto)";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, dB.GetConnection()))
                    {
                        
                            cmd.Parameters.AddWithValue("@nombre", nombre);
                            cmd.Parameters.AddWithValue("@cantidad", cantidad);
                            cmd.Parameters.AddWithValue("@precio", precio);
                            cmd.Parameters.AddWithValue("@foto", metodos.ImageToBase64(pb.Image, ImageFormat.Png)); //convertir la imagen en base 64
                            MessageBox.Show("nuevo medicamentos agregado");
                            cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    log.setMensaje("Metodo ConsultasDB.AgregarDato: Error con la conexion a Base de datos");
                    log.informacion(ex);
                    MessageBox.Show("error");
                }
            }
        }
        // traer los los nombres de los medicamentos al ComboBox
        public void AgregarDataCB (ComboBox cb)
        {
            NpgsqlDataAdapter dataAdapter;
            DataTable dt = new DataTable();
            using (ConexionDB dB = new ConexionDB())
            {
                dB.Conectar();
                if (dB.GetConnection().State == ConnectionState.Open)
                {
                    try
                    {
                        string query = "select id, nombre from medicamentos";
                        dataAdapter = new NpgsqlDataAdapter(query, dB.GetConnection());
                        dataAdapter.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            cb.DataSource = dt;
                            cb.ValueMember = "id";
                            cb.DisplayMember = "nombre";
                        }
                        else
                        {
                            MessageBox.Show("no se encotro datos");
                        }
                    }
                    catch (Exception ex)
                    {
                        log.setMensaje("Metodo ConsultasDB.AgregarDatoCB: Error con la conexion a Base de datos");
                        log.informacion(ex);
                        MessageBox.Show("error");
                    }
                }
            }
        }
        // actualizar los medicamentos de la base de datos con informacion ingresada
        public void ActualizarMedicamentos(ComboBox cb, string nombre, int cantidad, double precio, PictureBox pb)
        {
            using (ConexionDB dB = new ConexionDB())
            {
                try
                {
                    dB.Conectar();
                    string query = "Update medicamentos Set nombre = @nombre, cantidad = @cantidad, precio = @precio, foto = @foto where id = @id";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, dB.GetConnection()))
                    {
                        cmd.Parameters.AddWithValue("@id", cb.SelectedValue);
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@cantidad", cantidad);
                        cmd.Parameters.AddWithValue("@precio", precio);
                        cmd.Parameters.AddWithValue("@foto", metodos.ImageToBase64(pb.Image, ImageFormat.Png));
                        MessageBox.Show("Informacion actualizado");
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    log.setMensaje("Metodo ConsultasDB.ActualizarMedicamentos: Error con la conexion a Base de datos");
                    log.informacion(ex);
                    MessageBox.Show("error");
                }
            }
        }
        // obtener informacion de la base de datos del medicamento a buscar
        public void ObtenerInfo(ComboBox cb, TextBox nombre, TextBox precio, TextBox cantidad, PictureBox pb)
        {
            Console.WriteLine(cb.SelectedValue);
            using (ConexionDB db = new ConexionDB())
            {
                try
                {
                    db.Conectar();
                    string query = "select * from medicamentos where id=@id";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, db.GetConnection()))
                    {
                        cmd.Parameters.AddWithValue("@id", cb.SelectedValue);
                        NpgsqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            nombre.Text = reader["nombre"].ToString();
                            precio.Text = reader["precio"].ToString();
                            cantidad.Text = reader["cantidad"].ToString();
                            pb.Image = metodos.Base64ToImage(reader["foto"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    log.setMensaje("Metodo ConsultasDB.ObtenerInfo: Error con la conexion a Base de datos");
                    log.informacion(ex);
                    MessageBox.Show("error");
                }
            }
        }
        // obtener alguna informacion de la base de datos del medicamento a buscar
        public void ObtenerInfo(ComboBox cb, TextBox txtStock, PictureBox pb)
        {
            using(ConexionDB db = new ConexionDB())
            {
                try
                {
                    db.Conectar();
                    string query = "select * from medicamentos where id = @id";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, db.GetConnection()))
                    {
                        cmd.Parameters.AddWithValue("@id", cb.SelectedValue);
                        cmd.ExecuteNonQuery();
                        NpgsqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            txtStock.Text = reader["cantidad"].ToString();
                            stock = Convert.ToInt32(txtStock.Text);
                            pb.Image = metodos.Base64ToImage(reader["foto"].ToString());
                        }
                    }
                }
                catch (Exception ex) 
                {
                    log.setMensaje("Metodo ConsultasDB.ObtenerInfo: Error con la conexion a Base de datos");
                    log.informacion(ex);
                    MessageBox.Show("error");
                }
            }
        }

        public void Transaccion (ComboBox cb,TextBox txtCantidad, string metodo="")
        {
            int CantidadVender = int.TryParse(txtCantidad.Text, out int valor) ? valor : 0;
            if (stock >= CantidadVender || metodo == "reponer")
            {
                int newCantidad = (metodo == "reponer" ? stock + CantidadVender : stock - CantidadVender);
                using(ConexionDB db = new ConexionDB())
                {
                    try
                    {
                        db.Conectar();
                        string query = "Update medicamentos set cantidad = @cantidad where id = @id";
                        using (NpgsqlCommand cmd = new NpgsqlCommand(query, db.GetConnection()))
                        {
                            cmd.Parameters.AddWithValue("@id", cb.SelectedValue);
                            cmd.Parameters.AddWithValue("@cantidad", newCantidad);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch(Exception ex)
                    {
                        log.setMensaje("Metodo ConsultasDB.Transaccion: Error con la conexion a Base de datos");
                        log.informacion(ex);
                        MessageBox.Show("error");
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay suficiente Stock para este medicamento 😠");
            }
        }
        public void GetInventario (DataGridView dgv)
        {
            NpgsqlDataAdapter dataAdapter;
            DataTable dt = new DataTable();
            using (ConexionDB dB = new ConexionDB())
            {
                dB.Conectar();
                if (dB.GetConnection().State == ConnectionState.Open)
                {
                    try
                    {
                        string query = "select id, nombre, cantidad, precio from medicamentos";
                        dataAdapter = new NpgsqlDataAdapter(query, dB.GetConnection());
                        dataAdapter.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            dgv.DataSource = dt;
                            
                        }
                        else
                        {
                            MessageBox.Show("no se encotro datos");
                        }
                    }
                    catch (Exception ex)
                    {
                        log.setMensaje("Metodo ConsultasDB.GetInventario: Error con la conexion a Base de datos");
                        log.informacion(ex);
                        MessageBox.Show("error");
                    }
                }
            }
        }

    }
}
