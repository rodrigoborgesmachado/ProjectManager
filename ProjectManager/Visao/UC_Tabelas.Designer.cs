
namespace Visao
{
    partial class UC_Tabelas
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_fechar = new System.Windows.Forms.Button();
            this.pan_tot = new System.Windows.Forms.Panel();
            this.pan_formularioGeral = new System.Windows.Forms.Panel();
            this.grb_tabela = new System.Windows.Forms.GroupBox();
            this.pan_colunas = new System.Windows.Forms.Panel();
            this.btn_recarregar_campos = new System.Windows.Forms.Button();
            this.btn_visualizar_campo = new System.Windows.Forms.Button();
            this.btn_incluir_campo = new System.Windows.Forms.Button();
            this.btn_remover_campo = new System.Windows.Forms.Button();
            this.btn_editar_campo = new System.Windows.Forms.Button();
            this.dgv_colunas = new System.Windows.Forms.DataGridView();
            this.pan_tabelas = new System.Windows.Forms.Panel();
            this.btn_recarregar_tabelas = new System.Windows.Forms.Button();
            this.btn_adicionar_tabela = new System.Windows.Forms.Button();
            this.dgv_tabelas = new System.Windows.Forms.DataGridView();
            this.btn_visualizar_tabela = new System.Windows.Forms.Button();
            this.btn_remover_tabela = new System.Windows.Forms.Button();
            this.btn_editar_tabela = new System.Windows.Forms.Button();
            this.btn_gerarScripts = new System.Windows.Forms.Button();
            this.btn_gerar_classes = new System.Windows.Forms.Button();
            this.pan_botton = new System.Windows.Forms.Panel();
            this.pan_top = new System.Windows.Forms.Panel();
            this.btn_gerar_classe_api = new System.Windows.Forms.Button();
            this.pan_tot.SuspendLayout();
            this.pan_formularioGeral.SuspendLayout();
            this.grb_tabela.SuspendLayout();
            this.pan_colunas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_colunas)).BeginInit();
            this.pan_tabelas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabelas)).BeginInit();
            this.pan_botton.SuspendLayout();
            this.pan_top.SuspendLayout();
            this.SuspendLayout();
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
            this.pan_formularioGeral.Controls.Add(this.grb_tabela);
            this.pan_formularioGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_formularioGeral.Location = new System.Drawing.Point(0, 0);
            this.pan_formularioGeral.Name = "pan_formularioGeral";
            this.pan_formularioGeral.Size = new System.Drawing.Size(740, 507);
            this.pan_formularioGeral.TabIndex = 0;
            // 
            // grb_tabela
            // 
            this.grb_tabela.Controls.Add(this.pan_colunas);
            this.grb_tabela.Controls.Add(this.pan_tabelas);
            this.grb_tabela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_tabela.Location = new System.Drawing.Point(0, 0);
            this.grb_tabela.Name = "grb_tabela";
            this.grb_tabela.Size = new System.Drawing.Size(740, 507);
            this.grb_tabela.TabIndex = 0;
            this.grb_tabela.TabStop = false;
            this.grb_tabela.Text = "Tabelas Projeto";
            // 
            // pan_colunas
            // 
            this.pan_colunas.Controls.Add(this.btn_recarregar_campos);
            this.pan_colunas.Controls.Add(this.btn_visualizar_campo);
            this.pan_colunas.Controls.Add(this.btn_incluir_campo);
            this.pan_colunas.Controls.Add(this.btn_remover_campo);
            this.pan_colunas.Controls.Add(this.btn_editar_campo);
            this.pan_colunas.Controls.Add(this.dgv_colunas);
            this.pan_colunas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_colunas.Location = new System.Drawing.Point(382, 23);
            this.pan_colunas.Name = "pan_colunas";
            this.pan_colunas.Size = new System.Drawing.Size(355, 481);
            this.pan_colunas.TabIndex = 16;
            // 
            // btn_recarregar_campos
            // 
            this.btn_recarregar_campos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_recarregar_campos.BackgroundImage = global::Pj.Properties.Resources.loop_100px20x20;
            this.btn_recarregar_campos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_recarregar_campos.Location = new System.Drawing.Point(332, 109);
            this.btn_recarregar_campos.Name = "btn_recarregar_campos";
            this.btn_recarregar_campos.Size = new System.Drawing.Size(20, 20);
            this.btn_recarregar_campos.TabIndex = 21;
            this.btn_recarregar_campos.UseVisualStyleBackColor = true;
            this.btn_recarregar_campos.Click += new System.EventHandler(this.btn_recarregar_campos_Click);
            // 
            // btn_visualizar_campo
            // 
            this.btn_visualizar_campo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_visualizar_campo.BackgroundImage = global::Pj.Properties.Resources.eye_100px20x20;
            this.btn_visualizar_campo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_visualizar_campo.Location = new System.Drawing.Point(332, 83);
            this.btn_visualizar_campo.Name = "btn_visualizar_campo";
            this.btn_visualizar_campo.Size = new System.Drawing.Size(20, 20);
            this.btn_visualizar_campo.TabIndex = 20;
            this.btn_visualizar_campo.UseVisualStyleBackColor = true;
            this.btn_visualizar_campo.Click += new System.EventHandler(this.btn_visualizar_campo_Click);
            // 
            // btn_incluir_campo
            // 
            this.btn_incluir_campo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_incluir_campo.BackgroundImage = global::Pj.Properties.Resources.plus20x20;
            this.btn_incluir_campo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_incluir_campo.Location = new System.Drawing.Point(332, 5);
            this.btn_incluir_campo.Name = "btn_incluir_campo";
            this.btn_incluir_campo.Size = new System.Drawing.Size(20, 20);
            this.btn_incluir_campo.TabIndex = 19;
            this.btn_incluir_campo.UseVisualStyleBackColor = true;
            this.btn_incluir_campo.Click += new System.EventHandler(this.btn_incluir_campo_Click);
            // 
            // btn_remover_campo
            // 
            this.btn_remover_campo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_remover_campo.BackgroundImage = global::Pj.Properties.Resources.quit20x20;
            this.btn_remover_campo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_remover_campo.Location = new System.Drawing.Point(332, 31);
            this.btn_remover_campo.Name = "btn_remover_campo";
            this.btn_remover_campo.Size = new System.Drawing.Size(20, 20);
            this.btn_remover_campo.TabIndex = 17;
            this.btn_remover_campo.UseVisualStyleBackColor = true;
            this.btn_remover_campo.Click += new System.EventHandler(this.btn_remover_campo_Click);
            // 
            // btn_editar_campo
            // 
            this.btn_editar_campo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_editar_campo.BackgroundImage = global::Pj.Properties.Resources.pencil_100px20x20;
            this.btn_editar_campo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_editar_campo.Location = new System.Drawing.Point(332, 57);
            this.btn_editar_campo.Name = "btn_editar_campo";
            this.btn_editar_campo.Size = new System.Drawing.Size(20, 20);
            this.btn_editar_campo.TabIndex = 16;
            this.btn_editar_campo.UseVisualStyleBackColor = true;
            this.btn_editar_campo.Click += new System.EventHandler(this.btn_editar_campo_Click);
            // 
            // dgv_colunas
            // 
            this.dgv_colunas.AllowUserToAddRows = false;
            this.dgv_colunas.AllowUserToDeleteRows = false;
            this.dgv_colunas.AllowUserToOrderColumns = true;
            this.dgv_colunas.AllowUserToResizeRows = false;
            this.dgv_colunas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_colunas.BackgroundColor = System.Drawing.Color.White;
            this.dgv_colunas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_colunas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_colunas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_colunas.Location = new System.Drawing.Point(6, 4);
            this.dgv_colunas.MultiSelect = false;
            this.dgv_colunas.Name = "dgv_colunas";
            this.dgv_colunas.RowHeadersVisible = false;
            this.dgv_colunas.RowHeadersWidth = 51;
            this.dgv_colunas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_colunas.Size = new System.Drawing.Size(323, 473);
            this.dgv_colunas.TabIndex = 12;
            // 
            // pan_tabelas
            // 
            this.pan_tabelas.Controls.Add(this.btn_recarregar_tabelas);
            this.pan_tabelas.Controls.Add(this.btn_adicionar_tabela);
            this.pan_tabelas.Controls.Add(this.dgv_tabelas);
            this.pan_tabelas.Controls.Add(this.btn_visualizar_tabela);
            this.pan_tabelas.Controls.Add(this.btn_remover_tabela);
            this.pan_tabelas.Controls.Add(this.btn_editar_tabela);
            this.pan_tabelas.Dock = System.Windows.Forms.DockStyle.Left;
            this.pan_tabelas.Location = new System.Drawing.Point(3, 23);
            this.pan_tabelas.Name = "pan_tabelas";
            this.pan_tabelas.Size = new System.Drawing.Size(379, 481);
            this.pan_tabelas.TabIndex = 15;
            // 
            // btn_recarregar_tabelas
            // 
            this.btn_recarregar_tabelas.BackgroundImage = global::Pj.Properties.Resources.loop_100px20x20;
            this.btn_recarregar_tabelas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_recarregar_tabelas.Location = new System.Drawing.Point(353, 108);
            this.btn_recarregar_tabelas.Name = "btn_recarregar_tabelas";
            this.btn_recarregar_tabelas.Size = new System.Drawing.Size(20, 20);
            this.btn_recarregar_tabelas.TabIndex = 16;
            this.btn_recarregar_tabelas.UseVisualStyleBackColor = true;
            this.btn_recarregar_tabelas.Click += new System.EventHandler(this.btn_recarregar_tabelas_Click);
            // 
            // btn_adicionar_tabela
            // 
            this.btn_adicionar_tabela.BackgroundImage = global::Pj.Properties.Resources.plus20x20;
            this.btn_adicionar_tabela.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_adicionar_tabela.Location = new System.Drawing.Point(353, 4);
            this.btn_adicionar_tabela.Name = "btn_adicionar_tabela";
            this.btn_adicionar_tabela.Size = new System.Drawing.Size(20, 20);
            this.btn_adicionar_tabela.TabIndex = 15;
            this.btn_adicionar_tabela.UseVisualStyleBackColor = true;
            this.btn_adicionar_tabela.Click += new System.EventHandler(this.btn_adicionar_tabela_Click);
            // 
            // dgv_tabelas
            // 
            this.dgv_tabelas.AllowUserToAddRows = false;
            this.dgv_tabelas.AllowUserToDeleteRows = false;
            this.dgv_tabelas.AllowUserToOrderColumns = true;
            this.dgv_tabelas.AllowUserToResizeRows = false;
            this.dgv_tabelas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_tabelas.BackgroundColor = System.Drawing.Color.White;
            this.dgv_tabelas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_tabelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tabelas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_tabelas.Location = new System.Drawing.Point(3, 5);
            this.dgv_tabelas.MultiSelect = false;
            this.dgv_tabelas.Name = "dgv_tabelas";
            this.dgv_tabelas.RowHeadersVisible = false;
            this.dgv_tabelas.RowHeadersWidth = 51;
            this.dgv_tabelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tabelas.Size = new System.Drawing.Size(344, 473);
            this.dgv_tabelas.TabIndex = 11;
            this.dgv_tabelas.SelectionChanged += new System.EventHandler(this.dgv_tabelas_SelectionChanged);
            // 
            // btn_visualizar_tabela
            // 
            this.btn_visualizar_tabela.BackgroundImage = global::Pj.Properties.Resources.eye_100px20x20;
            this.btn_visualizar_tabela.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_visualizar_tabela.Location = new System.Drawing.Point(353, 82);
            this.btn_visualizar_tabela.Name = "btn_visualizar_tabela";
            this.btn_visualizar_tabela.Size = new System.Drawing.Size(20, 20);
            this.btn_visualizar_tabela.TabIndex = 14;
            this.btn_visualizar_tabela.UseVisualStyleBackColor = true;
            this.btn_visualizar_tabela.Click += new System.EventHandler(this.btn_visualizar_tabela_Click);
            // 
            // btn_remover_tabela
            // 
            this.btn_remover_tabela.BackgroundImage = global::Pj.Properties.Resources.quit20x20;
            this.btn_remover_tabela.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_remover_tabela.Location = new System.Drawing.Point(353, 30);
            this.btn_remover_tabela.Name = "btn_remover_tabela";
            this.btn_remover_tabela.Size = new System.Drawing.Size(20, 20);
            this.btn_remover_tabela.TabIndex = 13;
            this.btn_remover_tabela.UseVisualStyleBackColor = true;
            this.btn_remover_tabela.Click += new System.EventHandler(this.btn_remover_tabela_Click);
            // 
            // btn_editar_tabela
            // 
            this.btn_editar_tabela.BackgroundImage = global::Pj.Properties.Resources.pencil_100px20x20;
            this.btn_editar_tabela.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_editar_tabela.Location = new System.Drawing.Point(353, 56);
            this.btn_editar_tabela.Name = "btn_editar_tabela";
            this.btn_editar_tabela.Size = new System.Drawing.Size(20, 20);
            this.btn_editar_tabela.TabIndex = 12;
            this.btn_editar_tabela.UseVisualStyleBackColor = true;
            this.btn_editar_tabela.Click += new System.EventHandler(this.btn_editar_tabela_Click);
            // 
            // btn_gerarScripts
            // 
            this.btn_gerarScripts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_gerarScripts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_gerarScripts.Location = new System.Drawing.Point(622, 3);
            this.btn_gerarScripts.Name = "btn_gerarScripts";
            this.btn_gerarScripts.Size = new System.Drawing.Size(112, 29);
            this.btn_gerarScripts.TabIndex = 9;
            this.btn_gerarScripts.Text = "Gerar Scripts";
            this.btn_gerarScripts.UseVisualStyleBackColor = true;
            this.btn_gerarScripts.Click += new System.EventHandler(this.btn_gerarScripts_Click);
            // 
            // btn_gerar_classes
            // 
            this.btn_gerar_classes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_gerar_classes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_gerar_classes.Location = new System.Drawing.Point(501, 3);
            this.btn_gerar_classes.Name = "btn_gerar_classes";
            this.btn_gerar_classes.Size = new System.Drawing.Size(115, 29);
            this.btn_gerar_classes.TabIndex = 10;
            this.btn_gerar_classes.Text = "Gerar Classe";
            this.btn_gerar_classes.UseVisualStyleBackColor = true;
            this.btn_gerar_classes.Click += new System.EventHandler(this.btn_gerar_classes_Click);
            // 
            // pan_botton
            // 
            this.pan_botton.Controls.Add(this.btn_gerar_classe_api);
            this.pan_botton.Controls.Add(this.btn_gerarScripts);
            this.pan_botton.Controls.Add(this.btn_gerar_classes);
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
            // btn_gerar_classe_api
            // 
            this.btn_gerar_classe_api.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_gerar_classe_api.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_gerar_classe_api.Location = new System.Drawing.Point(339, 3);
            this.btn_gerar_classe_api.Name = "btn_gerar_classe_api";
            this.btn_gerar_classe_api.Size = new System.Drawing.Size(156, 29);
            this.btn_gerar_classe_api.TabIndex = 11;
            this.btn_gerar_classe_api.Text = "Gerar Classe API";
            this.btn_gerar_classe_api.UseVisualStyleBackColor = true;
            this.btn_gerar_classe_api.Click += new System.EventHandler(this.btn_gerar_classe_api_Click);
            // 
            // UC_Tabelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.Controls.Add(this.pan_tot);
            this.Controls.Add(this.pan_botton);
            this.Controls.Add(this.pan_top);
            this.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UC_Tabelas";
            this.Size = new System.Drawing.Size(740, 562);
            this.pan_tot.ResumeLayout(false);
            this.pan_formularioGeral.ResumeLayout(false);
            this.grb_tabela.ResumeLayout(false);
            this.pan_colunas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_colunas)).EndInit();
            this.pan_tabelas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabelas)).EndInit();
            this.pan_botton.ResumeLayout(false);
            this.pan_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Panel pan_tot;
        private System.Windows.Forms.Panel pan_formularioGeral;
        private System.Windows.Forms.Button btn_gerarScripts;
        private System.Windows.Forms.Button btn_gerar_classes;
        private System.Windows.Forms.Panel pan_botton;
        private System.Windows.Forms.Panel pan_top;
        private System.Windows.Forms.GroupBox grb_tabela;
        private System.Windows.Forms.Panel pan_tabelas;
        private System.Windows.Forms.DataGridView dgv_tabelas;
        private System.Windows.Forms.Button btn_remover_tabela;
        private System.Windows.Forms.Button btn_editar_tabela;
        private System.Windows.Forms.Panel pan_colunas;
        private System.Windows.Forms.Button btn_adicionar_tabela;
        private System.Windows.Forms.DataGridView dgv_colunas;
        private System.Windows.Forms.Button btn_incluir_campo;
        private System.Windows.Forms.Button btn_remover_campo;
        private System.Windows.Forms.Button btn_editar_campo;
        private System.Windows.Forms.Button btn_visualizar_tabela;
        private System.Windows.Forms.Button btn_visualizar_campo;
        private System.Windows.Forms.Button btn_recarregar_campos;
        private System.Windows.Forms.Button btn_recarregar_tabelas;
        private System.Windows.Forms.Button btn_gerar_classe_api;
    }
}
