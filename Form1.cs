using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordFinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHledat_Click(object sender, EventArgs e)
        {
            if(tboxSlovo.Text == "")
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Nezadal jsi hledané slovo!", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(tboxText.Text == "")
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Nezadal jsi prohledávaný text!", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int pocet = 0;
                int slov = 0;
                int radek = 0;
                string pozice = "";
                string tboxtext = tboxText.Text;
                tboxtext = tboxtext.Replace(".", "");
                tboxtext = tboxtext.Replace(",", "");
                tboxtext = tboxtext.Replace("!", "");
                tboxtext = tboxtext.Replace("?", "");
                tboxtext = tboxtext.Replace("(", "");
                tboxtext = tboxtext.Replace(")", "");
                tboxtext = tboxtext.Replace("\"", "");
                tboxtext = tboxtext.Replace("\r", "");
                string[] poleText = tboxtext.Split('\n');

                pozice += "(pozice slova), (číslo řádku) ";

                foreach (string slovo in poleText)
                {
                    /* slov++;
                    foreach(char znak in slovo)
                    {
                        if(znak == '\n')
                        {
                            radek++;
                        }
                    }
                    if (slovo.ToLower() == tboxSlovo.Text.ToLower())
                    {
                        pozice += $"{slov}, {radek}; ";
                        pocet++;
                    } */
                    radek++;
                    foreach(string neco in slovo.Split(' '))
                    {
                        slov++;
                        if(neco.ToLower() == tboxSlovo.Text.ToLower())
                        {
                            pozice += $"{slov}, {radek}; ";
                            pocet++;
                        }
                    }
                }

                pozice = pozice.Remove(pozice.Length - 2);

                if (pocet > 0)
                {
                    SystemSounds.Question.Play();
                    MessageBox.Show($"Hledané slovo '{tboxSlovo.Text}' se v textu vyskytují {pocet} krát.\n\nDélka hledaného slova: {tboxSlovo.Text.Length} znaků\nSlov celkem: {slov}\nSlovo nalezeno na pozicích: {pozice}", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    SystemSounds.Question.Play();
                    MessageBox.Show($"Hledané slovo '{tboxSlovo.Text}' se v textu nikde nevyskytuje.", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            SystemSounds.Question.Play();
            MessageBox.Show($"Aplikace WordFinder\n2023 © Petr Vurm\n\nVytvořeno jako domácí úkol z předmětu PROGRAMOVÁNÍ na SPŠ Hradební.", "O aplikaci", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
