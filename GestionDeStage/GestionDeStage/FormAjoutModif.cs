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

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      FORM Ajout/Modifier
//      Fait par Melissa Boucher
//      4 Fevrier 2015
//      Produit pour le cours de Base de Données
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace GestionDeStage
{
   public partial class FormAjoutModif : Form
   {
      // bool savoir si on est entrain de deplacer le form
      private bool _dragging = false;
      // emmagasine la position du curseur lors d'un deplacement de form
      private Point _start_point = new Point(0, 0);
      // emmagasine un string permettant de savoir si on ajoute ou modifie un stage
      string AjouterModifier;
      // connection au serveur 
      OracleConnection oraconn_AM = new OracleConnection();
      // emmagasine le numero de stage si on modifie un stage
      int NumStagePK;

      //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
      //      CONSTRUCTEUR
      //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
      public FormAjoutModif(string AjoutModif, OracleConnection oraconn, int NumStage)
      {
         oraconn_AM = oraconn;
         NumStagePK = NumStage;
         AjouterModifier = AjoutModif;
         InitializeComponent();
      }

      //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
      //      FORM LOAD
      //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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

      //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
      //      EVENTS DE FLASHBUTTON
      //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
      private void FB_Quit_Click(object sender, EventArgs e)
      {
         this.Close();
      }
      private void flashButton2_Click(object sender, EventArgs e)
      {
         this.Close();
      }
      private void TB_Description_TextChanged(object sender, EventArgs e)
      {
         UpdateControl();
      }
      private void RB_Industriel_CheckedChanged(object sender, EventArgs e)
      {
         UpdateControl();
      }
      private void RB_Gestion_CheckedChanged(object sender, EventArgs e)
      {
         UpdateControl();
      }
      private void CB_Entreprise_SelectedIndexChanged(object sender, EventArgs e)
      {
         UpdateControl();
      }

      //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
      //      DEPLACEMENT DU FORM
      //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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
      private void UpdateControl()
      {
         if (AjouterModifier == "Ajouter")
            FB_Appliquer.Enabled = (TB_Description.Text != "" && (RB_Gestion.Checked || RB_Industriel.Checked) && CB_Entreprise.SelectedIndex != -1);
         else
            FB_Appliquer.Enabled = (TB_Description.Text != "" && (RB_Gestion.Checked || RB_Industriel.Checked));
      }
      private void FB_Appliquer_Click(object sender, EventArgs e)
      {
         bool reussi = true;

         if (AjouterModifier == "Ajouter")
            reussi = Ajout();
         else
            reussi = Modifier();

         if (reussi)
            this.Close();
      }

      //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
      //      MODIFIER
      //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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
      private bool Modifier()
      {
         bool reussi = true;
         string commande = " update stage set " +
                           " description = :Description, " +
                           " typestage =  :TypeStage " +
                           " where numstage = " + NumStagePK;
         try
         {
            // on affecte les valeurs aux paramètres.
            OracleParameter oradescription = new OracleParameter(":Description", OracleDbType.Varchar2, 100);
            OracleParameter oratype = new OracleParameter(":TypeStage", OracleDbType.Varchar2, 3);

            oradescription.Value = TB_Description.Text;
            if (RB_Gestion.Checked)
               oratype.Value = "ges";
            else
               oratype.Value = "ind";

            OracleCommand oraModif = new OracleCommand(commande, oraconn_AM);
            oraModif.CommandType = CommandType.Text;

            // En utilisant la propriété Paramètres de OracleCommand, on spécifie les paramètres de la requête SQL.
            oraModif.Parameters.Add(oradescription);
            oraModif.Parameters.Add(oratype);

            // on exécute la requête
            oraModif.ExecuteNonQuery();
            // on appelle la fonction dissocier pour pouvoir insérer une deuxième fois.
            MessageBox.Show("Application reussite");
         }
         catch (OracleException ex)
         {
            MessageBox.Show(ex.ToString());
            //Erreur(ex);
            reussi = false;
         }
         return reussi;
      }

      //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
      //      AJOUTER
      //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
      private bool Ajout()
      {
         bool reussi = true;
         string commande = "insert into stage (description, typestage, nument) values " +
                          "(:Description, :TypeStage, (select nument from entreprise where nom = '" + CB_Entreprise.SelectedItem.ToString() + "'))";
         try
         {
            // on affecte les valeurs aux paramètres.
            OracleParameter oradescription = new OracleParameter(":Description", OracleDbType.Varchar2, 100);
            OracleParameter oratype = new OracleParameter(":TypeStage", OracleDbType.Varchar2, 3);

            OracleCommand oraModif = new OracleCommand(commande, oraconn_AM);
            oraModif.CommandType = CommandType.Text;

            oradescription.Value = TB_Description.Text;
            if (RB_Gestion.Checked)
               oratype.Value = "ges";
            else
               oratype.Value = "ind";
            // En utilisant la propriété Paramètres de OracleCommand, on spécifie les paramètres de la requête SQL.
            oraModif.Parameters.Add(oradescription);
            oraModif.Parameters.Add(oratype);

            // on exécute la requête
            oraModif.ExecuteNonQuery();
            // on appelle la fonction dissocier pour pouvoir insérer une deuxième fois.
            MessageBox.Show("Application reussite");
         }
         catch (OracleException ex)
         {
            Erreur(ex);
            reussi = false;
         }
         return reussi;
      }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//      GESTION DES ERREURS
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
      private void Erreur(OracleException exception)
      {
         FormErreur Erreur = new FormErreur(exception);

         if (Erreur.ShowDialog() == DialogResult.Cancel)
            this.Close();
      }
   }
}

