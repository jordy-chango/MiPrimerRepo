namespace Presentacion
{
    partial class FrmAdminMenu
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
            btnParticipantes = new Button();
            btnEventos = new Button();
            btnPremiaciones = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnEmprendimientos
            // 
            btnEmprendimientos.Location = new Point(51, 58);
            btnEmprendimientos.Name = "btnEmprendimientos";
            btnEmprendimientos.Size = new Size(224, 106);
            btnEmprendimientos.TabIndex = 0;
            btnEmprendimientos.Text = "Emprendimientos";
            btnEmprendimientos.UseVisualStyleBackColor = true;
            btnEmprendimientos.Click += btnEmprendimientos_Click;
            // 
            // btnParticipantes
            // 
            btnParticipantes.Location = new Point(337, 58);
            btnParticipantes.Name = "btnParticipantes";
            btnParticipantes.Size = new Size(224, 106);
            btnParticipantes.TabIndex = 1;
            btnParticipantes.Text = "Participantes";
            btnParticipantes.UseVisualStyleBackColor = true;
            btnParticipantes.Click += btnParticipantes_Click;
            // 
            // btnEventos
            // 
            btnEventos.Location = new Point(51, 218);
            btnEventos.Name = "btnEventos";
            btnEventos.Size = new Size(224, 106);
            btnEventos.TabIndex = 2;
            btnEventos.Text = "Eventos";
            btnEventos.UseVisualStyleBackColor = true;
            btnEventos.Click += btnEventos_Click;
            // 
            // btnPremiaciones
            // 
            btnPremiaciones.Location = new Point(337, 218);
            btnPremiaciones.Name = "btnPremiaciones";
            btnPremiaciones.Size = new Size(224, 106);
            btnPremiaciones.TabIndex = 3;
            btnPremiaciones.Text = "Premiaciones";
            btnPremiaciones.UseVisualStyleBackColor = true;
            btnPremiaciones.Click += btnPremiaciones_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(248, 365);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmAdminMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnPremiaciones);
            Controls.Add(btnEventos);
            Controls.Add(btnParticipantes);
            Controls.Add(btnEmprendimientos);
            Name = "FrmAdminMenu";
            Text = "FrmAdminMenu";
            Load += FrmAdminMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnEmprendimientos;
        private Button btnParticipantes;
        private Button btnEventos;
        private Button btnPremiaciones;
        private Button btnSalir;
    }
}