namespace Presentacion
{
    partial class FrmPremiaciones
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
            btnExportarPDF = new Button();
            btnAgregar = new Button();
            txtIdEmprendimiento = new TextBox();
            label3 = new Label();
            txtPuesto = new TextBox();
            label2 = new Label();
            txtCategoria = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExportarPDF);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(txtIdEmprendimiento);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPuesto);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtCategoria);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(38, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(501, 487);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Premiacion";
            // 
            // btnExportarPDF
            // 
            btnExportarPDF.Location = new Point(173, 417);
            btnExportarPDF.Name = "btnExportarPDF";
            btnExportarPDF.Size = new Size(145, 34);
            btnExportarPDF.TabIndex = 7;
            btnExportarPDF.Text = "Exportar PDF";
            btnExportarPDF.UseVisualStyleBackColor = true;
            btnExportarPDF.Click += btnExportarPDF_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(185, 336);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Guardar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtIdEmprendimiento
            // 
            txtIdEmprendimiento.Location = new Point(248, 260);
            txtIdEmprendimiento.Name = "txtIdEmprendimiento";
            txtIdEmprendimiento.Size = new Size(150, 31);
            txtIdEmprendimiento.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 260);
            label3.Name = "label3";
            label3.Size = new Size(169, 25);
            label3.TabIndex = 4;
            label3.Text = "Id Emprendimeinto:";
            // 
            // txtPuesto
            // 
            txtPuesto.Location = new Point(147, 177);
            txtPuesto.Name = "txtPuesto";
            txtPuesto.Size = new Size(150, 31);
            txtPuesto.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 177);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 2;
            label2.Text = "Puesto:";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(157, 90);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(150, 31);
            txtCategoria.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 90);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 0;
            label1.Text = "Categoria:";
            // 
            // FrmPremiaciones
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 560);
            Controls.Add(groupBox1);
            Name = "FrmPremiaciones";
            Text = "FrmPremiaciones";
            Load += FrmPremiaciones_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAgregar;
        private TextBox txtIdEmprendimiento;
        private Label label3;
        private TextBox txtPuesto;
        private Label label2;
        private TextBox txtCategoria;
        private Label label1;
        private Button btnExportarPDF;
    }
}