using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiaraMoncada
{
    public partial class SegundoFormulario : Form
    {
        public SegundoFormulario()
        {
            InitializeComponent();
        }

        //Array
        string[,] ListaCompra = new string[200, 5];
        int Fila = 0;

        private void AgregarButton_Click(object sender, EventArgs e)
        {

            //Validación 
            if (ProductoTextBox.Text == "")
            {
                errorProvider1.SetError(ProductoTextBox, "Ingrese un producto");
                return;
            }

            if (PrecioUnitarioTextBox.Text == "")
            {
                errorProvider1.SetError(PrecioUnitarioTextBox, "Ingrese precio del producto");
                return;
            }

            if (CantidadTextBox.Text == "")
            {
                errorProvider1.SetError(CantidadTextBox, "Ingrese cantidad de producto");
                return;
            }

            //Limpiar errores 
            errorProvider1.Clear();

            ListaCompra[Fila, 0] = ProductoTextBox.Text;
            ListaCompra[Fila, 1] = PrecioUnitarioTextBox.Text;
            ListaCompra[Fila, 2] = CantidadTextBox.Text;
            //SubTotal (Multiplicación de precio x cantidad)
            ListaCompra[Fila, 3] = (float.Parse(PrecioUnitarioTextBox.Text) * float.Parse(CantidadTextBox.Text)).ToString();

            //Agregar los datos a la data grid view
            dgvLista.Rows.Add(ListaCompra[Fila, 0], ListaCompra[Fila, 1], ListaCompra[Fila, 2], ListaCompra[Fila, 3], ListaCompra[Fila, 4]);

            Fila++;

            //Llamado de procedimiento para limpiar controles
            LimpiarControles();

            //Posicionar automaticamente en la casilla producto
            ProductoTextBox.Focus();
        }

        //Procedimiento para limpiar las TextBoxs
        private void LimpiarControles()
        {
            ProductoTextBox.Text = string.Empty;
            PrecioUnitarioTextBox.Text = string.Empty;
            CantidadTextBox.Text = string.Empty;
            TotalTextBox.Text = string.Empty;

        }

        private async void CalcularButton_Click(object sender, EventArgs e)
        {
            float totalVenta = 0;
            int cont = 0;
            float precioUnitario;

            cont = dgvLista.RowCount;

            for (int i = 0; i < cont; i++)
            {
                precioUnitario = float.Parse(dgvLista.Rows[i].Cells[3].Value.ToString());
                totalVenta += precioUnitario;
            }

            double descuento = await CalcularDescuentoAsync(totalVenta);
            double totalAPagar = totalVenta - descuento;

            //Mostrar Descuento 15%
            DescuentoTextBox.Text = $" Lps.{descuento:N2}";
            //Mostrar Total a pagar
            TotalTextBox.Text = $" Lps.{totalAPagar:N2}";

        }

        //Función Asíncrona Calcular 15% de descuento
        private async Task<double> CalcularDescuentoAsync(double totalVenta)
        {
            double descuento = await Task.Run(() =>
            {
                return totalVenta * 0.15;
            });
            return descuento;
        }
    }
}
