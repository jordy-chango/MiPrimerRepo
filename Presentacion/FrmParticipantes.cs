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
    public partial class FrmParticipantes : Form
    {
        private ParticipanteControlador controlador = new ParticipanteControlador();
        private EmprendimientoControlador empControlador = new EmprendimientoControlador();
        private string rutaFoto = "";

        public FrmParticipantes()
        {
            InitializeComponent();
            CargarEmprendimientos();
        }
        private void CargarEmprendimientos()
        {
            cbEmprendimiento.DataSource = empControlador.Listar();
            cbEmprendimiento.DisplayMember = "Nombre";
            cbEmprendimiento.ValueMember = "Id";
        }

        private bool ValidarParticipante()
        {
            if (string.IsNullOrWhiteSpace(txtNombres.Text))
            {
                MessageBox.Show("Ingrese el nombre del participante");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCargo.Text))
            {
                MessageBox.Show("Ingrese el cargo");
                return false;
            }

            if (pbFoto.Image == null)
            {
                MessageBox.Show("Debe seleccionar una foto");
                return false;
            }

            return true;
        }

        private void btnSeleccionarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imágenes|*.jpg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbFoto.Image = Image.FromFile(ofd.FileName);
                pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void Limpiar()
        {
            txtNombres.Clear();
            txtCargo.Clear();
            pbFoto.Image = null;
            rutaFoto = "";
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int idEmp = (int)cbEmprendimiento.SelectedValue;

            if (!ValidarParticipante()) return;
            try
            {
                controlador.Agregar(
                idEmp,
                txtNombres.Text,
                txtCargo.Text,
                pbFoto.Image
            );

                MessageBox.Show("Participante registrado correctamente");
                Limpiar();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void FrmParticipantes_Load(object sender, EventArgs e)
        {

        }
    }
}
