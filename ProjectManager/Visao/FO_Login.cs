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
            if(Util.WebUtil.Login.ValidaLogin(this.tbx_login.Text, this.tbx_password.Text.GetHashCode().ToString()))
            {
                this.DialogResult = DialogResult.OK;
                this.Dispose();
            }
            else
            {
                Visao.Message.MensagemAlerta("Login inválido!");
            }
        }

        private void FO_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
