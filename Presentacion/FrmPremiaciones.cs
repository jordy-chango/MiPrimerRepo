using Controlador;
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
    public partial class FrmPremiaciones : Form
    {
        private PremiadoControlador controlador = new PremiadoControlador();

        public FrmPremiaciones()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            txtCategoria.Clear();
            txtPuesto.Clear();
        }

        private bool ValidarPremiacion()
        {
            if (string.IsNullOrWhiteSpace(txtCategoria.Text))
            {
                MessageBox.Show("Ingrese la categoría");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPuesto.Text))
            {
                MessageBox.Show("Ingrese el puesto");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtIdEmprendimiento.Text))
            {
                MessageBox.Show("Ingrese el Id del Emprendimiento");
                return false;
            }
            return true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarPremiacion()) return;

            try
            {
                controlador.Agregar(
                txtCategoria.Text,
                txtPuesto.Text,
                int.Parse(txtIdEmprendimiento.Text)
            );

            MessageBox.Show("Premiación registrada");
            Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivo PDF|*.pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                StringBuilder sb = new StringBuilder();
                foreach (Premiado p in controlador.Listar())
                {
                    sb.AppendLine($"Categoría: {p.Categoria} - Puesto: {p.Puesto} - Emprendimiento ID: {p.IdEmprendimiento}");
                }

                File.WriteAllText(sfd.FileName, sb.ToString());
                MessageBox.Show("Resultados exportados");
            }
        }

        private void FrmPremiaciones_Load(object sender, EventArgs e)
        {

        }
    }
}
