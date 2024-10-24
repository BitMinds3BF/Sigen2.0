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
    public partial class FormularioEjercicio : Form
    {
        public FormularioEjercicio()
        {
            InitializeComponent();
            cboxGrupoMuscular.SelectedIndex = 0;
            cboxTipo.SelectedIndex = 0;

            controlador = FormularioEjercicioControlador.Instance;
            controlador.Ventana = this;

            txtNombre.Enter += controlador.EnterTxt;
            txtNombre.Leave += controlador.LeaveTxt;

            txtDescripcion.Enter += controlador.EnterTxt;
            txtDescripcion.Leave += controlador.LeaveTxt;

            btnGuardar.Click += controlador.BtnGuardar_Click;
        }

        private FormularioEjercicioControlador controlador;
    }
}
