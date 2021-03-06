﻿namespace BancoDeHoras.Views
{
    partial class DadosFuncionario
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.tb_CPF = new System.Windows.Forms.MaskedTextBox();
            this.tb_Demissao = new System.Windows.Forms.MaskedTextBox();
            this.tb_Admissao = new System.Windows.Forms.MaskedTextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_Nome_Func = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_Nome_Emp = new System.Windows.Forms.TextBox();
            this.tb_CNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(468, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "CNPJ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(18, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Empresa:";
            // 
            // tb_Telefone
            // 
            this.tb_Telefone.Enabled = false;
            this.tb_Telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tb_Telefone.Location = new System.Drawing.Point(490, 86);
            this.tb_Telefone.Mask = "(999) 00000-0000";
            this.tb_Telefone.Name = "tb_Telefone";
            this.tb_Telefone.Size = new System.Drawing.Size(151, 26);
            this.tb_Telefone.TabIndex = 19;
            // 
            // tb_CPF
            // 
            this.tb_CPF.Enabled = false;
            this.tb_CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tb_CPF.Location = new System.Drawing.Point(505, 30);
            this.tb_CPF.Mask = "000,000,000-00";
            this.tb_CPF.Name = "tb_CPF";
            this.tb_CPF.Size = new System.Drawing.Size(136, 26);
            this.tb_CPF.TabIndex = 18;
            // 
            // tb_Demissao
            // 
            this.tb_Demissao.Enabled = false;
            this.tb_Demissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Demissao.Location = new System.Drawing.Point(550, 142);
            this.tb_Demissao.Mask = "00/00/0000";
            this.tb_Demissao.Name = "tb_Demissao";
            this.tb_Demissao.Size = new System.Drawing.Size(91, 26);
            this.tb_Demissao.TabIndex = 17;
            this.tb_Demissao.ValidatingType = typeof(System.DateTime);
            // 
            // tb_Admissao
            // 
            this.tb_Admissao.Enabled = false;
            this.tb_Admissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Admissao.Location = new System.Drawing.Point(20, 142);
            this.tb_Admissao.Mask = "00/00/0000";
            this.tb_Admissao.Name = "tb_Admissao";
            this.tb_Admissao.Size = new System.Drawing.Size(93, 26);
            this.tb_Admissao.TabIndex = 16;
            this.tb_Admissao.ValidatingType = typeof(System.DateTime);
            // 
            // tb_Email
            // 
            this.tb_Email.Enabled = false;
            this.tb_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tb_Email.Location = new System.Drawing.Point(20, 86);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(366, 26);
            this.tb_Email.TabIndex = 8;
            // 
            // tb_Nome_Func
            // 
            this.tb_Nome_Func.Enabled = false;
            this.tb_Nome_Func.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tb_Nome_Func.Location = new System.Drawing.Point(20, 31);
            this.tb_Nome_Func.Name = "tb_Nome_Func";
            this.tb_Nome_Func.Size = new System.Drawing.Size(363, 26);
            this.tb_Nome_Func.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tb_Nome_Emp);
            this.panel1.Controls.Add(this.tb_CNPJ);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 74);
            this.panel1.TabIndex = 10;
            // 
            // tb_Nome_Emp
            // 
            this.tb_Nome_Emp.Enabled = false;
            this.tb_Nome_Emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Nome_Emp.Location = new System.Drawing.Point(20, 27);
            this.tb_Nome_Emp.Name = "tb_Nome_Emp";
            this.tb_Nome_Emp.Size = new System.Drawing.Size(376, 26);
            this.tb_Nome_Emp.TabIndex = 13;
            // 
            // tb_CNPJ
            // 
            this.tb_CNPJ.Enabled = false;
            this.tb_CNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CNPJ.Location = new System.Drawing.Point(468, 27);
            this.tb_CNPJ.Mask = "00,000,000/0000-00";
            this.tb_CNPJ.Name = "tb_CNPJ";
            this.tb_CNPJ.Size = new System.Drawing.Size(173, 26);
            this.tb_CNPJ.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(550, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Demissão:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(18, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(505, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(490, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(18, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome:";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(212, 404);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 15;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Location = new System.Drawing.Point(420, 404);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cadastrar.TabIndex = 14;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(253, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(206, 24);
            this.label9.TabIndex = 12;
            this.label9.Text = "Dados do Funcionarios";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.tb_Telefone);
            this.panel3.Controls.Add(this.tb_CPF);
            this.panel3.Controls.Add(this.tb_Demissao);
            this.panel3.Controls.Add(this.tb_Admissao);
            this.panel3.Controls.Add(this.tb_Email);
            this.panel3.Controls.Add(this.tb_Nome_Func);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(14, 143);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(684, 189);
            this.panel3.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(18, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Admissão:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BancoDeHoras.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(566, 404);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 50);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(319, 404);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(75, 23);
            this.btn_Editar.TabIndex = 16;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // DadosFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 464);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DadosFuncionario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco de Horas / Dados da Funcionário";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox tb_Telefone;
        private System.Windows.Forms.MaskedTextBox tb_CPF;
        private System.Windows.Forms.MaskedTextBox tb_Demissao;
        private System.Windows.Forms.MaskedTextBox tb_Admissao;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_Nome_Func;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.MaskedTextBox tb_CNPJ;
        private System.Windows.Forms.TextBox tb_Nome_Emp;
    }
}