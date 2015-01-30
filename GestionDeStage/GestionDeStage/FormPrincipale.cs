using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace GestionDeStage
{
   public partial class FormPrincipale : Form
   {
      public FormPrincipale()
      {
         InitializeComponent();
      }
      // bool savoir si on est entrain de deplacer le form
      private bool _dragging = false;
      // emmagasine la position du curseur lors d'un deplacement de form
      private Point _start_point = new Point(0, 0);
      // boolean pour stocker si le form est connecté ou non
      public bool connection = false;
      // variable contenant la connection a la bd 
      OracleConnection oraconnPrincipale = new OracleConnection();

      // Deplacement des forms
      private void Form1_MouseDown(object sender, MouseEventArgs e)
      {
         _dragging = true;  // Enregistre que l'utilisateur a selectionner la form
         _start_point = new Point(e.X, e.Y); // Enregistre le point actuelle du form 
      }
      private void Form1_MouseUp(object sender, MouseEventArgs e)
      {
         _dragging = false; // Enregistre que l'utilisateur a "lacher le form"
      }
      private void Form1_MouseMove(object sender, MouseEventArgs e)
      {
         if (_dragging) // si l'utilisateur a selectionner le form
         {
            Point p = PointToScreen(e.Location);
            Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
         }
      }

      private void FB_Quit_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void FB_Ajouter_Click(object sender, EventArgs e)
      {
         string AjoutModif = "Ajouter";
         AjoutModifier(AjoutModif);
      }
      private void FB_Modifier_Click(object sender, EventArgs e)
      {
         string AjoutModif = "Modifier";
         AjoutModifier(AjoutModif);
      }

      private void AjoutModifier(string AjoutModifier)
      {
         FormAjoutModif AjouterUnStage = new FormAjoutModif(AjoutModifier, oraconnPrincipale);

         AjouterUnStage.ShowDialog();
      }

      private void FormPrincipale_Load(object sender, EventArgs e)
      {
         if(TB_NumStage.Text == "")
         {
            FB_Supprimer.Enabled = false;
            FB_Modifier.Enabled = false; 
         }
         Connection();
         if (!connection) // si pas de connection 
         {
            
         }
      }

      private void Connection()
      {
         if (!connection)
         {
            //Remplit le DSource
            string Dsource = "(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                "(HOST=205.237.244.251)(PORT=1521)))" +
                "(CONNECT_DATA=(SERVICE_NAME=ORCL.clg.qc.ca)))";
            string user = "BRO3AU";
            string passwd = "ORACLE1";

            string chaineconnection = "Data Source = " + Dsource + ";User Id =" + user + "; Password =" + passwd;
            connection = true;
            try
            {
               oraconnPrincipale.ConnectionString = chaineconnection;
               oraconnPrincipale.Open();
            }
            catch (OracleException ex)
            {
               Erreur(ex);
               connection = false;
            }
         }
      }

      private void TB_NumStage_TextChanged(object sender, EventArgs e)
      {
         if (TB_NumStage.Text == "")
         {
            FB_Supprimer.Enabled = false;
            FB_Modifier.Enabled = false;
         }
         else
         {
            FB_Supprimer.Enabled = true;
            FB_Modifier.Enabled = true; 
         }
      }

      private void FB_Supprimer_Click(object sender, EventArgs e)
      {

      }

      private void Erreur(OracleException exception)
      {
         FormErreur Erreur = new FormErreur(exception);

         if (Erreur.ShowDialog() == DialogResult.Cancel)
            this.Close();
      }

      private void FormPrincipale_FormClosing(object sender, FormClosingEventArgs e)
      {
         oraconnPrincipale.Close();
      }
   }
}
