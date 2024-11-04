using BITMINDS.controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BITMINDS.ventanas
{
    public partial class FormularioUsuario : Form
    {
        public string Documento { get; set; } = string.Empty;
        public string TipoDocumento { get; set; } = string.Empty;
        public FormularioUsuario()
        {
            InitializeComponent();
            cboxTipoDocumento.SelectedIndex = 0;
            cboxRol.SelectedIndex = 0;
            cboxTipoCliente.SelectedIndex = 0;

            controlador = FormularioUsuarioControlador.Instance;
            controlador.Ventana = this;

            btnGuardar.Click += controlador.btnGuardar_Click;
            btnGenerarContraseña.Click += controlador.btnGenerarContraseña_Click;

            cboxTipoDocumento.SelectedIndexChanged += controlador.SelectedIndexChanged;
            cboxRol.SelectedIndexChanged += controlador.RolUsuario_Changed;

            txtDocumento.Enter += controlador.EnterTxt;
            txtDocumento.Leave += controlador.LeaveTxt;

            txtNombre.Enter += controlador.EnterTxt;
            txtNombre.Leave += controlador.LeaveTxt;

            txtApellido.Enter += controlador.EnterTxt;
            txtApellido.Leave += controlador.LeaveTxt;

            txtEmail.Enter += controlador.EnterTxt;
            txtEmail.Leave += controlador.LeaveTxt;

            txtDepartamento.Enter += controlador.EnterTxt;
            txtDepartamento.Leave += controlador.LeaveTxt;
            
            txtCalle.Enter += controlador.EnterTxt;
            txtCalle.Leave += controlador.LeaveTxt;

            txtNumero.Enter += controlador.EnterTxt;
            txtNumero.Leave += controlador.LeaveTxt;

            Load += controlador.Ventana_Load;
        }

        private FormularioUsuarioControlador controlador;
    }
}
