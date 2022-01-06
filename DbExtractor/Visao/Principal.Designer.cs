namespace Visao
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.pan_total = new System.Windows.Forms.Panel();
            this.tbc_table_control = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grb_configuracaoSQLSERVER = new System.Windows.Forms.GroupBox();
            this.btn_info_SenhaSqlServer = new System.Windows.Forms.Button();
            this.btn_info_Usuario_SqlServer = new System.Windows.Forms.Button();
            this.btn_info_DataBaseSqlServer = new System.Windows.Forms.Button();
            this.btn_info_servidorSqlServer = new System.Windows.Forms.Button();
            this.tbx_senhaSqlServer = new System.Windows.Forms.TextBox();
            this.tbx_usuarioSQLServer = new System.Windows.Forms.TextBox();
            this.tbx_dataBaseSqlServer = new System.Windows.Forms.TextBox();
            this.lbl_senhaSqlServer = new System.Windows.Forms.Label();
            this.tbx_servidorSqlServer = new System.Windows.Forms.TextBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.lbl_dataBaseSqlServer = new System.Windows.Forms.Label();
            this.lbl_servidorSQLServer = new System.Windows.Forms.Label();
            this.pan_botton = new System.Windows.Forms.Panel();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.tbp_sqlite = new System.Windows.Forms.TabPage();
            this.grb_groupSQLIte = new System.Windows.Forms.GroupBox();
            this.btn_selectFile = new System.Windows.Forms.Button();
            this.pan_bottonSQLIte = new System.Windows.Forms.Panel();
            this.btn_importarSQLIte = new System.Windows.Forms.Button();
            this.btn_infoDatabaseSLIte = new System.Windows.Forms.Button();
            this.tbx_dataBaseSQLIte = new System.Windows.Forms.TextBox();
            this.DataBaseSQLIte = new System.Windows.Forms.Label();
            this.pan_total.SuspendLayout();
            this.tbc_table_control.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grb_configuracaoSQLSERVER.SuspendLayout();
            this.pan_botton.SuspendLayout();
            this.tbp_sqlite.SuspendLayout();
            this.grb_groupSQLIte.SuspendLayout();
            this.pan_bottonSQLIte.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_total
            // 
            this.pan_total.Controls.Add(this.tbc_table_control);
            this.pan_total.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_total.Location = new System.Drawing.Point(0, 0);
            this.pan_total.Name = "pan_total";
            this.pan_total.Size = new System.Drawing.Size(463, 253);
            this.pan_total.TabIndex = 0;
            // 
            // tbc_table_control
            // 
            this.tbc_table_control.Controls.Add(this.tabPage1);
            this.tbc_table_control.Controls.Add(this.tbp_sqlite);
            this.tbc_table_control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbc_table_control.Location = new System.Drawing.Point(0, 0);
            this.tbc_table_control.Name = "tbc_table_control";
            this.tbc_table_control.SelectedIndex = 0;
            this.tbc_table_control.Size = new System.Drawing.Size(463, 253);
            this.tbc_table_control.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grb_configuracaoSQLSERVER);
            this.tabPage1.Controls.Add(this.pan_botton);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(455, 225);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sql Server";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grb_configuracaoSQLSERVER
            // 
            this.grb_configuracaoSQLSERVER.Controls.Add(this.btn_info_SenhaSqlServer);
            this.grb_configuracaoSQLSERVER.Controls.Add(this.btn_info_Usuario_SqlServer);
            this.grb_configuracaoSQLSERVER.Controls.Add(this.btn_info_DataBaseSqlServer);
            this.grb_configuracaoSQLSERVER.Controls.Add(this.btn_info_servidorSqlServer);
            this.grb_configuracaoSQLSERVER.Controls.Add(this.tbx_senhaSqlServer);
            this.grb_configuracaoSQLSERVER.Controls.Add(this.tbx_usuarioSQLServer);
            this.grb_configuracaoSQLSERVER.Controls.Add(this.tbx_dataBaseSqlServer);
            this.grb_configuracaoSQLSERVER.Controls.Add(this.lbl_senhaSqlServer);
            this.grb_configuracaoSQLSERVER.Controls.Add(this.tbx_servidorSqlServer);
            this.grb_configuracaoSQLSERVER.Controls.Add(this.lbl_usuario);
            this.grb_configuracaoSQLSERVER.Controls.Add(this.lbl_dataBaseSqlServer);
            this.grb_configuracaoSQLSERVER.Controls.Add(this.lbl_servidorSQLServer);
            this.grb_configuracaoSQLSERVER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_configuracaoSQLSERVER.Location = new System.Drawing.Point(0, 0);
            this.grb_configuracaoSQLSERVER.Name = "grb_configuracaoSQLSERVER";
            this.grb_configuracaoSQLSERVER.Size = new System.Drawing.Size(455, 190);
            this.grb_configuracaoSQLSERVER.TabIndex = 0;
            this.grb_configuracaoSQLSERVER.TabStop = false;
            this.grb_configuracaoSQLSERVER.Text = "Configuração";
            // 
            // btn_info_SenhaSqlServer
            // 
            this.btn_info_SenhaSqlServer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_info_SenhaSqlServer.BackgroundImage")));
            this.btn_info_SenhaSqlServer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_SenhaSqlServer.Location = new System.Drawing.Point(414, 111);
            this.btn_info_SenhaSqlServer.Name = "btn_info_SenhaSqlServer";
            this.btn_info_SenhaSqlServer.Size = new System.Drawing.Size(20, 20);
            this.btn_info_SenhaSqlServer.TabIndex = 9;
            this.btn_info_SenhaSqlServer.UseVisualStyleBackColor = true;
            this.btn_info_SenhaSqlServer.Click += new System.EventHandler(this.btn_info_SenhaSqlServer_Click);
            // 
            // btn_info_Usuario_SqlServer
            // 
            this.btn_info_Usuario_SqlServer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_info_Usuario_SqlServer.BackgroundImage")));
            this.btn_info_Usuario_SqlServer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_Usuario_SqlServer.Location = new System.Drawing.Point(414, 83);
            this.btn_info_Usuario_SqlServer.Name = "btn_info_Usuario_SqlServer";
            this.btn_info_Usuario_SqlServer.Size = new System.Drawing.Size(20, 20);
            this.btn_info_Usuario_SqlServer.TabIndex = 9;
            this.btn_info_Usuario_SqlServer.UseVisualStyleBackColor = true;
            this.btn_info_Usuario_SqlServer.Click += new System.EventHandler(this.btn_info_Usuario_SqlServer_Click);
            // 
            // btn_info_DataBaseSqlServer
            // 
            this.btn_info_DataBaseSqlServer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_info_DataBaseSqlServer.BackgroundImage")));
            this.btn_info_DataBaseSqlServer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_DataBaseSqlServer.Location = new System.Drawing.Point(414, 54);
            this.btn_info_DataBaseSqlServer.Name = "btn_info_DataBaseSqlServer";
            this.btn_info_DataBaseSqlServer.Size = new System.Drawing.Size(20, 20);
            this.btn_info_DataBaseSqlServer.TabIndex = 9;
            this.btn_info_DataBaseSqlServer.UseVisualStyleBackColor = true;
            this.btn_info_DataBaseSqlServer.Click += new System.EventHandler(this.btn_info_DataBaseSqlServer_Click);
            // 
            // btn_info_servidorSqlServer
            // 
            this.btn_info_servidorSqlServer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_info_servidorSqlServer.BackgroundImage")));
            this.btn_info_servidorSqlServer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_servidorSqlServer.Location = new System.Drawing.Point(414, 24);
            this.btn_info_servidorSqlServer.Name = "btn_info_servidorSqlServer";
            this.btn_info_servidorSqlServer.Size = new System.Drawing.Size(20, 20);
            this.btn_info_servidorSqlServer.TabIndex = 9;
            this.btn_info_servidorSqlServer.UseVisualStyleBackColor = true;
            this.btn_info_servidorSqlServer.Click += new System.EventHandler(this.btn_info_servidorSqlServer_Click);
            // 
            // tbx_senhaSqlServer
            // 
            this.tbx_senhaSqlServer.Location = new System.Drawing.Point(99, 110);
            this.tbx_senhaSqlServer.Name = "tbx_senhaSqlServer";
            this.tbx_senhaSqlServer.PasswordChar = '*';
            this.tbx_senhaSqlServer.Size = new System.Drawing.Size(309, 23);
            this.tbx_senhaSqlServer.TabIndex = 4;
            // 
            // tbx_usuarioSQLServer
            // 
            this.tbx_usuarioSQLServer.Location = new System.Drawing.Point(99, 81);
            this.tbx_usuarioSQLServer.Name = "tbx_usuarioSQLServer";
            this.tbx_usuarioSQLServer.Size = new System.Drawing.Size(309, 23);
            this.tbx_usuarioSQLServer.TabIndex = 3;
            // 
            // tbx_dataBaseSqlServer
            // 
            this.tbx_dataBaseSqlServer.Location = new System.Drawing.Point(99, 52);
            this.tbx_dataBaseSqlServer.Name = "tbx_dataBaseSqlServer";
            this.tbx_dataBaseSqlServer.Size = new System.Drawing.Size(309, 23);
            this.tbx_dataBaseSqlServer.TabIndex = 2;
            // 
            // lbl_senhaSqlServer
            // 
            this.lbl_senhaSqlServer.AutoSize = true;
            this.lbl_senhaSqlServer.Location = new System.Drawing.Point(9, 113);
            this.lbl_senhaSqlServer.Name = "lbl_senhaSqlServer";
            this.lbl_senhaSqlServer.Size = new System.Drawing.Size(42, 16);
            this.lbl_senhaSqlServer.TabIndex = 0;
            this.lbl_senhaSqlServer.Text = "Senha";
            // 
            // tbx_servidorSqlServer
            // 
            this.tbx_servidorSqlServer.Location = new System.Drawing.Point(99, 23);
            this.tbx_servidorSqlServer.Name = "tbx_servidorSqlServer";
            this.tbx_servidorSqlServer.Size = new System.Drawing.Size(309, 23);
            this.tbx_servidorSqlServer.TabIndex = 1;
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Location = new System.Drawing.Point(9, 84);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(51, 16);
            this.lbl_usuario.TabIndex = 0;
            this.lbl_usuario.Text = "Usuário";
            // 
            // lbl_dataBaseSqlServer
            // 
            this.lbl_dataBaseSqlServer.AutoSize = true;
            this.lbl_dataBaseSqlServer.Location = new System.Drawing.Point(9, 55);
            this.lbl_dataBaseSqlServer.Name = "lbl_dataBaseSqlServer";
            this.lbl_dataBaseSqlServer.Size = new System.Drawing.Size(60, 16);
            this.lbl_dataBaseSqlServer.TabIndex = 0;
            this.lbl_dataBaseSqlServer.Text = "DataBase";
            // 
            // lbl_servidorSQLServer
            // 
            this.lbl_servidorSQLServer.AutoSize = true;
            this.lbl_servidorSQLServer.Location = new System.Drawing.Point(9, 26);
            this.lbl_servidorSQLServer.Name = "lbl_servidorSQLServer";
            this.lbl_servidorSQLServer.Size = new System.Drawing.Size(56, 16);
            this.lbl_servidorSQLServer.TabIndex = 0;
            this.lbl_servidorSQLServer.Text = "Servidor";
            // 
            // pan_botton
            // 
            this.pan_botton.Controls.Add(this.btn_confirmar);
            this.pan_botton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_botton.Location = new System.Drawing.Point(0, 190);
            this.pan_botton.Name = "pan_botton";
            this.pan_botton.Size = new System.Drawing.Size(455, 35);
            this.pan_botton.TabIndex = 10;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_confirmar.Location = new System.Drawing.Point(377, 3);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(75, 29);
            this.btn_confirmar.TabIndex = 23;
            this.btn_confirmar.Text = "Importar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // tbp_sqlite
            // 
            this.tbp_sqlite.Controls.Add(this.grb_groupSQLIte);
            this.tbp_sqlite.Location = new System.Drawing.Point(4, 24);
            this.tbp_sqlite.Name = "tbp_sqlite";
            this.tbp_sqlite.Size = new System.Drawing.Size(455, 225);
            this.tbp_sqlite.TabIndex = 1;
            this.tbp_sqlite.Text = "SQLite";
            this.tbp_sqlite.UseVisualStyleBackColor = true;
            // 
            // grb_groupSQLIte
            // 
            this.grb_groupSQLIte.Controls.Add(this.btn_selectFile);
            this.grb_groupSQLIte.Controls.Add(this.pan_bottonSQLIte);
            this.grb_groupSQLIte.Controls.Add(this.btn_infoDatabaseSLIte);
            this.grb_groupSQLIte.Controls.Add(this.tbx_dataBaseSQLIte);
            this.grb_groupSQLIte.Controls.Add(this.DataBaseSQLIte);
            this.grb_groupSQLIte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_groupSQLIte.Location = new System.Drawing.Point(0, 0);
            this.grb_groupSQLIte.Name = "grb_groupSQLIte";
            this.grb_groupSQLIte.Size = new System.Drawing.Size(455, 225);
            this.grb_groupSQLIte.TabIndex = 1;
            this.grb_groupSQLIte.TabStop = false;
            this.grb_groupSQLIte.Text = "Configuração";
            // 
            // btn_selectFile
            // 
            this.btn_selectFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_selectFile.Location = new System.Drawing.Point(355, 22);
            this.btn_selectFile.Name = "btn_selectFile";
            this.btn_selectFile.Size = new System.Drawing.Size(53, 22);
            this.btn_selectFile.TabIndex = 12;
            this.btn_selectFile.Text = "File";
            this.btn_selectFile.UseVisualStyleBackColor = true;
            this.btn_selectFile.Click += new System.EventHandler(this.btn_selectFile_Click);
            // 
            // pan_bottonSQLIte
            // 
            this.pan_bottonSQLIte.Controls.Add(this.btn_importarSQLIte);
            this.pan_bottonSQLIte.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_bottonSQLIte.Location = new System.Drawing.Point(3, 187);
            this.pan_bottonSQLIte.Name = "pan_bottonSQLIte";
            this.pan_bottonSQLIte.Size = new System.Drawing.Size(449, 35);
            this.pan_bottonSQLIte.TabIndex = 11;
            // 
            // btn_importarSQLIte
            // 
            this.btn_importarSQLIte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_importarSQLIte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_importarSQLIte.Location = new System.Drawing.Point(371, 3);
            this.btn_importarSQLIte.Name = "btn_importarSQLIte";
            this.btn_importarSQLIte.Size = new System.Drawing.Size(75, 29);
            this.btn_importarSQLIte.TabIndex = 23;
            this.btn_importarSQLIte.Text = "Importar";
            this.btn_importarSQLIte.UseVisualStyleBackColor = true;
            this.btn_importarSQLIte.Click += new System.EventHandler(this.btn_importarSQLIte_Click);
            // 
            // btn_infoDatabaseSLIte
            // 
            this.btn_infoDatabaseSLIte.BackgroundImage = global::DbExtractor.Properties.Resources.png_infoProdutoBlack20x20;
            this.btn_infoDatabaseSLIte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_infoDatabaseSLIte.Location = new System.Drawing.Point(414, 23);
            this.btn_infoDatabaseSLIte.Name = "btn_infoDatabaseSLIte";
            this.btn_infoDatabaseSLIte.Size = new System.Drawing.Size(20, 20);
            this.btn_infoDatabaseSLIte.TabIndex = 9;
            this.btn_infoDatabaseSLIte.UseVisualStyleBackColor = true;
            this.btn_infoDatabaseSLIte.Click += new System.EventHandler(this.btn_infoDatabaseSLIte_Click);
            // 
            // tbx_dataBaseSQLIte
            // 
            this.tbx_dataBaseSQLIte.Location = new System.Drawing.Point(99, 21);
            this.tbx_dataBaseSQLIte.Name = "tbx_dataBaseSQLIte";
            this.tbx_dataBaseSQLIte.Size = new System.Drawing.Size(250, 23);
            this.tbx_dataBaseSQLIte.TabIndex = 2;
            // 
            // DataBaseSQLIte
            // 
            this.DataBaseSQLIte.AutoSize = true;
            this.DataBaseSQLIte.Location = new System.Drawing.Point(9, 24);
            this.DataBaseSQLIte.Name = "DataBaseSQLIte";
            this.DataBaseSQLIte.Size = new System.Drawing.Size(60, 16);
            this.DataBaseSQLIte.TabIndex = 0;
            this.DataBaseSQLIte.Text = "DataBase";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(463, 253);
            this.Controls.Add(this.pan_total);
            this.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importador";
            this.pan_total.ResumeLayout(false);
            this.tbc_table_control.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grb_configuracaoSQLSERVER.ResumeLayout(false);
            this.grb_configuracaoSQLSERVER.PerformLayout();
            this.pan_botton.ResumeLayout(false);
            this.tbp_sqlite.ResumeLayout(false);
            this.grb_groupSQLIte.ResumeLayout(false);
            this.grb_groupSQLIte.PerformLayout();
            this.pan_bottonSQLIte.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_total;
        private System.Windows.Forms.TabControl tbc_table_control;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grb_configuracaoSQLSERVER;
        private System.Windows.Forms.Panel pan_botton;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.TextBox tbx_servidorSqlServer;
        private System.Windows.Forms.Label lbl_servidorSQLServer;
        private System.Windows.Forms.TextBox tbx_senhaSqlServer;
        private System.Windows.Forms.TextBox tbx_usuarioSQLServer;
        private System.Windows.Forms.TextBox tbx_dataBaseSqlServer;
        private System.Windows.Forms.Label lbl_senhaSqlServer;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.Label lbl_dataBaseSqlServer;
        private System.Windows.Forms.Button btn_info_servidorSqlServer;
        private System.Windows.Forms.Button btn_info_SenhaSqlServer;
        private System.Windows.Forms.Button btn_info_Usuario_SqlServer;
        private System.Windows.Forms.Button btn_info_DataBaseSqlServer;
        private System.Windows.Forms.TabPage tbp_sqlite;
        private System.Windows.Forms.GroupBox grb_groupSQLIte;
        private System.Windows.Forms.Button btn_infoDatabaseSLIte;
        private System.Windows.Forms.TextBox tbx_dataBaseSQLIte;
        private System.Windows.Forms.Label DataBaseSQLIte;
        private System.Windows.Forms.Panel pan_bottonSQLIte;
        private System.Windows.Forms.Button btn_importarSQLIte;
        private System.Windows.Forms.Button btn_selectFile;
    }
}

