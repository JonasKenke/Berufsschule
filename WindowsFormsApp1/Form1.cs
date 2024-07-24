using List;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\U774641\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\kunde.csv";
            KundeDAO kundeDAO = new KundeDAO(filePath);
            List<Kunde> kunden = kundeDAO.LoadKunden();

            foreach (var kunde in kunden)
            {
                label1.Text += kunde.getName() + kunde.getVorname();
            }
        }
    }
}
