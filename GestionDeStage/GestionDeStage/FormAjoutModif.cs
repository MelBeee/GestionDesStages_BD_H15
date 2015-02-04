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
   public partial class FormAjoutModif : Form
   {
      // bool savoir si on est entrain de deplacer le form
      private bool _dragging = false;
      // emmagasine la position du curseur lors d'un deplacement de form
      private Point _start_point = new Point(0, 0);
      string AjouterModifier;
      OracleConnection oraconn_AM = new OracleConnection();
      int NumStagePK;
      string NumEntPK;

      public FormAjoutModif(string AjoutModif, OracleConnection oraconn, int NumStage)
      {
         oraconn_AM = oraconn;
         NumStagePK = NumStage;
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

      private void FormAjoutModif_Load(object sender, EventArgs e)
      {
         LB_AjoutModif.Text = AjouterModifier;
         if (AjouterModifier == "Modifier")
         {
            FB_Appliquer.Enabled = true;
            LB_NomEnt.Enabled = true;
            LB_NomEnt.Visible = true;
            CB_Entreprise.Enabled = false;
            CB_Entreprise.Visible = false;
            LoadInformation();
         }
         else
         {
            FB_Appliquer.Enabled = false;
            LB_NomEnt.Enabled = false;
            LB_NomEnt.Visible = false;
            CB_Entreprise.Enabled = true;
            CB_Entreprise.Visible = true;
            RemplirInformation();
         }
      }

      private void RemplirInformation()
      {
         string commandesql = "select nom from entreprise";

         try
         {
            OracleCommand orcd = new OracleCommand(commandesql, oraconn_AM);
            orcd.CommandType = CommandType.Text;
            OracleDataReader oraRead = orcd.ExecuteReader();

            while (oraRead.Read())
            {
               CB_Entreprise.Items.Add(oraRead.GetString(0).ToString());
            }

            oraRead.Close();
         }
         catch (OracleException ex)
         {
            Erreur(ex);

         }
      }

      private void LoadInformation()
      {
         string commandesql = "select s.description, s.typestage, e.nom from stage s " +
                       "inner join entreprise e on e.nument = s.nument " +
                       "where s.numstage = " + NumStagePK.ToString();
         try
         {
            OracleCommand orcd = new OracleCommand(commandesql, oraconn_AM);
            orcd.CommandType = CommandType.Text;
            OracleDataReader oraRead = orcd.ExecuteReader();

            oraRead.Read();

            TB_Description.Text = oraRead.GetString(0);
            if (oraRead.GetString(1) == "ind")
            {
               RB_Industriel.Select();
            }
            else
            {
               RB_Gestion.Select();
            }
            LB_NomEnt.Text = oraRead.GetString(2);


            oraRead.Close();
         }
         catch (OracleException ex)
         {
            Erreur(ex);
         }
      }

      private string Choixdelacommande()
      {
         string commande;
         if (AjouterModifier == "Ajouter")
         {
            commande = " insert into stage " +
                       " (description, typestage, nument) values " +
                       " (:description, :typestage, :nument)";
         }
         else
         {
            commande = " update stage set " +
                       " description = :description, " +
                       " typestage = :typestage, " +
                       " nument = :nument " +
                       " where numstage = " + NumStagePK.ToString();
         }
         return commande;
      }

      private void AjoutModif()
      {
         TrouverNument();
         bool reussi = true;
         try
         {
            // on affecte les valeurs aux paramètres.
            OracleParameter oradescription = new OracleParameter(":description", OracleDbType.Varchar2);
            OracleParameter oratype = new OracleParameter(":typestage", OracleDbType.Varchar2);
            OracleParameter oranument = new OracleParameter(":nument", OracleDbType.Char);
            // lalblablabla
            OracleCommand oraModif = new OracleCommand(Choixdelacommande(), oraconn_AM);
            oraModif.CommandType = CommandType.Text;

            oradescription.Value = TB_Description.Text;
            if (RB_Gestion.Checked)
               oratype.Value = "ges";
            else
               oratype.Value = "ind";
            oranument.Value = NumEntPK;
            // En utilisant la propriété Paramètres de OracleCommand, on spécifie les paramètres de la requête SQL.
            oraModif.Parameters.Add(oradescription);
            oraModif.Parameters.Add(oratype);
            oraModif.Parameters.Add(oranument);

            // on exécute la requête
            oraModif.ExecuteNonQuery();
            // on appelle la fonction dissocier pour pouvoir insérer une deuxième fois.
         }
         catch (OracleException ex)
         {
            reussi = false;
            Erreur(ex);
         }
         if (reussi)
            MessageBox.Show("Application reussite");
         else
            MessageBox.Show("Application non reussite");
      }

      private bool ChampsRempli()
      {
         return (TB_Description.Text == "") ||
                (!RB_Gestion.Checked && !RB_Industriel.Checked) ||
                (CB_Entreprise.SelectedIndex < 0);
      }

      private void FB_Appliquer_Click(object sender, EventArgs e)
      {
         if(ChampsRempli())
            AjoutModif();
      }

      private void TrouverNument()
      {
         string commande;
         if (AjouterModifier == "Ajouter")
         {
            commande = "select nument from entreprise where nom like '" + LB_NomEnt + "'";
         }
         else
         {
            commande = "select nument from entreprise where nom like '" + CB_Entreprise.Text + "'";
         }

         try
         {
            OracleCommand orcd = new OracleCommand(commande, oraconn_AM);
            orcd.CommandType = CommandType.Text;
            OracleDataReader oraRead = orcd.ExecuteReader();

            oraRead.Read();
            NumEntPK = oraRead.GetString(0);

            oraRead.Close();
         }
         catch (OracleException ex)
         {
            Erreur(ex);
         }
      }

      private void CB_Entreprise_SelectedIndexChanged(object sender, EventArgs e)
      {
         TrouverNument();
      }
   }
}
