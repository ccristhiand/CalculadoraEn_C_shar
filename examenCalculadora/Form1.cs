using examenCalculadora.clases;
using examenCalculadora.controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examenCalculadora
{
    public partial class Form1 : Form
    {
        operaciones operaciones= new operaciones();
        datos datos = new datos();

        public Form1()
        {
            string text = "";

            

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            var num = "1";
            txtResultados.Text += num;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            var num = "0";
            txtResultados.Text += num;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            var num = "2";
            txtResultados.Text += num;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            var num = "3";
            txtResultados.Text += num;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            var num = "4";
            txtResultados.Text += num;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            var num = "5";
            txtResultados.Text += num;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            var num = "6";
            txtResultados.Text += num;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            var num = "7";
            txtResultados.Text += num;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            var num = "8";
            txtResultados.Text += num;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            var num = "9";
            txtResultados.Text += num;
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            primerValor("+");

        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            primerValor("-");
        }

        private void btnmultiplicacion_Click(object sender, EventArgs e)
        {
            primerValor("x");
        }

        private void btnDivicion_Click(object sender, EventArgs e)
        {
            primerValor("/");
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (txtResultados.Text != "")
            {
                this.datos.num2 = Convert.ToDouble(txtResultados.Text);
                txtResultados.Clear();
            }

            if (datos.num2!=null && datos.num1!=null)
            {
                switch (datos.operador)
                {
                    case "+": datos.total = operaciones.suma(datos); total(); break;
                    case "-": datos.total = operaciones.resta(datos); total(); break;
                    case "x": datos.total = operaciones.multiplicacion(datos); total(); break;
                    case "/": datos.total = operaciones.divicion(datos); total(); break;
                    default:
                        break;
                }

            }

        }

        public void total()
        {
            txtResultados.Text = datos.total.ToString();
            txtHistorial.Text+=" || "+datos.num1+datos.operador+datos.num2+ "=" +datos.total;
        }
        
        public void primerValor(string operacion)
        {
            if (txtResultados.Text != "")
            {
                this.datos.num1 = Convert.ToDouble(txtResultados.Text);
                this.datos.operador = operacion;
                txtResultados.Clear();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtHistorial.Clear();
            txtResultados.Clear();
            datos=new datos();
        }
    }
}
