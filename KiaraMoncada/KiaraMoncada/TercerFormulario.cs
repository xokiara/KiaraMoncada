using System;
using System.Windows.Forms;

namespace KiaraMoncada
{
    public partial class TercerFormulario : Form
    {
        public TercerFormulario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Limpiar el listbox
            NumerosListBox.Items.Clear();


            //Números del 1 al 100
            for (int i = 1; i <= 100; i++)
            {

                // Agregar el número, nombre, apellido o ambos al list box dependienpo la condición
                if (i % 3 == 0)
                {
                    NumerosListBox.Items.Add("Kiara");
                }
                else if (i % 5 == 0)
                {
                    NumerosListBox.Items.Add("Moncada");
                }
                else if (i % 3 == 0 & i % 5 == 0)
                {
                    NumerosListBox.Items.Add("Kiara Moncada");
                }
                else
                {
                    NumerosListBox.Items.Add(i.ToString());
                }

            }

        }
    }
}
