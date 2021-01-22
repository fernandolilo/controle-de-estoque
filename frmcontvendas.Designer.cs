namespace Paula
{
    partial class frmcontvendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcontvendas));
            this.txtperfil = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.Perfil = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Label();
            this.bntvendas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtperfil
            // 
            this.txtperfil.FormattingEnabled = true;
            this.txtperfil.Items.AddRange(new object[] {
            "Administrardor",
            "Funcionário"});
            this.txtperfil.Location = new System.Drawing.Point(30, -35);
            this.txtperfil.Name = "txtperfil";
            this.txtperfil.Size = new System.Drawing.Size(10, 21);
            this.txtperfil.TabIndex = 33;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(580, 195);
            this.dataGridView1.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(-48, -9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Adicionar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(30, -61);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(10, 20);
            this.txtLogin.TabIndex = 25;
            // 
            // Perfil
            // 
            this.Perfil.AutoSize = true;
            this.Perfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Perfil.Location = new System.Drawing.Point(-38, -35);
            this.Perfil.Name = "Perfil";
            this.Perfil.Size = new System.Drawing.Size(50, 20);
            this.Perfil.TabIndex = 24;
            this.Perfil.Text = "Perfil";
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Login.Location = new System.Drawing.Point(-38, -63);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(53, 20);
            this.Login.TabIndex = 23;
            this.Login.Text = "Login";
            // 
            // bntvendas
            // 
            this.bntvendas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntvendas.BackgroundImage")));
            this.bntvendas.Location = new System.Drawing.Point(3, 58);
            this.bntvendas.Name = "bntvendas";
            this.bntvendas.Size = new System.Drawing.Size(72, 74);
            this.bntvendas.TabIndex = 34;
            this.bntvendas.UseVisualStyleBackColor = true;
            this.bntvendas.Click += new System.EventHandler(this.bntvendas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 42);
            this.label1.TabIndex = 35;
            this.label1.Text = "vendas";
            // 
            // frmcontvendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(592, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntvendas);
            this.Controls.Add(this.txtperfil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.Perfil);
            this.Controls.Add(this.Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmcontvendas";
            this.Text = "Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtperfil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label Perfil;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Button bntvendas;
        private System.Windows.Forms.Label label1;
    }
}