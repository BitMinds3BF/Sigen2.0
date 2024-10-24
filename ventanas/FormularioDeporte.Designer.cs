namespace BITMINDS.ventanas
{
    partial class FormularioDeporte
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
            this.txtDeporte = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Formulario Deporte";
            // 
            // txtDeporte
            // 
            this.txtDeporte.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeporte.Location = new System.Drawing.Point(132, 144);
            this.txtDeporte.Name = "txtDeporte";
            this.txtDeporte.Size = new System.Drawing.Size(312, 39);
            this.txtDeporte.TabIndex = 7;
            this.txtDeporte.Tag = "";
            this.txtDeporte.Text = "Deporte";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(132, 225);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(312, 52);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // FormularioDeporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 480);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtDeporte);
            this.Controls.Add(this.label1);
            this.Name = "FormularioDeporte";
            this.Text = "FormularioDeporte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtDeporte;
        public System.Windows.Forms.Button btnGuardar;
    }
}