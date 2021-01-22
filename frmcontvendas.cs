using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Paula
{
    
    public partial class frmcontvendas : Form
    {
        MySqlConnection conexao;
        MySqlCommand command;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSql;

        private void Buscar()
        {
            try
            {
                conexao = new MySqlConnection("server=localhost;user id=root;database=estoque;allowuservariables=True");
                strSql = "SELECT * FROM VENDA";
                da = new MySqlDataAdapter(strSql, conexao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            finally
            {
                conexao.Close();
                conexao = null;
               
            }
        }

        public frmcontvendas()
        {
            InitializeComponent();
        }

        private void bntvendas_Click(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
