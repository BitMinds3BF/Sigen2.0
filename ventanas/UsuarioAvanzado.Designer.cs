namespace BITMINDS.ventanas
{
    partial class UsuarioAvanzado
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnCerSes = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModi = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridMostrar = new System.Windows.Forms.DataGridView();
            this.radiobtnClientes = new System.Windows.Forms.RadioButton();
            this.radiobtnEjercicios = new System.Windows.Forms.RadioButton();
            this.radiobtnDeportes = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(308, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(157, 47);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "S.I.G.EN";
            // 
            // btnCerSes
            // 
            this.btnCerSes.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerSes.Location = new System.Drawing.Point(666, 406);
            this.btnCerSes.Name = "btnCerSes";
            this.btnCerSes.Size = new System.Drawing.Size(122, 32);
            this.btnCerSes.TabIndex = 11;
            this.btnCerSes.Text = "Cerrar Sesion";
            this.btnCerSes.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(673, 327);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 30);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModi
            // 
            this.btnModi.Location = new System.Drawing.Point(673, 230);
            this.btnModi.Name = "btnModi";
            this.btnModi.Size = new System.Drawing.Size(75, 30);
            this.btnModi.TabIndex = 14;
            this.btnModi.Text = "Modificar";
            this.btnModi.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(673, 133);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridMostrar
            // 
            this.dataGridMostrar.AllowUserToAddRows = false;
            this.dataGridMostrar.AllowUserToDeleteRows = false;
            this.dataGridMostrar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridMostrar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridMostrar.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMostrar.Location = new System.Drawing.Point(22, 133);
            this.dataGridMostrar.MultiSelect = false;
            this.dataGridMostrar.Name = "dataGridMostrar";
            this.dataGridMostrar.ReadOnly = true;
            this.dataGridMostrar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridMostrar.RowHeadersVisible = false;
            this.dataGridMostrar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridMostrar.Size = new System.Drawing.Size(615, 305);
            this.dataGridMostrar.TabIndex = 12;
            // 
            // radiobtnClientes
            // 
            this.radiobtnClientes.AutoSize = true;
            this.radiobtnClientes.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnClientes.Location = new System.Drawing.Point(62, 95);
            this.radiobtnClientes.Name = "radiobtnClientes";
            this.radiobtnClientes.Size = new System.Drawing.Size(82, 21);
            this.radiobtnClientes.TabIndex = 16;
            this.radiobtnClientes.Text = "CLIENTES";
            this.radiobtnClientes.UseVisualStyleBackColor = true;
            // 
            // radiobtnEjercicios
            // 
            this.radiobtnEjercicios.AllowDrop = true;
            this.radiobtnEjercicios.AutoSize = true;
            this.radiobtnEjercicios.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnEjercicios.Location = new System.Drawing.Point(183, 95);
            this.radiobtnEjercicios.Name = "radiobtnEjercicios";
            this.radiobtnEjercicios.Size = new System.Drawing.Size(94, 21);
            this.radiobtnEjercicios.TabIndex = 17;
            this.radiobtnEjercicios.Text = "EJERCICIOS";
            this.radiobtnEjercicios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.radiobtnEjercicios.UseVisualStyleBackColor = true;
            // 
            // radiobtnDeportes
            // 
            this.radiobtnDeportes.AutoSize = true;
            this.radiobtnDeportes.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnDeportes.Location = new System.Drawing.Point(306, 95);
            this.radiobtnDeportes.Name = "radiobtnDeportes";
            this.radiobtnDeportes.Size = new System.Drawing.Size(89, 21);
            this.radiobtnDeportes.TabIndex = 18;
            this.radiobtnDeportes.Text = "DEPORTES";
            this.radiobtnDeportes.UseVisualStyleBackColor = true;
            // 
            // UsuarioAvanzado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radiobtnDeportes);
            this.Controls.Add(this.radiobtnEjercicios);
            this.Controls.Add(this.radiobtnClientes);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModi);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridMostrar);
            this.Controls.Add(this.btnCerSes);
            this.Controls.Add(this.lbl1);
            this.Name = "UsuarioAvanzado";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnCerSes;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModi;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.RadioButton radiobtnClientes;
        public System.Windows.Forms.RadioButton radiobtnEjercicios;
        public System.Windows.Forms.RadioButton radiobtnDeportes;
        public System.Windows.Forms.DataGridView dataGridMostrar;
    }
}