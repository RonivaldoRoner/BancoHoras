namespace BancoDeHoras.Views
{
    partial class Principal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Cad_Empresa = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Cad_Responsavel = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Cad_Funcionario = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Novo_Reg = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Reg_Analise = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 491);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(187, 336);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(655, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "Contabilidade Integrada ao futuro!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::BancoDeHoras.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(321, 173);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 160);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarEmpresaToolStripMenuItem,
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1004, 33);
            this.menuStrip1.TabIndex = 5;
            // 
            // cadastrarEmpresaToolStripMenuItem
            // 
            this.cadastrarEmpresaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Cad_Empresa,
            this.btn_Cad_Responsavel,
            this.btn_Cad_Funcionario,
            this.usuáriosToolStripMenuItem});
            this.cadastrarEmpresaToolStripMenuItem.Name = "cadastrarEmpresaToolStripMenuItem";
            this.cadastrarEmpresaToolStripMenuItem.Size = new System.Drawing.Size(107, 29);
            this.cadastrarEmpresaToolStripMenuItem.Text = "Cadastros";
            // 
            // btn_Cad_Empresa
            // 
            this.btn_Cad_Empresa.Name = "btn_Cad_Empresa";
            this.btn_Cad_Empresa.Size = new System.Drawing.Size(192, 30);
            this.btn_Cad_Empresa.Text = "Empresa";
            this.btn_Cad_Empresa.Click += new System.EventHandler(this.empresaToolStripMenuItem_Click);
            // 
            // btn_Cad_Responsavel
            // 
            this.btn_Cad_Responsavel.Name = "btn_Cad_Responsavel";
            this.btn_Cad_Responsavel.Size = new System.Drawing.Size(192, 30);
            this.btn_Cad_Responsavel.Text = "Responsável";
            this.btn_Cad_Responsavel.Click += new System.EventHandler(this.btn_Cad_Responsavel_Click);
            // 
            // btn_Cad_Funcionario
            // 
            this.btn_Cad_Funcionario.Name = "btn_Cad_Funcionario";
            this.btn_Cad_Funcionario.Size = new System.Drawing.Size(192, 30);
            this.btn_Cad_Funcionario.Text = "Funcionários";
            this.btn_Cad_Funcionario.Click += new System.EventHandler(this.btn_Cad_Funcionario_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(192, 30);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Novo_Reg,
            this.btn_Reg_Analise});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // btn_Novo_Reg
            // 
            this.btn_Novo_Reg.Name = "btn_Novo_Reg";
            this.btn_Novo_Reg.Size = new System.Drawing.Size(176, 30);
            this.btn_Novo_Reg.Text = "Novo";
            this.btn_Novo_Reg.Click += new System.EventHandler(this.btn_Novo_Reg_Click);
            // 
            // btn_Reg_Analise
            // 
            this.btn_Reg_Analise.Name = "btn_Reg_Analise";
            this.btn_Reg_Analise.Size = new System.Drawing.Size(176, 30);
            this.btn_Reg_Analise.Text = "Em Análise";
            this.btn_Reg_Analise.Click += new System.EventHandler(this.btn_Reg_Analise_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(106, 29);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 515);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.ShowIcon = false;
            this.Text = "Banco de Horas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_Cad_Empresa;
        private System.Windows.Forms.ToolStripMenuItem btn_Cad_Funcionario;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_Cad_Responsavel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_Novo_Reg;
        private System.Windows.Forms.ToolStripMenuItem btn_Reg_Analise;
    }
}