namespace Visao
{
    partial class FO_Configuracoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FO_Configuracoes));
            this.tbc_table_control = new System.Windows.Forms.TabControl();
            this.tbp_cores = new System.Windows.Forms.TabPage();
            this.grb_coresDER = new System.Windows.Forms.GroupBox();
            this.btn_corSecundaria = new System.Windows.Forms.Button();
            this.btn_colorPickerPrimario = new System.Windows.Forms.Button();
            this.btn_info_corSecundaria = new System.Windows.Forms.Button();
            this.btn_info_corprimaria = new System.Windows.Forms.Button();
            this.tbx_corSecundaria = new System.Windows.Forms.TextBox();
            this.lbl_corSecundaria = new System.Windows.Forms.Label();
            this.tbx_corPrimaria = new System.Windows.Forms.TextBox();
            this.lbl_corPrimaria = new System.Windows.Forms.Label();
            this.pan_botton = new System.Windows.Forms.Panel();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.tbp_informacoes = new System.Windows.Forms.TabPage();
            this.grb_informacoesTelaPrincipal = new System.Windows.Forms.GroupBox();
            this.cmb_opcaoQuantidade = new System.Windows.Forms.ComboBox();
            this.btn_info_Quantidade = new System.Windows.Forms.Button();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_gravarInfromacoes = new System.Windows.Forms.Button();
            this.tbc_table_control.SuspendLayout();
            this.tbp_cores.SuspendLayout();
            this.grb_coresDER.SuspendLayout();
            this.pan_botton.SuspendLayout();
            this.tbp_informacoes.SuspendLayout();
            this.grb_informacoesTelaPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbc_table_control
            // 
            this.tbc_table_control.Controls.Add(this.tbp_cores);
            this.tbc_table_control.Controls.Add(this.tbp_informacoes);
            this.tbc_table_control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbc_table_control.Location = new System.Drawing.Point(0, 0);
            this.tbc_table_control.Name = "tbc_table_control";
            this.tbc_table_control.SelectedIndex = 0;
            this.tbc_table_control.Size = new System.Drawing.Size(463, 253);
            this.tbc_table_control.TabIndex = 2;
            // 
            // tbp_cores
            // 
            this.tbp_cores.Controls.Add(this.grb_coresDER);
            this.tbp_cores.Controls.Add(this.pan_botton);
            this.tbp_cores.Location = new System.Drawing.Point(4, 24);
            this.tbp_cores.Name = "tbp_cores";
            this.tbp_cores.Size = new System.Drawing.Size(455, 225);
            this.tbp_cores.TabIndex = 0;
            this.tbp_cores.Text = "Cores";
            this.tbp_cores.UseVisualStyleBackColor = true;
            // 
            // grb_coresDER
            // 
            this.grb_coresDER.Controls.Add(this.btn_corSecundaria);
            this.grb_coresDER.Controls.Add(this.btn_colorPickerPrimario);
            this.grb_coresDER.Controls.Add(this.btn_info_corSecundaria);
            this.grb_coresDER.Controls.Add(this.btn_info_corprimaria);
            this.grb_coresDER.Controls.Add(this.tbx_corSecundaria);
            this.grb_coresDER.Controls.Add(this.lbl_corSecundaria);
            this.grb_coresDER.Controls.Add(this.tbx_corPrimaria);
            this.grb_coresDER.Controls.Add(this.lbl_corPrimaria);
            this.grb_coresDER.Dock = System.Windows.Forms.DockStyle.Top;
            this.grb_coresDER.Location = new System.Drawing.Point(0, 0);
            this.grb_coresDER.Name = "grb_coresDER";
            this.grb_coresDER.Size = new System.Drawing.Size(455, 87);
            this.grb_coresDER.TabIndex = 0;
            this.grb_coresDER.TabStop = false;
            this.grb_coresDER.Text = "Cores do DER";
            // 
            // btn_corSecundaria
            // 
            this.btn_corSecundaria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_corSecundaria.Location = new System.Drawing.Point(361, 53);
            this.btn_corSecundaria.Name = "btn_corSecundaria";
            this.btn_corSecundaria.Size = new System.Drawing.Size(47, 22);
            this.btn_corSecundaria.TabIndex = 9;
            this.btn_corSecundaria.Text = "Color";
            this.btn_corSecundaria.UseVisualStyleBackColor = true;
            this.btn_corSecundaria.Click += new System.EventHandler(this.btn_corSecundaria_Click);
            // 
            // btn_colorPickerPrimario
            // 
            this.btn_colorPickerPrimario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_colorPickerPrimario.Location = new System.Drawing.Point(361, 24);
            this.btn_colorPickerPrimario.Name = "btn_colorPickerPrimario";
            this.btn_colorPickerPrimario.Size = new System.Drawing.Size(47, 22);
            this.btn_colorPickerPrimario.TabIndex = 9;
            this.btn_colorPickerPrimario.Text = "Color";
            this.btn_colorPickerPrimario.UseVisualStyleBackColor = true;
            this.btn_colorPickerPrimario.Click += new System.EventHandler(this.btn_colorPickerPrimario_Click);
            // 
            // btn_info_corSecundaria
            // 
            this.btn_info_corSecundaria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_info_corSecundaria.BackgroundImage")));
            this.btn_info_corSecundaria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_corSecundaria.Location = new System.Drawing.Point(414, 54);
            this.btn_info_corSecundaria.Name = "btn_info_corSecundaria";
            this.btn_info_corSecundaria.Size = new System.Drawing.Size(20, 20);
            this.btn_info_corSecundaria.TabIndex = 9;
            this.btn_info_corSecundaria.UseVisualStyleBackColor = true;
            this.btn_info_corSecundaria.Click += new System.EventHandler(this.btn_info_corSecundaria_Click);
            // 
            // btn_info_corprimaria
            // 
            this.btn_info_corprimaria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_info_corprimaria.BackgroundImage")));
            this.btn_info_corprimaria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_corprimaria.Location = new System.Drawing.Point(414, 25);
            this.btn_info_corprimaria.Name = "btn_info_corprimaria";
            this.btn_info_corprimaria.Size = new System.Drawing.Size(20, 20);
            this.btn_info_corprimaria.TabIndex = 9;
            this.btn_info_corprimaria.UseVisualStyleBackColor = true;
            this.btn_info_corprimaria.Click += new System.EventHandler(this.btn_info_corprimaria_Click);
            // 
            // tbx_corSecundaria
            // 
            this.tbx_corSecundaria.Enabled = false;
            this.tbx_corSecundaria.Location = new System.Drawing.Point(99, 52);
            this.tbx_corSecundaria.MaxLength = 50;
            this.tbx_corSecundaria.Name = "tbx_corSecundaria";
            this.tbx_corSecundaria.Size = new System.Drawing.Size(256, 23);
            this.tbx_corSecundaria.TabIndex = 1;
            // 
            // lbl_corSecundaria
            // 
            this.lbl_corSecundaria.AutoSize = true;
            this.lbl_corSecundaria.Location = new System.Drawing.Point(9, 55);
            this.lbl_corSecundaria.Name = "lbl_corSecundaria";
            this.lbl_corSecundaria.Size = new System.Drawing.Size(93, 16);
            this.lbl_corSecundaria.TabIndex = 0;
            this.lbl_corSecundaria.Text = "Cor secundária";
            // 
            // tbx_corPrimaria
            // 
            this.tbx_corPrimaria.Enabled = false;
            this.tbx_corPrimaria.Location = new System.Drawing.Point(99, 23);
            this.tbx_corPrimaria.Name = "tbx_corPrimaria";
            this.tbx_corPrimaria.Size = new System.Drawing.Size(256, 23);
            this.tbx_corPrimaria.TabIndex = 1;
            // 
            // lbl_corPrimaria
            // 
            this.lbl_corPrimaria.AutoSize = true;
            this.lbl_corPrimaria.Location = new System.Drawing.Point(9, 26);
            this.lbl_corPrimaria.Name = "lbl_corPrimaria";
            this.lbl_corPrimaria.Size = new System.Drawing.Size(79, 16);
            this.lbl_corPrimaria.TabIndex = 0;
            this.lbl_corPrimaria.Text = "Cor primária";
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
            this.btn_confirmar.Text = "Gravar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // tbp_informacoes
            // 
            this.tbp_informacoes.Controls.Add(this.grb_informacoesTelaPrincipal);
            this.tbp_informacoes.Controls.Add(this.panel1);
            this.tbp_informacoes.Location = new System.Drawing.Point(4, 24);
            this.tbp_informacoes.Name = "tbp_informacoes";
            this.tbp_informacoes.Size = new System.Drawing.Size(455, 225);
            this.tbp_informacoes.TabIndex = 1;
            this.tbp_informacoes.Text = "Informações";
            this.tbp_informacoes.UseVisualStyleBackColor = true;
            // 
            // grb_informacoesTelaPrincipal
            // 
            this.grb_informacoesTelaPrincipal.Controls.Add(this.cmb_opcaoQuantidade);
            this.grb_informacoesTelaPrincipal.Controls.Add(this.btn_info_Quantidade);
            this.grb_informacoesTelaPrincipal.Controls.Add(this.lbl_quantidade);
            this.grb_informacoesTelaPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.grb_informacoesTelaPrincipal.Location = new System.Drawing.Point(0, 0);
            this.grb_informacoesTelaPrincipal.Name = "grb_informacoesTelaPrincipal";
            this.grb_informacoesTelaPrincipal.Size = new System.Drawing.Size(455, 87);
            this.grb_informacoesTelaPrincipal.TabIndex = 12;
            this.grb_informacoesTelaPrincipal.TabStop = false;
            this.grb_informacoesTelaPrincipal.Text = "Informações da tela principal";
            // 
            // cmb_opcaoQuantidade
            // 
            this.cmb_opcaoQuantidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_opcaoQuantidade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_opcaoQuantidade.FormattingEnabled = true;
            this.cmb_opcaoQuantidade.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cmb_opcaoQuantidade.Location = new System.Drawing.Point(329, 23);
            this.cmb_opcaoQuantidade.Name = "cmb_opcaoQuantidade";
            this.cmb_opcaoQuantidade.Size = new System.Drawing.Size(79, 23);
            this.cmb_opcaoQuantidade.TabIndex = 10;
            // 
            // btn_info_Quantidade
            // 
            this.btn_info_Quantidade.BackgroundImage = global::Pj.Properties.Resources.png_infoProdutoBlack20x20;
            this.btn_info_Quantidade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_Quantidade.Location = new System.Drawing.Point(414, 25);
            this.btn_info_Quantidade.Name = "btn_info_Quantidade";
            this.btn_info_Quantidade.Size = new System.Drawing.Size(20, 20);
            this.btn_info_Quantidade.TabIndex = 9;
            this.btn_info_Quantidade.UseVisualStyleBackColor = true;
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Location = new System.Drawing.Point(9, 26);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(313, 16);
            this.lbl_quantidade.TabIndex = 0;
            this.lbl_quantidade.Text = "Apresenta informações de quantidade na tela principal:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_gravarInfromacoes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 35);
            this.panel1.TabIndex = 11;
            // 
            // btn_gravarInfromacoes
            // 
            this.btn_gravarInfromacoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_gravarInfromacoes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_gravarInfromacoes.Location = new System.Drawing.Point(377, 3);
            this.btn_gravarInfromacoes.Name = "btn_gravarInfromacoes";
            this.btn_gravarInfromacoes.Size = new System.Drawing.Size(75, 29);
            this.btn_gravarInfromacoes.TabIndex = 23;
            this.btn_gravarInfromacoes.Text = "Gravar";
            this.btn_gravarInfromacoes.UseVisualStyleBackColor = true;
            this.btn_gravarInfromacoes.Click += new System.EventHandler(this.btn_gravarInfromacoes_Click);
            // 
            // FO_Configuracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(463, 253);
            this.Controls.Add(this.tbc_table_control);
            this.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FO_Configuracoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.tbc_table_control.ResumeLayout(false);
            this.tbp_cores.ResumeLayout(false);
            this.grb_coresDER.ResumeLayout(false);
            this.grb_coresDER.PerformLayout();
            this.pan_botton.ResumeLayout(false);
            this.tbp_informacoes.ResumeLayout(false);
            this.grb_informacoesTelaPrincipal.ResumeLayout(false);
            this.grb_informacoesTelaPrincipal.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_table_control;
        private System.Windows.Forms.TabPage tbp_cores;
        private System.Windows.Forms.GroupBox grb_coresDER;
        private System.Windows.Forms.Button btn_info_corprimaria;
        private System.Windows.Forms.Label lbl_corPrimaria;
        private System.Windows.Forms.Panel pan_botton;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.TabPage tbp_informacoes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_gravarInfromacoes;
        private System.Windows.Forms.Button btn_corSecundaria;
        private System.Windows.Forms.Button btn_colorPickerPrimario;
        private System.Windows.Forms.Button btn_info_corSecundaria;
        private System.Windows.Forms.TextBox tbx_corSecundaria;
        private System.Windows.Forms.Label lbl_corSecundaria;
        private System.Windows.Forms.TextBox tbx_corPrimaria;
        private System.Windows.Forms.GroupBox grb_informacoesTelaPrincipal;
        private System.Windows.Forms.ComboBox cmb_opcaoQuantidade;
        private System.Windows.Forms.Button btn_info_Quantidade;
        private System.Windows.Forms.Label lbl_quantidade;
    }
}