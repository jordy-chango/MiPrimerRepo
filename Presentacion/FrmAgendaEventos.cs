using Controlador;
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
    public partial class FrmAgendaEventos : Form
    {
        public FrmAgendaEventos()
        {
            InitializeComponent();
        }
        EventoControlador controlador = new EventoControlador();
        private void FrmAgendaEventos_Load(object sender, EventArgs e)
        {
            dgvEventos.DataSource = controlador.Listar();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            dgvEventos.DataSource =
        controlador.FiltrarPorFecha(dtpFecha.Value);
        }
    }
}
