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
    public partial class Recherche : Form
    {
        public Recherche()
        {
            InitializeComponent();
        }

        private void Recherche_Load(object sender, EventArgs e)
        {

            MySqlDataAdapter msda = new MySqlDataAdapter("select * from VISITEUR", Program.mydb.connection);  // on prend toutes les données de la table visiteur
            DataSet DS = new DataSet();  
            msda.Fill(DS);

            comboBoxR.DataSource = DS.Tables[0];  
            comboBoxR.DisplayMember = "IDENTIFIANT"; // colonne de la table apparaissant dans la liste
            comboBoxR.ValueMember = "IDENTIFIANT";    // on retourne les valeurs de "IDENTIFIANT"           

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // Fonction pour afficher les fiches dans la listbox suivant l'utilisateur choisi
        {
            
            if (comboBoxR.SelectedIndex != 0)
            {                
                string identifiant = this.comboBoxR.SelectedValue.ToString(); 
                MySqlDataAdapter msda1 = new MySqlDataAdapter("SELECT ID_FICHE as 'idFiche', IDENTIFIANT as 'nomId', DATE as 'Date', ETAT.ETAT_ACTUEL as 'Etat', CONCAT(ID_FICHE, ' ' ,IDENTIFIANT, ' - ', DATE, ' - ', ETAT.ETAT_ACTUEL) as 'vFiche' FROM FICHE_FRAIS INNER JOIN ETAT ON ETAT.ID_ETAT=FICHE_FRAIS.ID_ETAT WHERE IDENTIFIANT ='" + identifiant + "'; ", Program.mydb.connection);
                DataSet DS1 = new DataSet();
                msda1.Fill(DS1);

                listBox1.DataSource = DS1.Tables[0];  

                listBox1.DisplayMember = "vFiche"; 
                listBox1.ValueMember = "IdFiche";   



            }
        }
        //Methode pour afficher l'Id dans une comboBox
        /*if (comboBoxR.SelectedIndex != 0)

        {

            MySqlCommand command = Program.mydb.connection.CreateCommand();

            command.CommandText = "SELECT ID_FICHE,IDENTIFIANT, DATE, ETAT.ETAT_ACTUEL FROM FICHE_FRAIS INNER JOIN ETAT ON ETAT.ID_ETAT=FICHE_FRAIS.ID_ETAT WHERE IDENTIFIANT= @nom";       //requete avec un paramètre

            command.Parameters.AddWithValue("@nom", comboBoxR.SelectedValue.ToString());

            using (MySqlDataReader reader = command.ExecuteReader())

            {

                reader.Read();

                comboBoxIdFiche.Text = reader["ID_FICHE"].ToString();


            }*/



    

        private void comboBoxIdFiche_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                var retour = new Accueil(); // Ouvre la page accueil
                this.Hide();
                retour.ShowDialog();
            
        }
    }
}

