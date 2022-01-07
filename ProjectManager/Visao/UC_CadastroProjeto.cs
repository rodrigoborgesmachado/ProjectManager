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
    public partial class UC_CadastroProjeto : UserControl
    {
        #region Atributos

        /// <summary>
        /// Constrolador da tarefa que a tela está executando
        /// </summary>
        Util.Enumerator.Tarefa tarefa = Util.Enumerator.Tarefa.INCLUINDO;

        /// <summary>
        /// Controle do projeto da tela
        /// </summary>
        Model.MD_Projeto projetoCorrente = null;

        /// <summary>
        /// Controle da classe da tela principal
        /// </summary>
        FO_Principal principal;

        #endregion Atributos

        #region Eventos

        /// <summary>
        /// Evento disparado no clique do botão fechar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.principal.FecharTela(Util.Enumerator.Telas.CADASTRO_PROJETO);
        }

        /// <summary>
        /// Enveto lançado no clique do botão gerar script
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_gerarScripts_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroProjeto.btn_gerarScripts_Click()", Util.Global.TipoLog.DETALHADO);

            this.GerarScripts();
        }

        /// <summary>
        /// Evento lançado no clique do botão gerar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_gerar_document_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroProjeto.btn_gerar_document_Click()", Util.Global.TipoLog.DETALHADO);

            this.GerarDer();
        }

        /// <summary>
        /// Evento lançado no clique do botão confirmar da tela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroProjeto.btn_confirmar_Click()", Util.Global.TipoLog.DETALHADO);

            if (tarefa == Util.Enumerator.Tarefa.VISUALIZANDO)
            {
                this.tarefa = Util.Enumerator.Tarefa.EDITANDO;
                this.InicializaUserControl();
            }
            else
            {
                this.Incluir();
            }
        }

        /// <summary>
        /// Evento lançado no clique do botão excluir/cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroProjeto.btn_excluir_Click()", Util.Global.TipoLog.DETALHADO);

            this.Excluir();
        }

        /// <summary>
        /// Evento lançado no clique do botão de informação do nome do projeto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_tarefa_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroProjeto.btn_info_tarefa_Click()", Util.Global.TipoLog.DETALHADO);

            Message.MensagemInformacao("Nome do projeto");
        }

        /// <summary>
        /// Evento lançado no clique do botão de informação sobre o repositório
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_repositorio_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroProjeto.btn_info_repositorio_Click()", Util.Global.TipoLog.DETALHADO);

            Message.MensagemInformacao("Link do repositório onde se encontra o fonte do projeto");
        }

        /// <summary>
        /// Evento lançado no clique do botão de informação da descrição do projeto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_infoDescriçãoProjeto_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroProjeto.btn_infoDescriçãoProjeto_Click()", Util.Global.TipoLog.DETALHADO);

            Message.MensagemInformacao("Descrição do projeto");
        }

        /// <summary>
        /// Evento lançado no clique do botão copiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_copiar_nome_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.tbx_nomeProjeto.Text);
        }

        /// <summary>
        /// Evento lançado no clique do botão copiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_copiar_descricao_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.tbx_descricao.Text);
        }

        /// <summary>
        /// Evento lançado no clique do botão copiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_copiarRepositorio_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.tbx_repositorio.Text);
        }

        #endregion Eventos

        #region Construtores

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="tarefa">Qual a tarefa a ser executada na tela</param>
        public UC_CadastroProjeto(Util.Enumerator.Tarefa tarefa, Model.MD_Projeto projeto, FO_Principal principal)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroProjeto()", Util.Global.TipoLog.DETALHADO);

            this.tarefa = tarefa;
            this.projetoCorrente = projeto;
            this.principal = principal;
            this.InitializeComponent();
            this.InicializaUserControl();
        }

        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Método que faz a inicialização do user control
        /// </summary>
        private void InicializaUserControl()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroProjeto.InicializaUserControl()", Util.Global.TipoLog.DETALHADO);

            this.Dock = DockStyle.Fill;
            this.tbx_descricao.Text = this.tbx_nomeProjeto.Text = string.Empty;
            if (tarefa != Util.Enumerator.Tarefa.INCLUINDO)
            {
                this.CarregaCampos();
            }

            this.ControlaBotoes();
        }

        /// <summary>
        /// Método que faz i controle dos botões da tela
        /// </summary>
        private void ControlaBotoes()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroProjeto.ControlaBotoes()", Util.Global.TipoLog.DETALHADO);

            if (tarefa == Util.Enumerator.Tarefa.VISUALIZANDO)
            {
                this.btn_confirmar.Enabled = true;
                this.btn_confirmar.Text = "Editar";
                this.tbx_descricao.Enabled = false;
                this.tbx_nomeProjeto.Enabled = false;
                this.tbx_repositorio.Enabled = false;
                this.btn_gerar_document.Enabled = true;
                this.btn_excluir.Text = "Excluir";
            }
            else
            {
                this.btn_confirmar.Enabled = true;
                this.tbx_descricao.Enabled = true;
                this.tbx_nomeProjeto.Enabled = true;
                this.tbx_repositorio.Enabled = true;
                this.btn_gerar_document.Enabled = false;
                this.btn_excluir.Text = "Cancelar";
                this.btn_confirmar.Text = tarefa == Util.Enumerator.Tarefa.EDITANDO ? "Alterar" : "Cadastrar";
            }
        }

        /// <summary>
        /// Método que carrega os campos a partir dos dados da classe
        /// </summary>
        private void CarregaCampos()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroProjeto.CarregaCampos()", Util.Global.TipoLog.DETALHADO);

            this.tbx_nomeProjeto.Text = this.projetoCorrente.DAO.Nome;
            this.tbx_descricao.Text = this.projetoCorrente.DAO.Descricao;
            this.tbx_repositorio.Text = this.projetoCorrente.DAO.Git;
        }

        /// <summary>
        /// Método que verifica os campos
        /// </summary>
        /// <returns></returns>
        private bool ValidaCampos()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroProjeto.ValidaCampos()", Util.Global.TipoLog.DETALHADO);

            bool retorno = true;

            if (string.IsNullOrEmpty(this.tbx_nomeProjeto.Text))
            {
                Message.MensagemAlerta("O nome do projeto não está válido!");
                this.tbx_nomeProjeto.Focus();
                retorno = false;
            }
            return retorno;
        }

        /// <summary>
        /// Método que faz a inclusão do projeto
        /// </summary>
        private void Incluir()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroProjeto.Incluir()", Util.Global.TipoLog.DETALHADO);

            if (ValidaCampos())
            {
                // Cria tabela e relacionamentos
                Model.MD_Projeto p = new Model.MD_Projeto(-1);

                // Instancia objeto
                Model.MD_Projeto proj = tarefa == Util.Enumerator.Tarefa.INCLUINDO ? new Model.MD_Projeto(DataBase.Connection.GetIncrement(p.DAO.table.Table_Name)) : proj = this.projetoCorrente;

                this.InstanciaDados(ref proj);

                if (tarefa == Util.Enumerator.Tarefa.INCLUINDO)
                {
                    this.IncluiProjeto(proj);
                }
                else
                {
                    this.AtualizaProjeto(proj);
                }

                this.projetoCorrente = proj;
                this.tarefa = Util.Enumerator.Tarefa.INCLUINDO;
                this.InicializaUserControl();
            }
        }

        /// <summary>
        /// Método que instancia os dados do projeto
        /// </summary>
        /// <param name="proj">Objeto a receber os dados</param>
        private void InstanciaDados(ref Model.MD_Projeto proj)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroProjeto.InstanciaDados()", Util.Global.TipoLog.DETALHADO);

            proj.DAO.Nome = this.tbx_nomeProjeto.Text;
            proj.DAO.Descricao = this.tbx_descricao.Text;
            proj.DAO.Git = this.tbx_repositorio.Text;
        }

        /// <summary>
        /// Método que faz a inserção do projeto
        /// </summary>
        /// <param name="proj">Projeto a ser inserido</param>
        private void IncluiProjeto(Model.MD_Projeto proj)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroProjeto.IncluiProjeto()", Util.Global.TipoLog.DETALHADO);

            if (proj.DAO.Insert())
            {
                Message.MensagemSucesso("Incluído com sucesso!");
                this.tbx_descricao.Text = this.tbx_nomeProjeto.Text = string.Empty;
                this.AtualizaPrincipal();
            }
            else
            {
                Message.MensagemErro("Erro ao inserir!");
            }
        }

        /// <summary>
        /// Método que faz a inserção do projeto
        /// </summary>
        /// <param name="proj">Projeto a ser inserido</param>
        private void AtualizaProjeto(Model.MD_Projeto proj)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroProjeto.AtualizaProjeto()", Util.Global.TipoLog.DETALHADO);

            if (proj.DAO.Update())
            {
                Message.MensagemSucesso("Alterado com sucesso!");
                this.AtualizaPrincipal();
            }
            else
            {
                Message.MensagemErro("Erro ao alterar!");
            }
        }

        /// <summary>
        /// Método que faz a exclusão do projeto
        /// </summary>
        private void Excluir()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroProjeto.Excluir()", Util.Global.TipoLog.DETALHADO);

            if (tarefa == Util.Enumerator.Tarefa.VISUALIZANDO)
            {
                this.Exclui();
            }
            else if (tarefa == Util.Enumerator.Tarefa.EDITANDO)
            {
                this.Cancela();
            }
            else
            {
                this.principal.FecharTela(Util.Enumerator.Telas.CADASTRO_PROJETO);
            }
        }

        /// <summary>
        /// Método que cancela a inclusão ou a edição do projeto
        /// </summary>
        private void Cancela()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroProjeto.Cancela()", Util.Global.TipoLog.DETALHADO);

            this.tarefa = Util.Enumerator.Tarefa.VISUALIZANDO;
            this.InicializaUserControl();
        }

        /// <summary>
        /// Método que exclui o projeto
        /// </summary>
        private void Exclui()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroProjeto.Exclui()", Util.Global.TipoLog.DETALHADO);

            this.projetoCorrente.DAO.StatusProjeto = Util.Enumerator.Status.DESATIVADO;
            this.AtualizaProjeto(this.projetoCorrente);
            this.AtualizaPrincipal();
        }

        /// <summary>
        /// Método que atualiza a tela com os dados principais
        /// </summary>
        private void AtualizaPrincipal()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroProjeto.AtualizaPrincipal()", Util.Global.TipoLog.DETALHADO);

            this.principal.CarregaTreeViewAutomaticamente();
            principal.FecharTela(Util.Enumerator.Telas.CADASTRO_PROJETO);
        }

        /// <summary>
        /// Método que gera o script
        /// </summary>
        /// <returns></returns>
        private void GerarScripts()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroProjeto.GerarScripts()", Util.Global.TipoLog.DETALHADO);

            this.principal.GerarScriptBD(this.projetoCorrente);
        }

        /// <summary>
        /// Método que gera o relatório do projeto selecionado
        /// </summary>
        private void GerarDer()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroProjeto.Gerar()", Util.Global.TipoLog.DETALHADO);

            if (tarefa == Util.Enumerator.Tarefa.VISUALIZANDO)
            {
                if (Regras.Document.Gerar(this.projetoCorrente))
                {
                    Message.MensagemSucesso("Gerado com sucesso!");

                    if (Message.MensagemConfirmaçãoYesNo("Deseja abrir o DER no Navegador?") == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(Util.Global.app_DER_file_Table);
                    }
                    else
                    {
                        Visao.UC_WEB web = new Visao.UC_WEB(Util.Global.app_DER_file_Table);
                        principal.AbreJanela(web, "DER - " + this.projetoCorrente.DAO.Nome, Util.Enumerator.Telas.CADASTRO_RELATORIO);
                    }
                }
                else
                {
                    Message.MensagemErro("Houve erro ao gerar o relatório!");
                }
            }
        }

        #endregion Métodos
        
    }
}
