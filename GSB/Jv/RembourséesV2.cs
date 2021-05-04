using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Devart.Data;
using Devart.Data.MySql;

namespace Jv
{
    public partial class RembourséesV2 : Form
    {
        public RembourséesV2()
        {
            InitializeComponent();
        }

        private void RembourséesV2_Load(object sender, EventArgs e)
        {
            

            MySqlDataAdapter msda = new MySqlDataAdapter("select ID_FICHE as 'IdFiche', IDENTIFIANT as 'Identifiant', ID_ETAT as 'Etat', DATE as 'Date', CONCAT(IDENTIFIANT, ' - ', ID_ETAT, ' - ', DATE) as 'vFicheR' from FICHE_FRAIS where ID_ETAT=4;", Program.mydb.connection);  //on prepare une requete
            DataSet DS = new DataSet();   //on cree en memoire un nouveau jeu de donnees
            msda.Fill(DS);
           
            listBoxR.DataSource = DS.Tables[0];  // lie le jeu de données à la combo

            listBoxR.DisplayMember = "vFicheR"; // colonne de la table apparaissant dans la liste
            listBoxR.ValueMember = "IdFiche";    // valeur retournée lorsqu'un élément est sélectionné


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var retour = new Accueil();
            this.Hide();
            retour.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
