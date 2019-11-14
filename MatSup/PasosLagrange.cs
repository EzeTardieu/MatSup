using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatSup
{
    public partial class PasosLagrange : UserControl
    {
        private List<Polinomio> Ls = Lagrange.ls;
        public PasosLagrange()
        {
            InitializeComponent();
        }

        private void PasosLagrange_Load(object sender, EventArgs e)
        {
            
        }
        public void cargar()
        {
            
            this.label1.Text = "Pasos...";
            int indice = 0;
            if (Ls != null)
            {
                foreach (var L in Ls)
                {
                    tablaLs.Controls.Add(new Label { Text = "L" + indice.ToString() + "(x)", Anchor = AnchorStyles.Left, AutoSize = true }, 0, indice);
                    tablaLs.Controls.Add(new Label { Text = L.Formatear(), Anchor = AnchorStyles.Left, AutoSize = true }, 1, indice);
                    indice++;
                }
            }
            
            
        }
    }
}
