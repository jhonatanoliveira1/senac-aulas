namespace AppTatoo
{
    partial class frm_Tatuagem
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
            this.pnl_Detalhe = new System.Windows.Forms.Panel();
            this.tbox_Nm_Tatuagem = new System.Windows.Forms.TextBox();
            this.tbox_Cod_Tatuagem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl_Lista = new System.Windows.Forms.Panel();
            this.lbox_Tatuagens = new System.Windows.Forms.ListBox();
            this.pnl_Botoes = new System.Windows.Forms.Panel();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.pnl_Titulo = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbox_Cor_Tatuagem = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbox_Tam_Tatuagem = new System.Windows.Forms.ComboBox();
            this.tbox_Cod_Tema = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Tema = new System.Windows.Forms.Button();
            this.lb_Tit_Tema = new System.Windows.Forms.Label();
            this.pnl_Detalhe.SuspendLayout();
            this.pnl_Lista.SuspendLayout();
            this.pnl_Botoes.SuspendLayout();
            this.pnl_Titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Detalhe
            // 
            this.pnl_Detalhe.BackColor = System.Drawing.Color.PapayaWhip;
            this.pnl_Detalhe.Controls.Add(this.lb_Tit_Tema);
            this.pnl_Detalhe.Controls.Add(this.btn_Tema);
            this.pnl_Detalhe.Controls.Add(this.tbox_Cod_Tema);
            this.pnl_Detalhe.Controls.Add(this.label9);
            this.pnl_Detalhe.Controls.Add(this.cbox_Tam_Tatuagem);
            this.pnl_Detalhe.Controls.Add(this.label8);
            this.pnl_Detalhe.Controls.Add(this.label7);
            this.pnl_Detalhe.Controls.Add(this.cbox_Cor_Tatuagem);
            this.pnl_Detalhe.Controls.Add(this.tbox_Nm_Tatuagem);
            this.pnl_Detalhe.Controls.Add(this.tbox_Cod_Tatuagem);
            this.pnl_Detalhe.Controls.Add(this.label6);
            this.pnl_Detalhe.Controls.Add(this.label5);
            this.pnl_Detalhe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Detalhe.Location = new System.Drawing.Point(144, 52);
            this.pnl_Detalhe.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Detalhe.Name = "pnl_Detalhe";
            this.pnl_Detalhe.Size = new System.Drawing.Size(324, 180);
            this.pnl_Detalhe.TabIndex = 7;
            // 
            // tbox_Nm_Tatuagem
            // 
            this.tbox_Nm_Tatuagem.Location = new System.Drawing.Point(72, 28);
            this.tbox_Nm_Tatuagem.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_Nm_Tatuagem.Name = "tbox_Nm_Tatuagem";
            this.tbox_Nm_Tatuagem.Size = new System.Drawing.Size(237, 20);
            this.tbox_Nm_Tatuagem.TabIndex = 5;
            // 
            // tbox_Cod_Tatuagem
            // 
            this.tbox_Cod_Tatuagem.Enabled = false;
            this.tbox_Cod_Tatuagem.Location = new System.Drawing.Point(16, 28);
            this.tbox_Cod_Tatuagem.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_Cod_Tatuagem.Name = "tbox_Cod_Tatuagem";
            this.tbox_Cod_Tatuagem.Size = new System.Drawing.Size(52, 20);
            this.tbox_Cod_Tatuagem.TabIndex = 4;
            this.tbox_Cod_Tatuagem.Tag = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(69, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(14, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Código";
            // 
            // pnl_Lista
            // 
            this.pnl_Lista.Controls.Add(this.lbox_Tatuagens);
            this.pnl_Lista.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Lista.Location = new System.Drawing.Point(0, 52);
            this.pnl_Lista.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Lista.Name = "pnl_Lista";
            this.pnl_Lista.Size = new System.Drawing.Size(144, 180);
            this.pnl_Lista.TabIndex = 6;
            // 
            // lbox_Tatuagens
            // 
            this.lbox_Tatuagens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbox_Tatuagens.FormattingEnabled = true;
            this.lbox_Tatuagens.Location = new System.Drawing.Point(0, 0);
            this.lbox_Tatuagens.Margin = new System.Windows.Forms.Padding(2);
            this.lbox_Tatuagens.Name = "lbox_Tatuagens";
            this.lbox_Tatuagens.Size = new System.Drawing.Size(144, 180);
            this.lbox_Tatuagens.TabIndex = 0;
            this.lbox_Tatuagens.Click += new System.EventHandler(this.lbox_Tatuagens_Click);
            // 
            // pnl_Botoes
            // 
            this.pnl_Botoes.BackColor = System.Drawing.Color.NavajoWhite;
            this.pnl_Botoes.Controls.Add(this.btn_Cancelar);
            this.pnl_Botoes.Controls.Add(this.btn_Confirmar);
            this.pnl_Botoes.Controls.Add(this.btn_Excluir);
            this.pnl_Botoes.Controls.Add(this.btn_Alterar);
            this.pnl_Botoes.Controls.Add(this.btn_Novo);
            this.pnl_Botoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Botoes.Location = new System.Drawing.Point(0, 232);
            this.pnl_Botoes.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Botoes.Name = "pnl_Botoes";
            this.pnl_Botoes.Size = new System.Drawing.Size(468, 40);
            this.pnl_Botoes.TabIndex = 5;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Cancelar.Location = new System.Drawing.Point(384, 9);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(67, 23);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_Confirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirmar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Confirmar.Location = new System.Drawing.Point(305, 9);
            this.btn_Confirmar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(74, 23);
            this.btn_Confirmar.TabIndex = 3;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = false;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_Excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Excluir.Location = new System.Drawing.Point(144, 9);
            this.btn_Excluir.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(62, 23);
            this.btn_Excluir.TabIndex = 2;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = false;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_Alterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alterar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Alterar.Location = new System.Drawing.Point(78, 9);
            this.btn_Alterar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(62, 23);
            this.btn_Alterar.TabIndex = 1;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = false;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Novo
            // 
            this.btn_Novo.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_Novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Novo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Novo.Location = new System.Drawing.Point(12, 9);
            this.btn_Novo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(62, 23);
            this.btn_Novo.TabIndex = 0;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = false;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // pnl_Titulo
            // 
            this.pnl_Titulo.BackColor = System.Drawing.Color.NavajoWhite;
            this.pnl_Titulo.Controls.Add(this.label4);
            this.pnl_Titulo.Controls.Add(this.label3);
            this.pnl_Titulo.Controls.Add(this.label2);
            this.pnl_Titulo.Controls.Add(this.label1);
            this.pnl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Titulo.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Titulo.Name = "pnl_Titulo";
            this.pnl_Titulo.Size = new System.Drawing.Size(468, 52);
            this.pnl_Titulo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSalmon;
            this.label4.Location = new System.Drawing.Point(284, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tatuagem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(233, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tatuagem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(381, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tatuagem";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(320, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tatuagem";
            // 
            // cbox_Cor_Tatuagem
            // 
            this.cbox_Cor_Tatuagem.FormattingEnabled = true;
            this.cbox_Cor_Tatuagem.Items.AddRange(new object[] {
            "SOMBREADO",
            "P&B",
            "AQUARELA"});
            this.cbox_Cor_Tatuagem.Location = new System.Drawing.Point(16, 139);
            this.cbox_Cor_Tatuagem.Name = "cbox_Cor_Tatuagem";
            this.cbox_Cor_Tatuagem.Size = new System.Drawing.Size(134, 21);
            this.cbox_Cor_Tatuagem.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label7.Location = new System.Drawing.Point(214, 123);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tamanho";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label8.Location = new System.Drawing.Point(15, 123);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Cor";
            // 
            // cbox_Tam_Tatuagem
            // 
            this.cbox_Tam_Tatuagem.FormattingEnabled = true;
            this.cbox_Tam_Tatuagem.Items.AddRange(new object[] {
            "Pequena",
            "Média",
            "Grande"});
            this.cbox_Tam_Tatuagem.Location = new System.Drawing.Point(219, 139);
            this.cbox_Tam_Tatuagem.Name = "cbox_Tam_Tatuagem";
            this.cbox_Tam_Tatuagem.Size = new System.Drawing.Size(88, 21);
            this.cbox_Tam_Tatuagem.TabIndex = 10;
            // 
            // tbox_Cod_Tema
            // 
            this.tbox_Cod_Tema.Location = new System.Drawing.Point(17, 84);
            this.tbox_Cod_Tema.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_Cod_Tema.Name = "tbox_Cod_Tema";
            this.tbox_Cod_Tema.Size = new System.Drawing.Size(51, 20);
            this.tbox_Cod_Tema.TabIndex = 12;
            this.tbox_Cod_Tema.Leave += new System.EventHandler(this.tbox_Cod_Tema_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label9.Location = new System.Drawing.Point(14, 68);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Tema";
            // 
            // btn_Tema
            // 
            this.btn_Tema.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_Tema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Tema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tema.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tema.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Tema.Location = new System.Drawing.Point(70, 82);
            this.btn_Tema.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Tema.Name = "btn_Tema";
            this.btn_Tema.Size = new System.Drawing.Size(22, 24);
            this.btn_Tema.TabIndex = 13;
            this.btn_Tema.UseVisualStyleBackColor = false;
            this.btn_Tema.Click += new System.EventHandler(this.btn_Tema_Click);
            // 
            // lb_Tit_Tema
            // 
            this.lb_Tit_Tema.BackColor = System.Drawing.Color.Bisque;
            this.lb_Tit_Tema.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lb_Tit_Tema.Location = new System.Drawing.Point(98, 87);
            this.lb_Tit_Tema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Tit_Tema.Name = "lb_Tit_Tema";
            this.lb_Tit_Tema.Size = new System.Drawing.Size(208, 13);
            this.lb_Tit_Tema.TabIndex = 14;
            // 
            // frm_Tatuagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 272);
            this.Controls.Add(this.pnl_Detalhe);
            this.Controls.Add(this.pnl_Lista);
            this.Controls.Add(this.pnl_Botoes);
            this.Controls.Add(this.pnl_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Tatuagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.pnl_Detalhe.ResumeLayout(false);
            this.pnl_Detalhe.PerformLayout();
            this.pnl_Lista.ResumeLayout(false);
            this.pnl_Botoes.ResumeLayout(false);
            this.pnl_Titulo.ResumeLayout(false);
            this.pnl_Titulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Detalhe;
        private System.Windows.Forms.TextBox tbox_Nm_Tatuagem;
        private System.Windows.Forms.TextBox tbox_Cod_Tatuagem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnl_Lista;
        private System.Windows.Forms.ListBox lbox_Tatuagens;
        private System.Windows.Forms.Panel pnl_Botoes;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Panel pnl_Titulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Tit_Tema;
        private System.Windows.Forms.Button btn_Tema;
        private System.Windows.Forms.TextBox tbox_Cod_Tema;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbox_Tam_Tatuagem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbox_Cor_Tatuagem;
    }
}