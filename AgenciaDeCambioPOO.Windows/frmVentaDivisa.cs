using AgenciaDeCambioPOO.Datos;
using AgenciaDeCambioPOO.Entidades;
using AgenciaDeCambioPOO.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace AgenciaDeCambioPOO.Windows
{
    public partial class frmVentaDivisa : Form
    {
        private readonly IServiceProvider _serviceProvider;

        private Divisa? divisaSeleccionada = null;
        private Venta? venta = null;

        public frmVentaDivisa(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this._serviceProvider = serviceProvider;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void frmVentaDivisa_Load(object sender, EventArgs e)
        {
            txtFechaOperacion.Text = DateTime.Now.ToShortDateString();
            AgenciaDeCambio agencia = _serviceProvider.GetService<AgenciaDeCambio>()!;
            //Lista de divisa
            ComboHelper.CargarDatosCombo<Divisa>(ref cboDivisas,
                agencia.ObtenerDivisas()
                .OrderBy(d => d.Nombre)
                .Where(d => d.Abreviatura != "ARS")
                .ToList(),
                "Nombre", "Abreviatura");
        }

        private void cboDivisas_SelectedIndexChanged(object sender, EventArgs e)
        {
            divisaSeleccionada = cboDivisas.SelectedItem as Divisa;
            nudCantidad.Maximum = divisaSeleccionada!.Cantidad;
            MostrarDatosOperacion();
        }

        private void MostrarDatosOperacion()
        {
            txtCotizacion.Text = divisaSeleccionada!.CotizacionVenta.ToString("C");
            txtTotal.Text = (divisaSeleccionada.CotizacionVenta * nudCantidad.Value).ToString("C");
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            MostrarDatosOperacion();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
             venta = new Venta(divisaSeleccionada!, nudCantidad.Value)
            {
                Fecha = DateTime.Now,
                Cotizacion = divisaSeleccionada!.CotizacionVenta
            };
            MessageBox.Show($"{venta.MostrarTransaccion()}", "Venta",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }
        public Venta? GetVenta()
        {
            return venta;
        }
    }
}
