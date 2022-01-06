namespace Visao
{
    partial class FO_GerarScripts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FO_GerarScripts));
            this.pan_completo = new System.Windows.Forms.Panel();
            this.pan_formulario = new System.Windows.Forms.Panel();
            this.grb_formulario = new System.Windows.Forms.GroupBox();
            this.ckb_gerarArquivo = new System.Windows.Forms.CheckBox();
            this.btn_info_tipoBanco = new System.Windows.Forms.Button();
            this.cmb_Tipobanco = new System.Windows.Forms.ComboBox();
            this.btn_selecionaFolder = new System.Windows.Forms.Button();
            this.btn_info_diretorio = new System.Windows.Forms.Button();
            this.tbx_caminhoSaida = new System.Windows.Forms.TextBox();
            this.lbl_bancodedados = new System.Windows.Forms.Label();
            this.lbl_caminhoSaida = new System.Windows.Forms.Label();
            this.pan_botton = new System.Windows.Forms.Panel();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.btn_info_gerarArquivo = new System.Windows.Forms.Button();
            this.pan_completo.SuspendLayout();
            this.pan_formulario.SuspendLayout();
            this.grb_formulario.SuspendLayout();
            this.pan_botton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_completo
            // 
            this.pan_completo.Controls.Add(this.pan_formulario);
            this.pan_completo.Controls.Add(this.pan_botton);
            this.pan_completo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_completo.Location = new System.Drawing.Point(0, 0);
            this.pan_completo.Name = "pan_completo";
            this.pan_completo.Size = new System.Drawing.Size(577, 144);
            this.pan_completo.TabIndex = 0;
            // 
            // pan_formulario
            // 
            this.pan_formulario.Controls.Add(this.grb_formulario);
            this.pan_formulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_formulario.Location = new System.Drawing.Point(0, 0);
            this.pan_formulario.Name = "pan_formulario";
            this.pan_formulario.Size = new System.Drawing.Size(577, 109);
            this.pan_formulario.TabIndex = 13;
            // 
            // grb_formulario
            // 
            this.grb_formulario.Controls.Add(this.btn_info_gerarArquivo);
            this.grb_formulario.Controls.Add(this.ckb_gerarArquivo);
            this.grb_formulario.Controls.Add(this.btn_info_tipoBanco);
            this.grb_formulario.Controls.Add(this.cmb_Tipobanco);
            this.grb_formulario.Controls.Add(this.btn_selecionaFolder);
            this.grb_formulario.Controls.Add(this.btn_info_diretorio);
            this.grb_formulario.Controls.Add(this.tbx_caminhoSaida);
            this.grb_formulario.Controls.Add(this.lbl_bancodedados);
            this.grb_formulario.Controls.Add(this.lbl_caminhoSaida);
            this.grb_formulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_formulario.Location = new System.Drawing.Point(0, 0);
            this.grb_formulario.Name = "grb_formulario";
            this.grb_formulario.Size = new System.Drawing.Size(577, 109);
            this.grb_formulario.TabIndex = 0;
            this.grb_formulario.TabStop = false;
            this.grb_formulario.Text = "Dados de salvamento";
            // 
            // ckb_gerarArquivo
            // 
            this.ckb_gerarArquivo.AutoSize = true;
            this.ckb_gerarArquivo.Location = new System.Drawing.Point(15, 87);
            this.ckb_gerarArquivo.Name = "ckb_gerarArquivo";
            this.ckb_gerarArquivo.Size = new System.Drawing.Size(186, 20);
            this.ckb_gerarArquivo.TabIndex = 6;
            this.ckb_gerarArquivo.Text = "Gerar um arquivo por tabela";
            this.ckb_gerarArquivo.UseVisualStyleBackColor = true;
            // 
            // btn_info_tipoBanco
            // 
            this.btn_info_tipoBanco.BackgroundImage = global::Pj.Properties.Resources.png_infoProdutoBlack20x20;
            this.btn_info_tipoBanco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_tipoBanco.Location = new System.Drawing.Point(293, 56);
            this.btn_info_tipoBanco.Name = "btn_info_tipoBanco";
            this.btn_info_tipoBanco.Size = new System.Drawing.Size(20, 20);
            this.btn_info_tipoBanco.TabIndex = 5;
            this.btn_info_tipoBanco.UseVisualStyleBackColor = true;
            this.btn_info_tipoBanco.Click += new System.EventHandler(this.btn_info_tipoBanco_Click);
            // 
            // cmb_Tipobanco
            // 
            this.cmb_Tipobanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Tipobanco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_Tipobanco.FormattingEnabled = true;
            this.cmb_Tipobanco.Items.AddRange(new object[] {
            "SQLite",
            "SQL Server"});
            this.cmb_Tipobanco.Location = new System.Drawing.Point(127, 54);
            this.cmb_Tipobanco.Name = "cmb_Tipobanco";
            this.cmb_Tipobanco.Size = new System.Drawing.Size(160, 23);
            this.cmb_Tipobanco.TabIndex = 4;
            // 
            // btn_selecionaFolder
            // 
            this.btn_selecionaFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_selecionaFolder.Location = new System.Drawing.Point(445, 20);
            this.btn_selecionaFolder.Name = "btn_selecionaFolder";
            this.btn_selecionaFolder.Size = new System.Drawing.Size(53, 23);
            this.btn_selecionaFolder.TabIndex = 2;
            this.btn_selecionaFolder.Text = "Folder";
            this.btn_selecionaFolder.UseVisualStyleBackColor = true;
            this.btn_selecionaFolder.Click += new System.EventHandler(this.btn_selecionaFolder_Click);
            // 
            // btn_info_diretorio
            // 
            this.btn_info_diretorio.BackgroundImage = global::Pj.Properties.Resources.png_infoProdutoBlack20x20;
            this.btn_info_diretorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_diretorio.Location = new System.Drawing.Point(504, 21);
            this.btn_info_diretorio.Name = "btn_info_diretorio";
            this.btn_info_diretorio.Size = new System.Drawing.Size(20, 20);
            this.btn_info_diretorio.TabIndex = 3;
            this.btn_info_diretorio.UseVisualStyleBackColor = true;
            this.btn_info_diretorio.Click += new System.EventHandler(this.btn_info_diretorio_Click);
            // 
            // tbx_caminhoSaida
            // 
            this.tbx_caminhoSaida.Location = new System.Drawing.Point(125, 20);
            this.tbx_caminhoSaida.MaxLength = 50;
            this.tbx_caminhoSaida.Name = "tbx_caminhoSaida";
            this.tbx_caminhoSaida.Size = new System.Drawing.Size(314, 23);
            this.tbx_caminhoSaida.TabIndex = 1;
            // 
            // lbl_bancodedados
            // 
            this.lbl_bancodedados.AutoSize = true;
            this.lbl_bancodedados.Location = new System.Drawing.Point(12, 57);
            this.lbl_bancodedados.Name = "lbl_bancodedados";
            this.lbl_bancodedados.Size = new System.Drawing.Size(97, 16);
            this.lbl_bancodedados.TabIndex = 8;
            this.lbl_bancodedados.Text = "Banco de dados";
            // 
            // lbl_caminhoSaida
            // 
            this.lbl_caminhoSaida.AutoSize = true;
            this.lbl_caminhoSaida.Location = new System.Drawing.Point(12, 23);
            this.lbl_caminhoSaida.Name = "lbl_caminhoSaida";
            this.lbl_caminhoSaida.Size = new System.Drawing.Size(108, 16);
            this.lbl_caminhoSaida.TabIndex = 8;
            this.lbl_caminhoSaida.Text = "Diretório de saída";
            // 
            // pan_botton
            // 
            this.pan_botton.Controls.Add(this.btn_confirmar);
            this.pan_botton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_botton.Location = new System.Drawing.Point(0, 109);
            this.pan_botton.Name = "pan_botton";
            this.pan_botton.Size = new System.Drawing.Size(577, 35);
            this.pan_botton.TabIndex = 12;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_confirmar.Location = new System.Drawing.Point(499, 3);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(75, 29);
            this.btn_confirmar.TabIndex = 10;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // btn_info_gerarArquivo
            // 
            this.btn_info_gerarArquivo.BackgroundImage = global::Pj.Properties.Resources.png_infoProdutoBlack20x20;
            this.btn_info_gerarArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_gerarArquivo.Location = new System.Drawing.Point(207, 86);
            this.btn_info_gerarArquivo.Name = "btn_info_gerarArquivo";
            this.btn_info_gerarArquivo.Size = new System.Drawing.Size(20, 20);
            this.btn_info_gerarArquivo.TabIndex = 9;
            this.btn_info_gerarArquivo.UseVisualStyleBackColor = true;
            this.btn_info_gerarArquivo.Click += new System.EventHandler(this.btn_info_gerarArquivo_Click);
            // 
            // FO_GerarScripts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(577, 144);
            this.Controls.Add(this.pan_completo);
            this.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FO_GerarScripts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerar Scripts";
            this.pan_completo.ResumeLayout(false);
            this.pan_formulario.ResumeLayout(false);
            this.grb_formulario.ResumeLayout(false);
            this.grb_formulario.PerformLayout();
            this.pan_botton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_completo;
        private System.Windows.Forms.Panel pan_botton;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Panel pan_formulario;
        private System.Windows.Forms.GroupBox grb_formulario;
        private System.Windows.Forms.Button btn_info_diretorio;
        private System.Windows.Forms.TextBox tbx_caminhoSaida;
        private System.Windows.Forms.Label lbl_caminhoSaida;
        private System.Windows.Forms.Button btn_selecionaFolder;
        private System.Windows.Forms.Label lbl_bancodedados;
        private System.Windows.Forms.Button btn_info_tipoBanco;
        private System.Windows.Forms.ComboBox cmb_Tipobanco;
        private System.Windows.Forms.CheckBox ckb_gerarArquivo;
        private System.Windows.Forms.Button btn_info_gerarArquivo;
    }
}