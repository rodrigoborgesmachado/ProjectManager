namespace Visao
{
    partial class UC_CadastroCampos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CadastroCampos));
            this.gpb_cadastroGeral = new System.Windows.Forms.GroupBox();
            this.grb_regras = new System.Windows.Forms.GroupBox();
            this.cmb_datatype = new System.Windows.Forms.ComboBox();
            this.tbx_precisao = new System.Windows.Forms.TextBox();
            this.tbx_tamanho = new System.Windows.Forms.TextBox();
            this.lbl_precisao = new System.Windows.Forms.Label();
            this.tbx_default = new System.Windows.Forms.TextBox();
            this.lbl_tamanho = new System.Windows.Forms.Label();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.lbl_default = new System.Windows.Forms.Label();
            this.tbx_check = new System.Windows.Forms.TextBox();
            this.lbl_check = new System.Windows.Forms.Label();
            this.btn_info_datatype = new System.Windows.Forms.Button();
            this.btn_info_check = new System.Windows.Forms.Button();
            this.btn_infoPrecisao = new System.Windows.Forms.Button();
            this.btn_infoTamanho = new System.Windows.Forms.Button();
            this.btn_info_valorDefault = new System.Windows.Forms.Button();
            this.grb_geral = new System.Windows.Forms.GroupBox();
            this.tbx_descrição = new System.Windows.Forms.TextBox();
            this.lbl_descrição = new System.Windows.Forms.Label();
            this.tbx_dominio = new System.Windows.Forms.TextBox();
            this.lbl_dominio = new System.Windows.Forms.Label();
            this.btn_info_descrição = new System.Windows.Forms.Button();
            this.tbx_nomeCampo = new System.Windows.Forms.TextBox();
            this.btn_info_dominio = new System.Windows.Forms.Button();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.btn_info_campo = new System.Windows.Forms.Button();
            this.grb_selecao = new System.Windows.Forms.GroupBox();
            this.ckb_unique = new System.Windows.Forms.CheckBox();
            this.btn_info_unique = new System.Windows.Forms.Button();
            this.btn_infonotnull = new System.Windows.Forms.Button();
            this.btn_info_primarykey = new System.Windows.Forms.Button();
            this.ckb_notNull = new System.Windows.Forms.CheckBox();
            this.ckb_primarykey = new System.Windows.Forms.CheckBox();
            this.pan_formularioGeral = new System.Windows.Forms.Panel();
            this.pan_botton = new System.Windows.Forms.Panel();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.pan_tot = new System.Windows.Forms.Panel();
            this.pan_top = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_copiar_campo = new System.Windows.Forms.Button();
            this.btn_copiar_dominio = new System.Windows.Forms.Button();
            this.btn_copiar_descricao = new System.Windows.Forms.Button();
            this.gpb_cadastroGeral.SuspendLayout();
            this.grb_regras.SuspendLayout();
            this.grb_geral.SuspendLayout();
            this.grb_selecao.SuspendLayout();
            this.pan_formularioGeral.SuspendLayout();
            this.pan_botton.SuspendLayout();
            this.pan_tot.SuspendLayout();
            this.pan_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_cadastroGeral
            // 
            this.gpb_cadastroGeral.Controls.Add(this.grb_regras);
            this.gpb_cadastroGeral.Controls.Add(this.grb_geral);
            this.gpb_cadastroGeral.Controls.Add(this.grb_selecao);
            this.gpb_cadastroGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpb_cadastroGeral.Location = new System.Drawing.Point(0, 0);
            this.gpb_cadastroGeral.Name = "gpb_cadastroGeral";
            this.gpb_cadastroGeral.Size = new System.Drawing.Size(740, 542);
            this.gpb_cadastroGeral.TabIndex = 0;
            this.gpb_cadastroGeral.TabStop = false;
            this.gpb_cadastroGeral.Text = "Cadastro de Campo";
            // 
            // grb_regras
            // 
            this.grb_regras.Controls.Add(this.cmb_datatype);
            this.grb_regras.Controls.Add(this.tbx_precisao);
            this.grb_regras.Controls.Add(this.tbx_tamanho);
            this.grb_regras.Controls.Add(this.lbl_precisao);
            this.grb_regras.Controls.Add(this.tbx_default);
            this.grb_regras.Controls.Add(this.lbl_tamanho);
            this.grb_regras.Controls.Add(this.lbl_tipo);
            this.grb_regras.Controls.Add(this.lbl_default);
            this.grb_regras.Controls.Add(this.tbx_check);
            this.grb_regras.Controls.Add(this.lbl_check);
            this.grb_regras.Controls.Add(this.btn_info_datatype);
            this.grb_regras.Controls.Add(this.btn_info_check);
            this.grb_regras.Controls.Add(this.btn_infoPrecisao);
            this.grb_regras.Controls.Add(this.btn_infoTamanho);
            this.grb_regras.Controls.Add(this.btn_info_valorDefault);
            this.grb_regras.Location = new System.Drawing.Point(7, 132);
            this.grb_regras.Name = "grb_regras";
            this.grb_regras.Size = new System.Drawing.Size(715, 126);
            this.grb_regras.TabIndex = 8;
            this.grb_regras.TabStop = false;
            this.grb_regras.Text = "Regras";
            // 
            // cmb_datatype
            // 
            this.cmb_datatype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_datatype.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_datatype.FormattingEnabled = true;
            this.cmb_datatype.Location = new System.Drawing.Point(504, 51);
            this.cmb_datatype.Name = "cmb_datatype";
            this.cmb_datatype.Size = new System.Drawing.Size(179, 23);
            this.cmb_datatype.TabIndex = 17;
            // 
            // tbx_precisao
            // 
            this.tbx_precisao.Location = new System.Drawing.Point(296, 80);
            this.tbx_precisao.MaxLength = 50;
            this.tbx_precisao.Name = "tbx_precisao";
            this.tbx_precisao.Size = new System.Drawing.Size(81, 23);
            this.tbx_precisao.TabIndex = 21;
            // 
            // tbx_tamanho
            // 
            this.tbx_tamanho.Location = new System.Drawing.Point(92, 80);
            this.tbx_tamanho.MaxLength = 50;
            this.tbx_tamanho.Name = "tbx_tamanho";
            this.tbx_tamanho.Size = new System.Drawing.Size(81, 23);
            this.tbx_tamanho.TabIndex = 19;
            // 
            // lbl_precisao
            // 
            this.lbl_precisao.AutoSize = true;
            this.lbl_precisao.Location = new System.Drawing.Point(209, 83);
            this.lbl_precisao.Name = "lbl_precisao";
            this.lbl_precisao.Size = new System.Drawing.Size(56, 16);
            this.lbl_precisao.TabIndex = 5;
            this.lbl_precisao.Text = "Precisão";
            // 
            // tbx_default
            // 
            this.tbx_default.Location = new System.Drawing.Point(92, 51);
            this.tbx_default.MaxLength = 50;
            this.tbx_default.Name = "tbx_default";
            this.tbx_default.Size = new System.Drawing.Size(285, 23);
            this.tbx_default.TabIndex = 15;
            // 
            // lbl_tamanho
            // 
            this.lbl_tamanho.AutoSize = true;
            this.lbl_tamanho.Location = new System.Drawing.Point(5, 83);
            this.lbl_tamanho.Name = "lbl_tamanho";
            this.lbl_tamanho.Size = new System.Drawing.Size(60, 16);
            this.lbl_tamanho.TabIndex = 5;
            this.lbl_tamanho.Text = "Tamanho";
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Location = new System.Drawing.Point(432, 54);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(66, 16);
            this.lbl_tipo.TabIndex = 5;
            this.lbl_tipo.Text = "Data Type";
            // 
            // lbl_default
            // 
            this.lbl_default.AutoSize = true;
            this.lbl_default.Location = new System.Drawing.Point(5, 54);
            this.lbl_default.Name = "lbl_default";
            this.lbl_default.Size = new System.Drawing.Size(81, 16);
            this.lbl_default.TabIndex = 5;
            this.lbl_default.Text = "Valor Default";
            // 
            // tbx_check
            // 
            this.tbx_check.Location = new System.Drawing.Point(92, 22);
            this.tbx_check.MaxLength = 50;
            this.tbx_check.Name = "tbx_check";
            this.tbx_check.Size = new System.Drawing.Size(591, 23);
            this.tbx_check.TabIndex = 13;
            // 
            // lbl_check
            // 
            this.lbl_check.AutoSize = true;
            this.lbl_check.Location = new System.Drawing.Point(5, 25);
            this.lbl_check.Name = "lbl_check";
            this.lbl_check.Size = new System.Drawing.Size(44, 16);
            this.lbl_check.TabIndex = 5;
            this.lbl_check.Text = "Check";
            // 
            // btn_info_datatype
            // 
            this.btn_info_datatype.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_info_datatype.BackgroundImage")));
            this.btn_info_datatype.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_datatype.Location = new System.Drawing.Point(689, 52);
            this.btn_info_datatype.Name = "btn_info_datatype";
            this.btn_info_datatype.Size = new System.Drawing.Size(20, 20);
            this.btn_info_datatype.TabIndex = 18;
            this.btn_info_datatype.UseVisualStyleBackColor = true;
            this.btn_info_datatype.Click += new System.EventHandler(this.btn_info_datatype_Click);
            // 
            // btn_info_check
            // 
            this.btn_info_check.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_info_check.BackgroundImage")));
            this.btn_info_check.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_check.Location = new System.Drawing.Point(689, 23);
            this.btn_info_check.Name = "btn_info_check";
            this.btn_info_check.Size = new System.Drawing.Size(20, 20);
            this.btn_info_check.TabIndex = 14;
            this.btn_info_check.UseVisualStyleBackColor = true;
            this.btn_info_check.Click += new System.EventHandler(this.btn_info_check_Click);
            // 
            // btn_infoPrecisao
            // 
            this.btn_infoPrecisao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_infoPrecisao.BackgroundImage")));
            this.btn_infoPrecisao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_infoPrecisao.Location = new System.Drawing.Point(383, 80);
            this.btn_infoPrecisao.Name = "btn_infoPrecisao";
            this.btn_infoPrecisao.Size = new System.Drawing.Size(20, 20);
            this.btn_infoPrecisao.TabIndex = 22;
            this.btn_infoPrecisao.UseVisualStyleBackColor = true;
            this.btn_infoPrecisao.Click += new System.EventHandler(this.btn_infoPrecisao_Click);
            // 
            // btn_infoTamanho
            // 
            this.btn_infoTamanho.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_infoTamanho.BackgroundImage")));
            this.btn_infoTamanho.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_infoTamanho.Location = new System.Drawing.Point(179, 81);
            this.btn_infoTamanho.Name = "btn_infoTamanho";
            this.btn_infoTamanho.Size = new System.Drawing.Size(20, 20);
            this.btn_infoTamanho.TabIndex = 20;
            this.btn_infoTamanho.UseVisualStyleBackColor = true;
            this.btn_infoTamanho.Click += new System.EventHandler(this.btn_infoTamanho_Click);
            // 
            // btn_info_valorDefault
            // 
            this.btn_info_valorDefault.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_info_valorDefault.BackgroundImage")));
            this.btn_info_valorDefault.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_valorDefault.Location = new System.Drawing.Point(383, 52);
            this.btn_info_valorDefault.Name = "btn_info_valorDefault";
            this.btn_info_valorDefault.Size = new System.Drawing.Size(20, 20);
            this.btn_info_valorDefault.TabIndex = 16;
            this.btn_info_valorDefault.UseVisualStyleBackColor = true;
            this.btn_info_valorDefault.Click += new System.EventHandler(this.btn_info_valorDefault_Click);
            // 
            // grb_geral
            // 
            this.grb_geral.Controls.Add(this.tbx_descrição);
            this.grb_geral.Controls.Add(this.lbl_descrição);
            this.grb_geral.Controls.Add(this.tbx_dominio);
            this.grb_geral.Controls.Add(this.lbl_dominio);
            this.grb_geral.Controls.Add(this.btn_info_descrição);
            this.grb_geral.Controls.Add(this.tbx_nomeCampo);
            this.grb_geral.Controls.Add(this.btn_info_dominio);
            this.grb_geral.Controls.Add(this.lbl_nome);
            this.grb_geral.Controls.Add(this.btn_copiar_descricao);
            this.grb_geral.Controls.Add(this.btn_copiar_dominio);
            this.grb_geral.Controls.Add(this.btn_copiar_campo);
            this.grb_geral.Controls.Add(this.btn_info_campo);
            this.grb_geral.Location = new System.Drawing.Point(6, 17);
            this.grb_geral.Name = "grb_geral";
            this.grb_geral.Size = new System.Drawing.Size(441, 108);
            this.grb_geral.TabIndex = 7;
            this.grb_geral.TabStop = false;
            this.grb_geral.Text = "Informações Gerais";
            // 
            // tbx_descrição
            // 
            this.tbx_descrição.Location = new System.Drawing.Point(71, 80);
            this.tbx_descrição.MaxLength = 900;
            this.tbx_descrição.Name = "tbx_descrição";
            this.tbx_descrição.Size = new System.Drawing.Size(307, 23);
            this.tbx_descrição.TabIndex = 5;
            // 
            // lbl_descrição
            // 
            this.lbl_descrição.AutoSize = true;
            this.lbl_descrição.Location = new System.Drawing.Point(6, 83);
            this.lbl_descrição.Name = "lbl_descrição";
            this.lbl_descrição.Size = new System.Drawing.Size(64, 16);
            this.lbl_descrição.TabIndex = 5;
            this.lbl_descrição.Text = "Descrição";
            // 
            // tbx_dominio
            // 
            this.tbx_dominio.Location = new System.Drawing.Point(71, 51);
            this.tbx_dominio.MaxLength = 50;
            this.tbx_dominio.Name = "tbx_dominio";
            this.tbx_dominio.Size = new System.Drawing.Size(307, 23);
            this.tbx_dominio.TabIndex = 3;
            // 
            // lbl_dominio
            // 
            this.lbl_dominio.AutoSize = true;
            this.lbl_dominio.Location = new System.Drawing.Point(6, 54);
            this.lbl_dominio.Name = "lbl_dominio";
            this.lbl_dominio.Size = new System.Drawing.Size(56, 16);
            this.lbl_dominio.TabIndex = 5;
            this.lbl_dominio.Text = "Dominio";
            // 
            // btn_info_descrição
            // 
            this.btn_info_descrição.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_info_descrição.BackgroundImage")));
            this.btn_info_descrição.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_descrição.Location = new System.Drawing.Point(384, 81);
            this.btn_info_descrição.Name = "btn_info_descrição";
            this.btn_info_descrição.Size = new System.Drawing.Size(20, 20);
            this.btn_info_descrição.TabIndex = 6;
            this.btn_info_descrição.UseVisualStyleBackColor = true;
            this.btn_info_descrição.Click += new System.EventHandler(this.btn_info_descrição_Click);
            // 
            // tbx_nomeCampo
            // 
            this.tbx_nomeCampo.Location = new System.Drawing.Point(71, 22);
            this.tbx_nomeCampo.MaxLength = 50;
            this.tbx_nomeCampo.Name = "tbx_nomeCampo";
            this.tbx_nomeCampo.Size = new System.Drawing.Size(307, 23);
            this.tbx_nomeCampo.TabIndex = 1;
            // 
            // btn_info_dominio
            // 
            this.btn_info_dominio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_info_dominio.BackgroundImage")));
            this.btn_info_dominio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_dominio.Location = new System.Drawing.Point(384, 52);
            this.btn_info_dominio.Name = "btn_info_dominio";
            this.btn_info_dominio.Size = new System.Drawing.Size(20, 20);
            this.btn_info_dominio.TabIndex = 4;
            this.btn_info_dominio.UseVisualStyleBackColor = true;
            this.btn_info_dominio.Click += new System.EventHandler(this.btn_info_dominio_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(6, 25);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(48, 16);
            this.lbl_nome.TabIndex = 5;
            this.lbl_nome.Text = "Campo";
            // 
            // btn_info_campo
            // 
            this.btn_info_campo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_info_campo.BackgroundImage")));
            this.btn_info_campo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_campo.Location = new System.Drawing.Point(384, 23);
            this.btn_info_campo.Name = "btn_info_campo";
            this.btn_info_campo.Size = new System.Drawing.Size(20, 20);
            this.btn_info_campo.TabIndex = 2;
            this.btn_info_campo.UseVisualStyleBackColor = true;
            this.btn_info_campo.Click += new System.EventHandler(this.btn_info_campo_Click);
            // 
            // grb_selecao
            // 
            this.grb_selecao.Controls.Add(this.ckb_unique);
            this.grb_selecao.Controls.Add(this.btn_info_unique);
            this.grb_selecao.Controls.Add(this.btn_infonotnull);
            this.grb_selecao.Controls.Add(this.btn_info_primarykey);
            this.grb_selecao.Controls.Add(this.ckb_notNull);
            this.grb_selecao.Controls.Add(this.ckb_primarykey);
            this.grb_selecao.Location = new System.Drawing.Point(453, 17);
            this.grb_selecao.Name = "grb_selecao";
            this.grb_selecao.Size = new System.Drawing.Size(269, 108);
            this.grb_selecao.TabIndex = 6;
            this.grb_selecao.TabStop = false;
            this.grb_selecao.Text = "Seleções";
            // 
            // ckb_unique
            // 
            this.ckb_unique.AutoSize = true;
            this.ckb_unique.Location = new System.Drawing.Point(20, 75);
            this.ckb_unique.Name = "ckb_unique";
            this.ckb_unique.Size = new System.Drawing.Size(66, 20);
            this.ckb_unique.TabIndex = 11;
            this.ckb_unique.Text = "Unique";
            this.ckb_unique.UseVisualStyleBackColor = true;
            // 
            // btn_info_unique
            // 
            this.btn_info_unique.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_info_unique.BackgroundImage")));
            this.btn_info_unique.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_unique.Location = new System.Drawing.Point(124, 75);
            this.btn_info_unique.Name = "btn_info_unique";
            this.btn_info_unique.Size = new System.Drawing.Size(20, 20);
            this.btn_info_unique.TabIndex = 12;
            this.btn_info_unique.UseVisualStyleBackColor = true;
            this.btn_info_unique.Click += new System.EventHandler(this.btn_info_unique_Click);
            // 
            // btn_infonotnull
            // 
            this.btn_infonotnull.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_infonotnull.BackgroundImage")));
            this.btn_infonotnull.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_infonotnull.Location = new System.Drawing.Point(124, 48);
            this.btn_infonotnull.Name = "btn_infonotnull";
            this.btn_infonotnull.Size = new System.Drawing.Size(20, 20);
            this.btn_infonotnull.TabIndex = 10;
            this.btn_infonotnull.UseVisualStyleBackColor = true;
            this.btn_infonotnull.Click += new System.EventHandler(this.btn_infonotnull_Click);
            // 
            // btn_info_primarykey
            // 
            this.btn_info_primarykey.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_info_primarykey.BackgroundImage")));
            this.btn_info_primarykey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_primarykey.Location = new System.Drawing.Point(124, 23);
            this.btn_info_primarykey.Name = "btn_info_primarykey";
            this.btn_info_primarykey.Size = new System.Drawing.Size(20, 20);
            this.btn_info_primarykey.TabIndex = 8;
            this.btn_info_primarykey.UseVisualStyleBackColor = true;
            this.btn_info_primarykey.Click += new System.EventHandler(this.btn_info_primarykey_Click);
            // 
            // ckb_notNull
            // 
            this.ckb_notNull.AutoSize = true;
            this.ckb_notNull.Location = new System.Drawing.Point(20, 49);
            this.ckb_notNull.Name = "ckb_notNull";
            this.ckb_notNull.Size = new System.Drawing.Size(71, 20);
            this.ckb_notNull.TabIndex = 9;
            this.ckb_notNull.Text = "NotNull";
            this.ckb_notNull.UseVisualStyleBackColor = true;
            // 
            // ckb_primarykey
            // 
            this.ckb_primarykey.AutoSize = true;
            this.ckb_primarykey.Location = new System.Drawing.Point(20, 23);
            this.ckb_primarykey.Name = "ckb_primarykey";
            this.ckb_primarykey.Size = new System.Drawing.Size(98, 20);
            this.ckb_primarykey.TabIndex = 7;
            this.ckb_primarykey.Text = "Primary Key";
            this.ckb_primarykey.UseVisualStyleBackColor = true;
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
            this.pan_botton.TabIndex = 9;
            // 
            // btn_excluir
            // 
            this.btn_excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_excluir.Location = new System.Drawing.Point(579, 3);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 29);
            this.btn_excluir.TabIndex = 24;
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
            this.btn_confirmar.TabIndex = 23;
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
            this.pan_tot.TabIndex = 8;
            // 
            // pan_top
            // 
            this.pan_top.Controls.Add(this.btn_fechar);
            this.pan_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_top.Location = new System.Drawing.Point(0, 0);
            this.pan_top.Name = "pan_top";
            this.pan_top.Size = new System.Drawing.Size(740, 20);
            this.pan_top.TabIndex = 22;
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
            // btn_copiar_campo
            // 
            this.btn_copiar_campo.BackgroundImage = global::Pj.Properties.Resources.check_circle_outline_100px20x20;
            this.btn_copiar_campo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_copiar_campo.Location = new System.Drawing.Point(410, 23);
            this.btn_copiar_campo.Name = "btn_copiar_campo";
            this.btn_copiar_campo.Size = new System.Drawing.Size(20, 20);
            this.btn_copiar_campo.TabIndex = 2;
            this.btn_copiar_campo.UseVisualStyleBackColor = true;
            this.btn_copiar_campo.Click += new System.EventHandler(this.btn_copiar_campo_Click);
            // 
            // btn_copiar_dominio
            // 
            this.btn_copiar_dominio.BackgroundImage = global::Pj.Properties.Resources.check_circle_outline_100px20x20;
            this.btn_copiar_dominio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_copiar_dominio.Location = new System.Drawing.Point(410, 52);
            this.btn_copiar_dominio.Name = "btn_copiar_dominio";
            this.btn_copiar_dominio.Size = new System.Drawing.Size(20, 20);
            this.btn_copiar_dominio.TabIndex = 2;
            this.btn_copiar_dominio.UseVisualStyleBackColor = true;
            this.btn_copiar_dominio.Click += new System.EventHandler(this.btn_copiar_dominio_Click);
            // 
            // btn_copiar_descricao
            // 
            this.btn_copiar_descricao.BackgroundImage = global::Pj.Properties.Resources.check_circle_outline_100px20x20;
            this.btn_copiar_descricao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_copiar_descricao.Location = new System.Drawing.Point(410, 81);
            this.btn_copiar_descricao.Name = "btn_copiar_descricao";
            this.btn_copiar_descricao.Size = new System.Drawing.Size(20, 20);
            this.btn_copiar_descricao.TabIndex = 2;
            this.btn_copiar_descricao.UseVisualStyleBackColor = true;
            this.btn_copiar_descricao.Click += new System.EventHandler(this.btn_copiar_descricao_Click);
            // 
            // UC_CadastroCampos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.pan_botton);
            this.Controls.Add(this.pan_tot);
            this.Controls.Add(this.pan_top);
            this.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.Name = "UC_CadastroCampos";
            this.Size = new System.Drawing.Size(740, 562);
            this.gpb_cadastroGeral.ResumeLayout(false);
            this.grb_regras.ResumeLayout(false);
            this.grb_regras.PerformLayout();
            this.grb_geral.ResumeLayout(false);
            this.grb_geral.PerformLayout();
            this.grb_selecao.ResumeLayout(false);
            this.grb_selecao.PerformLayout();
            this.pan_formularioGeral.ResumeLayout(false);
            this.pan_botton.ResumeLayout(false);
            this.pan_tot.ResumeLayout(false);
            this.pan_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_cadastroGeral;
        private System.Windows.Forms.Button btn_info_campo;
        private System.Windows.Forms.TextBox tbx_nomeCampo;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Panel pan_formularioGeral;
        private System.Windows.Forms.Panel pan_botton;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Panel pan_tot;
        private System.Windows.Forms.GroupBox grb_selecao;
        private System.Windows.Forms.CheckBox ckb_primarykey;
        private System.Windows.Forms.CheckBox ckb_unique;
        private System.Windows.Forms.Button btn_info_unique;
        private System.Windows.Forms.Button btn_infonotnull;
        private System.Windows.Forms.Button btn_info_primarykey;
        private System.Windows.Forms.CheckBox ckb_notNull;
        private System.Windows.Forms.GroupBox grb_geral;
        private System.Windows.Forms.TextBox tbx_dominio;
        private System.Windows.Forms.Label lbl_dominio;
        private System.Windows.Forms.Button btn_info_dominio;
        private System.Windows.Forms.TextBox tbx_descrição;
        private System.Windows.Forms.Label lbl_descrição;
        private System.Windows.Forms.Button btn_info_descrição;
        private System.Windows.Forms.GroupBox grb_regras;
        private System.Windows.Forms.TextBox tbx_check;
        private System.Windows.Forms.Label lbl_check;
        private System.Windows.Forms.Button btn_info_check;
        private System.Windows.Forms.TextBox tbx_default;
        private System.Windows.Forms.Label lbl_default;
        private System.Windows.Forms.Button btn_info_valorDefault;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.ComboBox cmb_datatype;
        private System.Windows.Forms.Button btn_info_datatype;
        private System.Windows.Forms.TextBox tbx_tamanho;
        private System.Windows.Forms.Label lbl_tamanho;
        private System.Windows.Forms.TextBox tbx_precisao;
        private System.Windows.Forms.Label lbl_precisao;
        private System.Windows.Forms.Button btn_infoPrecisao;
        private System.Windows.Forms.Button btn_infoTamanho;
        private System.Windows.Forms.Panel pan_top;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_copiar_campo;
        private System.Windows.Forms.Button btn_copiar_descricao;
        private System.Windows.Forms.Button btn_copiar_dominio;
    }
}
