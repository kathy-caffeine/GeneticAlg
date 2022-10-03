using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneticAlg
{
    public partial class Form1 : Form
    {
        Generation generation = new Generation();
        public Form1()
        {
            InitializeComponent();
        }

        private void Count_Click(object sender, EventArgs e)
        {
            // Проверка введённых значений
            bool crunch =
                int.TryParse(generationAmount.Text, out generation.generationAmount) &&
                int.TryParse(individualAmount.Text, out generation.individualAmount) &&
                int.TryParse(fightingAmount.Text, out generation.fightingAmount) &&
                double.TryParse(crossbreedingP.Text, out generation.crossbreedingP) &&
                generation.crossbreedingP >=0 && generation.crossbreedingP<1&&
                double.TryParse(mutationP.Text, out generation.mutationP) &&
                generation.mutationP >= 0 && generation.mutationP < 1;
            if (!crunch)
            {
                MessageBox.Show("Введённые значения некорректны. " +
                    "Для работы алгоритма необходимо изменить параметры, подсвеченные красным.");
            }
        }

        private void generationAmount_TextChanged(object sender, EventArgs e)
        {
            if(!int.TryParse(generationAmount.Text, out generation.generationAmount) 
                || generationAmount.Text == "")
            {
                generationAmount.BackColor = Color.Red;
                Count.Enabled = false;
            }
            else
            {
                generationAmount.BackColor = Color.White;
            }
        }

        private void individualAmount_TextChanged(object sender, EventArgs e)
        {
            if(!int.TryParse(individualAmount.Text, out generation.individualAmount)
                || individualAmount.Text == "")
            {
                individualAmount.BackColor = Color.Red;
                Count.Enabled = false;
            }
            else
            {
                individualAmount.BackColor = Color.White;
            }
        }

        private void fightingAmount_TextChanged(object sender, EventArgs e)
        {
            if(!int.TryParse(fightingAmount.Text, out generation.fightingAmount)
                || fightingAmount.Text == "")
            {
                fightingAmount.BackColor = Color.Red;
                Count.Enabled = false;
            }
            else
            {
                fightingAmount.BackColor = Color.White;
            }
        }

        private void crossbreedingP_TextChanged(object sender, EventArgs e)
        {
            if(!(double.TryParse(crossbreedingP.Text, out generation.crossbreedingP)
                && generation.crossbreedingP >= 0.0 && generation.crossbreedingP < 1.0)
                || crossbreedingP.Text == "")
            {
                crossbreedingP.BackColor = Color.Red;
                Count.Enabled = false;
            }
            else
            {
                crossbreedingP.BackColor = Color.White;
            }
        }

        private void mutationP_TextChanged(object sender, EventArgs e)
        {
            if (!(double.TryParse(mutationP.Text, out generation.mutationP) &&
                generation.mutationP >= 0.0 && generation.mutationP < 1.0))
            {
                mutationP.BackColor = Color.Red;
                Count.Enabled = false;
            }
            else
            {
                mutationP.BackColor = Color.White;
            }
        }
    }
}
