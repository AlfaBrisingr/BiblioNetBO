namespace BiblioNet
{
    partial class GestionDetails
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
            this.TableauLivre = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TableauLivre)).BeginInit();
            this.SuspendLayout();
            // 
            // TableauLivre
            // 
            this.TableauLivre.AllowUserToAddRows = false;
            this.TableauLivre.AllowUserToDeleteRows = false;
            this.TableauLivre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableauLivre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableauLivre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableauLivre.Location = new System.Drawing.Point(0, 0);
            this.TableauLivre.Name = "TableauLivre";
            this.TableauLivre.Size = new System.Drawing.Size(714, 388);
            this.TableauLivre.TabIndex = 0;
            // 
            // GestionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 388);
            this.Controls.Add(this.TableauLivre);
            this.Name = "GestionDetails";
            this.Text = "GestionDetails";
            this.Load += new System.EventHandler(this.GestionDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableauLivre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TableauLivre;
    }
}