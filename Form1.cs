using System.Data.SQLite;
using System.Data;
using Microsoft.VisualBasic.ApplicationServices;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace EsercizioAS2324._3G.GuardabascioRiccardo.PSDBPCTO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPiloti_Click(object sender, EventArgs e)
        {
            string query = "";
            string strConnessione = "";
            strConnessione = "Data Source=" + @"C:\Users\PC\Desktop\EsercizioAS2324.3G.GuardabascioRiccardo.PSDBPCTO\DB\MotoGP.db" + ";Version=3;";
            DataTable dtDati = new DataTable();
            query = "SELECT * FROM Piloti WHERE Nazionalita ORDER BY Nome, Cognome ";

            SQLiteDataAdapter da = new SQLiteDataAdapter(query, strConnessione);
            try
            {
                da.Fill(dtDati);
                dgvDati.DataSource = dtDati;
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }
        private void btnGare_Click_1(object sender, EventArgs e)
        {
            string query = "";
            string strConnessione = "";
            strConnessione = "Data Source=" + @"C:\Users\PC\Desktop\EsercizioAS2324.3G.GuardabascioRiccardo.PSDBPCTO\DB\MotoGP.db" + ";Version=3;";
            DataTable dtDati = new DataTable();
            query = "SELECT * FROM Gare WHERE Punteggio <=3 ";

            SQLiteDataAdapter da = new SQLiteDataAdapter(query, strConnessione);
            try
            {
                da.Fill(dtDati);
                dgvDati.DataSource = dtDati;
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }
    }
}
