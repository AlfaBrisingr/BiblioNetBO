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
            this.ListeUtilisateur = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ListeUtilisateur
            // 
            this.ListeUtilisateur.FormattingEnabled = true;
            this.ListeUtilisateur.Location = new System.Drawing.Point(12, 12);
            this.ListeUtilisateur.MultiColumn = true;
            this.ListeUtilisateur.Name = "ListeUtilisateur";
            this.ListeUtilisateur.Size = new System.Drawing.Size(184, 381);
            this.ListeUtilisateur.TabIndex = 0;
            this.ListeUtilisateur.SelectedIndexChanged += new System.EventHandler(this.ListeUtilisateur_SelectedIndexChanged);
            // 
            // GestionUtilisateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 544);
            this.Controls.Add(this.ListeUtilisateur);
            this.Name = "GestionUtilisateurs";
            this.Text = "GestionUtilisateurs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListeUtilisateur;
    }
}