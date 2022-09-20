using Cripto.Interfaces.Interfaces_Clientes;
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
    public partial class FrmRegistrarCliente : Form
    {
        public FrmRegistrarCliente()
        {
            InitializeComponent();
        }

        public bool esDatoValido(string dato)
        {
            if (dato.Equals(""))
                return false;
            else
                return true;

        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string ciudad = cmbCiudad.GetItemText(cmbCiudad.SelectedItem);
            string pais = cmbPais.GetItemText(cmbPais.SelectedItem);

            bool tieneNombre = esDatoValido(nombre);
            bool tieneApellido = esDatoValido(apellido);
            bool tieneTelefono = esDatoValido(telefono);
            bool tieneCiudad = esDatoValido(ciudad);
            bool tienePais = esDatoValido(pais);

            bool existeEnLaBD = ExisteEnLaBD(nombre, apellido, telefono, ciudad, pais);

            if (tieneNombre && tieneApellido && tieneTelefono && tieneCiudad && tienePais)
            {
                lblErrorRegistrarCliente.Visible = false;

                if (existeEnLaBD)
                {
                    lblErrorRegistrarCliente.Text = "El cliente ya está registrado. Inicie sesión o recupere su contraseña.";
                    lblErrorRegistrarCliente.Visible = true;
                }
                else
                {
                    // crear cliente
                    // registrar cliente en al BD
                    
                    var principalCliente = new FrmPrincipal();
                    principalCliente.Show();
                    this.Close();
                }
            }
            else
            {
                //otro  error podria ser que ya exista en la BD
                lblErrorRegistrarCliente.Text = "Completa todos los datos para registrarte.";
                lblErrorRegistrarCliente.Visible = true;
            }
        }

        private bool ExisteEnLaBD(string nombre, string apellido, string telefono, string ciudad, string pais)
        {
            // consultar si el cliente ya existe en la bd
            // si ya existe, deberia sugerir recuperar contraseño (si me acuerdo mañana lo hago)
            throw new NotImplementedException();
        }

        private void RegistrarCliente_Load(object sender, EventArgs e)
        {
            // txtMail.Text = Usuario.email;
        }
    }
}
