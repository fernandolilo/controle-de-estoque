using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DFe.Utils;
using FastReport.Dialog;
using MySql.Data.MySqlClient;

namespace Paula
{
    public partial class frmFormade_pagamento : Form
    {
        MySqlConnection conexao;
        MySqlCommand commando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSql;
        decimal valor;
        decimal parcelar;
        decimal total;
        public frmFormade_pagamento()
        {
            InitializeComponent();
        }
        

        private void InserirVenda()
        {

           

        }
        private void Limpar()
        {
            lbltroco.Text = "";
            lblformadepagamento.Text = "";
            lblvalor.Text = "";
            txtpagamento.Clear();
            txtbandeira.Clear();
            txtparcelas.Clear();
            lblvparcelas.Text = "";

        }

        private void Selecte()
        {

            

        }
        private void txtformadepagamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmFormade_pagamento_Load(object sender, EventArgs e)
        {
            Selecte();

        }

        private void btnfinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                //parametro de conexao com o banco de dados
                conexao = new MySqlConnection("server=localhost;user id=root;database=estoque;allowuservariables=True");
                // iserir informações no banco 
                strSql = "INSERT INTO PAGAMENTO (Id, bandeira, valor_total, Debito, dinheiro, Credito,data) VALUES (@Id, @bandeira, @valor_total, @Debito, @dinheiro, @Credito, @data)";
                //comando para apontar os campos a serem inseridos
                commando = new MySqlCommand(strSql, conexao);

                commando.Parameters.AddWithValue("@Id", Convert.ToInt32(lblid.Text.ToString()));
                commando.Parameters.AddWithValue("@bandeira", txtbandeira.Text);
                commando.Parameters.AddWithValue("@valor_total",Convert.ToDecimal(lblvalor.Text.ToString()));
                commando.Parameters.AddWithValue("@Debito", chdebito.Checked);
                commando.Parameters.AddWithValue("@dinheiro", chdinheiro.Checked);
                commando.Parameters.AddWithValue("@Credito", chcredito.Checked);
                commando.Parameters.AddWithValue("@data", txtdata.Text);
                commando.Parameters.AddWithValue("@parcelado", txtparcelas.Text);
                commando.Parameters.AddWithValue("@valor_parcelas", lblvparcelas.Text);
                


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

        private void frmFormade_pagamento_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //parametro de conexao com o banco de dados
            conexao = new MySqlConnection("server=localhost;user id=root;database=estoque;allowuservariables=True");
            // exibir informações no banco 
            strSql = "SELECT * FROM venda where Id = '" + txtid.Text + "'";

            try
            {

                commando = new MySqlCommand(strSql, conexao);
                conexao.Open();
                dr = commando.ExecuteReader();
                dr.Read();


                if (!dr.HasRows)
                {
                    MessageBox.Show("venda não encontrada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   
                    
                }
                else
                {
                    lblid.Text = Convert.ToString(dr["Id"]);
                    lblvalor.Text = Convert.ToString(dr["Valor_total"]);
                    

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

        

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void racredito_Click(object sender, EventArgs e)
        {

        }
        

        private void racredito_CheckedChanged(object sender, EventArgs e)
        {
            
            
        }

        private void txtparcelar_TextChanged(object sender, EventArgs e)
        {
            if(txtparcelas.Text != string.Empty)
            {
                
                lblvparcelas.Text = ((decimal.Parse(lblvalor.Text) - decimal.Parse(txtpagamento.Text)) / decimal.Parse(txtparcelas.Text)).ToString("C");
             
            }
            else
            {
                btnfinalizar.Focus();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtpagamento.Text != string.Empty)
            {
                
                lbltroco.Text = (decimal.Parse(txtpagamento.Text) - decimal.Parse(lblvalor.Text)).ToString("C");
               
            }
            else
            {
                btnfinalizar.Focus();
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            this.groupBox1.Controls.Add(this.chdinheiro);
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblvalor_Click(object sender, EventArgs e)
        {
           
        }

        private void lbltroco_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in lbltroco.Text)
                {
                    if (decimal.Parse(lbltroco.Text) < decimal.Parse(lblvalor.Text))
                    {
                        
                        lbltroco.Text = (decimal.Parse(lblvalor.Text) - decimal.Parse(txtpagamento.Text)).ToString("C");
                        lbltroco.Text = (decimal.Parse(lblvparcelas.Text) * decimal.Parse(txtparcelas.Text)).ToString("c");
                    }
                }
            }
            catch 
            {

                btnfinalizar.Focus();
            }
        }

        private void txtvalorparcelas_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            this.groupBox3.Controls.Add(this.chcredito);
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            this.groupBox2.Controls.Add(this.chdebito);
        }
    }
}
