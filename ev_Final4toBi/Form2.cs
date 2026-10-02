using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ev_Final4toBi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(BtnProducto.Text);
            int num2 = int.Parse(BtnProducto.Text);
            int producto = num1 * num2;
            MessageBox.Show("El resultado del producto es" + producto);
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(BtnSuma.Text);
            int num2 = int.Parse(BtnSuma.Text);
            int suma = num1 + num2;
            MessageBox.Show("El resultado de la suma es" + suma);
        }

        private void BtnPotencia_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(BtnPotencia.Text);
            int n2 = int.Parse(BtnPotencia.Text);
            int n3 = 1;
            int potencia = 1;
            while (n3 != n2)
            {
                potencia = potencia * n1;
                n3 = n3 + 1;
            }
            MessageBox.Show("El resultado de la potencia es" + potencia);
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(BtnPotencia.Text);
            int n2 = int.Parse(BtnPotencia.Text);
            int n3 = 1;
            int potencia = 1;
            while (n3 != n2)
            {
                potencia = potencia * n1;
                n3 = n3 + 1;
            }
            MessageBox.Show("El resultado de la potencia es" + potencia);
        }
    }
    }
    
