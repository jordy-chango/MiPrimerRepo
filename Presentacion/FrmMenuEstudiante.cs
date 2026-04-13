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
    public partial class FrmMenuEstudiante : Form
    {
        public FrmMenuEstudiante()
        {
            InitializeComponent();
        }

        private void btnEmprendimientos_Click(object sender, EventArgs e)
        {
            new ConsultaEmprendimientos().ShowDialog();
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            new FrmAgendaEventos().ShowDialog();
        }

        private void btnGaleria_Click(object sender, EventArgs e)
        {
            new FrmGaleriaFotos().ShowDialog();
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
    }
}
