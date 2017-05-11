namespace BancoDeHoras.Views
{
    partial class CadUsuario
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
            this.rb_Gerente = new System.Windows.Forms.RadioButton();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_CPF = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_CPF);
            this.panel1.Controls.Add(this.rb_Gerente);
            this.panel1.Controls.Add(this.btn_Gravar);
            this.panel1.Controls.Add(this.tb_senha);
            this.panel1.Controls.Add(this.tb_usuario);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(71, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 245);
            this.panel1.TabIndex = 7;
            // 
            // rb_Gerente
            // 
            this.rb_Gerente.AutoSize = true;
            this.rb_Gerente.Location = new System.Drawing.Point(207, 177);
            this.rb_Gerente.Name = "rb_Gerente";
            this.rb_Gerente.Size = new System.Drawing.Size(63, 17);
            this.rb_Gerente.TabIndex = 7;
            this.rb_Gerente.TabStop = true;
            this.rb_Gerente.Text = "Gerente";
            this.rb_Gerente.UseVisualStyleBackColor = true;
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.Location = new System.Drawing.Point(161, 210);
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
            this.tb_senha.Location = new System.Drawing.Point(36, 145);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(234, 26);
            this.tb_senha.TabIndex = 3;
            // 
            // tb_usuario
            // 
            this.tb_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_usuario.Location = new System.Drawing.Point(36, 88);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.Size = new System.Drawing.Size(234, 26);
            this.tb_usuario.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 68);
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
            this.label1.Location = new System.Drawing.Point(109, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cadastro de Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BancoDeHoras.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(315, 301);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 50);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // tb_CPF
            // 
            this.tb_CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CPF.Location = new System.Drawing.Point(36, 32);
            this.tb_CPF.Mask = "000,000,000-00";
            this.tb_CPF.Name = "tb_CPF";
            this.tb_CPF.Size = new System.Drawing.Size(122, 26);
            this.tb_CPF.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "CPF:";
            // 
            // CadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 364);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadUsuario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco de Horas / Cadastro de Usuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Gravar;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.TextBox tb_usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rb_Gerente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox tb_CPF;
    }
}