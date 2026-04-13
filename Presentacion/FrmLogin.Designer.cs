namespace Presentacion
{
    partial class FrmLogin
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
            rbAdmin = new RadioButton();
            rbEstudiante = new RadioButton();
            txtClave = new TextBox();
            btnIngresar = new Button();
            SuspendLayout();
            // 
            // rbAdmin
            // 
            rbAdmin.AutoSize = true;
            rbAdmin.Location = new Point(75, 65);
            rbAdmin.Name = "rbAdmin";
            rbAdmin.Size = new Size(151, 29);
            rbAdmin.TabIndex = 0;
            rbAdmin.TabStop = true;
            rbAdmin.Text = "Administrador";
            rbAdmin.UseVisualStyleBackColor = true;
            // 
            // rbEstudiante
            // 
            rbEstudiante.AutoSize = true;
            rbEstudiante.Location = new Point(75, 128);
            rbEstudiante.Name = "rbEstudiante";
            rbEstudiante.Size = new Size(119, 29);
            rbEstudiante.TabIndex = 1;
            rbEstudiante.TabStop = true;
            rbEstudiante.Text = "Estudiante";
            rbEstudiante.UseVisualStyleBackColor = true;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(246, 65);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(150, 31);
            txtClave.TabIndex = 2;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(182, 214);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(112, 34);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 275);
            Controls.Add(btnIngresar);
            Controls.Add(txtClave);
            Controls.Add(rbEstudiante);
            Controls.Add(rbAdmin);
            Name = "FrmLogin";
            Text = "FrmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbAdmin;
        private RadioButton rbEstudiante;
        private TextBox txtClave;
        private Button btnIngresar;
    }
}