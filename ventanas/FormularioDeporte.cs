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
    public partial class FormularioDeporte : Form
    {
        public int Id { get; set; }
        public FormularioDeporte()
        {
            InitializeComponent();
            controlador = FormularioDeporteControlador.Instance;
            controlador.Ventana = this;

            txtDeporte.Enter += controlador.EnterTxt;
            txtDeporte.Leave += controlador.LeaveTxt;

            btnGuardar.Click += controlador.BtnGuardar_Click;

            Load += controlador.Ventana_Load;
        }

        private FormularioDeporteControlador controlador;
    }
}
