using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoInterfaz
{
    public partial class GUIPrincipal : Form
    {
        public GUIPrincipal()
        {
            InitializeComponent();
        }

        private void mostrarInformaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIBuscarParticipante gui = new GUIBuscarParticipante();
            gui.Show();
        }

        private void registrarParticipanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUINewQueen gui = new GUINewQueen();
            gui.Show();
        }

        private void buscarPorNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
