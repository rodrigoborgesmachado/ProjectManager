using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Visao
{
    public partial class FO_Login : Form
    {
        public FO_Login()
        {
            InitializeComponent();
            this.lbl_versao.Text = "Versão: " + Regras.Versao.Version.DAO.Dercreator;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var task = Util.WebUtil.Login.ValidaLoginAsync(this.tbx_login.Text, Hash(this.tbx_password.Text).ToString());
            while (!task.IsCompleted) ;

            if (task.Result)
            {
                this.DialogResult = DialogResult.OK;
                this.Dispose();
            }
            else
            {
                Visao.Message.MensagemAlerta("Login inválido!");
            }
        }

        private long Hash(string texto)
        {
            long hash = 0;

            if (texto.Length == 0) return hash;

            for (int i = 0; i < texto.Length; i++)
            {
                int t = (int)texto[i];
                hash = ((hash << 5) - hash) + t;
                hash = hash & hash;
            }

            return hash;
        }

        private void FO_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
