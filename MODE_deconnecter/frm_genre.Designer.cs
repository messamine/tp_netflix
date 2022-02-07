
namespace MODE_deconnecter
{
    partial class frm_genre
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
            this.lblcodedugenre = new System.Windows.Forms.Label();
            this.lblintitulegenre = new System.Windows.Forms.Label();
            this.txtcodegenre = new System.Windows.Forms.TextBox();
            this.txtintitulegenre = new System.Windows.Forms.TextBox();
            this.btnpremier = new System.Windows.Forms.Button();
            this.btndernier = new System.Windows.Forms.Button();
            this.btnsuivant = new System.Windows.Forms.Button();
            this.btnprecedent = new System.Windows.Forms.Button();
            this.btnajouter = new System.Windows.Forms.Button();
            this.btnenregistrer = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnsuprimer = new System.Windows.Forms.Button();
            this.btnvider = new System.Windows.Forms.Button();
            this.dgvgenre = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgenre)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcodedugenre
            // 
            this.lblcodedugenre.AutoSize = true;
            this.lblcodedugenre.Font = new System.Drawing.Font("Lucida Bright", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodedugenre.Location = new System.Drawing.Point(34, 30);
            this.lblcodedugenre.Name = "lblcodedugenre";
            this.lblcodedugenre.Size = new System.Drawing.Size(166, 22);
            this.lblcodedugenre.TabIndex = 0;
            this.lblcodedugenre.Text = "CODE DU GENRE";
            // 
            // lblintitulegenre
            // 
            this.lblintitulegenre.AutoSize = true;
            this.lblintitulegenre.Font = new System.Drawing.Font("Lucida Bright", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblintitulegenre.Location = new System.Drawing.Point(11, 65);
            this.lblintitulegenre.Name = "lblintitulegenre";
            this.lblintitulegenre.Size = new System.Drawing.Size(200, 22);
            this.lblintitulegenre.TabIndex = 2;
            this.lblintitulegenre.Text = "INTITULE DU GENRE";
            // 
            // txtcodegenre
            // 
            this.txtcodegenre.Location = new System.Drawing.Point(288, 29);
            this.txtcodegenre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcodegenre.Name = "txtcodegenre";
            this.txtcodegenre.Size = new System.Drawing.Size(139, 22);
            this.txtcodegenre.TabIndex = 3;
            // 
            // txtintitulegenre
            // 
            this.txtintitulegenre.Location = new System.Drawing.Point(288, 63);
            this.txtintitulegenre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtintitulegenre.Name = "txtintitulegenre";
            this.txtintitulegenre.Size = new System.Drawing.Size(139, 22);
            this.txtintitulegenre.TabIndex = 4;
            // 
            // btnpremier
            // 
            this.btnpremier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpremier.Location = new System.Drawing.Point(113, 111);
            this.btnpremier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnpremier.Name = "btnpremier";
            this.btnpremier.Size = new System.Drawing.Size(51, 27);
            this.btnpremier.TabIndex = 5;
            this.btnpremier.Text = "<<";
            this.btnpremier.UseVisualStyleBackColor = true;
            this.btnpremier.Click += new System.EventHandler(this.btnpremier_Click);
            // 
            // btndernier
            // 
            this.btndernier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndernier.Location = new System.Drawing.Point(311, 111);
            this.btndernier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndernier.Name = "btndernier";
            this.btndernier.Size = new System.Drawing.Size(51, 27);
            this.btndernier.TabIndex = 6;
            this.btndernier.Text = ">>";
            this.btndernier.UseVisualStyleBackColor = true;
            this.btndernier.Click += new System.EventHandler(this.btndernier_Click);
            // 
            // btnsuivant
            // 
            this.btnsuivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuivant.Location = new System.Drawing.Point(255, 111);
            this.btnsuivant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsuivant.Name = "btnsuivant";
            this.btnsuivant.Size = new System.Drawing.Size(51, 27);
            this.btnsuivant.TabIndex = 7;
            this.btnsuivant.Text = ">";
            this.btnsuivant.UseVisualStyleBackColor = true;
            this.btnsuivant.Click += new System.EventHandler(this.btnsuivant_Click);
            // 
            // btnprecedent
            // 
            this.btnprecedent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprecedent.Location = new System.Drawing.Point(169, 111);
            this.btnprecedent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnprecedent.Name = "btnprecedent";
            this.btnprecedent.Size = new System.Drawing.Size(51, 27);
            this.btnprecedent.TabIndex = 8;
            this.btnprecedent.Text = "<";
            this.btnprecedent.UseVisualStyleBackColor = true;
            this.btnprecedent.Click += new System.EventHandler(this.btnprecedent_Click);
            // 
            // btnajouter
            // 
            this.btnajouter.Font = new System.Drawing.Font("Lucida Console", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouter.Location = new System.Drawing.Point(30, 167);
            this.btnajouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(134, 46);
            this.btnajouter.TabIndex = 9;
            this.btnajouter.Text = "AJOUTER";
            this.btnajouter.UseVisualStyleBackColor = true;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // btnenregistrer
            // 
            this.btnenregistrer.Font = new System.Drawing.Font("Lucida Console", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenregistrer.Location = new System.Drawing.Point(98, 270);
            this.btnenregistrer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnenregistrer.Name = "btnenregistrer";
            this.btnenregistrer.Size = new System.Drawing.Size(152, 54);
            this.btnenregistrer.TabIndex = 10;
            this.btnenregistrer.Text = "ENREGISTRER";
            this.btnenregistrer.UseVisualStyleBackColor = true;
            this.btnenregistrer.Click += new System.EventHandler(this.btnenregistrer_Click);
            // 
            // btnmodifier
            // 
            this.btnmodifier.Font = new System.Drawing.Font("Lucida Console", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifier.Location = new System.Drawing.Point(193, 219);
            this.btnmodifier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(141, 46);
            this.btnmodifier.TabIndex = 11;
            this.btnmodifier.Text = "MODIFIER";
            this.btnmodifier.UseVisualStyleBackColor = true;
            this.btnmodifier.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnsuprimer
            // 
            this.btnsuprimer.Font = new System.Drawing.Font("Lucida Console", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuprimer.Location = new System.Drawing.Point(30, 219);
            this.btnsuprimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsuprimer.Name = "btnsuprimer";
            this.btnsuprimer.Size = new System.Drawing.Size(134, 46);
            this.btnsuprimer.TabIndex = 12;
            this.btnsuprimer.Text = "SUPPRIMER";
            this.btnsuprimer.UseVisualStyleBackColor = true;
            this.btnsuprimer.Click += new System.EventHandler(this.btnsuprimer_Click);
            // 
            // btnvider
            // 
            this.btnvider.Font = new System.Drawing.Font("Lucida Console", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvider.Location = new System.Drawing.Point(193, 167);
            this.btnvider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnvider.Name = "btnvider";
            this.btnvider.Size = new System.Drawing.Size(141, 46);
            this.btnvider.TabIndex = 13;
            this.btnvider.Text = "VIDER";
            this.btnvider.UseVisualStyleBackColor = true;
            this.btnvider.Click += new System.EventHandler(this.btnvider_Click);
            // 
            // dgvgenre
            // 
            this.dgvgenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvgenre.Location = new System.Drawing.Point(447, 48);
            this.dgvgenre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvgenre.Name = "dgvgenre";
            this.dgvgenre.RowHeadersWidth = 62;
            this.dgvgenre.RowTemplate.Height = 28;
            this.dgvgenre.Size = new System.Drawing.Size(401, 245);
            this.dgvgenre.TabIndex = 14;
            // 
            // frm_genre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 360);
            this.Controls.Add(this.dgvgenre);
            this.Controls.Add(this.btnvider);
            this.Controls.Add(this.btnsuprimer);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.btnenregistrer);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.btnprecedent);
            this.Controls.Add(this.btnsuivant);
            this.Controls.Add(this.btndernier);
            this.Controls.Add(this.btnpremier);
            this.Controls.Add(this.txtintitulegenre);
            this.Controls.Add(this.txtcodegenre);
            this.Controls.Add(this.lblintitulegenre);
            this.Controls.Add(this.lblcodedugenre);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_genre";
            this.Text = "frmTP11";
            this.Load += new System.EventHandler(this.frmTP11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvgenre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcodedugenre;
        private System.Windows.Forms.Label lblintitulegenre;
        private System.Windows.Forms.TextBox txtcodegenre;
        private System.Windows.Forms.TextBox txtintitulegenre;
        private System.Windows.Forms.Button btnpremier;
        private System.Windows.Forms.Button btndernier;
        private System.Windows.Forms.Button btnsuivant;
        private System.Windows.Forms.Button btnprecedent;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Button btnenregistrer;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnsuprimer;
        private System.Windows.Forms.Button btnvider;
        private System.Windows.Forms.DataGridView dgvgenre;
    }
}