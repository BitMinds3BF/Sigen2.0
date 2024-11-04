namespace BITMINDS.ventanas
{
    partial class FormularioEjercicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cboxGrupoMuscular = new System.Windows.Forms.ComboBox();
            this.cboxTipo = new System.Windows.Forms.ComboBox();
            this.cboxRutinas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulario Ejercicio";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(123, 162);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(312, 29);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.Tag = "";
            this.txtNombre.Text = "Nombre";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(123, 215);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(312, 29);
            this.txtDescripcion.TabIndex = 7;
            this.txtDescripcion.Tag = "";
            this.txtDescripcion.Text = "Descripcion";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(123, 425);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(312, 36);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // cboxGrupoMuscular
            // 
            this.cboxGrupoMuscular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboxGrupoMuscular.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxGrupoMuscular.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cboxGrupoMuscular.FormattingEnabled = true;
            this.cboxGrupoMuscular.Items.AddRange(new object[] {
            "-- Grupo muscular--",
            "Piernas",
            "Brazos",
            "Pectorales",
            "Espalda",
            "Hombros"});
            this.cboxGrupoMuscular.Location = new System.Drawing.Point(123, 266);
            this.cboxGrupoMuscular.Name = "cboxGrupoMuscular";
            this.cboxGrupoMuscular.Size = new System.Drawing.Size(312, 28);
            this.cboxGrupoMuscular.TabIndex = 13;
            // 
            // cboxTipo
            // 
            this.cboxTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTipo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cboxTipo.FormattingEnabled = true;
            this.cboxTipo.Items.AddRange(new object[] {
            "-- Tipo--",
            "Empuje",
            "Jalon"});
            this.cboxTipo.Location = new System.Drawing.Point(123, 316);
            this.cboxTipo.Name = "cboxTipo";
            this.cboxTipo.Size = new System.Drawing.Size(312, 28);
            this.cboxTipo.TabIndex = 14;
            // 
            // cboxRutinas
            // 
            this.cboxRutinas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboxRutinas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxRutinas.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cboxRutinas.FormattingEnabled = true;
            this.cboxRutinas.Items.AddRange(new object[] {
            "-- Seleccionar rutina--"});
            this.cboxRutinas.Location = new System.Drawing.Point(123, 380);
            this.cboxRutinas.Name = "cboxRutinas";
            this.cboxRutinas.Size = new System.Drawing.Size(312, 28);
            this.cboxRutinas.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Seleccionar rutina";
            // 
            // FormularioEjercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 480);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboxRutinas);
            this.Controls.Add(this.cboxTipo);
            this.Controls.Add(this.cboxGrupoMuscular);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "FormularioEjercicio";
            this.Text = "FormularioEjercicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.ComboBox cboxGrupoMuscular;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.ComboBox cboxTipo;
        public System.Windows.Forms.ComboBox cboxRutinas;
        private System.Windows.Forms.Label label2;
    }
}