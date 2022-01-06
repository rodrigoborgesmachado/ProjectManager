using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visao
{
    public partial class FO_GerarHash : Form
    {
        public FO_GerarHash()
        {
            InitializeComponent();
        }

        private void btn_info_titulo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tbx_texto.Text))
            {
                Visao.Message.MensagemAlerta("O texto está em branco");
            }
            else
            {
                this.tbx_hash.Text = this.tbx_texto.Text.GetHashCode().ToString();
                Clipboard.SetText(this.tbx_hash.Text);
                Visao.Message.MensagemSucesso("O hash foi copiado para a área de transferência");
            }
        }
    }
}
