using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Devart.Data;
using Devart.Data.MySql;

namespace Jv
{
    static class Program
    {
        public static DB mydb;
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            mydb = new DB("192.168.2.4", "bdgpasquier7","sqlgpasquier", "savary");
           

            if (Program.mydb.OpenConnection() != true)
            {
                MessageBox.Show("Connexion à la BD impossible.");
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Accueil());

           
        }
    }
}
