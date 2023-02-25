using System;
using System.Globalization;
using System.Windows.Forms;

namespace KiaraMoncada
{
    public partial class PrimerFormulario : Form
    {
        public PrimerFormulario()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            //Limpiar el listbox
            InteresesListBox.Items.Clear();

            //Variables
            double capital = 200000;
            double tasaInteres = 0.015;
            int meses = 12;

            for (int i = 1; i <= meses; i++)
            {
                //Calcular el interés de mes actual
                double CantidadInteres = capital * tasaInteres;

                //Agregar mes y el interés a la ListBox
                string nombreDeMes = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i);
                string texto = $"{nombreDeMes}: Lps. {CantidadInteres:n2}";
                InteresesListBox.Items.Add(texto);

                //Interés al capital para el mes siguiente
                capital += CantidadInteres;
            }
        }
    }
}
