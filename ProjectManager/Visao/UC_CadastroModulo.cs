using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;

namespace Visao
{
    public partial class UC_CadastroModulo : UserControl
    {

        #region Atributos

        /// <summary>
        /// Constrolador da tarefa que a tela está executando
        /// </summary>
        Util.Enumerator.Tarefa tarefa = Util.Enumerator.Tarefa.INCLUINDO;

        /// <summary>
        /// Controle do modulo da tela
        /// </summary>
        Model.MD_Modulos moduloCorrente = null;

        /// <summary>
        /// Projeto que está selecionado
        /// </summary>
        Model.MD_Projeto projeto = null;

        /// <summary>
        /// Controle da classe da tela principal
        /// </summary>
        FO_Principal principal;

        /// <summary>
        /// Campos selecionados no grid
        /// </summary>
        List<Model.MD_Campos> campos = new List<Model.MD_Campos>();

        #endregion Atributos

        #region Eventos

        /// <summary>
        /// Evento disparado no clique do botão de fechar a tela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.principal.FecharTela(Util.Enumerator.Telas.CADASTRO_MODULO);
        }

        /// <summary>
        /// Evento lançado no clique do botão de adicionar vínculo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_adicionarVinculo_Click(object sender, EventArgs e)
        {
            this.AdicionarVinculo();
        }

        /// <summary>
        /// Evento lançado no clique de informação do grid de tabelas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_gridTabelas_Click(object sender, EventArgs e)
        {
            Message.MensagemInformacao("Tabelas que são utilizadas pelo módulo");
        }

        /// <summary>
        /// Evento lançado no clique do botão de informação do Passo a Passo do Módulo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_PassoPasso_Click(object sender, EventArgs e)
        {
            Message.MensagemInformacao("Passo a passo a ser seguido para ter acesso ao módulo. Afim de cadastro deve colocar os passos separados por ';'.");
        }

        /// <summary>
        /// Evento lançado no clique do botão de informação da descrição do Módulo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_infoDescriçãoProjeto_Click(object sender, EventArgs e)
        {
            Message.MensagemInformacao("Nome do projeto");
        }

        /// <summary>
        /// Evento lançado no clique do botão de informações sobre o nome do módulo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_tarefa_Click(object sender, EventArgs e)
        {
            Message.MensagemInformacao("Nome do módulo");
        }

        /// <summary>
        /// Evento lançado no clique do botão confirmar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroProjeto.btn_confirmar_Click()", Util.Global.TipoLog.DETALHADO);

