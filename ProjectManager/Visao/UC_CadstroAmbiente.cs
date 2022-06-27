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
    public partial class UC_CadastroAmbiente : UserControl
    {
        #region Atributos e Propriedades

        /// <summary>
        /// Constrolador da tarefa que a tela está executando
        /// </summary>
        Util.Enumerator.Tarefa tarefa = Util.Enumerator.Tarefa.INCLUINDO;

        /// <summary>
        /// Controle do projeto da tela
        /// </summary>
        Model.MD_Ambientes ambienteCorrente = null;

        /// <summary>
        /// Modelo de dados do projeto
        /// </summary>
        Model.MD_Projeto projeto = null;

        /// <summary>
        /// Controle da classe da tela principal
        /// </summary>
        FO_Principal principal;

        #endregion Atributos e Propriedades

        #region Eventos

        /// <summary>
        /// Evento lançado no clique do botão fechar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.principal.FecharTela(Util.Enumerator.Telas.CADASTRO_AMBIENTE);
        }

        /// <summary>
        /// Evento lançado no clique do botão informação ambiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_ambiente_Click(object sender, EventArgs e)
        {
            Message.MensagemInformacao("Nome do ambiente");
        }

        /// <summary>
        /// Evento lançado no clique do botão copiar nome ambiente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_copiar_nome_ambiente_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.tbx_nomeAmbiente.Text);
        }

        /// <summary>
        /// Evento lançado no clique do botão informação da url
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_url_Click(object sender, EventArgs e)
        {
            Message.MensagemInformacao("Url onde está disponível o projeto");
        }

        /// <summary>
        /// Evento lançado no clique do botão copiar url
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_copiar_url_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.tbx_urlSite.Text);
        }

        /// <summary>
        /// Evento lançado no clique do botão informação do usuário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_usuario_Click(object sender, EventArgs e)
        {
            Message.MensagemInformacao("Usuário de acesso");
        }

        /// <summary>
        /// Evento lançado no clique do botão copiar usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_copiar_usuario_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.tbx_usuario.Text);
        }

        /// <summary>
        /// Evento lançado no clique do botão informação senha
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_senha_Click(object sender, EventArgs e)
        {
            Message.MensagemInformacao("Senha de acesso");
        }

        /// <summary>
        /// Evento lançado no clique do botão copiar senha
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_copiar_senha_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.tbx_senha.Text);
        }

        /// <summary>
        /// Evento lançado no clique do botão informação de diretório
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_diretorio_publicacao_Click(object sender, EventArgs e)
        {
            Message.MensagemInformacao("Diretório publicação");
        }

        /// <summary>
        /// Evento lançado no clique do botão copiar diretorio publicacao
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_copiar_diretorio_publicacao_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.tbx_diretorio_publicacao.Text);
        }

        /// <summary>
        /// Evento lançado no clique do botão informação url publicação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_url_publicacao_Click(object sender, EventArgs e)
        {
            Message.MensagemInformacao("Url para publicação");
        }

        /// <summary>
        /// Evento lançado no clique do botão copiar url publicação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_copiar_url_publicacao_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.tbx_url_publicacao.Text);
        }

        /// <summary>
        /// Evento lançado no clique do botão exlcuir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            this.Excluir();
        }

        /// <summary>
        /// Evento lançado no clique do botão confirmar
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
        /// Construtor principal da classe
        /// </summary>
        /// <param name="ambiente"></param>
        /// <param name="tarefa"></param>
        /// <param name="principal"></param>
        public UC_CadastroAmbiente(Model.MD_Ambientes ambiente, Model.MD_Projeto projeto, Util.Enumerator.Tarefa tarefa, FO_Principal principal)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroAmbiente.UC_CadastroAmbiente()", Util.Global.TipoLog.DETALHADO);
            InitializeComponent();
            this.principal = principal;
            this.ambienteCorrente = ambiente;
            this.tarefa = tarefa;
            this.projeto = projeto;
            this.gpb_cadastroGeral.Text = $"Cadastro de Ambiente - Projeto {this.projeto.DAO.Nome}";
            this.Dock = DockStyle.Fill;

            this.IniciaForm();
        }

        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Método que inicializa o formulário
        /// </summary>
        public void IniciaForm()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroAmbiente.IniciaForm()", Util.Global.TipoLog.DETALHADO);

            this.ControlaBotoes();
            if (tarefa == Util.Enumerator.Tarefa.INCLUINDO)
            {
                this.ambienteCorrente = new Model.MD_Ambientes(DataBase.Connection.GetIncrement(new DAO.MD_Ambientes().table.Table_Name));
            }
            else
            {
                this.FillCampos();
            }
        }

        /// <summary>
        /// Método que preenche os campos
        /// </summary>
        private void FillCampos()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroAmbiente.FillCampos()", Util.Global.TipoLog.DETALHADO);

            this.tbx_diretorio_publicacao.Text = this.ambienteCorrente.DAO.Caminhoservidor;
            this.tbx_nomeAmbiente.Text = this.ambienteCorrente.DAO.Nome;
            this.tbx_senha.Text = this.ambienteCorrente.DAO.Senhaacesso;
            this.tbx_urlSite.Text = this.ambienteCorrente.DAO.Urldisponivel;
            this.tbx_url_publicacao.Text = this.ambienteCorrente.DAO.Urlservidorpublicacao;
            this.tbx_usuario.Text = this.ambienteCorrente.DAO.Usuarioacesso;

            this.tbx_diretorio_publicacao.Enabled = this.tbx_nomeAmbiente.Enabled = this.tbx_senha.Enabled = this.tbx_urlSite.Enabled = this.tbx_url_publicacao.Enabled = this.tbx_usuario.Enabled = tarefa != Util.Enumerator.Tarefa.VISUALIZANDO;
        }

        /// <summary>
        /// Método que controla os botões
        /// </summary>
        private void ControlaBotoes()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroAmbiente.ControlaBotoes()", Util.Global.TipoLog.DETALHADO);

            if (this.tarefa == Util.Enumerator.Tarefa.INCLUINDO)
            {
                this.btn_confirmar.Text = "Incluir";
                this.btn_excluir.Text = "Cancelar";
            }
            else if(this.tarefa == Util.Enumerator.Tarefa.EDITANDO)
            {
                this.btn_confirmar.Text = "Confirmar";
                this.btn_excluir.Text = "Cancelar";
            }
            else
            {
                this.btn_confirmar.Text = "Editar";
                this.btn_excluir.Text = "Excluir";
            }
        }

        /// <summary>
        /// Método que confirma o formulário
        /// </summary>
        private void Confirmar()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroAmbiente.Confirmar()", Util.Global.TipoLog.DETALHADO);

            if(this.tarefa == Util.Enumerator.Tarefa.EDITANDO)
            {
                this.CarregaObjeto();
                if (this.ambienteCorrente.DAO.Update())
                {
                    Message.MensagemSucesso("Atualizado com sucesso!");
                    this.tarefa = Util.Enumerator.Tarefa.VISUALIZANDO;
                    this.IniciaForm();
                    this.principal.CarregaTreeViewAutomaticamente();
                }
                else
                {
                    Message.MensagemErro("Erro ao atualizar");
                }
            }
            else if(this.tarefa == Util.Enumerator.Tarefa.VISUALIZANDO)
            {
                this.tarefa = Util.Enumerator.Tarefa.EDITANDO;
                this.IniciaForm();
            }
            else
            {
                this.CarregaObjeto();
                if (this.ambienteCorrente.DAO.Insert())
                {
                    Message.MensagemSucesso("Inserido com sucesso!");
                    this.tarefa = Util.Enumerator.Tarefa.VISUALIZANDO;
                    this.IniciaForm();
                    this.principal.CarregaTreeViewAutomaticamente();
                }
                else
                {
                    Message.MensagemErro("Erro ao atualizar");
                }
            }
        }

        /// <summary>
        /// Método que carrega os dados da tela no objeto
        /// </summary>
        private void CarregaObjeto()
        {
            this.ambienteCorrente.DAO.Codigoprojeto = this.projeto.DAO.Codigo;
            this.ambienteCorrente.DAO.Caminhoservidor = this.tbx_diretorio_publicacao.Text;
            this.ambienteCorrente.DAO.Nome = this.tbx_nomeAmbiente.Text;
            this.ambienteCorrente.DAO.Senhaacesso = this.tbx_senha.Text;
            this.ambienteCorrente.DAO.Urldisponivel = this.tbx_urlSite.Text;
            this.ambienteCorrente.DAO.Urlservidorpublicacao = this.tbx_url_publicacao.Text;
            this.ambienteCorrente.DAO.Usuarioacesso = this.tbx_usuario.Text;
        }

        /// <summary>
        /// Método que cancela o formulário
        /// </summary>
        private void Excluir()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroAmbiente.Excluir()", Util.Global.TipoLog.DETALHADO);

            if(tarefa == Util.Enumerator.Tarefa.EDITANDO)
            {
                this.tarefa = Util.Enumerator.Tarefa.VISUALIZANDO;
                this.IniciaForm();
            }
            else if(this.tarefa == Util.Enumerator.Tarefa.INCLUINDO)
            {
                this.btn_fechar_Click(null, null);
            }
            else
            {
                if(Message.MensagemConfirmaçãoYesNo("Deseja realmente excluir o ambiente " + this.ambienteCorrente.DAO.Nome + "?") == DialogResult.Yes)
                {
                    if (this.ambienteCorrente.DAO.Delete())
                    {
                        Message.MensagemSucesso("Excluído com sucesso");
                        this.principal.CarregaTreeViewAutomaticamente();
                        this.btn_fechar_Click(null, null);
                    }
                    else
                    {
                        Message.MensagemErro("Erro ao excluir, verificar log");
                    }
                }
            }
        }

        #endregion Métodos

    }
}
