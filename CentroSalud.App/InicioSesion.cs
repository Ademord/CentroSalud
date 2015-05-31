using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace CentroSalud.App
{
    public partial class InicioSesion : Form
    {
        string DBname = "centrosalud";
        string DBpwd = "cisco";

        public InicioSesion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var conn = new NpgsqlConnection("Host=localhost; User=" + DBname + "; Password=" + DBpwd );
            var conn = new NpgsqlConnection("Host=localhost; User=centrosalud; Password=cisco");
            conn.Open();
                
            var username = txt_username.Text;
            var password = txt_password.Text;

            var cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select count(*) from usuario where username= @username and password = @password;";

            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("password", password);

            var reader = cmd.ExecuteReader();
            reader.Read();
            var count = reader.GetInt64(0);

            if (count == 0)
            {
                MessageBox.Show("Usuario no existe");
            }
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void button_agregarMed_Click(object sender, EventArgs e)
        {
            var conn = new NpgsqlConnection("Host=localhost; User=centrosalud; Password=cisco");
            conn.Open();

            var nombreMed = textBox_nombreMed.Text;
            
            
            //agregar
            try {
                var cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO medicamento (nombre) VALUES (@nombreMed);";
                cmd.Parameters.AddWithValue("nombreMed", nombreMed);
                var reader = cmd.ExecuteReader();
                reader.Read();

                MessageBox.Show("Medicamento agregado exitosamente ");
            } 
            catch (Exception _error) {
                System.Console.Write(_error.ToString());
                MessageBox.Show("Medicamento ya existe.");
            }
        }

    }
}
