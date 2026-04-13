namespace Presentacion
{
    partial class FrmMenuEstudiante
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
            btnEmprendimientos = new Button();
            btnAgenda = new Button();
            btnGaleria = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnEmprendimientos
            // 
            btnEmprendimientos.Location = new Point(52, 43);
            btnEmprendimientos.Name = "btnEmprendimientos";
            btnEmprendimientos.Size = new Size(173, 98);
            btnEmprendimientos.TabIndex = 0;
            btnEmprendimientos.Text = "Emprendimientos";
            btnEmprendimientos.UseVisualStyleBackColor = true;
            btnEmprendimientos.Click += btnEmprendimientos_Click;
            // 
            // btnAgenda
            // 
            btnAgenda.Location = new Point(312, 43);
            btnAgenda.Name = "btnAgenda";
            btnAgenda.Size = new Size(173, 98);
            btnAgenda.TabIndex = 1;
            btnAgenda.Text = "Agenda";
            btnAgenda.UseVisualStyleBackColor = true;
            btnAgenda.Click += btnAgenda_Click;
            // 
            // btnGaleria
            // 
            btnGaleria.Location = new Point(52, 213);
            btnGaleria.Name = "btnGaleria";
            btnGaleria.Size = new Size(173, 98);
            btnGaleria.TabIndex = 2;
            btnGaleria.Text = "Galeria";
            btnGaleria.UseVisualStyleBackColor = true;
            btnGaleria.Click += btnGaleria_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(312, 213);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(173, 98);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmMenuEstudiante
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 361);
            Controls.Add(btnSalir);
            Controls.Add(btnGaleria);
            Controls.Add(btnAgenda);
            Controls.Add(btnEmprendimientos);
            Name = "FrmMenuEstudiante";
            Text = "FrmMenuEstudiante";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEmprendimientos;
        private Button btnAgenda;
        private Button btnGaleria;
        private Button btnSalir;
    }
}