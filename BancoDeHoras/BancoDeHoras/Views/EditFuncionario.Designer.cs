﻿namespace BancoDeHoras.Views
{
    partial class EditFuncionario
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
            this.tb_CNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cb_Gerente = new System.Windows.Forms.CheckBox();
            this.tb_Celular = new System.Windows.Forms.MaskedTextBox();
            this.tb_CPF = new System.Windows.Forms.MaskedTextBox();
            this.tb_Demissao = new System.Windows.Forms.MaskedTextBox();
            this.tb_Admissao = new System.Windows.Forms.MaskedTextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_Nome_Emp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Pesquisar_Func = new System.Windows.Forms.Button();
            this.tb_CPF_Pesquisa = new System.Windows.Forms.MaskedTextBox();
            this.tb_Nome_Pesquisa = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_CNPJ
            // 
            this.tb_CNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CNPJ.Location = new System.Drawing.Point(468, 27);
            this.tb_CNPJ.Mask = "00,000,000/0000-00";
            this.tb_CNPJ.Name = "tb_CNPJ";
            this.tb_CNPJ.Size = new System.Drawing.Size(173, 26);
            this.tb_CNPJ.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(231, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(250, 24);
            this.label9.TabIndex = 19;
            this.label9.Text = "Editar Dados do Funcionário";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.cb_Gerente);
            this.panel3.Controls.Add(this.tb_Celular);
            this.panel3.Controls.Add(this.tb_CPF);
            this.panel3.Controls.Add(this.tb_Demissao);
            this.panel3.Controls.Add(this.tb_Admissao);
            this.panel3.Controls.Add(this.tb_Email);
            this.panel3.Controls.Add(this.tb_Nome);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(14, 196);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(684, 234);
            this.panel3.TabIndex = 18;
            // 
            // cb_Gerente
            // 
            this.cb_Gerente.AutoSize = true;
            this.cb_Gerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Gerente.Location = new System.Drawing.Point(313, 203);
            this.cb_Gerente.Name = "cb_Gerente";
            this.cb_Gerente.Size = new System.Drawing.Size(87, 24);
            this.cb_Gerente.TabIndex = 20;
            this.cb_Gerente.Text = "Gerente";
            this.cb_Gerente.UseVisualStyleBackColor = true;
            // 
            // tb_Celular
            // 
            this.tb_Celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Celular.Location = new System.Drawing.Point(490, 86);
            this.tb_Celular.Mask = "(999) 00000-0000";
            this.tb_Celular.Name = "tb_Celular";
            this.tb_Celular.Size = new System.Drawing.Size(151, 26);
            this.tb_Celular.TabIndex = 19;
            // 
            // tb_CPF
            // 
            this.tb_CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_CPF.Location = new System.Drawing.Point(505, 30);
            this.tb_CPF.Mask = "000,000,000-00";
            this.tb_CPF.Name = "tb_CPF";
            this.tb_CPF.Size = new System.Drawing.Size(136, 26);
            this.tb_CPF.TabIndex = 18;
            // 
            // tb_Demissao
            // 
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
            this.tb_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Email.Location = new System.Drawing.Point(20, 86);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(366, 26);
            this.tb_Email.TabIndex = 8;
            // 
            // tb_Nome
            // 
            this.tb_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Nome.Location = new System.Drawing.Point(20, 31);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(363, 26);
            this.tb_Nome.TabIndex = 6;
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
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Celular:";
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
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BancoDeHoras.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(572, 447);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 50);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(235, 447);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 22;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.Location = new System.Drawing.Point(406, 447);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(75, 23);
            this.btn_Gravar.TabIndex = 21;
            this.btn_Gravar.Text = "Gravar";
            this.btn_Gravar.UseVisualStyleBackColor = true;
            this.btn_Gravar.Click += new System.EventHandler(this.btn_Gravar_Click);
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
            this.panel1.Size = new System.Drawing.Size(684, 64);
            this.panel1.TabIndex = 17;
            // 
            // tb_Nome_Emp
            // 
            this.tb_Nome_Emp.Enabled = false;
            this.tb_Nome_Emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Nome_Emp.Location = new System.Drawing.Point(20, 27);
            this.tb_Nome_Emp.Name = "tb_Nome_Emp";
            this.tb_Nome_Emp.Size = new System.Drawing.Size(376, 26);
            this.tb_Nome_Emp.TabIndex = 12;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(270, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 24);
            this.label10.TabIndex = 23;
            this.label10.Text = "Buscar Funcionário";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btn_Pesquisar_Func);
            this.panel4.Controls.Add(this.tb_CPF_Pesquisa);
            this.panel4.Controls.Add(this.tb_Nome_Pesquisa);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Location = new System.Drawing.Point(14, 105);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(684, 59);
            this.panel4.TabIndex = 24;
            // 
            // btn_Pesquisar_Func
            // 
            this.btn_Pesquisar_Func.Location = new System.Drawing.Point(566, 22);
            this.btn_Pesquisar_Func.Name = "btn_Pesquisar_Func";
            this.btn_Pesquisar_Func.Size = new System.Drawing.Size(75, 23);
            this.btn_Pesquisar_Func.TabIndex = 23;
            this.btn_Pesquisar_Func.Text = "Pesquisar";
            this.btn_Pesquisar_Func.UseVisualStyleBackColor = true;
            this.btn_Pesquisar_Func.Click += new System.EventHandler(this.btn_Pesquisar_Func_Click);
            // 
            // tb_CPF_Pesquisa
            // 
            this.tb_CPF_Pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_CPF_Pesquisa.Location = new System.Drawing.Point(409, 19);
            this.tb_CPF_Pesquisa.Mask = "000,000,000-00";
            this.tb_CPF_Pesquisa.Name = "tb_CPF_Pesquisa";
            this.tb_CPF_Pesquisa.Size = new System.Drawing.Size(136, 26);
            this.tb_CPF_Pesquisa.TabIndex = 22;
            // 
            // tb_Nome_Pesquisa
            // 
            this.tb_Nome_Pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Nome_Pesquisa.Location = new System.Drawing.Point(20, 20);
            this.tb_Nome_Pesquisa.Name = "tb_Nome_Pesquisa";
            this.tb_Nome_Pesquisa.Size = new System.Drawing.Size(363, 26);
            this.tb_Nome_Pesquisa.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(409, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "CPF:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(20, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "Nome:";
            // 
            // EditFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 504);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Gravar);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditFuncionario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco de Horas /Editar Dados do Funcionário";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox tb_CNPJ;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MaskedTextBox tb_Celular;
        private System.Windows.Forms.MaskedTextBox tb_CPF;
        private System.Windows.Forms.MaskedTextBox tb_Demissao;
        private System.Windows.Forms.MaskedTextBox tb_Admissao;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Gravar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_Pesquisar_Func;
        private System.Windows.Forms.MaskedTextBox tb_CPF_Pesquisa;
        private System.Windows.Forms.TextBox tb_Nome_Pesquisa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_Nome_Emp;
        private System.Windows.Forms.CheckBox cb_Gerente;
    }
}