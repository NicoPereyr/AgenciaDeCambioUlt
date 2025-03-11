using AgenciaDeCambioPOO.Datos;
using AgenciaDeCambioPOO.Entidades;
using AgenciaDeCambioPOO.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace AgenciaDeCambioPOO.Windows
{
    public partial class frmCompraDivisa : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private Divisa? divisaSeleccionada = null;
        private Compra? compra = null;

        public frmCompraDivisa(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void frmCompraDivisa_Load(object sender, EventArgs e)
        {
            txtFechaOperacion.Text = DateTime.Now.ToShortDateString();
            AgenciaDeCambio agencia = _serviceProvider.GetService<AgenciaDeCambio>()!;
            ComboHelper.CargarDatosCombo<Divisa>(ref cboDivisas,
                agencia.ObtenerDivisas()
                    .OrderBy(d => d.Nombre)
                    .Where(d => d.Abreviatura != "ARS")
                    .ToList()
                , "Nombre", "Abreviatura");
        }

        private void cboDivisas_SelectedIndexChanged(object sender, EventArgs e)
        {
            divisaSeleccionada = cboDivisas.SelectedItem as Divisa;
            nudCantidad.Maximum = 1000;
            MostrarDatosOperacion();
        }

        private void MostrarDatosOperacion()
        {
            txtCotizacion.Text = divisaSeleccionada!.CotizacionCompra.ToString("C");
            txtTotal.Text = (divisaSeleccionada.CotizacionCompra * nudCantidad.Value).ToString("C");
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            MostrarDatosOperacion();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            compra = new Compra(divisaSeleccionada!, nudCantidad.Value)
            {
                Fecha = DateTime.Now,
                Cotizacion = divisaSeleccionada!.CotizacionCompra
            };
            MessageBox.Show($"{compra.MostrarTransaccion()}", "Compra",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }

        public Compra? GetCompra()
        {
            return compra;
        }
    }
}
