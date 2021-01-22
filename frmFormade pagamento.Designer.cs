namespace Paula
{
    partial class frmFormade_pagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormade_pagamento));
            this.label1 = new System.Windows.Forms.Label();
            this.txtbandeira = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnfinalizar = new System.Windows.Forms.Button();
            this.lblformadepagamento = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblvalor = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdata = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtparcelas = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblvparcelas = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtpagamento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbltroco = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chdinheiro = new System.Windows.Forms.CheckBox();
            this.chdebito = new System.Windows.Forms.CheckBox();
            this.chcredito = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(1, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forma de pagamento";
            // 
            // txtbandeira
            // 
            this.txtbandeira.BackColor = System.Drawing.Color.Navy;
            this.txtbandeira.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbandeira.ForeColor = System.Drawing.SystemColors.Window;
            this.txtbandeira.Location = new System.Drawing.Point(164, 264);
            this.txtbandeira.Name = "txtbandeira";
            this.txtbandeira.Size = new System.Drawing.Size(236, 38);
            this.txtbandeira.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bandeira do cartão";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Forma de pagamento";
            // 
            // btnfinalizar
            // 
            this.btnfinalizar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnfinalizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnfinalizar.BackgroundImage")));
            this.btnfinalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnfinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfinalizar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnfinalizar.Location = new System.Drawing.Point(6, 538);
            this.btnfinalizar.Name = "btnfinalizar";
            this.btnfinalizar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnfinalizar.Size = new System.Drawing.Size(211, 42);
            this.btnfinalizar.TabIndex = 24;
            this.btnfinalizar.Text = "Pagamento efetuado com Sucesso";
            this.btnfinalizar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnfinalizar.UseVisualStyleBackColor = false;
            this.btnfinalizar.Click += new System.EventHandler(this.btnfinalizar_Click);
            // 
            // lblformadepagamento
            // 
            this.lblformadepagamento.AutoSize = true;
            this.lblformadepagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblformadepagamento.ForeColor = System.Drawing.Color.Maroon;
            this.lblformadepagamento.Location = new System.Drawing.Point(560, 250);
            this.lblformadepagamento.Name = "lblformadepagamento";
            this.lblformadepagamento.Size = new System.Drawing.Size(233, 31);
            this.lblformadepagamento.TabIndex = 26;
            this.lblformadepagamento.Text = "Código de venda";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.ForeColor = System.Drawing.Color.Maroon;
            this.lblid.Location = new System.Drawing.Point(799, 248);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(39, 31);
            this.lblid.TabIndex = 27;
            this.lblid.Text = "Id";
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.Navy;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.ForeColor = System.Drawing.SystemColors.Window;
            this.txtid.Location = new System.Drawing.Point(679, 168);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(70, 38);
            this.txtid.TabIndex = 28;
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalor.ForeColor = System.Drawing.Color.Maroon;
            this.lblvalor.Location = new System.Drawing.Point(865, 311);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(61, 31);
            this.lblvalor.TabIndex = 30;
            this.lblvalor.Text = "cod";
            this.lblvalor.Click += new System.EventHandler(this.lblvalor_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(561, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 60);
            this.button2.TabIndex = 31;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(566, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 31);
            this.label5.TabIndex = 33;
            this.label5.Text = "Valor a ser pago";
            // 
            // txtdata
            // 
            this.txtdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdata.Location = new System.Drawing.Point(775, 542);
            this.txtdata.Mask = "00/00/0000";
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(162, 38);
            this.txtdata.TabIndex = 34;
            this.txtdata.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(799, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 31);
            this.label4.TabIndex = 38;
            this.label4.Text = "R$:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(689, 549);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 31);
            this.label6.TabIndex = 39;
            this.label6.Text = "Data";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(175, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(313, 31);
            this.label7.TabIndex = 41;
            this.label7.Text = "Valor pago em dinheiro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(12, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(250, 62);
            this.label8.TabIndex = 43;
            this.label8.Text = "Quer parcelar \r\nem quantas vezes";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtparcelas
            // 
            this.txtparcelas.BackColor = System.Drawing.Color.Navy;
            this.txtparcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtparcelas.ForeColor = System.Drawing.SystemColors.Window;
            this.txtparcelas.Location = new System.Drawing.Point(21, 451);
            this.txtparcelas.Name = "txtparcelas";
            this.txtparcelas.Size = new System.Drawing.Size(225, 38);
            this.txtparcelas.TabIndex = 42;
            this.txtparcelas.TextChanged += new System.EventHandler(this.txtparcelar_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(268, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(241, 31);
            this.label9.TabIndex = 46;
            this.label9.Text = "Valor de parcelas";
            // 
            // lblvparcelas
            // 
            this.lblvparcelas.AutoSize = true;
            this.lblvparcelas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblvparcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvparcelas.ForeColor = System.Drawing.Color.Maroon;
            this.lblvparcelas.Location = new System.Drawing.Point(327, 428);
            this.lblvparcelas.Name = "lblvparcelas";
            this.lblvparcelas.Size = new System.Drawing.Size(256, 31);
            this.lblvparcelas.TabIndex = 48;
            this.lblvparcelas.Text = "Valor das parcelas";
            this.lblvparcelas.Click += new System.EventHandler(this.txtvalorparcelas_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(268, 428);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 31);
            this.label10.TabIndex = 50;
            this.label10.Text = "R$:";
            // 
            // txtpagamento
            // 
            this.txtpagamento.BackColor = System.Drawing.Color.Navy;
            this.txtpagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpagamento.ForeColor = System.Drawing.SystemColors.Window;
            this.txtpagamento.Location = new System.Drawing.Point(181, 122);
            this.txtpagamento.Name = "txtpagamento";
            this.txtpagamento.Size = new System.Drawing.Size(219, 38);
            this.txtpagamento.TabIndex = 51;
            this.txtpagamento.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(452, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 31);
            this.label11.TabIndex = 52;
            this.label11.Text = "Troco";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Maroon;
            this.label12.Location = new System.Drawing.Point(533, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 31);
            this.label12.TabIndex = 54;
            this.label12.Text = "R$:";
            // 
            // lbltroco
            // 
            this.lbltroco.AutoSize = true;
            this.lbltroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltroco.ForeColor = System.Drawing.Color.Maroon;
            this.lbltroco.Location = new System.Drawing.Point(587, 31);
            this.lbltroco.Name = "lbltroco";
            this.lbltroco.Size = new System.Drawing.Size(196, 31);
            this.lbltroco.TabIndex = 53;
            this.lbltroco.Text = "Valor do troco";
            this.lbltroco.Click += new System.EventHandler(this.lbltroco_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(34, 37);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(34, 37);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 289);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(34, 36);
            this.groupBox3.TabIndex = 57;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // chdinheiro
            // 
            this.chdinheiro.AutoSize = true;
            this.chdinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.chdinheiro.Location = new System.Drawing.Point(18, 91);
            this.chdinheiro.Name = "chdinheiro";
            this.chdinheiro.Size = new System.Drawing.Size(142, 35);
            this.chdinheiro.TabIndex = 58;
            this.chdinheiro.Text = "Dinheiro";
            this.chdinheiro.UseVisualStyleBackColor = true;
            // 
            // chdebito
            // 
            this.chdebito.AutoSize = true;
            this.chdebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.chdebito.Location = new System.Drawing.Point(21, 168);
            this.chdebito.Name = "chdebito";
            this.chdebito.Size = new System.Drawing.Size(118, 35);
            this.chdebito.TabIndex = 59;
            this.chdebito.Text = "Debito";
            this.chdebito.UseVisualStyleBackColor = true;
            // 
            // chcredito
            // 
            this.chcredito.AutoSize = true;
            this.chcredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.chcredito.Location = new System.Drawing.Point(21, 294);
            this.chcredito.Name = "chcredito";
            this.chcredito.Size = new System.Drawing.Size(128, 35);
            this.chcredito.TabIndex = 60;
            this.chcredito.Text = "Credito";
            this.chcredito.UseVisualStyleBackColor = true;
            // 
            // frmFormade_pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(959, 592);
            this.Controls.Add(this.chcredito);
            this.Controls.Add(this.chdebito);
            this.Controls.Add(this.chdinheiro);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbltroco);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtpagamento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblvparcelas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtparcelas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdata);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblvalor);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblformadepagamento);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnfinalizar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbandeira);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmFormade_pagamento";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Formade Pagamento";
            this.Load += new System.EventHandler(this.frmFormade_pagamento_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmFormade_pagamento_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbandeira;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnfinalizar;
        private System.Windows.Forms.Label lblformadepagamento;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtdata;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtparcelas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblvparcelas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtpagamento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbltroco;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chdinheiro;
        private System.Windows.Forms.CheckBox chdebito;
        private System.Windows.Forms.CheckBox chcredito;
    }
}