namespace Paula
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtLoginini = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEntarini = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsenhaini = new System.Windows.Forms.TextBox();
            this.btnSairini = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLoginini
            // 
            this.txtLoginini.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtLoginini.Location = new System.Drawing.Point(311, 12);
            this.txtLoginini.Name = "txtLoginini";
            this.txtLoginini.Size = new System.Drawing.Size(241, 32);
            this.txtLoginini.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(213, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Login";
            // 
            // btnEntarini
            // 
            this.btnEntarini.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEntarini.BackgroundImage")));
            this.btnEntarini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEntarini.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnEntarini.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntarini.Location = new System.Drawing.Point(247, 349);
            this.btnEntarini.Name = "btnEntarini";
            this.btnEntarini.Size = new System.Drawing.Size(136, 48);
            this.btnEntarini.TabIndex = 2;
            this.btnEntarini.Text = "Entrar";
            this.btnEntarini.UseVisualStyleBackColor = true;
            this.btnEntarini.Click += new System.EventHandler(this.btnEntarini_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.Location = new System.Drawing.Point(208, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Senha";
            // 
            // txtsenhaini
            // 
            this.txtsenhaini.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtsenhaini.Location = new System.Drawing.Point(311, 45);
            this.txtsenhaini.Name = "txtsenhaini";
            this.txtsenhaini.PasswordChar = '*';
            this.txtsenhaini.Size = new System.Drawing.Size(124, 32);
            this.txtsenhaini.TabIndex = 4;
            // 
            // btnSairini
            // 
            this.btnSairini.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSairini.BackgroundImage")));
            this.btnSairini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSairini.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnSairini.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSairini.Location = new System.Drawing.Point(401, 349);
            this.btnSairini.Name = "btnSairini";
            this.btnSairini.Size = new System.Drawing.Size(136, 48);
            this.btnSairini.TabIndex = 5;
            this.btnSairini.Text = "sair";
            this.btnSairini.UseVisualStyleBackColor = true;
            this.btnSairini.Click += new System.EventHandler(this.btnSairini_Click);
            // 
            // frmLogin
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(699, 398);
            this.Controls.Add(this.btnSairini);
            this.Controls.Add(this.txtsenhaini);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEntarini);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLoginini);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnentrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLoginini;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEntarini;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsenhaini;
        private System.Windows.Forms.Button btnSairini;
    }
}