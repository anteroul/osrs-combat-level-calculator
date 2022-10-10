using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ccalc;

namespace osrs_combat_level_calculator
{
    public partial class Form1 : Form
    {
        Calculator calc = new Calculator();

        int atk = 1;
        int str = 1;
        int hps = 10;
        int def = 1;
        int rng = 1;
        int mag = 1;
        int pra = 1;

        public Form1()
        {
            InitializeComponent();

            textBox1.Text = atk.ToString();
            textBox2.Text = str.ToString();
            textBox3.Text = hps.ToString();
            textBox4.Text = def.ToString();
            textBox5.Text = rng.ToString();
            textBox6.Text = mag.ToString();
            textBox7.Text = pra.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            atk = Convert.ToInt32(textBox1.Text);
            str = Convert.ToInt32(textBox2.Text);
            hps = Convert.ToInt32(textBox3.Text);
            def = Convert.ToInt32(textBox4.Text);
            rng = Convert.ToInt32(textBox5.Text);
            mag = Convert.ToInt32(textBox6.Text);
            pra = Convert.ToInt32(textBox7.Text);

            combatLvl.Text = calc.GetCombatLvl(atk, str, hps, def, rng, mag, pra).ToString();
        }
    }
}
