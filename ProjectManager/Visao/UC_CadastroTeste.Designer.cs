namespace Visao
{
    partial class UC_CadastroTeste
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
            this.btn_removerTeste = new System.Windows.Forms.Button();
            this.btn_adicionarTeste = new System.Windows.Forms.Button();
            this.dgv_testes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_info_modulo = new System.Windows.Forms.Button();
            this.cmb_modulos = new System.Windows.Forms.ComboBox();
            this.btn_info_notas = new System.Windows.Forms.Button();
            this.btn_infoDescricao = new System.Windows.Forms.Button();
            this.tbx_notas = new System.Windows.Forms.TextBox();
            this.tbx_descricao = new System.Windows.Forms.TextBox();
            this.lbl_modulo = new System.Windows.Forms.Label();
            this.lbl_notas = new System.Windows.Forms.Label();
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.pan_formularioGeral = new System.Windows.Forms.Panel();
            this.pan_botton = new System.Windows.Forms.Panel();
            this.btn_gerar_document = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.pan_tot = new System.Windows.Forms.Panel();
            this.pan_top = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_copiar_descricao = new System.Windows.Forms.Button();
            this.btn_copiar_notas = new System.Windows.Forms.Button();
            this.gpb_cadastroGeral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_testes)).BeginInit();
            this.pan_formularioGeral.SuspendLayout();
            this.pan_botton.SuspendLayout();
            this.pan_tot.SuspendLayout();
            this.pan_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_cadastroGeral
            // 
            this.gpb_cadastroGeral.Controls.Add(this.btn_copiar_notas);
            this.gpb_cadastroGeral.Controls.Add(this.btn_copiar_descricao);
            this.gpb_cadastroGeral.Controls.Add(this.btn_info_gridTabelas);
            this.gpb_cadastroGeral.Controls.Add(this.btn_removerTeste);
            this.gpb_cadastroGeral.Controls.Add(this.btn_adicionarTeste);
            this.gpb_cadastroGeral.Controls.Add(this.dgv_testes);
            this.gpb_cadastroGeral.Controls.Add(this.label1);
            this.gpb_cadastroGeral.Controls.Add(this.btn_info_modulo);
            this.gpb_cadastroGeral.Controls.Add(this.cmb_modulos);
            this.gpb_cadastroGeral.Controls.Add(this.btn_info_notas);
            this.gpb_cadastroGeral.Controls.Add(this.btn_infoDescricao);
            this.gpb_cadastroGeral.Controls.Add(this.tbx_notas);
            this.gpb_cadastroGeral.Controls.Add(this.tbx_descricao);
            this.gpb_cadastroGeral.Controls.Add(this.lbl_modulo);
            this.gpb_cadastroGeral.Controls.Add(this.lbl_notas);
            this.gpb_cadastroGeral.Controls.Add(this.lbl_descricao);
            this.gpb_cadastroGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpb_cadastroGeral.Location = new System.Drawing.Point(0, 0);
            this.gpb_cadastroGeral.Name = "gpb_cadastroGeral";
            this.gpb_cadastroGeral.Size = new System.Drawing.Size(740, 562);
            this.gpb_cadastroGeral.TabIndex = 0;
            this.gpb_cadastroGeral.TabStop = false;
            this.gpb_cadastroGeral.Text = "Cadastro de Teste";
            // 
            // btn_info_gridTabelas
            // 
            this.btn_info_gridTabelas.BackgroundImage = global::Pj.Properties.Resources.png_infoProdutoBlack20x20;
            this.btn_info_gridTabelas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_gridTabelas.Location = new System.Drawing.Point(690, 367);
            this.btn_info_gridTabelas.Name = "btn_info_gridTabelas";
            this.btn_info_gridTabelas.Size = new System.Drawing.Size(20, 20);
            this.btn_info_gridTabelas.TabIndex = 10;
            this.btn_info_gridTabelas.UseVisualStyleBackColor = true;
            this.btn_info_gridTabelas.Click += new System.EventHandler(this.btn_info_gridTabelas_Click);
            // 
            // btn_removerTeste
            // 
            this.btn_removerTeste.BackgroundImage = global::Pj.Properties.Resources.quit20x20;
            this.btn_removerTeste.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_removerTeste.Location = new System.Drawing.Point(690, 341);
            this.btn_removerTeste.Name = "btn_removerTeste";
            this.btn_removerTeste.Size = new System.Drawing.Size(20, 20);
            this.btn_removerTeste.TabIndex = 9;
            this.btn_removerTeste.UseVisualStyleBackColor = true;
            this.btn_removerTeste.Click += new System.EventHandler(this.btn_removerTeste_Click);
            // 
            // btn_adicionarTeste
            // 
            this.btn_adicionarTeste.BackgroundImage = global::Pj.Properties.Resources.plus20x20;
            this.btn_adicionarTeste.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_adicionarTeste.Location = new System.Drawing.Point(690, 315);
            this.btn_adicionarTeste.Name = "btn_adicionarTeste";
            this.btn_adicionarTeste.Size = new System.Drawing.Size(20, 20);
            this.btn_adicionarTeste.TabIndex = 8;
            this.btn_adicionarTeste.UseVisualStyleBackColor = true;
            this.btn_adicionarTeste.Click += new System.EventHandler(this.btn_adicionarTeste_Click);
            // 
            // dgv_testes
            // 
            this.dgv_testes.AllowUserToAddRows = false;
            this.dgv_testes.AllowUserToDeleteRows = false;
            this.dgv_testes.AllowUserToOrderColumns = true;
            this.dgv_testes.AllowUserToResizeRows = false;
            this.dgv_testes.BackgroundColor = System.Drawing.Color.White;
            this.dgv_testes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_testes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_testes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_testes.Location = new System.Drawing.Point(184, 315);
            this.dgv_testes.MultiSelect = false;
            this.dgv_testes.Name = "dgv_testes";
            this.dgv_testes.RowHeadersVisible = false;
            this.dgv_testes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_testes.Size = new System.Drawing.Size(499, 181);
            this.dgv_testes.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tabelas utilizadas no módulo:";
            // 
            // btn_info_modulo
            // 
            this.btn_info_modulo.BackgroundImage = global::Pj.Properties.Resources.png_infoProdutoBlack20x20;
            this.btn_info_modulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_modulo.Location = new System.Drawing.Point(314, 282);
            this.btn_info_modulo.Name = "btn_info_modulo";
            this.btn_info_modulo.Size = new System.Drawing.Size(20, 20);
            this.btn_info_modulo.TabIndex = 6;
            this.btn_info_modulo.UseVisualStyleBackColor = true;
            this.btn_info_modulo.Click += new System.EventHandler(this.btn_info_modulo_Click);
            // 
            // cmb_modulos
            // 
            this.cmb_modulos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_modulos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_modulos.FormattingEnabled = true;
            this.cmb_modulos.Location = new System.Drawing.Point(133, 280);
            this.cmb_modulos.Name = "cmb_modulos";
            this.cmb_modulos.Size = new System.Drawing.Size(175, 23);
            this.cmb_modulos.TabIndex = 5;
            // 
            // btn_info_notas
            // 
            this.btn_info_notas.BackgroundImage = global::Pj.Properties.Resources.png_infoProdutoBlack20x20;
            this.btn_info_notas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_notas.Location = new System.Drawing.Point(689, 151);
            this.btn_info_notas.Name = "btn_info_notas";
            this.btn_info_notas.Size = new System.Drawing.Size(20, 20);
            this.btn_info_notas.TabIndex = 4;
            this.btn_info_notas.UseVisualStyleBackColor = true;
            this.btn_info_notas.Click += new System.EventHandler(this.btn_info_notas_Click);
            // 
            // btn_infoDescricao
            // 
            this.btn_infoDescricao.BackgroundImage = global::Pj.Properties.Resources.png_infoProdutoBlack20x20;
            this.btn_infoDescricao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_infoDescricao.Location = new System.Drawing.Point(689, 23);
            this.btn_infoDescricao.Name = "btn_infoDescricao";
            this.btn_infoDescricao.Size = new System.Drawing.Size(20, 20);
            this.btn_infoDescricao.TabIndex = 2;
            this.btn_infoDescricao.UseVisualStyleBackColor = true;
            this.btn_infoDescricao.Click += new System.EventHandler(this.btn_infoDescricao_Click);
            // 
            // tbx_notas
            // 
            this.tbx_notas.AcceptsTab = true;
            this.tbx_notas.Location = new System.Drawing.Point(128, 152);
            this.tbx_notas.MaxLength = 1000;
            this.tbx_notas.Multiline = true;
            this.tbx_notas.Name = "tbx_notas";
            this.tbx_notas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_notas.Size = new System.Drawing.Size(555, 112);
            this.tbx_notas.TabIndex = 3;
            // 
            // tbx_descricao
            // 
            this.tbx_descricao.AcceptsTab = true;
            this.tbx_descricao.Location = new System.Drawing.Point(128, 24);
            this.tbx_descricao.MaxLength = 1000;
            this.tbx_descricao.Multiline = true;
            this.tbx_descricao.Name = "tbx_descricao";
            this.tbx_descricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_descricao.Size = new System.Drawing.Size(555, 112);
            this.tbx_descricao.TabIndex = 1;
            // 
            // lbl_modulo
            // 
            this.lbl_modulo.AutoSize = true;
            this.lbl_modulo.Location = new System.Drawing.Point(6, 283);
            this.lbl_modulo.Name = "lbl_modulo";
            this.lbl_modulo.Size = new System.Drawing.Size(126, 16);
            this.lbl_modulo.TabIndex = 5;
            this.lbl_modulo.Text = "Módulo a ser testado";
            // 
            // lbl_notas
            // 
            this.lbl_notas.AutoSize = true;
            this.lbl_notas.Location = new System.Drawing.Point(6, 152);
            this.lbl_notas.Name = "lbl_notas";
            this.lbl_notas.Size = new System.Drawing.Size(41, 16);
            this.lbl_notas.TabIndex = 5;
            this.lbl_notas.Text = "Notas";
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.Location = new System.Drawing.Point(6, 27);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(116, 16);
            this.lbl_descricao.TabIndex = 5;
            this.lbl_descricao.Text = "Descrição do Teste";
            // 
            // pan_formularioGeral
            // 
            this.pan_formularioGeral.AllowDrop = true;
            this.pan_formularioGeral.AutoScroll = true;
            this.pan_formularioGeral.Controls.Add(this.gpb_cadastroGeral);
            this.pan_formularioGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_formularioGeral.Location = new System.Drawing.Point(0, 0);
            this.pan_formularioGeral.Name = "pan_formularioGeral";
            this.pan_formularioGeral.Size = new System.Drawing.Size(740, 562);
            this.pan_formularioGeral.TabIndex = 0;
            // 
            // pan_botton
            // 
            this.pan_botton.Controls.Add(this.btn_gerar_document);
            this.pan_botton.Controls.Add(this.btn_excluir);
            this.pan_botton.Controls.Add(this.btn_confirmar);
            this.pan_botton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_botton.Location = new System.Drawing.Point(0, 527);
            this.pan_botton.Name = "pan_botton";
            this.pan_botton.Size = new System.Drawing.Size(740, 35);
            this.pan_botton.TabIndex = 7;
            // 
            // btn_gerar_document
            // 
            this.btn_gerar_document.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_gerar_document.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_gerar_document.Location = new System.Drawing.Point(6, 3);
            this.btn_gerar_document.Name = "btn_gerar_document";
            this.btn_gerar_document.Size = new System.Drawing.Size(159, 29);
            this.btn_gerar_document.TabIndex = 13;
            this.btn_gerar_document.Text = "Gerar Relatório de Teste";
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
            this.btn_excluir.TabIndex = 12;
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
            this.btn_confirmar.TabIndex = 11;
            this.btn_confirmar.Text = "Cadastrar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // pan_tot
            // 
            this.pan_tot.AutoScroll = true;
            this.pan_tot.Controls.Add(this.pan_formularioGeral);
            this.pan_tot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_tot.Location = new System.Drawing.Point(0, 0);
            this.pan_tot.Name = "pan_tot";
            this.pan_tot.Size = new System.Drawing.Size(740, 562);
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
            // btn_copiar_descricao
            // 
            this.btn_copiar_descricao.BackgroundImage = global::Pj.Properties.Resources.check_circle_outline_100px20x20;
            this.btn_copiar_descricao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_copiar_descricao.Location = new System.Drawing.Point(714, 23);
            this.btn_copiar_descricao.Name = "btn_copiar_descricao";
            this.btn_copiar_descricao.Size = new System.Drawing.Size(20, 20);
            this.btn_copiar_descricao.TabIndex = 511;
            this.btn_copiar_descricao.UseVisualStyleBackColor = true;
            this.btn_copiar_descricao.Click += new System.EventHandler(this.btn_copiar_descricao_Click);
            // 
            // btn_copiar_notas
            // 
            this.btn_copiar_notas.BackgroundImage = global::Pj.Properties.Resources.check_circle_outline_100px20x20;
            this.btn_copiar_notas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_copiar_notas.Location = new System.Drawing.Point(714, 151);
            this.btn_copiar_notas.Name = "btn_copiar_notas";
            this.btn_copiar_notas.Size = new System.Drawing.Size(20, 20);
            this.btn_copiar_notas.TabIndex = 511;
            this.btn_copiar_notas.UseVisualStyleBackColor = true;
            this.btn_copiar_notas.Click += new System.EventHandler(this.btn_copiar_notas_Click);
            // 
            // UC_CadastroTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.pan_top);
            this.Controls.Add(this.pan_botton);
            this.Controls.Add(this.pan_tot);
            this.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.Name = "UC_CadastroTeste";
            this.Size = new System.Drawing.Size(740, 562);
            this.gpb_cadastroGeral.ResumeLayout(false);
            this.gpb_cadastroGeral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_testes)).EndInit();
            this.pan_formularioGeral.ResumeLayout(false);
            this.pan_botton.ResumeLayout(false);
            this.pan_tot.ResumeLayout(false);
            this.pan_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_cadastroGeral;
        private System.Windows.Forms.Button btn_infoDescricao;
        private System.Windows.Forms.TextBox tbx_descricao;
        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.Panel pan_formularioGeral;
        private System.Windows.Forms.Panel pan_botton;
        private System.Windows.Forms.Button btn_gerar_document;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Panel pan_tot;
        private System.Windows.Forms.Button btn_info_notas;
        private System.Windows.Forms.TextBox tbx_notas;
        private System.Windows.Forms.Label lbl_modulo;
        private System.Windows.Forms.Label lbl_notas;
        private System.Windows.Forms.ComboBox cmb_modulos;
        private System.Windows.Forms.Button btn_info_modulo;
        private System.Windows.Forms.Button btn_info_gridTabelas;
        private System.Windows.Forms.Button btn_removerTeste;
        private System.Windows.Forms.Button btn_adicionarTeste;
        private System.Windows.Forms.DataGridView dgv_testes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pan_top;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_copiar_notas;
        private System.Windows.Forms.Button btn_copiar_descricao;
    }
}
