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
    public partial class Cliente : Form
    {
        public string Documento { get; set; }
        public string TipoDocumento { get; set; }
        public Cliente()
        {
            InitializeComponent();

            var controlador = ClienteControlador.Instance;
            controlador.Ventana = this;

            Load += controlador.Ventana_Load;

            btnMostrarEjercicios.Click += controlador.BtnMostrarEjercicios_Click;
            btnMostrarDesempeño.Click += controlador.BtnMostrarDesempeños_Click;
            btnCerrarSesion.Click += controlador.BtnCerrarSesion_Click;
            btnMarcarCompletado.Click += controlador.BtnMarcarCompletado_Click;

            dgvItems.RowStateChanged += controlador.DgvItems_RowStateChanged;
        }
    }
}
