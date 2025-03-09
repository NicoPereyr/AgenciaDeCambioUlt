using AgenciaDeCambioPOO.Datos;
using AgenciaDeCambioPOO.Entidades;
using AgenciaDeCambioPOO.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace AgenciaDeCambioPOO.Windows
{
    public partial class frmAgencia : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public frmAgencia(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;

        }

        private void dgvDivisas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tsbNuevaDivisa_Click(object sender, EventArgs e)
        {

        }

        private void frmAgencia_Load(object sender, EventArgs e)
        {
            AgenciaDeCambio agencia = _serviceProvider.GetService<AgenciaDeCambio>()!;
            GridHelper.MostrarDatosEnGrilla<Divisa>(agencia.ObtenerDivisas(), dgvDivisas);
        }

        private void tsbVenta_Click(object sender, EventArgs e)
        {
            frmVentaDivisa frm = new frmVentaDivisa(_serviceProvider);
            frm.ShowDialog();
        }
    }
}