            if (tarefa == Util.Enumerator.Tarefa.VISUALIZANDO)
            {
                this.tarefa = Util.Enumerator.Tarefa.EDITANDO;
                this.IniciaForm();
            }
            else
            {
                this.Incluir();
            }
        }

        /// <summary>
        /// Evento disparado no clique do botão de remover ao lado do grid de tabelas de vínculo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_removerVinculo_Click(object sender, EventArgs e)
        {
            this.RemoverVinculo();
        }

        /// <summary>
        /// Evento lançado no clique do botão excluir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroModulo.btn_excluir_Click()", Util.Global.TipoLog.DETALHADO);

            this.Excluir();
        }

        /// <summary>
        /// Evento lançado no clique do botão Gerar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_gerar_document_Click(object sender, EventArgs e)
        {
            GerarRelatorio();
        }

        /// <summary>
        /// Evento lançado no clique do botão copiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_copiar_nome_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.tbx_nomeModulo.Text);
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
        private void btn_copiar_passoPasso_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.tbx_passoPasso.Text);
        }

        #endregion

        #region Construtores

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="tarefa">O que está sendo feito na tela</param>
        /// <param name="modulo">Módulo a ser controlado</param>
        /// <param name="principal">Controle da tela principal</param>
        public UC_CadastroModulo(Util.Enumerator.Tarefa tarefa, Model.MD_Projeto projeto, Model.MD_Modulos modulo, FO_Principal principal)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroModulo.UC_CadastroModulo()", Util.Global.TipoLog.DETALHADO);

            this.moduloCorrente = modulo;
            this.principal = principal;
            this.tarefa = tarefa;
            this.projeto = projeto;

            if (!modulo.DAO.Empty)
            {
                foreach(Model.MD_Campos campo in this.moduloCorrente.Campos())
                {
                    this.campos.Add(campo);
                }
            }

            this.Dock = DockStyle.Fill;
            this.InitializeComponent();
            this.IniciaForm();
        }

        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Método que inicializa o formulário
        /// </summary>
        public void IniciaForm()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroModulo.IniciaForm()", Util.Global.TipoLog.DETALHADO);

            if (this.tarefa == Util.Enumerator.Tarefa.EDITANDO || this.tarefa == Util.Enumerator.Tarefa.INCLUINDO)
            {
                tbx_descricao.Text = tbx_nomeModulo.Text = tbx_passoPasso.Text = string.Empty;
                tbx_descricao.Enabled = tbx_nomeModulo.Enabled = tbx_passoPasso.Enabled = dgv_tabelasVinculadas.Enabled = btn_adicionarVinculo.Enabled = btn_removerVinculo.Enabled = true;
            }
            else if(this.tarefa == Util.Enumerator.Tarefa.VISUALIZANDO)
            {
                tbx_descricao.Text = tbx_nomeModulo.Text = tbx_passoPasso.Text = string.Empty;
                tbx_descricao.Enabled = tbx_nomeModulo.Enabled = tbx_passoPasso.Enabled = dgv_tabelasVinculadas.Enabled = btn_adicionarVinculo.Enabled = btn_removerVinculo.Enabled = false;
            }

            if (!this.moduloCorrente.DAO.Empty && this.tarefa != Util.Enumerator.Tarefa.INCLUINDO)
            {
                this.PreencheFormulario();
            }

            this.PreencheCampos();
            this.FillGrid();
            this.TrataBotoes();
        }

        /// <summary>
        /// Método que trata a nomenclatura dos botões
        /// </summary>
        private void TrataBotoes()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroModulo.TrataBotoes()", Util.Global.TipoLog.DETALHADO);

            if (tarefa == Util.Enumerator.Tarefa.VISUALIZANDO)
            {
                this.btn_confirmar.Enabled = true;
                this.btn_confirmar.Text = "Editar";
                this.btn_gerar_document.Enabled = true;
                this.btn_excluir.Text = "Excluir";
            }
            else
            {
                this.btn_confirmar.Enabled = true;
                this.btn_gerar_document.Enabled = false;
                this.btn_excluir.Text = "Cancelar";
                this.btn_confirmar.Text = tarefa == Util.Enumerator.Tarefa.EDITANDO ? "Alterar" : "Cadastrar";
            }
        }

        /// <summary>
        /// Método que preenche a lista de campos associados ao módulo
        /// </summary>
        private void PreencheCampos()
        {
            this.campos = new List<Model.MD_Campos>();
            this.campos = moduloCorrente.Campos();
        }

        /// <summary>
        /// Método que preenche o formulário
        /// </summary>
        private void PreencheFormulario()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroModulo.PreencheFormulario()", Util.Global.TipoLog.DETALHADO);

            this.tbx_nomeModulo.Text = this.moduloCorrente.DAO.NomeModulo;
            this.tbx_descricao.Text = this.moduloCorrente.DAO.Descricao;
            this.tbx_passoPasso.Text = this.moduloCorrente.DAO.SequenciaAbertura;
        }

        /// <summary>
        /// Método que preenche o grid view
        /// </summary>
        private void FillGrid()
        {
            this.dgv_tabelasVinculadas.ClearSelection();
            this.dgv_tabelasVinculadas.Rows.Clear();
            this.dgv_tabelasVinculadas.Columns.Clear();

            this.dgv_tabelasVinculadas.Columns.Add("Tabela", "Tabela");
            this.dgv_tabelasVinculadas.Columns.Add("Coluna", "Coluna");

            foreach (Model.MD_Campos campo in this.campos)
            {
                FillGrid(campo);
            }

            foreach(DataGridViewColumn o in this.dgv_tabelasVinculadas.Columns)
            {
                o.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        /// <summary>
        /// Método que preenche o grid view
        /// </summary>
        private void FillGrid(Model.MD_Campos campo)
        {
            List<Object> lista = new List<object>();
            lista.Add(campo.DAO.Tabela.Nome);
            lista.Add(campo.DAO.Nome);

            dgv_tabelasVinculadas.Rows.Add(lista.ToArray());
        }

        /// <summary>
        /// Método que adiciona tabela para vincular ao módulo
        /// </summary>
        private void AdicionarVinculo()
        {
            List<string> campos = new List<string>();
            campos.Add("CODIGOCAMPO");
            campos.Add("CODIGOTABELA");
            campos.Add("CODIGOPROJETO");

            DAO.MDN_Table.CreateTempTable(campos);

            Visao.FO_VincularTabelaModulo vincular = new FO_VincularTabelaModulo(this.moduloCorrente);
            if(vincular.ShowDialog() == DialogResult.OK)
            {
                DbDataReader reader = DAO.MDN_Table.LerTabelaTemporaria(campos);

                while (reader.Read())
                {
                    Model.MD_Campos campo = new Model.MD_Campos(int.Parse(reader["CODIGOCAMPO"].ToString()), int.Parse(reader["CODIGOTABELA"].ToString()), int.Parse(reader["CODIGOPROJETO"].ToString()));
                    this.campos.Add(campo);
                    FillGrid(campo);
                }
            }

            DAO.MDN_Table.CreateTempTable(campos);
        }

        /// <summary>
        /// Método que remove o vínculo do campo com o módulo
        /// </summary>
        private void RemoverVinculo()
        {
            if(this.dgv_tabelasVinculadas.SelectedRows.Count <= 0)
            {
                Message.MensagemAlerta("Selecione um dado no grid!");
            }
            else
            {
                this.campos.RemoveAt(this.dgv_tabelasVinculadas.SelectedRows[0].Index);
                this.FillGrid();
            }
        }

        /// <summary>
        /// Método que valida se os campos foram preenchidos corretamente
        /// </summary>
        /// <returns>Treu - correto; False - erro</returns>
        private bool ValidaCampos()
        {
            bool retorno = true;

            if (string.IsNullOrEmpty(this.tbx_nomeModulo.Text))
            {
                this.tbx_nomeModulo.Focus();
                Message.MensagemAlerta("O nome do módulo não foi preenchido");
                retorno = false;
            }
            else if (string.IsNullOrEmpty(this.tbx_descricao.Text))
            {
                this.tbx_descricao.Focus();
                Message.MensagemAlerta("A descrição do módulo não foi preenchido");
                retorno = false;
            }

            return retorno;
        }

        /// <summary>
        /// Método que preenche o módulo a partir do formulário
        /// </summary>
        /// <param name="mod"></param>
        private void InstanciaDados(ref Model.MD_Modulos mod)
        {
            mod.DAO.NomeModulo = this.tbx_nomeModulo.Text;
            mod.DAO.Descricao = this.tbx_descricao.Text;
            mod.DAO.SequenciaAbertura = this.tbx_passoPasso.Text;
        }

        /// <summary>
        /// Método que faz a inclusão do módulo
        /// </summary>
        private void Incluir()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroModulo.Incluir()", Util.Global.TipoLog.DETALHADO);
            if (this.ValidaCampos())
            {
                DAO.MD_Modulos mod = new DAO.MD_Modulos();

                Model.MD_Modulos modulo = this.tarefa == Util.Enumerator.Tarefa.INCLUINDO ? 
                    new Model.MD_Modulos(DataBase.Connection.GetIncrement(mod.table.Table_Name), this.projeto.DAO.Codigo) : 
                    this.moduloCorrente;

                bool retorno = true;
                this.InstanciaDados(ref modulo);
                modulo.DAO.Codigoprojeto = this.projeto.DAO.Codigo;

                if(this.tarefa == Util.Enumerator.Tarefa.INCLUINDO)
                {
                    retorno = modulo.DAO.Insert();
                }
                else
                {
                    retorno = modulo.DAO.Update();
                }
                this.moduloCorrente = modulo;
                this.InsereCampos();

                if (retorno)
                {
                    Message.MensagemSucesso((this.tarefa == Util.Enumerator.Tarefa.INCLUINDO ? "Incluído" : "Alterado") + " com sucesso!");
                    this.tarefa = Util.Enumerator.Tarefa.VISUALIZANDO;
                    this.principal.CarregaTreeViewAutomaticamente();
                    this.PreencheCampos();
                    this.FillGrid();
                    this.IniciaForm();
                }
                else
                {
                    Message.MensagemErro("Erro ao " + (this.tarefa == Util.Enumerator.Tarefa.VISUALIZANDO ? "incluir" : "alterar"));
                }
            }
        }

        /// <summary>
        /// Método que insere os campos vinculados ao módulo corrente
        /// </summary>
        private void InsereCampos()
        {
            Model.MD_TabelasModulos.ExcluiRelacoes(this.moduloCorrente.DAO.Codigo);

            foreach (Model.MD_Campos campo in this.campos)
            {
                Model.MD_TabelasModulos table = new Model.MD_TabelasModulos(campo.DAO.Tabela.Codigo, campo.DAO.Codigo, moduloCorrente.DAO.Codigo);
                table.DAO.Insert();
            }
        }

        /// <summary>
        /// Método que faz a exclusão do projeto
        /// </summary>
        private void Excluir()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroModulo.Excluir()", Util.Global.TipoLog.DETALHADO);

            if (tarefa == Util.Enumerator.Tarefa.VISUALIZANDO)
            {
                if(Message.MensagemConfirmaçãoYesNo("Deseja excluir o módulo " + this.moduloCorrente.DAO.NomeModulo + "?") == DialogResult.Yes)
                {
                    this.Exclui();
                }
            }
            else if (tarefa == Util.Enumerator.Tarefa.EDITANDO)
            {
                this.Cancela();
            }
            else
            {
                this.principal.FecharTela(Util.Enumerator.Telas.CADASTRO_MODULO);
            }
        }

        /// <summary>
        /// Método que cancela a inclusão ou a edição do projeto
        /// </summary>
        private void Cancela()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroProjeto.Cancela()", Util.Global.TipoLog.DETALHADO);

            this.tarefa = Util.Enumerator.Tarefa.VISUALIZANDO;
            this.IniciaForm();
        }

        /// <summary>
        /// Método que exclui o projeto
        /// </summary>
        private void Exclui()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroModulo.Exclui()", Util.Global.TipoLog.DETALHADO);

            if (this.moduloCorrente.DAO.Delete())
            {
                Message.MensagemSucesso("Excluído com sucesso");
            }

            this.AtualizaPrincipal();
            this.Dispose();
        }

        /// <summary>
        /// Método que atualiza a tela com os dados principais
        /// </summary>
        private void AtualizaPrincipal()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroModulo.AtualizaPrincipal()", Util.Global.TipoLog.DETALHADO);

            this.principal.CarregaTreeViewAutomaticamente();
            principal.FecharTela(Util.Enumerator.Telas.CADASTRO_PROJETO);
        }

        /// <summary>
        /// Método que gera o relatório do módulo
        /// </summary>
        private void GerarRelatorio()
        {
            principal.GerarRelatorioModulo(this.moduloCorrente);
        }

        #endregion Métodos
        
    }
}
