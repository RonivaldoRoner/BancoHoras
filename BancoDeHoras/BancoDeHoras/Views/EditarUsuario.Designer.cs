namespace BancoDeHoras.Views
{
    partial class EditarUsuario
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
            this.btn_Novo_Usuario = new System.Windows.Forms.Button();
            this.btn_LocalizaUsuario = new System.Windows.Forms.Button();
            this.tb_CPF_Busca = new System.Windows.Forms.MaskedTextBox();
            this.rb_Gerente = new System.Windows.Forms.RadioButton();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_Novo_Usuario);
            this.panel1.Controls.Add(this.btn_LocalizaUsuario);
            this.panel1.Controls.Add(this.tb_CPF_Busca);
            this.panel1.Controls.Add(this.rb_Gerente);
            this.panel1.Controls.Add(this.btn_Gravar);
            this.panel1.Controls.Add(this.tb_senha);
            this.panel1.Controls.Add(this.tb_usuario);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(66, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 248);
            this.panel1.TabIndex = 10;
            // 
            // btn_Novo_Usuario
            // 
            this.btn_Novo_Usuario.Location = new System.Drawing.Point(45, 207);
            this.btn_Novo_Usuario.Name = "btn_Novo_Usuario";
            this.btn_Novo_Usuario.Size = new System.Drawing.Size(94, 23);
            this.btn_Novo_Usuario.TabIndex = 10;
            this.btn_Novo_Usuario.Text = "Novo";
            this.btn_Novo_Usuario.UseVisualStyleBackColor = true;
            this.btn_Novo_Usuario.Click += new System.EventHandler(this.btn_Novo_Usuario_Click);
            // 
            // btn_LocalizaUsuario
            // 
            this.btn_LocalizaUsuario.Location = new System.Drawing.Point(177, 26);
            this.btn_LocalizaUsuario.Name = "btn_LocalizaUsuario";
            this.btn_LocalizaUsuario.Size = new System.Drawing.Size(102, 23);
            this.btn_LocalizaUsuario.TabIndex = 9;
            this.btn_LocalizaUsuario.Text = "Localizar Usuario";
            this.btn_LocalizaUsuario.UseVisualStyleBackColor = true;
            this.btn_LocalizaUsuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_CPF_Busca
            // 
            this.tb_CPF_Busca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CPF_Busca.Location = new System.Drawing.Point(45, 26);
            this.tb_CPF_Busca.Mask = "000,000,000-00";
            this.tb_CPF_Busca.Name = "tb_CPF_Busca";
            this.tb_CPF_Busca.Size = new System.Drawing.Size(122, 26);
            this.tb_CPF_Busca.TabIndex = 8;
            // 
            // rb_Gerente
            // 
            this.rb_Gerente.AutoSize = true;
            this.rb_Gerente.Location = new System.Drawing.Point(216, 174);
            this.rb_Gerente.Name = "rb_Gerente";
            this.rb_Gerente.Size = new System.Drawing.Size(63, 17);
            this.rb_Gerente.TabIndex = 7;
            this.rb_Gerente.TabStop = true;
            this.rb_Gerente.Text = "Gerente";
            this.rb_Gerente.UseVisualStyleBackColor = true;
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.Location = new System.Drawing.Point(170, 207);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(109, 23);
            this.btn_Gravar.TabIndex = 4;
            this.btn_Gravar.Text = "Gravar";
            this.btn_Gravar.UseVisualStyleBackColor = true;
            this.btn_Gravar.Click += new System.EventHandler(this.btn_Gravar_Click);
            // 
            // tb_senha
            // 
            this.tb_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_senha.Location = new System.Drawing.Point(45, 142);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(234, 26);
            this.tb_senha.TabIndex = 3;
            // 
            // tb_usuario
            // 
            this.tb_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_usuario.Location = new System.Drawing.Point(45, 85);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.Size = new System.Drawing.Size(234, 26);
            this.tb_usuario.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(75, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cadastro de Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BancoDeHoras.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(326, 298);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 50);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // EditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 352);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditarUsuario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco de Horas / Edição de Usuaário";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rb_Gerente;
        private System.Windows.Forms.Button btn_Gravar;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.TextBox tb_usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_LocalizaUsuario;
        private System.Windows.Forms.MaskedTextBox tb_CPF_Busca;
        private System.Windows.Forms.Button btn_Novo_Usuario;
    }
}