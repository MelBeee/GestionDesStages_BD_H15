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
         this.FB_Annuler = new FlashButton.FlashButton();
         this.FB_Appliquer = new FlashButton.FlashButton();
         this.CB_Entreprise = new System.Windows.Forms.ComboBox();
         this.TB_Description = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.LB_AjoutModif = new System.Windows.Forms.Label();
         this.FB_Quit = new FlashButton.FlashButton();
         this.RB_Industriel = new System.Windows.Forms.RadioButton();
         this.RB_Gestion = new System.Windows.Forms.RadioButton();
         this.panel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.LightGreen;
         this.panel1.Controls.Add(this.RB_Gestion);
         this.panel1.Controls.Add(this.RB_Industriel);
         this.panel1.Controls.Add(this.FB_Annuler);
         this.panel1.Controls.Add(this.FB_Appliquer);
         this.panel1.Controls.Add(this.CB_Entreprise);
         this.panel1.Controls.Add(this.TB_Description);
         this.panel1.Controls.Add(this.label3);
         this.panel1.Controls.Add(this.label2);
         this.panel1.Controls.Add(this.label1);
         this.panel1.Location = new System.Drawing.Point(2, 24);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(286, 239);
         this.panel1.TabIndex = 2;
         // 
         // FB_Annuler
         // 
         this.FB_Annuler.BackgroundImage = global::GestionDeStage.Properties.Resources.AnnulerNormal;
         this.FB_Annuler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
         this.FB_Annuler.ImageClick = global::GestionDeStage.Properties.Resources.AnnulerClick;
         this.FB_Annuler.ImageDisable = global::GestionDeStage.Properties.Resources.AnnulerDisable;
         this.FB_Annuler.ImageNeutral = global::GestionDeStage.Properties.Resources.AnnulerNormal;
         this.FB_Annuler.ImageOver = global::GestionDeStage.Properties.Resources.AnnulerHover;
         this.FB_Annuler.Location = new System.Drawing.Point(146, 204);
         this.FB_Annuler.Name = "FB_Annuler";
         this.FB_Annuler.Size = new System.Drawing.Size(99, 20);
         this.FB_Annuler.TabIndex = 7;
         this.FB_Annuler.Click += new System.EventHandler(this.flashButton2_Click);
         // 
         // FB_Appliquer
         // 
         this.FB_Appliquer.BackgroundImage = global::GestionDeStage.Properties.Resources.AppliquerNormal;
         this.FB_Appliquer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
         this.FB_Appliquer.ImageClick = global::GestionDeStage.Properties.Resources.AppliquerClick;
         this.FB_Appliquer.ImageDisable = global::GestionDeStage.Properties.Resources.AppliquerDisable;
         this.FB_Appliquer.ImageNeutral = global::GestionDeStage.Properties.Resources.AppliquerNormal;
         this.FB_Appliquer.ImageOver = global::GestionDeStage.Properties.Resources.AppliquerHover;
         this.FB_Appliquer.Location = new System.Drawing.Point(44, 204);
         this.FB_Appliquer.Name = "FB_Appliquer";
         this.FB_Appliquer.Size = new System.Drawing.Size(96, 20);
         this.FB_Appliquer.TabIndex = 6;
         // 
         // CB_Entreprise
         // 
         this.CB_Entreprise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.CB_Entreprise.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.CB_Entreprise.FormattingEnabled = true;
         this.CB_Entreprise.Location = new System.Drawing.Point(51, 172);
         this.CB_Entreprise.Name = "CB_Entreprise";
         this.CB_Entreprise.Size = new System.Drawing.Size(185, 24);
         this.CB_Entreprise.TabIndex = 5;
         // 
         // TB_Description
         // 
         this.TB_Description.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.TB_Description.Location = new System.Drawing.Point(10, 26);
         this.TB_Description.MaxLength = 100;
         this.TB_Description.Multiline = true;
         this.TB_Description.Name = "TB_Description";
         this.TB_Description.Size = new System.Drawing.Size(267, 77);
         this.TB_Description.TabIndex = 3;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.BackColor = System.Drawing.Color.LightGreen;
         this.label3.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.ForeColor = System.Drawing.Color.Black;
         this.label3.Location = new System.Drawing.Point(101, 5);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(85, 18);
         this.label3.TabIndex = 2;
         this.label3.Text = "Description";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.ForeColor = System.Drawing.Color.Black;
         this.label2.Location = new System.Drawing.Point(106, 151);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(75, 18);
         this.label2.TabIndex = 1;
         this.label2.Text = "Entreprise";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.Black;
         this.label1.Location = new System.Drawing.Point(124, 108);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(39, 18);
         this.label1.TabIndex = 0;
         this.label1.Text = "Type";
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
         this.FB_Quit.Name = "FB_Quit";
         this.FB_Quit.Size = new System.Drawing.Size(20, 20);
         this.FB_Quit.TabIndex = 1;
         this.FB_Quit.Click += new System.EventHandler(this.FB_Quit_Click);
         // 
         // RB_Industriel
         // 
         this.RB_Industriel.AutoSize = true;
         this.RB_Industriel.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.RB_Industriel.Location = new System.Drawing.Point(148, 128);
         this.RB_Industriel.Name = "RB_Industriel";
         this.RB_Industriel.Size = new System.Drawing.Size(78, 20);
         this.RB_Industriel.TabIndex = 8;
         this.RB_Industriel.TabStop = true;
         this.RB_Industriel.Text = "Industriel";
         this.RB_Industriel.UseVisualStyleBackColor = true;
         // 
         // RB_Gestion
         // 
         this.RB_Gestion.AutoSize = true;
         this.RB_Gestion.Font = new System.Drawing.Font("Kristen ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.RB_Gestion.Location = new System.Drawing.Point(78, 128);
         this.RB_Gestion.Name = "RB_Gestion";
         this.RB_Gestion.Size = new System.Drawing.Size(68, 20);
         this.RB_Gestion.TabIndex = 9;
         this.RB_Gestion.TabStop = true;
         this.RB_Gestion.Text = "Gestion";
         this.RB_Gestion.UseVisualStyleBackColor = true;
         // 
         // AjoutModifStage
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.MediumSeaGreen;
         this.ClientSize = new System.Drawing.Size(290, 265);
         this.Controls.Add(this.LB_AjoutModif);
         this.Controls.Add(this.FB_Quit);
         this.Controls.Add(this.panel1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "AjoutModifStage";
         this.Text = "AjoutModifStage";
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
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
      private FlashButton.FlashButton FB_Annuler;
      private FlashButton.FlashButton FB_Appliquer;
      private System.Windows.Forms.ComboBox CB_Entreprise;
      private System.Windows.Forms.RadioButton RB_Gestion;
      private System.Windows.Forms.RadioButton RB_Industriel;
   }
}