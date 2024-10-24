﻿using BITMINDS.modelos;
using BITMINDS.ventanas;
using BITMINDS.services.login;
using System;
using System.Windows.Forms;

namespace BITMINDS.controladores
{
    public class LoginControlador : ControladorBase
    {
        private LoginService service = new LoginService();
        public Login ventana { get; set; }

        public void SeleccionarTipoDocumentoPorDefecto()
        {
            ventana.cboxTipoDocumento.SelectedIndex = 0;
        }

        public void SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ventana.cboxTipoDocumento.Text.ToLower())
            {
                case "documento":
                    if (ventana.txtDocumento.TextLength > 8)
                    {
                        ventana.txtDocumento.Text = string.Empty;
                    }
                    ventana.txtDocumento.MaxLength = 8;
                    break;
                case "pasaporte":
                    ventana.txtDocumento.MaxLength = 9;
                    break;
            }
        }

        public void BtnLoginClick(object sender, EventArgs e)
        {
            try
            {
                bool successLogin = service.Login
                (
                    ventana.txtDocumento.Text,
                    ventana.cboxTipoDocumento.Text.ToLower(),
                    ventana.txtContraseña.Text
                );

                if (successLogin)
                {
                    MessageBox.Show("Logueado correctamente!");
                    string documento = ventana.txtDocumento.Text;
                    string tipoDocumento = ventana.cboxTipoDocumento.Text;
                    LimpiarCampos();
                    var cliente = new ventanas.Cliente();
                    cliente.Documento = documento;
                    cliente.TipoDocumento = tipoDocumento;

                    ventana.Hide();
                    cliente.ShowDialog();
                    ventana.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            ventana.txtDocumento.Text = "Documento";
            ventana.txtContraseña.Text = "Contraseña";
            ventana.txtContraseña.PasswordChar = '\0';
            ventana.cboxTipoDocumento.SelectedIndex = 0;
        }

        public override string ObtenerPlaceHolder(TextBox campo)
        {
            switch (campo.Name)
            {
                case "txtDocumento":
                    return "Documento";
                case "txtContraseña":
                    return "Contraseña";
            }

            return string.Empty;
        }

        public static LoginControlador Instance 
        { 
            get 
            {
                if (instance == null) instance = new LoginControlador();

                return instance;
            }
        }
        private static LoginControlador instance;
    }
}
