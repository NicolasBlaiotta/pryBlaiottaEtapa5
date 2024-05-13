namespace pryBlaiottaEtapa5
{
    public partial class Form1 : Form
    {
        ClsVehiculo objVehiculo;

        public Form1()
        {
            InitializeComponent();
            objVehiculo = new ClsVehiculo();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            objVehiculo.crearVehiculo(pctVehiculo);
        }
    }
}