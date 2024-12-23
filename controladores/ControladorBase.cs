﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BITMINDS.controladores
{
    public abstract class ControladorBase
    {
        public void EnterTxt(object sender, EventArgs e)
        {
            var campo = sender as TextBox;
            bool placeHolder = campo.Text == ObtenerPlaceHolder(campo);

            if (placeHolder)
            {
                if ((campo.Tag as string) == "password")
                {
                    campo.PasswordChar = '*';
                }
                campo.Text = string.Empty;
            }
        }

        public void LeaveTxt(object sender, EventArgs e)
        {
            var campo = sender as TextBox;
            if (campo.Text.Length == 0)
            {
                if ((campo.Tag as string) == "password")
                {
                    campo.PasswordChar = '\0';
                }

                campo.Text = ObtenerPlaceHolder(campo);
            }
        }

        public abstract string ObtenerPlaceHolder(TextBox campo);
    }
}
