using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (rbAdmin.Checked)
            {
                if (txtClave.Text == "j123456") 
                {
                    FrmAdminMenu frm = new FrmAdminMenu();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
            }
            else if (rbEstudiante.Checked)
            {
                FrmMenuEstudiante frm = new FrmMenuEstudiante();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Seleccione un rol");
            }
        }
    }
}
