namespace Presentacion
{
    partial class FrmAgendaEventos
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
            dtpFecha = new DateTimePicker();
            btnFiltrar = new Button();
            dgvEventos = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEventos).BeginInit();
            SuspendLayout();
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(65, 89);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(300, 31);
            dtpFecha.TabIndex = 0;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(411, 89);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(112, 34);
            btnFiltrar.TabIndex = 1;
            btnFiltrar.Text = "Buscar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // dgvEventos
            // 
            dgvEventos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEventos.Location = new Point(65, 152);
            dgvEventos.Name = "dgvEventos";
            dgvEventos.RowHeadersWidth = 62;
            dgvEventos.Size = new Size(621, 225);
            dgvEventos.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 45);
            label1.Name = "label1";
            label1.Size = new Size(222, 25);
            label1.TabIndex = 3;
            label1.Text = "Buscar eventos por fechas:";
            // 
            // FrmAgendaEventos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 450);
            Controls.Add(label1);
            Controls.Add(dgvEventos);
            Controls.Add(btnFiltrar);
            Controls.Add(dtpFecha);
            Name = "FrmAgendaEventos";
            Text = "FrmAgendaEventos";
            Load += FrmAgendaEventos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEventos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFecha;
        private Button btnFiltrar;
        private DataGridView dgvEventos;
        private Label label1;
    }
}