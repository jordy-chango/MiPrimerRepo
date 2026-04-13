namespace Presentacion
{
    partial class FrmEventos
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
            dtpHora = new DateTimePicker();
            txtUbicacion = new TextBox();
            label5 = new Label();
            btnAgregar = new Button();
            txtIdEmprendimiento = new TextBox();
            label4 = new Label();
            txtOrden = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dtpFecha = new DateTimePicker();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpHora);
            groupBox1.Controls.Add(txtUbicacion);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(txtIdEmprendimiento);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtOrden);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dtpFecha);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(37, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(513, 531);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Eventos";
            // 
            // dtpHora
            // 
            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.Location = new Point(95, 153);
            dtpHora.Name = "dtpHora";
            dtpHora.ShowUpDown = true;
            dtpHora.Size = new Size(125, 31);
            dtpHora.TabIndex = 11;
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new Point(128, 217);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(150, 31);
            txtUbicacion.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 217);
            label5.Name = "label5";
            label5.Size = new Size(93, 25);
            label5.TabIndex = 9;
            label5.Text = "Ubicacion:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(187, 446);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Guardar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtIdEmprendimiento
            // 
            txtIdEmprendimiento.Location = new Point(228, 353);
            txtIdEmprendimiento.Name = "txtIdEmprendimiento";
            txtIdEmprendimiento.Size = new Size(150, 31);
            txtIdEmprendimiento.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 353);
            label4.Name = "label4";
            label4.Size = new Size(169, 25);
            label4.TabIndex = 6;
            label4.Text = "Id Emprendimeinto:";
            // 
            // txtOrden
            // 
            txtOrden.Location = new Point(119, 277);
            txtOrden.Name = "txtOrden";
            txtOrden.Size = new Size(150, 31);
            txtOrden.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 277);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 4;
            label3.Text = "Orden:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 153);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 2;
            label2.Text = "Hora:";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(101, 80);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(328, 31);
            dtpFecha.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 80);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 0;
            label1.Text = "Fecha:";
            // 
            // FrmEventos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 600);
            Controls.Add(groupBox1);
            Name = "FrmEventos";
            Text = "FrmEventos";
            Load += FrmEventos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private TextBox txtOrden;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpFecha;
        private Label label1;
        private Button btnAgregar;
        private TextBox txtIdEmprendimiento;
        private TextBox txtUbicacion;
        private Label label5;
        private DateTimePicker dtpHora;
    }
}