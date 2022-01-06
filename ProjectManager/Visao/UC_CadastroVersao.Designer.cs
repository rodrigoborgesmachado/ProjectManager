namespace Visao
{
    partial class UC_CadastroVersao
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CadastroVersao));
            this.pan_tot = new System.Windows.Forms.Panel();
            this.pan_formularioGeral = new System.Windows.Forms.Panel();
            this.gpb_cadastroGeral = new System.Windows.Forms.GroupBox();
            this.btn_info_instalador = new System.Windows.Forms.Button();
            this.btn_infoDestino = new System.Windows.Forms.Button();
            this.btn_origem = new System.Windows.Forms.Button();
            this.btn_info_tarefa = new System.Windows.Forms.Button();
            this.tbx_destinoArquivo = new System.Windows.Forms.TextBox();
            this.lbl_destino = new System.Windows.Forms.Label();
            this.tbx_origemArquivo = new System.Windows.Forms.TextBox();
            this.lbl_instalador = new System.Windows.Forms.Label();
            this.tbx_versao = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.pan_botton = new System.Windows.Forms.Panel();
            this.pan_top = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_copiar_notas = new System.Windows.Forms.Button();
            this.btn_copiar_origem = new System.Windows.Forms.Button();
            this.btn_copiar_destino = new System.Windows.Forms.Button();
            this.pan_tot.SuspendLayout();
            this.pan_formularioGeral.SuspendLayout();
            this.gpb_cadastroGeral.SuspendLayout();
            this.pan_botton.SuspendLayout();
            this.pan_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_tot
            // 
            this.pan_tot.AutoScroll = true;
            this.pan_tot.Controls.Add(this.pan_formularioGeral);
            this.pan_tot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_tot.Location = new System.Drawing.Point(0, 20);
            this.pan_tot.Name = "pan_tot";
            this.pan_tot.Size = new System.Drawing.Size(740, 507);
            this.pan_tot.TabIndex = 19;
            // 
            // pan_formularioGeral
            // 
            this.pan_formularioGeral.AllowDrop = true;
            this.pan_formularioGeral.AutoScroll = true;
            this.pan_formularioGeral.Controls.Add(this.gpb_cadastroGeral);
            this.pan_formularioGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_formularioGeral.Location = new System.Drawing.Point(0, 0);
            this.pan_formularioGeral.Name = "pan_formularioGeral";
            this.pan_formularioGeral.Size = new System.Drawing.Size(740, 507);
            this.pan_formularioGeral.TabIndex = 0;
            // 
            // gpb_cadastroGeral
            // 
            this.gpb_cadastroGeral.Controls.Add(this.btn_copiar_destino);
            this.gpb_cadastroGeral.Controls.Add(this.btn_copiar_origem);
            this.gpb_cadastroGeral.Controls.Add(this.btn_copiar_notas);
            this.gpb_cadastroGeral.Controls.Add(this.btn_info_instalador);
            this.gpb_cadastroGeral.Controls.Add(this.btn_infoDestino);
            this.gpb_cadastroGeral.Controls.Add(this.btn_origem);
            this.gpb_cadastroGeral.Controls.Add(this.btn_info_tarefa);
            this.gpb_cadastroGeral.Controls.Add(this.tbx_destinoArquivo);
            this.gpb_cadastroGeral.Controls.Add(this.lbl_destino);
            this.gpb_cadastroGeral.Controls.Add(this.tbx_origemArquivo);
            this.gpb_cadastroGeral.Controls.Add(this.lbl_instalador);
            this.gpb_cadastroGeral.Controls.Add(this.tbx_versao);
            this.gpb_cadastroGeral.Controls.Add(this.lbl_nome);
            this.gpb_cadastroGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpb_cadastroGeral.Location = new System.Drawing.Point(0, 0);
            this.gpb_cadastroGeral.Name = "gpb_cadastroGeral";
            this.gpb_cadastroGeral.Size = new System.Drawing.Size(740, 507);
            this.gpb_cadastroGeral.TabIndex = 0;
            this.gpb_cadastroGeral.TabStop = false;
            this.gpb_cadastroGeral.Text = "Cadastro de Versão";
            // 
            // btn_info_instalador
            // 
            this.btn_info_instalador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_info_instalador.BackgroundImage")));
            this.btn_info_instalador.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_instalador.Location = new System.Drawing.Point(689, 60);
            this.btn_info_instalador.Name = "btn_info_instalador";
            this.btn_info_instalador.Size = new System.Drawing.Size(20, 20);
            this.btn_info_instalador.TabIndex = 5;
            this.btn_info_instalador.UseVisualStyleBackColor = true;
            this.btn_info_instalador.Click += new System.EventHandler(this.btn_infoOrigem_Click);
            // 
            // btn_infoDestino
            // 
            this.btn_infoDestino.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_infoDestino.BackgroundImage")));
            this.btn_infoDestino.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_infoDestino.Location = new System.Drawing.Point(646, 88);
            this.btn_infoDestino.Name = "btn_infoDestino";
            this.btn_infoDestino.Size = new System.Drawing.Size(20, 20);
            this.btn_infoDestino.TabIndex = 7;
            this.btn_infoDestino.UseVisualStyleBackColor = true;
            this.btn_infoDestino.Click += new System.EventHandler(this.btn_infoDestino_Click);
            // 
            // btn_origem
            // 
            this.btn_origem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_origem.Location = new System.Drawing.Point(646, 59);
            this.btn_origem.Name = "btn_origem";
            this.btn_origem.Size = new System.Drawing.Size(37, 23);
            this.btn_origem.TabIndex = 4;
            this.btn_origem.Text = "File";
            this.btn_origem.UseVisualStyleBackColor = true;
            this.btn_origem.Click += new System.EventHandler(this.btn_origem_Click);
            // 
            // btn_info_tarefa
            // 
            this.btn_info_tarefa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_info_tarefa.BackgroundImage")));
            this.btn_info_tarefa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_tarefa.Location = new System.Drawing.Point(358, 26);
            this.btn_info_tarefa.Name = "btn_info_tarefa";
            this.btn_info_tarefa.Size = new System.Drawing.Size(20, 20);
            this.btn_info_tarefa.TabIndex = 2;
            this.btn_info_tarefa.UseVisualStyleBackColor = true;
            this.btn_info_tarefa.Click += new System.EventHandler(this.btn_info_versao_Click);
            // 
            // tbx_destinoArquivo
            // 
            this.tbx_destinoArquivo.AcceptsTab = true;
            this.tbx_destinoArquivo.Enabled = false;
            this.tbx_destinoArquivo.Location = new System.Drawing.Point(97, 88);
            this.tbx_destinoArquivo.MaxLength = 30000;
            this.tbx_destinoArquivo.Name = "tbx_destinoArquivo";
            this.tbx_destinoArquivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_destinoArquivo.Size = new System.Drawing.Size(543, 23);
            this.tbx_destinoArquivo.TabIndex = 6;
            this.tbx_destinoArquivo.Text = "Instaladores/Sunsale/Instaladores/";
            // 
            // lbl_destino
            // 
            this.lbl_destino.AutoSize = true;
            this.lbl_destino.Location = new System.Drawing.Point(6, 91);
            this.lbl_destino.Name = "lbl_destino";
            this.lbl_destino.Size = new System.Drawing.Size(51, 16);
            this.lbl_destino.TabIndex = 5;
            this.lbl_destino.Text = "Destino";
            // 
            // tbx_origemArquivo
            // 
            this.tbx_origemArquivo.AcceptsTab = true;
            this.tbx_origemArquivo.Location = new System.Drawing.Point(97, 59);
            this.tbx_origemArquivo.MaxLength = 30000;
            this.tbx_origemArquivo.Name = "tbx_origemArquivo";
            this.tbx_origemArquivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_origemArquivo.Size = new System.Drawing.Size(543, 23);
            this.tbx_origemArquivo.TabIndex = 3;
            // 
            // lbl_instalador
            // 
            this.lbl_instalador.AutoSize = true;
            this.lbl_instalador.Location = new System.Drawing.Point(6, 62);
            this.lbl_instalador.Name = "lbl_instalador";
            this.lbl_instalador.Size = new System.Drawing.Size(64, 16);
            this.lbl_instalador.TabIndex = 5;
            this.lbl_instalador.Text = "Instalador";
            // 
            // tbx_versao
            // 
            this.tbx_versao.Location = new System.Drawing.Point(97, 25);
            this.tbx_versao.MaxLength = 50;
            this.tbx_versao.Name = "tbx_versao";
            this.tbx_versao.Size = new System.Drawing.Size(255, 23);
            this.tbx_versao.TabIndex = 1;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(6, 28);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(45, 16);
            this.lbl_nome.TabIndex = 5;
            this.lbl_nome.Text = "Versao";
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_confirmar.Location = new System.Drawing.Point(662, 3);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(75, 29);
            this.btn_confirmar.TabIndex = 8;
            this.btn_confirmar.Text = "Cadastrar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // pan_botton
            // 
            this.pan_botton.Controls.Add(this.btn_confirmar);
            this.pan_botton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_botton.Location = new System.Drawing.Point(0, 527);
            this.pan_botton.Name = "pan_botton";
            this.pan_botton.Size = new System.Drawing.Size(740, 35);
            this.pan_botton.TabIndex = 20;
            // 
            // pan_top
            // 
            this.pan_top.Controls.Add(this.btn_fechar);
            this.pan_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_top.Location = new System.Drawing.Point(0, 0);
            this.pan_top.Name = "pan_top";
            this.pan_top.Size = new System.Drawing.Size(740, 20);
            this.pan_top.TabIndex = 21;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fechar.BackColor = System.Drawing.Color.Red;
            this.btn_fechar.BackgroundImage = global::Pj.Properties.Resources.window_close_100px20x20;
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_fechar.Location = new System.Drawing.Point(720, 0);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(20, 20);
            this.btn_fechar.TabIndex = 17;
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_copiar_notas
            // 
            this.btn_copiar_notas.BackgroundImage = global::Pj.Properties.Resources.check_circle_outline_100px20x20;
            this.btn_copiar_notas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_copiar_notas.Location = new System.Drawing.Point(384, 26);
            this.btn_copiar_notas.Name = "btn_copiar_notas";
            this.btn_copiar_notas.Size = new System.Drawing.Size(20, 20);
            this.btn_copiar_notas.TabIndex = 512;
            this.btn_copiar_notas.UseVisualStyleBackColor = true;
            this.btn_copiar_notas.Click += new System.EventHandler(this.btn_copiar_notas_Click);
            // 
            // btn_copiar_origem
            // 
            this.btn_copiar_origem.BackgroundImage = global::Pj.Properties.Resources.check_circle_outline_100px20x20;
            this.btn_copiar_origem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_copiar_origem.Location = new System.Drawing.Point(715, 60);
            this.btn_copiar_origem.Name = "btn_copiar_origem";
            this.btn_copiar_origem.Size = new System.Drawing.Size(20, 20);
            this.btn_copiar_origem.TabIndex = 513;
            this.btn_copiar_origem.UseVisualStyleBackColor = true;
            this.btn_copiar_origem.Click += new System.EventHandler(this.btn_copiar_origem_Click);
            // 
            // btn_copiar_destino
            // 
            this.btn_copiar_destino.BackgroundImage = global::Pj.Properties.Resources.check_circle_outline_100px20x20;
            this.btn_copiar_destino.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_copiar_destino.Location = new System.Drawing.Point(672, 88);
            this.btn_copiar_destino.Name = "btn_copiar_destino";
            this.btn_copiar_destino.Size = new System.Drawing.Size(20, 20);
            this.btn_copiar_destino.TabIndex = 514;
            this.btn_copiar_destino.UseVisualStyleBackColor = true;
            this.btn_copiar_destino.Click += new System.EventHandler(this.btn_copiar_destino_Click);
            // 
            // UC_CadastroVersao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.pan_tot);
            this.Controls.Add(this.pan_botton);
            this.Controls.Add(this.pan_top);
            this.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.Name = "UC_CadastroVersao";
            this.Size = new System.Drawing.Size(740, 562);
            this.pan_tot.ResumeLayout(false);
            this.pan_formularioGeral.ResumeLayout(false);
            this.gpb_cadastroGeral.ResumeLayout(false);
            this.gpb_cadastroGeral.PerformLayout();
            this.pan_botton.ResumeLayout(false);
            this.pan_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Panel pan_tot;
        private System.Windows.Forms.Panel pan_formularioGeral;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Panel pan_botton;
        private System.Windows.Forms.Panel pan_top;
        private System.Windows.Forms.GroupBox gpb_cadastroGeral;
        private System.Windows.Forms.Button btn_origem;
        private System.Windows.Forms.Button btn_info_tarefa;
        private System.Windows.Forms.TextBox tbx_origemArquivo;
        private System.Windows.Forms.Label lbl_instalador;
        private System.Windows.Forms.TextBox tbx_versao;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Button btn_info_instalador;
        private System.Windows.Forms.Button btn_infoDestino;
        private System.Windows.Forms.TextBox tbx_destinoArquivo;
        private System.Windows.Forms.Label lbl_destino;
        private System.Windows.Forms.Button btn_copiar_destino;
        private System.Windows.Forms.Button btn_copiar_origem;
        private System.Windows.Forms.Button btn_copiar_notas;
    }
}
