using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorTemperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double graus, temperatura;
            graus = double.Parse(Graus.Text);
            temperatura = graus + 273.15;
            Temperatura.Text = "Temperatura: " + temperatura + "°K";
        }
        private void CK_Click(object sender, EventArgs e)
        {
            double graus, temperatura;
            graus = double.Parse(Graus.Text);
            temperatura = graus + 273.15;
            Temperatura.Text = "Temperatura: " + temperatura + "°K";
        }

        private void CF_Click(object sender, EventArgs e)
        {
            double graus, temperatura;
            graus = double.Parse(Graus.Text);
            temperatura = (graus * 9 / 5) + 32;
            Temperatura.Text = "Temperatura: " + temperatura + "°F";
        }

        private void FC_Click(object sender, EventArgs e)
        {
            double graus, temperatura;
            graus = double.Parse(Graus.Text);
            temperatura = (graus - 32) * 5/9;
            Temperatura.Text = "Temperatura: " + temperatura + "°C";
        }

        private void KC_Click(object sender, EventArgs e)
        {
            double graus, temperatura;
            graus = double.Parse(Graus.Text);
            temperatura = graus - 273.15;
            Temperatura.Text = "Temperatura: " + temperatura + "°C";
        }

        private void FK_Click(object sender, EventArgs e)
        {
            double graus, temperatura;
            graus = double.Parse(Graus.Text);
            temperatura = (graus - 32) * 5/9 + 273.15;
            Temperatura.Text = "Temperatura: " + temperatura + "°K";
        }

        private void KF_Click(object sender, EventArgs e)
        {
            double graus, temperatura;
            graus = double.Parse(Graus.Text);
            temperatura = (graus - 273.15) * 9 / 5 + 32;
            Temperatura.Text = "Temperatura: " + temperatura + "°F";
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
