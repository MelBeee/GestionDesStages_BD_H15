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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_NumStage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FB_Quit = new FlashButton.FlashButton();
            this.FB_Modifier = new FlashButton.FlashButton();
            this.FB_Ajouter = new FlashButton.FlashButton();
            this.FB_Supprimer = new FlashButton.FlashButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 485);
            this.panel1.TabIndex = 0;
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
            this.panel2.Location = new System.Drawing.Point(13, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 123);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero de Stage";
            // 
            // TB_NumStage
            // 
            this.TB_NumStage.Location = new System.Drawing.Point(51, 60);
            this.TB_NumStage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TB_NumStage.Name = "TB_NumStage";
            this.TB_NumStage.Size = new System.Drawing.Size(132, 22);
            this.TB_NumStage.TabIndex = 3;
            this.TB_NumStage.TextChanged += new System.EventHandler(this.TB_NumStage_TextChanged);
            this.TB_NumStage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_NumStage_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestion des Stages";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
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
            this.FB_Quit.Location = new System.Drawing.Point(401, 2);
            this.FB_Quit.Margin = new System.Windows.Forms.Padding(5);
            this.FB_Quit.Name = "FB_Quit";
            this.FB_Quit.Size = new System.Drawing.Size(27, 25);
            this.FB_Quit.TabIndex = 0;
            this.FB_Quit.Click += new System.EventHandler(this.FB_Quit_Click);
            // 
            // FB_Modifier
            // 
            this.FB_Modifier.BackgroundImage = global::GestionDeStage.Properties.Resources.AjouterNormal;
            this.FB_Modifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB_Modifier.ImageClick = global::GestionDeStage.Properties.Resources.ModifierClick;
            this.FB_Modifier.ImageDisable = global::GestionDeStage.Properties.Resources.ModifierDisable;
            this.FB_Modifier.ImageNeutral = global::GestionDeStage.Properties.Resources.ModifierNormal;
            this.FB_Modifier.ImageOver = global::GestionDeStage.Properties.Resources.ModifierHover;
            this.FB_Modifier.Location = new System.Drawing.Point(247, 48);
            this.FB_Modifier.Margin = new System.Windows.Forms.Padding(5);
            this.FB_Modifier.Name = "FB_Modifier";
            this.FB_Modifier.Size = new System.Drawing.Size(129, 26);
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
            this.FB_Ajouter.Location = new System.Drawing.Point(247, 15);
            this.FB_Ajouter.Margin = new System.Windows.Forms.Padding(5);
            this.FB_Ajouter.Name = "FB_Ajouter";
            this.FB_Ajouter.Size = new System.Drawing.Size(129, 26);
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
            this.FB_Supprimer.Location = new System.Drawing.Point(247, 81);
            this.FB_Supprimer.Margin = new System.Windows.Forms.Padding(5);
            this.FB_Supprimer.Name = "FB_Supprimer";
            this.FB_Supprimer.Size = new System.Drawing.Size(129, 26);
            this.FB_Supprimer.TabIndex = 0;
            this.FB_Supprimer.Click += new System.EventHandler(this.FB_Supprimer_Click);
            // 
            // FormPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(431, 517);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FB_Quit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPrincipale";
            this.Text = "Gestion des Stages";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipale_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipale_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
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
   }
}

