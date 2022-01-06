namespace Visao
{
    partial class FO_VincularTabelaModulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FO_VincularTabelaModulo));
            this.pan_botton = new System.Windows.Forms.Panel();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.pan_complet = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckb_todosCampos = new System.Windows.Forms.CheckBox();
            this.btn_info_campo = new System.Windows.Forms.Button();
            this.btn_info_nomeprojeto = new System.Windows.Forms.Button();
            this.cmb_campos = new System.Windows.Forms.ComboBox();
            this.lbl_campos = new System.Windows.Forms.Label();
            this.cmb_tables = new System.Windows.Forms.ComboBox();
            this.lbl_tabelas = new System.Windows.Forms.Label();
            this.lbl_nomeModulo = new System.Windows.Forms.Label();
            this.pan_botton.SuspendLayout();
            this.pan_complet.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_botton
            // 
            this.pan_botton.Controls.Add(this.btn_confirmar);
            this.pan_botton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_botton.Location = new System.Drawing.Point(0, 135);
            this.pan_botton.Name = "pan_botton";
            this.pan_botton.Size = new System.Drawing.Size(346, 35);
            this.pan_botton.TabIndex = 12;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_confirmar.Location = new System.Drawing.Point(268, 3);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(75, 29);
            this.btn_confirmar.TabIndex = 10;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // pan_complet
            // 
            this.pan_complet.Controls.Add(this.groupBox1);
            this.pan_complet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_complet.Location = new System.Drawing.Point(0, 0);
            this.pan_complet.Name = "pan_complet";
            this.pan_complet.Size = new System.Drawing.Size(346, 135);
            this.pan_complet.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckb_todosCampos);
            this.groupBox1.Controls.Add(this.btn_info_campo);
            this.groupBox1.Controls.Add(this.btn_info_nomeprojeto);
            this.groupBox1.Controls.Add(this.cmb_campos);
            this.groupBox1.Controls.Add(this.lbl_campos);
            this.groupBox1.Controls.Add(this.cmb_tables);
            this.groupBox1.Controls.Add(this.lbl_tabelas);
            this.groupBox1.Controls.Add(this.lbl_nomeModulo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vínculo entre módulo e tabela";
            // 
            // ckb_todosCampos
            // 
            this.ckb_todosCampos.AutoSize = true;
            this.ckb_todosCampos.Location = new System.Drawing.Point(15, 71);
            this.ckb_todosCampos.Name = "ckb_todosCampos";
            this.ckb_todosCampos.Size = new System.Drawing.Size(127, 20);
            this.ckb_todosCampos.TabIndex = 8;
            this.ckb_todosCampos.Text = "Todos os campos";
            this.ckb_todosCampos.UseVisualStyleBackColor = true;
            this.ckb_todosCampos.CheckedChanged += new System.EventHandler(this.ckb_todosCampos_CheckedChanged);
            // 
            // btn_info_campo
            // 
            this.btn_info_campo.BackgroundImage = global::Pj.Properties.Resources.png_infoProdutoBlack20x20;
            this.btn_info_campo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_campo.Location = new System.Drawing.Point(312, 99);
            this.btn_info_campo.Name = "btn_info_campo";
            this.btn_info_campo.Size = new System.Drawing.Size(20, 20);
            this.btn_info_campo.TabIndex = 7;
            this.btn_info_campo.UseVisualStyleBackColor = true;
            this.btn_info_campo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_info_nomeprojeto
            // 
            this.btn_info_nomeprojeto.BackgroundImage = global::Pj.Properties.Resources.png_infoProdutoBlack20x20;
            this.btn_info_nomeprojeto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_nomeprojeto.Location = new System.Drawing.Point(312, 45);
            this.btn_info_nomeprojeto.Name = "btn_info_nomeprojeto";
            this.btn_info_nomeprojeto.Size = new System.Drawing.Size(20, 20);
            this.btn_info_nomeprojeto.TabIndex = 7;
            this.btn_info_nomeprojeto.UseVisualStyleBackColor = true;
            this.btn_info_nomeprojeto.Click += new System.EventHandler(this.btn_info_nomeprojeto_Click);
            // 
            // cmb_campos
            // 
            this.cmb_campos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_campos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_campos.FormattingEnabled = true;
            this.cmb_campos.Location = new System.Drawing.Point(69, 98);
            this.cmb_campos.Name = "cmb_campos";
            this.cmb_campos.Size = new System.Drawing.Size(237, 23);
            this.cmb_campos.TabIndex = 2;
            // 
            // lbl_campos
            // 
            this.lbl_campos.AutoSize = true;
            this.lbl_campos.Location = new System.Drawing.Point(12, 102);
            this.lbl_campos.Name = "lbl_campos";
            this.lbl_campos.Size = new System.Drawing.Size(54, 16);
            this.lbl_campos.TabIndex = 1;
            this.lbl_campos.Text = "Campos";
            // 
            // cmb_tables
            // 
            this.cmb_tables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tables.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_tables.FormattingEnabled = true;
            this.cmb_tables.Location = new System.Drawing.Point(69, 44);
            this.cmb_tables.Name = "cmb_tables";
            this.cmb_tables.Size = new System.Drawing.Size(237, 23);
            this.cmb_tables.TabIndex = 2;
            this.cmb_tables.SelectedIndexChanged += new System.EventHandler(this.cmb_tables_SelectedIndexChanged);
            // 
            // lbl_tabelas
            // 
            this.lbl_tabelas.AutoSize = true;
            this.lbl_tabelas.Location = new System.Drawing.Point(12, 48);
            this.lbl_tabelas.Name = "lbl_tabelas";
            this.lbl_tabelas.Size = new System.Drawing.Size(50, 16);
            this.lbl_tabelas.TabIndex = 1;
            this.lbl_tabelas.Text = "Tabelas";
            // 
            // lbl_nomeModulo
            // 
            this.lbl_nomeModulo.AutoSize = true;
            this.lbl_nomeModulo.Location = new System.Drawing.Point(12, 22);
            this.lbl_nomeModulo.Name = "lbl_nomeModulo";
            this.lbl_nomeModulo.Size = new System.Drawing.Size(51, 16);
            this.lbl_nomeModulo.TabIndex = 1;
            this.lbl_nomeModulo.Text = "Módulo";
            // 
            // FO_VincularTabelaModulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(346, 170);
            this.Controls.Add(this.pan_complet);
            this.Controls.Add(this.pan_botton);
            this.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FO_VincularTabelaModulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vinculo";
            this.pan_botton.ResumeLayout(false);
            this.pan_complet.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_botton;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Panel pan_complet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_nomeModulo;
        private System.Windows.Forms.ComboBox cmb_tables;
        private System.Windows.Forms.Label lbl_tabelas;
        private System.Windows.Forms.Button btn_info_nomeprojeto;
        private System.Windows.Forms.Button btn_info_campo;
        private System.Windows.Forms.ComboBox cmb_campos;
        private System.Windows.Forms.Label lbl_campos;
        private System.Windows.Forms.CheckBox ckb_todosCampos;
    }
}