namespace Visao
{
    partial class FO_GerarHash
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
            this.tbx_texto = new System.Windows.Forms.TextBox();
            this.lbl_texto = new System.Windows.Forms.Label();
            this.btn_info_titulo = new System.Windows.Forms.Button();
            this.grb_gerarHash = new System.Windows.Forms.GroupBox();
            this.tbx_hash = new System.Windows.Forms.TextBox();
            this.lbl_hash = new System.Windows.Forms.Label();
            this.pan_tot.SuspendLayout();
            this.grb_gerarHash.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan_tot
            // 
            this.pan_tot.Controls.Add(this.grb_gerarHash);
            this.pan_tot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan_tot.Location = new System.Drawing.Point(0, 0);
            this.pan_tot.Name = "pan_tot";
            this.pan_tot.Size = new System.Drawing.Size(331, 114);
            this.pan_tot.TabIndex = 0;
            // 
            // tbx_texto
            // 
            this.tbx_texto.Location = new System.Drawing.Point(89, 16);
            this.tbx_texto.MaxLength = 300;
            this.tbx_texto.Name = "tbx_texto";
            this.tbx_texto.Size = new System.Drawing.Size(201, 23);
            this.tbx_texto.TabIndex = 6;
            // 
            // lbl_texto
            // 
            this.lbl_texto.AutoSize = true;
            this.lbl_texto.Location = new System.Drawing.Point(12, 19);
            this.lbl_texto.Name = "lbl_texto";
            this.lbl_texto.Size = new System.Drawing.Size(40, 16);
            this.lbl_texto.TabIndex = 8;
            this.lbl_texto.Text = "Texto";
            // 
            // btn_info_titulo
            // 
            this.btn_info_titulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_info_titulo.Location = new System.Drawing.Point(15, 45);
            this.btn_info_titulo.Name = "btn_info_titulo";
            this.btn_info_titulo.Size = new System.Drawing.Size(126, 28);
            this.btn_info_titulo.TabIndex = 7;
            this.btn_info_titulo.Text = "Gerar hash";
            this.btn_info_titulo.UseVisualStyleBackColor = true;
            this.btn_info_titulo.Click += new System.EventHandler(this.btn_info_titulo_Click);
            // 
            // grb_gerarHash
            // 
            this.grb_gerarHash.Controls.Add(this.lbl_hash);
            this.grb_gerarHash.Controls.Add(this.lbl_texto);
            this.grb_gerarHash.Controls.Add(this.tbx_hash);
            this.grb_gerarHash.Controls.Add(this.tbx_texto);
            this.grb_gerarHash.Controls.Add(this.btn_info_titulo);
            this.grb_gerarHash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_gerarHash.Location = new System.Drawing.Point(0, 0);
            this.grb_gerarHash.Name = "grb_gerarHash";
            this.grb_gerarHash.Size = new System.Drawing.Size(331, 114);
            this.grb_gerarHash.TabIndex = 9;
            this.grb_gerarHash.TabStop = false;
            this.grb_gerarHash.Text = "Formulário";
            // 
            // tbx_hash
            // 
            this.tbx_hash.Location = new System.Drawing.Point(89, 79);
            this.tbx_hash.MaxLength = 300;
            this.tbx_hash.Name = "tbx_hash";
            this.tbx_hash.Size = new System.Drawing.Size(201, 23);
            this.tbx_hash.TabIndex = 6;
            // 
            // lbl_hash
            // 
            this.lbl_hash.AutoSize = true;
            this.lbl_hash.Location = new System.Drawing.Point(12, 82);
            this.lbl_hash.Name = "lbl_hash";
            this.lbl_hash.Size = new System.Drawing.Size(36, 16);
            this.lbl_hash.TabIndex = 8;
            this.lbl_hash.Text = "Hash";
            // 
            // FO_GerarHash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(331, 114);
            this.Controls.Add(this.pan_tot);
            this.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.MaximizeBox = false;
            this.Name = "FO_GerarHash";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerar Hash";
            this.pan_tot.ResumeLayout(false);
            this.grb_gerarHash.ResumeLayout(false);
            this.grb_gerarHash.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan_tot;
        private System.Windows.Forms.Button btn_info_titulo;
        private System.Windows.Forms.TextBox tbx_texto;
        private System.Windows.Forms.Label lbl_texto;
        private System.Windows.Forms.GroupBox grb_gerarHash;
        private System.Windows.Forms.Label lbl_hash;
        private System.Windows.Forms.TextBox tbx_hash;
    }
}