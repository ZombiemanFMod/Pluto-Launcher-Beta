using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pluto_Login_V2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Pfad zur Datei angeben
            string filePath = "C:\\Pfad\\zu\\deiner\\datei.txt";

            // Überprüfen, ob die Datei existiert
            if (File.Exists(filePath))
            {
                try
                {
                    // Inhalt der Datei lesen
                    string fileContent = File.ReadAllText(filePath);

                    // Überprüfen, ob der Inhalt mit "Username:" beginnt und diesen Teil entfernen
                    if (fileContent.StartsWith("Username:"))
                    {
                        string username = fileContent.Substring("Username:".Length).Trim();
                        label2.Text = username;
                    }
                    else
                    {
                        label2.Text = "Kein gültiger Benutzername gefunden";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim Lesen der Datei: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Datei nicht gefunden");
            }
        }
    }
}
