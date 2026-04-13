using Datos;
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
    public partial class FrmAdminMenu : Form
    {
        public FrmAdminMenu()
        {
            InitializeComponent();
        }

        private void btnEmprendimientos_Click(object sender, EventArgs e)
        {
            FrmEmprendimientos frm = new FrmEmprendimientos();
            frm.ShowDialog();
        }

        private void btnParticipantes_Click(object sender, EventArgs e)
        {
            FrmParticipantes frm = new FrmParticipantes();
            frm.ShowDialog();
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            FrmEventos frm = new FrmEventos();
            frm.ShowDialog();
        }

        private void btnPremiaciones_Click(object sender, EventArgs e)
        {
            FrmPremiaciones frm = new FrmPremiaciones();
            frm.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
        "¿Desea salir del módulo estudiante?",
        "Confirmar",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                new FrmLogin().Show();
            }
        }

        private void btnPruebaBD_Click(object sender, EventArgs e)
        {

        }

        private void FrmAdminMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
