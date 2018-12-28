using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Turing
{

    public partial class Form1 : Form
    {
        private Boolean div = false;
        private Boolean igual = false;
        private List<string> lista = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void boxDiv_CheckedChanged(object sender, EventArgs e)
        {
            boxIgualdade.Checked = false;
            lblOperador.Text = "?";
            textNum1.Text = "nº 1";
            textNum2.Text = "nº 2";
            if (boxDiv.Checked == true)
            {
                textNum1.Text = "";
                textNum2.Text = "";
                this.igual = false;
                this.div = true;
                lblOperador.Text = "/";
            }
        }

        private void boxIgualdade_CheckedChanged(object sender, EventArgs e)
        {
            boxDiv.Checked = false;
            lblOperador.Text = "?";
            textNum1.Text = "nº 1";
            textNum2.Text = "nº 2";
            if (boxIgualdade.Checked == true)
            {
                textNum1.Text = "";
                textNum2.Text = "";
                this.div = false;
                this.igual = true;
                lblOperador.Text = "=";
            }
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if (div == false && igual == false)
            {
                MessageBox.Show("Selecione uma das caixas", "Máquina de Turing",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            if(textNum1.TextLength == 0 || textNum2.TextLength == 0)
            {
                MessageBox.Show("Digite algum número!", "Máquina de Turing",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                return;
            }

            int num1 = Convert.ToInt32(textNum1.Text);
            int num2 = Convert.ToInt32(textNum2.Text);

            if ((num2 > num1) && div == true)
            {
                MessageBox.Show("O segundo número deve ser menor ou igual ao primeiro", "Máquina de Turing",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                return;
            }
            textFita.Text = "";
            textArea.Text = "";
            lista = new List<string>();

            preparaFita(num1, num2);
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            if (div == false && igual == false)
            {
                MessageBox.Show("Selecione uma das caixas", "Máquina de Turing",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            else
            {
                if (div)
                {
                    Div();
                }
                else if (igual)
                {
                    Igual();
                }
            }
        }

        public void Div()
        {
            textFita.Text = "";

            int estado = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                string item = lista[i];

                switch (estado)
                {
                    case 0:
                        if (item.Equals(">")) { estado = 1; }
                        break;

                    case 1:
                        if (item.Equals("*")) { estado = 1; }
                        if (item.Equals("_")) { estado = 2; }
                        break;

                    case 2:
                        if (item.Equals("*"))
                        {
                            estado = 3;
                            lista[i] = "y";
                            manipularArea();
                            i = i - 2;
                        }
                        if (item.Equals("_")) { estado = 5; lista.Add("_"); manipularArea(); }
                        if (item.Equals("y")) { estado = 2; }
                        break;

                    case 3:
                        if (item.Equals("*")) { i = i - 2; }
                        if (item.Equals("_")) { i = i - 2; }
                        if (item.Equals("y")) { i = i - 2; }
                        if (item.Equals("z")) { estado = 4; }
                        if (item.Equals(">")) { estado = 4; }
                        break;

                    case 4:
                        if (item.Equals("*"))
                        {
                            estado = 1;
                            lista[i] = "y";
                            manipularArea();
                        }
                        if (item.Equals("_")) { estado = 9; i = i - 2; }
                        if (item.Equals("y")) { estado = 4; }
                        break;

                    case 5:
                        if (item.Equals("*")) { estado = 5; }
                        if (item.Equals("_"))
                        {
                            estado = 6;
                            lista[i] = "*";
                            manipularArea();
                            i = i - 2;
                        }
                        break;

                    case 6:
                        if (item.Equals("*")) { i = i - 2; }
                        if (item.Equals("_")) { estado = 7; i = i - 2; }
                        break;

                    case 7:
                        if (item.Equals("_")) { estado = 8; i = i - 2; }
                        if (item.Equals("y")) { lista[i] = "*"; manipularArea(); i = i - 2; }
                        break;

                    case 8:
                        if (item.Equals("*")) { i = i - 2; }
                        if (item.Equals("y")) { lista[i] = "z"; estado = 1; manipularArea(); }
                        break;

                    case 9:
                        if (item.Equals("*")) { i = i - 2; }
                        if (item.Equals("y")) { lista[i] = "*"; estado = 10; manipularArea(); }
                        if (item.Equals("z"))
                        {
                            estado = 17;
                            lista[i] = "*";
                            manipularArea();
                            i = i - 2;
                        }
                        break;

                    case 10:
                        if (item.Equals("_")) { estado = 11; }
                        break;

                    case 11:
                        if (item.Equals("_")) { estado = 12; }
                        if (item.Equals("y")) { lista[i] = "*"; lista.Add("_"); manipularArea(); }
                        break;

                    case 12:
                        if (item.Equals("_")) { estado = 13; /*lista.Add("_"); */}
                        break;

                    case 13:
                        if (item.Equals("_")) { lista[i] = "*"; estado = 14; manipularArea(); i = i - 2; }
                        break;

                    case 14:
                        if (item.Equals("*")) { i = i - 2; }
                        if (item.Equals("_")) { estado = 15; i = i - 2; }
                        break;

                    case 15:
                        if (item.Equals("*")) { i = i - 2; }
                        if (item.Equals("_")) { estado = 16; i = i - 2; }
                        break;

                    case 16:
                        if (item.Equals("*")) { i = i - 2; }
                        if (item.Equals("_")) { estado = 9; i = i - 2; }
                        break;

                    case 17:
                        if (item.Equals("*")) { i = i - 2; }
                        if (item.Equals("_")) { i = i - 2; }
                        if (item.Equals("y")) { lista[i] = "*"; manipularArea(); i = i - 2; }
                        if (item.Equals("z")) { lista[i] = "*"; manipularArea(); i = i - 2; }
                        if (item.Equals(">")) { estado = 18; /*i = lista.Count;*/ }
                        break;

                    case 18:
                        if (item.Equals("_")) { estado = 19; }
                        break;

                    case 19:
                        if (item.Equals("y")) { lista[i] = "*"; manipularArea(); }
                        if (item.Equals("_")) { i = lista.Count; }
                        break;

                    default:
                        break;
                }
            }

            manipularFita();
        }

        public void Igual()
        {
            textFita.Text = "";

            int estado = -1;
            for (int i = 0; i < lista.Count; i++)
            {
                string item = lista[i];

                switch (estado)
                {
                    case -1:
                        if (item.Equals(">")) { estado = 0; }
                        break;
                    case 0:
                        if (item.Equals("*")) { lista[i] = "y"; manipularArea(); estado = 1; }
                        if (item.Equals("_")) { estado = 5; }
                        break;
                    case 1:
                        if (item.Equals("_")) { estado = 2; }
                        break;
                    case 2:
                        if (item.Equals("_")) { estado = 3; i = i - 2; }
                        if (item.Equals("y")) { estado = 3; i = i - 2; }
                        break;
                    case 3:
                        if (item.Equals("*")) { lista[i] = "y"; manipularArea(); estado = 4; i = i - 2; }
                        if (item.Equals("_")) { estado = 10; lista.Add("_"); }
                        break;
                    case 4:
                        if (item.Equals("*")) { i = i - 2; }
                        if (item.Equals("_")) { i = i - 2; }
                        if (item.Equals("y")) { estado = 0; }
                        break;
                    case 5:
                        if (item.Equals("*")) { estado = 6; }
                        if (item.Equals("_")) { estado = 7; i = i - 2; }
                        if (item.Equals("y")) { lista[i] = "*"; manipularArea(); }
                        break;
                    case 6:
                        if (item.Equals("_")) { estado = 8; i = i - 2; }
                        if (item.Equals("y")) { lista[i] = "*"; manipularArea(); }
                        break;
                    case 7:
                        if (item.Equals("*")) { i = i - 2; }
                        if (item.Equals("_")) { i = i - 2; }
                        if (item.Equals("y")) { lista[i] = "*"; manipularArea(); i = i - 2; }
                        if (item.Equals(">")) { /* FIM */  i = lista.Count; }
                        break;
                    case 8:
                        if (item.Equals("*")) { lista[i] = "_"; manipularArea(); estado = 9; i = i - 2; }
                        break;
                    case 9:
                        if (item.Equals("*")) { i = i - 2; }
                        if (item.Equals("_")) { i = i - 2; }
                        if (item.Equals("y")) { lista[i] = "*"; manipularArea(); i = i - 2; }
                        if (item.Equals(">")) { estado = 0; }
                        break;
                    case 10:
                        if (item.Equals("_")) { lista[i] = "*"; manipularArea(); estado = 9; i = i - 2; }
                        if (item.Equals("y")) { lista[i] = "*"; manipularArea(); estado = 10; }
                        break;
                    default:
                        break;
                }
            }

            manipularFita();
        }

        public void manipularFita()
        {
            textFita.Text = "";
            for (int i = 0; i < lista.Count; i++)
            {
                string item = lista[i];
                if (item.Equals("y") || item.Equals("z"))
                {
                    item = "*";
                }
                textFita.Text += item;
            }
        }

        public void manipularArea()
        {
            string item = "";
            for (int i = 0; i < lista.Count; i++)
            {
                item += lista[i];
            }
            textArea.Text += item;
            textArea.Text += "\n";
        }

        public List<string> preparaFita(int num1, int num2)
        {
            textFita.Font = new Font("Arial", 14);
            textArea.Font = new Font("Arial", 14);
            lista.Add(">");

            for (int i = 0; i < num1; i++)
            {
                lista.Add("*");
            }
            lista.Add("_");
            for (int i = 0; i < num2; i++)
            {
                lista.Add("*");
            }
            lista.Add("_");
            foreach (var item in lista)
            {
                textFita.Text += item.ToString();
            }
            return lista;
        }

        private void textNum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}