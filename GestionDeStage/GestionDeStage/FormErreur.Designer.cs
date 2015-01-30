namespace GestionDeStage
{
   partial class FormErreur
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
         this.FB_Continuer = new FlashButton.FlashButton();
         this.FB_Quitter = new FlashButton.FlashButton();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.LB_Description = new System.Windows.Forms.Label();
         this.LB_Text = new System.Windows.Forms.Label();
         this.FB_Quit = new FlashButton.FlashButton();
         this.panel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.PaleGreen;
         this.panel1.Controls.Add(this.FB_Continuer);
         this.panel1.Controls.Add(this.FB_Quitter);
         this.panel1.Controls.Add(this.pictureBox1);
         this.panel1.Controls.Add(this.LB_Description);
         this.panel1.Location = new System.Drawing.Point(2, 22);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(279, 117);
         this.panel1.TabIndex = 0;
         // 
         // FB_Continuer
         // 
         this.FB_Continuer.BackgroundImage = global::GestionDeStage.Properties.Resources.ContinuerNormal;
         this.FB_Continuer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.FB_Continuer.ImageClick = global::GestionDeStage.Properties.Resources.ContinuerClick;
         this.FB_Continuer.ImageDisable = global::GestionDeStage.Properties.Resources.ContinuerDisable;
         this.FB_Continuer.ImageNeutral = global::GestionDeStage.Properties.Resources.ContinuerNormal;
         this.FB_Continuer.ImageOver = global::GestionDeStage.Properties.Resources.ContinuerHover;
         this.FB_Continuer.Location = new System.Drawing.Point(48, 92);
         this.FB_Continuer.Name = "FB_Continuer";
         this.FB_Continuer.Size = new System.Drawing.Size(89, 17);
         this.FB_Continuer.TabIndex = 4;
         this.FB_Continuer.Click += new System.EventHandler(this.FB_Continuer_Click);
         // 
         // FB_Quitter
         // 
         this.FB_Quitter.BackgroundImage = global::GestionDeStage.Properties.Resources.FermerNormal;
         this.FB_Quitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.FB_Quitter.ImageClick = global::GestionDeStage.Properties.Resources.FermerClick;
         this.FB_Quitter.ImageDisable = global::GestionDeStage.Properties.Resources.FermerDisable;
         this.FB_Quitter.ImageNeutral = global::GestionDeStage.Properties.Resources.FermerNormal;
         this.FB_Quitter.ImageOver = global::GestionDeStage.Properties.Resources.FermerHover;
         this.FB_Quitter.Location = new System.Drawing.Point(143, 92);
         this.FB_Quitter.Name = "FB_Quitter";
         this.FB_Quitter.Size = new System.Drawing.Size(89, 17);
         this.FB_Quitter.TabIndex = 3;
         this.FB_Quitter.Click += new System.EventHandler(this.FB_Quitter_Click);
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = global::GestionDeStage.Properties.Resources.error;
         this.pictureBox1.Location = new System.Drawing.Point(204, 7);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(66, 79);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox1.TabIndex = 2;
         this.pictureBox1.TabStop = false;
         // 
         // LB_Description
         // 
         this.LB_Description.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.LB_Description.Location = new System.Drawing.Point(11, 7);
         this.LB_Description.Name = "LB_Description";
         this.LB_Description.Size = new System.Drawing.Size(187, 79);
         this.LB_Description.TabIndex = 1;
         this.LB_Description.Text = "label2";
         this.LB_Description.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // LB_Text
         // 
         this.LB_Text.AutoSize = true;
         this.LB_Text.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.LB_Text.ForeColor = System.Drawing.Color.White;
         this.LB_Text.Location = new System.Drawing.Point(4, 0);
         this.LB_Text.Name = "LB_Text";
         this.LB_Text.Size = new System.Drawing.Size(60, 22);
         this.LB_Text.TabIndex = 2;
         this.LB_Text.Text = "Erreur";
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
         this.FB_Quit.Location = new System.Drawing.Point(260, 1);
         this.FB_Quit.Name = "FB_Quit";
         this.FB_Quit.Size = new System.Drawing.Size(20, 20);
         this.FB_Quit.TabIndex = 1;
         // 
         // FormErreur
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.MediumSeaGreen;
         this.ClientSize = new System.Drawing.Size(283, 141);
         this.Controls.Add(this.LB_Text);
         this.Controls.Add(this.FB_Quit);
         this.Controls.Add(this.panel1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "FormErreur";
         this.Text = "FormErreur";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormErreur_FormClosing);
         this.Load += new System.EventHandler(this.FormErreur_Load);
         this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormErreur_MouseDown);
         this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormErreur_MouseMove);
         this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormErreur_MouseUp);
         this.panel1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Panel panel1;
      private FlashButton.FlashButton FB_Quit;
      private System.Windows.Forms.Label LB_Text;
      private System.Windows.Forms.Label LB_Description;
      private System.Windows.Forms.PictureBox pictureBox1;
      private FlashButton.FlashButton FB_Quitter;
      private FlashButton.FlashButton FB_Continuer;
   }
}