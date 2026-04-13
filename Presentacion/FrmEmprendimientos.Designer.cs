namespace Presentacion
{
    partial class FrmEmprendimientos
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
            groupBox1 = new GroupBox();
            label5 = new Label();
            pbFoto = new PictureBox();
            btnAgregarFoto = new Button();
            txtDescripcion = new TextBox();
            txtRubro = new TextBox();
            txtFacultad = new TextBox();
            label4 = new Label();
            label2 = new Label();
            txtBuscar = new TextBox();
            btnListar = new Button();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            btnAgregar = new Button();
            txtNombre = new TextBox();
            label3 = new Label();
            label1 = new Label();
            dgvEmprendimientos = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmprendimientos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(pbFoto);
            groupBox1.Controls.Add(btnAgregarFoto);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(txtRubro);
            groupBox1.Controls.Add(txtFacultad);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtBuscar);
            groupBox1.Controls.Add(btnListar);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(22, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(961, 317);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestion de Emprendimientos";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(609, 210);
            label5.Name = "label5";
            label5.Size = new Size(326, 25);
            label5.TabIndex = 21;
            label5.Text = "Buscar por nombre de emprendimeinto";
            label5.Click += label5_Click;
            // 
            // pbFoto
            // 
            pbFoto.Location = new Point(329, 94);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(217, 160);
            pbFoto.TabIndex = 20;
            pbFoto.TabStop = false;
            pbFoto.Click += pbFoto_Click;
            // 
            // btnAgregarFoto
            // 
            btnAgregarFoto.Location = new Point(378, 44);
            btnAgregarFoto.Name = "btnAgregarFoto";
            btnAgregarFoto.Size = new Size(112, 34);
            btnAgregarFoto.TabIndex = 19;
            btnAgregarFoto.Text = "foto";
            btnAgregarFoto.UseVisualStyleBackColor = true;
            btnAgregarFoto.Click += btnAgregarFoto_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(609, 63);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(289, 128);
            txtDescripcion.TabIndex = 5;
            // 
            // txtRubro
            // 
            txtRubro.Location = new Point(154, 160);
            txtRubro.Name = "txtRubro";
            txtRubro.Size = new Size(150, 31);
            txtRubro.TabIndex = 18;
            // 
            // txtFacultad
            // 
            txtFacultad.Location = new Point(154, 106);
            txtFacultad.Name = "txtFacultad";
            txtFacultad.Size = new Size(150, 31);
            txtFacultad.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 166);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 16;
            label4.Text = "Rubro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 106);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 15;
            label2.Text = "Facultad";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(609, 263);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(150, 31);
            txtBuscar.TabIndex = 14;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(167, 260);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(112, 34);
            btnListar.TabIndex = 13;
            btnListar.Text = "listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(809, 260);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 34);
            btnBuscar.TabIndex = 12;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(311, 260);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 34);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(38, 260);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(154, 50);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(614, 27);
            label3.Name = "label3";
            label3.Size = new Size(108, 25);
            label3.TabIndex = 2;
            label3.Text = "Descripcion:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 49);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // dgvEmprendimientos
            // 
            dgvEmprendimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmprendimientos.Location = new Point(60, 376);
            dgvEmprendimientos.Name = "dgvEmprendimientos";
            dgvEmprendimientos.RowHeadersWidth = 62;
            dgvEmprendimientos.Size = new Size(860, 225);
            dgvEmprendimientos.TabIndex = 1;
            dgvEmprendimientos.CellContentClick += dgvEmprendimientos_CellContentClick;
            // 
            // FrmEmprendimientos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 669);
            Controls.Add(dgvEmprendimientos);
            Controls.Add(groupBox1);
            Name = "FrmEmprendimientos";
            Text = "FrmEmprendimientos";
            Load += FrmEmprendimientos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmprendimientos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label1;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private Button btnLimpiar;
        private Button btnAgregar;
        private DataGridView dgvEmprendimientos;
        private Button btnListar;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Label label4;
        private Label label2;
        private TextBox txtRubro;
        private TextBox txtFacultad;
        private Button btnAgregarFoto;
        private PictureBox pbFoto;
        private Label label5;
    }
}