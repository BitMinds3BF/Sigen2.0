using BITMINDS.controladores;
using System;
using System.Windows.Forms;

namespace BITMINDS.ventanas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            controlador = LoginControlador.Instance;
            controlador.ventana = this;
            controlador.SeleccionarTipoDocumentoPorDefecto();

            //Asignamos los eventos basicos
            txtDocumento.Enter += controlador.EnterTxt;
            txtDocumento.Leave += controlador.LeaveTxt;

            txtContraseña.Enter += controlador.EnterTxt;
            txtContraseña.Leave += controlador.LeaveTxt;

            btnLogin.Click += controlador.BtnLoginClick;
            cboxTipoDocumento.SelectedIndexChanged += controlador.SelectedIndexChanged;   
        }

        private LoginControlador controlador;
    }
}
