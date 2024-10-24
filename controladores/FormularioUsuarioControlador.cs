using BITMINDS.services;
using BITMINDS.ventanas;
using System;
using System.Windows.Forms;
using BITMINDS.modelos;

namespace BITMINDS.controladores
{
    public class FormularioUsuarioControlador : ControladorBase
    {
        private FormularioUsuarioService service = new FormularioUsuarioService();
        public FormularioUsuario Ventana { get; set; }

        public void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var usuario = new modelos.Cliente()
                {
                    NumDoc = Ventana.txtDocumento.Text,
                    TipoDoc = Ventana.cboxTipoDocumento.Text.ToLower(),
                    Email = Ventana.txtEmail.Text,
                    Nombre = Ventana.txtNombre.Text,
                    Apellido = Ventana.txtApellido.Text,
                    Departamento = Ventana.txtDepartamento.Text,
                    Calle = Ventana.txtCalle.Text,
                    Numero = Ventana.txtNumero.Text,

                    Rol = Ventana.cboxRol.Text.ToLower()
                };
                service.GuardarUsuario(usuario);

                if (Ventana.cboxRol.SelectedItem.ToString().ToLower() == "cliente")
                {
                    string tipoCliente = Ventana.cboxTipoCliente.SelectedItem.ToString().ToLower();
                    service.GuardarCliente(usuario, tipoCliente);
                }

                MessageBox.Show("Usuario guardado correctamente!");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        public void btnGenerarContraseña_Click(object sender, EventArgs e)
        {
            string tempPass = service.GenerarContraseña();
            Ventana.txtContraseña.Text = tempPass;
        }

        public void RolUsuario_Changed(object sender, EventArgs e)
        {
            var rol = sender as ComboBox;
            switch(rol.SelectedItem.ToString().ToLower())
            {
                case "cliente":
                    Ventana.cboxTipoCliente.Enabled = true;
                    break;
                default:
                    Ventana.cboxTipoCliente.Enabled = false;
                    Ventana.cboxTipoCliente.SelectedIndex = 0;
                    break;
            }
        }

        public void SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox tipoDocumento = (ComboBox)sender;            
            switch (tipoDocumento.Text.ToLower())
            {
                case "documento":
                    if (Ventana.txtDocumento.TextLength > 8)
                    {
                        Ventana.txtDocumento.Text = string.Empty;
                    }
                    Ventana.txtDocumento.MaxLength = 8;
                    break;
                case "pasaporte":
                    Ventana.txtDocumento.MaxLength = 9;
                    break;
            }
        }

        public override string ObtenerPlaceHolder(TextBox campo)
        {
            switch (campo.Name)
            {
                case "txtDocumento":
                    return "Documento";
                case "txtEmail":
                    return "Email";
                case "txtNombre":
                    return "Nombre";
                case "txtApellido":
                    return "Apellido";
                case "txtDepartamento":
                    return "Departamento";
                case "txtCalle":
                    return "Calle";
                case "txtNumero":
                    return "N°";
            }

            return string.Empty;
        }

        public static FormularioUsuarioControlador Instance
        {
            get
            {
                if (instance == null) instance = new FormularioUsuarioControlador();

                return instance;
            }
        }

        private static FormularioUsuarioControlador instance;
    }
}
