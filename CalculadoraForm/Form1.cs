using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaCalculadora;
using System.Runtime.InteropServices;

namespace CalculadoraForm
{
    public partial class Form1 : Form
    {
        private double Almacenar = 0, total = 0, valor1 = 0, valor2 = 0;
        private char operation = '0';
        public Form1()
        {
            InitializeComponent();
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            Operacion('/');
        }

        private void uno_Click(object sender, EventArgs e)
        {
            agregar('1');
        }

        void agregar(char caracter)
        {
            Almacenar = Convert.ToDouble(Resultado.Text += "" + caracter);
        }

        private void dos_Click(object sender, EventArgs e)
        {
            agregar('2');
        }

        private void tres_Click(object sender, EventArgs e)
        {
            agregar('3');
        }

        private void cuatro_Click(object sender, EventArgs e)
        {
            agregar('4');
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            agregar('5');
        }

        private void seis_Click(object sender, EventArgs e)
        {
            agregar('6');
        }

        private void siete_Click(object sender, EventArgs e)
        {
            agregar('7');
        }

        private void ocho_Click(object sender, EventArgs e)
        {
            agregar('8');
        }

        private void nueve_Click(object sender, EventArgs e)
        {
            agregar('9');
        }
        private void multiplicar_Click(object sender, EventArgs e)
        {
            Operacion('*');
        }

        void Operacion(char caracter)
        {
            if (valor1 == 0)
            {
                Valores(caracter);
            }
            else if (valor1 != 0)
            {
                Total();
                Valores(caracter);
            }
        }

        void Valores(char caracter)
        {
            valor1 = Almacenar;
            operation = caracter;
            SalidaText.Text = "" + valor1 + " " + caracter;
            Resultado.Text = "";
            Almacenar = 0;
        }
        private void igual_Click(object sender, EventArgs e)
        {
            Total();
        }

        void Total()
        {
            valor2 = Almacenar;
            Almacenar = 0;
            switch (operation)
            {
                case '*':
                    total = Operaciones.multiplicar(valor1, valor2);//obtiene el total
                    impresion();
                    break;
                case '/':
                    total = Operaciones.division(valor1, valor2);
                    impresion();
                    break;
                case '+':
                    total = Operaciones.sumar(valor1, valor2);
                    impresion();
                    break;
                case '-':
                    total = Operaciones.restar(valor1, valor2);
                    impresion();
                    break;
                case '^':
                    total = Operaciones.potencia(valor1, 2);
                    impresion();
                    break;
                case 'r':
                    total = Operaciones.raizCuadrada(valor1);
                    impresion();
                    break;
                case '%':
                    total = Operaciones.porcentaje(valor1, valor2);
                    impresion();
                    break;
                case 'f':
                    total = Operaciones.fraccion(valor1);
                    impresion();
                    break;
                default:
                    break;
            }
        }
        void impresion()
        {
            SalidaText.Text = " = " + (Almacenar = total);
            Resultado.Text = "";
        }

        private void suma_Click(object sender, EventArgs e)
        {
            Operacion('+');
        }

        private void resta_Click(object sender, EventArgs e)
        {
            Operacion('-');
        }

        private void cero_Click(object sender, EventArgs e)
        {
            agregar('0');
        }

        private void Borrar2_Click(object sender, EventArgs e)
        {
            BorrarUno();
        }

        void BorrarUno()
        {
            if (Resultado.Text != "" && Resultado.Text.Length > 1)
            {
                Almacenar = Convert.ToDouble(Resultado.Text = cadena(Resultado.Text));
            }
        }

        string cadena(string caracteresS)
        {
            string salida = "";
            if (caracteresS.Length > 0)
            {
                salida = caracteresS.Remove(caracteresS.Length - 1, 1);//borrar el ultimo caracter
            }
            return salida;
        }

        private void Borrar1_Click(object sender, EventArgs e)
        {
            SalidaText.Text = Resultado.Text = "";
            Almacenar = valor1 = valor2 = total = 0;
        }

        private void BorrarTodo_Click(object sender, EventArgs e)
        {
            Resultado.Text = "";
            Almacenar = 0;
        }

        private void SalidaText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Resultado_TextChanged(object sender, EventArgs e)
        {

        }
        private void exponencial_Click(object sender, EventArgs e)
        {
            Operacion('^');
        }

        private void Modulo_Click(object sender, EventArgs e)
        {
            Operacion('%');
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void BarraTitulo_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void fraccion_Click(object sender, EventArgs e)
        {
            Operacion('f');
        }

        private void raiz_Click(object sender, EventArgs e)
        {
            Operacion('r');
        }

        private void punto_Click(object sender, EventArgs e)
        {
            if(!Resultado.Text.Contains(".") && !(Resultado.Text == ""))
            {
                agregar('.');
            }
            if (Resultado.Text == "")
            {
                agregar('0');
                agregar('.');
            }
        }
    }
}
