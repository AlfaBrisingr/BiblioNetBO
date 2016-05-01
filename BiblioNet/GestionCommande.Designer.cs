namespace BiblioNet
{
    partial class GestionCommande
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
            this.Titre = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.Label();
            this.Prénom = new System.Windows.Forms.Label();
            this.NbCommand = new System.Windows.Forms.Label();
            this.buttonDetail = new System.Windows.Forms.Button();
            this.LblCourant = new System.Windows.Forms.Label();
            this.LblMaximum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDebut = new System.Windows.Forms.Button();
            this.buttonPrecedent = new System.Windows.Forms.Button();
            this.buttonFin = new System.Windows.Forms.Button();
            this.buttonSuivant = new System.Windows.Forms.Button();
            this.LblNom = new System.Windows.Forms.Label();
            this.LblPrenom = new System.Windows.Forms.Label();
            this.LblComande = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Titre
            // 
            this.Titre.AutoSize = true;
            this.Titre.Location = new System.Drawing.Point(246, 38);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(120, 13);
            this.Titre.TabIndex = 0;
            this.Titre.Text = "Nombre de Commandes";
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(52, 92);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(35, 13);
            this.Nom.TabIndex = 1;
            this.Nom.Text = "Nom :";
            // 
            // Prénom
            // 
            this.Prénom.AutoSize = true;
            this.Prénom.Location = new System.Drawing.Point(52, 135);
            this.Prénom.Name = "Prénom";
            this.Prénom.Size = new System.Drawing.Size(49, 13);
            this.Prénom.TabIndex = 2;
            this.Prénom.Text = "Prénom :";
            // 
            // NbCommand
            // 
            this.NbCommand.AutoSize = true;
            this.NbCommand.Location = new System.Drawing.Point(52, 177);
            this.NbCommand.Name = "NbCommand";
            this.NbCommand.Size = new System.Drawing.Size(109, 13);
            this.NbCommand.TabIndex = 3;
            this.NbCommand.Text = "Numéro Commande : ";
            // 
            // buttonDetail
            // 
            this.buttonDetail.Location = new System.Drawing.Point(55, 213);
            this.buttonDetail.Name = "buttonDetail";
            this.buttonDetail.Size = new System.Drawing.Size(90, 32);
            this.buttonDetail.TabIndex = 4;
            this.buttonDetail.Text = "Détails";
            this.buttonDetail.UseVisualStyleBackColor = true;
            this.buttonDetail.Click += new System.EventHandler(this.buttonDetail_Click);
            // 
            // LblCourant
            // 
            this.LblCourant.AutoSize = true;
            this.LblCourant.Location = new System.Drawing.Point(274, 308);
            this.LblCourant.Name = "LblCourant";
            this.LblCourant.Size = new System.Drawing.Size(13, 13);
            this.LblCourant.TabIndex = 5;
            this.LblCourant.Text = "?";
            // 
            // LblMaximum
            // 
            this.LblMaximum.AutoSize = true;
            this.LblMaximum.Location = new System.Drawing.Point(311, 308);
            this.LblMaximum.Name = "LblMaximum";
            this.LblMaximum.Size = new System.Drawing.Size(13, 13);
            this.LblMaximum.TabIndex = 6;
            this.LblMaximum.Text = "?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(9, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "|";
            // 
            // buttonDebut
            // 
            this.buttonDebut.Image = global::BiblioNet.Properties.Resources.demarrer_icone_5230_32;
            this.buttonDebut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDebut.Location = new System.Drawing.Point(20, 291);
            this.buttonDebut.Name = "buttonDebut";
            this.buttonDebut.Size = new System.Drawing.Size(110, 46);
            this.buttonDebut.TabIndex = 11;
            this.buttonDebut.Text = "Début";
            this.buttonDebut.UseVisualStyleBackColor = true;
            this.buttonDebut.Click += new System.EventHandler(this.buttonDebut_Click);
            // 
            // buttonPrecedent
            // 
            this.buttonPrecedent.Image = global::BiblioNet.Properties.Resources.fleche_erreur_a_gauche_precedente_icone_3917_32;
            this.buttonPrecedent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPrecedent.Location = new System.Drawing.Point(136, 291);
            this.buttonPrecedent.Name = "buttonPrecedent";
            this.buttonPrecedent.Size = new System.Drawing.Size(110, 46);
            this.buttonPrecedent.TabIndex = 10;
            this.buttonPrecedent.Text = "Précédent";
            this.buttonPrecedent.UseVisualStyleBackColor = true;
            this.buttonPrecedent.Click += new System.EventHandler(this.buttonPrecedent_Click);
            // 
            // buttonFin
            // 
            this.buttonFin.Image = global::BiblioNet.Properties.Resources.finition_icone_9683_32;
            this.buttonFin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFin.Location = new System.Drawing.Point(469, 291);
            this.buttonFin.Name = "buttonFin";
            this.buttonFin.Size = new System.Drawing.Size(110, 46);
            this.buttonFin.TabIndex = 9;
            this.buttonFin.Text = "Fin";
            this.buttonFin.UseVisualStyleBackColor = true;
            this.buttonFin.Click += new System.EventHandler(this.buttonFin_Click);
            // 
            // buttonSuivant
            // 
            this.buttonSuivant.Image = global::BiblioNet.Properties.Resources.fleche_a_cote_a_droite_icone_6873_32;
            this.buttonSuivant.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSuivant.Location = new System.Drawing.Point(353, 291);
            this.buttonSuivant.Name = "buttonSuivant";
            this.buttonSuivant.Size = new System.Drawing.Size(110, 46);
            this.buttonSuivant.TabIndex = 8;
            this.buttonSuivant.Text = "Suivant";
            this.buttonSuivant.UseVisualStyleBackColor = true;
            this.buttonSuivant.Click += new System.EventHandler(this.buttonSuivant_Click);
            // 
            // LblNom
            // 
            this.LblNom.AutoSize = true;
            this.LblNom.Location = new System.Drawing.Point(93, 92);
            this.LblNom.Name = "LblNom";
            this.LblNom.Size = new System.Drawing.Size(16, 13);
            this.LblNom.TabIndex = 15;
            this.LblNom.Text = "...";
            // 
            // LblPrenom
            // 
            this.LblPrenom.AutoSize = true;
            this.LblPrenom.Location = new System.Drawing.Point(107, 135);
            this.LblPrenom.Name = "LblPrenom";
            this.LblPrenom.Size = new System.Drawing.Size(16, 13);
            this.LblPrenom.TabIndex = 16;
            this.LblPrenom.Text = "...";
            // 
            // LblComande
            // 
            this.LblComande.AutoSize = true;
            this.LblComande.Location = new System.Drawing.Point(184, 177);
            this.LblComande.Name = "LblComande";
            this.LblComande.Size = new System.Drawing.Size(16, 13);
            this.LblComande.TabIndex = 17;
            this.LblComande.Text = "...";
            // 
            // GestionCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 457);
            this.Controls.Add(this.LblComande);
            this.Controls.Add(this.LblPrenom);
            this.Controls.Add(this.LblNom);
            this.Controls.Add(this.buttonDebut);
            this.Controls.Add(this.buttonPrecedent);
            this.Controls.Add(this.buttonFin);
            this.Controls.Add(this.buttonSuivant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblMaximum);
            this.Controls.Add(this.LblCourant);
            this.Controls.Add(this.buttonDetail);
            this.Controls.Add(this.NbCommand);
            this.Controls.Add(this.Prénom);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.Titre);
            this.Name = "GestionCommande";
            this.Text = "GestionCommande";
            this.Load += new System.EventHandler(this.GestionCommande_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titre;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.Label Prénom;
        private System.Windows.Forms.Label NbCommand;
        private System.Windows.Forms.Button buttonDetail;
        private System.Windows.Forms.Label LblCourant;
        private System.Windows.Forms.Label LblMaximum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSuivant;
        private System.Windows.Forms.Button buttonFin;
        private System.Windows.Forms.Button buttonPrecedent;
        private System.Windows.Forms.Button buttonDebut;
        private System.Windows.Forms.Label LblNom;
        private System.Windows.Forms.Label LblPrenom;
        private System.Windows.Forms.Label LblComande;
    }
}