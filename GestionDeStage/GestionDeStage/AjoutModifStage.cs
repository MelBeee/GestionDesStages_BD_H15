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
//  commenter
namespace GestionDeStage
{
   public partial class AjoutModifStage : Form
   {
      // bool savoir si on est entrain de deplacer le form
      private bool _dragging = false;
      // emmagasine la position du curseur lors d'un deplacement de form
      private Point _start_point = new Point(0, 0);
      string AjouterModifier;
      OracleConnection oraconn_AM = new OracleConnection();

      public AjoutModifStage(string AjoutModif, OracleConnection oraconn)
      {
         oraconn_AM = oraconn; 
         AjouterModifier = AjoutModif; 
         InitializeComponent();
      }

      private void FB_Quit_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void flashButton2_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      // Deplacement des forms
      private void AjoutModifStage_MouseDown(object sender, MouseEventArgs e)
      {
         _dragging = true;  // Enregistre que l'utilisateur a selectionner la form
         _start_point = new Point(e.X, e.Y); // Enregistre le point actuelle du form 
      }
      private void AjoutModifStage_MouseUp(object sender, MouseEventArgs e)
      {
         _dragging = false; // Enregistre que l'utilisateur a "lacher le form"
      }
      private void AjoutModifStage_MouseMove(object sender, MouseEventArgs e)
      {
         if (_dragging) // si l'utilisateur a selectionner le form
         {
            Point p = PointToScreen(e.Location);
            Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
         }
      }

      private void Erreur(OracleException exception)
      {
         FormErreur Erreur = new FormErreur(exception);

         if (Erreur.ShowDialog() == DialogResult.Cancel)
            this.Close();
      }
   }
}
