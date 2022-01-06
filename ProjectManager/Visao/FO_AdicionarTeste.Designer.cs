namespace Visao
{
    partial class FO_AdicionarTeste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FO_AdicionarTeste));
            this.pan_botton = new System.Windows.Forms.Panel();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.pan_form = new System.Windows.Forms.Panel();
            this.grb_formulario = new System.Windows.Forms.GroupBox();
            this.btn_info_status = new System.Windows.Forms.Button();
            this.cmb_comboStatus = new System.Windows.Forms.ComboBox();
            this.btn_info_notas = new System.Windows.Forms.Button();
            this.btn_infoDescrição = new System.Windows.Forms.Button();
            this.tbx_notas = new System.Windows.Forms.TextBox();
            this.tbx_descricao = new System.Windows.Forms.TextBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_notas = new System.Windows.Forms.Label();
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.pan_botton.SuspendLayout();
            this.pan_form.SuspendLayout();
            this.grb_formulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_botton
            // 
            this.pan_botton.Controls.Add(this.btn_confirmar);
            this.pan_botton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pan_botton.Location = new System.Drawing.Point(0, 220);
            this.pan_botton.Name = "pan_botton";
            this.pan_botton.Size = new System.Drawing.Size(434, 35);
            this.pan_botton.TabIndex = 13;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_confirmar.Location = new System.Drawing.Point(356, 3);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(75, 29);
            this.btn_confirmar.TabIndex = 7;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // pan_form
            // 
            this.pan_form.Controls.Add(this.grb_formulario);
            this.pan_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_form.Location = new System.Drawing.Point(0, 0);
            this.pan_form.Name = "pan_form";
            this.pan_form.Size = new System.Drawing.Size(434, 220);
            this.pan_form.TabIndex = 14;
            // 
            // grb_formulario
            // 
            this.grb_formulario.Controls.Add(this.btn_info_status);
            this.grb_formulario.Controls.Add(this.cmb_comboStatus);
            this.grb_formulario.Controls.Add(this.btn_info_notas);
            this.grb_formulario.Controls.Add(this.btn_infoDescrição);
            this.grb_formulario.Controls.Add(this.tbx_notas);
            this.grb_formulario.Controls.Add(this.tbx_descricao);
            this.grb_formulario.Controls.Add(this.lbl_status);
            this.grb_formulario.Controls.Add(this.lbl_notas);
            this.grb_formulario.Controls.Add(this.lbl_descricao);
            this.grb_formulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_formulario.Location = new System.Drawing.Point(0, 0);
            this.grb_formulario.Name = "grb_formulario";
            this.grb_formulario.Size = new System.Drawing.Size(434, 220);
            this.grb_formulario.TabIndex = 0;
            this.grb_formulario.TabStop = false;
            this.grb_formulario.Text = "Cadastro de caso de teste";
            // 
            // btn_info_status
            // 
            this.btn_info_status.BackgroundImage = global::Pj.Properties.Resources.png_infoProdutoBlack20x20;
            this.btn_info_status.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_status.Location = new System.Drawing.Point(242, 190);
            this.btn_info_status.Name = "btn_info_status";
            this.btn_info_status.Size = new System.Drawing.Size(20, 20);
            this.btn_info_status.TabIndex = 6;
            this.btn_info_status.UseVisualStyleBackColor = true;
            this.btn_info_status.Click += new System.EventHandler(this.btn_info_status_Click);
            // 
            // cmb_comboStatus
            // 
            this.cmb_comboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_comboStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_comboStatus.FormattingEnabled = true;
            this.cmb_comboStatus.Items.AddRange(new object[] {
            "Sucesso",
            "Erro"});
            this.cmb_comboStatus.Location = new System.Drawing.Point(82, 187);
            this.cmb_comboStatus.Name = "cmb_comboStatus";
            this.cmb_comboStatus.Size = new System.Drawing.Size(154, 23);
            this.cmb_comboStatus.TabIndex = 5;
            // 
            // btn_info_notas
            // 
            this.btn_info_notas.BackgroundImage = global::Pj.Properties.Resources.png_infoProdutoBlack20x20;
            this.btn_info_notas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_notas.Location = new System.Drawing.Point(408, 103);
            this.btn_info_notas.Name = "btn_info_notas";
            this.btn_info_notas.Size = new System.Drawing.Size(20, 20);
            this.btn_info_notas.TabIndex = 4;
            this.btn_info_notas.UseVisualStyleBackColor = true;
            this.btn_info_notas.Click += new System.EventHandler(this.btn_info_notas_Click);
            // 
            // btn_infoDescrição
            // 
            this.btn_infoDescrição.BackgroundImage = global::Pj.Properties.Resources.png_infoProdutoBlack20x20;
            this.btn_infoDescrição.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_infoDescrição.Location = new System.Drawing.Point(408, 21);
            this.btn_infoDescrição.Name = "btn_infoDescrição";
            this.btn_infoDescrição.Size = new System.Drawing.Size(20, 20);
            this.btn_infoDescrição.TabIndex = 2;
            this.btn_infoDescrição.UseVisualStyleBackColor = true;
            this.btn_infoDescrição.Click += new System.EventHandler(this.btn_infoDescricao);
            // 
            // tbx_notas
            // 
            this.tbx_notas.AcceptsTab = true;
            this.tbx_notas.Location = new System.Drawing.Point(82, 103);
            this.tbx_notas.MaxLength = 500;
            this.tbx_notas.Multiline = true;
            this.tbx_notas.Name = "tbx_notas";
            this.tbx_notas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_notas.Size = new System.Drawing.Size(320, 74);
            this.tbx_notas.TabIndex = 3;
            // 
            // tbx_descricao
            // 
            this.tbx_descricao.AcceptsTab = true;
            this.tbx_descricao.Location = new System.Drawing.Point(82, 21);
            this.tbx_descricao.MaxLength = 800;
            this.tbx_descricao.Multiline = true;
            this.tbx_descricao.Name = "tbx_descricao";
            this.tbx_descricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_descricao.Size = new System.Drawing.Size(320, 74);
            this.tbx_descricao.TabIndex = 1;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(12, 187);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(43, 16);
            this.lbl_status.TabIndex = 8;
            this.lbl_status.Text = "Status";
            // 
            // lbl_notas
            // 
            this.lbl_notas.AutoSize = true;
            this.lbl_notas.Location = new System.Drawing.Point(12, 106);
            this.lbl_notas.Name = "lbl_notas";
            this.lbl_notas.Size = new System.Drawing.Size(41, 16);
            this.lbl_notas.TabIndex = 8;
            this.lbl_notas.Text = "Notas";
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.Location = new System.Drawing.Point(12, 24);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(64, 16);
            this.lbl_descricao.TabIndex = 8;
            this.lbl_descricao.Text = "Descrição";
            // 
            // FO_AdicionarTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(434, 255);
            this.Controls.Add(this.pan_form);
            this.Controls.Add(this.pan_botton);
            this.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FO_AdicionarTeste";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FO_AdicionarTeste";
            this.pan_botton.ResumeLayout(false);
            this.pan_form.ResumeLayout(false);
            this.grb_formulario.ResumeLayout(false);
            this.grb_formulario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_botton;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Panel pan_form;
        private System.Windows.Forms.GroupBox grb_formulario;
        private System.Windows.Forms.Button btn_infoDescrição;
        private System.Windows.Forms.TextBox tbx_descricao;
        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.Button btn_info_notas;
        private System.Windows.Forms.TextBox tbx_notas;
        private System.Windows.Forms.Label lbl_notas;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.ComboBox cmb_comboStatus;
        private System.Windows.Forms.Button btn_info_status;
    }
}