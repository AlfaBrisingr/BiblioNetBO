namespace BiblioNet
{
    partial class GestionLivre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionLivre));
            this.buttonPrecedent = new System.Windows.Forms.Button();
            this.buttonSuivant = new System.Windows.Forms.Button();
            this.buttonFin = new System.Windows.Forms.Button();
            this.buttonDebut = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelNbPage = new System.Windows.Forms.Label();
            this.LabelPagueCourent = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labNoLivre = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.BoxISBN = new System.Windows.Forms.TextBox();
            this.BoxNomLivre = new System.Windows.Forms.TextBox();
            this.BoxNonAuteur = new System.Windows.Forms.TextBox();
            this.BoxQuantiteStock = new System.Windows.Forms.TextBox();
            this.BoxDateSortie = new System.Windows.Forms.TextBox();
            this.BoxTarif = new System.Windows.Forms.TextBox();
            this.BoxLangue = new System.Windows.Forms.TextBox();
            this.BoxResume = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BoxEdition = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.BoxGenre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonPrecedent
            // 
            this.buttonPrecedent.Image = global::BiblioNet.Properties.Resources.fleche_erreur_a_gauche_precedente_icone_3917_32;
            this.buttonPrecedent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPrecedent.Location = new System.Drawing.Point(163, 301);
            this.buttonPrecedent.Name = "buttonPrecedent";
            this.buttonPrecedent.Size = new System.Drawing.Size(108, 30);
            this.buttonPrecedent.TabIndex = 26;
            this.buttonPrecedent.Text = "Précédent";
            this.buttonPrecedent.UseVisualStyleBackColor = true;
            this.buttonPrecedent.Click += new System.EventHandler(this.buttonPrecedent_Click);
            // 
            // buttonSuivant
            // 
            this.buttonSuivant.Image = global::BiblioNet.Properties.Resources.fleche_a_cote_a_droite_icone_6873_32;
            this.buttonSuivant.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSuivant.Location = new System.Drawing.Point(459, 301);
            this.buttonSuivant.Name = "buttonSuivant";
            this.buttonSuivant.Size = new System.Drawing.Size(107, 30);
            this.buttonSuivant.TabIndex = 25;
            this.buttonSuivant.Text = "Suivant";
            this.buttonSuivant.UseVisualStyleBackColor = true;
            this.buttonSuivant.Click += new System.EventHandler(this.buttonSuivant_Click);
            // 
            // buttonFin
            // 
            this.buttonFin.Image = global::BiblioNet.Properties.Resources.finition_icone_9683_32;
            this.buttonFin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFin.Location = new System.Drawing.Point(604, 301);
            this.buttonFin.Name = "buttonFin";
            this.buttonFin.Size = new System.Drawing.Size(108, 30);
            this.buttonFin.TabIndex = 24;
            this.buttonFin.Text = "Fin";
            this.buttonFin.UseVisualStyleBackColor = true;
            this.buttonFin.Click += new System.EventHandler(this.buttonFin_Click);
            // 
            // buttonDebut
            // 
            this.buttonDebut.Image = global::BiblioNet.Properties.Resources.demarrer_icone_5230_32;
            this.buttonDebut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDebut.Location = new System.Drawing.Point(23, 301);
            this.buttonDebut.Name = "buttonDebut";
            this.buttonDebut.Size = new System.Drawing.Size(108, 30);
            this.buttonDebut.TabIndex = 23;
            this.buttonDebut.Text = "Debut";
            this.buttonDebut.UseVisualStyleBackColor = true;
            this.buttonDebut.Click += new System.EventHandler(this.buttonDebut_Click);
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(307, 366);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 38);
            this.button5.TabIndex = 22;
            this.button5.Text = "Ajouter";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = global::BiblioNet.Properties.Resources.fermer_croix_supprimer_erreurs_sortie_icone_4368_32;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(620, 366);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 38);
            this.button4.TabIndex = 21;
            this.button4.Text = "Annuler";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = global::BiblioNet.Properties.Resources.modifier_texte_icone_4855_32;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 366);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button3.Size = new System.Drawing.Size(109, 38);
            this.button3.TabIndex = 20;
            this.button3.Text = "Modifier";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::BiblioNet.Properties.Resources.dossier_icone_8757_32;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(157, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 38);
            this.button2.TabIndex = 19;
            this.button2.Text = "Valider";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::BiblioNet.Properties.Resources.vide_trash_icone_8487_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(459, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 38);
            this.button1.TabIndex = 18;
            this.button1.Text = "Suprimer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(9, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "|";
            // 
            // LabelNbPage
            // 
            this.LabelNbPage.AutoSize = true;
            this.LabelNbPage.Location = new System.Drawing.Point(358, 310);
            this.LabelNbPage.Name = "LabelNbPage";
            this.LabelNbPage.Size = new System.Drawing.Size(13, 13);
            this.LabelNbPage.TabIndex = 28;
            this.LabelNbPage.Text = "?";
            // 
            // LabelPagueCourent
            // 
            this.LabelPagueCourent.AutoSize = true;
            this.LabelPagueCourent.Location = new System.Drawing.Point(324, 310);
            this.LabelPagueCourent.Name = "LabelPagueCourent";
            this.LabelPagueCourent.Size = new System.Drawing.Size(13, 13);
            this.LabelPagueCourent.TabIndex = 29;
            this.LabelPagueCourent.Text = "?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Livre n° :";
            // 
            // labNoLivre
            // 
            this.labNoLivre.AutoSize = true;
            this.labNoLivre.Location = new System.Drawing.Point(347, 16);
            this.labNoLivre.Name = "labNoLivre";
            this.labNoLivre.Size = new System.Drawing.Size(13, 13);
            this.labNoLivre.TabIndex = 31;
            this.labNoLivre.Text = "?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Auteur :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "QuantiteStock :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "CodeISBN :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(217, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Nom :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "DateSortie :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(347, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Tarif :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 198);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "Resume :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "Langue :";
            // 
            // BoxISBN
            // 
            this.BoxISBN.Location = new System.Drawing.Point(99, 34);
            this.BoxISBN.Name = "BoxISBN";
            this.BoxISBN.Size = new System.Drawing.Size(100, 20);
            this.BoxISBN.TabIndex = 40;
            // 
            // BoxNomLivre
            // 
            this.BoxNomLivre.Location = new System.Drawing.Point(295, 38);
            this.BoxNomLivre.Name = "BoxNomLivre";
            this.BoxNomLivre.Size = new System.Drawing.Size(178, 20);
            this.BoxNomLivre.TabIndex = 41;
            // 
            // BoxNonAuteur
            // 
            this.BoxNonAuteur.Location = new System.Drawing.Point(100, 66);
            this.BoxNonAuteur.Name = "BoxNonAuteur";
            this.BoxNonAuteur.Size = new System.Drawing.Size(99, 20);
            this.BoxNonAuteur.TabIndex = 42;
            // 
            // BoxQuantiteStock
            // 
            this.BoxQuantiteStock.Location = new System.Drawing.Point(295, 66);
            this.BoxQuantiteStock.Name = "BoxQuantiteStock";
            this.BoxQuantiteStock.Size = new System.Drawing.Size(42, 20);
            this.BoxQuantiteStock.TabIndex = 43;
            // 
            // BoxDateSortie
            // 
            this.BoxDateSortie.Location = new System.Drawing.Point(99, 95);
            this.BoxDateSortie.Name = "BoxDateSortie";
            this.BoxDateSortie.Size = new System.Drawing.Size(100, 20);
            this.BoxDateSortie.TabIndex = 44;
            // 
            // BoxTarif
            // 
            this.BoxTarif.Location = new System.Drawing.Point(387, 66);
            this.BoxTarif.Name = "BoxTarif";
            this.BoxTarif.Size = new System.Drawing.Size(32, 20);
            this.BoxTarif.TabIndex = 45;
            // 
            // BoxLangue
            // 
            this.BoxLangue.Location = new System.Drawing.Point(97, 122);
            this.BoxLangue.Name = "BoxLangue";
            this.BoxLangue.Size = new System.Drawing.Size(100, 20);
            this.BoxLangue.TabIndex = 46;
            // 
            // BoxResume
            // 
            this.BoxResume.Location = new System.Drawing.Point(97, 195);
            this.BoxResume.Multiline = true;
            this.BoxResume.Name = "BoxResume";
            this.BoxResume.Size = new System.Drawing.Size(295, 100);
            this.BoxResume.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Edition :";
            // 
            // BoxEdition
            // 
            this.BoxEdition.Location = new System.Drawing.Point(295, 95);
            this.BoxEdition.Name = "BoxEdition";
            this.BoxEdition.Size = new System.Drawing.Size(147, 20);
            this.BoxEdition.TabIndex = 49;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(220, 125);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 13);
            this.label14.TabIndex = 50;
            this.label14.Text = "Genre";
            // 
            // BoxGenre
            // 
            this.BoxGenre.Location = new System.Drawing.Point(293, 127);
            this.BoxGenre.Name = "BoxGenre";
            this.BoxGenre.Size = new System.Drawing.Size(148, 20);
            this.BoxGenre.TabIndex = 51;
            // 
            // GestionLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 417);
            this.Controls.Add(this.BoxGenre);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.BoxEdition);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BoxResume);
            this.Controls.Add(this.BoxLangue);
            this.Controls.Add(this.BoxTarif);
            this.Controls.Add(this.BoxDateSortie);
            this.Controls.Add(this.BoxQuantiteStock);
            this.Controls.Add(this.BoxNonAuteur);
            this.Controls.Add(this.BoxNomLivre);
            this.Controls.Add(this.BoxISBN);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labNoLivre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LabelPagueCourent);
            this.Controls.Add(this.LabelNbPage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPrecedent);
            this.Controls.Add(this.buttonSuivant);
            this.Controls.Add(this.buttonFin);
            this.Controls.Add(this.buttonDebut);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "GestionLivre";
            this.Text = "-";
            this.Load += new System.EventHandler(this.GestionLivre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrecedent;
        private System.Windows.Forms.Button buttonSuivant;
        private System.Windows.Forms.Button buttonFin;
        private System.Windows.Forms.Button buttonDebut;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelNbPage;
        private System.Windows.Forms.Label LabelPagueCourent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labNoLivre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox BoxISBN;
        private System.Windows.Forms.TextBox BoxNomLivre;
        private System.Windows.Forms.TextBox BoxNonAuteur;
        private System.Windows.Forms.TextBox BoxQuantiteStock;
        private System.Windows.Forms.TextBox BoxDateSortie;
        private System.Windows.Forms.TextBox BoxTarif;
        private System.Windows.Forms.TextBox BoxLangue;
        private System.Windows.Forms.TextBox BoxResume;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BoxEdition;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox BoxGenre;
    }
}