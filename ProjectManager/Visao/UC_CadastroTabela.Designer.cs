namespace Visao
{
    partial class UC_CadastroTabela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CadastroTabela));
            this.gpb_cadastroGeral = new System.Windows.Forms.GroupBox();
            this.btn_infoNotas = new System.Windows.Forms.Button();
            this.btn_infoDescriçãoProjeto = new System.Windows.Forms.Button();
            this.btn_info_tarefa = new System.Windows.Forms.Button();
            this.tbx_notas = new System.Windows.Forms.TextBox();
            this.lbl_observacao = new System.Windows.Forms.Label();
            this.tbx_descricao = new System.Windows.Forms.TextBox();
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.tbx_nomeTabela = new System.Windows.Forms.TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.pan_formularioGeral = new System.Windows.Forms.Panel();
            this.pan_botton = new System.Windows.Forms.Panel();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.pan_tot = new System.Windows.Forms.Panel();
            this.pan_top = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_copiarRepositorio = new System.Windows.Forms.Button();
            this.btn_copiar_descricao = new System.Windows.Forms.Button();
            this.btn_copiar_Notas = new System.Windows.Forms.Button();
            this.gpb_cadastroGeral.SuspendLayout();
            this.pan_formularioGeral.SuspendLayout();
            this.pan_botton.SuspendLayout();
            this.pan_tot.SuspendLayout();
            this.pan_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_cadastroGeral
            // 
            this.gpb_cadastroGeral.Controls.Add(this.btn_copiar_Notas);
            this.gpb_cadastroGeral.Controls.Add(this.btn_copiar_descricao);
            this.gpb_cadastroGeral.Controls.Add(this.btn_copiarRepositorio);
            this.gpb_cadastroGeral.Controls.Add(this.btn_infoNotas);
            this.gpb_cadastroGeral.Controls.Add(this.btn_infoDescriçãoProjeto);
            this.gpb_cadastroGeral.Controls.Add(this.btn_info_tarefa);
            this.gpb_cadastroGeral.Controls.Add(this.tbx_notas);
            this.gpb_cadastroGeral.Controls.Add(this.lbl_observacao);
            this.gpb_cadastroGeral.Controls.Add(this.tbx_descricao);
            this.gpb_cadastroGeral.Controls.Add(this.lbl_descricao);
            this.gpb_cadastroGeral.Controls.Add(this.tbx_nomeTabela);
            this.gpb_cadastroGeral.Controls.Add(this.lbl_nome);
            this.gpb_cadastroGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpb_cadastroGeral.Location = new System.Drawing.Point(0, 0);
            this.gpb_cadastroGeral.Name = "gpb_cadastroGeral";
            this.gpb_cadastroGeral.Size = new System.Drawing.Size(740, 542);
            this.gpb_cadastroGeral.TabIndex = 0;
            this.gpb_cadastroGeral.TabStop = false;
            this.gpb_cadastroGeral.Text = "Cadastro de Tabela";
            // 
            // btn_infoNotas
            // 
            this.btn_infoNotas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_infoNotas.BackgroundImage")));
            this.btn_infoNotas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_infoNotas.Location = new System.Drawing.Point(689, 176);
            this.btn_infoNotas.Name = "btn_infoNotas";
            this.btn_infoNotas.Size = new System.Drawing.Size(20, 20);
            this.btn_infoNotas.TabIndex = 6;
            this.btn_infoNotas.UseVisualStyleBackColor = true;
            this.btn_infoNotas.Click += new System.EventHandler(this.btn_infoNotas_Click);
            // 
            // btn_infoDescriçãoProjeto
            // 
            this.btn_infoDescriçãoProjeto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_infoDescriçãoProjeto.BackgroundImage")));
            this.btn_infoDescriçãoProjeto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_infoDescriçãoProjeto.Location = new System.Drawing.Point(689, 58);
            this.btn_infoDescriçãoProjeto.Name = "btn_infoDescriçãoProjeto";
            this.btn_infoDescriçãoProjeto.Size = new System.Drawing.Size(20, 20);
            this.btn_infoDescriçãoProjeto.TabIndex = 4;
            this.btn_infoDescriçãoProjeto.UseVisualStyleBackColor = true;
            this.btn_infoDescriçãoProjeto.Click += new System.EventHandler(this.btn_infoDescriçãoProjeto_Click);
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
            this.btn_info_tarefa.Click += new System.EventHandler(this.btn_info_tarefa_Click);
            // 
            // tbx_notas
            // 
            this.tbx_notas.AcceptsTab = true;
            this.tbx_notas.Location = new System.Drawing.Point(97, 177);
            this.tbx_notas.MaxLength = 30000;
            this.tbx_notas.Multiline = true;
            this.tbx_notas.Name = "tbx_notas";
            this.tbx_notas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_notas.Size = new System.Drawing.Size(586, 112);
            this.tbx_notas.TabIndex = 5;
            // 
            // lbl_observacao
            // 
            this.lbl_observacao.AutoSize = true;
            this.lbl_observacao.Location = new System.Drawing.Point(6, 180);
            this.lbl_observacao.Name = "lbl_observacao";
            this.lbl_observacao.Size = new System.Drawing.Size(41, 16);
            this.lbl_observacao.TabIndex = 5;
            this.lbl_observacao.Text = "Notas";
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
            // tbx_nomeTabela
            // 
            this.tbx_nomeTabela.Location = new System.Drawing.Point(97, 25);
            this.tbx_nomeTabela.MaxLength = 50;
            this.tbx_nomeTabela.Name = "tbx_nomeTabela";
            this.tbx_nomeTabela.Size = new System.Drawing.Size(255, 23);
            this.tbx_nomeTabela.TabIndex = 1;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(6, 28);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(44, 16);
            this.lbl_nome.TabIndex = 5;
            this.lbl_nome.Text = "Tabela";
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
            this.pan_botton.Controls.Add(this.btn_excluir);
            this.pan_botton.Controls.Add(this.btn_confirmar);
            this.pan_botton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_botton.Location = new System.Drawing.Point(0, 527);
            this.pan_botton.Name = "pan_botton";
            this.pan_botton.Size = new System.Drawing.Size(740, 35);
            this.pan_botton.TabIndex = 7;
            // 
            // btn_excluir
            // 
            this.btn_excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_excluir.Location = new System.Drawing.Point(579, 3);
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
            this.pan_tot.TabIndex = 6;
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
            // btn_copiarRepositorio
            // 
            this.btn_copiarRepositorio.BackgroundImage = global::Pj.Properties.Resources.check_circle_outline_100px20x20;
            this.btn_copiarRepositorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_copiarRepositorio.Location = new System.Drawing.Point(384, 26);
            this.btn_copiarRepositorio.Name = "btn_copiarRepositorio";
            this.btn_copiarRepositorio.Size = new System.Drawing.Size(20, 20);
            this.btn_copiarRepositorio.TabIndex = 510;
            this.btn_copiarRepositorio.UseVisualStyleBackColor = true;
            this.btn_copiarRepositorio.Click += new System.EventHandler(this.btn_copiarRepositorio_Click);
            // 
            // btn_copiar_descricao
            // 
            this.btn_copiar_descricao.BackgroundImage = global::Pj.Properties.Resources.check_circle_outline_100px20x20;
            this.btn_copiar_descricao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_copiar_descricao.Location = new System.Drawing.Point(714, 58);
            this.btn_copiar_descricao.Name = "btn_copiar_descricao";
            this.btn_copiar_descricao.Size = new System.Drawing.Size(20, 20);
            this.btn_copiar_descricao.TabIndex = 511;
            this.btn_copiar_descricao.UseVisualStyleBackColor = true;
            this.btn_copiar_descricao.Click += new System.EventHandler(this.btn_copiar_descricao_Click);
            // 
            // btn_copiar_Notas
            // 
            this.btn_copiar_Notas.BackgroundImage = global::Pj.Properties.Resources.check_circle_outline_100px20x20;
            this.btn_copiar_Notas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_copiar_Notas.Location = new System.Drawing.Point(714, 176);
            this.btn_copiar_Notas.Name = "btn_copiar_Notas";
            this.btn_copiar_Notas.Size = new System.Drawing.Size(20, 20);
            this.btn_copiar_Notas.TabIndex = 511;
            this.btn_copiar_Notas.UseVisualStyleBackColor = true;
            this.btn_copiar_Notas.Click += new System.EventHandler(this.btn_copiar_Notas_Click);
            // 
            // UC_CadastroTabela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.pan_botton);
            this.Controls.Add(this.pan_tot);
            this.Controls.Add(this.pan_top);
            this.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.Name = "UC_CadastroTabela";
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
        private System.Windows.Forms.Button btn_infoDescriçãoProjeto;
        private System.Windows.Forms.Button btn_info_tarefa;
        private System.Windows.Forms.TextBox tbx_descricao;
        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.TextBox tbx_nomeTabela;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Panel pan_formularioGeral;
        private System.Windows.Forms.Panel pan_botton;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Panel pan_tot;
        private System.Windows.Forms.Button btn_infoNotas;
        private System.Windows.Forms.TextBox tbx_notas;
        private System.Windows.Forms.Label lbl_observacao;
        private System.Windows.Forms.Panel pan_top;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_copiar_Notas;
        private System.Windows.Forms.Button btn_copiar_descricao;
        private System.Windows.Forms.Button btn_copiarRepositorio;
    }
}
