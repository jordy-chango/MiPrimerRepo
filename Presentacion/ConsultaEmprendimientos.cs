using Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace Presentacion
{
    public partial class ConsultaEmprendimientos : Form
    {
        public ConsultaEmprendimientos()
        {
            InitializeComponent();
        }
        private EmprendimientoControlador controlador = new EmprendimientoControlador();


        private void ConsultaEmprendimientos_Load(object sender, EventArgs e)
        {
            dgvEmprendimientos.DataSource = controlador.Listar();
            dgvEmprendimientos.ReadOnly = true;
            dgvEmprendimientos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvEmprendimientos.Columns["Foto"].Visible = false;
            dgvEmprendimientos.Columns["Descripcion"].Visible = false;

            try
            {
                dgvEmprendimientos.DataSource = controlador.Listar();

                // OCULTAR ID
                dgvEmprendimientos.Columns["Id"].Visible = false;

                // Opcional: mejorar nombres
                dgvEmprendimientos.Columns["Nombre"].HeaderText = "Emprendimiento";
                dgvEmprendimientos.Columns["Facultad"].HeaderText = "Facultad";
                dgvEmprendimientos.Columns["Rubro"].HeaderText = "Rubro";
                dgvEmprendimientos.Columns["Descripcion"].HeaderText = "Descripción";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar emprendimientos");
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (dgvEmprendimientos.CurrentRow == null) return;

            Emprendimiento emp =
                dgvEmprendimientos.CurrentRow.DataBoundItem as Emprendimiento;

            new FrmDetalleEmprendimiento(emp).ShowDialog();
        }
    }
}
