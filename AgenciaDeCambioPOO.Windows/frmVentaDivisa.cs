namespace AgenciaDeCambioPOO.Windows
{
    public partial class frmVentaDivisa : Form
    {
        private readonly IServiceProvider serviceProvider;

        public frmVentaDivisa(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.serviceProvider = serviceProvider;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void frmVentaDivisa_Load(object sender, EventArgs e)
        {
            txtFechaOperacion.Text = DateTime.Now.ToShortDateString();
        }
    }
}
