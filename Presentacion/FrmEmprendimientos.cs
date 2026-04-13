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
    public partial class FrmEmprendimientos : Form
    {
        private EmprendimientoControlador controlador = new EmprendimientoControlador();
        private int idSeleccionado = 0;
        private string rutaFoto = "";

        public FrmEmprendimientos()
        {
            InitializeComponent();
            CargarTabla();
        }
        private void PrepararGrid()
        {
            dgvEmprendimientos.RowTemplate.Height = 80;
            dgvEmprendimientos.AutoGenerateColumns = true;

            if (dgvEmprendimientos.Columns["Foto"] != null)
                dgvEmprendimientos.Columns["Foto"].Visible = false;

            if (!dgvEmprendimientos.Columns.Contains("FotoImg"))
            {
                DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                imgCol.Name = "FotoImg";
                imgCol.HeaderText = "Foto";
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imgCol.ReadOnly = true;

                dgvEmprendimientos.Columns.Insert(0, imgCol);
            }
        }

        private void CargarImagenesEnGrid()
        {
            foreach (DataGridViewRow row in dgvEmprendimientos.Rows)
            {
                if (row.IsNewRow) continue;

                Emprendimiento emp = row.DataBoundItem as Emprendimiento;

                if (emp != null && emp.Foto != null)
                {
                    row.Cells["FotoImg"].Value = UtilImagen.BytesAImagen(emp.Foto);
                }
                else
                {
                    row.Cells["FotoImg"].Value = null;
                }
            }
        }
        private void CargarTabla()
        {
            dgvEmprendimientos.DataSource = null;
            dgvEmprendimientos.DataSource = controlador.Listar();
            PrepararGrid();
            CargarImagenesEnGrid();


            if (dgvEmprendimientos.Columns["Foto"] != null)
            {
                dgvEmprendimientos.Columns["Foto"].Visible = false;
            }

            if (!dgvEmprendimientos.Columns.Contains("FotoImg"))
            {
                DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                imgCol.Name = "FotoImg";
                imgCol.HeaderText = "Foto";
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imgCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                imgCol.ReadOnly = true;
                imgCol.DataPropertyName = null;

                dgvEmprendimientos.Columns.Insert(0, imgCol);
            }

            foreach (DataGridViewRow row in dgvEmprendimientos.Rows)
            {
                if (row.IsNewRow) continue;

                Emprendimiento emp = row.DataBoundItem as Emprendimiento;

                if (emp != null && emp.Foto != null)
                {
                    row.Cells["FotoImg"].Value = UtilImagen.BytesAImagen(emp.Foto);
                }
            }

            dgvEmprendimientos.RowTemplate.Height = 80;
            dgvEmprendimientos.RowTemplate.Height = 80;
            dgvEmprendimientos.Columns["FotoImg"].Width = 80;
            CargarImagenesEnGrid();
        }
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtFacultad.Clear();
            txtRubro.Clear();
            txtDescripcion.Clear();
            txtBuscar.Clear();
        }

        private bool ValidarEmprendimiento()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre del emprendimiento");
                txtNombre.Focus();
                return false;
            }

            if (txtNombre.Text.Length < 3)
            {
                MessageBox.Show("El nombre es muy corto");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtFacultad.Text))
            {
                MessageBox.Show("Ingrese la facultad");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtRubro.Text))
            {
                MessageBox.Show("Ingrese el rubro");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Ingrese la descripción");
                return false;
            }

            if (pbFoto.Image == null)
            {
                MessageBox.Show("Debe seleccionar una foto");
                return false;
            }

            return true;
        }


        private void FrmEmprendimientos_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarEmprendimiento()) return;

            try
            {
                controlador.Agregar(
                    txtNombre.Text,
                    txtFacultad.Text,
                    txtRubro.Text,
                    txtDescripcion.Text,
                    pbFoto.Image
                );

                MessageBox.Show("Emprendimiento registrado correctamente");
                CargarTabla();
                LimpiarCampos();
                pbFoto.Image = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }




        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtFacultad.Clear();
            txtRubro.Clear();
            txtDescripcion.Clear();
            txtBuscar.Clear();
        }

        private void dgvEmprendimientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Emprendimiento fila =
                    dgvEmprendimientos.Rows[e.RowIndex].DataBoundItem as Emprendimiento;

                if (fila == null) return;

                idSeleccionado = fila.Id;

                txtNombre.Text = fila.Nombre;
                txtFacultad.Text = fila.Facultad;
                txtRubro.Text = fila.Rubro;
                txtDescripcion.Text = fila.Descripcion;

                if (fila.Foto != null)
                {
                    pbFoto.Image = UtilImagen.BytesAImagen(fila.Foto);
                    pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pbFoto.Image = null;
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvEmprendimientos.DataSource = controlador.BuscarPorNombre(txtBuscar.Text);

            PrepararGrid();
            CargarImagenesEnGrid();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void btnAgregarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imágenes|*.jpg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbFoto.Image = Image.FromFile(ofd.FileName);
            }

           
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pbFoto_Click(object sender, EventArgs e)
        {

        }
    }
}
