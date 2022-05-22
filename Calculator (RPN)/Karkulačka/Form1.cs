using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karkulačka {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private string priklad = "";
        private string znamenko = "";
        private float vysledek = 0f;
        private bool promazat = false;
        private bool aktivniOperator = false;

        private void cisloKlik(object sender, EventArgs e) {
            Button btn = sender as Button;
            if (promazat)
                priklad = btn.Text;
            else
                priklad += btn.Text;

            lbVysledek.Text = priklad;
            promazat = false;
        }

        private void operatorKlik(object sender, EventArgs e) {
            Button btn = sender as Button;

            if(!aktivniOperator)
                vysledek = float.Parse(lbVysledek.Text);
            else if(priklad.Length != 0) {
                lbVysledek.Text = vypocitat();
            }

            znamenko = btn.Text;
            lbPriklad.Text += priklad + znamenko;
            aktivniOperator = true;
            promazat = true;
        }

        private void teckaKlik(object sender, EventArgs e) {

            if (!priklad.Contains(".")) {
                if (priklad.Length == 0) {
                    priklad += "0.";
                } else {
                    priklad += ".";
                }
                lbVysledek.Text = priklad;
                promazat = false;
            }
        }

        private void vymazatPosledni(object sender, EventArgs e) {
            if (priklad.Length != 0) {
                priklad = priklad.Remove(priklad.Length - 1);
                lbVysledek.Text = priklad;
            }
        }

        private void vymazatCely(object sender, EventArgs e) {
            lbPriklad.Text = "";
            lbVysledek.Text = "0";

            priklad = "";
            znamenko = "";
            vysledek = 0f;
            promazat = false;
            aktivniOperator = false;
        }

        private void rovnaSeKlik(object sender, EventArgs e) {
            if (priklad.Length != 0) {
                lbPriklad.Text += priklad;
                lbVysledek.Text = vypocitat();
            }
        }

        private string vypocitat() {
            float cislo = float.Parse(priklad);
            switch (znamenko) {
                case "÷":
                    if(cislo == 0f) {
                        return "Nelze dělit nulou";
                    }
                    vysledek /= cislo;
                    break;

                case "*":
                    vysledek *= cislo;
                    break;

                case "-":
                    vysledek -= cislo;
                    break;

                case "+":
                default:
                    vysledek += cislo;
                    break;
            }
            znamenko = "";
            priklad = "";
            promazat = true;
            return formatovatVysledek(vysledek);
        }

        private string formatovatVysledek(float vysledek) {
            return (Math.Floor((double)(vysledek * 100)) / 100).ToString();
        }
    }
}
