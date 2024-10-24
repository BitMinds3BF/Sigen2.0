using BITMINDS.modelos;
using BITMINDS.services;
using BITMINDS.ventanas;
using System;
using System.Windows.Forms;

namespace BITMINDS.controladores
{
    public class FormularioDeporteControlador : ControladorBase
    {
        private FormularioDeporteService service = new FormularioDeporteService();
        public FormularioDeporte Ventana {  get; set; }

        public void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var deporte = new Deporte() 
                {
                    Nombre = Ventana.txtDeporte.Text
                };
                service.GuardarDeporte(deporte);
                MessageBox.Show("Deporte agregado correctamente");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        public override string ObtenerPlaceHolder(TextBox campo)
        {
            switch(campo.Name)
            {
                case "txtDeporte":
                    return "Deporte";
            }

            return string.Empty;
        }

        public static FormularioDeporteControlador Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FormularioDeporteControlador();
                }

                return instance;
            }
        }

        private static FormularioDeporteControlador instance;
    }
}
