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
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(31, 88);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.Size = new System.Drawing.Size(913, 478);
            this.dgvItems.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(27, 40);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(391, 45);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Planes de entrenamiento";
            // 
            // btnMostrarEjercicios
            // 
            this.btnMostrarEjercicios.Location = new System.Drawing.Point(977, 101);
            this.btnMostrarEjercicios.Name = "btnMostrarEjercicios";
            this.btnMostrarEjercicios.Size = new System.Drawing.Size(135, 53);
            this.btnMostrarEjercicios.TabIndex = 5;
            this.btnMostrarEjercicios.Text = "Mostrar ejercicios asignados";
            this.btnMostrarEjercicios.UseVisualStyleBackColor = true;
            // 
            // btnMostrarDesempeño
            // 
            this.btnMostrarDesempeño.Location = new System.Drawing.Point(977, 174);
            this.btnMostrarDesempeño.Name = "btnMostrarDesempeño";
            this.btnMostrarDesempeño.Size = new System.Drawing.Size(135, 53);
            this.btnMostrarDesempeño.TabIndex = 6;
            this.btnMostrarDesempeño.Text = "Mostrar desempeño";
            this.btnMostrarDesempeño.UseVisualStyleBackColor = true;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 595);
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
    }
}