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


        private void frmAgencia_Load(object sender, EventArgs e)
        {
            AgenciaDeCambio agencia = _serviceProvider.GetService<AgenciaDeCambio>()!;
            GridHelper.MostrarDatosEnGrilla<Divisa>(agencia.ObtenerDivisas(), dgvDivisas);
            GridHelper.MostrarDatosEnGrilla<Transaccion>(agencia.ObtenerTransacciones(), dgvOperaciones);

        }

        private void tsbVenta_Click(object sender, EventArgs e)
        {
            frmVentaDivisa frm = new frmVentaDivisa(_serviceProvider);
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.Cancel) return;
            Venta? venta = frm.GetVenta();
            if (venta == null) return;
            AgenciaDeCambio agencia = _serviceProvider.GetRequiredService<AgenciaDeCambio>()!;
            agencia.GuardarTransaccion(venta);
            DataGridViewRow r = GridHelper.ConstruirFila(dgvOperaciones);
            GridHelper.SetearFila(r, venta);
            GridHelper.AgregarFila(r, dgvOperaciones);
            GridHelper.MostrarDatosEnGrilla<Divisa>(agencia.ObtenerDivisas(), dgvDivisas);

        }

        private void tsbCompra_Click(object sender, EventArgs e)
        {
            frmCompraDivisa frm = new frmCompraDivisa(_serviceProvider);
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.Cancel) return;
            Compra? compra = frm.GetCompra();
            if (compra == null) return;
            AgenciaDeCambio agencia = _serviceProvider.GetRequiredService<AgenciaDeCambio>()!;
            agencia.GuardarTransaccion(compra);
            DataGridViewRow r = GridHelper.ConstruirFila(dgvOperaciones);
            GridHelper.SetearFila(r, compra);
            GridHelper.AgregarFila(r, dgvOperaciones);
            GridHelper.MostrarDatosEnGrilla<Divisa>(agencia.ObtenerDivisas(), dgvDivisas);
        }
    }
}
