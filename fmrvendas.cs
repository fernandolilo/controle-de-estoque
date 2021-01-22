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
    
    public partial class fmrvendas : Form
    {
        MySqlConnection conexao;
        MySqlCommand commando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSql;
        public fmrvendas()
        {
            InitializeComponent();
        }

        private void fmrvendas_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtExibir_Click(object sender, EventArgs e)
        {
            try
            {   //parametro de conexao com o banco de dados
                conexao = new MySqlConnection("server=localhost;user id=root;database=estoque;allowuservariables=True");
                // exibir informações no banco 
                strSql = "SELECT * FROM vendas";
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
                commando = null;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {   //parametro de conexao com o banco de dados
                conexao = new MySqlConnection("server=localhost;user id=root;database=estoque;allowuservariables=True");
                // deletar  informações no banco 
                strSql = "DELETE FROM vendas where Id = @Id";
                //comando para apontar os campos a serem inseridos
                commando = new MySqlCommand(strSql, conexao);
                commando.Parameters.AddWithValue("@Id", txtId.Text);
                MessageBox.Show("Excluido com Sucesso!", "Ok", MessageBoxButtons.OK);


                conexao.Open();// abre a conexão com o banco de dados
                commando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexao.Close();
                conexao = null;
                commando = null;
            }
        }
    }
}
