using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PainelAcademiaPlusApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Calcular Metas Hidratação
        private void Calcular_Meta_Hidatacao()
        {
            decimal peso = numericUpDown2.Value;

            decimal metaHidatacao = (peso * 35) / 1000;

            txtResultadoHidratacao.Text = metaHidatacao.ToString("F3") + " Litros";

        }

        //Calcular IMC
        private void Calcular_Imc()
        {
            decimal peso = numericUpDownPeso.Value;
            decimal altura = numericUpDownAltura.Value;
            if (peso == 0 || altura == 0)
            {
                return;
            }

            decimal imc = peso / (altura * altura);

            txtIMC.Text = imc.ToString("F2");

        }

        private void numericUpDownPeso_ValueChanged(object sender, EventArgs e)
        {
            Calcular_Imc();
        }

        private void numericUpDownAltura_ValueChanged(object sender, EventArgs e)
        {
            Calcular_Imc();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Calcular_Meta_Hidatacao();
        }
        
        private void numPesoCalorias_ValueChanged(object sender, EventArgs e)
        {
            calculaCalorias();
        }

        //Calcular Calorias
        private void calculaCalorias()
        {
            decimal peso = numPesoCalorias.Value;
            decimal duracao = numDuracao.Value;
            int atividade = cbAtividade.SelectedIndex;

            decimal kcal = 0;

            if (atividade == 0) //musculação
                kcal = 0.0714m;
            else if (atividade == 1) //corrida
                kcal = 0.1428m;
            else if (atividade == 2) //bicicleta
                kcal = 0.0857m;
            else if (atividade == 3) //dança
                kcal = 0.05m;

            if (peso == 0 || duracao == 0 )
            {
                return;
            }

            txtResultadoCalorias.Text = (kcal * duracao * peso).ToString("F3") + " kcal";

        }

        private void numDuracao_ValueChanged(object sender, EventArgs e)
        {
            calculaCalorias();
        }
    }
}
