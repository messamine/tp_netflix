using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MODE_deconnecter
{
    public partial class frm_genre : Form
    {
        
        static int cpt ;
        public frm_genre()
        {
            InitializeComponent();

        }


        tp11 f = new tp11();


        private void button3_Click(object sender, EventArgs e)
        {
        try
        {
                DataRow dr = f.ds.Tables["Genre"].Select("codeg =" + txtcodegenre.Text + "")[0];
                dr[1] = txtintitulegenre.Text;
                MessageBox.Show(" vous avez modifié l'intitule genre en : " + dr[1].ToString());
        }
        catch (Exception ex)
        {
                MessageBox.Show("erreur modofication " + ex.Message );
        }
        
        }

        private void frmTP11_Load(object sender, EventArgs e)
        {

            dgvgenre.DataSource = f.ds.Tables["genre"] ;

        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow dr = f.ds.Tables["Genre"].NewRow();
                dr[0] = txtcodegenre.Text;
                dr[1] = txtintitulegenre.Text;
                f.ds.Tables["Genre"].Rows.Add(dr);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnvider_Click(object sender, EventArgs e)
        {
            txtcodegenre.Text = string.Empty;
            txtintitulegenre.Text = string.Empty;
        }

        private void btnsuprimer_Click(object sender, EventArgs e)
        {
            f.ds.Tables["Genre"].Select("codeg=" + txtcodegenre.Text + "")[0].Delete();
        }

        private void navigation()
        {
            txtcodegenre.Text = f.ds.Tables["genre"].Rows[cpt][0].ToString(); 
            txtintitulegenre.Text = f.ds.Tables["genre"].Rows[cpt][1].ToString();
        }

        private void btnpremier_Click(object sender, EventArgs e)
        {
            cpt = 0;
            navigation();
        }

        private void btnprecedent_Click(object sender, EventArgs e)
        {
            try
            {
                cpt -= 1;
                navigation();
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Vous avez atteint le début");
                cpt = 0;
            }
        }

        private void btnsuivant_Click(object sender, EventArgs e)
        {
            try
            {
                cpt += 1;
                navigation();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vous avez atteint la fin" + ex.Message);
                cpt = f.ds.Tables["genre"].Rows.Count - 1;
            }
        }
        
        private void btndernier_Click(object sender, EventArgs e)
        {
            cpt = f.ds.Tables["Genre"].Rows.Count - 1;
            navigation();
        }

        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            
            SqlCommandBuilder cmb = new SqlCommandBuilder(f.daG);
            f.daG.Update(f.ds, "genre");

            
            
        }
    }
}
