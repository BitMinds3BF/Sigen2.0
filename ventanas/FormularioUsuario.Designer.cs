namespace BITMINDS.ventanas
{
    partial class FormularioUsuario
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
            this.cboxTipoDocumento = new System.Windows.Forms.ComboBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.btnGenerarContraseña = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.cboxRol = new System.Windows.Forms.ComboBox();
            this.cboxTipoCliente = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboxTipoDocumento
            // 
            this.cboxTipoDocumento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboxTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTipoDocumento.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cboxTipoDocumento.FormattingEnabled = true;
            this.cboxTipoDocumento.Items.AddRange(new object[] {
            "-- Tipo de documento --",
            "Documento",
            "Pasaporte"});
            this.cboxTipoDocumento.Location = new System.Drawing.Point(176, 90);
            this.cboxTipoDocumento.Name = "cboxTipoDocumento";
            this.cboxTipoDocumento.Size = new System.Drawing.Size(223, 28);
            this.cboxTipoDocumento.TabIndex = 6;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(60, 134);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(223, 29);
            this.txtDocumento.TabIndex = 5;
            this.txtDocumento.Tag = "";
            this.txtDocumento.Text = "Documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "Formulario del usuario";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Location = new System.Drawing.Point(21, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 139);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos personales";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(6, 100);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(240, 29);
            this.txtApellido.TabIndex = 12;
            this.txtApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(6, 61);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(240, 29);
            this.txtNombre.TabIndex = 11;
            this.txtNombre.Tag = "";
            this.txtNombre.Text = "Nombre";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(6, 21);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(240, 29);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.Tag = "";
            this.txtEmail.Text = "Email";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNumero);
            this.groupBox2.Controls.Add(this.txtCalle);
            this.groupBox2.Controls.Add(this.txtDepartamento);
            this.groupBox2.Location = new System.Drawing.Point(289, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 139);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Direccion";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(198, 77);
            this.txtNumero.MaxLength = 6;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(66, 29);
            this.txtNumero.TabIndex = 14;
            this.txtNumero.Text = "n°";
            // 
            // txtCalle
            // 
            this.txtCalle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalle.Location = new System.Drawing.Point(6, 77);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(186, 29);
            this.txtCalle.TabIndex = 13;
            this.txtCalle.Text = "Calle";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartamento.Location = new System.Drawing.Point(6, 33);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(258, 29);
            this.txtDepartamento.TabIndex = 12;
            this.txtDepartamento.Text = "Departamento";
            // 
            // btnGenerarContraseña
            // 
            this.btnGenerarContraseña.Location = new System.Drawing.Point(21, 376);
            this.btnGenerarContraseña.Name = "btnGenerarContraseña";
            this.btnGenerarContraseña.Size = new System.Drawing.Size(538, 40);
            this.btnGenerarContraseña.TabIndex = 10;
            this.btnGenerarContraseña.Text = "Generar contraseña";
            this.btnGenerarContraseña.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(21, 428);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(538, 40);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Enabled = false;
            this.txtContraseña.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(295, 134);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(223, 29);
            this.txtContraseña.TabIndex = 12;
            this.txtContraseña.Tag = "";
            this.txtContraseña.Text = "Contraseña no generada";
            // 
            // cboxRol
            // 
            this.cboxRol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboxRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxRol.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cboxRol.FormattingEnabled = true;
            this.cboxRol.Items.AddRange(new object[] {
            "-- Rol --",
            "Cliente",
            "Admin",
            "Entrenador",
            "TI"});
            this.cboxRol.Location = new System.Drawing.Point(60, 175);
            this.cboxRol.Name = "cboxRol";
            this.cboxRol.Size = new System.Drawing.Size(223, 28);
            this.cboxRol.TabIndex = 13;
            // 
            // cboxTipoCliente
            // 
            this.cboxTipoCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboxTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTipoCliente.Enabled = false;
            this.cboxTipoCliente.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cboxTipoCliente.FormattingEnabled = true;
            this.cboxTipoCliente.Items.AddRange(new object[] {
            "-- Tipo de cliente --",
            "Deportista",
            "Paciente"});
            this.cboxTipoCliente.Location = new System.Drawing.Point(295, 175);
            this.cboxTipoCliente.Name = "cboxTipoCliente";
            this.cboxTipoCliente.Size = new System.Drawing.Size(223, 28);
            this.cboxTipoCliente.TabIndex = 14;
            // 
            // FormularioUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 480);
            this.Controls.Add(this.cboxTipoCliente);
            this.Controls.Add(this.cboxRol);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnGenerarContraseña);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxTipoDocumento);
            this.Controls.Add(this.txtDocumento);
            this.Name = "FormularioUsuario";
            this.Text = "Formulario del Usuario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cboxTipoDocumento;
        public System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.TextBox txtNumero;
        public System.Windows.Forms.TextBox txtCalle;
        public System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Button btnGenerarContraseña;
        private System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.TextBox txtApellido;
        public System.Windows.Forms.TextBox txtContraseña;
        public System.Windows.Forms.ComboBox cboxRol;
        public System.Windows.Forms.ComboBox cboxTipoCliente;
    }
}