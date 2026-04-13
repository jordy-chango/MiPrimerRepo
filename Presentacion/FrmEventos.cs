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
    public partial class FrmEventos : Form
    {
        private EventoControlador controlador = new EventoControlador();
        public FrmEventos()
        {
            InitializeComponent();
        }

        private bool ValidarEvento()
        {
            if (dtpFecha.Value.Date < DateTime.Today)
            {
                MessageBox.Show("La fecha no puede ser anterior a hoy");
                return false;
            }

            if (string.IsNullOrWhiteSpace(dtpHora.Text))
            {
                MessageBox.Show("Ingrese la hora");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtUbicacion.Text))
            {
                MessageBox.Show("Ingrese la ubicación");
                return false;
            }

            if (!int.TryParse(txtOrden.Text, out int orden) || orden <= 0)
            {
                MessageBox.Show("Orden inválido");
                return false;
            }

            return true;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarEvento()) return;
            try
            {
                controlador.Agregar(
               dtpFecha.Value,
               dtpHora.Text,
               txtUbicacion.Text,
               int.Parse(txtOrden.Text),
               int.Parse(txtIdEmprendimiento.Text)


             );

                MessageBox.Show("Evento registrado");
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar evento: " + ex.Message);
            }
        }

        private void Limpiar()
        {
           
            txtUbicacion.Clear();
            txtOrden.Clear();
        }

        private void FrmEventos_Load(object sender, EventArgs e)
        {

        }
    }
}
