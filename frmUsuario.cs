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
    public partial class frmUsuario : Form
    {
        MySqlConnection conexao;
        MySqlCommand commando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSql;
        public frmUsuario()
        {
            

            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            try
            {   //parametro de conexao com o banco de dados
                conexao = new MySqlConnection("server=localhost;user id=root;database=estoque;allowuservariables=True");
                // iserir informações no banco 
                strSql = "INSERT INTO login(Id, login, senha, nome, perfil) VALUES (@Id, @login, @senha, @nome, @perfil)";
                //comando para apontar os campos a serem inseridos
                commando = new MySqlCommand(strSql,conexao);
                commando.Parameters.AddWithValue("@Id",txtId.Text);
                commando.Parameters.AddWithValue("@login",txtLogin.Text);
                commando.Parameters.AddWithValue("@senha", txtSenha.Text);
                commando.Parameters.AddWithValue("@nome",txtNome.Text);
                commando.Parameters.AddWithValue("@perfil", txtperfil.Text);

                conexao.Open();// abre a conexão com o banco de dados
                commando.ExecuteNonQuery();
                MessageBox.Show("Inserido com Sucesso!", "Ok", MessageBoxButtons.OK);

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

        private void txtId_TextChanged(object sender, EventArgs e)

        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {   //parametro de conexao com o banco de dados
                conexao = new MySqlConnection("server=localhost;user id=root;database=estoque;allowuservariables=True");
                // atualizar informações informações no banco 
                strSql = "UPDATE login SET login = @login, senha = @senha, nome = @nome, perfil =@perfil where Id = @Id";
                //comando para apontar os campos a serem inseridos
                commando = new MySqlCommand(strSql, conexao);
                commando.Parameters.AddWithValue("@Id", txtId.Text);
                commando.Parameters.AddWithValue("@login", txtLogin.Text);
                commando.Parameters.AddWithValue("@senha", txtSenha.Text);
                commando.Parameters.AddWithValue("@nome", txtNome.Text);
                commando.Parameters.AddWithValue("@perfil", txtperfil.Text);

                conexao.Open();// abre a conexão com o banco de dados
                commando.ExecuteNonQuery();
                MessageBox.Show("Alterado com Sucesso!","Ok",MessageBoxButtons.OK);

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
                strSql = "DELETE FROM LOGIN where Id = @Id";
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {   //parametro de conexao com o banco de dados
                conexao = new MySqlConnection("server=localhost;user id=root;database=estoque;allowuservariables=True");
                // exibir informações no banco 
                strSql = "SELECT * FROM LOGIN";
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {   //parametro de conexao com o banco de dados
                conexao = new MySqlConnection("server=localhost;user id=root;database=estoque;allowuservariables=True");
                // exibir informações no banco 
                strSql = "SELECT * FROM LOGIN WHERE Id = @Id";
                commando = new MySqlCommand(strSql, conexao);
                commando.Parameters.AddWithValue("Id",txtId.Text);


                conexao.Open();
                dr = commando.ExecuteReader();
                while(dr.Read())
                {
                    txtNome.Text = Convert.ToString(dr["Nome"]);
                    txtId.Text = Convert.ToString(dr["Id"]);
                    txtLogin.Text = Convert.ToString(dr["login"]);
                    txtSenha.Text = Convert.ToString(dr["senha"]);
                    txtperfil.Text = Convert.ToString(dr["perfil"]);
                }


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

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Perfil_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {

        }
    }
}

