namespace Presentacion
{
    partial class FrmDetalleEmprendimiento
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
            lblNombre = new Label();
            lblDescripcion = new Label();
            pbFoto = new PictureBox();
            dgvParticipantes = new DataGridView();
            dgvComentarios = new DataGridView();
            txtComentario = new TextBox();
            btnComentar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvParticipantes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvComentarios).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(58, 260);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(59, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "label1";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(58, 327);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(59, 25);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "label2";
            // 
            // pbFoto
            // 
            pbFoto.Location = new Point(423, 12);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(235, 211);
            pbFoto.TabIndex = 2;
            pbFoto.TabStop = false;
            // 
            // dgvParticipantes
            // 
            dgvParticipantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParticipantes.Location = new Point(554, 255);
            dgvParticipantes.Name = "dgvParticipantes";
            dgvParticipantes.RowHeadersWidth = 62;
            dgvParticipantes.Size = new Size(512, 183);
            dgvParticipantes.TabIndex = 3;
            // 
            // dgvComentarios
            // 
            dgvComentarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComentarios.Location = new Point(554, 484);
            dgvComentarios.Name = "dgvComentarios";
            dgvComentarios.RowHeadersWidth = 62;
            dgvComentarios.Size = new Size(354, 225);
            dgvComentarios.TabIndex = 4;
            // 
            // txtComentario
            // 
            txtComentario.Location = new Point(47, 471);
            txtComentario.Multiline = true;
            txtComentario.Name = "txtComentario";
            txtComentario.Size = new Size(259, 141);
            txtComentario.TabIndex = 5;
            // 
            // btnComentar
            // 
            btnComentar.Location = new Point(117, 635);
            btnComentar.Name = "btnComentar";
            btnComentar.Size = new Size(111, 37);
            btnComentar.TabIndex = 6;
            btnComentar.Text = "Comentar";
            btnComentar.UseVisualStyleBackColor = true;
            btnComentar.Click += btnComentar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 413);
            label1.Name = "label1";
            label1.Size = new Size(196, 25);
            label1.TabIndex = 7;
            label1.Text = "Dejanos tu comentario:";
            // 
            // FrmDetalleEmprendimiento
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 733);
            Controls.Add(label1);
            Controls.Add(btnComentar);
            Controls.Add(txtComentario);
            Controls.Add(dgvComentarios);
            Controls.Add(dgvParticipantes);
            Controls.Add(pbFoto);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNombre);
            Name = "FrmDetalleEmprendimiento";
            Text = "FrmDetalleEmprendimiento";
            Load += FrmDetalleEmprendimiento_Load;
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvParticipantes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvComentarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblDescripcion;
        private PictureBox pbFoto;
        private DataGridView dgvParticipantes;
        private DataGridView dgvComentarios;
        private TextBox txtComentario;
        private Button btnComentar;
        private Label label1;
    }
}