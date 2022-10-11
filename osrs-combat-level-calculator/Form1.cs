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
            combatLvl.Text = calc.GetCombatLvl(atk, str, hps, def, rng, mag, pra).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            atk = getFieldValue(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            str = getFieldValue(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            hps = getFieldValue(textBox3.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            def = getFieldValue(textBox4.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            rng = getFieldValue(textBox5.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            mag = getFieldValue(textBox6.Text);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            pra = getFieldValue(textBox7.Text);
        }

        private int getFieldValue(string field)
        {
            int value;

            if (int.TryParse(field, out value) && field.Length > 0)
            {
                value = Convert.ToInt32(field);

                if (value <= 0)
                    return 1;

                return value;
            }
            return 1;
        }
    }
}
