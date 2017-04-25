namespace BancoDeHoras.Views
{
    partial class LoginAdmin
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
            this.btn_Cancel_Adm = new System.Windows.Forms.Button();
            this.btn_Logar_Adm = new System.Windows.Forms.Button();
            this.tb_Senha_AdminDB = new System.Windows.Forms.TextBox();
            this.tb_Admin_DB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_Cancel_Adm);
            this.panel1.Controls.Add(this.btn_Logar_Adm);
            this.panel1.Controls.Add(this.tb_Senha_AdminDB);
            this.panel1.Controls.Add(this.tb_Admin_DB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(33, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 190);
            this.panel1.TabIndex = 2;
            // 
            // btn_Cancel_Adm
            // 
            this.btn_Cancel_Adm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel_Adm.Location = new System.Drawing.Point(36, 148);
            this.btn_Cancel_Adm.Name = "btn_Cancel_Adm";
            this.btn_Cancel_Adm.Size = new System.Drawing.Size(101, 28);
            this.btn_Cancel_Adm.TabIndex = 5;
            this.btn_Cancel_Adm.Text = "Cancelar";
            this.btn_Cancel_Adm.UseVisualStyleBackColor = true;
            // 
            // btn_Logar_Adm
            // 
            this.btn_Logar_Adm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logar_Adm.Location = new System.Drawing.Point(189, 148);
            this.btn_Logar_Adm.Name = "btn_Logar_Adm";
            this.btn_Logar_Adm.Size = new System.Drawing.Size(99, 28);
            this.btn_Logar_Adm.TabIndex = 4;
            this.btn_Logar_Adm.Text = "Logar";
            this.btn_Logar_Adm.UseVisualStyleBackColor = true;
            this.btn_Logar_Adm.Click += new System.EventHandler(this.btn_Logar_Adm_Click);
            // 
            // tb_Senha_AdminDB
            // 
            this.tb_Senha_AdminDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Senha_AdminDB.Location = new System.Drawing.Point(36, 100);
            this.tb_Senha_AdminDB.Name = "tb_Senha_AdminDB";
            this.tb_Senha_AdminDB.PasswordChar = '*';
            this.tb_Senha_AdminDB.Size = new System.Drawing.Size(252, 26);
            this.tb_Senha_AdminDB.TabIndex = 3;
            // 
            // tb_Admin_DB
            // 
            this.tb_Admin_DB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Admin_DB.Location = new System.Drawing.Point(36, 34);
            this.tb_Admin_DB.Name = "tb_Admin_DB";
            this.tb_Admin_DB.Size = new System.Drawing.Size(252, 26);
            this.tb_Admin_DB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Administrador do Banco de Dados";
            // 
            // LoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 275);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "LoginAdmin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Administrador";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Cancel_Adm;
        private System.Windows.Forms.Button btn_Logar_Adm;
        private System.Windows.Forms.TextBox tb_Senha_AdminDB;
        private System.Windows.Forms.TextBox tb_Admin_DB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}