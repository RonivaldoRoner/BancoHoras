namespace BancoDeHoras.Views
{
    partial class CadRegistros
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
            this.tb_Nome_Emp = new System.Windows.Forms.TextBox();
            this.tb_CNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_Nome_Func = new System.Windows.Forms.TextBox();
            this.tb_CPF = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rb_Compensacao = new System.Windows.Forms.RadioButton();
            this.rb_Hora_Extra = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_Fim_Reg = new System.Windows.Forms.MaskedTextBox();
            this.tb_Inicio_Reg = new System.Windows.Forms.MaskedTextBox();
            this.cb_Responsavel = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Data_Reg = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Descricao_Reg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Gravar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tb_Nome_Emp);
            this.panel1.Controls.Add(this.tb_CNPJ);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 62);
            this.panel1.TabIndex = 11;
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tb_Nome_Func);
            this.panel2.Controls.Add(this.tb_CPF);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(14, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 62);
            this.panel2.TabIndex = 12;
            // 
            // tb_Nome_Func
            // 
            this.tb_Nome_Func.Enabled = false;
            this.tb_Nome_Func.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Nome_Func.Location = new System.Drawing.Point(20, 27);
            this.tb_Nome_Func.Name = "tb_Nome_Func";
            this.tb_Nome_Func.Size = new System.Drawing.Size(376, 26);
            this.tb_Nome_Func.TabIndex = 17;
            // 
            // tb_CPF
            // 
            this.tb_CPF.Enabled = false;
            this.tb_CPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CPF.Location = new System.Drawing.Point(503, 27);
            this.tb_CPF.Mask = "000,000,000-00";
            this.tb_CPF.Name = "tb_CPF";
            this.tb_CPF.Size = new System.Drawing.Size(138, 26);
            this.tb_CPF.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(503, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(20, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Funcionário:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.tb_Fim_Reg);
            this.panel3.Controls.Add(this.tb_Inicio_Reg);
            this.panel3.Controls.Add(this.cb_Responsavel);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.tb_Data_Reg);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.tb_Descricao_Reg);
            this.panel3.Location = new System.Drawing.Point(14, 172);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(684, 286);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.rb_Compensacao);
            this.panel4.Controls.Add(this.rb_Hora_Extra);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(-2, -2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(684, 42);
            this.panel4.TabIndex = 26;
            // 
            // rb_Compensacao
            // 
            this.rb_Compensacao.AutoSize = true;
            this.rb_Compensacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Compensacao.Location = new System.Drawing.Point(423, 8);
            this.rb_Compensacao.Name = "rb_Compensacao";
            this.rb_Compensacao.Size = new System.Drawing.Size(116, 21);
            this.rb_Compensacao.TabIndex = 29;
            this.rb_Compensacao.TabStop = true;
            this.rb_Compensacao.Text = "Compensação";
            this.rb_Compensacao.UseVisualStyleBackColor = true;
            // 
            // rb_Hora_Extra
            // 
            this.rb_Hora_Extra.AutoSize = true;
            this.rb_Hora_Extra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Hora_Extra.Location = new System.Drawing.Point(303, 8);
            this.rb_Hora_Extra.Name = "rb_Hora_Extra";
            this.rb_Hora_Extra.Size = new System.Drawing.Size(93, 21);
            this.rb_Hora_Extra.TabIndex = 28;
            this.rb_Hora_Extra.TabStop = true;
            this.rb_Hora_Extra.Text = "Hora Extra";
            this.rb_Hora_Extra.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(124, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "Tipo de Registro:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(23, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Descrição:";
            // 
            // tb_Fim_Reg
            // 
            this.tb_Fim_Reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Fim_Reg.Location = new System.Drawing.Point(340, 64);
            this.tb_Fim_Reg.Mask = "00:00";
            this.tb_Fim_Reg.Name = "tb_Fim_Reg";
            this.tb_Fim_Reg.Size = new System.Drawing.Size(56, 26);
            this.tb_Fim_Reg.TabIndex = 3;
            // 
            // tb_Inicio_Reg
            // 
            this.tb_Inicio_Reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Inicio_Reg.Location = new System.Drawing.Point(202, 66);
            this.tb_Inicio_Reg.Mask = "00:00";
            this.tb_Inicio_Reg.Name = "tb_Inicio_Reg";
            this.tb_Inicio_Reg.Size = new System.Drawing.Size(53, 26);
            this.tb_Inicio_Reg.TabIndex = 2;
            // 
            // cb_Responsavel
            // 
            this.cb_Responsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Responsavel.FormattingEnabled = true;
            this.cb_Responsavel.Location = new System.Drawing.Point(452, 64);
            this.cb_Responsavel.Name = "cb_Responsavel";
            this.cb_Responsavel.Size = new System.Drawing.Size(183, 28);
            this.cb_Responsavel.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(452, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Responsável:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(340, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Fim:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(202, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Inicio:";
            // 
            // tb_Data_Reg
            // 
            this.tb_Data_Reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Data_Reg.Location = new System.Drawing.Point(23, 64);
            this.tb_Data_Reg.Mask = "00/00/0000";
            this.tb_Data_Reg.Name = "tb_Data_Reg";
            this.tb_Data_Reg.Size = new System.Drawing.Size(92, 26);
            this.tb_Data_Reg.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(23, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Data:";
            // 
            // tb_Descricao_Reg
            // 
            this.tb_Descricao_Reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Descricao_Reg.Location = new System.Drawing.Point(23, 142);
            this.tb_Descricao_Reg.MaxLength = 420;
            this.tb_Descricao_Reg.Multiline = true;
            this.tb_Descricao_Reg.Name = "tb_Descricao_Reg";
            this.tb_Descricao_Reg.Size = new System.Drawing.Size(612, 128);
            this.tb_Descricao_Reg.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(292, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Novo Registro";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BancoDeHoras.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(572, 464);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 50);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Gravar
            // 
            this.btn_Gravar.Location = new System.Drawing.Point(400, 464);
            this.btn_Gravar.Name = "btn_Gravar";
            this.btn_Gravar.Size = new System.Drawing.Size(75, 23);
            this.btn_Gravar.TabIndex = 18;
            this.btn_Gravar.Text = "Gravar";
            this.btn_Gravar.UseVisualStyleBackColor = true;
            this.btn_Gravar.Click += new System.EventHandler(this.btn_Gravar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(238, 464);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 19;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // CadRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 522);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Gravar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadRegistros";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco de Horas / Novo Registro";
            this.Load += new System.EventHandler(this.CadRegistros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_Nome_Emp;
        private System.Windows.Forms.MaskedTextBox tb_CNPJ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_Nome_Func;
        private System.Windows.Forms.MaskedTextBox tb_CPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Descricao_Reg;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox tb_Fim_Reg;
        private System.Windows.Forms.ComboBox cb_Responsavel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox tb_Data_Reg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Gravar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.MaskedTextBox tb_Inicio_Reg;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rb_Compensacao;
        private System.Windows.Forms.RadioButton rb_Hora_Extra;
        private System.Windows.Forms.Label label11;
    }
}