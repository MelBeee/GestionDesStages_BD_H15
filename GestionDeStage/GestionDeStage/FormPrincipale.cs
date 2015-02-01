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
        // variable utilisé pour la verification dans les textboxs
        const char BACKSPACE = '\b';
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
            if (NumstageValide(TB_NumStage.Text))
            {
                int numstage = -1;
                if (TB_NumStage.Text != "")
                    numstage = Convert.ToInt32(TB_NumStage.Text);
                FormAjoutModif AjouterUnStage = new FormAjoutModif(AjoutModifier, oraconnPrincipale, numstage);

                AjouterUnStage.ShowDialog();
            }
            else
            {
                TB_NumStage.Text = "";
            }
            UpdateControl();
        }

        private void FormPrincipale_Load(object sender, EventArgs e)
        {
            if (TB_NumStage.Text == "")
            {
                FB_Supprimer.Enabled = false;
                FB_Modifier.Enabled = false;
            }
            Connection();
        }

        private void Connection()
        {
            if (!connection)
            {
                //Remplit le DSource
                string Dsource = "(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                    "(HOST=205.237.244.251)(PORT=1521)))" +
                    "(CONNECT_DATA=(SERVICE_NAME=ORCL.clg.qc.ca)))";
                string user = "BOUCHERM";
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
                }
            }
        }

        private void TB_NumStage_TextChanged(object sender, EventArgs e)
        {
            UpdateControl();
        }

        private void UpdateControl()
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
            if (NumstageValide(TB_NumStage.Text))
            {
                string sqlcommande2 = "delete from postuler where numstage = " + TB_NumStage.Text;
                string sqlcommande = "delete from stage where numstage = " + TB_NumStage.Text;
                OracleCommand orcd2 = new OracleCommand(sqlcommande2, oraconnPrincipale);
                OracleCommand orcd = new OracleCommand(sqlcommande, oraconnPrincipale);
                try
                {
                    orcd2.CommandType = CommandType.Text;
                    orcd2.ExecuteNonQuery();

                    orcd.CommandType = CommandType.Text;
                    orcd.ExecuteNonQuery();

                    MessageBox.Show("Suppression reussite");
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("Suppression non reussite");
                    Erreur(ex);
                }
                TB_NumStage.Clear();
            }
            else
            {
                TB_NumStage.Text = "";
            }
            UpdateControl();
        }

        private void Erreur(OracleException exception)
        {
            FormErreur Erreur = new FormErreur(exception);

            if (Erreur.ShowDialog() == DialogResult.Cancel)
            {
                this.Close();
            }
        }

        private void FormPrincipale_FormClosing(object sender, FormClosingEventArgs e)
        {
            oraconnPrincipale.Close();
        }

        private void TB_NumStage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != BACKSPACE)
                e.Handled = !EstChiffre(e.KeyChar);
        }

        bool EstChiffre(char c)
        {
            String chiffres = "0123456789";
            return (chiffres.IndexOf(c.ToString()) != -1);
        }

        private bool NumstageValide(string numstage)
        {
            bool valide = false;  
            string sql = "select numstage from stage where numstage = " + numstage;
            OracleCommand orcd = new OracleCommand(sql, oraconnPrincipale);
            orcd.CommandType = CommandType.Text;
            OracleDataReader oraRead = orcd.ExecuteReader();

            if (oraRead.Read())
            {
                valide = true;
            }
            else
            {
                MessageBox.Show("Numéro de stage invalide");
            }
            oraRead.Close();
            return valide;
        }
    }
}
