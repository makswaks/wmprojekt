using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wmprojekt
{
    public partial class Form1 : Form
    {
        private WMService service;
        public Form1()
        {
            ErgebnisRepository repo=new ErgebnisRepository();
            service = new WMService(repo);  
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(AppDomain.CurrentDomain.BaseDirectory);// Mannschaften in ComboBox laden
            cmboxHeim.Items.Add("Deutschland");
            cmboxHeim.Items.Add("Curacao");
            cmboxHeim.Items.Add("Elfenbeinkueste");
            cmboxHeim.Items.Add("Ecuador");

            cboxGast.Items.Add("Deutschland");
            cboxGast.Items.Add("Curacao");
            cboxGast.Items.Add("Elfenbeinkueste");
            cboxGast.Items.Add("Ecuador");

            cmboxHeim.SelectedIndex = 0;
            cboxGast.SelectedIndex = 1;

        }
        
        private void btnErgebnis_Click(object sender, EventArgs e)
        {
            bool is_ok = service.ErgebnisEintragen(cmboxHeim.Text, cboxGast.Text, (int)numericUpDown1ToreHeim.Value, (int)numericUpDownToreGast.Value);
            if (!is_ok) { MessageBox.Show("Fehler"); }
            else
            {
                dgvTabelle.DataSource = null;
                dgvTabelle.DataSource = service.GetTabelle();
            }
        }

        private void btnbeste_Click(object sender, EventArgs e)
        {
            Mannschaft beste = service.GetBesteMannschaft();
            MessageBox.Show("Beste Mannschaft: " + beste.Name);
        }
    }
}
