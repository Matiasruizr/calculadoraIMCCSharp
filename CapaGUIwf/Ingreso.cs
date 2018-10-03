using CapaDTO;
using CapaConexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapaGUIwf
{
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();
        }

        private void btoGrabar_Click(object sender, EventArgs e)
        {
            if (txtRut.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un rut");
            }
            else if (txtNombre.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un nombre");
            }
            else if (txtEstatura.Text.Length == 0 || float.Parse(txtEstatura.Text) < 1)
            {
                MessageBox.Show("Debe ingresar un valor valido para la estatura");
            }
            else if (txtPeso.Text.Length == 0 || float.Parse(txtPeso.Text) < 1)
            {
                MessageBox.Show("Debe ingresar un valor valido para el peso");
            }
            else
            {
                Transaccion t = new Transaccion();
                t.Rut_paciente = txtRut.Text;
                t.Nom_paciente = txtNombre.Text;
                t.Estatura = float.Parse(txtEstatura.Text);
                t.Peso = int.Parse(txtPeso.Text);
                t.IMC1 = ((float.Parse(txtPeso.Text) / (float.Parse(txtEstatura.Text) * float.Parse(txtEstatura.Text)) ) );
    
                if (t.IMC1 < 18)
                {
                    txtIMC.Text = "Esqueleto "+ t.IMC1;
                } 
                else if (t.IMC1 >= 18 && t.IMC1 < 25)
                {
                    txtIMC.Text = "Bien " + t.IMC1;
                }
                else if (t.IMC1 >= 25)
                {
                    txtIMC.Text = "Ballena " + t.IMC1;
                }
            }


            
        }

        private void btoSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
            System.GC.Collect();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
