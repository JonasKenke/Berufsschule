using System;
using System.Collections.Generic;
using System.Windows.Forms;
using List;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly IKundeService kundeService;

        public Form1()
        {
            InitializeComponent();
            IKundeDAO kundeDAO = new KundeDAO("C:\\Users\\U774641\\source\\repos\\Berufsschule\\WindowsFormsApp1\\kunde.csv"); // Path to your CSV file
            IKundeService baseService = new KundeService(kundeDAO);
            IKundeService secService = new SecDecorator(baseService);
            kundeService = new LaufzeitDecorator(secService);
            LoadKunden();
        }

        private void LoadKunden()
        {
            List<Kunde> kunden = kundeService.readKunde();
            listBoxKunden.Items.Clear();
            foreach (Kunde kunde in kunden)
            {
                listBoxKunden.Items.Add($"{kunde.Vorname} {kunde.Nachname}");
            }
        }

        private void buttonAddKunde_Click(object sender, EventArgs e)
        {
            string vorname = textBoxVorname.Text;
            string nachname = textBoxNachname.Text;

            kundeService.writeKunde(vorname, nachname);
            LoadKunden();
        }
    }
}
