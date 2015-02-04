namespace GestionDeStage
{
   partial class FormPrincipale
   {
      /// <summary>
      /// Variable nécessaire au concepteur.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Nettoyage des ressources utilisées.
      /// </summary>
      /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Code généré par le Concepteur Windows Form

      /// <summary>
      /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
      /// le contenu de cette méthode avec l'éditeur de code.
      /// </summary>
      private void InitializeComponent()
      {
         this.panel1 = new System.Windows.Forms.Panel();
         this.panel3 = new System.Windows.Forms.Panel();
         this.LB_Type = new System.Windows.Forms.Label();
         this.LB_Description = new System.Windows.Forms.Label();
         this.LBX_Entreprise = new System.Windows.Forms.ListBox();
         this.panel2 = new System.Windows.Forms.Panel();
         this.label2 = new System.Windows.Forms.Label();
         this.TB_NumStage = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.LB_TitreDescription = new System.Windows.Forms.Label();
         this.LB_TitreType = new System.Windows.Forms.Label();
         this.LB_TitreNumStage = new System.Windows.Forms.Label();
         this.LB_NumStage = new System.Windows.Forms.Label();
         this.FB_Quit = new FlashButton.FlashButton();
         this.FB_Suivant = new FlashButton.FlashButton();
         this.FB_Precedant = new FlashButton.FlashButton();
         this.FB_Modifier = new FlashButton.FlashButton();
         this.FB_Ajouter = new FlashButton.FlashButton();
         this.FB_Supprimer = new FlashButton.FlashButton();
         this.panel1.SuspendLayout();
         this.panel3.SuspendLayout();
         this.panel2.SuspendLayout();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.LightGreen;
         this.panel1.Controls.Add(this.panel3);
         this.panel1.Controls.Add(this.panel2);
         this.panel1.Location = new System.Drawing.Point(2, 24);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(319, 355);
         this.panel1.TabIndex = 0;
         // 
         // panel3
         // 
         this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(250)))), ((int)(((byte)(180)))));
         this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panel3.Controls.Add(this.LB_TitreNumStage);
         this.panel3.Controls.Add(this.LB_NumStage);
         this.panel3.Controls.Add(this.LB_TitreType);
         this.panel3.Controls.Add(this.LB_TitreDescription);
         this.panel3.Controls.Add(this.LB_Type);
         this.panel3.Controls.Add(this.LB_Description);
         this.panel3.Controls.Add(this.LBX_Entreprise);
         this.panel3.Controls.Add(this.FB_Suivant);
         this.panel3.Controls.Add(this.FB_Precedant);
         this.panel3.Location = new System.Drawing.Point(10, 116);
         this.panel3.Name = "panel3";
         this.panel3.Size = new System.Drawing.Size(299, 231);
         this.panel3.TabIndex = 3;
         // 
         // LB_Type
         // 
         this.LB_Type.Font = new System.Drawing.Font("Kristen ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.LB_Type.Location = new System.Drawing.Point(14, 180);
         this.LB_Type.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.LB_Type.Name = "LB_Type";
         this.LB_Type.Size = new System.Drawing.Size(270, 20);
         this.LB_Type.TabIndex = 4;
         this.LB_Type.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // LB_Description
         // 
         this.LB_Description.Font = new System.Drawing.Font("Kristen ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.LB_Description.Location = new System.Drawing.Point(14, 120);
         this.LB_Description.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.LB_Description.Name = "LB_Description";
         this.LB_Description.Size = new System.Drawing.Size(270, 50);
         this.LB_Description.TabIndex = 3;
         this.LB_Description.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // LBX_Entreprise
         // 
         this.LBX_Entreprise.FormattingEnabled = true;
         this.LBX_Entreprise.Location = new System.Drawing.Point(14, 10);
         this.LBX_Entreprise.Margin = new System.Windows.Forms.Padding(2);
         this.LBX_Entreprise.Name = "LBX_Entreprise";
         this.LBX_Entreprise.Size = new System.Drawing.Size(270, 56);
         this.LBX_Entreprise.TabIndex = 2;
         this.LBX_Entreprise.SelectedIndexChanged += new System.EventHandler(this.LBX_Entreprise_SelectedIndexChanged);
         // 
         // panel2
         // 
         this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(250)))), ((int)(((byte)(180)))));
         this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.panel2.Controls.Add(this.label2);
         this.panel2.Controls.Add(this.TB_NumStage);
         this.panel2.Controls.Add(this.FB_Modifier);
         this.panel2.Controls.Add(this.FB_Ajouter);
         this.panel2.Controls.Add(this.FB_Supprimer);
         this.panel2.Location = new System.Drawing.Point(10, 10);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(299, 100);
         this.panel2.TabIndex = 2;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(30, 28);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(117, 18);
         this.label2.TabIndex = 4;
         this.label2.Text = "Numero de Stage";
         // 
         // TB_NumStage
         // 
         this.TB_NumStage.Location = new System.Drawing.Point(38, 49);
         this.TB_NumStage.Name = "TB_NumStage";
         this.TB_NumStage.Size = new System.Drawing.Size(100, 20);
         this.TB_NumStage.TabIndex = 3;
         this.TB_NumStage.TextChanged += new System.EventHandler(this.TB_NumStage_TextChanged);
         this.TB_NumStage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_NumStage_KeyPress);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.White;
         this.label1.Location = new System.Drawing.Point(3, 2);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(149, 22);
         this.label1.TabIndex = 1;
         this.label1.Text = "Gestion des Stages";
         this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
         this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
         this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
         // 
         // LB_TitreDescription
         // 
         this.LB_TitreDescription.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.LB_TitreDescription.Location = new System.Drawing.Point(14, 103);
         this.LB_TitreDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.LB_TitreDescription.Name = "LB_TitreDescription";
         this.LB_TitreDescription.Size = new System.Drawing.Size(270, 20);
         this.LB_TitreDescription.TabIndex = 5;
         this.LB_TitreDescription.Text = "Description de stage";
         this.LB_TitreDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // LB_TitreType
         // 
         this.LB_TitreType.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.LB_TitreType.Location = new System.Drawing.Point(14, 164);
         this.LB_TitreType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.LB_TitreType.Name = "LB_TitreType";
         this.LB_TitreType.Size = new System.Drawing.Size(270, 20);
         this.LB_TitreType.TabIndex = 6;
         this.LB_TitreType.Text = "Type de stage";
         this.LB_TitreType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // LB_TitreNumStage
         // 
         this.LB_TitreNumStage.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.LB_TitreNumStage.Location = new System.Drawing.Point(14, 68);
         this.LB_TitreNumStage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.LB_TitreNumStage.Name = "LB_TitreNumStage";
         this.LB_TitreNumStage.Size = new System.Drawing.Size(270, 20);
         this.LB_TitreNumStage.TabIndex = 8;
         this.LB_TitreNumStage.Text = "Numero de stage";
         this.LB_TitreNumStage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // LB_NumStage
         // 
         this.LB_NumStage.Font = new System.Drawing.Font("Kristen ITC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.LB_NumStage.Location = new System.Drawing.Point(14, 84);
         this.LB_NumStage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.LB_NumStage.Name = "LB_NumStage";
         this.LB_NumStage.Size = new System.Drawing.Size(270, 20);
         this.LB_NumStage.TabIndex = 7;
         this.LB_NumStage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // FB_Quit
         // 
         this.FB_Quit.BackColor = System.Drawing.Color.Yellow;
         this.FB_Quit.BackgroundImage = global::GestionDeStage.Properties.Resources.CloseNormal;
         this.FB_Quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.FB_Quit.ImageClick = global::GestionDeStage.Properties.Resources.CloseClick;
         this.FB_Quit.ImageDisable = global::GestionDeStage.Properties.Resources.CloseDisable;
         this.FB_Quit.ImageNeutral = global::GestionDeStage.Properties.Resources.CloseNormal;
         this.FB_Quit.ImageOver = global::GestionDeStage.Properties.Resources.CloseHover;
         this.FB_Quit.Location = new System.Drawing.Point(301, 2);
         this.FB_Quit.Margin = new System.Windows.Forms.Padding(4);
         this.FB_Quit.Name = "FB_Quit";
         this.FB_Quit.Size = new System.Drawing.Size(20, 20);
         this.FB_Quit.TabIndex = 0;
         this.FB_Quit.Click += new System.EventHandler(this.FB_Quit_Click);
         // 
         // FB_Suivant
         // 
         this.FB_Suivant.BackgroundImage = global::GestionDeStage.Properties.Resources.RetourNormalDoite;
         this.FB_Suivant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.FB_Suivant.ImageClick = global::GestionDeStage.Properties.Resources.RetourClickDoite;
         this.FB_Suivant.ImageDisable = global::GestionDeStage.Properties.Resources.RetourDisableDoite;
         this.FB_Suivant.ImageNeutral = global::GestionDeStage.Properties.Resources.RetourNormalDoite;
         this.FB_Suivant.ImageOver = global::GestionDeStage.Properties.Resources.RetourHoverDoite;
         this.FB_Suivant.Location = new System.Drawing.Point(154, 204);
         this.FB_Suivant.Name = "FB_Suivant";
         this.FB_Suivant.Size = new System.Drawing.Size(22, 21);
         this.FB_Suivant.TabIndex = 1;
         this.FB_Suivant.Click += new System.EventHandler(this.FB_Suivant_Click);
         // 
         // FB_Precedant
         // 
         this.FB_Precedant.BackgroundImage = global::GestionDeStage.Properties.Resources.RetourNormal;
         this.FB_Precedant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.FB_Precedant.ImageClick = global::GestionDeStage.Properties.Resources.RetourClick;
         this.FB_Precedant.ImageDisable = global::GestionDeStage.Properties.Resources.RetourDisable;
         this.FB_Precedant.ImageNeutral = global::GestionDeStage.Properties.Resources.RetourNormal;
         this.FB_Precedant.ImageOver = global::GestionDeStage.Properties.Resources.RetourHover;
         this.FB_Precedant.Location = new System.Drawing.Point(121, 204);
         this.FB_Precedant.Name = "FB_Precedant";
         this.FB_Precedant.Size = new System.Drawing.Size(23, 21);
         this.FB_Precedant.TabIndex = 0;
         this.FB_Precedant.Click += new System.EventHandler(this.FB_Precedant_Click);
         // 
         // FB_Modifier
         // 
         this.FB_Modifier.BackgroundImage = global::GestionDeStage.Properties.Resources.ModifierNormal;
         this.FB_Modifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.FB_Modifier.ImageClick = global::GestionDeStage.Properties.Resources.ModifierClick;
         this.FB_Modifier.ImageDisable = global::GestionDeStage.Properties.Resources.ModifierDisable;
         this.FB_Modifier.ImageNeutral = global::GestionDeStage.Properties.Resources.ModifierNormal;
         this.FB_Modifier.ImageOver = global::GestionDeStage.Properties.Resources.ModifierHover;
         this.FB_Modifier.Location = new System.Drawing.Point(185, 39);
         this.FB_Modifier.Margin = new System.Windows.Forms.Padding(4);
         this.FB_Modifier.Name = "FB_Modifier";
         this.FB_Modifier.Size = new System.Drawing.Size(97, 21);
         this.FB_Modifier.TabIndex = 2;
         this.FB_Modifier.Click += new System.EventHandler(this.FB_Modifier_Click);
         // 
         // FB_Ajouter
         // 
         this.FB_Ajouter.BackgroundImage = global::GestionDeStage.Properties.Resources.AjouterNormal;
         this.FB_Ajouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.FB_Ajouter.ImageClick = global::GestionDeStage.Properties.Resources.AjouterClick;
         this.FB_Ajouter.ImageDisable = global::GestionDeStage.Properties.Resources.AjouterDisable;
         this.FB_Ajouter.ImageNeutral = global::GestionDeStage.Properties.Resources.AjouterNormal;
         this.FB_Ajouter.ImageOver = global::GestionDeStage.Properties.Resources.AjouterHover;
         this.FB_Ajouter.Location = new System.Drawing.Point(185, 12);
         this.FB_Ajouter.Margin = new System.Windows.Forms.Padding(4);
         this.FB_Ajouter.Name = "FB_Ajouter";
         this.FB_Ajouter.Size = new System.Drawing.Size(97, 21);
         this.FB_Ajouter.TabIndex = 1;
         this.FB_Ajouter.Click += new System.EventHandler(this.FB_Ajouter_Click);
         // 
         // FB_Supprimer
         // 
         this.FB_Supprimer.BackgroundImage = global::GestionDeStage.Properties.Resources.SupprimerNormal;
         this.FB_Supprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.FB_Supprimer.ImageClick = global::GestionDeStage.Properties.Resources.SupprimerClick;
         this.FB_Supprimer.ImageDisable = global::GestionDeStage.Properties.Resources.SupprimerDisable;
         this.FB_Supprimer.ImageNeutral = global::GestionDeStage.Properties.Resources.SupprimerNormal;
         this.FB_Supprimer.ImageOver = global::GestionDeStage.Properties.Resources.SupprimerHover;
         this.FB_Supprimer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
         this.FB_Supprimer.Location = new System.Drawing.Point(185, 66);
         this.FB_Supprimer.Margin = new System.Windows.Forms.Padding(4);
         this.FB_Supprimer.Name = "FB_Supprimer";
         this.FB_Supprimer.Size = new System.Drawing.Size(97, 21);
         this.FB_Supprimer.TabIndex = 0;
         this.FB_Supprimer.Click += new System.EventHandler(this.FB_Supprimer_Click);
         // 
         // FormPrincipale
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.MediumSeaGreen;
         this.ClientSize = new System.Drawing.Size(323, 381);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.FB_Quit);
         this.Controls.Add(this.panel1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "FormPrincipale";
         this.Text = "Gestion des Stages";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipale_FormClosing);
         this.Load += new System.EventHandler(this.FormPrincipale_Load);
         this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
         this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
         this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
         this.panel1.ResumeLayout(false);
         this.panel3.ResumeLayout(false);
         this.panel2.ResumeLayout(false);
         this.panel2.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Panel panel1;
      private FlashButton.FlashButton FB_Quit;
      private System.Windows.Forms.Label label1;
      private FlashButton.FlashButton FB_Supprimer;
      private FlashButton.FlashButton FB_Ajouter;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox TB_NumStage;
      private FlashButton.FlashButton FB_Modifier;
      private System.Windows.Forms.Panel panel3;
      private FlashButton.FlashButton FB_Suivant;
      private FlashButton.FlashButton FB_Precedant;
      private System.Windows.Forms.ListBox LBX_Entreprise;
      private System.Windows.Forms.Label LB_Type;
      private System.Windows.Forms.Label LB_Description;
      private System.Windows.Forms.Label LB_TitreType;
      private System.Windows.Forms.Label LB_TitreDescription;
      private System.Windows.Forms.Label LB_TitreNumStage;
      private System.Windows.Forms.Label LB_NumStage;
   }
}

