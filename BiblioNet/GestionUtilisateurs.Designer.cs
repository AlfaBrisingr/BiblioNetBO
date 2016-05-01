namespace BiblioNet
{
    partial class GestionUtilisateurs
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TableauUser = new System.Windows.Forms.DataGridView();
            this.LblCode = new System.Windows.Forms.Label();
            this.BtnAnnuler = new System.Windows.Forms.Button();
            this.BtnValider = new System.Windows.Forms.Button();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BoxVille = new System.Windows.Forms.TextBox();
            this.BoxCp = new System.Windows.Forms.TextBox();
            this.BoxAdresse = new System.Windows.Forms.TextBox();
            this.BoxMDP = new System.Windows.Forms.TextBox();
            this.BoxMail = new System.Windows.Forms.TextBox();
            this.BoxPrenom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxNom = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableauUser)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TableauUser);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.LblCode);
            this.splitContainer1.Panel2.Controls.Add(this.BtnAnnuler);
            this.splitContainer1.Panel2.Controls.Add(this.BtnValider);
            this.splitContainer1.Panel2.Controls.Add(this.BtnSupprimer);
            this.splitContainer1.Panel2.Controls.Add(this.BtnModifier);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.BoxVille);
            this.splitContainer1.Panel2.Controls.Add(this.BoxCp);
            this.splitContainer1.Panel2.Controls.Add(this.BoxAdresse);
            this.splitContainer1.Panel2.Controls.Add(this.BoxMDP);
            this.splitContainer1.Panel2.Controls.Add(this.BoxMail);
            this.splitContainer1.Panel2.Controls.Add(this.BoxPrenom);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.BoxNom);
            this.splitContainer1.Size = new System.Drawing.Size(636, 544);
            this.splitContainer1.SplitterDistance = 186;
            this.splitContainer1.TabIndex = 0;
            // 
            // TableauUser
            // 
            this.TableauUser.AllowUserToAddRows = false;
            this.TableauUser.AllowUserToDeleteRows = false;
            this.TableauUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableauUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableauUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableauUser.Location = new System.Drawing.Point(0, 0);
            this.TableauUser.Name = "TableauUser";
            this.TableauUser.ReadOnly = true;
            this.TableauUser.Size = new System.Drawing.Size(636, 186);
            this.TableauUser.TabIndex = 1;
            this.TableauUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickCellule);
            // 
            // LblCode
            // 
            this.LblCode.AutoSize = true;
            this.LblCode.Location = new System.Drawing.Point(352, 27);
            this.LblCode.Name = "LblCode";
            this.LblCode.Size = new System.Drawing.Size(13, 13);
            this.LblCode.TabIndex = 19;
            this.LblCode.Text = "?";
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.Enabled = false;
            this.BtnAnnuler.Image = global::BiblioNet.Properties.Resources.fermer_croix_supprimer_erreurs_sortie_icone_4368_32;
            this.BtnAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAnnuler.Location = new System.Drawing.Point(488, 234);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(125, 42);
            this.BtnAnnuler.TabIndex = 18;
            this.BtnAnnuler.Text = "Annuler";
            this.BtnAnnuler.UseVisualStyleBackColor = true;
            this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // BtnValider
            // 
            this.BtnValider.Enabled = false;
            this.BtnValider.Image = global::BiblioNet.Properties.Resources.dossier_icone_8757_32;
            this.BtnValider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnValider.Location = new System.Drawing.Point(164, 234);
            this.BtnValider.Name = "BtnValider";
            this.BtnValider.Size = new System.Drawing.Size(123, 42);
            this.BtnValider.TabIndex = 17;
            this.BtnValider.Text = "Valider";
            this.BtnValider.UseVisualStyleBackColor = true;
            this.BtnValider.Click += new System.EventHandler(this.BtnValider_Click);
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.Enabled = false;
            this.BtnSupprimer.Image = global::BiblioNet.Properties.Resources.vide_trash_icone_8487_32;
            this.BtnSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSupprimer.Location = new System.Drawing.Point(356, 234);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(123, 42);
            this.BtnSupprimer.TabIndex = 16;
            this.BtnSupprimer.Text = "Supprimer";
            this.BtnSupprimer.UseVisualStyleBackColor = true;
            this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // BtnModifier
            // 
            this.BtnModifier.Enabled = false;
            this.BtnModifier.Image = global::BiblioNet.Properties.Resources.modifier_texte_icone_4855_32;
            this.BtnModifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModifier.Location = new System.Drawing.Point(28, 234);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(123, 42);
            this.BtnModifier.TabIndex = 15;
            this.BtnModifier.Text = "Modifier";
            this.BtnModifier.UseVisualStyleBackColor = true;
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(353, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ville";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Code Postal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Adresse ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mot de Passe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Adresse Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prénom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nom";
            // 
            // BoxVille
            // 
            this.BoxVille.Enabled = false;
            this.BoxVille.Location = new System.Drawing.Point(385, 190);
            this.BoxVille.Name = "BoxVille";
            this.BoxVille.Size = new System.Drawing.Size(100, 20);
            this.BoxVille.TabIndex = 7;
            // 
            // BoxCp
            // 
            this.BoxCp.Enabled = false;
            this.BoxCp.Location = new System.Drawing.Point(131, 190);
            this.BoxCp.Name = "BoxCp";
            this.BoxCp.Size = new System.Drawing.Size(100, 20);
            this.BoxCp.TabIndex = 6;
            // 
            // BoxAdresse
            // 
            this.BoxAdresse.Enabled = false;
            this.BoxAdresse.Location = new System.Drawing.Point(131, 150);
            this.BoxAdresse.Name = "BoxAdresse";
            this.BoxAdresse.Size = new System.Drawing.Size(354, 20);
            this.BoxAdresse.TabIndex = 5;
            // 
            // BoxMDP
            // 
            this.BoxMDP.Enabled = false;
            this.BoxMDP.Location = new System.Drawing.Point(385, 107);
            this.BoxMDP.Name = "BoxMDP";
            this.BoxMDP.Size = new System.Drawing.Size(100, 20);
            this.BoxMDP.TabIndex = 4;
            // 
            // BoxMail
            // 
            this.BoxMail.Enabled = false;
            this.BoxMail.Location = new System.Drawing.Point(131, 107);
            this.BoxMail.Name = "BoxMail";
            this.BoxMail.Size = new System.Drawing.Size(100, 20);
            this.BoxMail.TabIndex = 3;
            // 
            // BoxPrenom
            // 
            this.BoxPrenom.Enabled = false;
            this.BoxPrenom.Location = new System.Drawing.Point(385, 65);
            this.BoxPrenom.Name = "BoxPrenom";
            this.BoxPrenom.Size = new System.Drawing.Size(100, 20);
            this.BoxPrenom.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Utilisateur n°";
            // 
            // BoxNom
            // 
            this.BoxNom.Enabled = false;
            this.BoxNom.Location = new System.Drawing.Point(131, 65);
            this.BoxNom.Name = "BoxNom";
            this.BoxNom.Size = new System.Drawing.Size(100, 20);
            this.BoxNom.TabIndex = 0;
            // 
            // GestionUtilisateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 544);
            this.Controls.Add(this.splitContainer1);
            this.Name = "GestionUtilisateurs";
            this.Text = "GestionUtilisateurs";
            this.Load += new System.EventHandler(this.GestionUtilisateurs_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TableauUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView TableauUser;
        private System.Windows.Forms.Button BtnValider;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BoxVille;
        private System.Windows.Forms.TextBox BoxCp;
        private System.Windows.Forms.TextBox BoxAdresse;
        private System.Windows.Forms.TextBox BoxMDP;
        private System.Windows.Forms.TextBox BoxMail;
        private System.Windows.Forms.TextBox BoxPrenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BoxNom;
        private System.Windows.Forms.Button BtnAnnuler;
        private System.Windows.Forms.Label LblCode;
    }
}