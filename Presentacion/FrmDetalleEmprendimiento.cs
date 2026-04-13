using Controlador;
using Datos;
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

namespace Presentacion
{
    public partial class FrmDetalleEmprendimiento : Form
    {
        private Emprendimiento emprendimiento;
        public FrmDetalleEmprendimiento(Emprendimiento emp)
        {
            InitializeComponent();
            emprendimiento = emp;
        }

        private void FrmDetalleEmprendimiento_Load(object sender, EventArgs e)
        {
            lblNombre.Text = emprendimiento.Nombre;
            lblDescripcion.Text = emprendimiento.Descripcion;

            if (emprendimiento.Foto != null)
                pbFoto.Image = UtilImagen.BytesAImagen(emprendimiento.Foto);

            dgvParticipantes.DataSource =
                new ParticipanteControlador().Listar(emprendimiento.Id);

            dgvComentarios.DataSource =
                new ComentarioControlador().ListarPorEmprendimiento(emprendimiento.Id);

            dgvParticipantes.Columns["Foto"].Visible = false;

            if (!dgvParticipantes.Columns.Contains("FotoImg"))
               
            {
                DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                imgCol.Name = "FotoImg";
                imgCol.HeaderText = "Foto";
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dgvParticipantes.Columns.Insert(0, imgCol);
            }

            foreach (DataGridViewRow row in dgvParticipantes.Rows)
            {
                Participante p = row.DataBoundItem as Participante;

                if (p != null && p.Foto != null)
                {
                    row.Cells["FotoImg"].Value =
                        UtilImagen.BytesAImagen(p.Foto);
                }
            }

           
            if (dgvParticipantes.Columns["Id"] != null)
                dgvParticipantes.Columns["Id"].Visible = false;

            if (dgvParticipantes.Columns["IdEmprendimiento"] != null)
                dgvParticipantes.Columns["IdEmprendimiento"].Visible = false;

            if (dgvComentarios.Columns["IdEmprendimiento"] != null)
                dgvComentarios.Columns["IdEmprendimiento"].Visible = false;

            

        }

        private void btnComentar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtComentario.Text)) return;

            new ComentarioControlador()
                .Agregar(emprendimiento.Id, txtComentario.Text);

            dgvComentarios.DataSource =
                new ComentarioControlador()
                .ListarPorEmprendimiento(emprendimiento.Id);

            txtComentario.Clear();
        }
    }
}
