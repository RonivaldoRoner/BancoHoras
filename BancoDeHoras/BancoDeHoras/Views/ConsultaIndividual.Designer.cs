namespace BancoDeHoras.Views
{
    partial class ConsultaIndividual
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.tb_CPF_Func = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_Nome_Emp = new System.Windows.Forms.TextBox();
            this.tb_CNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lv_Cons_Individual = new System.Windows.Forms.ListView();
            this.col_Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Tipo_Reg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Reg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Saldo_Horas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Saldo_Dias = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Detalhes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_TotalDias = new System.Windows.Forms.Label();
            this.lb_TotalHoras = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_Data_Filtro_Inicio = new System.Windows.Forms.MaskedTextBox();
            this.tb_Data_Filtro_Final = new System.Windows.Forms.MaskedTextBox();
            this.btn_Filtra_Data = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.tb_CPF_Func);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.tb_Nome);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(12, 77);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(2);
            this.panel5.Size = new System.Drawing.Size(684, 55);
            this.panel5.TabIndex = 21;
            // 
            // tb_CPF_Func
            // 
            this.tb_CPF_Func.Enabled = false;
            this.tb_CPF_Func.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_CPF_Func.Location = new System.Drawing.Point(505, 22);
            this.tb_CPF_Func.Mask = "000,000,000-00";
            this.tb_CPF_Func.Name = "tb_CPF_Func";
            this.tb_CPF_Func.Size = new System.Drawing.Size(136, 26);
            this.tb_CPF_Func.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(505, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "CPF:";
            // 
            // tb_Nome
            // 
            this.tb_Nome.Enabled = false;
            this.tb_Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Nome.Location = new System.Drawing.Point(20, 22);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(385, 26);
            this.tb_Nome.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nome:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tb_Nome_Emp);
            this.panel1.Controls.Add(this.tb_CNPJ);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 59);
            this.panel1.TabIndex = 20;
            // 
            // tb_Nome_Emp
            // 
            this.tb_Nome_Emp.Enabled = false;
            this.tb_Nome_Emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Nome_Emp.Location = new System.Drawing.Point(20, 27);
            this.tb_Nome_Emp.Name = "tb_Nome_Emp";
            this.tb_Nome_Emp.Size = new System.Drawing.Size(365, 26);
            this.tb_Nome_Emp.TabIndex = 12;
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(468, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "CNPJ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(18, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Empresa:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BancoDeHoras.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(560, 558);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 50);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btn_Filtra_Data);
            this.panel2.Controls.Add(this.tb_Data_Filtro_Final);
            this.panel2.Controls.Add(this.tb_Data_Filtro_Inicio);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lv_Cons_Individual);
            this.panel2.Location = new System.Drawing.Point(12, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 385);
            this.panel2.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(277, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Final:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Inicial:";
            // 
            // lv_Cons_Individual
            // 
            this.lv_Cons_Individual.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_Data,
            this.col_Tipo_Reg,
            this.col_Reg,
            this.col_Saldo_Horas,
            this.col_Saldo_Dias,
            this.col_Detalhes});
            this.lv_Cons_Individual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Cons_Individual.GridLines = true;
            this.lv_Cons_Individual.Location = new System.Drawing.Point(3, 64);
            this.lv_Cons_Individual.Name = "lv_Cons_Individual";
            this.lv_Cons_Individual.Size = new System.Drawing.Size(672, 314);
            this.lv_Cons_Individual.TabIndex = 0;
            this.lv_Cons_Individual.UseCompatibleStateImageBehavior = false;
            this.lv_Cons_Individual.View = System.Windows.Forms.View.Details;
            // 
            // col_Data
            // 
            this.col_Data.Text = "Data";
            this.col_Data.Width = 122;
            // 
            // col_Tipo_Reg
            // 
            this.col_Tipo_Reg.Text = "Tipo";
            this.col_Tipo_Reg.Width = 153;
            // 
            // col_Reg
            // 
            this.col_Reg.Text = "Registro";
            this.col_Reg.Width = 92;
            // 
            // col_Saldo_Horas
            // 
            this.col_Saldo_Horas.Text = "Saldo Horas";
            this.col_Saldo_Horas.Width = 102;
            // 
            // col_Saldo_Dias
            // 
            this.col_Saldo_Dias.Text = "Saldo Dias";
            this.col_Saldo_Dias.Width = 90;
            // 
            // col_Detalhes
            // 
            this.col_Detalhes.Text = "Detalhes";
            this.col_Detalhes.Width = 107;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(404, 538);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Total Dias:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(529, 538);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Total Horas:";
            // 
            // lb_TotalDias
            // 
            this.lb_TotalDias.AutoSize = true;
            this.lb_TotalDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TotalDias.Location = new System.Drawing.Point(494, 538);
            this.lb_TotalDias.Name = "lb_TotalDias";
            this.lb_TotalDias.Size = new System.Drawing.Size(0, 20);
            this.lb_TotalDias.TabIndex = 26;
            // 
            // lb_TotalHoras
            // 
            this.lb_TotalHoras.AutoSize = true;
            this.lb_TotalHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TotalHoras.Location = new System.Drawing.Point(630, 538);
            this.lb_TotalHoras.Name = "lb_TotalHoras";
            this.lb_TotalHoras.Size = new System.Drawing.Size(0, 20);
            this.lb_TotalHoras.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(297, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Filtrar por Data";
            // 
            // tb_Data_Filtro_Inicio
            // 
            this.tb_Data_Filtro_Inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Data_Filtro_Inicio.Location = new System.Drawing.Point(82, 32);
            this.tb_Data_Filtro_Inicio.Mask = "00/00/0000";
            this.tb_Data_Filtro_Inicio.Name = "tb_Data_Filtro_Inicio";
            this.tb_Data_Filtro_Inicio.Size = new System.Drawing.Size(94, 26);
            this.tb_Data_Filtro_Inicio.TabIndex = 11;
            // 
            // tb_Data_Filtro_Final
            // 
            this.tb_Data_Filtro_Final.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Data_Filtro_Final.Location = new System.Drawing.Point(330, 32);
            this.tb_Data_Filtro_Final.Mask = "00/00/0000";
            this.tb_Data_Filtro_Final.Name = "tb_Data_Filtro_Final";
            this.tb_Data_Filtro_Final.Size = new System.Drawing.Size(94, 26);
            this.tb_Data_Filtro_Final.TabIndex = 12;
            // 
            // btn_Filtra_Data
            // 
            this.btn_Filtra_Data.Location = new System.Drawing.Point(566, 35);
            this.btn_Filtra_Data.Name = "btn_Filtra_Data";
            this.btn_Filtra_Data.Size = new System.Drawing.Size(75, 23);
            this.btn_Filtra_Data.TabIndex = 13;
            this.btn_Filtra_Data.Text = "Filtrar";
            this.btn_Filtra_Data.UseVisualStyleBackColor = true;
            this.btn_Filtra_Data.Click += new System.EventHandler(this.btn_Filtra_Data_Click);
            // 
            // ConsultaIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 616);
            this.Controls.Add(this.lb_TotalHoras);
            this.Controls.Add(this.lb_TotalDias);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultaIndividual";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco de Horas / Consulta Individual";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.MaskedTextBox tb_CPF_Func;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_Nome_Emp;
        private System.Windows.Forms.MaskedTextBox tb_CNPJ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lv_Cons_Individual;
        private System.Windows.Forms.ColumnHeader col_Data;
        private System.Windows.Forms.ColumnHeader col_Tipo_Reg;
        private System.Windows.Forms.ColumnHeader col_Reg;
        private System.Windows.Forms.ColumnHeader col_Saldo_Horas;
        private System.Windows.Forms.ColumnHeader col_Saldo_Dias;
        private System.Windows.Forms.ColumnHeader col_Detalhes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_TotalDias;
        private System.Windows.Forms.Label lb_TotalHoras;
        private System.Windows.Forms.Button btn_Filtra_Data;
        private System.Windows.Forms.MaskedTextBox tb_Data_Filtro_Final;
        private System.Windows.Forms.MaskedTextBox tb_Data_Filtro_Inicio;
        private System.Windows.Forms.Label label9;
    }
}