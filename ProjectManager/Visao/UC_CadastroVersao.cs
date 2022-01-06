using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Visao
{
    public partial class UC_CadastroVersao : UserControl
    {
        #region Atributos

        /// <summary>
        /// Constrolador da tarefa que a tela está executando
        /// </summary>
        Util.Enumerator.Tarefa tarefa = Util.Enumerator.Tarefa.INCLUINDO;

        /// <summary>
        /// Controle da classe tabela da tela
        /// </summary>
        Model.MD_Versoes versaoCorrente = null;

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
            this.principal.FecharTela(Util.Enumerator.Telas.CADASTRO_VERSAO);
        }

        /// <summary>
        /// Evento lançado no clique do botão de informação sobre o nome
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_versao_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroVersao.btn_info_tarefa_Click()", Util.Global.TipoLog.DETALHADO);

            Message.MensagemInformacao("Número da versão");
        }

        /// <summary>
        /// Evento lançado no clique do botão de informação sobre a descrição
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_infoOrigem_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroTabela.btn_infoDescriçãoProjeto_Click()", Util.Global.TipoLog.DETALHADO);

            Message.MensagemInformacao("Instalador do programa");
        }

        /// <summary>
        /// Evento lançado no clique do botão de informação sobre as notas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_infoDestino_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroVersao.btn_infoNotas_Click()", Util.Global.TipoLog.DETALHADO);

            Message.MensagemInformacao("Caminho onde será colocado o instalador");
        }

        /// <summary>
        /// Evento lançado no clique do botão confirmar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroVersao.btn_confirmar_Click()", Util.Global.TipoLog.DETALHADO);

            this.Inserir();
        }

        /// <summary>
        /// Evento lançado no botão excluir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroVersao.btn_excluir_Click()", Util.Global.TipoLog.DETALHADO);

            this.Excluir();
        }

        /// <summary>
        /// Evento disparado no clique da opção de abrir para selecionar o arquivo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_origem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Selecionar o instalador";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.tbx_origemArquivo.Text = dialog.FileName.ToString();
            }
        }

        /// <summary>
        /// Evento lançado no clique do botão copiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_copiar_notas_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.tbx_versao.Text);
        }

        /// <summary>
        /// Evento lançado no clique do botão copiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_copiar_origem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.tbx_origemArquivo.Text);
        }

        /// <summary>
        /// Evento lançado no clique do botão copiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_copiar_destino_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.tbx_destinoArquivo.Text);
        }

        #endregion Eventos

        #region Construtores

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="tarefa">tarefa a ser realizada na tela</param>
        /// <param name="tabela">Instancia da classe de tabela</param>
        /// <param name="principal">Tela principal para controle do visual</param>
        public UC_CadastroVersao(Util.Enumerator.Tarefa tarefa, Model.MD_Versoes versao, Model.MD_Projeto projeto, FO_Principal principal)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroVersao()", Util.Global.TipoLog.DETALHADO);

            this.InitializeComponent();

            this.projeto = projeto;
            this.versaoCorrente = versao;
            this.principal = principal;
            this.tarefa = tarefa;
            this.gpb_cadastroGeral.Text = "Cadastro de Versões - Projeto " + this.projeto.DAO.Nome;
            this.InicializaUserControl();
        }

        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Método que inicializa a tela
        /// </summary>
        public void InicializaUserControl()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroVersao.InicializaUserControl()", Util.Global.TipoLog.DETALHADO);

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
            Util.CL_Files.WriteOnTheLog("UC_CadastroVersao.PreecheCampos()", Util.Global.TipoLog.DETALHADO);

            if (this.versaoCorrente != null)
            {
                this.tbx_versao.Text = this.versaoCorrente.DAO.Versao;
                this.tbx_origemArquivo.Text = this.versaoCorrente.DAO.Caminhoorigem;
                this.tbx_destinoArquivo.Text = this.versaoCorrente.DAO.Caminhodestino;
            }

            if (this.tarefa == Util.Enumerator.Tarefa.VISUALIZANDO)
            {
                this.tbx_versao.Enabled = false;
                this.tbx_origemArquivo.Enabled = false;
                this.tbx_destinoArquivo.Enabled = false;
            }
            else
            {
                this.tbx_versao.Enabled = true;
                this.tbx_origemArquivo.Enabled = true;
                this.tbx_destinoArquivo.Enabled = true;
            }
        }

        /// <summary>
        /// Método que carrega os botões
        /// </summary>
        private void CarregaBotoes()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroVersao.CarregaBotoes()", Util.Global.TipoLog.DETALHADO);

            if (this.tarefa == Util.Enumerator.Tarefa.VISUALIZANDO)
            {
                this.btn_confirmar.Text = "Editar";
            }
            else
            {
                this.btn_confirmar.Text = "Confirmar";
            }
        }

        /// <summary>
        /// Método que faz a validação dos campos do formulário
        /// </summary>
        /// <returns>True - Correto; False - incorreto</returns>
        private bool ValidaCampos()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroVersao.ValidaCampos()", Util.Global.TipoLog.DETALHADO);

            bool retorno = true;

            if (string.IsNullOrEmpty(this.tbx_versao.Text))
            {
                retorno = false;
                this.tbx_versao.Focus();

                Message.MensagemAlerta("Deve ser fornecido a versão");
            }

            return retorno;
        }

        /// <summary>
        /// Método que faz a inserção
        /// </summary>
        private void Inserir()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroVersao.Inserir()", Util.Global.TipoLog.DETALHADO);

            if (this.tarefa == Util.Enumerator.Tarefa.VISUALIZANDO)
            {
                this.tarefa = Util.Enumerator.Tarefa.EDITANDO;
                this.InicializaUserControl();
            }
            else
            {
                if (this.ValidaCampos())
                {
                    BarraDeCarregamento barra = new BarraDeCarregamento(10, "Fazendo upload do arquivo!");
                    barra.Show();

                    Model.MD_Versoes versao = (tarefa == Util.Enumerator.Tarefa.EDITANDO ? this.versaoCorrente : new Model.MD_Versoes(this.tbx_versao.Text, this.projeto.DAO.Codigo));

                    this.CarregaCampos(ref versao);

                    if (this.Insere(versao))
                    {
                        this.principal.CarregaTreeViewAutomaticamente();

                        this.versaoCorrente = versao;
                        this.tarefa = Util.Enumerator.Tarefa.VISUALIZANDO;
                        this.InicializaUserControl();
                    }

                    barra.Dispose();
                }
            }
        }

        /// <summary>
        /// Método que carrega os campos no objeto
        /// </summary>
        /// <param name="tabela"></param>
        private void CarregaCampos(ref Model.MD_Versoes tabela)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroVersao.CarregaCampos()", Util.Global.TipoLog.DETALHADO);

            tabela.DAO.Codigoprojeto = this.projeto.DAO.Codigo;
            tabela.DAO.Versao = this.tbx_versao.Text;
            tabela.DAO.Caminhoorigem = this.tbx_origemArquivo.Text;
            tabela.DAO.Caminhodestino = this.tbx_destinoArquivo.Text;
        }

        /// <summary>
        /// Método que insere o objeto
        /// </summary>
        /// <param name="tab">Classe a ser inserida</param>
        private bool Insere(Model.MD_Versoes tab)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroVersao.Insere()", Util.Global.TipoLog.DETALHADO);
            bool retorno = true;

            if (this.tarefa == Util.Enumerator.Tarefa.INCLUINDO)
            {
                if (tab.DAO.Insert())
                {
                    Message.MensagemSucesso("Versão incluída com sucesso!");
                }
                else
                {
                    retorno = false;
                    Message.MensagemErro("Erro ao incluir!");
                }
            }
            else
            {
                if (tab.DAO.Update())
                {
                    Message.MensagemSucesso("Versão alterada com sucesso!");
                }
                else
                {
                    retorno = false;
                    Message.MensagemErro("Erro ao alterar!");
                }
            }

            return retorno;
        }

        /// <summary>
        /// Método que faz a exclusão
        /// </summary>
        private void Excluir()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroVersao.Excluir()", Util.Global.TipoLog.DETALHADO);

            if (this.tarefa == Util.Enumerator.Tarefa.VISUALIZANDO)
            {
                if (Message.MensagemConfirmaçãoYesNo("Deseja excluir a versão " + this.versaoCorrente.DAO.Versao + "?") == DialogResult.Yes)
                {
                    if (this.versaoCorrente.DAO.Delete())
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
