using DataCliente;
using System.Data;

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
            GuardarCliente();
            CargarLista();
            MessageBox.Show("Se guardo el registro en Lista", "Información");
        }

        public void GuardarCliente()
        {
            Cliente cliente = new Cliente();
            cliente.IDCliente = Convert.ToInt32(this.txtIDCliente.Text);
            cliente.Cedula = this.txtCedula.Text;
            cliente.PrimerNombre = this.txtPrimerNombre.Text;
            cliente.SegundoNombre = this.txtSegundoNombre.Text;
            cliente.PrimerApellido = this.txtPrimerApellido.Text;
            cliente.SegundoApellido = this.txtSegundoApellido.Text;
            cliente.Correo = this.txtCorreo.Text;
            cliente.Departamento = this.CBDepartamento.Text;
            cliente.Direccion = this.txtDireccion.Text;
            cliente.Telefono = this.txtTelefono.Text;

            archivo.AddCliente(cliente);
        }

        public void CargarLista()
        {
            this.dataCliente.Columns.Clear();
            DataTable lista = new DataTable();
            lista.Columns.Add("Id Cliente");
            lista.Columns.Add("Cédula");
            lista.Columns.Add("1er Nombre");
            lista.Columns.Add("2do Nombre");
            lista.Columns.Add("1er Apellido");
            lista.Columns.Add("2do Apellido");
            lista.Columns.Add("Correo");
            lista.Columns.Add("Departamento");
            lista.Columns.Add("Dirección");
            lista.Columns.Add("Teléfono");

            this.archivo.PrintCliente().ForEach(delegate (Cliente c)
            {
                lista.Rows.Add(new Object[]
                {
                    c.IDCliente,
                    c.Cedula,
                    c.PrimerNombre,
                    c.SegundoNombre,
                    c.PrimerApellido,
                    c.SegundoApellido,
                    c.Correo,
                    c.Departamento,
                    c.Direccion,
                    c.Telefono
                });
            });
            this.dataCliente.DataSource = lista;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
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
    }
}