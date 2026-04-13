namespace Presentacion
{
    partial class FrmGaleriaFotos
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
            cboEmprendimiento = new ComboBox();
            flowGaleria = new FlowLayoutPanel();
            label1 = new Label();
            SuspendLayout();
            // 
            // cboEmprendimiento
            // 
            cboEmprendimiento.FormattingEnabled = true;
            cboEmprendimiento.Location = new Point(158, 118);
            cboEmprendimiento.Name = "cboEmprendimiento";
            cboEmprendimiento.Size = new Size(182, 33);
            cboEmprendimiento.TabIndex = 0;
            cboEmprendimiento.SelectedIndexChanged += cboEmprendimiento_SelectedIndexChanged;
            // 
            // flowGaleria
            // 
            flowGaleria.Location = new Point(130, 196);
            flowGaleria.Name = "flowGaleria";
            flowGaleria.Size = new Size(237, 215);
            flowGaleria.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 56);
            label1.Name = "label1";
            label1.Size = new Size(244, 25);
            label1.TabIndex = 2;
            label1.Text = "Nombre del emprendimiento";
            // 
            // FrmGaleriaFotos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 484);
            Controls.Add(label1);
            Controls.Add(flowGaleria);
            Controls.Add(cboEmprendimiento);
            Name = "FrmGaleriaFotos";
            Text = "FrmGaleriaFotos";
            Load += FrmGaleriaFotos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboEmprendimiento;
        private FlowLayoutPanel flowGaleria;
        private Label label1;
    }
}