using AgenciaDeCambioPOO.Datos;
using AgenciaDeCambioPOO.Entidades;
using AgenciaDeCambioPOO.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace AgenciaDeCambioPOO.Windows
{
    public partial class frmVentaDivisa : Form
    {
        private readonly IServiceProvider _serviceProvider;

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
            ComboHelper.CargarDatosCombo<Divisa>(ref cboDivisas, agencia.ObtenerDivisas(), "Nombre", "Abreviatura");
        }
    }
}
