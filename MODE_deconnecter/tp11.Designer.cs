
namespace MODE_deconnecter
{
    partial class tp11
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
            this.btn_serie = new System.Windows.Forms.Button();
            this.btn_genre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_serie
            // 
            this.btn_serie.Location = new System.Drawing.Point(99, 222);
            this.btn_serie.Name = "btn_serie";
            this.btn_serie.Size = new System.Drawing.Size(152, 104);
            this.btn_serie.TabIndex = 0;
            this.btn_serie.Text = "SERIE";
            this.btn_serie.UseVisualStyleBackColor = true;
            this.btn_serie.Click += new System.EventHandler(this.btn_serie_Click);
            // 
            // btn_genre
            // 
            this.btn_genre.Location = new System.Drawing.Point(330, 222);
            this.btn_genre.Name = "btn_genre";
            this.btn_genre.Size = new System.Drawing.Size(152, 104);
            this.btn_genre.TabIndex = 1;
            this.btn_genre.Text = "genre";
            this.btn_genre.UseVisualStyleBackColor = true;
            this.btn_genre.Click += new System.EventHandler(this.btn_genre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "TP 11 / gestion netflix";
            // 
            // tp11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 433);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_genre);
            this.Controls.Add(this.btn_serie);
            this.Name = "tp11";
            this.Text = "tp11";
            this.Load += new System.EventHandler(this.tp11_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_serie;
        private System.Windows.Forms.Button btn_genre;
        private System.Windows.Forms.Label label1;
    }
}