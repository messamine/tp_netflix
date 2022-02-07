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
    public partial class tp11 : Form
    {
        public tp11()
        {
            InitializeComponent();
            sc = new SqlConnection(@"Data Source =DESKTOP-UCDNTIG\SQLEXPRESS; Initial Catalog =netflix; Integrated Security = True");
            daS = new SqlDataAdapter("select * from serie ", sc);
            daG = new SqlDataAdapter("select * from genre ", sc);
            daS.Fill(ds, "serie");
            daG.Fill(ds, "genre");

        }
        public SqlConnection sc;
        public DataSet ds = new DataSet();
        public SqlDataAdapter daS;
        public SqlDataAdapter daG;
        public SqlCommand cmd;

        private void tp11_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_genre_Click(object sender, EventArgs e)
        {
            frm_genre f = new frm_genre();
            f.Show(); 
        }

        private void btn_serie_Click(object sender, EventArgs e)
        {
            frm_serie f = new frm_serie();
            f.Show(); 
        }
    }
}
