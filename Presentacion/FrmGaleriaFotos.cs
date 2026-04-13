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
    public partial class FrmGaleriaFotos : Form
    {
        public FrmGaleriaFotos()
        {
            InitializeComponent();
        }
        private EmprendimientoControlador controlador = new EmprendimientoControlador();
        private void FrmGaleriaFotos_Load(object sender, EventArgs e)
        {
            cboEmprendimiento.DataSource = controlador.Listar();
            cboEmprendimiento.DisplayMember = "Nombre";
            cboEmprendimiento.ValueMember = "Id";
        }

        private void cboEmprendimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowGaleria.Controls.Clear();

            Emprendimiento emp = cboEmprendimiento.SelectedItem as Emprendimiento;

            if (emp?.Foto != null)
            {
                PictureBox pb = new PictureBox();
                pb.Image = UtilImagen.BytesAImagen(emp.Foto);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Width = 150;
                pb.Height = 150;

                flowGaleria.Controls.Add(pb);
            }
        }
    }
}
