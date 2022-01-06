using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visao
{
    public partial class UC_CadastroTabela : UserControl
    {
        #region Atributos

        /// <summary>
        /// Constrolador da tarefa que a tela está executando
        /// </summary>
        Util.Enumerator.Tarefa tarefa = Util.Enumerator.Tarefa.INCLUINDO;

        /// <summary>
        /// Controle da classe tabela da tela
        /// </summary>
        Model.MD_Tabela tabelaCorrente = null;

        /// <summary>
        /// Controle da classe projeto
        /// </summary>
        Model.MD_Projeto projeto = null;

        /// <summary>
        /// Controle da classe da tela principal
        /// </summary>
        FO_Principal principal;

        #endregion Atributos

        #region Eventos

        /// <summary>
        /// Evento disparado no cliue do botão fechar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.principal.FecharTela(Util.Enumerator.Telas.CADASTRO_TABELAS);
        }

        /// <summary>
        /// Evento lançado no clique do botão de informação sobre o nome
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_tarefa_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroTabela.btn_info_tarefa_Click()", Util.Global.TipoLog.DETALHADO);

            Message.MensagemInformacao("Nome da tabela");
        }

        /// <summary>
        /// Evento lançado no clique do botão de informação sobre a descrição
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_infoDescriçãoProjeto_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroTabela.btn_infoDescriçãoProjeto_Click()", Util.Global.TipoLog.DETALHADO);

            Message.MensagemInformacao("Descrição da tabela");
        }

        /// <summary>
        /// Evento lançado no clique do botão de informação sobre as notas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_infoNotas_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroTabela.btn_infoNotas_Click()", Util.Global.TipoLog.DETALHADO);

            Message.MensagemInformacao("Observações da tabela");
        }

        /// <summary>
        /// Evento lançado no clique do botão confirmar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroTabela.btn_confirmar_Click()", Util.Global.TipoLog.DETALHADO);

            this.Inserir();
        }

        /// <summary>
        /// Evento lançado no botão excluir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroTabela.btn_excluir_Click()", Util.Global.TipoLog.DETALHADO);

            this.Excluir();
        }

        /// <summary>
        /// Evento lançado no clique do botão de copiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_copiar_descricao_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.tbx_descricao.Text);
        }

        /// <summary>
        /// Evento lançado no clique do botão de copiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_copiar_Notas_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.tbx_notas.Text);
        }

        /// <summary>
        /// Evento lançado no clique do botão de copiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_copiarRepositorio_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.tbx_nomeTabela.Text);
        }

        #endregion Eventos

        #region Construtores

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="tarefa">tarefa a ser realizada na tela</param>
        /// <param name="tabela">Instancia da classe de tabela</param>
        /// <param name="principal">Tela principal para controle do visual</param>
        public UC_CadastroTabela(Util.Enumerator.Tarefa tarefa, Model.MD_Tabela tabela, Model.MD_Projeto projeto, FO_Principal principal)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroTabela()", Util.Global.TipoLog.DETALHADO);

            this.InitializeComponent();

            this.projeto = projeto;
            this.tabelaCorrente = new Model.MD_Tabela(tabela.DAO.Codigo, projeto.DAO.Codigo);
            this.principal = principal;
            this.tarefa = tarefa;
            this.gpb_cadastroGeral.Text = "Cadastro de tabela - Projeto " + this.projeto.DAO.Nome;
            this.InicializaUserControl();
        }

        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Método que inicializa a tela
        /// </summary>
        public void InicializaUserControl()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroTabela.InicializaUserControl()", Util.Global.TipoLog.DETALHADO);

            this.Dock = DockStyle.Fill;
            if (this.tarefa != Util.Enumerator.Tarefa.INCLUINDO)
            {
                this.PreecheCampos();
            }

            this.CarregaBotoes();
        }

        /// <summary>
        /// Método que preenche os campos
        /// </summary>
        private void PreecheCampos()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroTabela.PreecheCampos()", Util.Global.TipoLog.DETALHADO);

            if (this.tabelaCorrente != null)
            {
                this.tbx_descricao.Text = this.tabelaCorrente.DAO.Descricao;
                this.tbx_nomeTabela.Text = this.tabelaCorrente.DAO.Nome;
                this.tbx_notas.Text = this.tabelaCorrente.DAO.Notas;
            }

            if (this.tarefa == Util.Enumerator.Tarefa.VISUALIZANDO)
            {
                this.tbx_descricao.Enabled = false;
                this.tbx_nomeTabela.Enabled = false;
                this.tbx_notas.Enabled = false;
            }
            else
            {
                this.tbx_descricao.Enabled = true;
                this.tbx_nomeTabela.Enabled = true;
                this.tbx_notas.Enabled = true;
            }
        }

        /// <summary>
        /// Método que carrega os botões
        /// </summary>
        private void CarregaBotoes()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroTabela.CarregaBotoes()", Util.Global.TipoLog.DETALHADO);

            if (this.tarefa == Util.Enumerator.Tarefa.VISUALIZANDO)
            {
                this.btn_confirmar.Text = "Editar";
                this.btn_excluir.Text = "Excluir";
            }
            else
            {
                this.btn_confirmar.Text = "Confirmar";
                this.btn_excluir.Text = "Cancelar";
            }
        }

        /// <summary>
        /// Método que faz a validação dos campos do formulário
        /// </summary>
        /// <returns>True - Correto; False - incorreto</returns>
        private bool ValidaCampos()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroTabela.ValidaCampos()", Util.Global.TipoLog.DETALHADO);

            bool retorno = true;

            if (string.IsNullOrEmpty(this.tbx_nomeTabela.Text))
            {
                retorno = false;
                this.tbx_nomeTabela.Focus();
                Message.MensagemAlerta("Deve ser fornecido o nome da tabela!");
            }

            return retorno;
        }

        /// <summary>
        /// Método que faz a inserção
        /// </summary>
        private void Inserir()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroTabela.Inserir()", Util.Global.TipoLog.DETALHADO);

            if (this.tarefa == Util.Enumerator.Tarefa.VISUALIZANDO)
            {
                this.tarefa = Util.Enumerator.Tarefa.EDITANDO;
                this.InicializaUserControl();
            }
            else
            {
                if (this.ValidaCampos())
                {
                    Model.MD_Tabela tabela = (tarefa == Util.Enumerator.Tarefa.EDITANDO ? this.tabelaCorrente : new Model.MD_Tabela(DataBase.Connection.GetIncrement("TABELA"), this.projeto.DAO.Codigo));

                    this.CarregaCampos(ref tabela);

                    if (Model.MD_Tabela.ValidaExisteTabelaProjeto(tabela.DAO.Nome, tabela.DAO.Projeto.Codigo))
                    {
                        Message.MensagemAlerta("A tabela " + tabela.DAO.Nome + " já existe no projeto!");
                        return;
                    }

                    if (this.Insere(tabela))
                    {
                        if (Message.MensagemConfirmaçãoYesNo("Deseja cadastrar um campo para a tabela?") == DialogResult.Yes)
                        {
                            principal.AbrirCadastroCampo(this.tabelaCorrente, Util.Enumerator.Tarefa.INCLUINDO);
                        }

                        this.principal.CarregaTreeViewAutomaticamente();

                        this.tabelaCorrente = tabela;
                        this.tarefa = Util.Enumerator.Tarefa.VISUALIZANDO;
                        this.InicializaUserControl();

                        
                    }
                }
            }
        }

        /// <summary>
        /// Método que carrega os campos no objeto
        /// </summary>
        /// <param name="tabela"></param>
        private void CarregaCampos(ref Model.MD_Tabela tabela)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroTabela.CarregaCampos()", Util.Global.TipoLog.DETALHADO);

            tabela.DAO.Nome = this.tbx_nomeTabela.Text;
            tabela.DAO.Descricao = this.tbx_descricao.Text;
            tabela.DAO.Notas = this.tbx_notas.Text;
        }

        /// <summary>
        /// Método que insere o objeto
        /// </summary>
        /// <param name="tab">Classe a ser inserida</param>
        private bool Insere(Model.MD_Tabela tab)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroTabela.Insere()", Util.Global.TipoLog.DETALHADO);
            bool retorno = true;

            if (this.tarefa == Util.Enumerator.Tarefa.INCLUINDO)
            {
                if (tab.DAO.Insert())
                {
                    Message.MensagemSucesso("Tabela incluída com sucesso!");
                }
                else
                {
                    Message.MensagemErro("Erro ao incluir!");
                    retorno = false;
                }
            }
            else
            {
                if (tab.DAO.Update())
                {
                    Message.MensagemSucesso("Tabela alterada com sucesso!");
                }
                else
                {
                    Message.MensagemErro("Erro ao alterar!");
                    retorno = false;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Método que faz a exclusão
        /// </summary>
        private void Excluir()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroTabela.Excluir()", Util.Global.TipoLog.DETALHADO);

            if (this.tarefa == Util.Enumerator.Tarefa.VISUALIZANDO)
            {
                if (Message.MensagemConfirmaçãoYesNo("Deseja excluir a tabela " + this.tabelaCorrente.DAO.Nome + "?") == DialogResult.Yes)
                {
                    if (this.tabelaCorrente.DAO.Delete())
                    {
                        Message.MensagemSucesso("Excluído com sucesso!");
                        this.principal.CarregaTreeViewAutomaticamente();
                        this.principal.FecharTela(Util.Enumerator.Telas.CADASTRO_TABELAS);
                    }
                }
            }
            else
            {
                if (this.tarefa == Util.Enumerator.Tarefa.INCLUINDO)
                {
                    this.principal.FecharTela(Util.Enumerator.Telas.CADASTRO_TABELAS);
                }
                else
                {
                    this.tarefa = Util.Enumerator.Tarefa.VISUALIZANDO;
                    this.InicializaUserControl();
                }
            }
        }

        #endregion Métodos
        
    }
}
