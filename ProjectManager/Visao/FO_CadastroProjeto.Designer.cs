namespace Visao
{
    partial class FO_CadastroProjeto
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
            this.pan_tot = new System.Windows.Forms.Panel();
            this.grb_Cadastro = new System.Windows.Forms.GroupBox();
            this.btn_info_descricaoProjeto = new System.Windows.Forms.Button();
            this.btn_info_nomeprojeto = new System.Windows.Forms.Button();
            this.tbx_descricaoProjeto = new System.Windows.Forms.TextBox();
            this.lbl_descricaoProjeto = new System.Windows.Forms.Label();
            this.tbx_nomeprojeto = new System.Windows.Forms.TextBox();
            this.lbl_projeto = new System.Windows.Forms.Label();
            this.pan_botton = new System.Windows.Forms.Panel();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.pan_tot.SuspendLayout();
            this.grb_Cadastro.SuspendLayout();
            this.pan_botton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_tot
            // 
            this.pan_tot.Controls.Add(this.grb_Cadastro);
            this.pan_tot.Controls.Add(this.pan_botton);
            this.pan_tot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_tot.Location = new System.Drawing.Point(0, 0);
            this.pan_tot.Name = "pan_tot";
            this.pan_tot.Size = new System.Drawing.Size(529, 198);
            this.pan_tot.TabIndex = 0;
            // 
            // grb_Cadastro
            // 
            this.grb_Cadastro.Controls.Add(this.btn_info_descricaoProjeto);
            this.grb_Cadastro.Controls.Add(this.btn_info_nomeprojeto);
            this.grb_Cadastro.Controls.Add(this.tbx_descricaoProjeto);
            this.grb_Cadastro.Controls.Add(this.lbl_descricaoProjeto);
            this.grb_Cadastro.Controls.Add(this.tbx_nomeprojeto);
            this.grb_Cadastro.Controls.Add(this.lbl_projeto);
            this.grb_Cadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_Cadastro.Location = new System.Drawing.Point(0, 0);
            this.grb_Cadastro.Name = "grb_Cadastro";
            this.grb_Cadastro.Size = new System.Drawing.Size(529, 163);
            this.grb_Cadastro.TabIndex = 12;
            this.grb_Cadastro.TabStop = false;
            this.grb_Cadastro.Text = "Relação";
            // 
            // btn_info_descricaoProjeto
            // 
            this.btn_info_descricaoProjeto.BackgroundImage = global::Pj.Properties.Resources.png_infoProdutoBlack20x20;
            this.btn_info_descricaoProjeto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_descricaoProjeto.Location = new System.Drawing.Point(464, 53);
            this.btn_info_descricaoProjeto.Name = "btn_info_descricaoProjeto";
            this.btn_info_descricaoProjeto.Size = new System.Drawing.Size(20, 20);
            this.btn_info_descricaoProjeto.TabIndex = 6;
            this.btn_info_descricaoProjeto.UseVisualStyleBackColor = true;
            this.btn_info_descricaoProjeto.Click += new System.EventHandler(this.btn_info_descricaoProjeto_Click);
            // 
            // btn_info_nomeprojeto
            // 
            this.btn_info_nomeprojeto.BackgroundImage = global::Pj.Properties.Resources.png_infoProdutoBlack20x20;
            this.btn_info_nomeprojeto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_nomeprojeto.Location = new System.Drawing.Point(464, 24);
            this.btn_info_nomeprojeto.Name = "btn_info_nomeprojeto";
            this.btn_info_nomeprojeto.Size = new System.Drawing.Size(20, 20);
            this.btn_info_nomeprojeto.TabIndex = 6;
            this.btn_info_nomeprojeto.UseVisualStyleBackColor = true;
            this.btn_info_nomeprojeto.Click += new System.EventHandler(this.btn_info_nomeprojeto_Click);
            // 
            // tbx_descricaoProjeto
            // 
            this.tbx_descricaoProjeto.AcceptsTab = true;
            this.tbx_descricaoProjeto.Location = new System.Drawing.Point(94, 51);
            this.tbx_descricaoProjeto.MaxLength = 30000;
            this.tbx_descricaoProjeto.Multiline = true;
            this.tbx_descricaoProjeto.Name = "tbx_descricaoProjeto";
            this.tbx_descricaoProjeto.Size = new System.Drawing.Size(364, 106);
            this.tbx_descricaoProjeto.TabIndex = 5;
            // 
            // lbl_descricaoProjeto
            // 
            this.lbl_descricaoProjeto.AutoSize = true;
            this.lbl_descricaoProjeto.Location = new System.Drawing.Point(11, 54);
            this.lbl_descricaoProjeto.Name = "lbl_descricaoProjeto";
            this.lbl_descricaoProjeto.Size = new System.Drawing.Size(64, 16);
            this.lbl_descricaoProjeto.TabIndex = 0;
            this.lbl_descricaoProjeto.Text = "Descrição";
            // 
            // tbx_nomeprojeto
            // 
            this.tbx_nomeprojeto.Location = new System.Drawing.Point(94, 22);
            this.tbx_nomeprojeto.MaxLength = 50;
            this.tbx_nomeprojeto.Name = "tbx_nomeprojeto";
            this.tbx_nomeprojeto.Size = new System.Drawing.Size(364, 23);
            this.tbx_nomeprojeto.TabIndex = 5;
            // 
            // lbl_projeto
            // 
            this.lbl_projeto.AutoSize = true;
            this.lbl_projeto.Location = new System.Drawing.Point(11, 25);
            this.lbl_projeto.Name = "lbl_projeto";
            this.lbl_projeto.Size = new System.Drawing.Size(48, 16);
            this.lbl_projeto.TabIndex = 0;
            this.lbl_projeto.Text = "Projeto";
            // 
            // pan_botton
            // 
            this.pan_botton.Controls.Add(this.btn_confirmar);
            this.pan_botton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_botton.Location = new System.Drawing.Point(0, 163);
            this.pan_botton.Name = "pan_botton";
            this.pan_botton.Size = new System.Drawing.Size(529, 35);
            this.pan_botton.TabIndex = 11;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_confirmar.Location = new System.Drawing.Point(451, 3);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(75, 29);
            this.btn_confirmar.TabIndex = 10;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // FO_CadastroProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(529, 198);
            this.Controls.Add(this.pan_tot);
            this.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FO_CadastroProjeto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Projeto";
            this.pan_tot.ResumeLayout(false);
            this.grb_Cadastro.ResumeLayout(false);
            this.grb_Cadastro.PerformLayout();
            this.pan_botton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_tot;
        private System.Windows.Forms.Panel pan_botton;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.GroupBox grb_Cadastro;
        private System.Windows.Forms.Button btn_info_nomeprojeto;
        private System.Windows.Forms.TextBox tbx_nomeprojeto;
        private System.Windows.Forms.Label lbl_projeto;
        private System.Windows.Forms.Button btn_info_descricaoProjeto;
        private System.Windows.Forms.TextBox tbx_descricaoProjeto;
        private System.Windows.Forms.Label lbl_descricaoProjeto;
    }
}