using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulačkaNaOstro {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        double vysledek = 0;
        string mujOperator = "";
        bool aktivniZnamenko = false;
        bool zacatekNula = true;
        bool delenoNulou = false;
        bool zablokovat = false;

        private void buttonCE_Click(object sender, EventArgs e) {
            if (!zablokovat) {
                HlavniDisplej.Text = "0";
            }
        }

        private void buttonC_Click(object sender, EventArgs e) {
            HlavniDisplej.Text = "0";
            InfoDisplej.Text = null;
            vysledek = 0;
            zacatekNula = true;
            aktivniZnamenko = false;
            delenoNulou = false;
            zablokovat = false;
            mujOperator = null;
        }

        private void ButtonsCisla_click(object sender, EventArgs e) {
            Button tlacitko = sender as Button;
            if (!zablokovat) {
                if ((HlavniDisplej.Text == "0" && tlacitko.Text != ",") || aktivniZnamenko) {
                    HlavniDisplej.Text = null;
                    aktivniZnamenko = false;
                }
                if (tlacitko.Text == "," && HlavniDisplej.Text.Contains(",")) { }
                else {
                    HlavniDisplej.Text += tlacitko.Text;
                }
            }
        }

        private void ButtonsOperace_click(object sender, EventArgs e) {
            Button tlacitko = sender as Button;
            if (!zablokovat) {
                if (zacatekNula) {
                    vysledek = double.Parse(HlavniDisplej.Text);
                    mujOperator = tlacitko.Text;
                    InfoDisplej.Text += HlavniDisplej.Text + mujOperator;
                    HlavniDisplej.Text = "0";
                    zacatekNula = false;
                }
                else {
                    vypocet();
                    if (!delenoNulou) {
                        mujOperator = tlacitko.Text;
                        InfoDisplej.Text += HlavniDisplej.Text + mujOperator;
                        HlavniDisplej.Text = vysledek.ToString();
                        aktivniZnamenko = true;
                    }
                    else {
                        HlavniDisplej.Text = "Nulou nelze dělit!";
                        InfoDisplej.Text = "Klikněte na 'C' pro pokračování";
                    }
                }
            }
        }
        private void vypocet() {
            switch (mujOperator) {
                case "+":
                    vysledek += double.Parse(HlavniDisplej.Text);
                    break;
                case "-":
                    vysledek -= double.Parse(HlavniDisplej.Text);
                    break;
                case "*":
                    vysledek *= double.Parse(HlavniDisplej.Text);
                    break;
                case "/":
                    if (HlavniDisplej.Text == "0") {
                        delenoNulou = true;
                        zablokovat = true;
                    }
                    else {
                        vysledek /= double.Parse(HlavniDisplej.Text);
                    }
                    break;
            }
        }

        private void buttonRovnaSe_Click(object sender, EventArgs e) {
            if (!zablokovat) {
                vypocet();
                if (!delenoNulou) {
                    InfoDisplej.Text = null;
                    HlavniDisplej.Text = vysledek.ToString();
                    zacatekNula = true;
                    mujOperator = null;
                }
                else {
                    HlavniDisplej.Text = "Nulou nelze dělit!";
                    InfoDisplej.Text = "Klikněte na 'C' pro pokračování";
                }
            }
        }

        private void button1DelenoX_Click(object sender, EventArgs e) {
            if (!zablokovat) {
                if (HlavniDisplej.Text == "0") {
                    HlavniDisplej.Text = "Převrácená hodnota z nuly neexistuje!";
                    InfoDisplej.Text = "Klikněte na 'C' pro pokračování";
                    zablokovat = true;
                }
                else {
                    HlavniDisplej.Text = (1 / double.Parse(HlavniDisplej.Text)).ToString();
                }
            }
        }

        private void buttonOdmocnina_Click(object sender, EventArgs e) {
            if (!zablokovat) {
                if (double.Parse(HlavniDisplej.Text) < 0) {
                    HlavniDisplej.Text += " nelze odmocnit!";
                    InfoDisplej.Text = "Klikněte na 'C' pro pokračování";
                    zablokovat = true;
                }
                else {
                    HlavniDisplej.Text = Math.Sqrt(double.Parse(HlavniDisplej.Text)).ToString();
                }
            }
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e) {
            if (!zablokovat) {
                HlavniDisplej.Text = (double.Parse(HlavniDisplej.Text) - (2*double.Parse(HlavniDisplej.Text))).ToString();
            }
        }

        private void buttonNaDruhou_Click(object sender, EventArgs e) {
            if (!zablokovat) {
                HlavniDisplej.Text = (double.Parse(HlavniDisplej.Text) * double.Parse(HlavniDisplej.Text)).ToString();
            }
        }

        private void buttonPi_Click(object sender, EventArgs e) {
            if (!zablokovat) {
                HlavniDisplej.Text = "3,14";
            }
        }
    }
}
