using System;
using System.Windows.Forms;

namespace KiaraMoncada
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void primerFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrimerFormulario primerFormulario = new PrimerFormulario();
            primerFormulario.Show();
        }

        private void segundoFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SegundoFormulario segundoFormulario = new SegundoFormulario();
            segundoFormulario.Show();
        }

        private void tercerFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TercerFormulario tercerFormulario = new TercerFormulario();
            tercerFormulario.Show();
        }
    }
}
