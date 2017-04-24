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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Cad_Empresa = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Cad_Responsavel = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Cad_Funcionario = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Cad_Usuario = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 491);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::BancoDeHoras.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(237, 184);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(599, 254);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarEmpresaToolStripMenuItem,
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1004, 29);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarEmpresaToolStripMenuItem
            // 
            this.cadastrarEmpresaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Cad_Empresa,
            this.btn_Cad_Responsavel,
            this.btn_Cad_Funcionario,
            this.btn_Cad_Usuario});
            this.cadastrarEmpresaToolStripMenuItem.Name = "cadastrarEmpresaToolStripMenuItem";
            this.cadastrarEmpresaToolStripMenuItem.Size = new System.Drawing.Size(91, 25);
            this.cadastrarEmpresaToolStripMenuItem.Text = "Cadastros";
            // 
            // btn_Cad_Empresa
            // 
            this.btn_Cad_Empresa.Name = "btn_Cad_Empresa";
            this.btn_Cad_Empresa.Size = new System.Drawing.Size(169, 26);
            this.btn_Cad_Empresa.Text = "Empresa";
            this.btn_Cad_Empresa.Click += new System.EventHandler(this.empresaToolStripMenuItem_Click);
            // 
            // btn_Cad_Responsavel
            // 
            this.btn_Cad_Responsavel.Name = "btn_Cad_Responsavel";
            this.btn_Cad_Responsavel.Size = new System.Drawing.Size(169, 26);
            this.btn_Cad_Responsavel.Text = "Responsável";
            this.btn_Cad_Responsavel.Click += new System.EventHandler(this.btn_Cad_Responsavel_Click);
            // 
            // btn_Cad_Funcionario
            // 
            this.btn_Cad_Funcionario.Name = "btn_Cad_Funcionario";
            this.btn_Cad_Funcionario.Size = new System.Drawing.Size(169, 26);
            this.btn_Cad_Funcionario.Text = "Funcionários";
            this.btn_Cad_Funcionario.Click += new System.EventHandler(this.btn_Cad_Funcionario_Click);
            // 
            // btn_Cad_Usuario
            // 
            this.btn_Cad_Usuario.Name = "btn_Cad_Usuario";
            this.btn_Cad_Usuario.Size = new System.Drawing.Size(169, 26);
            this.btn_Cad_Usuario.Text = "Usuários";
            this.btn_Cad_Usuario.Click += new System.EventHandler(this.btn_Cad_Usuario_Click);
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(87, 25);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(90, 25);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 515);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.ShowIcon = false;
            this.Text = "Banco de Horas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.ToolStripMenuItem btn_Cad_Usuario;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_Cad_Responsavel;
    }
}