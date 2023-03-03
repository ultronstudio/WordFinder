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

        /// <summary>
        /// Po kliknutí na tlačítko se spustí tato klíčová funkce pro aplikaci; vyhledání hledaného slova v textu
        /// </summary>
        private void btnHledat_Click(object sender, EventArgs e)
        {
            if(tboxSlovo.Text == "")
            {
                // Pokud nebyl do vstupu pro hledané slovo zadán text
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Nezadal jsi hledané slovo!", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(tboxText.Text == "")
            {
                // Pokud nebyl do vstupu pro prohledávaný text zadán nějaký text
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Nezadal jsi prohledávaný text!", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                // Zavedení proměnných
                int pocet = 0;
                int slov = 0;
                int radek = 0;
                string pozice = "";
                string tboxtext = tboxText.Text;

                // Nahrazení případných dalíšch znaků v textu
                tboxtext = tboxtext.Replace(".", "");
                tboxtext = tboxtext.Replace(",", "");
                tboxtext = tboxtext.Replace("!", "");
                tboxtext = tboxtext.Replace("?", "");
                tboxtext = tboxtext.Replace("(", "");
                tboxtext = tboxtext.Replace(")", "");
                tboxtext = tboxtext.Replace("\"", "");
                tboxtext = tboxtext.Replace("\r", "");

                // Vytvoření pole z textu, rozděleno znakem '\n' (novým řádkem)
                string[] poleText = tboxtext.Split('\n');

                // Vysvětlivka (použito dále v kódu)
                pozice += "(pozice slova), (číslo řádku) ";

                // Cyklus pro řádky
                foreach (string slovo in poleText)
                {
                    // Přičte do proměné 'řádek' jedničku
                    radek++;

                    // Rozdělí jednotlivé řádky na slova
                    foreach(string neco in slovo.Split(' '))
                    {
                        // Přičte jedničku k počtu slov
                        slov++;

                        // Pokud je aktuálí procházené slovo z textu stejné jako hledaní slovo (pro lepší vyhledání převedeno na malá písmena)
                        if (neco.ToLower() == tboxSlovo.Text.ToLower())
                        {
                            // Přídá text do proměnné 'pozice', kde proměnná 'slov' znázorňuje aktuální pořadí čísla nalezeného slova v textu, a proměnná 'řádek' číslo aktuálního řádku kde se nachází nalezené slovo
                            pozice += $"{slov}, {radek}; ";
                            
                            // Přičte jedničku do celkového počtu nalezených slov, které odpovídají hledanému slovu
                            pocet++;
                        }
                    }
                }

                // Odstraní poslední dva znaky z proměnné 'pozice' (tj. mezeru a sředník); pro lepší vzhled
                pozice = pozice.Remove(pozice.Length - 2);

                if (pocet > 0)
                {
                    // Pokud bylo v prohledávaném textu nalezeno více než 0 slov odpovídající hledanému slovu
                    SystemSounds.Question.Play();
                    MessageBox.Show($"Hledané slovo '{tboxSlovo.Text}' se v textu vyskytují {pocet} krát.\n\nDélka hledaného slova: {tboxSlovo.Text.Length} znaků\nSlov celkem: {slov}\nSlovo nalezeno na pozicích: {pozice}", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    // Pokud v prohledávaném textu nebylo nalezeno ŽÁDNÉ slovo odpovídající hledanému slovu
                    SystemSounds.Question.Play();
                    MessageBox.Show($"Hledané slovo '{tboxSlovo.Text}' se v textu nikde nevyskytuje.", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// Kliknutí na ikonu otazníku v záhlaví aplikace zobrazí MessageBox s informacemi o aplikaci
        /// </summary>
        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            SystemSounds.Question.Play();
            MessageBox.Show($"Aplikace WordFinder\n2023 © Petr Vurm\n\nVytvořeno jako domácí úkol z předmětu PROGRAMOVÁNÍ na SPŠ Hradební.", "O aplikaci", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
