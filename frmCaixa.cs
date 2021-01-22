using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;
using CTe.Classes.Informacoes.infCTeNormal.infModals.aereos;
using NFE_dll.wsStatusServicoProdSVRS;
using NFE_dll.wsConsultaProdPR_2;
using NFE_dll.wsCancelamentoHomAM_2;
using NFE_dll.wsRecepcaoProdMS_2;
using CTe.Classes.Informacoes.Tipos;
using CTe.Classes.Informacoes.infCTeNormal.infDocumentos;
using NFE_dll.wsRegistroSaidaProdMG;
using CTe.Classes.Informacoes.infCTeNormal.infModals;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Paula

{

    public partial class frmCaixa : Form
    {
        MySqlConnection conexao;
        MySqlCommand commando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSql;
        decimal valortotal;
        





        public frmCaixa()
        {
            InitializeComponent();
        }
        public void usuarioLogado()
        {

        }


        private void gerarCodigo()
        {//gerar cod de venda
            conexao = new MySqlConnection("server=localhost;user id=root;database=estoque;allowuservariables=True");

            strSql = "select max(Id) from venda";
            try
            {
                conexao.Open();
                commando = new MySqlCommand(strSql, conexao);
                if (commando.ExecuteScalar() == DBNull.Value)
                {
                    lblcod.Text = "1";
                }
                else
                {
                    Int32 ra = Convert.ToInt32(commando.ExecuteScalar()) + 1;
                    lblcod.Text = ra.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }

        }

        private void ConsultarProdduto()
        {
            //parametro de conexao com o banco de dados
            conexao = new MySqlConnection("server=localhost;user id=root;database=estoque;allowuservariables=True");
            // exibir informações no banco 
            strSql = "SELECT * FROM estoque where cod_barras = '" + txtcodbarra.Text+ "'";

            try
            {

                commando = new MySqlCommand(strSql, conexao);
                commando.Parameters.AddWithValue("@cod_barras",txtcodbarra.Text.ToString());
                conexao.Open();
                dr = commando.ExecuteReader();
                dr.Read();


                if (!dr.HasRows)
                {
                    MessageBox.Show("Produto não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtcodbarra.Clear();
                    txtcod.Clear();
                    txtcodbarra.Focus();
                }
                else
                {
                    txtcod.Text = Convert.ToString(dr["cod"]);
                    txtdescricao.Text = Convert.ToString(dr["descricao"]);
                    txtvprod.Text = Convert.ToString(dr["valor_unit_venda"]);
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



        private void Inserir()
        {
            strSql = "INSERT INTO venda(Id, cod, descricao , valor_unitario, quantidade, valor_total) VALUES (@Id, @cod, @descricao, @valor_unitario, @quantidade, @valor_total)";
            //comando para apontar os campos a serem inseridos
            commando = new MySqlCommand(strSql, conexao);


            try
            {
                conexao.Open();


                for (int i = 0; i < dataGridViewsvenda.Rows.Count - 1; i++)
                {
                    commando.Parameters.Clear();
                    commando.Parameters.AddWithValue("@Id", Convert.ToInt32(lblcod.Text.ToString()));
                    commando.Parameters.AddWithValue("@descricao", dataGridViewsvenda.Rows[i].Cells[1].Value);
                    commando.Parameters.AddWithValue("@valor_unitario", Convert.ToDecimal(dataGridViewsvenda.Rows[i].Cells[3].Value.ToString()));
                    commando.Parameters.AddWithValue("@cod", dataGridViewsvenda.Rows[i].Cells[0].Value);
                    commando.Parameters.AddWithValue("@quantidade", Convert.ToDecimal(dataGridViewsvenda.Rows[i].Cells[2].Value.ToString()));
                    commando.Parameters.AddWithValue("@valor_total", Convert.ToDecimal(lblvalorfim.Text).ToString());

                    commando.ExecuteNonQuery();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Venda Finalizada com sucesso!");

            }
            finally
            {

                dataGridViewsvenda.Rows.Clear();
                valortotal = 0;
                txtvprod.Text = "0";
                lblvalorfim.Text = "0";
                lblvalor.Text = "0";
                conexao.Close();

            }

        }

        private void Limpar()
        {
            txtcod.Clear();
            txtcodbarra.Clear();
            txtdescricao.Clear();
            txtvprod.Clear();
            txtquantidade.Clear();

        }


        private void NomearDatagrind()
        {
            dataGridViewsvenda.ColumnCount = 6;
            dataGridViewsvenda.Columns[0].Name = "Código";
            dataGridViewsvenda.Columns[1].Width = 267;
            dataGridViewsvenda.Columns[1].Name = "Descrição";
            dataGridViewsvenda.Columns[2].Name = "Valor Unitario";
            dataGridViewsvenda.Columns[3].Name = "Quantidade";
            dataGridViewsvenda.Columns[4].Name = "Total";
            dataGridViewsvenda.Columns[5].Name = "Cod de barra";
        }

        private void Atualizar()
        {
            try
            {
                //parametro de conexao com o banco de dados
                conexao = new MySqlConnection("server=localhost;user id=root;database=estoque;allowuservariables=True");
                // atualizar informações informações no banco 
                strSql = "UPDATE ESTOQUE SET QUANTIDADE = quantidade - @quantidade WHERE (cod = @cod)";
                //comando para apontar os campos a serem inseridos
                commando = new MySqlCommand(strSql, conexao);

                commando.Parameters.AddWithValue("@cod", txtcod.Text);               
                commando.Parameters.AddWithValue("@quantidade", txtquantidade.Text);
                conexao.Open();
                commando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Não foi possivel atualizar o estoque");

            }
            finally
            {
                conexao.Close();

            }
        }
       

        private void lblcod_Click(object sender, EventArgs e)
        {

        }

        private void frmCaixa_Load(object sender, EventArgs e)
        {

            // TODO: esta linha de código carrega dados na tabela 'estoqueDataSet2.estoque'. Você pode movê-la ou removê-la conforme necessário.
            //this.estoqueTableAdapter.Fill(this.estoqueDataSet2.estoque);           

            gerarCodigo();
        }

        private void txtcod_Validated(object sender, EventArgs e)
        {

        }

        private void txtcod_Validating(object sender, CancelEventArgs e)
        {
            if (txtcodbarra.Text != string.Empty)
            {
                ConsultarProdduto();
                NomearDatagrind();
            }
            else
            {
                txtcod.Focus();
                txtcodbarra.Focus();
            }
        }

        private void txtquantidade_Validating(object sender, CancelEventArgs e)
        {
            if (txtquantidade.Text != string.Empty)
            {
                
                    lblvalor.Text = (decimal.Parse(txtvprod.Text) * decimal.Parse(txtquantidade.Text)).ToString();


                btnAdd.Focus();
            }
            else
            {
               
                MessageBox.Show("Digite uma quantidade valida");

                txtquantidade.Focus();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) // iserir dados da venda
        {
            dataGridViewsvenda.Rows.Add(txtcod.Text, txtdescricao.Text, txtvprod.Text, txtquantidade.Text, lblvalor.Text);
            //listBox1impressoraComboBox.Items.Add(String.Format(" {0}   -   {1}   -   {2} Unidades   -   R$:{3}", txtcod.Text, txtdescricao.Text, txtquantidade.Text, lblvalor.Text));

            Atualizar();
            valortotal += Decimal.Parse(lblvalor.Text);
            lblvalorfim.Text = valortotal.ToString();

            Limpar();
            txtcod.Focus();
            txtcodbarra.Focus();




        }

        private void btnfinalizar_Click(object sender, EventArgs e)
        {


            Inserir();
            gerarCodigo();
            Limpar();
            frmFormade_pagamento cad = new frmFormade_pagamento();
            cad.Show();

        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x cad = new x();
            cad.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario cad = new frmUsuario();
            cad.Show();

        }

        private void btformadepagamento_Click(object sender, EventArgs e)
        {



        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {//metodo chama informações do datagrind para a label de vendas

        }

        private void btndirestoque_Click(object sender, EventArgs e)
        {

            try
            {   //parametro de conexao com o banco de dados
                conexao = new MySqlConnection("server=localhost;user id=root;database=estoque;allowuservariables=True");
                // exibir informações no banco 
                strSql = "SELECT  Id, cod, quantidade , descricao, marca, valor_unit_venda FROM estoque ";
                da = new MySqlDataAdapter(strSql, conexao);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewestoque.DataSource = dt;
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

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.estoqueTableAdapter1.Fill(this.estoqueDataSet.estoque);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewestoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewestoque_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtcod_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show(txtcodbarra.Text);
            }
        }

        private void btnformadepagamento_Click(object sender, EventArgs e)
        {


            frmFormade_pagamento cad = new frmFormade_pagamento();
            cad.Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcontvendas cad = new frmcontvendas();
            cad.Show();
        }

        private void relatorioDePagamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmpag cad = new frmpag();
            cad.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NFe nota = new NFe();
            nota.infNFe = new NFeInfNFe();
            nota.infNFe.dest = new NFeInfNFeDest();
            nota.infNFe.dest.enderDest = new NFeInfNFeDestEnderDest();

            nota.infNFe.dest.enderDest.xLgr = "Rua das candongas";
            nota.infNFe.dest.enderDest.nro = 99;
            nota.infNFe.dest.enderDest.UF = "SP";
            nota.infNFe.dest.enderDest.xBairro = "Bairro das camélias";

            XmlSerializer ser = new XmlSerializer(typeof(NFe));
            FileStream arquivo = new FileStream("C:\\downloads\\nota serializada.xml", FileMode.CreateNew);

            //ser.Serialize(arquivo, nota);


        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }

        private void documento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            string cupom = "Perfumaria Paula Comercio de Cosmeticos Ltda" +
            "Rua: Serra do boqueirão 56A Jd. nova vitoria - São Paulo";

            Font letra = new Font("Calibri", 11, FontStyle.Bold, GraphicsUnit.Pixel);
            SolidBrush cor = new SolidBrush(Color.Black);
            Point ponto = new Point(100, 100);
            e.Graphics.DrawString(cupom, letra, cor, ponto);
        
           

        }

        private void txtcod_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcodbarra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
