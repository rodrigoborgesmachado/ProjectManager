namespace Visao
{
    partial class FO_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FO_Principal));
            this.pan_left = new System.Windows.Forms.Panel();
            this.pan_projetos = new System.Windows.Forms.Panel();
            this.trv_projetos = new System.Windows.Forms.TreeView();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.pan_opções = new System.Windows.Forms.Panel();
            this.btn_novo_projeto = new System.Windows.Forms.Button();
            this.pan_informacoesQuantidades = new System.Windows.Forms.Panel();
            this.lbl_foreignkey = new System.Windows.Forms.Label();
            this.lbl_campos = new System.Windows.Forms.Label();
            this.lbl_quantidadeForeign = new System.Windows.Forms.Label();
            this.lbl_tabelas = new System.Windows.Forms.Label();
            this.lbl_quantidadeCampos = new System.Windows.Forms.Label();
            this.lbl_quantidadeTabelas = new System.Windows.Forms.Label();
            this.lbl_quantidadeProjeto = new System.Windows.Forms.Label();
            this.lbl_projetos = new System.Windows.Forms.Label();
            this.pan_titulo = new System.Windows.Forms.Panel();
            this.btn_expandTree = new System.Windows.Forms.Button();
            this.btn_inplandsTree = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.lbl_título = new System.Windows.Forms.Label();
            this.mst_opcoes = new System.Windows.Forms.MenuStrip();
            this.tsm_opcoes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsp_tipLog = new System.Windows.Forms.ToolStripMenuItem();
            this.tsp_log_simples = new System.Windows.Forms.ToolStripMenuItem();
            this.tsp_log_detalhado = new System.Windows.Forms.ToolStripMenuItem();
            this.tsp_carregarTreeViewAutomaticamente = new System.Windows.Forms.ToolStripMenuItem();
            this.tspSim = new System.Windows.Forms.ToolStripMenuItem();
            this.tspNao = new System.Windows.Forms.ToolStripMenuItem();
            this.apresentaMensagemConfirmaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsp_apresenta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsp_naoApresenta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsp_buscarBackupFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsp_configurações = new System.Windows.Forms.ToolStripMenuItem();
            this.tsp_arquivosUtil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsp_arquivosModel = new System.Windows.Forms.ToolStripMenuItem();
            this.utilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarHashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pan_principal = new System.Windows.Forms.Panel();
            this.tbc_table_control = new System.Windows.Forms.TabControl();
            this.pan_descricoes = new System.Windows.Forms.Panel();
            this.lbl_valorVersao = new System.Windows.Forms.Label();
            this.lbl_empresa = new System.Windows.Forms.Label();
            this.lbl_versao = new System.Windows.Forms.Label();
            this.pan_left.SuspendLayout();
            this.pan_projetos.SuspendLayout();
            this.pan_opções.SuspendLayout();
            this.pan_informacoesQuantidades.SuspendLayout();
            this.pan_titulo.SuspendLayout();
            this.mst_opcoes.SuspendLayout();
            this.pan_principal.SuspendLayout();
            this.pan_descricoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_left
            // 
            this.pan_left.Controls.Add(this.pan_projetos);
            this.pan_left.Controls.Add(this.pan_opções);
            this.pan_left.Controls.Add(this.pan_titulo);
            this.pan_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pan_left.Location = new System.Drawing.Point(0, 0);
            this.pan_left.Name = "pan_left";
            this.pan_left.Size = new System.Drawing.Size(246, 606);
            this.pan_left.TabIndex = 0;
            // 
            // pan_projetos
            // 
            this.pan_projetos.Controls.Add(this.trv_projetos);
            this.pan_projetos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_projetos.Location = new System.Drawing.Point(0, 59);
            this.pan_projetos.Name = "pan_projetos";
            this.pan_projetos.Size = new System.Drawing.Size(246, 450);
            this.pan_projetos.TabIndex = 1;
            // 
            // trv_projetos
            // 
            this.trv_projetos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.trv_projetos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trv_projetos.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.trv_projetos.ImageIndex = 0;
            this.trv_projetos.ImageList = this.imgList;
            this.trv_projetos.Location = new System.Drawing.Point(0, 0);
            this.trv_projetos.Name = "trv_projetos";
            this.trv_projetos.SelectedImageIndex = 0;
            this.trv_projetos.Size = new System.Drawing.Size(246, 450);
            this.trv_projetos.TabIndex = 0;
            this.trv_projetos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trv_projetos_AfterSelect);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "project-management20x20.png");
            this.imgList.Images.SetKeyName(1, "list20x20.png");
            this.imgList.Images.SetKeyName(2, "target20x20.png");
            this.imgList.Images.SetKeyName(3, "graph20x20.png");
            this.imgList.Images.SetKeyName(4, "internet20x20.png");
            this.imgList.Images.SetKeyName(5, "module20x20.png");
            this.imgList.Images.SetKeyName(6, "approve20x20.png");
            this.imgList.Images.SetKeyName(7, "browser20x20.png");
            // 
            // pan_opções
            // 
            this.pan_opções.Controls.Add(this.btn_novo_projeto);
            this.pan_opções.Controls.Add(this.pan_informacoesQuantidades);
            this.pan_opções.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_opções.Location = new System.Drawing.Point(0, 509);
            this.pan_opções.Name = "pan_opções";
            this.pan_opções.Size = new System.Drawing.Size(246, 97);
            this.pan_opções.TabIndex = 0;
            // 
            // btn_novo_projeto
            // 
            this.btn_novo_projeto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_novo_projeto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_novo_projeto.Location = new System.Drawing.Point(0, 74);
            this.btn_novo_projeto.Name = "btn_novo_projeto";
            this.btn_novo_projeto.Size = new System.Drawing.Size(246, 23);
            this.btn_novo_projeto.TabIndex = 0;
            this.btn_novo_projeto.Text = "Novo Projeto";
            this.btn_novo_projeto.UseVisualStyleBackColor = true;
            this.btn_novo_projeto.Click += new System.EventHandler(this.btn_novo_projeto_Click);
            // 
            // pan_informacoesQuantidades
            // 
            this.pan_informacoesQuantidades.Controls.Add(this.lbl_foreignkey);
            this.pan_informacoesQuantidades.Controls.Add(this.lbl_campos);
            this.pan_informacoesQuantidades.Controls.Add(this.lbl_quantidadeForeign);
            this.pan_informacoesQuantidades.Controls.Add(this.lbl_tabelas);
            this.pan_informacoesQuantidades.Controls.Add(this.lbl_quantidadeCampos);
            this.pan_informacoesQuantidades.Controls.Add(this.lbl_quantidadeTabelas);
            this.pan_informacoesQuantidades.Controls.Add(this.lbl_quantidadeProjeto);
            this.pan_informacoesQuantidades.Controls.Add(this.lbl_projetos);
            this.pan_informacoesQuantidades.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_informacoesQuantidades.Location = new System.Drawing.Point(0, 0);
            this.pan_informacoesQuantidades.Name = "pan_informacoesQuantidades";
            this.pan_informacoesQuantidades.Size = new System.Drawing.Size(246, 72);
            this.pan_informacoesQuantidades.TabIndex = 1;
            // 
            // lbl_foreignkey
            // 
            this.lbl_foreignkey.AutoSize = true;
            this.lbl_foreignkey.Location = new System.Drawing.Point(12, 51);
            this.lbl_foreignkey.Name = "lbl_foreignkey";
            this.lbl_foreignkey.Size = new System.Drawing.Size(102, 19);
            this.lbl_foreignkey.TabIndex = 1;
            this.lbl_foreignkey.Text = "Foreign keys:";
            // 
            // lbl_campos
            // 
            this.lbl_campos.AutoSize = true;
            this.lbl_campos.Location = new System.Drawing.Point(12, 35);
            this.lbl_campos.Name = "lbl_campos";
            this.lbl_campos.Size = new System.Drawing.Size(169, 19);
            this.lbl_campos.TabIndex = 1;
            this.lbl_campos.Text = "Quantidade de Campos:";
            // 
            // lbl_quantidadeForeign
            // 
            this.lbl_quantidadeForeign.AutoSize = true;
            this.lbl_quantidadeForeign.Location = new System.Drawing.Point(155, 51);
            this.lbl_quantidadeForeign.Name = "lbl_quantidadeForeign";
            this.lbl_quantidadeForeign.Size = new System.Drawing.Size(81, 19);
            this.lbl_quantidadeForeign.TabIndex = 1;
            this.lbl_quantidadeForeign.Text = "qt_foreign";
            // 
            // lbl_tabelas
            // 
            this.lbl_tabelas.AutoSize = true;
            this.lbl_tabelas.Location = new System.Drawing.Point(12, 19);
            this.lbl_tabelas.Name = "lbl_tabelas";
            this.lbl_tabelas.Size = new System.Drawing.Size(164, 19);
            this.lbl_tabelas.TabIndex = 1;
            this.lbl_tabelas.Text = "Quantidade de Tabelas:";
            // 
            // lbl_quantidadeCampos
            // 
            this.lbl_quantidadeCampos.AutoSize = true;
            this.lbl_quantidadeCampos.Location = new System.Drawing.Point(155, 35);
            this.lbl_quantidadeCampos.Name = "lbl_quantidadeCampos";
            this.lbl_quantidadeCampos.Size = new System.Drawing.Size(67, 19);
            this.lbl_quantidadeCampos.TabIndex = 1;
            this.lbl_quantidadeCampos.Text = "qt_camp";
            // 
            // lbl_quantidadeTabelas
            // 
            this.lbl_quantidadeTabelas.AutoSize = true;
            this.lbl_quantidadeTabelas.Location = new System.Drawing.Point(155, 19);
            this.lbl_quantidadeTabelas.Name = "lbl_quantidadeTabelas";
            this.lbl_quantidadeTabelas.Size = new System.Drawing.Size(71, 19);
            this.lbl_quantidadeTabelas.TabIndex = 1;
            this.lbl_quantidadeTabelas.Text = "qt_tabela";
            // 
            // lbl_quantidadeProjeto
            // 
            this.lbl_quantidadeProjeto.AutoSize = true;
            this.lbl_quantidadeProjeto.Location = new System.Drawing.Point(155, 3);
            this.lbl_quantidadeProjeto.Name = "lbl_quantidadeProjeto";
            this.lbl_quantidadeProjeto.Size = new System.Drawing.Size(59, 19);
            this.lbl_quantidadeProjeto.TabIndex = 1;
            this.lbl_quantidadeProjeto.Text = "qt_proj";
            // 
            // lbl_projetos
            // 
            this.lbl_projetos.AutoSize = true;
            this.lbl_projetos.Location = new System.Drawing.Point(12, 3);
            this.lbl_projetos.Name = "lbl_projetos";
            this.lbl_projetos.Size = new System.Drawing.Size(173, 19);
            this.lbl_projetos.TabIndex = 1;
            this.lbl_projetos.Text = "Quantidade de Projetos:";
            // 
            // pan_titulo
            // 
            this.pan_titulo.Controls.Add(this.btn_expandTree);
            this.pan_titulo.Controls.Add(this.btn_inplandsTree);
            this.pan_titulo.Controls.Add(this.btn_atualizar);
            this.pan_titulo.Controls.Add(this.lbl_título);
            this.pan_titulo.Controls.Add(this.mst_opcoes);
            this.pan_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_titulo.Location = new System.Drawing.Point(0, 0);
            this.pan_titulo.Name = "pan_titulo";
            this.pan_titulo.Size = new System.Drawing.Size(246, 59);
            this.pan_titulo.TabIndex = 2;
            // 
            // btn_expandTree
            // 
            this.btn_expandTree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_expandTree.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_expandTree.BackgroundImage")));
            this.btn_expandTree.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_expandTree.Location = new System.Drawing.Point(169, 38);
            this.btn_expandTree.Name = "btn_expandTree";
            this.btn_expandTree.Size = new System.Drawing.Size(20, 20);
            this.btn_expandTree.TabIndex = 3;
            this.btn_expandTree.UseVisualStyleBackColor = true;
            this.btn_expandTree.Click += new System.EventHandler(this.btn_expandTree_Click);
            // 
            // btn_inplandsTree
            // 
            this.btn_inplandsTree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_inplandsTree.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_inplandsTree.BackgroundImage")));
            this.btn_inplandsTree.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_inplandsTree.Location = new System.Drawing.Point(195, 38);
            this.btn_inplandsTree.Name = "btn_inplandsTree";
            this.btn_inplandsTree.Size = new System.Drawing.Size(20, 20);
            this.btn_inplandsTree.TabIndex = 3;
            this.btn_inplandsTree.UseVisualStyleBackColor = true;
            this.btn_inplandsTree.Click += new System.EventHandler(this.btn_inplandsTree_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_atualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_atualizar.BackgroundImage")));
            this.btn_atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_atualizar.Location = new System.Drawing.Point(221, 38);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(20, 20);
            this.btn_atualizar.TabIndex = 3;
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // lbl_título
            // 
            this.lbl_título.AutoSize = true;
            this.lbl_título.Location = new System.Drawing.Point(12, 41);
            this.lbl_título.Name = "lbl_título";
            this.lbl_título.Size = new System.Drawing.Size(68, 19);
            this.lbl_título.TabIndex = 0;
            this.lbl_título.Text = "Projetos";
            // 
            // mst_opcoes
            // 
            this.mst_opcoes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mst_opcoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_opcoes,
            this.utilToolStripMenuItem});
            this.mst_opcoes.Location = new System.Drawing.Point(0, 0);
            this.mst_opcoes.Name = "mst_opcoes";
            this.mst_opcoes.Size = new System.Drawing.Size(246, 30);
            this.mst_opcoes.TabIndex = 1;
            this.mst_opcoes.Text = "menuStrip1";
            // 
            // tsm_opcoes
            // 
            this.tsm_opcoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsp_tipLog,
            this.tsp_carregarTreeViewAutomaticamente,
            this.apresentaMensagemConfirmaçãoToolStripMenuItem,
            this.tsp_buscarBackupFile,
            this.tsp_configurações,
            this.tsp_arquivosUtil,
            this.tsp_arquivosModel});
            this.tsm_opcoes.Name = "tsm_opcoes";
            this.tsm_opcoes.Size = new System.Drawing.Size(73, 26);
            this.tsm_opcoes.Text = "Opções";
            // 
            // tsp_tipLog
            // 
            this.tsp_tipLog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsp_log_simples,
            this.tsp_log_detalhado});
            this.tsp_tipLog.Name = "tsp_tipLog";
            this.tsp_tipLog.Size = new System.Drawing.Size(323, 26);
            this.tsp_tipLog.Text = "Log";
            // 
            // tsp_log_simples
            // 
            this.tsp_log_simples.Name = "tsp_log_simples";
            this.tsp_log_simples.Size = new System.Drawing.Size(162, 26);
            this.tsp_log_simples.Text = "Simples";
            // 
            // tsp_log_detalhado
            // 
            this.tsp_log_detalhado.Name = "tsp_log_detalhado";
            this.tsp_log_detalhado.Size = new System.Drawing.Size(162, 26);
            this.tsp_log_detalhado.Text = "Detalhado";
            // 
            // tsp_carregarTreeViewAutomaticamente
            // 
            this.tsp_carregarTreeViewAutomaticamente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspSim,
            this.tspNao});
            this.tsp_carregarTreeViewAutomaticamente.Name = "tsp_carregarTreeViewAutomaticamente";
            this.tsp_carregarTreeViewAutomaticamente.Size = new System.Drawing.Size(323, 26);
            this.tsp_carregarTreeViewAutomaticamente.Text = "Tree view automatico";
            // 
            // tspSim
            // 
            this.tspSim.Name = "tspSim";
            this.tspSim.Size = new System.Drawing.Size(179, 26);
            this.tspSim.Text = "Carregar";
            // 
            // tspNao
            // 
            this.tspNao.Name = "tspNao";
            this.tspNao.Size = new System.Drawing.Size(179, 26);
            this.tspNao.Text = "Não carregar";
            // 
            // apresentaMensagemConfirmaçãoToolStripMenuItem
            // 
            this.apresentaMensagemConfirmaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsp_apresenta,
            this.tsp_naoApresenta});
            this.apresentaMensagemConfirmaçãoToolStripMenuItem.Name = "apresentaMensagemConfirmaçãoToolStripMenuItem";
            this.apresentaMensagemConfirmaçãoToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.apresentaMensagemConfirmaçãoToolStripMenuItem.Text = "Apresenta mensagem confirmação";
            // 
            // tsp_apresenta
            // 
            this.tsp_apresenta.Name = "tsp_apresenta";
            this.tsp_apresenta.Size = new System.Drawing.Size(189, 26);
            this.tsp_apresenta.Text = "Apresenta";
            this.tsp_apresenta.Click += new System.EventHandler(this.apresentaToolStripMenuItem_Click);
            // 
            // tsp_naoApresenta
            // 
            this.tsp_naoApresenta.Name = "tsp_naoApresenta";
            this.tsp_naoApresenta.Size = new System.Drawing.Size(189, 26);
            this.tsp_naoApresenta.Text = "Não apresenta";
            this.tsp_naoApresenta.Click += new System.EventHandler(this.nãoApresentaToolStripMenuItem_Click);
            // 
            // tsp_buscarBackupFile
            // 
            this.tsp_buscarBackupFile.Name = "tsp_buscarBackupFile";
            this.tsp_buscarBackupFile.Size = new System.Drawing.Size(323, 26);
            this.tsp_buscarBackupFile.Text = "Buscar Backup";
            this.tsp_buscarBackupFile.Click += new System.EventHandler(this.tsp_buscarBackupFile_Click);
            // 
            // tsp_configurações
            // 
            this.tsp_configurações.Name = "tsp_configurações";
            this.tsp_configurações.Size = new System.Drawing.Size(323, 26);
            this.tsp_configurações.Text = "Configurações";
            this.tsp_configurações.Click += new System.EventHandler(this.tsp_configurações_Click);
            // 
            // tsp_arquivosUtil
            // 
            this.tsp_arquivosUtil.Name = "tsp_arquivosUtil";
            this.tsp_arquivosUtil.Size = new System.Drawing.Size(323, 26);
            this.tsp_arquivosUtil.Text = "Arquivos UTIL";
            // 
            // tsp_arquivosModel
            // 
            this.tsp_arquivosModel.Name = "tsp_arquivosModel";
            this.tsp_arquivosModel.Size = new System.Drawing.Size(323, 26);
            this.tsp_arquivosModel.Text = "Arquivos Model";
            // 
            // utilToolStripMenuItem
            // 
            this.utilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarHashToolStripMenuItem});
            this.utilToolStripMenuItem.Name = "utilToolStripMenuItem";
            this.utilToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.utilToolStripMenuItem.Text = "Util";
            // 
            // gerarHashToolStripMenuItem
            // 
            this.gerarHashToolStripMenuItem.Name = "gerarHashToolStripMenuItem";
            this.gerarHashToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.gerarHashToolStripMenuItem.Text = "Gerar Hash";
            this.gerarHashToolStripMenuItem.Click += new System.EventHandler(this.gerarHashToolStripMenuItem_Click);
            // 
            // pan_principal
            // 
            this.pan_principal.Controls.Add(this.tbc_table_control);
            this.pan_principal.Controls.Add(this.pan_descricoes);
            this.pan_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_principal.Location = new System.Drawing.Point(246, 0);
            this.pan_principal.Name = "pan_principal";
            this.pan_principal.Size = new System.Drawing.Size(864, 606);
            this.pan_principal.TabIndex = 1;
            // 
            // tbc_table_control
            // 
            this.tbc_table_control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbc_table_control.Location = new System.Drawing.Point(0, 0);
            this.tbc_table_control.Name = "tbc_table_control";
            this.tbc_table_control.SelectedIndex = 0;
            this.tbc_table_control.Size = new System.Drawing.Size(864, 583);
            this.tbc_table_control.TabIndex = 0;
            // 
            // pan_descricoes
            // 
            this.pan_descricoes.Controls.Add(this.lbl_valorVersao);
            this.pan_descricoes.Controls.Add(this.lbl_empresa);
            this.pan_descricoes.Controls.Add(this.lbl_versao);
            this.pan_descricoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_descricoes.Location = new System.Drawing.Point(0, 583);
            this.pan_descricoes.Name = "pan_descricoes";
            this.pan_descricoes.Size = new System.Drawing.Size(864, 23);
            this.pan_descricoes.TabIndex = 2;
            // 
            // lbl_valorVersao
            // 
            this.lbl_valorVersao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_valorVersao.AutoSize = true;
            this.lbl_valorVersao.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lbl_valorVersao.Location = new System.Drawing.Point(805, 4);
            this.lbl_valorVersao.Name = "lbl_valorVersao";
            this.lbl_valorVersao.Size = new System.Drawing.Size(47, 17);
            this.lbl_valorVersao.TabIndex = 1;
            this.lbl_valorVersao.Text = "versao";
            // 
            // lbl_empresa
            // 
            this.lbl_empresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_empresa.AutoSize = true;
            this.lbl_empresa.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lbl_empresa.Location = new System.Drawing.Point(687, 4);
            this.lbl_empresa.Name = "lbl_empresa";
            this.lbl_empresa.Size = new System.Drawing.Size(103, 17);
            this.lbl_empresa.TabIndex = 1;
            this.lbl_empresa.Text = "ProjectManager";
            // 
            // lbl_versao
            // 
            this.lbl_versao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_versao.AutoSize = true;
            this.lbl_versao.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lbl_versao.Location = new System.Drawing.Point(757, 4);
            this.lbl_versao.Name = "lbl_versao";
            this.lbl_versao.Size = new System.Drawing.Size(52, 17);
            this.lbl_versao.TabIndex = 1;
            this.lbl_versao.Text = "Versão:";
            // 
            // FO_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1110, 606);
            this.Controls.Add(this.pan_principal);
            this.Controls.Add(this.pan_left);
            this.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1126, 644);
            this.Name = "FO_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DER Creator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pan_left.ResumeLayout(false);
            this.pan_projetos.ResumeLayout(false);
            this.pan_opções.ResumeLayout(false);
            this.pan_informacoesQuantidades.ResumeLayout(false);
            this.pan_informacoesQuantidades.PerformLayout();
            this.pan_titulo.ResumeLayout(false);
            this.pan_titulo.PerformLayout();
            this.mst_opcoes.ResumeLayout(false);
            this.mst_opcoes.PerformLayout();
            this.pan_principal.ResumeLayout(false);
            this.pan_descricoes.ResumeLayout(false);
            this.pan_descricoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_left;
        private System.Windows.Forms.Panel pan_opções;
        private System.Windows.Forms.Panel pan_principal;
        private System.Windows.Forms.TabControl tbc_table_control;
        private System.Windows.Forms.Panel pan_projetos;
        private System.Windows.Forms.TreeView trv_projetos;
        private System.Windows.Forms.Panel pan_titulo;
        private System.Windows.Forms.Button btn_novo_projeto;
        private System.Windows.Forms.Label lbl_título;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.MenuStrip mst_opcoes;
        private System.Windows.Forms.ToolStripMenuItem tsm_opcoes;
        private System.Windows.Forms.ToolStripMenuItem tsp_tipLog;
        private System.Windows.Forms.ToolStripMenuItem tsp_log_simples;
        private System.Windows.Forms.ToolStripMenuItem tsp_log_detalhado;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.ToolStripMenuItem tsp_buscarBackupFile;
        private System.Windows.Forms.Button btn_inplandsTree;
        private System.Windows.Forms.Button btn_expandTree;
        private System.Windows.Forms.ToolStripMenuItem tsp_carregarTreeViewAutomaticamente;
        private System.Windows.Forms.ToolStripMenuItem tspSim;
        private System.Windows.Forms.ToolStripMenuItem tspNao;
        private System.Windows.Forms.ToolStripMenuItem tsp_configurações;
        private System.Windows.Forms.ToolStripMenuItem tsp_arquivosUtil;
        private System.Windows.Forms.ToolStripMenuItem tsp_arquivosModel;
        private System.Windows.Forms.Panel pan_informacoesQuantidades;
        private System.Windows.Forms.Label lbl_campos;
        private System.Windows.Forms.Label lbl_tabelas;
        private System.Windows.Forms.Label lbl_projetos;
        private System.Windows.Forms.Label lbl_quantidadeProjeto;
        private System.Windows.Forms.Label lbl_quantidadeCampos;
        private System.Windows.Forms.Label lbl_quantidadeTabelas;
        private System.Windows.Forms.Label lbl_foreignkey;
        private System.Windows.Forms.Label lbl_quantidadeForeign;
        private System.Windows.Forms.Panel pan_descricoes;
        private System.Windows.Forms.Label lbl_valorVersao;
        private System.Windows.Forms.Label lbl_versao;
        private System.Windows.Forms.Label lbl_empresa;
        private System.Windows.Forms.ToolStripMenuItem utilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarHashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apresentaMensagemConfirmaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsp_apresenta;
        private System.Windows.Forms.ToolStripMenuItem tsp_naoApresenta;
    }
}

