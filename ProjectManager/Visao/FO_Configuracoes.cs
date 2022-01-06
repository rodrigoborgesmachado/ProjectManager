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
    public partial class FO_Configuracoes : Form
    {
        #region Eventos

        /// <summary>
        /// Evento lançado no clique do botão de informação sobre a cor primária
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_corprimaria_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Configuracoes.btn_info_corprimaria_Click()", Util.Global.TipoLog.DETALHADO);

            Visao.Message.MensagemInformacao("Cor primária do DER");
        }

        /// <summary>
        /// Evento lançado no clique do botão de informação sobre a cor primária
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_corSecundaria_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Configuracoes.btn_info_corSecundaria_Click()", Util.Global.TipoLog.DETALHADO);

            Visao.Message.MensagemInformacao("Cor secundária do DER");
        }

        /// <summary>
        /// Evento lançado no clique da opção de cor primária
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_colorPickerPrimario_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Configuracoes.btn_colorPickerPrimario_Click()", Util.Global.TipoLog.DETALHADO);

            AbreSeletorDeCores(ref this.tbx_corPrimaria);
        }

        /// <summary>
        /// Evento lançado no clique da opção de cor secundária
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_corSecundaria_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Configuracoes.btn_corSecundaria_Click()", Util.Global.TipoLog.DETALHADO);

            AbreSeletorDeCores(ref this.tbx_corSecundaria);
        }

        /// <summary>
        /// Evento lançado no clique do botão confirmar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Configuracoes.btn_confirmar_Click()", Util.Global.TipoLog.DETALHADO);

            ConfirmarFormulario();
        }

        /// <summary>
        /// Evento lançado no clique do botão de gravar em informações
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_gravarInfromacoes_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Configuracoes.btn_gravarInfromacoes_Click()", Util.Global.TipoLog.DETALHADO);

            ConfirmarFormulario();
        }

        #endregion Eventos

        #region Construtores

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        public FO_Configuracoes()
        {
            Util.CL_Files.WriteOnTheLog("FO_Configuracoes()", Util.Global.TipoLog.DETALHADO);

            InitializeComponent();
            this.InicializaForm();
        }

        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Método que inicializa o formulário
        /// </summary>
        public void InicializaForm()
        {
            Util.CL_Files.WriteOnTheLog("FO_Configuracoes.InicializaForm()", Util.Global.TipoLog.DETALHADO);

            PreencheParametros();
        }

        /// <summary>
        /// Método que preenche os valor dos parâmetros
        /// </summary>
        public void PreencheParametros()
        {
            Util.CL_Files.WriteOnTheLog("FO_Configuracoes.PreencheParametros()", Util.Global.TipoLog.DETALHADO);

            this.PreencheValoresDasCores();
            this.PreencheValorInformacoes();

        }

        /// <summary>
        /// Método que preenche o valor das informações
        /// </summary>
        private void PreencheValorInformacoes()
        {
            Util.CL_Files.WriteOnTheLog("FO_Configuracoes.PreencheValorInformacoes()", Util.Global.TipoLog.DETALHADO);

            this.PreencheInformacoesTelaPrincipal();
        }

        /// <summary>
        /// Método que preenche as informações da tela principal
        /// </summary>
        private void PreencheInformacoesTelaPrincipal()
        {
            Util.CL_Files.WriteOnTheLog("FO_Configuracoes.PreencheInformacoesTelaPrincipal()", Util.Global.TipoLog.DETALHADO);

            this.cmb_opcaoQuantidade.SelectedIndex = Regras.Parametros.ApresentaQuantidades.DAO.Valor.Equals("0") ? 0 : 1;
        }

        /// <summary>
        /// Método que preenche os valores da aba Cores
        /// </summary>
        public void PreencheValoresDasCores()
        {
            Util.CL_Files.WriteOnTheLog("FO_Configuracoes.PreencheValoresDasCores()", Util.Global.TipoLog.DETALHADO);

            PreencheCoresDoDer();
        }

        /// <summary>
        /// Método que preenche os valores dos parâmetros das cores do DER
        /// </summary>
        public void PreencheCoresDoDer()
        {
            Util.CL_Files.WriteOnTheLog("FO_Configuracoes.PreencheCoresDoDer()", Util.Global.TipoLog.DETALHADO);

            this.tbx_corPrimaria.Text = Regras.Parametros.CorPrimariaDER.DAO.Valor;
            this.tbx_corSecundaria.Text = Regras.Parametros.CorSecundariaDER.DAO.Valor;
        }

        /// <summary>
        /// Método que abre o seletor de cores
        /// </summary>
        /// <param name="text">textbox a ser preenchido com a cor selecionada</param>
        private void AbreSeletorDeCores(ref TextBox text)
        {
            Util.CL_Files.WriteOnTheLog("FO_Configuracoes.AbreSeletorDeCores()", Util.Global.TipoLog.DETALHADO);

            string mensagem = string.Empty;
            Util.Cor cor = new Util.Cor(text.Text.Replace("rgb(", "").Replace(")", ""), ref mensagem);

            ColorDialog colorDialog = new ColorDialog();

            colorDialog.Color = Color.FromArgb(cor.r, cor.g, cor.b);
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Util.Cor resultado = new Util.Cor(colorDialog.Color.R + "," + colorDialog.Color.G + "," + colorDialog.Color.B, ref mensagem);
                text.Text = "rgb(" + resultado.r + "," + resultado.g + "," + resultado.b + ")";
            }
        }

        /// <summary>
        /// Método que processa o formúlário
        /// </summary>
        private void ConfirmarFormulario()
        {
            Util.CL_Files.WriteOnTheLog("FO_Configuracoes.ConfirmarFormulario()", Util.Global.TipoLog.DETALHADO);

            if (this.ConfirmaCores() && this.ConfirmaInformacoes())
            {
                Visao.Message.MensagemSucesso("Salvo com sucesso!");
            }
            else
            {
                Visao.Message.MensagemErro("Erro! Verificar log!");
            }
        }

        /// <summary>
        /// Método que confirma as cores 
        /// </summary>
        /// <returns>True - Confirmado com sucesso; False - Erro</returns>
        private bool ConfirmaCores()
        {
            Util.CL_Files.WriteOnTheLog("FO_Configuracoes.ConfirmaCores()", Util.Global.TipoLog.DETALHADO);

            try
            {
                Regras.Parametros.CorPrimariaDER.DAO.Valor = this.tbx_corPrimaria.Text;
                Regras.Parametros.CorPrimariaDER.DAO.Update();

                Regras.Parametros.CorSecundariaDER.DAO.Valor = this.tbx_corSecundaria.Text;
                Regras.Parametros.CorSecundariaDER.DAO.Update();
            }
            catch (Exception e)
            {
                Util.CL_Files.WriteOnTheLog("Erro: " + e.Message, Util.Global.TipoLog.SIMPLES);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Método que confirma as informações
        /// </summary>
        /// <returns>true - confirmado sem erro; false - erro</returns>
        private bool ConfirmaInformacoes()
        {
            Util.CL_Files.WriteOnTheLog("FO_Configuracoes.ConfirmaInformacoes()", Util.Global.TipoLog.DETALHADO);

            try
            {
                Regras.Parametros.ApresentaQuantidades.DAO.Valor = this.cmb_opcaoQuantidade.SelectedIndex == 0 ? "0" : "1";
                Regras.Parametros.ApresentaQuantidades.DAO.Update();
            }
            catch (Exception e)
            {
                Util.CL_Files.WriteOnTheLog("Erro: " + e.Message, Util.Global.TipoLog.SIMPLES);
                return false;
            }
            return true;
        }

        #endregion Métodos

    }
}
