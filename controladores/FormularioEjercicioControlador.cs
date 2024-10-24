using BITMINDS.services;
using BITMINDS.ventanas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BITMINDS.controladores
{
    public class FormularioEjercicioControlador : ControladorBase
    {
        private FormularioEjercicioService service = new FormularioEjercicioService();
        public FormularioEjercicio Ventana { get; set; }

        public void Ventana_onLoad(object sender, EventArgs e)
        {
            Ventana.cboxRutinas.DataSource = service.Rutinas();
        }
        public void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var ejercicio = new modelos.Ejercicio()
                {
                    Nombre = Ventana.txtNombre.Text,
                    Descripcion = Ventana.txtDescripcion.Text,
                    GrupoMuscular = Ventana.cboxGrupoMuscular.Text.ToLower(),
                    Tipo = Ventana.cboxTipo.Text.ToLower(),
                    Rutina = Convert.ToInt32(Ventana.cboxRutinas.Text)
                };
                service.GuardarEjercicio(ejercicio);
                MessageBox.Show("Ejercicio guardado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public override string ObtenerPlaceHolder(TextBox campo)
        {
            switch (campo.Name)
            {
                case "txtNombre":
                    return "Nombre";
                case "txtDescripcion":
                    return "Descripcion";
            }

            return string.Empty;
        }

        public static FormularioEjercicioControlador Instance
        {
            get
            {
                if (instance == null) instance = new FormularioEjercicioControlador();

                return instance;
            }
        }

        private static FormularioEjercicioControlador instance;
    }
}
