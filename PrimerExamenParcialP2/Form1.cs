using DataCliente;

namespace PrimerExamenParcialP2
{
    public partial class Form1 : Form
    {
        FileDB archivo = new FileDB();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtIDCliente.Enabled = false;
            txtCedula.Enabled = false;
            txtPrimerNombre.Enabled = false;
            txtSegundoNombre.Enabled = false;
            txtPrimerApellido.Enabled = false;
            txtSegundoApellido.Enabled = false;
            txtCorreo.Enabled = false;
            CBDepartamento.Enabled = false;
            txtDireccion.Enabled = false;
            txtTelefono.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnImprimir.Enabled = true;
            btnBuscar.Enabled = true;
            CBDepartamentoBuscar.Enabled = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtIDCliente.Enabled = true;
            txtCedula.Enabled = true;
            txtPrimerNombre.Enabled = true;
            txtSegundoNombre.Enabled = true;
            txtPrimerApellido.Enabled = true;
            txtSegundoApellido.Enabled = true;
            txtCorreo.Enabled = true;
            CBDepartamento.Enabled = true;
            txtDireccion.Enabled = true;
            txtTelefono.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnImprimir.Enabled = false;
            btnBuscar.Enabled = false;
            CBDepartamentoBuscar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarProducto();
        }

        public void GuardarProducto()
        {
            Cliente c = new Cliente();
            c.IDCliente = Convert.ToInt32(txtIDCliente.Text);
            c.Cedula = Convert.ToString(txtCedula.Text);
            c.PrimerNombre = Convert.ToString(txtPrimerNombre.Text);
            c.SegundoNombre = Convert.ToString(txtSegundoNombre.Text);
            c.PrimerApellido = Convert.ToString(txtPrimerApellido.Text);
            c.SegundoApellido = Convert.ToString(txtSegundoApellido.Text);
            c.Correo = Convert.ToString(txtCorreo.Text);
            c.Departamento = Convert.ToString(CBDepartamento.Text);
            c.Direccion = Convert.ToString(txtDireccion.Text);
            c.Telefono = Convert.ToString(txtTelefono.Text);

            archivo.AddCliente(c);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}