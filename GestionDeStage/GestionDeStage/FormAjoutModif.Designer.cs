﻿namespace GestionDeStage
{
   partial class FormAjoutModif
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.panel1 = new System.Windows.Forms.Panel();
         this.CB_Entreprise = new System.Windows.Forms.ComboBox();
         this.label1 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.LB_TitreDescription = new System.Windows.Forms.Label();
         this.LB_NomEnt = new System.Windows.Forms.Label();
         this.RB_Gestion = new System.Windows.Forms.RadioButton();
         this.RB_Industriel = new System.Windows.Forms.RadioButton();
         this.FB_Annuler = new FlashButton.FlashButton();
         this.FB_Appliquer = new FlashButton.FlashButton();
         this.TB_Description = new System.Windows.Forms.TextBox();
         this.LB_AjoutModif = new System.Windows.Forms.Label();
         this.FB_Quit = new FlashButton.FlashButton();
         this.panel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.LightGreen;
         this.panel1.Controls.Add(this.CB_Entreprise);
         this.panel1.Controls.Add(this.label1);
         this.panel1.Controls.Add(this.label3);
         this.panel1.Controls.Add(this.LB_TitreDescription);
         this.panel1.Controls.Add(this.LB_NomEnt);
         this.panel1.Controls.Add(this.RB_Gestion);
         this.panel1.Controls.Add(this.RB_Industriel);
         this.panel1.Controls.Add(this.FB_Annuler);
         this.panel1.Controls.Add(this.FB_Appliquer);
         this.panel1.Controls.Add(this.TB_Description);
         this.panel1.Location = new System.Drawing.Point(2, 24);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(286, 238);
         this.panel1.TabIndex = 2;
         // 
         // CB_Entreprise
         // 
         this.CB_Entreprise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.CB_Entreprise.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.CB_Entreprise.FormattingEnabled = true;
         this.CB_Entreprise.Location = new System.Drawing.Point(51, 167);
         this.CB_Entreprise.Name = "CB_Entreprise";
         this.CB_Entreprise.Size = new System.Drawing.Size(185, 25);
         this.CB_Entreprise.TabIndex = 5;
         this.CB_Entreprise.SelectedIndexChanged += new System.EventHandler(this.CB_Entreprise_SelectedIndexChanged);
         // 
         // label1
         // 
         this.label1.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(10, 149);
         this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(267, 18);
         this.label1.TabIndex = 13;
         this.label1.Text = "Entreprise ";
         this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // label3
         // 
         this.label3.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(10, 89);
         this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(267, 18);
         this.label3.TabIndex = 12;
         this.label3.Text = "Type de stage";
         this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // LB_TitreDescription
         // 
         this.LB_TitreDescription.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.LB_TitreDescription.Location = new System.Drawing.Point(10, 7);
         this.LB_TitreDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.LB_TitreDescription.Name = "LB_TitreDescription";
         this.LB_TitreDescription.Size = new System.Drawing.Size(267, 18);
         this.LB_TitreDescription.TabIndex = 11;
         this.LB_TitreDescription.Text = "Description de stage";
         this.LB_TitreDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // LB_NomEnt
         // 
         this.LB_NomEnt.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.LB_NomEnt.Location = new System.Drawing.Point(11, 169);
         this.LB_NomEnt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         this.LB_NomEnt.Name = "LB_NomEnt";
         this.LB_NomEnt.Size = new System.Drawing.Size(264, 19);
         this.LB_NomEnt.TabIndex = 10;
         this.LB_NomEnt.Text = "label4";
         this.LB_NomEnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // RB_Gestion
         // 
         this.RB_Gestion.AutoSize = true;
         this.RB_Gestion.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.RB_Gestion.Location = new System.Drawing.Point(57, 126);
         this.RB_Gestion.Name = "RB_Gestion";
         this.RB_Gestion.Size = new System.Drawing.Size(173, 21);
         this.RB_Gestion.TabIndex = 9;
         this.RB_Gestion.TabStop = true;
         this.RB_Gestion.Text = "Informatique de Gestion";
         this.RB_Gestion.UseVisualStyleBackColor = true;
         this.RB_Gestion.CheckedChanged += new System.EventHandler(this.RB_Gestion_CheckedChanged);
         // 
         // RB_Industriel
         // 
         this.RB_Industriel.AutoSize = true;
         this.RB_Industriel.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.RB_Industriel.Location = new System.Drawing.Point(55, 107);
         this.RB_Industriel.Name = "RB_Industriel";
         this.RB_Industriel.Size = new System.Drawing.Size(176, 21);
         this.RB_Industriel.TabIndex = 8;
         this.RB_Industriel.TabStop = true;
         this.RB_Industriel.Text = "Informatique Industrielle";
         this.RB_Industriel.UseVisualStyleBackColor = true;
         this.RB_Industriel.CheckedChanged += new System.EventHandler(this.RB_Industriel_CheckedChanged);
         // 
         // FB_Annuler
         // 
         this.FB_Annuler.BackgroundImage = global::GestionDeStage.Properties.Resources.AnnulerNormal;
         this.FB_Annuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.FB_Annuler.ImageClick = global::GestionDeStage.Properties.Resources.AnnulerClick;
         this.FB_Annuler.ImageDisable = global::GestionDeStage.Properties.Resources.AnnulerDisable;
         this.FB_Annuler.ImageNeutral = global::GestionDeStage.Properties.Resources.AnnulerNormal;
         this.FB_Annuler.ImageOver = global::GestionDeStage.Properties.Resources.AnnulerHover;
         this.FB_Annuler.Location = new System.Drawing.Point(146, 202);
         this.FB_Annuler.Margin = new System.Windows.Forms.Padding(4);
         this.FB_Annuler.Name = "FB_Annuler";
         this.FB_Annuler.Size = new System.Drawing.Size(99, 20);
         this.FB_Annuler.TabIndex = 7;
         this.FB_Annuler.Click += new System.EventHandler(this.flashButton2_Click);
         // 
         // FB_Appliquer
         // 
         this.FB_Appliquer.BackgroundImage = global::GestionDeStage.Properties.Resources.AppliquerNormal;
         this.FB_Appliquer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.FB_Appliquer.ImageClick = global::GestionDeStage.Properties.Resources.AppliquerClick;
         this.FB_Appliquer.ImageDisable = global::GestionDeStage.Properties.Resources.AppliquerDisable;
         this.FB_Appliquer.ImageNeutral = global::GestionDeStage.Properties.Resources.AppliquerNormal;
         this.FB_Appliquer.ImageOver = global::GestionDeStage.Properties.Resources.AppliquerHover;
         this.FB_Appliquer.Location = new System.Drawing.Point(44, 202);
         this.FB_Appliquer.Margin = new System.Windows.Forms.Padding(4);
         this.FB_Appliquer.Name = "FB_Appliquer";
         this.FB_Appliquer.Size = new System.Drawing.Size(96, 20);
         this.FB_Appliquer.TabIndex = 6;
         this.FB_Appliquer.Click += new System.EventHandler(this.FB_Appliquer_Click);
         // 
         // TB_Description
         // 
         this.TB_Description.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.TB_Description.Location = new System.Drawing.Point(10, 26);
         this.TB_Description.MaxLength = 100;
         this.TB_Description.Multiline = true;
         this.TB_Description.Name = "TB_Description";
         this.TB_Description.Size = new System.Drawing.Size(267, 55);
         this.TB_Description.TabIndex = 3;
         this.TB_Description.TextChanged += new System.EventHandler(this.TB_Description_TextChanged);
         // 
         // LB_AjoutModif
         // 
         this.LB_AjoutModif.AutoSize = true;
         this.LB_AjoutModif.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.LB_AjoutModif.ForeColor = System.Drawing.Color.White;
         this.LB_AjoutModif.Location = new System.Drawing.Point(2, 1);
         this.LB_AjoutModif.Name = "LB_AjoutModif";
         this.LB_AjoutModif.Size = new System.Drawing.Size(149, 22);
         this.LB_AjoutModif.TabIndex = 3;
         this.LB_AjoutModif.Text = "Gestion des Stages";
         this.LB_AjoutModif.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AjoutModifStage_MouseDown);
         this.LB_AjoutModif.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AjoutModifStage_MouseMove);
         this.LB_AjoutModif.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AjoutModifStage_MouseUp);
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
         this.FB_Quit.Location = new System.Drawing.Point(268, 2);
         this.FB_Quit.Margin = new System.Windows.Forms.Padding(4);
         this.FB_Quit.Name = "FB_Quit";
         this.FB_Quit.Size = new System.Drawing.Size(20, 20);
         this.FB_Quit.TabIndex = 1;
         this.FB_Quit.Click += new System.EventHandler(this.FB_Quit_Click);
         // 
         // FormAjoutModif
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.MediumSeaGreen;
         this.ClientSize = new System.Drawing.Size(290, 265);
         this.Controls.Add(this.LB_AjoutModif);
         this.Controls.Add(this.FB_Quit);
         this.Controls.Add(this.panel1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "FormAjoutModif";
         this.Text = "AjoutModifStage";
         this.Load += new System.EventHandler(this.FormAjoutModif_Load);
         this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AjoutModifStage_MouseDown);
         this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AjoutModifStage_MouseMove);
         this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AjoutModifStage_MouseUp);
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private FlashButton.FlashButton FB_Quit;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Label LB_AjoutModif;
      private System.Windows.Forms.TextBox TB_Description;
      private FlashButton.FlashButton FB_Annuler;
      private FlashButton.FlashButton FB_Appliquer;
      private System.Windows.Forms.ComboBox CB_Entreprise;
      private System.Windows.Forms.RadioButton RB_Gestion;
      private System.Windows.Forms.RadioButton RB_Industriel;
      private System.Windows.Forms.Label LB_NomEnt;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label LB_TitreDescription;
   }
}