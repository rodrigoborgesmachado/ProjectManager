using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Util.Enumerator;
using static Util.Global;

namespace Visao
{
    public partial class FO_Principal : Form
    {
        #region Atributos e Propriedades

        /// <summary>
        /// Controle de eventos da tela
        /// </summary>
        bool lockchange = false;

        List<TabPage> pages = new List<TabPage>();
        /// <summary>
        /// Páginas abertas
        /// </summary>
        public List<TabPage> Pages
        {
            get
            {
                return pages;
            }
            set
            {
                this.pages = value;
            }
        }

        public Model.MD_Projeto projeto = new Model.MD_Projeto(-1);

        #endregion Atributos e Propriedades

        #region Eventos

        /// <summary>
        /// Evento lançado quando a tela abre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FO_Principal_Load(object sender, EventArgs e)
        {
            this.CarregaTreeView();
        }

        /// <summary>
        /// Evento lançado no clique do botão atualizar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.btn_atualizar_Click()", Util.Global.TipoLog.DETALHADO);

            this.CarregaTreeView();
        }

        /// <summary>
        /// Evento lançado no clique de novo projeto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_novo_projeto_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.btn_novo_projeto_Click()", Util.Global.TipoLog.DETALHADO);

            AbrirJanelaDeCadastroProjeto(Util.Enumerator.Tarefa.INCLUINDO);
        }

        /// <summary>
        /// CArrega informações após seleção
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trv_projetos_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.trv_projetos_AfterSelect()", Util.Global.TipoLog.DETALHADO);

            if (this.trv_projetos.SelectedNode == null)
                return;

            string codigo = this.trv_projetos.SelectedNode.Tag.ToString();
            this.AbrirJanela(codigo);
        }

        /// <summary>
        /// Evento lançado na seleção do botão direito no tree view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void item_editar_selected_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.item_editar_selected_Click()", Util.Global.TipoLog.DETALHADO);

            MenuItem item = (MenuItem)sender;
            string codigo = item.Tag.ToString();
            this.AbrirJanelaDeCadastroProjeto(Tarefa.EDITANDO, int.Parse(codigo));
        }

        /// <summary>
        /// Evento lançado na seleção do botão direito no tree view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void item_excluir_selected_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.item_excluir_selected_Click()", Util.Global.TipoLog.DETALHADO);

            MenuItem item = (MenuItem)sender;
            string codigo = item.Tag.ToString();
            Model.MD_Projeto project = new Model.MD_Projeto(int.Parse(codigo));
            if (Visao.Message.MensagemConfirmaçãoYesNo("Deseja excluir o projeto: " + project.DAO.Nome + "?") == DialogResult.Yes)
            {
                if (project.DAO.Delete())
                    Visao.Message.MensagemSucesso("Excluído com sucesso!");
                else
                    Visao.Message.MensagemErro("Erro ao excluir!");

                this.CarregaTreeViewAutomaticamente();
                this.FecharTela(Telas.CADASTRO_PROJETO);
            }
        }

        /// <summary>
        /// Evento lançado na seleção do botão direito no tree view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void item_incluirTabela_selected_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.item_incluirTabela_selected_Click()", Util.Global.TipoLog.DETALHADO);

            MenuItem item = (MenuItem)sender;
            string codigo = item.Tag.ToString();
            Model.MD_Projeto project = new Model.MD_Projeto(int.Parse(codigo));
            this.AbrirCadastroTabela(project, Tarefa.INCLUINDO);
        }

        /// <summary>
        /// Evento lançado na seleção do botão direito no tree view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void item_gerarDER_selected_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.item_gerarDER_selected_Click()", Util.Global.TipoLog.DETALHADO);

            MenuItem item = (MenuItem)sender;
            string codigo = item.Tag.ToString();
            Model.MD_Projeto project = new Model.MD_Projeto(int.Parse(codigo));
            this.GerarDocumentoDER(project);
        }

        /// <summary>
        /// Evento lançado na seleção do botão direito no tree view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void item_gerarScriptsProjeto_selected_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.item_gerarScriptsProjeto_selected_Click()", Util.Global.TipoLog.DETALHADO);

            MenuItem item = (MenuItem)sender;
            string codigo = item.Tag.ToString();
            Model.MD_Projeto project = new Model.MD_Projeto(int.Parse(codigo));
            this.GerarScriptBD(project);
        }

        /// <summary>
        /// Evento lançado na seleção do botão direito no tree view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void item_buscarTabelaBancoDados_selected_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.item_buscarTabelaBancoDados_selected_Click()", Util.Global.TipoLog.DETALHADO);

            MenuItem item = (MenuItem)sender;
            string codigo = item.Tag.ToString();
            this.BuscarImportacaoBancoDados(int.Parse(codigo));
        }

        /// <summary>
        /// Evento lançado na seleção do botão direito no tree view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void item_buscarBackup_selected_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.item_buscarBackup_selected_Click()", Util.Global.TipoLog.DETALHADO);

            MenuItem item = (MenuItem)sender;
            string codigo = item.Tag.ToString();

            this.projeto = new Model.MD_Projeto(int.Parse(codigo));
            this.BuscarBackupDER();
        }

        /// <summary>
        /// Evento lançado na seleção do botão direito no tree view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void item_ativar_selected_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.item_ativar_selected_Click()", Util.Global.TipoLog.DETALHADO);

            MenuItem item = (MenuItem)sender;
            string codigo = item.Tag.ToString();

            Model.MD_Projeto projeto = new Model.MD_Projeto(int.Parse(codigo));
            projeto.DAO.StatusProjeto = Status.ATIVO;
            projeto.DAO.Update();
            this.CarregaTreeViewAutomaticamente();
        }

        /// <summary>
        /// Evento lançado na seleção do botão direito no tree view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void item_desativar_selected_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.item_desativar_selected_Click()", Util.Global.TipoLog.DETALHADO);

            MenuItem item = (MenuItem)sender;
            string codigo = item.Tag.ToString();

            Model.MD_Projeto projeto = new Model.MD_Projeto(int.Parse(codigo));
            projeto.DAO.StatusProjeto = Status.DESATIVADO;
            projeto.DAO.Update();
            this.CarregaTreeViewAutomaticamente();
        }

        /// <summary>
        /// Evento lançado na seleção do botão direito no tree view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void item_gerarDERProjeto_selected_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.item_gerarDER_selected_Click()", Util.Global.TipoLog.DETALHADO);

            MenuItem item = (MenuItem)sender;
            string codigo = item.Tag.ToString();

            Model.MD_Projeto projeto = new Model.MD_Projeto(int.Parse(codigo));
            this.GerarDocumentoDER(projeto);
        }

        /// <summary>
        /// Evento lançado na seleção do botão direito no tree view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void item_gerarClasses_selected_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.item_gerarClasses_selected_Click()", Util.Global.TipoLog.DETALHADO);

            MenuItem item = (MenuItem)sender;
            string codigo = item.Tag.ToString();

            Model.MD_Projeto projeto = new Model.MD_Projeto(int.Parse(codigo));
            this.GerarClasses(projeto);
        }

        /// <summary>
        /// Evento lançado na seleção do botão direito no tree view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void item_gerarScriptTabela_selected_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.item_gerarClasse_selected_Click()", Util.Global.TipoLog.DETALHADO);

            MenuItem item = (MenuItem)sender;
            string codigo_tabela = item.Tag.ToString().Split(':')[0];
            string codigoprojeto = item.Tag.ToString().Split(':')[1];

            Model.MD_Projeto proj = new Model.MD_Projeto(int.Parse(codigoprojeto));
            Model.MD_Tabela table = new Model.MD_Tabela(int.Parse(codigo_tabela), proj.DAO.Codigo);

            this.GerarScriptBD(proj, table);
        }

        /// <summary>
        /// Evento lançado na seleção do botão direito no tree view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void item_gerarClasse_selected_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.item_gerarClasse_selected_Click()", Util.Global.TipoLog.DETALHADO);

            MenuItem item = (MenuItem)sender;
            string codigo_tabela = item.Tag.ToString().Split(':')[0];
            string codigoprojeto = item.Tag.ToString().Split(':')[1];

            Model.MD_Projeto proj = new Model.MD_Projeto(int.Parse(codigoprojeto));
            Model.MD_Tabela table = new Model.MD_Tabela(int.Parse(codigo_tabela), proj.DAO.Codigo);

            string mensagem = string.Empty;
            if (this.GerarClasse(table, ref mensagem))
            {
                Visao.Message.MensagemSucesso("Classe gerada com sucesso no diretório: " + Util.Global.app_classes_directory + "!");
            }
            else
            {
                Visao.Message.MensagemErro("Houve erros ao gerar a classe!");
            }
        }

        /// <summary>
        /// Evento lançado na seleção do botão direito no tree view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void item_gerarRelatorioModulo_selected_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.item_gerarClasse_selected_Click()", Util.Global.TipoLog.DETALHADO);

            MenuItem item = (MenuItem)sender;
            string codigo_modulo = item.Tag.ToString().Split(':')[0];
            string codigoprojeto = item.Tag.ToString().Split(':')[1];

            Model.MD_Projeto proj = new Model.MD_Projeto(int.Parse(codigoprojeto));
            Model.MD_Modulos mod = new Model.MD_Modulos(int.Parse(codigo_modulo), proj.DAO.Codigo);

            string mensagem = string.Empty;
            if (this.GerarRelatorioModulo(mod))
            {
                Visao.Message.MensagemSucesso("Relatório gerado com sucesso no diretório: " + Util.Global.app_rel_directory + "!");
            }
            else
            {
                Visao.Message.MensagemErro("Houve erros ao gerar o relatório!");
            }

        }

        /// <summary>
        /// Evento lançado na seleção do botão direito no tree view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void item_gerarRelatorioTodosModulo_selected_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.item_gerarRelatorioTodosModulo_selected_Click()", Util.Global.TipoLog.DETALHADO);

            MenuItem item = (MenuItem)sender;
            string codigoprojeto = item.Tag.ToString();

            Model.MD_Projeto proj = new Model.MD_Projeto(int.Parse(codigoprojeto));

            string mensagem = string.Empty;
            if (!this.GerarRelatorioModulo(proj))
            {
                Visao.Message.MensagemAlerta("Houve erros ao gerar o relatório!");
            }

        }

        /// <summary>
        /// Evento lançado na seleção do botão direito no tree view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void item_gerarRelatorioTodosTestes_selected_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.item_gerarRelatorioTodosTestes_selected_Click()", Util.Global.TipoLog.DETALHADO);

            MenuItem item = (MenuItem)sender;
            string codigoprojeto = item.Tag.ToString();

            Model.MD_Projeto proj = new Model.MD_Projeto(int.Parse(codigoprojeto));

            string mensagem = string.Empty;
            if (!this.GerarRelatorioTeste(proj))
            {
                Message.MensagemAlerta("Houve erros ao gerar o relatório!");
            }

        }
        /// <summary>
        /// Evento lançado na seleção do botão incluir campo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void item_adicionaCampo_tabela_selected_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.item_adicionaCampo_tabela_selected_Click()", Util.Global.TipoLog.DETALHADO);

            MenuItem item = (MenuItem)sender;
            string codigo_tabela = item.Tag.ToString().Split(':')[0];
            string codigoprojeto = item.Tag.ToString().Split(':')[1];

            Model.MD_Projeto proj = new Model.MD_Projeto(int.Parse(codigoprojeto));
            Model.MD_Tabela table = new Model.MD_Tabela(int.Parse(codigo_tabela), proj.DAO.Codigo);
            this.AbrirCadastroCampo(table, Tarefa.INCLUINDO);
        }

        /// <summary>
        /// Evento lançado na seleção do botão incluir módulo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void item_adicionaModulo_tabela_selected_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.item_adicionaModulo_tabela_selected_Click()", Util.Global.TipoLog.DETALHADO);

            MenuItem item = (MenuItem)sender;
            string codigo_projeto = item.Tag.ToString();

            Model.MD_Modulos mod = new Model.MD_Modulos(-1, int.Parse(codigo_projeto));
            this.AbrirCadastroModulo(mod, new Model.MD_Projeto(int.Parse(codigo_projeto)), Tarefa.INCLUINDO);
        }

        /// <summary>
        /// Evento lançado na seleção do botão incluir módulo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void item_adicionaTeste_tabela_selected_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.item_adicionaTeste_tabela_selected_Click()", Util.Global.TipoLog.DETALHADO);

            MenuItem item = (MenuItem)sender;
            string codigo_projeto = item.Tag.ToString();

            Model.MD_Teste teste = new Model.MD_Teste(-1, new Model.MD_Projeto(-1));
            this.AbrirCadastroTeste(teste, new Model.MD_Projeto(int.Parse(codigo_projeto)), Tarefa.INCLUINDO);
        }

        /// <summary>
        /// Evento lançado quando a opção de log é alterada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsp_log_simples_CheckedChanged(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.Tsp_log_simples_CheckedChanged()", Util.Global.TipoLog.DETALHADO);

            if (lockchange)
                return;
            lockchange = true;

            tsp_log_simples.Checked = true;
            tsp_log_detalhado.Checked = !tsp_log_simples.Checked;
            DataBase.Connection.SetLog(TipoLog.SIMPLES);
            log_system = DataBase.Connection.GetLog();

            lockchange = false;
        }

        /// <summary>
        /// Evento lançado quando a opção de log é alterada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsp_log_detalhado_CheckedChanged(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.Tsp_log_detalhado_CheckedChanged()", Util.Global.TipoLog.DETALHADO);

            if (lockchange)
                return;
            lockchange = true;

            tsp_log_detalhado.Checked = true;
            tsp_log_simples.Checked = !tsp_log_detalhado.Checked;
            DataBase.Connection.SetLog(TipoLog.DETALHADO);
            log_system = DataBase.Connection.GetLog();

            lockchange = false;
        }

        /// <summary>
        /// Evento lançado no clique da opção de gerar os arquivos UTIL 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsp_arquivosUTIL_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.Tsp_arquivosUTIL_Click()", Util.Global.TipoLog.DETALHADO);

            this.AbrirTelaSelecaoDestinoDirectoryArquivos(ArquivosGerados.UTIL);
        }

        /// <summary>
        /// Evento lançado no clique da opção de gerar arquivos model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsp_arquivosModel_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.Tsp_arquivosModel_Click()", Util.Global.TipoLog.DETALHADO);

            this.AbrirTelaSelecaoDestinoDirectoryArquivos(ArquivosGerados.MODEL);
        }

        /// <summary>
        /// Evento lançado quando a opção de carregar tree view manual é alterada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TspNao_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.TspNao_Click()", Util.Global.TipoLog.DETALHADO);

            if (lockchange)
                return;
            lockchange = true;

            tspNao.Checked = true;
            tspSim.Checked = !tspNao.Checked;
            DataBase.Connection.SetAutomatico(Automatico.Manual);
            Util.Global.CarregarAutomaticamente = DataBase.Connection.GetAutomatico();

            lockchange = false;
        }

        /// <summary>
        /// Evento lançado quando a opção de carregar tree view automático é alterada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TspSim_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.TspSim_Click()", Util.Global.TipoLog.DETALHADO);

            if (lockchange)
                return;
            lockchange = true;

            tspSim.Checked = true;
            tspNao.Checked = !tspSim.Checked;
            DataBase.Connection.SetAutomatico(Automatico.Automatico);
            Util.Global.CarregarAutomaticamente = DataBase.Connection.GetAutomatico();

            lockchange = false;
        }

        /// <summary>
        /// Evento lançado no cliqeu da opção editar da tabela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void item_editar_tabela_selected_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.item_editar_tabela_selected_Click()", Util.Global.TipoLog.DETALHADO);

            if (lockchange)
                return;

            MenuItem item = (MenuItem)sender;
            string codigo = item.Tag.ToString().Split(':')[1];
            Model.MD_Projeto project = new Model.MD_Projeto(int.Parse(codigo));
            Model.MD_Tabela table = new Model.MD_Tabela(int.Parse(item.Tag.ToString().Split(':')[0]), project.DAO.Codigo);

            this.AbrirCadastroTabela(project, Tarefa.EDITANDO, table);
        }

        /// <summary>
        /// Evento lançado no cliqeu da opção editar do m[odulo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void item_editar_modulo_selected_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.item_editar_modulo_selected_Click()", Util.Global.TipoLog.DETALHADO);

            if (lockchange)
                return;

            MenuItem item = (MenuItem)sender;
            string codigo = item.Tag.ToString().Split(':')[1];
            Model.MD_Modulos mod = new Model.MD_Modulos(int.Parse(item.Tag.ToString().Split(':')[0]), int.Parse(codigo));

            this.AbrirCadastroModulo(mod, new Model.MD_Projeto(int.Parse(codigo)), Tarefa.EDITANDO);
        }

        /// <summary>
        /// Evento lançado no cliqeu da opção editar do m[odulo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void item_editar_teste_selected_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.item_editar_teste_selected_Click()", Util.Global.TipoLog.DETALHADO);

            if (lockchange)
                return;

            MenuItem item = (MenuItem)sender;
            string codigo = item.Tag.ToString().Split(':')[1];
            Model.MD_Teste mod = new Model.MD_Teste(int.Parse(item.Tag.ToString().Split(':')[0]), new Model.MD_Projeto(int.Parse(codigo)));

            this.AbrirCadastroTeste(mod, new Model.MD_Projeto(int.Parse(codigo)), Tarefa.EDITANDO);
        }

        /// <summary>
        /// Evento lançado no cliqeu da opção excluir da tabela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void item_excluir_tabela_selected_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.item_excluir_tabela_selected_Click()", Util.Global.TipoLog.DETALHADO);

            if (lockchange)
                return;

            MenuItem item = (MenuItem)sender;
            string codigo = item.Tag.ToString().Split(':')[1];
            Model.MD_Projeto project = new Model.MD_Projeto(int.Parse(codigo));
            Model.MD_Tabela table = new Model.MD_Tabela(int.Parse(item.Tag.ToString().Split(':')[0]), project.DAO.Codigo);

            if (Message.MensagemConfirmaçãoYesNo("Deseja excluir a tabela " + table.DAO.Nome + "?") == DialogResult.Yes)
            {
                if (table.DAO.Delete())
                {
                    Message.MensagemSucesso("Excluído com sucesso!");
                    this.CarregaTreeViewAutomaticamente();
                    this.FecharTela(Telas.CADASTRO_TABELAS);
                }
            }
        }


        /// <summary>
        /// Evento lançado no cliqeu da opção excluir da tabela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void item_excluir_modulo_selected_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.item_excluir_modulo_selected_Click()", Util.Global.TipoLog.DETALHADO);

            if (lockchange)
                return;

            MenuItem item = (MenuItem)sender;
            string codigo = item.Tag.ToString().Split(':')[1];
            Model.MD_Projeto project = new Model.MD_Projeto(int.Parse(codigo));
            Model.MD_Modulos mod = new Model.MD_Modulos(int.Parse(item.Tag.ToString().Split(':')[0]), project.DAO.Codigo);

            if (Message.MensagemConfirmaçãoYesNo("Deseja excluir o módulo " + mod.DAO.NomeModulo + "?") == DialogResult.Yes)
            {
                if (mod.DAO.Delete())
                {
                    foreach (Model.MD_Campos campo in mod.Campos())
                    {
                        Model.MD_TabelasModulos tab = new Model.MD_TabelasModulos(campo.DAO.Tabela.Codigo, campo.DAO.Codigo, campo.DAO.Projeto.Codigo);
                        tab.DAO.Delete();
                    }

                    Message.MensagemSucesso("Excluído com sucesso!");
                    this.CarregaTreeViewAutomaticamente();
                    this.FecharTela(Telas.CADASTRO_MODULO);
                }
            }
        }

        /// <summary>
        /// Evento lançado no cliqeu da opção excluir da tabela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void item_excluir_teste_selected_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.item_excluir_teste_selected_Click()", Util.Global.TipoLog.DETALHADO);

            if (lockchange)
                return;

            MenuItem item = (MenuItem)sender;
            string codigo = item.Tag.ToString().Split(':')[1];
            Model.MD_Projeto project = new Model.MD_Projeto(int.Parse(codigo));
            Model.MD_Teste mod = new Model.MD_Teste(int.Parse(item.Tag.ToString().Split(':')[0]), project);

            if (Message.MensagemConfirmaçãoYesNo("Deseja excluir?") == DialogResult.Yes)
            {
                if (mod.DAO.Delete())
                {
                    foreach (Model.MD_Tabelatestes teste in mod.RetornaListaTestes())
                    {
                        teste.DAO.Delete();
                    }

                    Message.MensagemSucesso("Excluído com sucesso!");
                    this.CarregaTreeViewAutomaticamente();
                    this.FecharTela(Telas.CADASTRO_MODULO);
                }
            }
        }

        /// <summary>
        /// Evento lançado no cliqeu da opção editar do campo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void item_editar_campo_selected_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.item_editar_campo_selected_Click()", Util.Global.TipoLog.DETALHADO);

            if (lockchange)
                return;

            MenuItem item = (MenuItem)sender;
            string codigo_campo = item.Tag.ToString().Split(':')[0];
            string codigo_tabela = item.Tag.ToString().Split(':')[1];
            string codigoprojeto = item.Tag.ToString().Split(':')[2];

            Model.MD_Projeto proj = new Model.MD_Projeto(int.Parse(codigoprojeto));
            Model.MD_Tabela table = new Model.MD_Tabela(int.Parse(codigo_tabela), proj.DAO.Codigo);
            Model.MD_Campos campo = new Model.MD_Campos(int.Parse(codigo_campo), table.DAO.Codigo, table.DAO.Projeto.Codigo);

            this.AbrirCadastroCampo(table, Tarefa.EDITANDO, campo);
        }

        /// <summary>
        /// Evento lançado no cliqeu da opção excluir do campo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void item_excluir_campo_selected_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.item_excluir_campo_selected_Click()", Util.Global.TipoLog.DETALHADO);

            if (lockchange)
                return;

            MenuItem item = (MenuItem)sender;
            string codigo_campo = item.Tag.ToString().Split(':')[0];
            string codigo_tabela = item.Tag.ToString().Split(':')[1];
            string codigoprojeto = item.Tag.ToString().Split(':')[2];

            Model.MD_Projeto proj = new Model.MD_Projeto(int.Parse(codigoprojeto));
            Model.MD_Tabela table = new Model.MD_Tabela(int.Parse(codigo_tabela), proj.DAO.Codigo);
            Model.MD_Campos campo = new Model.MD_Campos(int.Parse(codigo_campo), table.DAO.Codigo, table.DAO.Projeto.Codigo);

            if (Message.MensagemConfirmaçãoYesNo("Deseja excluir o campo " + campo.DAO.Nome + "?") == DialogResult.Yes)
            {
                if (campo.DAO.Delete())
                {
                    Message.MensagemSucesso("Excluído com sucesso!");
                    this.CarregaTreeViewAutomaticamente();
                    this.FecharTela(Telas.CADASTRO_CAMPOS);
                }
            }
        }

        /// <summary>
        /// Evento lançado no cliqeu da opção excluir do campo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void item_incluirRelacionamento_campo_selected_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.item_incluirRelacionamento_campo_selected_Click()", Util.Global.TipoLog.DETALHADO);

            if (lockchange)
                return;

            MenuItem item = (MenuItem)sender;
            string codigo_campo = item.Tag.ToString().Split(':')[0];
            string codigo_tabela = item.Tag.ToString().Split(':')[1];
            string codigoprojeto = item.Tag.ToString().Split(':')[2];

            Model.MD_Projeto proj = new Model.MD_Projeto(int.Parse(codigoprojeto));
            Model.MD_Tabela table = new Model.MD_Tabela(int.Parse(codigo_tabela), proj.DAO.Codigo);
            Model.MD_Campos campo = new Model.MD_Campos(int.Parse(codigo_campo), table.DAO.Codigo, table.DAO.Projeto.Codigo);

            this.AbrirCadastroRelacao(campo, Tarefa.INCLUINDO);
        }

        /// <summary>
        /// Evento lançado no cliqeu da opção editar do campo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void item_editar_relacao_selected_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.item_editar_relacao_selected_Click()", Util.Global.TipoLog.DETALHADO);

            if (lockchange)
                return;

            MenuItem item = (MenuItem)sender;
            string codigo_relacao = item.Tag.ToString().Split(':')[0];
            string codigo_campoOrigem = item.Tag.ToString().Split(':')[1];
            string codigo_campoDestino = item.Tag.ToString().Split(':')[2];
            string codigo_tabelaOrigem = item.Tag.ToString().Split(':')[3];
            string codigo_tabelaDestino = item.Tag.ToString().Split(':')[4];
            string codigo_projeto = item.Tag.ToString().Split(':')[5];

            Model.MD_Projeto projeto = new Model.MD_Projeto(int.Parse(codigo_projeto));
            Model.MD_Tabela tabelaOrigem = new Model.MD_Tabela(int.Parse(codigo_tabelaOrigem), projeto.DAO.Codigo);
            Model.MD_Tabela tabelaDestino = new Model.MD_Tabela(int.Parse(codigo_tabelaDestino), projeto.DAO.Codigo);
            Model.MD_Campos campoOrigem = new Model.MD_Campos(int.Parse(codigo_campoOrigem), tabelaOrigem.DAO.Codigo, tabelaOrigem.DAO.Projeto.Codigo);
            Model.MD_Campos campoDestino = new Model.MD_Campos(int.Parse(codigo_campoDestino), tabelaDestino.DAO.Codigo, tabelaDestino.DAO.Projeto.Codigo);
            Model.MD_Relacao relacao = new Model.MD_Relacao(int.Parse(codigo_relacao), projeto.DAO, tabelaOrigem.DAO, tabelaDestino.DAO, campoOrigem.DAO, campoDestino.DAO);

            this.AbrirCadastroRelacao(campoOrigem, Tarefa.EDITANDO, relacao);
        }

        /// <summary>
        /// Evento lançado no cliqeu da opção excluir do campo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void item_excluir_relacao_selected_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.item_excluir_relacao_selected_Click()", Util.Global.TipoLog.DETALHADO);

            if (lockchange)
                return;

            MenuItem item = (MenuItem)sender;
            string codigo_relacao = item.Tag.ToString().Split(':')[0];
            string codigo_campoOrigem = item.Tag.ToString().Split(':')[1];
            string codigo_campoDestino = item.Tag.ToString().Split(':')[2];
            string codigo_tabelaOrigem = item.Tag.ToString().Split(':')[3];
            string codigo_tabelaDestino = item.Tag.ToString().Split(':')[4];
            string codigo_projeto = item.Tag.ToString().Split(':')[5];

            Model.MD_Projeto projeto = new Model.MD_Projeto(int.Parse(codigo_projeto));
            Model.MD_Tabela tabelaOrigem = new Model.MD_Tabela(int.Parse(codigo_tabelaOrigem), projeto.DAO.Codigo);
            Model.MD_Tabela tabelaDestino = new Model.MD_Tabela(int.Parse(codigo_tabelaDestino), projeto.DAO.Codigo);
            Model.MD_Campos campoOrigem = new Model.MD_Campos(int.Parse(codigo_campoOrigem), tabelaOrigem.DAO.Codigo, tabelaOrigem.DAO.Projeto.Codigo);
            Model.MD_Campos campoDestino = new Model.MD_Campos(int.Parse(codigo_campoDestino), tabelaDestino.DAO.Codigo, tabelaDestino.DAO.Projeto.Codigo);
            Model.MD_Relacao relacao = new Model.MD_Relacao(int.Parse(codigo_relacao), projeto.DAO, tabelaOrigem.DAO, tabelaDestino.DAO, campoOrigem.DAO, campoDestino.DAO);

            if (Message.MensagemConfirmaçãoYesNo("Deseja excluir a relação " + (string.IsNullOrEmpty(relacao.DAO.NomeForeingKey) ? "do campo " + relacao.DAO.CampoOrigem : relacao.DAO.NomeForeingKey) + "?") == DialogResult.Yes)
            {
                if (relacao.DAO.Delete())
                {
                    Message.MensagemSucesso("Excluído com sucesso!");
                    this.CarregaTreeViewAutomaticamente();
                    this.FecharTela(Telas.CADASTRO_CAMPOS);
                }
            }
        }

        /// <summary>
        /// Evento lançado no clique da opção buscar backup em opções
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsp_buscarBackupFile_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.tsp_buscarBackupFile_Click()", Util.Global.TipoLog.DETALHADO);

            this.BuscarBackupDER();
        }

        /// <summary>
        /// Evento lançado no clique do botão expandir do treeview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_expandTree_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.btn_expandTree_Click()", Util.Global.TipoLog.DETALHADO);

            this.trv_projetos.ExpandAll();
        }

        /// <summary>
        /// Evento lançado no clique do botão recolher do treeview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_inplandsTree_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.btn_inplandsTree_Click()", Util.Global.TipoLog.DETALHADO);

            this.trv_projetos.CollapseAll();
        }

        /// <summary>
        /// Evento lançado no clique da opção de configurações
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsp_configurações_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.tsp_configurações_Click()", Util.Global.TipoLog.DETALHADO);

            this.AbrirConfiguracoes();
        }

        /// <summary>
        /// Evento lançado no clique do botão de gera hash
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gerarHashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FO_GerarHash gerar = new FO_GerarHash();
            gerar.ShowDialog();
        }

        /// <summary>
        /// Evento lançado no clique da opção de apresentar mensagens automaticamente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void apresentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.apresentaToolStripMenuItem_Click()", Util.Global.TipoLog.DETALHADO);

            if (lockchange)
                return;
            lockchange = true;

            tsp_apresenta.Checked = true;
            tsp_naoApresenta.Checked = !tsp_apresenta.Checked;
            DataBase.Connection.SetApresentaInformacao(Informacao.APRESETAR);
            Util.Global.ApresentaInformacao = DataBase.Connection.GetApresentaInformacao();

            lockchange = false;
        }

        /// <summary>
        /// Evento lançado no clique da opção de apresentar não mensagens automaticamente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nãoApresentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.apresentaToolStripMenuItem_Click()", Util.Global.TipoLog.DETALHADO);

            if (lockchange)
                return;
            lockchange = true;

            tsp_apresenta.Checked = false;
            tsp_naoApresenta.Checked = !tsp_apresenta.Checked;
            DataBase.Connection.SetApresentaInformacao(Informacao.NAOAPRESENTAR);
            Util.Global.ApresentaInformacao = DataBase.Connection.GetApresentaInformacao();

            lockchange = false;
        }

        #endregion Eventos

        #region Construtores

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        public FO_Principal()
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.FO_Principal()", Util.Global.TipoLog.DETALHADO);
            IniciaForm();
        }

        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Método que faz a inicialização do Form
        /// </summary>
        public void IniciaForm()
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.IniciaForm()", Util.Global.TipoLog.DETALHADO);

            this.InitializeComponent();
            this.lbl_valorVersao.Text = Regras.Versao.Version.DAO.Dercreator;
            this.CarregaMenuOpcoes();
        }

        /// <summary>
        /// Método que carrega as informações da tela
        /// </summary>
        private void CarregaInformacoes()
        {
            if (Regras.Parametros.ApresentaQuantidades.DAO.Valor.Equals("1"))
            {
                this.pan_informacoesQuantidades.Visible = false;
            }
            else
            {
                this.pan_informacoesQuantidades.Visible = true;

                this.lbl_quantidadeProjeto.Text = new DAO.MD_Projeto().QuantidadeTotal("WHERE STATUS = '1'").ToString();
                this.lbl_quantidadeTabelas.Text = new DAO.MD_Tabela().QuantidadeTotal("WHERE PROJETO IN (SELECT CODIGO FROM PROJETO WHERE STATUS = '1')").ToString();
                this.lbl_quantidadeCampos.Text = new DAO.MD_Campos().QuantidadeTotal("WHERE CODIGOTABELA in (SELECT CODIGO FROM TABELA WHERE PROJETO IN (SELECT CODIGO FROM PROJETO WHERE STATUS = 1))").ToString();
                this.lbl_quantidadeForeign.Text = new DAO.MD_Relacao().QuantidadeTotal("WHERE CODIGOPROJETO IN (SELECT CODIGO FROM PROJETO WHERE STATUS = '1')").ToString(); 
            }
        }

        /// <summary>
        /// Método que carrega o menu de opções
        /// </summary>
        public void CarregaMenuOpcoes()
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.CarregaMenuOpcoes()", Util.Global.TipoLog.DETALHADO);

            lockchange = true;

            this.tsp_log_simples.Click += Tsp_log_simples_CheckedChanged;
            this.tsp_log_detalhado.Click += Tsp_log_detalhado_CheckedChanged;
            this.tsp_arquivosUtil.Click += Tsp_arquivosUTIL_Click;
            this.tsp_arquivosModel.Click += Tsp_arquivosModel_Click;

            this.tsp_log_detalhado.Checked = Util.Global.log_system == Util.Global.TipoLog.DETALHADO;
            this.tsp_log_simples.Checked = !tsp_log_detalhado.Checked;

            this.tsp_apresenta.Checked = Util.Global.ApresentaInformacao == Informacao.APRESETAR;
            this.tsp_naoApresenta.Checked = !tsp_apresenta.Checked;

            this.CarregaMenuAutomatico();

            lockchange = false;
        }

        /// <summary>
        /// Método que carrega as opções de carrega tree view automaticamente
        /// </summary>
        public void CarregaMenuAutomatico()
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.CarregaMenuAutomatico()", Util.Global.TipoLog.DETALHADO);

            lockchange = true;

            tspSim.Click += TspSim_Click;
            tspNao.Click += TspNao_Click;

            tspSim.Checked = Util.Global.CarregarAutomaticamente == Automatico.Automatico;
            tspNao.Checked = !tspSim.Checked;

            lockchange = false;
        }

        /// <summary>
        /// Método que carrega o tree view
        /// </summary>
        private void CarregaTreeView()
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.CarregaTreeView()", Util.Global.TipoLog.DETALHADO);

            this.trv_projetos.Nodes.Clear();
            BarraDeCarregamento aguarde = new BarraDeCarregamento(this.BuscaTotalItensTreeView(), "Carregando TreeView");

            aguarde.Show();
            this.trv_projetos.Scrollable = true;

            this.trv_projetos.Nodes.Add(this.CarregaProjetos(ref aguarde));

            this.CarregaInformacoes();

            aguarde.Close();
            aguarde.Dispose();
            aguarde = null;
        }

        /// <summary>
        /// Método que carrega os projetos cadastrados e os coloca no treeView
        /// </summary>
        private TreeNode CarregaProjetos(ref BarraDeCarregamento aguarde)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.CarregaProjetos()", Util.Global.TipoLog.DETALHADO);

            DbDataReader reader = DataBase.Connection.Select(new DAO.MD_Projeto().table.CreateCommandSQLTable());
            TreeNode projetos = new TreeNode("Sistemas");

            while (reader.Read())
            {
                aguarde.AvancaBarra(1);
                Model.MD_Projeto project = new Model.MD_Projeto(int.Parse(reader["CODIGO"].ToString()));

                TreeNode node = new TreeNode(project.DAO.Nome);
                node.Tag = "projetos:" + project.DAO.Codigo;
                node.ImageIndex = 0;
                node.SelectedImageIndex = 0;

                this.MontaMenuProjeto(project, ref node);

                if (project.DAO.StatusProjeto == Status.ATIVO)
                {
                    this.CarregaVersoes(project, ref node, ref aguarde);
                    this.CarregaTabelas(project, ref node, ref aguarde);
                    this.CarregaModulos(project, ref node, ref aguarde);
                    this.CarregaTestes(project, ref node, ref aguarde);
                }

                projetos.Nodes.Add(node);
            }

            projetos.Tag = -1;
            projetos.Expand();
            reader.Close();

            return projetos;
        }

        /// <summary>
        /// Método que monta o meno do node
        /// </summary>
        /// <param name="node"></param>
        private void MontaMenuProjeto(Model.MD_Projeto project, ref TreeNode node)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.MontaMenuProjeto()", Util.Global.TipoLog.DETALHADO);

            ContextMenu menu = new ContextMenu();

            if (project.DAO.StatusProjeto == Status.ATIVO)
            {
                MenuItem item_editar = new MenuItem("Editar", item_editar_selected_Click);
                item_editar.Tag = project.DAO.Codigo;

                MenuItem item_excluir = new MenuItem("Excluir", item_excluir_selected_Click);
                item_excluir.Tag = project.DAO.Codigo;

                MenuItem item_buscarTabelasBanco = new MenuItem("Buscar tabelas de banco de dados", item_buscarTabelaBancoDados_selected_Click);
                item_buscarTabelasBanco.Tag = project.DAO.Codigo;

                MenuItem item_buscaBackup = new MenuItem("Buscar Backup", item_buscarBackup_selected_Click);
                item_buscaBackup.Tag = project.DAO.Codigo;

                MenuItem item_desativar = new MenuItem("Desativar", item_desativar_selected_Click);
                item_desativar.Tag = project.DAO.Codigo;

                MenuItem item_gerarDER = new MenuItem("Gerar DER", item_gerarDER_selected_Click);
                item_gerarDER.Tag = project.DAO.Codigo;

                MenuItem item_gerarScript = new MenuItem("Gerar Scripts", item_gerarScriptsProjeto_selected_Click);
                item_gerarScript.Tag = project.DAO.Codigo;

                MenuItem item_gerarclasses = new MenuItem("Gerar Classes", item_gerarClasses_selected_Click);
                item_gerarclasses.Tag = project.DAO.Codigo;

                MenuItem item_gerarRelModulos = new MenuItem("Gerar Relatório de Módulos", item_gerarRelatorioTodosModulo_selected_Click);
                item_gerarRelModulos.Tag = project.DAO.Codigo;

                MenuItem item_gerarRelTestes = new MenuItem("Gerar Relatório de Testes", item_gerarRelatorioTodosTestes_selected_Click);
                item_gerarRelTestes.Tag = project.DAO.Codigo;

                menu.MenuItems.Add(item_buscaBackup);
                menu.MenuItems.Add(item_buscarTabelasBanco);
                menu.MenuItems.Add(item_desativar);
                menu.MenuItems.Add(item_editar);
                menu.MenuItems.Add(item_excluir);
                menu.MenuItems.Add(item_gerarclasses);
                menu.MenuItems.Add(item_gerarDER);
                menu.MenuItems.Add(item_gerarScript);
                menu.MenuItems.Add(item_gerarRelModulos);
                menu.MenuItems.Add(item_gerarRelTestes);

            }
            else
            {
                MenuItem item_ativar = new MenuItem("Ativar", item_ativar_selected_Click);
                item_ativar.Tag = project.DAO.Codigo;

                menu.MenuItems.Add(item_ativar);
            }

            node.ContextMenu = menu;
        }

        /// <summary>
        /// Método que preenche os relatórios de usabilidade do sistema
        /// </summary>
        /// <param name="project">Projeto dos relatórios</param>
        /// <param name="node">NOde do tree view para receber os relatórios</param>
        /// <param name="aguarde"></param>
        public void CarregaModulos(Model.MD_Projeto project, ref TreeNode node, ref BarraDeCarregamento aguarde)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.CarregaRelatoriosUso()", Util.Global.TipoLog.DETALHADO);

            DbDataReader reader = DataBase.Connection.Select(new DAO.MD_Modulos().table.CreateCommandSQLTable() + " WHERE CODIGOPROJETO = " + project.DAO.Codigo);

            TreeNode nodeRelatorios = new TreeNode("Módulos");
            nodeRelatorios.Tag = project.DAO.Codigo;
            
            while (reader.Read())
            {
                aguarde.AvancaBarra(1);
                Model.MD_Modulos modulo = new Model.MD_Modulos(int.Parse(reader["CODIGO"].ToString()), int.Parse(reader["CODIGOPROJETO"].ToString()));

                TreeNode nodeRelatorio = new TreeNode(modulo.DAO.NomeModulo);
                nodeRelatorio.Tag = "modulos:" + modulo.DAO.Codigo + ":" + project.DAO.Codigo;
                nodeRelatorio.ImageIndex = 5;
                nodeRelatorio.SelectedImageIndex = 5;

                this.IncluiMenuRelatorio(ref nodeRelatorio, modulo, project);

                nodeRelatorios.Nodes.Add(nodeRelatorio);
            }

            ContextMenu menu = new ContextMenu();

            MenuItem incluirModulo = new MenuItem("Incluir Módulo", item_adicionaModulo_tabela_selected_Click);
            incluirModulo.Tag = project.DAO.Codigo;

            MenuItem RelatorioModulo = new MenuItem("Gerar Relatório dos Módulos", item_gerarRelatorioTodosModulo_selected_Click);
            RelatorioModulo.Tag = project.DAO.Codigo;

            menu.MenuItems.Add(incluirModulo);
            menu.MenuItems.Add(RelatorioModulo);

            nodeRelatorios.ContextMenu = menu;

            nodeRelatorios.Expand();
            node.Nodes.Add(nodeRelatorios);
            reader.Close();
        }

        /// <summary>
        /// Método que preenche os relatórios de usabilidade do sistema
        /// </summary>
        /// <param name="project">Projeto dos relatórios</param>
        /// <param name="node">NOde do tree view para receber os relatórios</param>
        /// <param name="aguarde"></param>
        public void CarregaTestes(Model.MD_Projeto project, ref TreeNode node, ref BarraDeCarregamento aguarde)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.CarregaTestes()", Util.Global.TipoLog.DETALHADO);

            DbDataReader reader = DataBase.Connection.Select(new DAO.MD_Testes().table.CreateCommandSQLTable() + " WHERE CODIGOPROJETO = " + project.DAO.Codigo);

            TreeNode nodeTestes = new TreeNode("Testes");
            nodeTestes.Tag = project.DAO.Codigo;
            while (reader.Read())
            {
                aguarde.AvancaBarra(1);
                Model.MD_Teste teste = new Model.MD_Teste(int.Parse(reader["CODIGO"].ToString()), project);

                TreeNode nodeRelatorio = new TreeNode("Módulo - " + new DAO.MD_Modulos(teste.DAO.Codigomodulo, project.DAO.Codigo).NomeModulo);
                nodeRelatorio.Tag = "testes:" + teste.DAO.Codigo + ":" + project.DAO.Codigo;
                nodeRelatorio.ImageIndex = 6;
                nodeRelatorio.SelectedImageIndex = 6;

                this.IncluiMenuTeste(ref nodeRelatorio, teste, project);

                nodeTestes.Nodes.Add(nodeRelatorio);
            }

            ContextMenu menu = new ContextMenu();

            MenuItem incluirTeste = new MenuItem("Incluir Teste", item_adicionaTeste_tabela_selected_Click);
            incluirTeste.Tag = project.DAO.Codigo;

            MenuItem RelatorioTeste = new MenuItem("Gerar Relatório dos Testes", item_gerarRelatorioTodosTestes_selected_Click);
            RelatorioTeste.Tag = project.DAO.Codigo;

            menu.MenuItems.Add(incluirTeste);
            menu.MenuItems.Add(RelatorioTeste);

            nodeTestes.ContextMenu = menu;

            nodeTestes.Expand();
            node.Nodes.Add(nodeTestes);
            reader.Close();
        }

        /// <summary>
        /// Método que adiciona as tabelas no node do projeto
        /// </summary>
        /// <param name="project">Projeto selecionado no node</param>
        /// /// <param name="node">Node a acionar as tabelas</param>
        public void CarregaVersoes(Model.MD_Projeto project, ref TreeNode node, ref BarraDeCarregamento aguarde)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.CarregaVersoes()", Util.Global.TipoLog.DETALHADO);

            DbDataReader reader = DataBase.Connection.Select(new DAO.MD_Versoes().table.CreateCommandSQLTable() + " WHERE CODIGOPROJETO = " + project.DAO.Codigo + " ORDER BY VERSAO");

            TreeNode nodeTabelas = new TreeNode("Versões");
            nodeTabelas.Tag = string.Empty;

            while (reader.Read())
            {
                aguarde.AvancaBarra(1);
                Model.MD_Versoes versao = new Model.MD_Versoes(reader["VERSAO"].ToString(), project.DAO.Codigo);

                TreeNode nodeTabela = new TreeNode(versao.DAO.Versao);
                nodeTabela.Tag = "versoes:" + versao.DAO.Versao + ":" + project.DAO.Codigo;
                nodeTabela.ImageIndex = 1;
                nodeTabela.SelectedImageIndex = 1;

                this.IncluiMenuVersao(ref nodeTabela, versao, project);

                nodeTabelas.Nodes.Add(nodeTabela);
            }

            MenuItem item_incluirVersao = new MenuItem("Incluir versão", delegate { this.AbrirCadastroVersao(new Model.MD_Versoes(string.Empty, projeto.DAO.Codigo), Tarefa.INCLUINDO, project); });
            item_incluirVersao.Tag = project.DAO.Codigo;


            ContextMenu menu = new ContextMenu();
            menu.MenuItems.Add(item_incluirVersao);
            nodeTabelas.ContextMenu = menu;

            nodeTabelas.Expand();
            node.Nodes.Add(nodeTabelas);
            reader.Close();
        }

        /// <summary>
        /// Método que adiciona as tabelas no node do projeto
        /// </summary>
        /// <param name="project">Projeto selecionado no node</param>
        /// /// <param name="node">Node a acionar as tabelas</param>
        public void CarregaTabelas(Model.MD_Projeto project, ref TreeNode node, ref BarraDeCarregamento aguarde)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.CarregaTabelas()", Util.Global.TipoLog.DETALHADO);

            DbDataReader reader = DataBase.Connection.Select(new DAO.MD_Tabela().table.CreateCommandSQLTable() + " WHERE PROJETO = " + project.DAO.Codigo + " ORDER BY NOME");

            TreeNode nodeTabelas = new TreeNode("Tabelas");
            nodeTabelas.Tag = string.Empty;

            while (reader.Read())
            {
                aguarde.AvancaBarra(1);
                Model.MD_Tabela tabela = new Model.MD_Tabela(int.Parse(reader["CODIGO"].ToString()), project.DAO.Codigo);

                if (tabela.DAO.Projeto.Codigo != project.DAO.Codigo)
                    continue;

                TreeNode nodeTabela = new TreeNode(tabela.DAO.Nome);
                nodeTabela.Tag = "tabelas:" + tabela.DAO.Codigo + ":" + project.DAO.Codigo;
                nodeTabela.ImageIndex = 1;
                nodeTabela.SelectedImageIndex = 1;

                this.IncluiMenuTabela(ref nodeTabela, tabela, project);
                this.CarregaCampos(tabela, ref nodeTabela, ref aguarde);

                nodeTabelas.Nodes.Add(nodeTabela);
            }

            MenuItem item_incluirTabela = new MenuItem("Incluir tabela", item_incluirTabela_selected_Click);
            item_incluirTabela.Tag = project.DAO.Codigo;

            MenuItem item_gerarDER = new MenuItem("Gerar DER", item_gerarDERProjeto_selected_Click);
            item_gerarDER.Tag = project.DAO.Codigo;

            MenuItem item_gerarScript = new MenuItem("Gerar Scripts", item_gerarScriptsProjeto_selected_Click);
            item_gerarScript.Tag = project.DAO.Codigo;


            ContextMenu menu = new ContextMenu();
            menu.MenuItems.Add(item_incluirTabela);
            menu.MenuItems.Add(item_gerarDER);
            menu.MenuItems.Add(item_gerarScript);
            nodeTabelas.ContextMenu = menu;

            nodeTabelas.Expand();
            node.Nodes.Add(nodeTabelas);
            reader.Close();
        }

        /// <summary>
        /// Método que adiciona o menu à tabela
        /// </summary>
        /// <param name="nodeTabela">Node referente à tabela</param>
        private void IncluiMenuTeste(ref TreeNode nodeTabela, Model.MD_Teste teste, Model.MD_Projeto projeto)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.IncluiMenuTeste()", Util.Global.TipoLog.DETALHADO);

            MenuItem item_editar_relatorio = new MenuItem("Editar", item_editar_teste_selected_Click);
            item_editar_relatorio.Tag = teste.DAO.Codigo + ":" + projeto.DAO.Codigo;

            MenuItem item_excluir_relatorio = new MenuItem("Excluir", item_excluir_teste_selected_Click);
            item_excluir_relatorio.Tag = teste.DAO.Codigo + ":" + projeto.DAO.Codigo;

            MenuItem item_gerarrelatorio = new MenuItem("Gerar Relatorio", item_gerarRelatorioModulo_selected_Click);
            item_gerarrelatorio.Tag = teste.DAO.Codigo + ":" + projeto.DAO.Codigo;

            ContextMenu menuCenario = new ContextMenu();

            menuCenario.MenuItems.Add(item_editar_relatorio);
            menuCenario.MenuItems.Add(item_excluir_relatorio);
            menuCenario.MenuItems.Add(item_gerarrelatorio);
            nodeTabela.ContextMenu = menuCenario;
        }

        /// <summary>
        /// Método que adiciona o menu à tabela
        /// </summary>
        /// <param name="nodeTabela">Node referente à tabela</param>
        private void IncluiMenuRelatorio(ref TreeNode nodeTabela, Model.MD_Modulos modulo, Model.MD_Projeto projeto)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.IncluiMenuRelatorio()", Util.Global.TipoLog.DETALHADO);

            MenuItem item_editar_relatorio = new MenuItem("Editar", item_editar_modulo_selected_Click);
            item_editar_relatorio.Tag = modulo.DAO.Codigo + ":" + projeto.DAO.Codigo;

            MenuItem item_excluir_relatorio = new MenuItem("Excluir", item_excluir_modulo_selected_Click);
            item_excluir_relatorio.Tag = modulo.DAO.Codigo + ":" + projeto.DAO.Codigo;

            MenuItem item_gerarrelatorio = new MenuItem("Gerar Relatorio", item_gerarRelatorioModulo_selected_Click);
            item_gerarrelatorio.Tag = modulo.DAO.Codigo + ":" + projeto.DAO.Codigo;

            ContextMenu menuCenario = new ContextMenu();

            menuCenario.MenuItems.Add(item_editar_relatorio);
            menuCenario.MenuItems.Add(item_excluir_relatorio);
            menuCenario.MenuItems.Add(item_gerarrelatorio);
            nodeTabela.ContextMenu = menuCenario;
        }

        /// <summary>
        /// Método que adiciona o menu à tabela
        /// </summary>
        /// <param name="nodeTabela">Node referente à tabela</param>
        private void IncluiMenuVersao(ref TreeNode nodeTabela, Model.MD_Versoes versao, Model.MD_Projeto projeto)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.IncluiMenuVersao()", Util.Global.TipoLog.DETALHADO);

            MenuItem item_BaixarInstalador = new MenuItem("Baixar Instalador", delegate { /*TODO*/ });
            item_BaixarInstalador.Tag = versao.DAO.Versao + ":" + projeto.DAO.Codigo;

            ContextMenu menuCenario = new ContextMenu();

            menuCenario.MenuItems.Add(item_BaixarInstalador);

            nodeTabela.ContextMenu = menuCenario;
        }

        /// <summary>
        /// Método que adiciona o menu à tabela
        /// </summary>
        /// <param name="nodeTabela">Node referente à tabela</param>
        private void IncluiMenuTabela(ref TreeNode nodeTabela, Model.MD_Tabela tabela, Model.MD_Projeto projeto)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.IncluiMenuTabela()", Util.Global.TipoLog.DETALHADO);

            MenuItem item_editar_tabela = new MenuItem("Editar", item_editar_tabela_selected_Click);
            item_editar_tabela.Tag = tabela.DAO.Codigo + ":" + projeto.DAO.Codigo;

            MenuItem item_excluir_tabela = new MenuItem("Excluir", item_excluir_tabela_selected_Click);
            item_excluir_tabela.Tag = tabela.DAO.Codigo + ":" + projeto.DAO.Codigo;

            MenuItem item_adicionarCampo_tabela = new MenuItem("Adicionar Campo", item_adicionaCampo_tabela_selected_Click);
            item_adicionarCampo_tabela.Tag = tabela.DAO.Codigo + ":" + projeto.DAO.Codigo;

            MenuItem item_gerarclasse = new MenuItem("Gerar Classe", item_gerarClasse_selected_Click);
            item_gerarclasse.Tag = tabela.DAO.Codigo + ":" + projeto.DAO.Codigo;

            MenuItem item_gerarScript = new MenuItem("Gerar Script", item_gerarScriptTabela_selected_Click);
            item_gerarScript.Tag = tabela.DAO.Codigo + ":" + projeto.DAO.Codigo;

            ContextMenu menuCenario = new ContextMenu();

            menuCenario.MenuItems.Add(item_adicionarCampo_tabela);
            menuCenario.MenuItems.Add(item_editar_tabela);
            menuCenario.MenuItems.Add(item_excluir_tabela);
            menuCenario.MenuItems.Add(item_gerarclasse);
            menuCenario.MenuItems.Add(item_gerarScript);

            nodeTabela.ContextMenu = menuCenario;
        }

        /// <summary>
        /// Método que carrega os campos da tabela
        /// </summary>
        /// <param name="tabela">Tabela para buscar os campos</param>
        /// <param name="node">Node para adicionar os campos</param>
        public void CarregaCampos(Model.MD_Tabela tabela, ref TreeNode node, ref BarraDeCarregamento aguarde)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.CarregaCampos()", Util.Global.TipoLog.DETALHADO);

            DbDataReader reader = DataBase.Connection.Select(new DAO.MD_Campos().table.CreateCommandSQLTable() + " WHERE CODIGOTABELA = " + tabela.DAO.Codigo + " ORDER BY NOME");

            while (reader.Read())
            {
                aguarde.AvancaBarra(1);
                Model.MD_Campos campo = new Model.MD_Campos(int.Parse(reader["CODIGO"].ToString()), tabela.DAO.Codigo, tabela.DAO.Projeto.Codigo);

                if (tabela.DAO.Codigo != campo.DAO.Tabela.Codigo)
                    continue;

                TreeNode nodeCampo = new TreeNode(campo.DAO.Nome);
                nodeCampo.Tag = "campos:" + campo.DAO.Codigo + ":" + tabela.DAO.Codigo + ":" + tabela.DAO.Projeto.Codigo;
                nodeCampo.ImageIndex = 2;
                nodeCampo.SelectedImageIndex = 2;

                this.CarregaRelacoes(campo, ref nodeCampo, ref aguarde);
                this.IncluiMenuCampo(ref nodeCampo, campo);

                node.Nodes.Add(nodeCampo);
            }

            reader.Close();
        }

        /// <summary>
        /// Método que adiciona o menu ao campo
        /// </summary>
        /// <param name="nodeTabela">Node referente ao campo</param>
        private void IncluiMenuCampo(ref TreeNode nodeTabela, Model.MD_Campos campo)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.IncluiMenuCampo()", Util.Global.TipoLog.DETALHADO);

            MenuItem item_editar_tabela = new MenuItem("Editar", item_editar_campo_selected_Click);
            item_editar_tabela.Tag = campo.DAO.Codigo + ":" + campo.DAO.Tabela.Codigo + ":" + campo.DAO.Projeto.Codigo;

            MenuItem item_excluir_tabela = new MenuItem("Excluir", item_excluir_campo_selected_Click);
            item_excluir_tabela.Tag = campo.DAO.Codigo + ":" + campo.DAO.Tabela.Codigo + ":" + campo.DAO.Projeto.Codigo;

            MenuItem item_incluirRelacao_tabela = new MenuItem("Incluir relacionamento", item_incluirRelacionamento_campo_selected_Click);
            item_incluirRelacao_tabela.Tag = campo.DAO.Codigo + ":" + campo.DAO.Tabela.Codigo + ":" + campo.DAO.Projeto.Codigo;

            ContextMenu menuCenario = new ContextMenu();
            menuCenario.MenuItems.Add(item_editar_tabela);
            menuCenario.MenuItems.Add(item_excluir_tabela);
            menuCenario.MenuItems.Add(item_incluirRelacao_tabela);
            nodeTabela.ContextMenu = menuCenario;
        }

        /// <summary>
        /// Método que carrega as relações do campo
        /// </summary>
        /// <param name="campo">Campo para buscar as relações</param>
        /// <param name="node">node para preencher as relações</param>
        public void CarregaRelacoes(Model.MD_Campos campo, ref TreeNode node, ref BarraDeCarregamento aguarde)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.CarregaRelacoes()", Util.Global.TipoLog.DETALHADO);

            DbDataReader reader = DataBase.Connection.Select(new DAO.MD_Relacao().table.CreateCommandSQLTable() + " WHERE CAMPOORIGEM = " + campo.DAO.Codigo + " ORDER BY FOREINGKEY");

            while (reader.Read())
            {
                aguarde.AvancaBarra(1);
                Model.MD_Tabela tabelaDestino = new Model.MD_Tabela(int.Parse(reader["TABELADESTINO"].ToString()), campo.DAO.Projeto.Codigo);
                Model.MD_Campos campoDestino = new Model.MD_Campos(int.Parse(reader["CAMPODESTINO"].ToString()), tabelaDestino.DAO.Codigo, tabelaDestino.DAO.Projeto.Codigo);

                Model.MD_Relacao relacao = new Model.MD_Relacao(int.Parse(reader["CODIGO"].ToString()), campo.DAO.Projeto, campo.DAO.Tabela, tabelaDestino.DAO, campo.DAO, campoDestino.DAO);

                if (campo.DAO.Codigo != relacao.DAO.CampoOrigem.Codigo)
                    continue;

                TreeNode nodeRelacao = new TreeNode(string.IsNullOrEmpty(relacao.DAO.NomeForeingKey) ? campo.DAO.Nome : relacao.DAO.NomeForeingKey);
                nodeRelacao.Tag = "relacoes:" + relacao.DAO.Codigo + ":" + campo.DAO.Codigo + ":" + campoDestino.DAO.Codigo + ":" + campo.DAO.Tabela.Codigo + ":" + tabelaDestino.DAO.Codigo + ":" + campo.DAO.Projeto.Codigo;
                nodeRelacao.ImageIndex = 3;
                nodeRelacao.SelectedImageIndex = 3;

                this.IncluiMenuRelacao(ref nodeRelacao, relacao);

                node.Nodes.Add(nodeRelacao);
            }

            reader.Close();
        }

        /// <summary>
        /// Método que adiciona o menu ao campo
        /// </summary>
        /// <param name="nodeTabela">Node referente ao campo</param>
        private void IncluiMenuRelacao(ref TreeNode nodeTabela, Model.MD_Relacao relacao)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.IncluiMenuRelacao()", Util.Global.TipoLog.DETALHADO);

            MenuItem item_editar_relacao = new MenuItem("Editar", item_editar_relacao_selected_Click);
            item_editar_relacao.Tag = relacao.DAO.Codigo + ":" + relacao.DAO.CampoOrigem.Codigo + ":" + relacao.DAO.CampoDestino.Codigo + ":" + relacao.DAO.CampoOrigem.Tabela.Codigo + ":" + relacao.DAO.TabelaDestino.Codigo + ":" + relacao.DAO.Projeto.Codigo;

            MenuItem item_excluir_relacao = new MenuItem("Excluir", item_excluir_relacao_selected_Click);
            item_excluir_relacao.Tag = relacao.DAO.Codigo + ":" + relacao.DAO.CampoOrigem.Codigo + ":" + relacao.DAO.CampoDestino.Codigo + ":" + relacao.DAO.CampoOrigem.Tabela.Codigo + ":" + relacao.DAO.TabelaDestino.Codigo + ":" + relacao.DAO.Projeto.Codigo;

            ContextMenu menuCenario = new ContextMenu();
            menuCenario.MenuItems.Add(item_editar_relacao);
            menuCenario.MenuItems.Add(item_excluir_relacao);
            nodeTabela.ContextMenu = menuCenario;
        }

        /// <summary>
        /// Método que abre a janela de cadastro de projeto
        /// </summary>
        public void AbrirJanelaDeCadastroProjeto(Util.Enumerator.Tarefa tarefa, int codigo = -1)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.AbrirJanelaDeCadastroProjeto()", Util.Global.TipoLog.DETALHADO);

            Model.MD_Projeto proj = new Model.MD_Projeto(codigo);
            this.AbreJanela(new Visao.UC_CadastroProjeto(tarefa, proj, this), "Cadastro de Projeto", Telas.CADASTRO_PROJETO);
        }

        /// <summary>
        /// Método que abre janela de cadastro de tabela
        /// </summary>
        /// <param name="project"></param>
        public void AbrirCadastroTabela(Model.MD_Projeto project, Tarefa tarefa, Model.MD_Tabela table = null)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.AbrirCadastroTabela()", Util.Global.TipoLog.DETALHADO);

            this.AbreJanela(new Visao.UC_CadastroTabela(tarefa, table == null ? new Model.MD_Tabela(-1, project.DAO.Codigo) : table, project, this), "Cadastro de Tabela", Telas.CADASTRO_TABELAS);
        }

        /// <summary>
        /// Método que abre a janela de cadastro de campo
        /// </summary>
        /// <param name="campo">Classe de instância do campo</param>
        /// <param name="tarefa"></param>
        public void AbrirCadastroTeste(Model.MD_Teste teste, Model.MD_Projeto projeto, Tarefa tarefa)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.AbrirCadastroTeste()", Util.Global.TipoLog.DETALHADO);

            this.AbreJanela(new Visao.UC_CadastroTeste(teste, tarefa, this, projeto), "Cadastro de Teste", Telas.CADASTRO_TESTES);
        }

        /// <summary>
        /// Método que abre a janela de cadastro de campo
        /// </summary>
        /// <param name="campo">Classe de instância do campo</param>
        /// <param name="tarefa"></param>
        public void AbrirCadastroModulo(Model.MD_Modulos modulo, Model.MD_Projeto projeto, Tarefa tarefa)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.AbrirCadastroCampo()", Util.Global.TipoLog.DETALHADO);

            this.AbreJanela(new Visao.UC_CadastroModulo(tarefa, projeto, modulo, this), "Cadastro de Módulo", Telas.CADASTRO_MODULO);
        }

        /// <summary>
        /// Método que abre a janela de cadastro de campo
        /// </summary>
        /// <param name="campo">Classe de instância do campo</param>
        /// <param name="tarefa"></param>
        public void AbrirCadastroCampo(Model.MD_Tabela tabela, Tarefa tarefa, Model.MD_Campos campo = null)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.AbrirCadastroCampo()", Util.Global.TipoLog.DETALHADO);

            this.AbreJanela(new Visao.UC_CadastroCampos(tarefa, campo, tabela, this), "Cadastro de Campos", Telas.CADASTRO_CAMPOS);
        }

        /// <summary>
        /// Método que abre a janela de cadastro de campo
        /// </summary>
        /// <param name="campo">Classe de instância do campo</param>
        /// <param name="tarefa"></param>
        public void AbrirCadastroVersao(Model.MD_Versoes tabela, Tarefa tarefa, Model.MD_Projeto projeto)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.AbrirCadastroVersao()", Util.Global.TipoLog.DETALHADO);

            this.AbreJanela(new Visao.UC_CadastroVersao(tarefa, tabela, projeto, this), "Cadastro de Versões", Telas.CADASTRO_VERSAO);
        }

        /// <summary>
        /// Método que abre a janela de cadastro de campo
        /// </summary>
        /// <param name="campo">Classe de instância do campo</param>
        /// <param name="tarefa"></param>
        public void AbrirCadastroRelacao(Model.MD_Campos campoOrigem, Tarefa tarefa, Model.MD_Relacao relacao = null)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.AbrirCadastroRelacao()", Util.Global.TipoLog.DETALHADO);

            Visao.FO_Relacionamento cadastro = null;

            if (relacao == null)
            {
                cadastro = new Visao.FO_Relacionamento(tarefa, campoOrigem, this);
            }
            else
            {
                cadastro = new Visao.FO_Relacionamento(tarefa, new Model.MD_Campos(relacao.DAO.CampoOrigem.Codigo, relacao.DAO.CampoOrigem.Tabela.Codigo, relacao.DAO.Projeto.Codigo), this, relacao);
            }

            cadastro.ShowDialog();
        }

        /// <summary>
        /// Método que abre a janela para visualização
        /// </summary>
        /// <param name="code">Código da janela a ser aberta</param>
        public void AbrirJanela(string code)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.AbrirJanela()", Util.Global.TipoLog.DETALHADO);

            string janela = code.Split(':')[0];

            if (janela.Equals("projetos"))
            {
                int cod = int.Parse(code.Split(':')[1]);
                this.AbrirJanelaDeCadastroProjeto(Tarefa.VISUALIZANDO, cod);
            }
            else if (janela.Equals("tabelas"))
            {
                int tab = int.Parse(code.Split(':')[1]);
                int proj = int.Parse(code.Split(':')[2]);
                this.AbrirCadastroTabela(new Model.MD_Projeto(proj), Tarefa.VISUALIZANDO, new Model.MD_Tabela(tab, proj));
            }
            else if (janela.Equals("campos"))
            {
                int cam = int.Parse(code.Split(':')[1]);
                int tab = int.Parse(code.Split(':')[2]);
                int proj = int.Parse(code.Split(':')[3]);

                Model.MD_Projeto proje = new Model.MD_Projeto(proj);
                Model.MD_Tabela table = new Model.MD_Tabela(tab, proje.DAO.Codigo);
                Model.MD_Campos campo = new Model.MD_Campos(cam, table.DAO.Codigo, table.DAO.Projeto.Codigo);

                this.AbrirCadastroCampo(table, Tarefa.VISUALIZANDO, campo);

            }
            else if (janela.Equals("relacoes"))
            {
                string codigo_relacao = code.Split(':')[1];
                string codigo_campoOrigem = code.Split(':')[2];
                string codigo_campoDestino = code.Split(':')[3];
                string codigo_tabelaOrigem = code.Split(':')[4];
                string codigo_tabelaDestino = code.Split(':')[5];
                string codigo_projeto = code.Split(':')[6];

                Model.MD_Projeto projeto = new Model.MD_Projeto(int.Parse(codigo_projeto));
                Model.MD_Tabela tabelaOrigem = new Model.MD_Tabela(int.Parse(codigo_tabelaOrigem), projeto.DAO.Codigo);
                Model.MD_Tabela tabelaDestino = new Model.MD_Tabela(int.Parse(codigo_tabelaDestino), projeto.DAO.Codigo);
                Model.MD_Campos campoOrigem = new Model.MD_Campos(int.Parse(codigo_campoOrigem), tabelaOrigem.DAO.Codigo, tabelaOrigem.DAO.Projeto.Codigo);
                Model.MD_Campos campoDestino = new Model.MD_Campos(int.Parse(codigo_campoDestino), tabelaDestino.DAO.Codigo, tabelaDestino.DAO.Projeto.Codigo);
                Model.MD_Relacao relacao = new Model.MD_Relacao(int.Parse(codigo_relacao), projeto.DAO, tabelaOrigem.DAO, tabelaDestino.DAO, campoOrigem.DAO, campoDestino.DAO);

                this.AbrirCadastroRelacao(campoOrigem, Tarefa.VISUALIZANDO, relacao);
            }
            else if (janela.Equals("modulos"))
            {
                string codigo_modulo = code.Split(':')[1];
                string codigo_projeto = code.Split(':')[2];
                Model.MD_Modulos mod = new Model.MD_Modulos(int.Parse(codigo_modulo), int.Parse(codigo_projeto));
                this.AbrirCadastroModulo(mod,new Model.MD_Projeto(int.Parse(codigo_projeto)), Tarefa.VISUALIZANDO);
            }
            else if (janela.Equals("testes"))
            {
                string codigo_teste = code.Split(':')[1];
                string codigo_projeto = code.Split(':')[2];
                Model.MD_Projeto projeto = new Model.MD_Projeto(int.Parse(codigo_projeto));
                Model.MD_Teste mod = new Model.MD_Teste(int.Parse(codigo_teste), projeto);
                this.AbrirCadastroTeste(mod, projeto, Tarefa.VISUALIZANDO);
            }
            else if (janela.Equals("versoes"))
            {
                string codVersao = code.Split(':')[1];
                int cod = int.Parse(code.Split(':')[2]);
                this.AbrirCadastroVersao(new Model.MD_Versoes(codVersao, cod), Tarefa.VISUALIZANDO, new Model.MD_Projeto(cod));
            }
        }

        /// <summary>
        /// Método que abre uma nova aba no tab page
        /// </summary>
        /// <param name="control">User control a ser aberto dentro da page</param>
        /// <param name="titulo">Título da aba da página a ser aberta</param>
        public void AbreJanela(UserControl control, string titulo, Telas tag)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.AbreJanela()", Util.Global.TipoLog.DETALHADO);

            int index = 0;
            Telas tag_aberto = Telas.CADASTRO_PROJETO;
            bool aberto = false;
            foreach (TabPage p in pages)
            {
                if ((int)p.Tag == (int)tag)
                {
                    tag_aberto = (Telas)p.Tag;
                    aberto = true;
                    break;
                }
                else index++;
            }

            if (aberto)
                FecharTela(tag_aberto);
            TabPage page = new TabPage(titulo);

            TabPage tabPage1 = new TabPage(titulo);
            tabPage1.Tag = (int)tag;
            pages.Add(tabPage1);

            tabPage1.Controls.Add(control);
            this.tbc_table_control.Controls.Add(tabPage1);
            this.tbc_table_control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbc_table_control.Name = titulo;

            index = 0;
            foreach (TabPage p in this.tbc_table_control.Controls)
            {
                if ((int)p.Tag == (int)tag)
                    break;
                index++;
            }

            this.tbc_table_control.TabIndex = index;
            this.tbc_table_control.SelectedIndex = index;
        }

        /// <summary>
        /// Método que fecha a tela
        /// </summary>
        /// <param name="tag"></param>
        public void FecharTela(Telas tag)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.FecharTela()", Util.Global.TipoLog.DETALHADO);

            int index = 0;
            foreach (TabPage p in pages)
            {
                if ((int)p.Tag == (int)tag)
                {
                    p.Dispose();
                    break;
                }
                else index++;
            }

            if (index < pages.Count)
                pages.RemoveAt(index);
        }

        /// <summary>
        /// Método que abre a busca de importação
        /// </summary>
        /// <param name="codigoProjeto">Código do projeto para se buscar a importação</param>
        private void BuscarImportacaoBancoDados(int codigoProjeto)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.BuscarImportacaoBancoDados()", Util.Global.TipoLog.DETALHADO);

            if (Regras.Importador.Importar(codigoProjeto))
            {
                Message.MensagemSucesso("Importação concluída sem erros!");
                CarregaTreeViewAutomaticamente();
            }
            else
            {
                Message.MensagemErro("Houve erros ao importar, verificar arquivo de log!");
                CarregaTreeViewAutomaticamente();
            }
        }

        /// <summary>
        /// Método que busca o total dos itens presentes no tree view
        /// </summary>
        /// <returns></returns>
        private int BuscaTotalItensTreeView()
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.BuscaTotalItensTreeView()", Util.Global.TipoLog.DETALHADO);

            int totalProjetos = 0;
            int totalTabelas = 0;
            int totalCampos = 0;
            int totalRelacoes = 0;
            int totalModulos = 0;

            DAO.MD_Projeto projeto = new DAO.MD_Projeto();
            totalProjetos = projeto.QuantidadeTotal();

            DAO.MD_Tabela tabela = new DAO.MD_Tabela();
            totalTabelas = tabela.QuantidadeTotal();

            DAO.MD_Campos campos = new DAO.MD_Campos();
            totalCampos = campos.QuantidadeTotal();

            DAO.MD_Relacao relacoes = new DAO.MD_Relacao();
            totalRelacoes = relacoes.QuantidadeTotal();

            DAO.MD_Modulos moduloes = new DAO.MD_Modulos();
            totalModulos = moduloes.QuantidadeTotal();

            return totalProjetos + totalCampos + totalRelacoes + totalTabelas + totalModulos;
        }

        /// <summary>
        /// Método que busca o backup a partir de um arquivo DER
        /// </summary>
        public void BuscarBackupDER()
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.BuscarBackupDER()", Util.Global.TipoLog.DETALHADO);

            string caminho = string.Empty;

            OpenFileDialog dialog_f = new OpenFileDialog();
            dialog_f.Title = "Seleção do DER (tableB) para importação!";

            if (dialog_f.ShowDialog() == DialogResult.OK)
            {
                caminho = dialog_f.FileName.ToString();
                FileInfo fileInfo = new FileInfo(caminho);
                string mensagem = string.Empty;

                // Se estiver vazio é necessário cadastrar
                if (this.projeto.DAO.Empty)
                {
                    FO_CadastroProjeto cadastroProjeto = new FO_CadastroProjeto(this);

                    if (cadastroProjeto.ShowDialog() == DialogResult.OK)
                    {
                        if (Regras.Backup.BuscarBackup(this.projeto, fileInfo, ref mensagem))
                        {
                            Message.MensagemSucesso("Backup feito com sucesso!");
                            CarregaTreeViewAutomaticamente();
                        }
                    }
                }
                else
                {
                    if (Regras.Backup.BuscarBackup(projeto, fileInfo, ref mensagem))
                    {
                        Message.MensagemSucesso("Backup feito com sucesso!");
                        CarregaTreeViewAutomaticamente();
                    }
                }
            }
        }

        /// <summary>
        /// Método que carrega o treeview se estiver automático
        /// </summary>
        public void CarregaTreeViewAutomaticamente()
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.CarregaTreeViewAutomaticamente()", Util.Global.TipoLog.DETALHADO);

            if (Util.Global.CarregarAutomaticamente == Automatico.Automatico)
            {
                this.CarregaTreeView();
            }
        }

        /// <summary>
        /// Método que abre a tela de configurações
        /// </summary>
        public void AbrirConfiguracoes()
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.AbrirConfiguracoes()", Util.Global.TipoLog.DETALHADO);

            FO_Configuracoes configuracoes = new FO_Configuracoes();
            configuracoes.Show();
        }

        /// <summary>
        /// Método que gera as classes de um projeto
        /// </summary>
        /// <param name="projeto"></param>
        public void GerarClasses(Model.MD_Projeto projeto)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.GerarClasses()", Util.Global.TipoLog.DETALHADO);

            string mensagemErro = string.Empty;
            List<Model.MD_Tabela> tabelas = projeto.GetTabelasProjeto();
            List<Model.MD_Tabela> tabelas_erro = projeto.GetTabelasProjeto();
            bool houveErro = false;

            if (tabelas.Count < 1)
            {
                Message.MensagemAlerta("Não há tabelas cadastradas para o projeto selecionado!");
            }
            else
            {
                BarraDeCarregamento barra = new BarraDeCarregamento(tabelas.Count * 2, "Gerando as classes");
                barra.Show();

                foreach (Model.MD_Tabela t in tabelas)
                {
                    barra.AvancaBarra(1);
                    if (!this.GerarClasse(t, ref mensagemErro))
                    {
                        tabelas_erro.Add(t);
                        houveErro = true;
                    }
                }

                barra.Close();
                barra.Dispose();
                barra = null;

                if (houveErro)
                {
                    string retorno = "Houve erro nas tabelas:" + Environment.NewLine;

                    foreach (Model.MD_Tabela t in tabelas_erro)
                    {
                        retorno += t.DAO.Nome + Environment.NewLine;
                    }

                    Message.MensagemAlerta(retorno);
                }
                else
                {
                    Message.MensagemSucesso("As classes foram geradas no diretórios: " + Util.Global.app_classes_directory + "!");
                }
            }
        }

        /// <summary>
        /// Método que gera a classe da tabela passada por parâmetro
        /// </summary>
        /// <param name="tabela">Tabela a se gerar a classe</param>
        /// <param name="mensagem">mensagem caso tenha erro</param>
        /// <returns>True - sucesso; False - erro</returns>
        public bool GerarClasse(Model.MD_Tabela tabela, ref string mensagem)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.GerarClasse()", Util.Global.TipoLog.DETALHADO);

            DAO.MDN_Table table = Regras.ClassCreater.MontaTable(tabela);
            return Regras.ClassCreater.Create(table, ref mensagem);
        }

        /// <summary>
        /// Método que gera os scripts de banco
        /// </summary>
        /// <param name="projeto">Projeto para capturar as tabelas</param>
        public void GerarScriptBD(Model.MD_Projeto projeto, Model.MD_Tabela tabela)
        {
            FO_GerarScripts form = new FO_GerarScripts(projeto, tabela);
            form.Show();
        }

        /// <summary>
        /// Método que gera os scripts de banco
        /// </summary>
        /// <param name="projeto">Projeto para capturar as tabelas</param>
        public void GerarScriptBD(Model.MD_Projeto projeto)
        {
            FO_GerarScripts form = new FO_GerarScripts(projeto);
            form.Show();
        }

        /// <summary>
        /// Método que gera o relatório do módulo
        /// </summary>
        /// <param name="modulo"></param>
        public bool GerarRelatorioModulo(Model.MD_Projeto projeto)
        {
            if (projeto == null)
            {
                return false;
            }

            return Regras.ModuloRelatorio.Criar(projeto);
        }

        /// <summary>
        /// Método que gera o relatório do módulo
        /// </summary>
        /// <param name="modulo"></param>
        public bool GerarRelatorioTeste(Model.MD_Projeto projeto)
        {
            if (projeto == null)
            {
                return false;
            }

            return Regras.TesteRelatorio.Criar(projeto);
        }

        /// <summary>
        /// Método que gera o relatório do módulo
        /// </summary>
        /// <param name="modulo"></param>
        public bool GerarRelatorioTeste(Model.MD_Teste teste)
        {
            if (teste == null)
            {
                return false;
            }

            return Regras.TesteRelatorio.Criar(teste);
        }

        /// <summary>
        /// Método que gera o relatório do módulo
        /// </summary>
        /// <param name="modulo"></param>
        public bool GerarRelatorioModulo(Model.MD_Modulos modulo)
        {
            if(modulo == null)
            {
                return false;
            }

            return Regras.ModuloRelatorio.Criar(modulo);
        }

        /// <summary>
        /// Método que gera o relatório do projeto selecionado
        /// </summary>
        private void GerarDocumentoDER(Model.MD_Projeto projetoCorrente)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.GerarDocumentoDER()", Util.Global.TipoLog.DETALHADO);

            if (Regras.Document.Gerar(projetoCorrente))
            {
                Message.MensagemSucesso("Gerado com sucesso!");

                if (Message.MensagemConfirmaçãoYesNo("Deseja abrir o DER no Navegador?") == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(Util.Global.app_DER_file_Table);
                }
                else
                {
                    Visao.UC_WEB web = new Visao.UC_WEB(Util.Global.app_DER_file_Table);
                    this.AbreJanela(web, "DER - " + projetoCorrente.DAO.Nome, Util.Enumerator.Telas.CADASTRO_RELATORIO);
                }
            }
            else
            {
                Message.MensagemErro("Houve erro ao gerar o relatório!");
            }
        }

        /// <summary>
        /// Método que abre o diretório para copiar os arquivos
        /// </summary>
        private void AbrirTelaSelecaoDestinoDirectoryArquivos(Util.Enumerator.ArquivosGerados arquivosGerados)
        {
            Util.CL_Files.WriteOnTheLog("FO_Principal.AbrirTelaSelecaoDestinoDirectoryArquivos()", Util.Global.TipoLog.DETALHADO);

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Selecionar o diretório de saída dos arquivos";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string caminhoSaida = string.Empty;
                caminhoSaida = dialog.SelectedPath.ToString();
                DirectoryInfo info = new DirectoryInfo(caminhoSaida);

                if (Regras.UtilHelper.GerarArquivos(arquivosGerados, info))
                {
                    Message.MensagemSucesso("Arquivos gerados com sucesso no diretório: " + info.FullName);
                }
                else
                {
                    Message.MensagemErro("Erro ao gerar os arquivos");
                }
            }
        }


        #endregion Métodos

    }
}
