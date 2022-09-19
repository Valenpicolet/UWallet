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
            string contrasenia1 = txtContrasenia.Text;
            string contrasenia2 = txtRepetirContrasenia.Text;

            string nombreDeUsuario = txtNombreUsuario.Text.Trim();
            string email = txtContrasenia.Text.Trim();
            string contrasenia = txtContrasenia.Text.Trim();

            bool tienenombreDeUsuario = esDatoValido(nombreDeUsuario);
            bool tieneEmail = validarEmaill(email);
            bool tieneContrasenia = esDatoValido(contrasenia);
            bool contraseniasCoinciden = String.Equals(contrasenia1, contrasenia2);

            bool existeEnLaBD = ExisteEnLaBD();

            if (tienenombreDeUsuario && tieneEmail && tieneContrasenia && contraseniasCoinciden)
            {
                lblErrorRegistrarUsuario.Visible = false;


                if (existeEnLaBD)
                {
                    lblErrorRegistrarUsuario.Text = "El usuario ya esta registrado.";
                    lblErrorRegistrarUsuario.Visible = true;
                }
                else
                {
                    // crear usuario
                    // registrar usuario en al BD

                    var registrarCliente = new FrmRegistrarCliente();
                    this.Close();
                }
            }
            else
            {
                lblErrorRegistrarUsuario.Text = "El usuario no se ha podido crear.";
                lblErrorRegistrarUsuario.Visible = true;
            }

            // enviar info a al BD

        }

        private bool ExisteEnLaBD()
        {
            throw new NotImplementedException();
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
                lblContraseniasNoCoinciden.Text = "Las contraseñas no coinciden";
                lblContraseniasNoCoinciden.Visible = true;
            }
        }

        public static bool validarEmaill(string email)
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

        private void txtMail_Leave(object sender, EventArgs e)
        {
            string input = txtMail.Text.Trim();
            bool emailEsValido = validarEmaill(input);
            if (emailEsValido)
            {
                lblErrorMail.Visible = false;
            }
            else
            {
                lblErrorMail.Text = "E-mail no válido.";
                lblErrorMail.Visible = true;
            }
        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {
            string input = txtNombreUsuario.Text.Trim();
            bool nombreUsuarioEsValido = EstaNombreDeUsuarioDisponible(input);

            if (nombreUsuarioEsValido)
            {
                lblErrorNombreUsuario.Visible = false;
            }
            else
            {
                lblErrorNombreUsuario.Text = "Nombre de usuario no disponible.";
                lblErrorNombreUsuario.Visible = true;
            }

        }

        private bool EstaNombreDeUsuarioDisponible(string input)
        {
            // consultar si existe en bd
            // si el usuario ya existe, devolver false
            // si el usuario no existe, devolver true

            throw new NotImplementedException();
        }
    }
}
