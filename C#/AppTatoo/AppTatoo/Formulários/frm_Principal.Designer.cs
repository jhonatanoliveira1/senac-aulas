namespace AppTatoo
{
    partial class frm_Principal
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
            this.components = new System.ComponentModel.Container();
            this.mstrip_Principal = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tatuadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especialidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tatuagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sstrip_Principal = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslabel_DataSys = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslabel_HoraSys = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tim_Principal = new System.Windows.Forms.Timer(this.components);
            this.mstrip_Principal.SuspendLayout();
            this.sstrip_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstrip_Principal
            // 
            this.mstrip_Principal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mstrip_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.agendamentoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.mstrip_Principal.Location = new System.Drawing.Point(0, 0);
            this.mstrip_Principal.Name = "mstrip_Principal";
            this.mstrip_Principal.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mstrip_Principal.Size = new System.Drawing.Size(886, 24);
            this.mstrip_Principal.TabIndex = 0;
            this.mstrip_Principal.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.tatuadorToolStripMenuItem,
            this.tatuagemToolStripMenuItem,
            this.toolStripMenuItem1,
            this.usuárioToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // tatuadorToolStripMenuItem
            // 
            this.tatuadorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.especialidadeToolStripMenuItem,
            this.turnoToolStripMenuItem});
            this.tatuadorToolStripMenuItem.Name = "tatuadorToolStripMenuItem";
            this.tatuadorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tatuadorToolStripMenuItem.Text = "Tatuador";
            this.tatuadorToolStripMenuItem.Click += new System.EventHandler(this.tatuadorToolStripMenuItem_Click);
            // 
            // especialidadeToolStripMenuItem
            // 
            this.especialidadeToolStripMenuItem.Name = "especialidadeToolStripMenuItem";
            this.especialidadeToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.especialidadeToolStripMenuItem.Text = "Especialidade";
            this.especialidadeToolStripMenuItem.Click += new System.EventHandler(this.especialidadeToolStripMenuItem_Click);
            // 
            // turnoToolStripMenuItem
            // 
            this.turnoToolStripMenuItem.Name = "turnoToolStripMenuItem";
            this.turnoToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.turnoToolStripMenuItem.Text = "Turno";
            this.turnoToolStripMenuItem.Click += new System.EventHandler(this.turnoToolStripMenuItem_Click);
            // 
            // tatuagemToolStripMenuItem
            // 
            this.tatuagemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temaToolStripMenuItem});
            this.tatuagemToolStripMenuItem.Name = "tatuagemToolStripMenuItem";
            this.tatuagemToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tatuagemToolStripMenuItem.Text = "Tatuagem";
            this.tatuagemToolStripMenuItem.Click += new System.EventHandler(this.tatuagemToolStripMenuItem_Click);
            // 
            // temaToolStripMenuItem
            // 
            this.temaToolStripMenuItem.Name = "temaToolStripMenuItem";
            this.temaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.temaToolStripMenuItem.Text = "Tema";
            this.temaToolStripMenuItem.Click += new System.EventHandler(this.temaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            // 
            // agendamentoToolStripMenuItem
            // 
            this.agendamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendaToolStripMenuItem});
            this.agendamentoToolStripMenuItem.Name = "agendamentoToolStripMenuItem";
            this.agendamentoToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.agendamentoToolStripMenuItem.Text = "Agendamento";
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.agendaToolStripMenuItem.Text = "Agenda";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // sstrip_Principal
            // 
            this.sstrip_Principal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sstrip_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsslabel_DataSys,
            this.toolStripStatusLabel2,
            this.tsslabel_HoraSys,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6});
            this.sstrip_Principal.Location = new System.Drawing.Point(0, 151);
            this.sstrip_Principal.Name = "sstrip_Principal";
            this.sstrip_Principal.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.sstrip_Principal.Size = new System.Drawing.Size(886, 25);
            this.sstrip_Principal.TabIndex = 1;
            this.sstrip_Principal.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(37, 20);
            this.toolStripStatusLabel1.Text = "Data: ";
            // 
            // tsslabel_DataSys
            // 
            this.tsslabel_DataSys.AutoSize = false;
            this.tsslabel_DataSys.ForeColor = System.Drawing.Color.Maroon;
            this.tsslabel_DataSys.Name = "tsslabel_DataSys";
            this.tsslabel_DataSys.Size = new System.Drawing.Size(90, 20);
            this.tsslabel_DataSys.Text = "99/99/9999";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(39, 20);
            this.toolStripStatusLabel2.Text = "Hora: ";
            // 
            // tsslabel_HoraSys
            // 
            this.tsslabel_HoraSys.AutoSize = false;
            this.tsslabel_HoraSys.ForeColor = System.Drawing.Color.Maroon;
            this.tsslabel_HoraSys.Name = "tsslabel_HoraSys";
            this.tsslabel_HoraSys.Size = new System.Drawing.Size(80, 20);
            this.tsslabel_HoraSys.Text = "99:99:99";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.AutoSize = false;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(251, 20);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(204, 20);
            this.toolStripStatusLabel4.Text = "AppTatoo - Sistema de agendamento";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.AutoSize = false;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(51, 20);
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(122, 15);
            this.toolStripStatusLabel6.Text = "by Mfacine (Monstro)";
            // 
            // tim_Principal
            // 
            this.tim_Principal.Enabled = true;
            this.tim_Principal.Tick += new System.EventHandler(this.tim_Principal_Tick);
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 176);
            this.Controls.Add(this.sstrip_Principal);
            this.Controls.Add(this.mstrip_Principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.mstrip_Principal;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mstrip_Principal.ResumeLayout(false);
            this.mstrip_Principal.PerformLayout();
            this.sstrip_Principal.ResumeLayout(false);
            this.sstrip_Principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstrip_Principal;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tatuadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especialidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tatuagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.StatusStrip sstrip_Principal;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslabel_DataSys;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tsslabel_HoraSys;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.Timer tim_Principal;
    }
}

