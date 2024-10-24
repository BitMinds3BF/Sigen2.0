namespace BITMINDS.ventanas
{
    partial class Cliente
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
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMostrarEjercicios = new System.Windows.Forms.Button();
            this.btnMostrarDesempeño = new System.Windows.Forms.Button();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(12, 88);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(625, 350);
            this.dgvItems.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(11, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(391, 45);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Planes de entrenamiento";
            // 
            // btnMostrarEjercicios
            // 
            this.btnMostrarEjercicios.Location = new System.Drawing.Point(653, 88);
            this.btnMostrarEjercicios.Name = "btnMostrarEjercicios";
            this.btnMostrarEjercicios.Size = new System.Drawing.Size(135, 53);
            this.btnMostrarEjercicios.TabIndex = 5;
            this.btnMostrarEjercicios.Text = "Mostrar ejercicios asignados";
            this.btnMostrarEjercicios.UseVisualStyleBackColor = true;
            // 
            // btnMostrarDesempeño
            // 
            this.btnMostrarDesempeño.Location = new System.Drawing.Point(653, 158);
            this.btnMostrarDesempeño.Name = "btnMostrarDesempeño";
            this.btnMostrarDesempeño.Size = new System.Drawing.Size(135, 53);
            this.btnMostrarDesempeño.TabIndex = 6;
            this.btnMostrarDesempeño.Text = "Mostrar desempeño";
            this.btnMostrarDesempeño.UseVisualStyleBackColor = true;
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCompleto.Location = new System.Drawing.Point(14, 13);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(163, 25);
            this.lblNombreCompleto.TabIndex = 7;
            this.lblNombreCompleto.Text = "Nombre Apellido";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(653, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 53);
            this.button1.TabIndex = 8;
            this.button1.Text = "Marcar como completado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNombreCompleto);
            this.Controls.Add(this.btnMostrarDesempeño);
            this.Controls.Add(this.btnMostrarEjercicios);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvItems);
            this.Name = "Cliente";
            this.Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMostrarEjercicios;
        private System.Windows.Forms.Button btnMostrarDesempeño;
        public System.Windows.Forms.DataGridView dgvItems;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.Button button1;
    }
}