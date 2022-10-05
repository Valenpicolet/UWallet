using Cripto.Servicios;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAV
{
    public partial class FrmRegistrarUsuario : Form
    {
        public FrmRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            string nombreDeUsuario = txtNombreUsuario.Text.Trim();
            string email = txtMail.Text.Trim();
            string contrasenia = txtContrasenia.Text.Trim();
            string contrasenia2 = txtRepetirContrasenia.Text.Trim();

            bool tieneNombreDeUsuario = esDatoValido(nombreDeUsuario);
            bool tieneEmail = esDatoValido(email);
            bool tieneContrasenia = esDatoValido(contrasenia);
            bool mailValido = validarEmaillPosta(email);
            bool contraseniasCoinciden = String.Equals(contrasenia, contrasenia2);

            bool existeEnLaBD = ExisteEnLaBD(nombreDeUsuario, email);

            if (tieneNombreDeUsuario && tieneEmail && tieneContrasenia && contraseniasCoinciden && mailValido)
            {
                lblErrorRegistrarUsuario.Visible = false;

                if (existeEnLaBD)
                {
                    MostrarError(lblErrorRegistrarUsuario, "El usuario ya esta registrado.", true);
                }
                else
                {
                    AltaUsuario(nombreDeUsuario, email, contrasenia);
                    MessageBox.Show("Usuario creado");
                    this.Hide();
                    var registrarCliente = new FrmRegistrarCliente();
                    this.Close();
                }
            }
            else
            {
                MostrarError(lblErrorRegistrarUsuario, "El usuario no se ha podido crear.", true);
            }
        }

        private void MostrarError(Guna2HtmlLabel lbl, string mensaje, bool mostrar)
        {
            lbl.Visible = mostrar;
            lbl.Text = mensaje;
        }

        private void AltaUsuario(string nombreDeUsuario, string email, string contrasenia)
        {
            var sql = $"INSERT INTO Usuarios (nombre, email, contrasenia, id_perfil, fecha_alta)" +
                $"VALUES ('{nombreDeUsuario}', '{email}', '{contrasenia}', 2, GETDATE())";
            var res = DBHelper.GetDBHelper().EjecutarSQL(sql);
        }

        private bool ExisteEnLaBD(string nombre, string email)
        {
            var sql = $"SELECT * FROM Usuarios WHERE nombre='{nombre}' AND email='{email}'";
            var res = DBHelper.GetDBHelper().ConsultaSQL(sql);

            if (res.Rows.Count == 0)
                return false;

            return true;
        }

        public bool esDatoValido(string dato)
        {
            if (dato.Equals(""))
                return false;
            else
                return true;
        }

        private void txtRepetirContrasenia_TextChanged(object sender, EventArgs e)
        {
            string contrasenia1 = txtContrasenia.Text;
            string contrasenia2 = txtRepetirContrasenia.Text;

            if(String.Equals(contrasenia1, contrasenia2))
            {
                lblContraseniasNoCoinciden.Visible = false;
            }
            else
            {
                MostrarError(lblContraseniasNoCoinciden, "Las contraseñas no coinciden", true);
            }
        }

        public static bool validarEmaillPosta(string email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool ValidarEmaill(string email)
        {
            var sql = $"SELECT * FROM Usuarios WHERE email='{email}'";
            var res = DBHelper.GetDBHelper().ConsultaSQL(sql);

            if (res.Rows.Count == 0)
                return true;

            return false;
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {
            string input = txtMail.Text.Trim();
            bool emailEsValido = ValidarEmaill(input);
            if (emailEsValido)
            {
                MostrarError(lblErrorMail, "", false);
            }
            else
            {
                MostrarError(lblErrorMail, "E-mail no válido.", true);
            }
        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {
            string input = txtNombreUsuario.Text.Trim();
            bool nombreUsuarioEsValido = ValidarNombreUsuario(input);

            if (nombreUsuarioEsValido)
            {
                MostrarError(lblErrorNombreUsuario, "", false);
            }
            else
            {
                MostrarError(lblErrorNombreUsuario, "Nombre de usuario no disponible.", true);
            }
        }

        private bool ValidarNombreUsuario(string nombre)
        {
            var sql = $"SELECT * FROM Usuarios WHERE nombre='{nombre}'";
            var res = DBHelper.GetDBHelper().ConsultaSQL(sql);

            if (res.Rows.Count == 0)
                return true;

            return false;
        }
    }
}
