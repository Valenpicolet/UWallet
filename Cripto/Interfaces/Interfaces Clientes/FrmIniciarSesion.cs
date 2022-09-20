using Cripto.Interfaces.Interfaces_Clientes;
using Cripto.Servicios;
using Pav.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAV
{
    public partial class FrmIniciarSesion : Form
    {

        public FrmIniciarSesion()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var registraruUsuario = new FrmRegistrarUsuario();
            this.Close();
        }

        private void btnRecuperarContrasenia_Click(object sender, EventArgs e)
        {
            var RecuperarContrasenia = new FrmRecuperarContrasenia();
            this.Close();
        }

        private void LimpiarCampos()
        {
            txtUsuario.Clear();
            txtContrasenia.Clear();
        }

        private void MostrarError(string mensaje, bool mostrar)
        {
            lblErrorInicioSesion.Visible = mostrar;
            lblErrorInicioSesion.Text = mensaje;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            bool esUsuarioValido;

            MostrarError("", false);

            if (txtUsuario.Text.Trim() == "")
            {
                MostrarError("Debe ingresar usuario.", true);
                txtUsuario.Focus();
                return;
            }

            if (txtContrasenia.Text == String.Empty)
            {
                MostrarError("Debe ingresar la contraseña.", true);
                txtContrasenia.Focus();
                return;
            }

            string usuarioIngresado = txtUsuario.Text;
            string contraseniaIngresada = txtContrasenia.Text;
            esUsuarioValido = ValidarUsuario(usuarioIngresado, contraseniaIngresada);

            // si tenemos el usuario, ir al principal usuario o admin
            // si no tenemos los datos del cliente en la BD, ir a registrar cliente

            if (esUsuarioValido)
            {
                bool esUsuarioCliente = ValidarPerfil(usuarioIngresado, contraseniaIngresada, 2);
                if (esUsuarioCliente)
                {
                    bool tengoDatosCliente = ValidarDatos(usuarioIngresado, contraseniaIngresada, 2);

                    if (tengoDatosCliente)
                    {
                        var principalCliente = new FrmPrincipal();
                        principalCliente.Show();
                        MessageBox.Show("Llega hasta aca y despues se cierra :(");
                    }
                    else
                    {
            //            var registrarCliente = new FrmRegistrarCliente();
                    }
                    this.Close();
                }
                else
                {
            //        var principalAdmin = new FrmPrincipalAdmin();
                }
                this.Close();
            }
            else
            {
                // TODO no se muestra el error y no se pq :(
                MostrarError("Usuario y/o contraseña incorrectos.", true);
                //MessageBox.Show("no se que falla");
                LimpiarCampos();
                this.txtUsuario.Focus();
            }
        }

        // Verfica que el cliente tenga apellido, que significa que tiene todos sus datos cargados
        private bool ValidarDatos(string nombre, string contrasenia, int id_perfil)
        {
            var sql = $"SELECT * FROM Usuarios u JOIN Perfiles p ON u.id_perfil = p.id_perfil " +
                $"JOIN Clientes c on u.id_usuario = c.id_usuario " + 
                $"WHERE u.nombre='{nombre}' AND u.contrasenia='{contrasenia}' " +
                $"AND u.id_perfil={id_perfil} AND c.apellido IS NOT NULL";
            var res = DBHelper.GetDBHelper().ConsultaSQL(sql);

            if (res.Rows.Count == 0)
                return false;

            return true;
        }

        // Devuelve true si el usuario tiene ese perfil
        private bool ValidarPerfil(string nombre, string contrasenia, int id_perfil)
        {
            // id_perfil = 1 -> Administrador
            // id_perfil = 2 -> Cliente
            var sql = $"SELECT * FROM Usuarios u JOIN Perfiles p ON u.id_perfil = p.id_perfil " +
                $"WHERE u.nombre='{nombre}' AND u.contrasenia='{contrasenia}' " +
                $"AND u.id_perfil={id_perfil}";
            var res = DBHelper.GetDBHelper().ConsultaSQL(sql);

            if (res.Rows.Count == 0)
                return false;

            return true;
        }

        // Valida si existe el usuario
        private bool ValidarUsuario(string nombre, string contrasenia) 
        {
            var sql = $"SELECT * FROM Usuarios WHERE nombre='{nombre}' " +
                $"AND contrasenia='{contrasenia}'";
            var res = DBHelper.GetDBHelper().ConsultaSQL(sql);

            if (res.Rows.Count == 0)
                return false;

            return true;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            lblErrorInicioSesion.Visible = false;
        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {
            lblErrorInicioSesion.Visible = false;
        }

        private void FrmIniciarSesion_Load(object sender, EventArgs e)
        {
           
        }
    }
}
