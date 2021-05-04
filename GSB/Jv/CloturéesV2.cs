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
    public partial class CloturéesV2 : Form
    {
        public CloturéesV2()
        {
            InitializeComponent();
        }

        private void CloturéesV2_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter msda = new MySqlDataAdapter("select ID_FICHE as 'IdFiche', IDENTIFIANT as 'Identifiant', ID_ETAT as 'Etat', DATE as 'Date', CONCAT(ID_FICHE, ' ' ,IDENTIFIANT, ' - ', ID_ETAT, ' - ', DATE) as 'vFicheC' from FICHE_FRAIS where ID_ETAT=1;", Program.mydb.connection);  //on prepare une requete
            DataSet DS = new DataSet();   
            msda.Fill(DS);

            listBoxC.DataSource = DS.Tables[0];  

            listBoxC.DisplayMember = "vFicheC"; 
            listBoxC.ValueMember = "IdFiche";    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var retour = new Accueil();
            this.Hide();
            retour.ShowDialog();
        }


        private void listBoxC_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Forfaits

                ListeBoxFrais.Items.Clear();


                MySqlCommand command = Program.mydb.connection.CreateCommand();

                command.CommandText = "SELECT ID_FRAIS FROM FICHE_FRAIS INNER JOIN FORFAITAIRE ON FICHE_FRAIS.ID_FICHE=FORFAITAIRE.ID_FICHE INNER JOIN TYPE ON FORFAITAIRE.ID_TYPE=TYPE.ID_TYPE WHERE FICHE_FRAIS.ID_FICHE =@id";    //requete avec un paramètre

                command.Parameters.AddWithValue("@id", listBoxC.SelectedValue.ToString()); 

              

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        ListeBoxFrais.Items.Add(reader["ID_FRAIS"].ToString());
                }


            //Hors-Forfaits

                cmbBoxHF.Items.Clear();


                MySqlCommand command1 = Program.mydb.connection.CreateCommand();

                command1.CommandText = "SELECT ID_HORSFORFAIT FROM HORS_FORFAIT INNER JOIN FICHE_FRAIS ON HORS_FORFAIT.ID_FICHE=FICHE_FRAIS.ID_FICHE WHERE FICHE_FRAIS.ID_FICHE = @id;";    //requete avec un paramètre

                command1.Parameters.AddWithValue("@id", listBoxC.SelectedValue.ToString()); 

                

                using (MySqlDataReader reader = command1.ExecuteReader())
                {

                    while (reader.Read())
                        cmbBoxHF.Items.Add(reader["ID_HORSFORFAIT"].ToString());

                }

        }


        private void ListeBoxFrais_SelectedIndexChanged(object sender, EventArgs e)
        {
                

                MySqlCommand command = Program.mydb.connection.CreateCommand();
                //command.CommandText = "SELECT MONTANT FROM TYPE INNER JOIN FORFAITAIRE ON TYPE.ID_TYPE=FORFAITAIRE.ID_TYPE WHERE FORFAITAIRE.ID_FRAIS=@id;";         //requete avec un paramètre
                command.CommandText = "SELECT QTE FROM FORFAITAIRE WHERE ID_FRAIS=@id;";
                command.Parameters.AddWithValue("@id", ListeBoxFrais.SelectedItem.ToString());    //remplissage du paramètre
                                                                                                  //avec le numéro du club selectionne dans la liste

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    reader.Read();
                    //textBox1.Text = reader["MONTANT"].ToString();
                    textBox1.Text = reader["QTE"].ToString();
                }

            MySqlCommand command1 = Program.mydb.connection.CreateCommand();
            command1.CommandText = "SELECT LIBELLE FROM TYPE INNER JOIN FORFAITAIRE ON TYPE.ID_TYPE=FORFAITAIRE.ID_TYPE WHERE FORFAITAIRE.ID_FRAIS=@id;";         //requete avec un paramètre
            command1.Parameters.AddWithValue("@id", ListeBoxFrais.SelectedItem.ToString());    //remplissage du paramètre
                                                                                              //avec le numéro du club selectionne dans la liste

            using (MySqlDataReader reader = command1.ExecuteReader())
            {
                reader.Read();
                txtBoxLibelle.Text = reader["LIBELLE"].ToString();
            }

        }

        private void cmbBoxHF_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlCommand command = Program.mydb.connection.CreateCommand();
            command.CommandText = "SELECT MONTANT, LIBELLE FROM HORS_FORFAIT WHERE ID_HORSFORFAIT = @id;"; //requête avec un paramètre
            command.Parameters.AddWithValue("@id", cmbBoxHF.SelectedItem.ToString());    //remplissage du paramètre
                                                                                         //avec le numéro du club selectionne dans la liste

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                reader.Read();
                txtHF.Text = reader["MONTANT"].ToString();
                txtBoxLibHF.Text = reader["LIBELLE"].ToString();
            }

            
        }

        private void btn_modif_Click(object sender, EventArgs e)
        {
            MySqlCommand command = Program.mydb.connection.CreateCommand();


            //command.CommandText = "UPDATE TYPE INNER JOIN FORFAITAIRE ON TYPE.ID_TYPE=FORFAITAIRE.ID_TYPE SET MONTANT = @nom  WHERE FORFAITAIRE.ID_FRAIS = @id;";         //requete avec un paramètre
            command.CommandText = "UPDATE FORFAITAIRE SET QTE = @nom WHERE FORFAITAIRE.ID_FRAIS = @id;";
            command.Parameters.AddWithValue("@nom", textBox1.Text);    //remplissage du paramètre
            command.Parameters.AddWithValue("@id", ListeBoxFrais.SelectedItem);
            command.ExecuteNonQuery();

            CloturéesV2_Load(sender, e);
            textBox1.Text = "";
        }

        private void btnModifHF_Click(object sender, EventArgs e)
        {
            MySqlCommand command = Program.mydb.connection.CreateCommand();

            command.CommandText = "UPDATE HORS_FORFAIT  SET MONTANT = @montant WHERE ID_HORSFORFAIT = @id;";         //requete avec un paramètre
            command.Parameters.AddWithValue("@montant", txtHF.Text);    //remplissage du paramètre
            command.Parameters.AddWithValue("@id", cmbBoxHF.SelectedItem);
            command.ExecuteNonQuery();

            CloturéesV2_Load(sender, e);
            txtHF.Text = "";
        }

        private void btnSuprHF_Click(object sender, EventArgs e)
        {
            MySqlCommand command = Program.mydb.connection.CreateCommand();

            try
            {
                command.CommandText = "DELETE from HORS_FORFAIT where ID_HORSFORFAIT = @id";         //requete avec un paramètre
                command.Parameters.AddWithValue("@id", cmbBoxHF.SelectedItem);
                command.ExecuteNonQuery();

                CloturéesV2_Load(sender, e);
                txtHF.Text = "";

            }
            catch
            {
                MessageBox.Show("Erreur.", "Impossible de supprimer.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnValidHF_Click(object sender, EventArgs e)
        {
            MySqlCommand command = Program.mydb.connection.CreateCommand();

            command.CommandText = "UPDATE HORS_FORFAIT SET VALIDATION = 1 where ID_HORSFORFAIT = @id";         //requete avec un paramètre
            command.Parameters.AddWithValue("@id", cmbBoxHF.SelectedItem);
            command.ExecuteNonQuery();

            CloturéesV2_Load(sender, e);
            txtHF.Text = "";
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            MySqlCommand command = Program.mydb.connection.CreateCommand();

            command.CommandText = "UPDATE FICHE_FRAIS SET ID_ETAT = 2 WHERE ID_FICHE = @id;";         //requete avec un paramètre
            command.Parameters.AddWithValue("@id", listBoxC.SelectedValue);
            command.ExecuteNonQuery();

            CloturéesV2_Load(sender, e);
        }

        private void txtBoxLibHF_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
