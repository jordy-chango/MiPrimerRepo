namespace Presentacion
{
    partial class FrmParticipantes
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
            btnAgregar = new Button();
            btnSeleccionarFoto = new Button();
            pbFoto = new PictureBox();
            label4 = new Label();
            txtCargo = new TextBox();
            label3 = new Label();
            txtNombres = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cbEmprendimiento = new ComboBox();
            openFileDialog = new OpenFileDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFoto).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(btnSeleccionarFoto);
            groupBox1.Controls.Add(pbFoto);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtCargo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNombres);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbEmprendimiento);
            groupBox1.Location = new Point(50, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(486, 524);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Participantes";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(160, 445);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Guardar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnSeleccionarFoto
            // 
            btnSeleccionarFoto.Location = new Point(121, 374);
            btnSeleccionarFoto.Name = "btnSeleccionarFoto";
            btnSeleccionarFoto.Size = new Size(194, 34);
            btnSeleccionarFoto.TabIndex = 8;
            btnSeleccionarFoto.Text = "Seleccionar foto";
            btnSeleccionarFoto.UseVisualStyleBackColor = true;
            btnSeleccionarFoto.Click += btnSeleccionarFoto_Click;
            // 
            // pbFoto
            // 
            pbFoto.Location = new Point(140, 272);
            pbFoto.Name = "pbFoto";
            pbFoto.Size = new Size(150, 75);
            pbFoto.TabIndex = 7;
            pbFoto.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 281);
            label4.Name = "label4";
            label4.Size = new Size(53, 25);
            label4.TabIndex = 6;
            label4.Text = "Foto:";
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(140, 213);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(150, 31);
            txtCargo.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 213);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 4;
            label3.Text = "Cargo:";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(140, 144);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(150, 31);
            txtNombres.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 142);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 2;
            label2.Text = "Nombres:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 65);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 1;
            label1.Text = "Emprendimientos:";
            // 
            // cbEmprendimiento
            // 
            cbEmprendimiento.FormattingEnabled = true;
            cbEmprendimiento.Location = new Point(217, 62);
            cbEmprendimiento.Name = "cbEmprendimiento";
            cbEmprendimiento.Size = new Size(182, 33);
            cbEmprendimiento.TabIndex = 0;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // FrmParticipantes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 608);
            Controls.Add(groupBox1);
            Name = "FrmParticipantes";
            Text = "FrmParticipantes";
            Load += FrmParticipantes_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private ComboBox cbEmprendimiento;
        private TextBox txtCargo;
        private Label label3;
        private TextBox txtNombres;
        private Button btnAgregar;
        private Button btnSeleccionarFoto;
        private PictureBox pbFoto;
        private Label label4;
        private OpenFileDialog openFileDialog;
    }
}