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
    public partial class ValidéesV2 : Form
    {
        
        public ValidéesV2()
        {
            InitializeComponent();
        }

                private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ValidéesV2_Load(object sender, EventArgs e)
        {
          

            MySqlDataAdapter msda = new MySqlDataAdapter("select ID_FICHE as 'IdFiche', IDENTIFIANT as 'Identifiant', DATE as 'Date', CONCAT('Utilisateur : ',  IDENTIFIANT, ' - ', ' Date : ', DATE) as 'vFicheV' from FICHE_FRAIS where ID_ETAT=2;", Program.mydb.connection);  //on prepare une requete
            DataSet DS = new DataSet();   //on cree en memoire un nouveau jeu de donnees
            msda.Fill(DS);

            listBoxV.DataSource = DS.Tables[0];  // lie le jeu de données à la combo
            listBoxV.DisplayMember = "vFicheV"; // colonne de la table apparaissant dans la liste
            listBoxV.ValueMember = "IdFiche";    // valeur retournée lorsqu'un élément est sélectionné

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var retour = new Accueil();
            this.Hide();
            retour.ShowDialog();
        }               

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxV_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            MySqlCommand command = Program.mydb.connection.CreateCommand();
            try
            {
                command.CommandText = "SELECT FICHE_FRAIS.ID_FICHE, (SELECT sum(HORS_FORFAIT.MONTANT) FROM HORS_FORFAIT WHERE HORS_FORFAIT.ID_FICHE = FICHE_FRAIS.ID_FICHE) as TotalHF, (SELECT sum(FORFAITAIRE.QTE * TYPE.MONTANT) FROM FORFAITAIRE, TYPE WHERE FORFAITAIRE.ID_FICHE = FICHE_FRAIS.ID_FICHE AND TYPE.ID_TYPE = FORFAITAIRE.ID_TYPE) as totF, (SELECT TotalHF + totF) as 'MontantTotal' from FICHE_FRAIS as FICHE_FRAIS where FICHE_FRAIS.ID_FICHE =@id GROUP BY FICHE_FRAIS.ID_FICHE";       //requete avec un paramètre
            }
            catch 
            {
                command.CommandText = "SELECT FICHE_FRAIS.ID_FICHE, (SELECT sum(FORFAITAIRE.QTE * TYPE.MONTANT) FROM FORFAITAIRE, TYPE WHERE FORFAITAIRE.ID_FICHE = FICHE_FRAIS.ID_FICHE AND TYPE.ID_TYPE = FORFAITAIRE.ID_TYPE) as totF, (SELECT totF) as 'MontantTotal' from FICHE_FRAIS as FICHE_FRAIS where FICHE_FRAIS.ID_FICHE =@id";
            }
            command.Parameters.AddWithValue("@id", listBoxV.SelectedValue.ToString());
            
           
            using (MySqlDataReader reader = command.ExecuteReader())
                if(reader.HasRows)
                {
                    reader.Read();
                    textBox1.Text = reader["MontantTotal"].ToString();
                }
            
        }

        private void listBoxV_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
