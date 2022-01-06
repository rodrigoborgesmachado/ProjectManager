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
    public partial class FO_CadastroProjeto : Form
    {
        #region Atributos e Propriedades

        /// <summary>
        /// Classe principal
        /// </summary>
        FO_Principal principal;

        #endregion Atributos e Propriedades

        #region Eventos

        /// <summary>
        /// Evento lançado no clique do botão de informação do nome do projeto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_nomeprojeto_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_CadastroProjeto.btn_info_nomeprojeto_Click()", Util.Global.TipoLog.DETALHADO);

            Visao.Message.MensagemInformacao("Nome do projeto");
        }

        /// <summary>
        /// Evento lançado no clique do botão de informação da descrição do projeto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_descricaoProjeto_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_CadastroProjeto.btn_info_descricaoProjeto_Click()", Util.Global.TipoLog.DETALHADO);

            Visao.Message.MensagemInformacao("Descrição do projeto");
        }

        /// <summary>
        /// Evento lançado no clique do botão confirmar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_CadastroProjeto.btn_confirmar_Click()", Util.Global.TipoLog.DETALHADO);

            this.Confirmar();
        }

        #endregion Eventos

        #region Construtores

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        public FO_CadastroProjeto(FO_Principal principal)
        {
            Util.CL_Files.WriteOnTheLog("FO_CadastroProjeto()", Util.Global.TipoLog.DETALHADO);

            InitializeComponent();
            this.principal = principal;
            this.InicializaForm();
        }

        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Método que inicializa o forms
        /// </summary>
        private void InicializaForm()
        {
            Util.CL_Files.WriteOnTheLog("FO_CadastroProjeto.InicializaForm()", Util.Global.TipoLog.DETALHADO);

        }

        /// <summary>
        /// Método que valida se o formulário está válido
        /// </summary>
        /// <returns>True - válido; false - inválido</returns>
        private bool FormalurioValido(ref string mensagem)
        {
            Util.CL_Files.WriteOnTheLog("FO_CadastroProjeto.FormalurioValido()", Util.Global.TipoLog.DETALHADO);

            bool retorno = true;

            if (string.IsNullOrEmpty(this.tbx_nomeprojeto.Text))
            {
                this.tbx_nomeprojeto.Focus();
                mensagem = "Nome do projeto não pode estar vazio!";
            }

            return retorno;
        }

        /// <summary>
        /// Método que confirma o formulário
        /// </summary>
        private void Confirmar()
        {
            Util.CL_Files.WriteOnTheLog("FO_CadastroProjeto.Confirmar()", Util.Global.TipoLog.DETALHADO);

            string mensagem = string.Empty;
            if (this.FormalurioValido(ref mensagem))
            {
                Model.MD_Projeto temp = new Model.MD_Projeto(-1);

                this.principal.projeto = new Model.MD_Projeto(DataBase.Connection.GetIncrement(temp.DAO.table.Table_Name));
                this.principal.projeto.DAO.Nome = this.tbx_nomeprojeto.Text;
                this.principal.projeto.DAO.Descricao = this.tbx_descricaoProjeto.Text;
                temp = null;

                if (this.principal.projeto.DAO.Insert())
                {
                    Visao.Message.MensagemSucesso("Cadastrado o novo projeto");
                    this.DialogResult = DialogResult.OK;
                    this.Dispose();
                }
                else
                {
                    Visao.Message.MensagemErro("Erro! Verificar Log!");
                }
            }
            else
            {
                Visao.Message.MensagemAlerta(mensagem);
            }
        }

        #endregion Métodos

    }
}
