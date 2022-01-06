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
    public partial class FO_AdicionarTeste : Form
    {
        #region Eventos

        /// <summary>
        /// Evento disparado no clique do botão de informação da descrição
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_infoDescricao(object sender, EventArgs e)
        {
            Visao.Message.MensagemInformacao("Descrição do teste a ser feito");
        }

        /// <summary>
        /// Evento disparado no clique do botão de informação do botão notas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_notas_Click(object sender, EventArgs e)
        {
            Visao.Message.MensagemInformacao("Notas sobre o teste a ser feito");
        }

        /// <summary>
        /// Evento disparado no clique do botão de informação do botão status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_status_Click(object sender, EventArgs e)
        {
            Visao.Message.MensagemInformacao("Se o teste foi efetuado com sucesso ou não");
        }

        /// <summary>
        /// Evento disparado no cliqeu do botão confirmar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            this.Confirmar();
        }

        #endregion Eventos

        #region Construtores

        /// <summary>
        /// Construtores
        /// </summary>
        public FO_AdicionarTeste()
        {
            InitializeComponent();
        }

        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Método que valida o formulário
        /// </summary>
        /// <returns></returns>
        private bool ValidaFormulario()
        {
            bool retorno = true;

            if (string.IsNullOrEmpty(this.tbx_descricao.Text))
            {
                retorno = false;
                Visao.Message.MensagemInformacao("A descrição não pode estar em branco");
                this.tbx_descricao.Focus();
            }
            else if(this.cmb_comboStatus.SelectedIndex < 0)
            {
                retorno = false;
                Visao.Message.MensagemInformacao("Deve ser preenchido o status do teste");
                this.cmb_comboStatus.Focus();
            }

            return retorno;
        }

        /// <summary>
        /// Método que confirma o formulário
        /// </summary>
        private void Confirmar()
        {
            if (ValidaFormulario())
            {
                Model.MD_Tabelatestes teste = new Model.MD_Tabelatestes(-1);
                teste.DAO.Descricao = this.tbx_descricao.Text;
                teste.DAO.Notas = this.tbx_notas.Text;
                teste.DAO.Status = this.cmb_comboStatus.SelectedIndex == 0 ? "1" : "0";
                                
                if (InsereTemporaria(teste))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Dispose();
                }
                else
                {
                    Visao.Message.MensagemErro("Erro ao inserir");
                }
            }
        }

        /// <summary>
        /// Método que insere os dados na tabela temporária
        /// </summary>
        /// <param name="campos">Lista de campos a serem inseridos</param>
        /// <returns>True - </returns>
        private bool InsereTemporaria(Model.MD_Tabelatestes teste)
        {
            bool retorno = true;

            try
            {
                string sentenca = " INSERT INTO " + Util.Global.tempTable + " (DESCRICAO, NOTAS, STATUS) VALUES (#VALOR1, #VALOR2, #VALOR3)";

                sentenca = sentenca.Replace("#VALOR1", "'" + teste.DAO.Descricao.ToString() + "'").Replace("#VALOR2", "'" + teste.DAO.Notas.ToString() + "'").Replace("#VALOR3", "'" + teste.DAO.Status.ToString() + "'");
                DataBase.Connection.Insert(sentenca);
            }
            catch (Exception e)
            {
                retorno = false;
                Util.CL_Files.WriteOnTheLog("Error: " + e.Message, Util.Global.TipoLog.SIMPLES);
            }

            return retorno;
        }

        #endregion Métodos
    }
}
