namespace Presentacion
{
    partial class ConsultaEmprendimientos
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
            btnConsultar = new Button();
            dgvEmprendimientos = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmprendimientos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnConsultar);
            groupBox1.Controls.Add(dgvEmprendimientos);
            groupBox1.Location = new Point(35, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(567, 445);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Consultar Emprendimientos";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(224, 384);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(112, 34);
            btnConsultar.TabIndex = 1;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // dgvEmprendimientos
            // 
            dgvEmprendimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmprendimientos.Location = new Point(28, 60);
            dgvEmprendimientos.Name = "dgvEmprendimientos";
            dgvEmprendimientos.RowHeadersWidth = 62;
            dgvEmprendimientos.Size = new Size(509, 297);
            dgvEmprendimientos.TabIndex = 0;
            // 
            // ConsultaEmprendimientos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 524);
            Controls.Add(groupBox1);
            Name = "ConsultaEmprendimientos";
            Text = "ConsultaEmprendimientos";
            Load += ConsultaEmprendimientos_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmprendimientos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvEmprendimientos;
        private Button btnConsultar;
    }
}