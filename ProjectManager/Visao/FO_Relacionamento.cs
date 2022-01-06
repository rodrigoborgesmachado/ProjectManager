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
    public partial class FO_Relacionamento : Form
    {
        #region Atributos e Propriedades

        bool lockchange = false;

        /// <summary>
        /// Tabela do campo de origem
        /// </summary>
        Model.MD_Campos campoOrigem = new Model.MD_Campos(-1,-1,-1);

        /// <summary>
        /// Tabela de campo de destino
        /// </summary>
        Model.MD_Campos campoDestino = null;

        /// <summary>
        /// Tabela de relacao
        /// </summary>
        Model.MD_Relacao relacao = null;

        /// <summary>
        /// Controle da tela principal
        /// </summary>
        FO_Principal principal = null;

        /// <summary>
        /// tarefa a ser executada na tela 
        /// </summary>
        Util.Enumerator.Tarefa tarefa = Util.Enumerator.Tarefa.VISUALIZANDO;

        #endregion Atributos e Propriedades

        #region Eventos

        /// <summary>
        /// Evento lançado no clique do botão excluir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Relacionamento.btn_excluir_Click()", Util.Global.TipoLog.DETALHADO);

            this.Excluir();
        }

        /// <summary>
        /// Evento lançado no clique do botão confirmar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Relacionamento.btn_confirmar_Click()", Util.Global.TipoLog.DETALHADO);

            this.Confirmar();
        }

        /// <summary>
        /// Evento lançado quando alterado a tabela selecionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_tabela_SelectedIndexChanged(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Relacionamento.cmb_tabela_SelectedIndexChanged()", Util.Global.TipoLog.DETALHADO);

            if (lockchange)
                return;
            this.CarregaComboCampos();
        }

        /// <summary>
        /// Evento lançado no clique de informação no botão tabela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_tabela_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Relacionamento.btn_info_tabela_Click()", Util.Global.TipoLog.DETALHADO);

            Visao.Message.MensagemInformacao("Tabela que o campo " + this.campoOrigem.DAO.Tabela.Nome + "." + this.campoOrigem.DAO.Nome + "  será relacionado!");
        }

        /// <summary>
        /// Evento lançado no clique de informação no botão campo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_campo_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Relacionamento.btn_info_campo_Click()", Util.Global.TipoLog.DETALHADO);

            Message.MensagemInformacao("Campo que o campo " + this.campoOrigem.DAO.Tabela.Nome + "." + this.campoOrigem.DAO.Nome + "  será relacionado!");
        }

        /// <summary>
        /// Evento lançado no clique de informação no botão Foreing Key
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_foreingkey_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Relacionamento.btn_info_foreingkey_Click()", Util.Global.TipoLog.DETALHADO);

            Message.MensagemInformacao("Nome da foreing key de relacionamento");
        }

        /// <summary>
        /// Evento lançado no clique de informação no botão cardinalidade
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cardinalidade_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Relacionamento.btn_cardinalidade_Click()", Util.Global.TipoLog.DETALHADO);

            Message.MensagemInformacao("Cardinalidade do relacionamento");
        }

        #endregion Eventos

        #region Construtores

        /// <summary>
        /// Contrutor principal da classe
        /// </summary>
        /// <param name="tarefa">Tarefa a ser executada na tela</param>
        /// <param name="campoOrigem">Campo de origem do relacionamento</param>
        /// <param name="principal">tela principal para controle de eventos</param>
        public FO_Relacionamento(Util.Enumerator.Tarefa tarefa, Model.MD_Campos campoOrigem, FO_Principal principal, Model.MD_Relacao relacao = null)
        {
            Util.CL_Files.WriteOnTheLog("FO_Relacionamento()", Util.Global.TipoLog.DETALHADO);

            this.campoOrigem = campoOrigem;

            if (relacao != null)
            {
                this.campoDestino = new Model.MD_Campos(relacao.DAO.CampoDestino.Codigo, relacao.DAO.CampoDestino.Tabela.Codigo, relacao.DAO.CampoDestino.Projeto.Codigo);
            }

            this.relacao = relacao;
            this.principal = principal;
            this.tarefa = tarefa;
            this.InitializeComponent();
            this.InicializaForm();
        }

        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Método que inicializa a tela
        /// </summary>
        private void InicializaForm()
        {
            Util.CL_Files.WriteOnTheLog("FO_Relacionamento.InicializaForm()", Util.Global.TipoLog.DETALHADO);

            this.CarregaLabelCampo();
            this.CarregaComboTabelas();
            this.PreencheForm();
        }

        /// <summary>
        /// Método que carrega o nome de label do campo
        /// </summary>
        private void CarregaLabelCampo()
        {
            Util.CL_Files.WriteOnTheLog("FO_Relacionamento.CarregaLabelCampo()", Util.Global.TipoLog.DETALHADO);

            this.lbl_campoOrigem.Text = "Campo: " + this.campoOrigem.DAO.Tabela.Nome + "." + this.campoOrigem.DAO.Nome;
        }

        /// <summary>
        /// Método que carrega o combo de tabelas 
        /// </summary>
        private void CarregaComboTabelas()
        {
            Util.CL_Files.WriteOnTheLog("FO_Relacionamento.CarregaComboTabelas()", Util.Global.TipoLog.DETALHADO);

            lockchange = true;

            string sentenca = this.campoOrigem.DAO.Tabela.table.CreateCommandSQLTable() + " WHERE PROJETO = " + this.campoOrigem.DAO.Projeto.Codigo + " AND CODIGO <> " + this.campoOrigem.DAO.Tabela.Codigo + " ORDER BY NOME";

            DataTable table = new DataTable();
            table.Load(DataBase.Connection.Select(sentenca));
            this.cmb_tabela.DataSource = table.DefaultView;

            this.cmb_tabela.DisplayMember = "NOME";
            this.cmb_tabela.ValueMember = "CODIGO";
            this.cmb_tabela.SelectedIndex = 0;
            this.CarregaComboCampos();
            lockchange = false;
        }

        /// <summary>
        /// Método que carrega o combo de campos
        /// </summary>
        private void CarregaComboCampos()
        {
            Util.CL_Files.WriteOnTheLog("FO_Relacionamento.CarregaComboCampos()", Util.Global.TipoLog.DETALHADO);

            if (this.cmb_tabela.SelectedIndex < 0)
                return;

            lockchange = true;

            string sentenca = this.campoOrigem.DAO.table.CreateCommandSQLTable() + " WHERE CODIGOTABELA = " + this.cmb_tabela.SelectedValue;
            this.cmb_campos.DataSource = DataBase.Connection.Select(sentenca);
            this.cmb_campos.DisplayMember = "NOME";
            this.cmb_campos.ValueMember = "CODIGO";
            this.cmb_campos.SelectedIndex = 0;

            lockchange = false;
        }

        /// <summary>
        /// Método que preenche as labels
        /// </summary>
        public void PreencheForm()
        {
            Util.CL_Files.WriteOnTheLog("FO_Relacionamento.PreencheForm()", Util.Global.TipoLog.DETALHADO);

            if (this.tarefa == Util.Enumerator.Tarefa.VISUALIZANDO)
            {
                this.btn_confirmar.Text = "Editar";
                this.btn_excluir.Text = "Excluir";

                this.PreencheLabels();
                this.HabilitaCampos(false);
            }
            else
            {
                this.btn_confirmar.Text = "Confirmar";
                this.btn_excluir.Text = "Cancelar";

                if (this.tarefa == Util.Enumerator.Tarefa.EDITANDO)
                {
                    this.PreencheLabels();
                }

                this.HabilitaCampos(true);
            }
        }

        /// <summary>
        /// Método que preenche as labels do formulario
        /// </summary>
        private void PreencheLabels()
        {
            Util.CL_Files.WriteOnTheLog("FO_Relacionamento.PreencheLabels()", Util.Global.TipoLog.DETALHADO);

            if (relacao != null)
            {
                this.cmb_tabela.SelectedValue = this.relacao.DAO.CampoDestino.Tabela.Codigo;
                this.cmb_campos.SelectedValue = this.relacao.DAO.CampoDestino.Codigo;
                this.tbx_foreingKey.Text = this.relacao.DAO.NomeForeingKey;
                this.tbx_cardOrigem.Text = this.relacao.DAO.CardinalidadeOrigem;
                this.tbx_cardDestino.Text = this.relacao.DAO.CardinalidadeDestino;
            }
        }

        /// <summary>
        /// Método que habilita ou ndesabilita os campos
        /// </summary>
        /// <param name="habilita">True - habilita; False - desabilita</param>
        private void HabilitaCampos(bool habilita)
        {
            Util.CL_Files.WriteOnTheLog("FO_Relacionamento.HabilitaCampos()", Util.Global.TipoLog.DETALHADO);

            this.cmb_campos.Enabled = this.cmb_tabela.Enabled = this.tbx_foreingKey.Enabled = this.tbx_cardOrigem.Enabled = this.tbx_cardDestino.Enabled = habilita;
        }

        /// <summary>
        /// Método que valida se o formulário foi preenchido corretamente
        /// </summary>
        /// <returns>True - sucesso; False - erro</returns>
        private bool VerificaCampos()
        {
            Util.CL_Files.WriteOnTheLog("FO_Relacionamento.VerificaCampos()", Util.Global.TipoLog.DETALHADO);

            bool retorno = true;

            if (this.cmb_tabela.SelectedIndex < 0)
            {
                retorno = false;
                Message.MensagemAlerta("A tabela de destino deve ser preenchida");
                this.cmb_tabela.Focus();
            }
            else if (this.cmb_campos.SelectedIndex < 0)
            {
                retorno = false;
                Message.MensagemAlerta("O campo de destino deve ser preenchido");
                this.cmb_campos.Focus();
            }
            else if (string.IsNullOrEmpty(this.tbx_cardOrigem.Text) || string.IsNullOrEmpty(this.tbx_cardDestino.Text))
            {
                retorno = false;
                Message.MensagemAlerta("A cardinalidade deve ser preenchida");
                this.tbx_cardOrigem.Focus();
            }

            return retorno;
        }

        /// <summary>
        /// Método que confirma o formulário
        /// </summary>
        private void Confirmar()
        {
            Util.CL_Files.WriteOnTheLog("FO_Relacionamento.Confirmar()", Util.Global.TipoLog.DETALHADO);

            if (this.tarefa == Util.Enumerator.Tarefa.VISUALIZANDO)
            {
                this.tarefa = Util.Enumerator.Tarefa.EDITANDO;
                this.InicializaForm();
            }
            else
            {
                if (this.VerificaCampos())
                {
                    Model.MD_Tabela tabelaDestino = new Model.MD_Tabela(int.Parse(this.cmb_tabela.SelectedValue.ToString()), this.campoOrigem.DAO.Projeto.Codigo);
                    this.campoDestino = new Model.MD_Campos(int.Parse(this.cmb_campos.SelectedValue.ToString()), tabelaDestino.DAO.Codigo, tabelaDestino.DAO.Projeto.Codigo);
                    Model.MD_Relacao relacao = (this.tarefa == Util.Enumerator.Tarefa.EDITANDO ? this.relacao : new Model.MD_Relacao(DataBase.Connection.GetIncrement("RELACAO"), this.campoOrigem.DAO.Projeto, this.campoOrigem.DAO.Tabela, tabelaDestino.DAO, this.campoOrigem.DAO, this.campoDestino.DAO));

                    this.relacao = relacao;
                    this.PreencheRelacao(ref relacao);
                    bool worked = false;

                    if (this.tarefa == Util.Enumerator.Tarefa.EDITANDO)
                    {
                        worked = relacao.DAO.Update();
                    }
                    else
                    {
                        worked = relacao.DAO.Insert();
                    }

                    if (worked)
                    {
                        Message.MensagemSucesso("Cadastro efetuado com sucesso!");
                        this.tarefa = Util.Enumerator.Tarefa.VISUALIZANDO;
                        this.principal.CarregaTreeViewAutomaticamente();
                        this.InicializaForm();
                    }
                    else
                    {
                        Message.MensagemErro("Erro ao cadastrar!");
                    }
                }
            }
        }

        /// <summary>
        /// Método que preenche a relação de acordo com o formulário
        /// </summary>
        /// <param name="relacao"></param>
        private void PreencheRelacao(ref Model.MD_Relacao relacao)
        {
            Util.CL_Files.WriteOnTheLog("FO_Relacionamento.PreencheRelacao()", Util.Global.TipoLog.DETALHADO);

            relacao.DAO.NomeForeingKey = this.tbx_foreingKey.Text;
            relacao.DAO.CardinalidadeOrigem = this.tbx_cardOrigem.Text;
            relacao.DAO.CardinalidadeDestino = this.tbx_cardDestino.Text;
        }

        /// <summary>
        /// Método que faz a exclusão
        /// </summary>
        private void Excluir()
        {
            Util.CL_Files.WriteOnTheLog("FO_Relacionamento.Excluir()", Util.Global.TipoLog.DETALHADO);

            if (this.tarefa == Util.Enumerator.Tarefa.VISUALIZANDO)
            {
                if (Message.MensagemConfirmaçãoYesNo("Deseja realmente excluir?") == DialogResult.Yes)
                {
                    this.ExcluirRelacao();
                }
            }
            else if (this.tarefa == Util.Enumerator.Tarefa.EDITANDO)
            {
                this.tarefa = Util.Enumerator.Tarefa.VISUALIZANDO;
                this.InicializaForm();
            }
            else
            {
                if (Message.MensagemConfirmaçãoYesNo("Deseja realmente cancelar a inclusão?") == DialogResult.Yes)
                {
                    this.Close();
                    this.Dispose();
                }
            }
        }

        /// <summary>
        /// Método que efetua a exclusão da relação
        /// </summary>
        private void ExcluirRelacao()
        {
            Util.CL_Files.WriteOnTheLog("FO_Relacionamento.ExcluirRelacao()", Util.Global.TipoLog.DETALHADO);

            if (this.relacao.DAO.Delete())
            {
                Message.MensagemSucesso("Excluído com sucesso!");
                this.principal.CarregaTreeViewAutomaticamente();
                this.Close();
                this.Dispose();
            }
            else
            {
                Message.MensagemErro("Não foi possível excluir!");
            }
        }

        #endregion Métodos

    }
}
