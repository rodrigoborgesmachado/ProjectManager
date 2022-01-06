namespace Visao
{
    partial class UC_CadastroModulo
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
            this.btn_info_gridTabelas = new System.Windows.Forms.Button();
            this.btn_removerVinculo = new System.Windows.Forms.Button();
            this.btn_adicionarVinculo = new System.Windows.Forms.Button();
            this.dgv_tabelasVinculadas = new System.Windows.Forms.DataGridView();
            this.btn_infoDescriçãoProjeto = new System.Windows.Forms.Button();
            this.btn_info_PassoPasso = new System.Windows.Forms.Button();
            this.btn_info_tarefa = new System.Windows.Forms.Button();
            this.tbx_descricao = new System.Windows.Forms.TextBox();
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.tbx_passoPasso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_passoPasso = new System.Windows.Forms.Label();
            this.tbx_nomeModulo = new System.Windows.Forms.TextBox();
            this.lbl_nomeModulo = new System.Windows.Forms.Label();
            this.pan_formularioGeral = new System.Windows.Forms.Panel();
            this.pan_botton = new System.Windows.Forms.Panel();
            this.btn_gerar_document = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.pan_tot = new System.Windows.Forms.Panel();
            this.pan_top = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_copiar_nome = new System.Windows.Forms.Button();
            this.btn_copiar_descricao = new System.Windows.Forms.Button();
            this.btn_copiar_passoPasso = new System.Windows.Forms.Button();
            this.gpb_cadastroGeral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabelasVinculadas)).BeginInit();
            this.pan_formularioGeral.SuspendLayout();
            this.pan_botton.SuspendLayout();
            this.pan_tot.SuspendLayout();
            this.pan_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_cadastroGeral
            // 
            this.gpb_cadastroGeral.Controls.Add(this.btn_copiar_passoPasso);
            this.gpb_cadastroGeral.Controls.Add(this.btn_copiar_descricao);
            this.gpb_cadastroGeral.Controls.Add(this.btn_copiar_nome);
            this.gpb_cadastroGeral.Controls.Add(this.btn_info_gridTabelas);
            this.gpb_cadastroGeral.Controls.Add(this.btn_removerVinculo);
            this.gpb_cadastroGeral.Controls.Add(this.btn_adicionarVinculo);
            this.gpb_cadastroGeral.Controls.Add(this.dgv_tabelasVinculadas);
            this.gpb_cadastroGeral.Controls.Add(this.btn_infoDescriçãoProjeto);
            this.gpb_cadastroGeral.Controls.Add(this.btn_info_PassoPasso);
            this.gpb_cadastroGeral.Controls.Add(this.btn_info_tarefa);
            this.gpb_cadastroGeral.Controls.Add(this.tbx_descricao);
            this.gpb_cadastroGeral.Controls.Add(this.lbl_descricao);
            this.gpb_cadastroGeral.Controls.Add(this.tbx_passoPasso);
            this.gpb_cadastroGeral.Controls.Add(this.label1);
            this.gpb_cadastroGeral.Controls.Add(this.lbl_passoPasso);
            this.gpb_cadastroGeral.Controls.Add(this.tbx_nomeModulo);
            this.gpb_cadastroGeral.Controls.Add(this.lbl_nomeModulo);
            this.gpb_cadastroGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpb_cadastroGeral.Location = new System.Drawing.Point(0, 0);
            this.gpb_cadastroGeral.Name = "gpb_cadastroGeral";
            this.gpb_cadastroGeral.Size = new System.Drawing.Size(863, 628);
            this.gpb_cadastroGeral.TabIndex = 0;
            this.gpb_cadastroGeral.TabStop = false;
            this.gpb_cadastroGeral.Text = "Cadastro de Módulo";
            // 
            // btn_info_gridTabelas
            // 
            this.btn_info_gridTabelas.BackgroundImage = global::Pj.Properties.Resources.png_infoProdutoBlack20x20;
            this.btn_info_gridTabelas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_gridTabelas.Location = new System.Drawing.Point(542, 302);
            this.btn_info_gridTabelas.Name = "btn_info_gridTabelas";
            this.btn_info_gridTabelas.Size = new System.Drawing.Size(20, 20);
            this.btn_info_gridTabelas.TabIndex = 10;
            this.btn_info_gridTabelas.UseVisualStyleBackColor = true;
            this.btn_info_gridTabelas.Click += new System.EventHandler(this.btn_info_gridTabelas_Click);
            // 
            // btn_removerVinculo
            // 
            this.btn_removerVinculo.BackgroundImage = global::Pj.Properties.Resources.quit20x20;
            this.btn_removerVinculo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_removerVinculo.Location = new System.Drawing.Point(542, 276);
            this.btn_removerVinculo.Name = "btn_removerVinculo";
            this.btn_removerVinculo.Size = new System.Drawing.Size(20, 20);
            this.btn_removerVinculo.TabIndex = 9;
            this.btn_removerVinculo.UseVisualStyleBackColor = true;
            this.btn_removerVinculo.Click += new System.EventHandler(this.btn_removerVinculo_Click);
            // 
            // btn_adicionarVinculo
            // 
            this.btn_adicionarVinculo.BackgroundImage = global::Pj.Properties.Resources.plus20x20;
            this.btn_adicionarVinculo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_adicionarVinculo.Location = new System.Drawing.Point(542, 250);
            this.btn_adicionarVinculo.Name = "btn_adicionarVinculo";
            this.btn_adicionarVinculo.Size = new System.Drawing.Size(20, 20);
            this.btn_adicionarVinculo.TabIndex = 8;
            this.btn_adicionarVinculo.UseVisualStyleBackColor = true;
            this.btn_adicionarVinculo.Click += new System.EventHandler(this.btn_adicionarVinculo_Click);
            // 
            // dgv_tabelasVinculadas
            // 
            this.dgv_tabelasVinculadas.AllowUserToAddRows = false;
            this.dgv_tabelasVinculadas.AllowUserToDeleteRows = false;
            this.dgv_tabelasVinculadas.AllowUserToOrderColumns = true;
            this.dgv_tabelasVinculadas.AllowUserToResizeRows = false;
            this.dgv_tabelasVinculadas.BackgroundColor = System.Drawing.Color.White;
            this.dgv_tabelasVinculadas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_tabelasVinculadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tabelasVinculadas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_tabelasVinculadas.Location = new System.Drawing.Point(208, 250);
            this.dgv_tabelasVinculadas.MultiSelect = false;
            this.dgv_tabelasVinculadas.Name = "dgv_tabelasVinculadas";
            this.dgv_tabelasVinculadas.RowHeadersVisible = false;
            this.dgv_tabelasVinculadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tabelasVinculadas.Size = new System.Drawing.Size(328, 319);
            this.dgv_tabelasVinculadas.TabIndex = 7;
            // 
            // btn_infoDescriçãoProjeto
            // 
            this.btn_infoDescriçãoProjeto.BackgroundImage = global::Pj.Properties.Resources.png_infoProdutoBlack20x20;
            this.btn_infoDescriçãoProjeto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_infoDescriçãoProjeto.Location = new System.Drawing.Point(804, 67);
            this.btn_infoDescriçãoProjeto.Name = "btn_infoDescriçãoProjeto";
            this.btn_infoDescriçãoProjeto.Size = new System.Drawing.Size(20, 20);
            this.btn_infoDescriçãoProjeto.TabIndex = 4;
            this.btn_infoDescriçãoProjeto.UseVisualStyleBackColor = true;
            this.btn_infoDescriçãoProjeto.Click += new System.EventHandler(this.btn_infoDescriçãoProjeto_Click);
            // 
            // btn_info_PassoPasso
            // 
            this.btn_info_PassoPasso.BackgroundImage = global::Pj.Properties.Resources.png_infoProdutoBlack20x20;
            this.btn_info_PassoPasso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_PassoPasso.Location = new System.Drawing.Point(804, 211);
            this.btn_info_PassoPasso.Name = "btn_info_PassoPasso";
            this.btn_info_PassoPasso.Size = new System.Drawing.Size(20, 20);
            this.btn_info_PassoPasso.TabIndex = 6;
            this.btn_info_PassoPasso.UseVisualStyleBackColor = true;
            this.btn_info_PassoPasso.Click += new System.EventHandler(this.btn_info_PassoPasso_Click);
            // 
            // btn_info_tarefa
            // 
            this.btn_info_tarefa.BackgroundImage = global::Pj.Properties.Resources.png_infoProdutoBlack20x20;
            this.btn_info_tarefa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_tarefa.Location = new System.Drawing.Point(418, 30);
            this.btn_info_tarefa.Name = "btn_info_tarefa";
            this.btn_info_tarefa.Size = new System.Drawing.Size(20, 20);
            this.btn_info_tarefa.TabIndex = 2;
            this.btn_info_tarefa.UseVisualStyleBackColor = true;
            this.btn_info_tarefa.Click += new System.EventHandler(this.btn_info_tarefa_Click);
            // 
            // tbx_descricao
            // 
            this.tbx_descricao.AcceptsTab = true;
            this.tbx_descricao.Location = new System.Drawing.Point(113, 68);
            this.tbx_descricao.MaxLength = 1000;
            this.tbx_descricao.Multiline = true;
            this.tbx_descricao.Name = "tbx_descricao";
            this.tbx_descricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_descricao.Size = new System.Drawing.Size(683, 129);
            this.tbx_descricao.TabIndex = 3;
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.Location = new System.Drawing.Point(7, 72);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(64, 16);
            this.lbl_descricao.TabIndex = 5;
            this.lbl_descricao.Text = "Descrição";
            // 
            // tbx_passoPasso
            // 
            this.tbx_passoPasso.Location = new System.Drawing.Point(113, 209);
            this.tbx_passoPasso.MaxLength = 300;
            this.tbx_passoPasso.Name = "tbx_passoPasso";
            this.tbx_passoPasso.Size = new System.Drawing.Size(683, 23);
            this.tbx_passoPasso.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tabelas utilizadas no módulo:";
            // 
            // lbl_passoPasso
            // 
            this.lbl_passoPasso.AutoSize = true;
            this.lbl_passoPasso.Location = new System.Drawing.Point(7, 212);
            this.lbl_passoPasso.Name = "lbl_passoPasso";
            this.lbl_passoPasso.Size = new System.Drawing.Size(104, 16);
            this.lbl_passoPasso.TabIndex = 5;
            this.lbl_passoPasso.Text = "Passo a passo (:)";
            // 
            // tbx_nomeModulo
            // 
            this.tbx_nomeModulo.Location = new System.Drawing.Point(113, 29);
            this.tbx_nomeModulo.MaxLength = 50;
            this.tbx_nomeModulo.Name = "tbx_nomeModulo";
            this.tbx_nomeModulo.Size = new System.Drawing.Size(297, 23);
            this.tbx_nomeModulo.TabIndex = 1;
            // 
            // lbl_nomeModulo
            // 
            this.lbl_nomeModulo.AutoSize = true;
            this.lbl_nomeModulo.Location = new System.Drawing.Point(7, 32);
            this.lbl_nomeModulo.Name = "lbl_nomeModulo";
            this.lbl_nomeModulo.Size = new System.Drawing.Size(107, 16);
            this.lbl_nomeModulo.TabIndex = 5;
            this.lbl_nomeModulo.Text = "Nome do Módulo";
            // 
            // pan_formularioGeral
            // 
            this.pan_formularioGeral.AllowDrop = true;
            this.pan_formularioGeral.AutoScroll = true;
            this.pan_formularioGeral.Controls.Add(this.gpb_cadastroGeral);
            this.pan_formularioGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_formularioGeral.Location = new System.Drawing.Point(0, 0);
            this.pan_formularioGeral.Name = "pan_formularioGeral";
            this.pan_formularioGeral.Size = new System.Drawing.Size(863, 628);
            this.pan_formularioGeral.TabIndex = 0;
            // 
            // pan_botton
            // 
            this.pan_botton.Controls.Add(this.btn_gerar_document);
            this.pan_botton.Controls.Add(this.btn_excluir);
            this.pan_botton.Controls.Add(this.btn_confirmar);
            this.pan_botton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_botton.Location = new System.Drawing.Point(0, 608);
            this.pan_botton.Name = "pan_botton";
            this.pan_botton.Size = new System.Drawing.Size(863, 40);
            this.pan_botton.TabIndex = 7;
            // 
            // btn_gerar_document
            // 
            this.btn_gerar_document.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_gerar_document.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_gerar_document.Location = new System.Drawing.Point(678, 3);
            this.btn_gerar_document.Name = "btn_gerar_document";
            this.btn_gerar_document.Size = new System.Drawing.Size(87, 33);
            this.btn_gerar_document.TabIndex = 8;
            this.btn_gerar_document.Text = "Gerar";
            this.btn_gerar_document.UseVisualStyleBackColor = true;
            this.btn_gerar_document.Click += new System.EventHandler(this.btn_gerar_document_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_excluir.Location = new System.Drawing.Point(583, 3);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(87, 33);
            this.btn_excluir.TabIndex = 9;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_confirmar.Location = new System.Drawing.Point(772, 3);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(87, 33);
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
            this.pan_tot.Size = new System.Drawing.Size(863, 628);
            this.pan_tot.TabIndex = 6;
            // 
            // pan_top
            // 
            this.pan_top.Controls.Add(this.btn_fechar);
            this.pan_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_top.Location = new System.Drawing.Point(0, 0);
            this.pan_top.Name = "pan_top";
            this.pan_top.Size = new System.Drawing.Size(863, 20);
            this.pan_top.TabIndex = 19;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fechar.BackColor = System.Drawing.Color.Red;
            this.btn_fechar.BackgroundImage = global::Pj.Properties.Resources.window_close_100px20x20;
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_fechar.Location = new System.Drawing.Point(843, 0);
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
            this.btn_copiar_nome.Location = new System.Drawing.Point(444, 30);
            this.btn_copiar_nome.Name = "btn_copiar_nome";
            this.btn_copiar_nome.Size = new System.Drawing.Size(20, 20);
            this.btn_copiar_nome.TabIndex = 506;
            this.btn_copiar_nome.UseVisualStyleBackColor = true;
            this.btn_copiar_nome.Click += new System.EventHandler(this.btn_copiar_nome_Click);
            // 
            // btn_copiar_descricao
            // 
            this.btn_copiar_descricao.BackgroundImage = global::Pj.Properties.Resources.check_circle_outline_100px20x20;
            this.btn_copiar_descricao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_copiar_descricao.Location = new System.Drawing.Point(830, 67);
            this.btn_copiar_descricao.Name = "btn_copiar_descricao";
            this.btn_copiar_descricao.Size = new System.Drawing.Size(20, 20);
            this.btn_copiar_descricao.TabIndex = 507;
            this.btn_copiar_descricao.UseVisualStyleBackColor = true;
            this.btn_copiar_descricao.Click += new System.EventHandler(this.btn_copiar_descricao_Click);
            // 
            // btn_copiar_passoPasso
            // 
            this.btn_copiar_passoPasso.BackgroundImage = global::Pj.Properties.Resources.check_circle_outline_100px20x20;
            this.btn_copiar_passoPasso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_copiar_passoPasso.Location = new System.Drawing.Point(830, 211);
            this.btn_copiar_passoPasso.Name = "btn_copiar_passoPasso";
            this.btn_copiar_passoPasso.Size = new System.Drawing.Size(20, 20);
            this.btn_copiar_passoPasso.TabIndex = 508;
            this.btn_copiar_passoPasso.UseVisualStyleBackColor = true;
            this.btn_copiar_passoPasso.Click += new System.EventHandler(this.btn_copiar_passoPasso_Click);
            // 
            // UC_CadastroModulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.pan_botton);
            this.Controls.Add(this.pan_tot);
            this.Controls.Add(this.pan_top);
            this.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.Name = "UC_CadastroModulo";
            this.Size = new System.Drawing.Size(863, 648);
            this.gpb_cadastroGeral.ResumeLayout(false);
            this.gpb_cadastroGeral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabelasVinculadas)).EndInit();
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
        private System.Windows.Forms.TextBox tbx_nomeModulo;
        private System.Windows.Forms.Label lbl_nomeModulo;
        private System.Windows.Forms.Panel pan_formularioGeral;
        private System.Windows.Forms.Panel pan_botton;
        private System.Windows.Forms.Button btn_gerar_document;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Panel pan_tot;
        private System.Windows.Forms.Button btn_info_PassoPasso;
        private System.Windows.Forms.TextBox tbx_passoPasso;
        private System.Windows.Forms.Label lbl_passoPasso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_info_gridTabelas;
        private System.Windows.Forms.Button btn_removerVinculo;
        private System.Windows.Forms.Button btn_adicionarVinculo;
        private System.Windows.Forms.DataGridView dgv_tabelasVinculadas;
        private System.Windows.Forms.Panel pan_top;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_copiar_passoPasso;
        private System.Windows.Forms.Button btn_copiar_descricao;
        private System.Windows.Forms.Button btn_copiar_nome;
    }
}
