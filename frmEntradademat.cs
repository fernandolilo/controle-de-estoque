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
    public partial class x : Form


    {

        MySqlConnection conexao;
        MySqlCommand commando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSql;
        
        public x()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        private void EntradaDeMateriais()
        {
            try
            {
                //parametro de conexao com o banco de dados
                conexao = new MySqlConnection("server=localhost;user id=root;database=estoque;allowuservariables=True");
                // iserir informações no banco 
                strSql = "INSERT INTO entrada_materiais (Id,cod, descricao, valor_unit_entrada, marca, fornecedor, contato_do_fornecedor, email_fornecedor,quantidade, valor_da_NF, nota, dia, cnpj_fornecedor, valor_unit_venda, cod_barras ) VALUES (@Id,@cod, @descricao, @valor_unit_entrada, @marca,@fornecedor, @contato_do_fornecedor, @email_fornecedor,@quantidade,@valor_da_NF, @nota, @dia, @cnpj_fornecedor, @valor_unit_venda, @cod_barras)";
                //comando para apontar os campos a serem inseridos
                commando = new MySqlCommand(strSql, conexao);

                commando.Parameters.AddWithValue("@Id", Convert.ToInt32(txtid.Text.ToString()));
                commando.Parameters.AddWithValue("@cod", txtcod.Text);
                commando.Parameters.AddWithValue("@descricao", txtdescricao.Text);
                commando.Parameters.AddWithValue("@Valor_unit_entrada", Convert.ToDecimal(txtValorUniEntrada.Text.ToString()));
                commando.Parameters.AddWithValue("@marca", txtmarca.Text);
                commando.Parameters.AddWithValue("@contato_do_fornecedor", txtcontato.Text);
                commando.Parameters.AddWithValue("@fornecedor", txtfornecedor.Text);
                commando.Parameters.AddWithValue("@email_fornecedor", txtemail.Text);
                commando.Parameters.AddWithValue("@nota", txtnota.Text);
                commando.Parameters.AddWithValue("@quantidade", txtquantidade.Text);
                commando.Parameters.AddWithValue("@valor_da_NF", Convert.ToDecimal(txtvalordanf.Text.ToString()));
                commando.Parameters.AddWithValue("@dia", txtdata.Text);
                commando.Parameters.AddWithValue("@cnpj_fornecedor", txtcnpj.Text);
                commando.Parameters.AddWithValue("@valor_unit_venda", Convert.ToDecimal(txtprecovenda.Text.ToString()));
                commando.Parameters.AddWithValue("@cod_barras", txtcodbarra.Text);

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
        private void EstoqueDeEstoque()
        {
            try
            {
                //parametro de conexao com o banco de dados
                conexao = new MySqlConnection("server=localhost;user id=root;database=estoque;allowuservariables=True");
                // iserir informações no banco 
                strSql = "INSERT INTO estoque (Id,cod, descricao, valor_unit_entrada, marca, fornecedor, contato_do_fornecedor, email_fornecedor,quantidade, valor_da_NF, nota, dia, cnpj_fornecedor, valor_unit_venda, cod_barras ) VALUES (@Id,@cod, @descricao, @valor_unit_entrada, @marca,@fornecedor, @contato_do_fornecedor, @email_fornecedor,@quantidade,@valor_da_NF, @nota, @dia, @cnpj_fornecedor, @valor_unit_venda, @cod_barras)";
                //comando para apontar os campos a serem inseridos
                commando = new MySqlCommand(strSql, conexao);

                commando.Parameters.AddWithValue("@Id", Convert.ToInt32(txtid.Text.ToString()));
                commando.Parameters.AddWithValue("@cod", txtcod.Text);
                commando.Parameters.AddWithValue("@descricao", txtdescricao.Text);
                commando.Parameters.AddWithValue("@Valor_unit_entrada", Convert.ToDecimal(txtValorUniEntrada.Text.ToString()));
                commando.Parameters.AddWithValue("@marca", txtmarca.Text);
                commando.Parameters.AddWithValue("@contato_do_fornecedor", txtcontato.Text);
                commando.Parameters.AddWithValue("@fornecedor", txtfornecedor.Text);
                commando.Parameters.AddWithValue("@email_fornecedor", txtemail.Text);
                commando.Parameters.AddWithValue("@nota", txtnota.Text);
                commando.Parameters.AddWithValue("@quantidade", txtquantidade.Text);
                commando.Parameters.AddWithValue("@valor_da_NF", Convert.ToDecimal(txtvalordanf.Text.ToString()));
                commando.Parameters.AddWithValue("@dia", txtdata.Text);
                commando.Parameters.AddWithValue("@cnpj_fornecedor", txtcnpj.Text);
                commando.Parameters.AddWithValue("@valor_unit_venda", Convert.ToDecimal(txtprecovenda.Text.ToString()));
                commando.Parameters.AddWithValue("@cod_barras", txtcodbarra.Text);


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
        private void button1_Click(object sender, EventArgs e)
        {
            EntradaDeMateriais();
            EstoqueDeEstoque();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtExibir_Click(object sender, EventArgs e)
        {
            try
            {   //parametro de conexao com o banco de dados
                conexao = new MySqlConnection("server=localhost;user id=root;database=estoque;allowuservariables=True");
                // exibir informações no banco 
                strSql = "SELECT * FROM estoque";
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
                strSql = "DELETE FROM estoque where cod = @cod";
                //comando para apontar os campos a serem inseridos
                commando = new MySqlCommand(strSql, conexao);
                commando.Parameters.AddWithValue("@cod", txtcod.Text);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtvalordanf_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtquantidadeuni_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtpreço_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtmarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtfornecedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtdescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtdata_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtcod_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmEntradademat_Load(object sender, EventArgs e)
        {

        }

        private void txtdata_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {   //parametro de conexao com o banco de dados
                conexao = new MySqlConnection("server=localhost;user id=root;database=estoque;allowuservariables=True");
                // exibir informações no banco 
                strSql = "SELECT * FROM entrada_materiais";
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {   //parametro de conexao com o banco de dados
                conexao = new MySqlConnection("server=localhost;user id=root;database=estoque;allowuservariables=True");
                // atualizar informações informações no banco 
                strSql = "UPDATE estoque SET cod =@cod, descricao =@descricao, valor_unit_entrada = @valor_unit_entrada, marca = @marca, fornecedor = @fornecedor, contato_do_fornecedor =@contato_do_fornecedor, email_fornecedor =@email_fornecedor, quantidade =@quantidade, valor_da_NF =@valor_da_NF, nota =@nota, dia =@dia, valor_unit_venda =@valor_unit_venda where Id = @Id";
                //comando para apontar os campos a serem inseridos
                commando = new MySqlCommand(strSql, conexao);


                commando.Parameters.AddWithValue("@Id", Convert.ToInt32(txtid.Text.ToString()));
                commando.Parameters.AddWithValue("@cod", txtcod.Text);
                commando.Parameters.AddWithValue("@descricao", txtdescricao.Text);
                commando.Parameters.AddWithValue("@Valor_unit_entrada", Convert.ToDecimal(txtValorUniEntrada.Text.ToString()));
                commando.Parameters.AddWithValue("@marca", txtmarca.Text);
                commando.Parameters.AddWithValue("@contato_do_fornecedor", txtcontato.Text);
                commando.Parameters.AddWithValue("@fornecedor", txtfornecedor.Text);
                commando.Parameters.AddWithValue("@email_fornecedor", txtemail.Text);
                commando.Parameters.AddWithValue("@nota", txtnota.Text);
                commando.Parameters.AddWithValue("@quantidade", txtquantidade.Text);
                commando.Parameters.AddWithValue("@valor_da_NF", Convert.ToDecimal(txtvalordanf.Text.ToString()));
                commando.Parameters.AddWithValue("@dia", txtdata.Text);
                commando.Parameters.AddWithValue("@cnpj_fornecedor", txtcnpj.Text);
                commando.Parameters.AddWithValue("@valor_unit_venda", Convert.ToDecimal(txtprecovenda.Text.ToString()));
                commando.Parameters.AddWithValue("@cod_barras", txtcodbarra.Text);

                conexao.Open();// abre a conexão com o banco de dados
                commando.ExecuteNonQuery();
                MessageBox.Show("Alterado com Sucesso!", "Ok", MessageBoxButtons.OK);

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
                strSql = "SELECT * FROM estoque WHERE Id = @Id";
                commando = new MySqlCommand(strSql, conexao);
                commando.Parameters.AddWithValue("Id", txtid.Text);


                conexao.Open();
                dr = commando.ExecuteReader();
                while (dr.Read())
                {
                    txtid.Text = Convert.ToString(dr["Id"]);
                    txtcod.Text = Convert.ToString(dr["cod"]);
                    txtdescricao.Text = Convert.ToString(dr["descricao"]);
                    txtValorUniEntrada.Text = Convert.ToString(dr["valor_unit_entrada"]);
                    txtmarca.Text = Convert.ToString(dr["marca"]);
                    txtcontato.Text = Convert.ToString(dr["contato_do_fornecedor"]);
                    txtfornecedor.Text = Convert.ToString(dr["fornecedor"]);
                    txtemail.Text = Convert.ToString(dr["email_fornecedor"]);
                    txtnota.Text = Convert.ToString(dr["nota"]);
                    txtquantidade.Text = Convert.ToString(dr["quantidade"]);
                    txtvalordanf.Text = Convert.ToString(dr["valor_da_NF"]);
                    txtdata.Text = Convert.ToString(dr["dia"]);
                    txtcnpj.Text = Convert.ToString(dr["cnpj_fornecedor"]);
                    txtprecovenda.Text = Convert.ToString(dr["valor_unit_venda"]);
                    txtcodbarra.Text = Convert.ToString(dr["cod_barras"]);

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

        private void txtcodbarra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                


            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
