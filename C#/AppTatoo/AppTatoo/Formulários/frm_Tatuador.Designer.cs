namespace AppTatoo
{
    partial class frm_Tatuador
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
            this.tbox_Cod_Especialidade = new System.Windows.Forms.TextBox();
            this.tbox_Cod_Tatuador = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl_Lista = new System.Windows.Forms.Panel();
            this.lbox_Tatuadores = new System.Windows.Forms.ListBox();
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
            this.tbox_Nm_Tatuador = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbox_Cod_Turno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbox_Cel_Tatuador = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Especialidade = new System.Windows.Forms.Button();
            this.btn_Turno = new System.Windows.Forms.Button();
            this.lb_Tit_Especialidade = new System.Windows.Forms.Label();
            this.lb_Amostra_Turno = new System.Windows.Forms.Label();
            this.pnl_Detalhe.SuspendLayout();
            this.pnl_Lista.SuspendLayout();
            this.pnl_Botoes.SuspendLayout();
            this.pnl_Titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Detalhe
            // 
            this.pnl_Detalhe.BackColor = System.Drawing.Color.PapayaWhip;
            this.pnl_Detalhe.Controls.Add(this.lb_Amostra_Turno);
            this.pnl_Detalhe.Controls.Add(this.lb_Tit_Especialidade);
            this.pnl_Detalhe.Controls.Add(this.btn_Turno);
            this.pnl_Detalhe.Controls.Add(this.btn_Especialidade);
            this.pnl_Detalhe.Controls.Add(this.tbox_Cel_Tatuador);
            this.pnl_Detalhe.Controls.Add(this.label10);
            this.pnl_Detalhe.Controls.Add(this.tbox_Cod_Turno);
            this.pnl_Detalhe.Controls.Add(this.label9);
            this.pnl_Detalhe.Controls.Add(this.tbox_Nm_Tatuador);
            this.pnl_Detalhe.Controls.Add(this.label8);
            this.pnl_Detalhe.Controls.Add(this.tbox_Cod_Especialidade);
            this.pnl_Detalhe.Controls.Add(this.tbox_Cod_Tatuador);
            this.pnl_Detalhe.Controls.Add(this.label6);
            this.pnl_Detalhe.Controls.Add(this.label5);
            this.pnl_Detalhe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Detalhe.Location = new System.Drawing.Point(144, 52);
            this.pnl_Detalhe.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Detalhe.Name = "pnl_Detalhe";
            this.pnl_Detalhe.Size = new System.Drawing.Size(332, 200);
            this.pnl_Detalhe.TabIndex = 11;
            // 
            // tbox_Cod_Especialidade
            // 
            this.tbox_Cod_Especialidade.Location = new System.Drawing.Point(16, 119);
            this.tbox_Cod_Especialidade.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_Cod_Especialidade.Name = "tbox_Cod_Especialidade";
            this.tbox_Cod_Especialidade.Size = new System.Drawing.Size(51, 20);
            this.tbox_Cod_Especialidade.TabIndex = 5;
            this.tbox_Cod_Especialidade.Leave += new System.EventHandler(this.tbox_Cod_Especialidade_Leave);
            // 
            // tbox_Cod_Tatuador
            // 
            this.tbox_Cod_Tatuador.Enabled = false;
            this.tbox_Cod_Tatuador.Location = new System.Drawing.Point(16, 28);
            this.tbox_Cod_Tatuador.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_Cod_Tatuador.Name = "tbox_Cod_Tatuador";
            this.tbox_Cod_Tatuador.Size = new System.Drawing.Size(52, 20);
            this.tbox_Cod_Tatuador.TabIndex = 4;
            this.tbox_Cod_Tatuador.Tag = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(14, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Especialidade";
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
            this.pnl_Lista.Controls.Add(this.lbox_Tatuadores);
            this.pnl_Lista.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Lista.Location = new System.Drawing.Point(0, 52);
            this.pnl_Lista.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Lista.Name = "pnl_Lista";
            this.pnl_Lista.Size = new System.Drawing.Size(144, 200);
            this.pnl_Lista.TabIndex = 10;
            // 
            // lbox_Tatuadores
            // 
            this.lbox_Tatuadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbox_Tatuadores.FormattingEnabled = true;
            this.lbox_Tatuadores.Location = new System.Drawing.Point(0, 0);
            this.lbox_Tatuadores.Margin = new System.Windows.Forms.Padding(2);
            this.lbox_Tatuadores.Name = "lbox_Tatuadores";
            this.lbox_Tatuadores.Size = new System.Drawing.Size(144, 200);
            this.lbox_Tatuadores.TabIndex = 0;
            this.lbox_Tatuadores.Click += new System.EventHandler(this.lbox_Tatuadores_Click);
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
            this.pnl_Botoes.Location = new System.Drawing.Point(0, 252);
            this.pnl_Botoes.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Botoes.Name = "pnl_Botoes";
            this.pnl_Botoes.Size = new System.Drawing.Size(476, 40);
            this.pnl_Botoes.TabIndex = 9;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Cancelar.Location = new System.Drawing.Point(397, 9);
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
            this.btn_Confirmar.Location = new System.Drawing.Point(318, 9);
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
            this.btn_Excluir.Location = new System.Drawing.Point(137, 9);
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
            this.btn_Alterar.Location = new System.Drawing.Point(71, 9);
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
            this.btn_Novo.Location = new System.Drawing.Point(5, 9);
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
            this.pnl_Titulo.Size = new System.Drawing.Size(476, 52);
            this.pnl_Titulo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightSalmon;
            this.label4.Location = new System.Drawing.Point(323, 1);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tatuador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(296, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tatuador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(394, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tatuador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(352, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tatuador";
            // 
            // tbox_Nm_Tatuador
            // 
            this.tbox_Nm_Tatuador.Location = new System.Drawing.Point(17, 73);
            this.tbox_Nm_Tatuador.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_Nm_Tatuador.Name = "tbox_Nm_Tatuador";
            this.tbox_Nm_Tatuador.Size = new System.Drawing.Size(186, 20);
            this.tbox_Nm_Tatuador.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label8.Location = new System.Drawing.Point(15, 57);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nome";
            // 
            // tbox_Cod_Turno
            // 
            this.tbox_Cod_Turno.Location = new System.Drawing.Point(17, 160);
            this.tbox_Cod_Turno.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_Cod_Turno.Name = "tbox_Cod_Turno";
            this.tbox_Cod_Turno.Size = new System.Drawing.Size(50, 20);
            this.tbox_Cod_Turno.TabIndex = 10;
            this.tbox_Cod_Turno.Leave += new System.EventHandler(this.tbox_Cod_Turno_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label9.Location = new System.Drawing.Point(13, 145);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Turno";
            // 
            // tbox_Cel_Tatuador
            // 
            this.tbox_Cel_Tatuador.Location = new System.Drawing.Point(207, 73);
            this.tbox_Cel_Tatuador.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_Cel_Tatuador.Name = "tbox_Cel_Tatuador";
            this.tbox_Cel_Tatuador.Size = new System.Drawing.Size(109, 20);
            this.tbox_Cel_Tatuador.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label10.Location = new System.Drawing.Point(204, 57);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Celular";
            // 
            // btn_Especialidade
            // 
            this.btn_Especialidade.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_Especialidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Especialidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Especialidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Especialidade.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Especialidade.Location = new System.Drawing.Point(71, 118);
            this.btn_Especialidade.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Especialidade.Name = "btn_Especialidade";
            this.btn_Especialidade.Size = new System.Drawing.Size(28, 23);
            this.btn_Especialidade.TabIndex = 13;
            this.btn_Especialidade.UseVisualStyleBackColor = false;
            // 
            // btn_Turno
            // 
            this.btn_Turno.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_Turno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Turno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Turno.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Turno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Turno.Location = new System.Drawing.Point(71, 158);
            this.btn_Turno.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Turno.Name = "btn_Turno";
            this.btn_Turno.Size = new System.Drawing.Size(28, 23);
            this.btn_Turno.TabIndex = 14;
            this.btn_Turno.UseVisualStyleBackColor = false;
            // 
            // lb_Tit_Especialidade
            // 
            this.lb_Tit_Especialidade.BackColor = System.Drawing.Color.NavajoWhite;
            this.lb_Tit_Especialidade.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lb_Tit_Especialidade.Location = new System.Drawing.Point(103, 123);
            this.lb_Tit_Especialidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Tit_Especialidade.Name = "lb_Tit_Especialidade";
            this.lb_Tit_Especialidade.Size = new System.Drawing.Size(213, 13);
            this.lb_Tit_Especialidade.TabIndex = 15;
            this.lb_Tit_Especialidade.Text = "Nome";
            // 
            // lb_Amostra_Turno
            // 
            this.lb_Amostra_Turno.BackColor = System.Drawing.Color.NavajoWhite;
            this.lb_Amostra_Turno.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lb_Amostra_Turno.Location = new System.Drawing.Point(103, 163);
            this.lb_Amostra_Turno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Amostra_Turno.Name = "lb_Amostra_Turno";
            this.lb_Amostra_Turno.Size = new System.Drawing.Size(213, 13);
            this.lb_Amostra_Turno.TabIndex = 16;
            this.lb_Amostra_Turno.Text = "Nome";
            // 
            // frm_Tatuador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 292);
            this.Controls.Add(this.pnl_Detalhe);
            this.Controls.Add(this.pnl_Lista);
            this.Controls.Add(this.pnl_Botoes);
            this.Controls.Add(this.pnl_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Tatuador";
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
        private System.Windows.Forms.Label lb_Amostra_Turno;
        private System.Windows.Forms.Label lb_Tit_Especialidade;
        private System.Windows.Forms.Button btn_Turno;
        private System.Windows.Forms.Button btn_Especialidade;
        private System.Windows.Forms.TextBox tbox_Cel_Tatuador;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbox_Cod_Turno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbox_Nm_Tatuador;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbox_Cod_Especialidade;
        private System.Windows.Forms.TextBox tbox_Cod_Tatuador;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnl_Lista;
        private System.Windows.Forms.ListBox lbox_Tatuadores;
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
    }
}