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
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
         

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            var cloture = new CloturéesV2(); // Ouvre la page de cloturées
            this.Hide();
            cloture.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }             
            

        private void button3_Click_1(object sender, EventArgs e)
        {
            var remboursé = new RembourséesV2(); // Ouvre la page remboursées
            this.Hide();
            remboursé.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
                var validé = new ValidéesV2(); // Ouvre la page validées
            this.Hide();
                validé.ShowDialog();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var recherche = new Recherche(); // Ouvre la page de recherches
            this.Hide();
            recherche.ShowDialog();
        }

        private void Accueil_Load(object sender, EventArgs e)
        {
            Int32 months = (DateTime.Now.Month); // Recupère le mois
            Int32 year = (DateTime.Now.Year); // Recupère l'année
            Int32 lastday = DateTime.DaysInMonth(year, months); // Recupère le denrier jour du mois selon l'année 


            if ((DateTime.Now.Day) == lastday) // Si dernier jour
            {
                MySqlCommand command = Program.mydb.connection.CreateCommand();
                command.CommandText = "Call LastDayOfMonths();";  // Appel de la procédure
                command.ExecuteNonQuery(); // Execution de la procédure
            }
        }
    }
}
