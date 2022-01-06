namespace Visao
{
    partial class UC_CadastroProjeto
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
            this.gpb_cadastroGeral = new System.Windows.Forms.GroupBox();
            this.btn_infoDescriçãoProjeto = new System.Windows.Forms.Button();
            this.btn_info_repositorio = new System.Windows.Forms.Button();
            this.btn_info_tarefa = new System.Windows.Forms.Button();
            this.tbx_descricao = new System.Windows.Forms.TextBox();
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.tbx_repositorio = new System.Windows.Forms.TextBox();
            this.lbl_repositorio = new System.Windows.Forms.Label();
            this.tbx_nomeProjeto = new System.Windows.Forms.TextBox();
            this.lbl_nomeProjeto = new System.Windows.Forms.Label();
            this.pan_formularioGeral = new System.Windows.Forms.Panel();
            this.pan_botton = new System.Windows.Forms.Panel();
            this.btn_gerarScripts = new System.Windows.Forms.Button();
            this.btn_gerar_document = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.pan_tot = new System.Windows.Forms.Panel();
            this.pan_top = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_copiar_nome = new System.Windows.Forms.Button();
            this.btn_copiar_descricao = new System.Windows.Forms.Button();
            this.btn_copiarRepositorio = new System.Windows.Forms.Button();
            this.gpb_cadastroGeral.SuspendLayout();
            this.pan_formularioGeral.SuspendLayout();
            this.pan_botton.SuspendLayout();
            this.pan_tot.SuspendLayout();
            this.pan_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_cadastroGeral
            // 
            this.gpb_cadastroGeral.Controls.Add(this.btn_copiarRepositorio);
            this.gpb_cadastroGeral.Controls.Add(this.btn_copiar_descricao);
            this.gpb_cadastroGeral.Controls.Add(this.btn_copiar_nome);
            this.gpb_cadastroGeral.Controls.Add(this.btn_infoDescriçãoProjeto);
            this.gpb_cadastroGeral.Controls.Add(this.btn_info_repositorio);
            this.gpb_cadastroGeral.Controls.Add(this.btn_info_tarefa);
            this.gpb_cadastroGeral.Controls.Add(this.tbx_descricao);
            this.gpb_cadastroGeral.Controls.Add(this.lbl_descricao);
            this.gpb_cadastroGeral.Controls.Add(this.tbx_repositorio);
            this.gpb_cadastroGeral.Controls.Add(this.lbl_repositorio);
            this.gpb_cadastroGeral.Controls.Add(this.tbx_nomeProjeto);
            this.gpb_cadastroGeral.Controls.Add(this.lbl_nomeProjeto);
            this.gpb_cadastroGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpb_cadastroGeral.Location = new System.Drawing.Point(0, 0);
            this.gpb_cadastroGeral.Name = "gpb_cadastroGeral";
            this.gpb_cadastroGeral.Size = new System.Drawing.Size(740, 542);
            this.gpb_cadastroGeral.TabIndex = 0;
            this.gpb_cadastroGeral.TabStop = false;
            this.gpb_cadastroGeral.Text = "Cadastro de Projeto";
            // 
            // btn_infoDescriçãoProjeto
            // 
            this.btn_infoDescriçãoProjeto.BackgroundImage = global::Pj.Properties.Resources.png_infoProdutoBlack20x20;
            this.btn_infoDescriçãoProjeto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_infoDescriçãoProjeto.Location = new System.Drawing.Point(689, 58);
            this.btn_infoDescriçãoProjeto.Name = "btn_infoDescriçãoProjeto";
            this.btn_infoDescriçãoProjeto.Size = new System.Drawing.Size(20, 20);
            this.btn_infoDescriçãoProjeto.TabIndex = 4;
            this.btn_infoDescriçãoProjeto.UseVisualStyleBackColor = true;
            this.btn_infoDescriçãoProjeto.Click += new System.EventHandler(this.btn_infoDescriçãoProjeto_Click);
            // 
            // btn_info_repositorio
            // 
            this.btn_info_repositorio.BackgroundImage = global::Pj.Properties.Resources.png_infoProdutoBlack20x20;
            this.btn_info_repositorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_repositorio.Location = new System.Drawing.Point(358, 178);
            this.btn_info_repositorio.Name = "btn_info_repositorio";
            this.btn_info_repositorio.Size = new System.Drawing.Size(20, 20);
            this.btn_info_repositorio.TabIndex = 6;
            this.btn_info_repositorio.UseVisualStyleBackColor = true;
            this.btn_info_repositorio.Click += new System.EventHandler(this.btn_info_repositorio_Click);
            // 
            // btn_info_tarefa
            // 
            this.btn_info_tarefa.BackgroundImage = global::Pj.Properties.Resources.png_infoProdutoBlack20x20;
            this.btn_info_tarefa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_tarefa.Location = new System.Drawing.Point(358, 26);
            this.btn_info_tarefa.Name = "btn_info_tarefa";
            this.btn_info_tarefa.Size = new System.Drawing.Size(20, 20);
            this.btn_info_tarefa.TabIndex = 2;
            this.btn_info_tarefa.UseVisualStyleBackColor = true;
            this.btn_info_tarefa.Click += new System.EventHandler(this.btn_info_tarefa_Click);
            // 
            // tbx_descricao
            // 
            this.tbx_descricao.AcceptsTab = true;
            this.tbx_descricao.Location = new System.Drawing.Point(97, 59);
            this.tbx_descricao.MaxLength = 30000;
            this.tbx_descricao.Multiline = true;
            this.tbx_descricao.Name = "tbx_descricao";
            this.tbx_descricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_descricao.Size = new System.Drawing.Size(586, 112);
            this.tbx_descricao.TabIndex = 3;
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.Location = new System.Drawing.Point(6, 62);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(64, 16);
            this.lbl_descricao.TabIndex = 5;
            this.lbl_descricao.Text = "Descrição";
            // 
            // tbx_repositorio
            // 
            this.tbx_repositorio.Location = new System.Drawing.Point(97, 177);
            this.tbx_repositorio.MaxLength = 50;
            this.tbx_repositorio.Name = "tbx_repositorio";
            this.tbx_repositorio.Size = new System.Drawing.Size(255, 23);
            this.tbx_repositorio.TabIndex = 5;
            // 
            // lbl_repositorio
            // 
            this.lbl_repositorio.AutoSize = true;
            this.lbl_repositorio.Location = new System.Drawing.Point(6, 180);
            this.lbl_repositorio.Name = "lbl_repositorio";
            this.lbl_repositorio.Size = new System.Drawing.Size(75, 16);
            this.lbl_repositorio.TabIndex = 5;
            this.lbl_repositorio.Text = "Repositório:";
            // 
            // tbx_nomeProjeto
            // 
            this.tbx_nomeProjeto.Location = new System.Drawing.Point(97, 25);
            this.tbx_nomeProjeto.MaxLength = 50;
            this.tbx_nomeProjeto.Name = "tbx_nomeProjeto";
            this.tbx_nomeProjeto.Size = new System.Drawing.Size(255, 23);
            this.tbx_nomeProjeto.TabIndex = 1;
            // 
            // lbl_nomeProjeto
            // 
            this.lbl_nomeProjeto.AutoSize = true;
            this.lbl_nomeProjeto.Location = new System.Drawing.Point(6, 28);
            this.lbl_nomeProjeto.Name = "lbl_nomeProjeto";
            this.lbl_nomeProjeto.Size = new System.Drawing.Size(48, 16);
            this.lbl_nomeProjeto.TabIndex = 5;
            this.lbl_nomeProjeto.Text = "Projeto";
            // 
            // pan_formularioGeral
            // 
            this.pan_formularioGeral.AllowDrop = true;
            this.pan_formularioGeral.AutoScroll = true;
            this.pan_formularioGeral.Controls.Add(this.gpb_cadastroGeral);
            this.pan_formularioGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_formularioGeral.Location = new System.Drawing.Point(0, 0);
            this.pan_formularioGeral.Name = "pan_formularioGeral";
            this.pan_formularioGeral.Size = new System.Drawing.Size(740, 542);
            this.pan_formularioGeral.TabIndex = 0;
            // 
            // pan_botton
            // 
            this.pan_botton.Controls.Add(this.btn_gerarScripts);
            this.pan_botton.Controls.Add(this.btn_gerar_document);
            this.pan_botton.Controls.Add(this.btn_excluir);
            this.pan_botton.Controls.Add(this.btn_confirmar);
            this.pan_botton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_botton.Location = new System.Drawing.Point(0, 527);
            this.pan_botton.Name = "pan_botton";
            this.pan_botton.Size = new System.Drawing.Size(740, 35);
            this.pan_botton.TabIndex = 5;
            // 
            // btn_gerarScripts
            // 
            this.btn_gerarScripts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_gerarScripts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_gerarScripts.Location = new System.Drawing.Point(102, 3);
            this.btn_gerarScripts.Name = "btn_gerarScripts";
            this.btn_gerarScripts.Size = new System.Drawing.Size(96, 29);
            this.btn_gerarScripts.TabIndex = 9;
            this.btn_gerarScripts.Text = "Gerar Scripts";
            this.btn_gerarScripts.UseVisualStyleBackColor = true;
            this.btn_gerarScripts.Click += new System.EventHandler(this.btn_gerarScripts_Click);
            // 
            // btn_gerar_document
            // 
            this.btn_gerar_document.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_gerar_document.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_gerar_document.Location = new System.Drawing.Point(6, 3);
            this.btn_gerar_document.Name = "btn_gerar_document";
            this.btn_gerar_document.Size = new System.Drawing.Size(90, 29);
            this.btn_gerar_document.TabIndex = 10;
            this.btn_gerar_document.Text = "Gerar DER";
            this.btn_gerar_document.UseVisualStyleBackColor = true;
            this.btn_gerar_document.Click += new System.EventHandler(this.btn_gerar_document_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_excluir.Location = new System.Drawing.Point(581, 3);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 29);
            this.btn_excluir.TabIndex = 8;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_confirmar.Location = new System.Drawing.Point(662, 3);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(75, 29);
            this.btn_confirmar.TabIndex = 7;
            this.btn_confirmar.Text = "Cadastrar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // pan_tot
            // 
            this.pan_tot.AutoScroll = true;
            this.pan_tot.Controls.Add(this.pan_formularioGeral);
            this.pan_tot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_tot.Location = new System.Drawing.Point(0, 20);
            this.pan_tot.Name = "pan_tot";
            this.pan_tot.Size = new System.Drawing.Size(740, 542);
            this.pan_tot.TabIndex = 3;
            // 
            // pan_top
            // 
            this.pan_top.Controls.Add(this.btn_fechar);
            this.pan_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_top.Location = new System.Drawing.Point(0, 0);
            this.pan_top.Name = "pan_top";
            this.pan_top.Size = new System.Drawing.Size(740, 20);
            this.pan_top.TabIndex = 18;
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
            // btn_copiar_nome
            // 
            this.btn_copiar_nome.BackgroundImage = global::Pj.Properties.Resources.check_circle_outline_100px20x20;
            this.btn_copiar_nome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_copiar_nome.Location = new System.Drawing.Point(384, 26);
            this.btn_copiar_nome.Name = "btn_copiar_nome";
            this.btn_copiar_nome.Size = new System.Drawing.Size(20, 20);
            this.btn_copiar_nome.TabIndex = 507;
            this.btn_copiar_nome.UseVisualStyleBackColor = true;
            this.btn_copiar_nome.Click += new System.EventHandler(this.btn_copiar_nome_Click);
            // 
            // btn_copiar_descricao
            // 
            this.btn_copiar_descricao.BackgroundImage = global::Pj.Properties.Resources.check_circle_outline_100px20x20;
            this.btn_copiar_descricao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_copiar_descricao.Location = new System.Drawing.Point(714, 58);
            this.btn_copiar_descricao.Name = "btn_copiar_descricao";
            this.btn_copiar_descricao.Size = new System.Drawing.Size(20, 20);
            this.btn_copiar_descricao.TabIndex = 508;
            this.btn_copiar_descricao.UseVisualStyleBackColor = true;
            this.btn_copiar_descricao.Click += new System.EventHandler(this.btn_copiar_descricao_Click);
            // 
            // btn_copiarRepositorio
            // 
            this.btn_copiarRepositorio.BackgroundImage = global::Pj.Properties.Resources.check_circle_outline_100px20x20;
            this.btn_copiarRepositorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_copiarRepositorio.Location = new System.Drawing.Point(384, 178);
            this.btn_copiarRepositorio.Name = "btn_copiarRepositorio";
            this.btn_copiarRepositorio.Size = new System.Drawing.Size(20, 20);
            this.btn_copiarRepositorio.TabIndex = 509;
            this.btn_copiarRepositorio.UseVisualStyleBackColor = true;
            this.btn_copiarRepositorio.Click += new System.EventHandler(this.btn_copiarRepositorio_Click);
            // 
            // UC_CadastroProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.pan_botton);
            this.Controls.Add(this.pan_tot);
            this.Controls.Add(this.pan_top);
            this.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.Name = "UC_CadastroProjeto";
            this.Size = new System.Drawing.Size(740, 562);
            this.gpb_cadastroGeral.ResumeLayout(false);
            this.gpb_cadastroGeral.PerformLayout();
            this.pan_formularioGeral.ResumeLayout(false);
            this.pan_botton.ResumeLayout(false);
            this.pan_tot.ResumeLayout(false);
            this.pan_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpb_cadastroGeral;
        private System.Windows.Forms.Button btn_info_tarefa;
        private System.Windows.Forms.TextBox tbx_descricao;
        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.TextBox tbx_nomeProjeto;
        private System.Windows.Forms.Label lbl_nomeProjeto;
        private System.Windows.Forms.Panel pan_formularioGeral;
        private System.Windows.Forms.Panel pan_botton;
        private System.Windows.Forms.Button btn_gerar_document;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Panel pan_tot;
        private System.Windows.Forms.Button btn_infoDescriçãoProjeto;
        private System.Windows.Forms.Button btn_gerarScripts;
        private System.Windows.Forms.Button btn_info_repositorio;
        private System.Windows.Forms.TextBox tbx_repositorio;
        private System.Windows.Forms.Label lbl_repositorio;
        private System.Windows.Forms.Panel pan_top;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_copiarRepositorio;
        private System.Windows.Forms.Button btn_copiar_descricao;
        private System.Windows.Forms.Button btn_copiar_nome;
    }
}
