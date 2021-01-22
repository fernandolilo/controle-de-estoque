using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Paula

{   
 
    public partial class frmLogin : Form

    {
        MySqlConnection conexao;
        MySqlCommand commando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSql;
       
       
        
      

        public frmLogin()

        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {   
                
            

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntarini_Click(object sender, EventArgs e)
        {

            //parametro de conexao com o banco de dados
            conexao = new MySqlConnection("server=localhost;user id=root;database=estoque;allowuservariables=True");
            // iserir informações no banco 
            strSql = "(SELECT * FROM login where login = @login and senha = @senha)";
            //comando para apontar os campos a serem inseridos
            commando = new MySqlCommand(strSql, conexao);
            commando.Parameters.Add("@login",MySqlDbType.VarChar).Value = txtLoginini.Text;
            commando.Parameters.Add("@senha", MySqlDbType.VarChar).Value = txtsenhaini.Text;
            btnEntarini.Focus();

            try
            {
                conexao.Open();
                dr = commando.ExecuteReader();
                if (dr.HasRows == false)
                {
                    throw new Exception("Usuario ou senha invalido");
                }


                dr.Read();
                MessageBox.Show("logado com sucesso!", "Bom dia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmCaixa cad = new frmCaixa();
                cad.Show();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexao.Close();
            }          
        }

        private void btnSairini_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
