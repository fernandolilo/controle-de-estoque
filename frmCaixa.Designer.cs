namespace Paula
{
    partial class frmCaixa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaixa));
            this.dataGridViewsvenda = new System.Windows.Forms.DataGridView();
            this.lblcod = new System.Windows.Forms.Label();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtquantidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtvprod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnfinalizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroDeEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioDePagamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btndirestoque = new System.Windows.Forms.Button();
            this.estoqueTableAdapter1 = new Paula.estoqueDataSetTableAdapters.estoqueTableAdapter();
            this.tableAdapterManager = new Paula.estoqueDataSetTableAdapters.TableAdapterManager();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.dataGridViewestoque = new System.Windows.Forms.DataGridView();
            this.estoqueDataSet = new Paula.estoqueDataSet();
            this.estoqueTableAdapter = new Paula.estoqueDataSet2TableAdapters.estoqueTableAdapter();
            this.estoqueDataSet2 = new Paula.estoqueDataSet2();
            this.label9 = new System.Windows.Forms.Label();
            this.lblvalorfim = new System.Windows.Forms.Label();
            this.lblvalor = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.estoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.documento = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.printDialog2 = new System.Windows.Forms.PrintDialog();
            this.txtcodbarra = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsvenda)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewestoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewsvenda
            // 
            this.dataGridViewsvenda.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewsvenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewsvenda.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewsvenda.Location = new System.Drawing.Point(0, 373);
            this.dataGridViewsvenda.Name = "dataGridViewsvenda";
            this.dataGridViewsvenda.Size = new System.Drawing.Size(693, 150);
            this.dataGridViewsvenda.TabIndex = 0;
            this.dataGridViewsvenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // lblcod
            // 
            this.lblcod.AutoSize = true;
            this.lblcod.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcod.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblcod.Location = new System.Drawing.Point(158, 24);
            this.lblcod.Name = "lblcod";
            this.lblcod.Size = new System.Drawing.Size(97, 59);
            this.lblcod.TabIndex = 2;
            this.lblcod.Text = "cod";
            this.lblcod.Click += new System.EventHandler(this.lblcod_Click);
            // 
            // txtdescricao
            // 
            this.txtdescricao.BackColor = System.Drawing.Color.Navy;
            this.txtdescricao.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescricao.ForeColor = System.Drawing.Color.White;
            this.txtdescricao.Location = new System.Drawing.Point(168, 568);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(170, 33);
            this.txtdescricao.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(171, 539);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Descrição do Prod";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(356, 538);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valor do item";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(699, 499);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Valor total da compra";
            // 
            // txtquantidade
            // 
            this.txtquantidade.BackColor = System.Drawing.Color.Navy;
            this.txtquantidade.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantidade.ForeColor = System.Drawing.Color.White;
            this.txtquantidade.Location = new System.Drawing.Point(381, 316);
            this.txtquantidade.Name = "txtquantidade";
            this.txtquantidade.Size = new System.Drawing.Size(108, 33);
            this.txtquantidade.TabIndex = 13;
            this.txtquantidade.Validating += new System.ComponentModel.CancelEventHandler(this.txtquantidade_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(376, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "Quantidade";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtcod
            // 
            this.txtcod.BackColor = System.Drawing.Color.Navy;
            this.txtcod.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcod.ForeColor = System.Drawing.Color.White;
            this.txtcod.Location = new System.Drawing.Point(0, 316);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(137, 33);
            this.txtcod.TabIndex = 15;
            this.txtcod.TextChanged += new System.EventHandler(this.txtcod_TextChanged);
            this.txtcod.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtcod_KeyUp);
            this.txtcod.Validating += new System.ComponentModel.CancelEventHandler(this.txtcod_Validating);
            this.txtcod.Validated += new System.EventHandler(this.txtcod_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(5, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "ID do produto";
            // 
            // txtvprod
            // 
            this.txtvprod.BackColor = System.Drawing.Color.Navy;
            this.txtvprod.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvprod.ForeColor = System.Drawing.Color.White;
            this.txtvprod.Location = new System.Drawing.Point(13, 568);
            this.txtvprod.Name = "txtvprod";
            this.txtvprod.Size = new System.Drawing.Size(100, 33);
            this.txtvprod.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(8, 539);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "Valor do produto";
            // 
            // btnfinalizar
            // 
            this.btnfinalizar.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.btnfinalizar.BackColor = System.Drawing.Color.Navy;
            this.btnfinalizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnfinalizar.BackgroundImage")));
            this.btnfinalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnfinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnfinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfinalizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnfinalizar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnfinalizar.Location = new System.Drawing.Point(705, 591);
            this.btnfinalizar.Name = "btnfinalizar";
            this.btnfinalizar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnfinalizar.Size = new System.Drawing.Size(212, 99);
            this.btnfinalizar.TabIndex = 18;
            this.btnfinalizar.Text = "Finalizar venda";
            this.btnfinalizar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnfinalizar.UseVisualStyleBackColor = false;
            this.btnfinalizar.TextChanged += new System.EventHandler(this.btnfinalizar_Click);
            this.btnfinalizar.Click += new System.EventHandler(this.btnfinalizar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(3, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 59);
            this.label3.TabIndex = 19;
            this.label3.Text = "Venda";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeEstoqueToolStripMenuItem,
            this.cadastroDeUsuarioToolStripMenuItem,
            this.toolStripMenuItem1,
            this.pagamentosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(986, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroDeEstoqueToolStripMenuItem
            // 
            this.cadastroDeEstoqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estoqueToolStripMenuItem});
            this.cadastroDeEstoqueToolStripMenuItem.Name = "cadastroDeEstoqueToolStripMenuItem";
            this.cadastroDeEstoqueToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.cadastroDeEstoqueToolStripMenuItem.Text = "Cadastro de Estoque";
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            this.estoqueToolStripMenuItem.Click += new System.EventHandler(this.estoqueToolStripMenuItem_Click);
            // 
            // cadastroDeUsuarioToolStripMenuItem
            // 
            this.cadastroDeUsuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem});
            this.cadastroDeUsuarioToolStripMenuItem.Name = "cadastroDeUsuarioToolStripMenuItem";
            this.cadastroDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.cadastroDeUsuarioToolStripMenuItem.Text = "Cadastro de Usuario";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Checked = true;
            this.toolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.vendasToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShowShortcutKeys = false;
            this.toolStripMenuItem1.Size = new System.Drawing.Size(122, 20);
            this.toolStripMenuItem1.Text = "Relatorio de vendas";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(108, 6);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.vendasToolStripMenuItem.Text = "Vendas";
            this.vendasToolStripMenuItem.Click += new System.EventHandler(this.vendasToolStripMenuItem_Click);
            // 
            // pagamentosToolStripMenuItem
            // 
            this.pagamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatorioDePagamentosToolStripMenuItem});
            this.pagamentosToolStripMenuItem.Name = "pagamentosToolStripMenuItem";
            this.pagamentosToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.pagamentosToolStripMenuItem.Text = "pagamentos";
            // 
            // relatorioDePagamentosToolStripMenuItem
            // 
            this.relatorioDePagamentosToolStripMenuItem.Name = "relatorioDePagamentosToolStripMenuItem";
            this.relatorioDePagamentosToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.relatorioDePagamentosToolStripMenuItem.Text = "Relatorio de pagamentos";
            this.relatorioDePagamentosToolStripMenuItem.Click += new System.EventHandler(this.relatorioDePagamentosToolStripMenuItem_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Navy;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(526, 316);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAdd.Size = new System.Drawing.Size(162, 33);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Adicionar a venda";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.Navy;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 685);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(537, 38);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(3, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 59);
            this.label8.TabIndex = 25;
            this.label8.Text = "Estoque";
            // 
            // btndirestoque
            // 
            this.btndirestoque.BackColor = System.Drawing.Color.MidnightBlue;
            this.btndirestoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btndirestoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndirestoque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndirestoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btndirestoque.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndirestoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndirestoque.Location = new System.Drawing.Point(192, 136);
            this.btndirestoque.Name = "btndirestoque";
            this.btndirestoque.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btndirestoque.Size = new System.Drawing.Size(162, 33);
            this.btndirestoque.TabIndex = 28;
            this.btndirestoque.Text = "Pesquisar estoque";
            this.btndirestoque.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btndirestoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btndirestoque.UseVisualStyleBackColor = false;
            this.btndirestoque.Click += new System.EventHandler(this.btndirestoque_Click);
            // 
            // estoqueTableAdapter1
            // 
            this.estoqueTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.estoqueTableAdapter = this.estoqueTableAdapter1;
            this.tableAdapterManager.UpdateOrder = Paula.estoqueDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(303, 13);
            // 
            // dataGridViewestoque
            // 
            this.dataGridViewestoque.AllowUserToOrderColumns = true;
            this.dataGridViewestoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewestoque.Location = new System.Drawing.Point(0, 178);
            this.dataGridViewestoque.Name = "dataGridViewestoque";
            this.dataGridViewestoque.Size = new System.Drawing.Size(673, 86);
            this.dataGridViewestoque.TabIndex = 30;
            this.dataGridViewestoque.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewestoque_CellContentClick);
            this.dataGridViewestoque.Validating += new System.ComponentModel.CancelEventHandler(this.dataGridViewestoque_Validating);
            // 
            // estoqueDataSet
            // 
            this.estoqueDataSet.DataSetName = "estoqueDataSet";
            this.estoqueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estoqueTableAdapter
            // 
            this.estoqueTableAdapter.ClearBeforeFill = true;
            // 
            // estoqueDataSet2
            // 
            this.estoqueDataSet2.DataSetName = "estoqueDataSet2";
            this.estoqueDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(699, 539);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 31);
            this.label9.TabIndex = 34;
            this.label9.Text = "R$:";
            // 
            // lblvalorfim
            // 
            this.lblvalorfim.AutoSize = true;
            this.lblvalorfim.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalorfim.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblvalorfim.Location = new System.Drawing.Point(749, 539);
            this.lblvalorfim.Name = "lblvalorfim";
            this.lblvalorfim.Size = new System.Drawing.Size(84, 31);
            this.lblvalorfim.TabIndex = 36;
            this.lblvalorfim.Text = "Valor ";
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblvalor.Location = new System.Drawing.Point(405, 570);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(84, 31);
            this.lblvalor.TabIndex = 38;
            this.lblvalor.Text = "Valor ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(355, 570);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 31);
            this.label11.TabIndex = 37;
            this.label11.Text = "R$:";
            // 
            // estoqueBindingSource
            // 
            this.estoqueBindingSource.DataMember = "estoque";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Informal Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(367, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(242, 88);
            this.label10.TabIndex = 39;
            this.label10.Text = "S.P\r\n    Systen Pro";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // documento
            // 
            this.documento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.documento_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(608, 609);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(85, 81);
            this.button1.TabIndex = 41;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDialog2
            // 
            this.printDialog2.UseEXDialog = true;
            // 
            // txtcodbarra
            // 
            this.txtcodbarra.BackColor = System.Drawing.Color.Navy;
            this.txtcodbarra.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodbarra.ForeColor = System.Drawing.Color.White;
            this.txtcodbarra.Location = new System.Drawing.Point(152, 316);
            this.txtcodbarra.Name = "txtcodbarra";
            this.txtcodbarra.Size = new System.Drawing.Size(223, 33);
            this.txtcodbarra.TabIndex = 43;
            this.txtcodbarra.TextChanged += new System.EventHandler(this.txtcodbarra_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(157, 287);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 26);
            this.label12.TabIndex = 42;
            this.label12.Text = "ID do produto";
            // 
            // frmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(986, 735);
            this.Controls.Add(this.txtcodbarra);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblvalor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblvalorfim);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridViewestoque);
            this.Controls.Add(this.btndirestoque);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnfinalizar);
            this.Controls.Add(this.txtvprod);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtquantidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcod);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridViewsvenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCaixa";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Caixa";
            this.Load += new System.EventHandler(this.frmCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsvenda)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewestoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewsvenda;
        private System.Windows.Forms.Label lblcod;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtquantidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtvprod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnfinalizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private estoqueDataSet2TableAdapters.estoqueTableAdapter estoqueTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btndirestoque;
        private estoqueDataSetTableAdapters.estoqueTableAdapter estoqueTableAdapter1;
        private estoqueDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridViewestoque;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.BindingSource estoqueBindingSource;
        private estoqueDataSet2 estoqueDataSet2;
        private estoqueDataSet estoqueDataSet;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblvalorfim;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripMenuItem pagamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioDePagamentosToolStripMenuItem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument documento;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PrintDialog printDialog2;
        private System.Windows.Forms.TextBox txtcodbarra;
        private System.Windows.Forms.Label label12;
    }
}