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
    public partial class UC_CadastroTeste : UserControl
    {
        #region Atributos e Propriedades

        /// <summary>
        /// Teste corrente
        /// </summary>
        Model.MD_Teste testeCorrente = null;

        /// <summary>
        /// Projeto corrente
        /// </summary>
        Model.MD_Projeto projetoCorrente = null;

        /// <summary>
        /// Constrole do que está sendo efetuado na tela
        /// </summary>
        Util.Enumerator.Tarefa tarefa = Util.Enumerator.Tarefa.INCLUINDO;

        /// <summary>
        /// Controle da tela principal
        /// </summary>
        FO_Principal principal = null;

        /// <summary>
        /// Lista dos testes efetuados
        /// </summary>
        List<Model.MD_Tabelatestes> testesLista = new List<Model.MD_Tabelatestes>();

        #endregion Atributos e Propriedades

        #region Eventos

        /// <summary>
        /// Evento disparado no clique do botão de fechar a tela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.principal.FecharTela(Util.Enumerator.Telas.CADASTRO_TESTES);
        }

        /// <summary>
        /// Evento lançado no clique do botão de informação sobre a descrição
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_infoDescricao_Click(object sender, EventArgs e)
        {
            Message.MensagemInformacao("Descrição geral do teste a ser feito.");
        }


        /// <summary>
        /// Evento lançado no clique da opção de informação das notas do teste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_notas_Click(object sender, EventArgs e)
        {
            Message.MensagemInformacao("Descrição geral do teste a ser feito.");
        }


        /// <summary>
        /// Evento disparado no cliqeu da opção de informações do módulo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_modulo_Click(object sender, EventArgs e)
        {
            Message.MensagemInformacao("Módulo que o teste está sendo feito.");
        }

        /// <summary>
        /// Evento disparado no clique do botão de informação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_gridTabelas_Click(object sender, EventArgs e)
        {
            Message.MensagemInformacao("Tabela com os campos envolvidos no módulo selecionado");
        }

        /// <summary>
        /// Evento disparado no clique do botão incluir teste no grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_adicionarTeste_Click(object sender, EventArgs e)
        {
            this.AdicionarVinculo();
        }

        /// <summary>
        /// Evento disparado no clique de remover vínculo ao lado do grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_removerTeste_Click(object sender, EventArgs e)
        {
            this.RemoverVinculo();
        }

        /// <summary>
        /// Evento disparado no clique do botão confirmar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            this.Confirmar();
        }

        /// <summary>
        /// Evento disparado no clique do botão excluir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            this.Excluir();
        }

        /// <summary>
        /// Método que gera o relatório de teste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_gerar_document_Click(object sender, EventArgs e)
        {
            this.principal.GerarRelatorioTeste(this.testeCorrente);

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
        private void btn_copiar_notas_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.tbx_notas.Text);
        }

        #endregion Eventos

        #region Construtores

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="teste">Classe de modelo</param>
        /// <param name="tarefa">Tarefa que está sendo executada na tela</param>
        /// <param name="principal">Tela principal do sistema</param>
        public UC_CadastroTeste(Model.MD_Teste teste, Util.Enumerator.Tarefa tarefa, FO_Principal principal, Model.MD_Projeto projeto)
        {
            this.testeCorrente = teste;
            this.tarefa = tarefa;
            this.principal = principal;
            this.projetoCorrente = projeto;
            this.InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.IniciaForm();
        }

        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Método que inicia o formulário
        /// </summary>
        private void IniciaForm()
        {
            if (tarefa == Util.Enumerator.Tarefa.EDITANDO || tarefa == Util.Enumerator.Tarefa.INCLUINDO)
            {
                this.tbx_descricao.Enabled = true;
                this.tbx_notas.Enabled = true;
                this.cmb_modulos.Enabled = true;
                this.btn_adicionarTeste.Enabled = true;
                this.btn_removerTeste.Enabled = true;
            }
            else
            {
                this.tbx_descricao.Enabled = false;
                this.tbx_notas.Enabled = false;
                this.cmb_modulos.Enabled = false;
                this.btn_adicionarTeste.Enabled = false;
                this.btn_removerTeste.Enabled = false;
            }

            if (tarefa != Util.Enumerator.Tarefa.INCLUINDO)
            {
                PreencheListaTestes();
                PreencheFormulario();
            }

            this.FillGrid();
            this.PreencheCombo();
            this.TrataBotoes();
        }

        /// <summary>
        /// Método que trata a nomenclatura dos botões
        /// </summary>
        private void TrataBotoes()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroTeste.TrataBotoes()", Util.Global.TipoLog.DETALHADO);

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
        /// Método que preenche o combo de módulos
        /// </summary>
        private void PreencheCombo()
        {
            string sentenca = new DAO.MD_Modulos().table.CreateCommandSQLTable() + " WHERE CODIGOPROJETO = " + this.projetoCorrente.DAO.Codigo;

            DataTable table = new DataTable();
            table.Load(DataBase.Connection.Select(sentenca));
            this.cmb_modulos.DataSource = table.DefaultView;

            this.cmb_modulos.DisplayMember = "NOMEMODULO";
            this.cmb_modulos.ValueMember = "CODIGO";

            if (table.Rows.Count > 0)
                this.cmb_modulos.SelectedIndex = 0;
        }

        /// <summary>
        /// Método que preenche a lista de testes
        /// </summary>
        private void PreencheListaTestes()
        {
            this.testesLista = testeCorrente.RetornaListaTestes();
        }

        /// <summary>
        /// Método que preenche o grid de testes
        /// </summary>
        private void FillGrid()
        {
            this.dgv_testes.Rows.Clear();
            this.dgv_testes.Columns.Clear();

            this.dgv_testes.Columns.Add("Descrição", "Descrição");
            this.dgv_testes.Columns.Add("Notas", "Notas");
            this.dgv_testes.Columns.Add("Status", "Status");

            foreach(Model.MD_Tabelatestes teste in this.testesLista)
            {
                FillGrid(teste);
            }


            foreach (DataGridViewColumn o in this.dgv_testes.Columns)
            {
                o.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        /// <summary>
        /// Método que preenche o grid com o campo
        /// </summary>
        /// <param name="teste">Teste a ser preenchido</param>
        private void FillGrid(Model.MD_Tabelatestes teste)
        {
            List<Object> lista = new List<object>();
            lista.Add(teste.DAO.Descricao);
            lista.Add(teste.DAO.Notas);
            lista.Add(teste.DAO.Status == "1" ? "Sucesso" : "Erro");

            this.dgv_testes.Rows.Add(lista.ToArray()); 
        }

        /// <summary>
        /// Método que adiciona tabela para vincular ao módulo
        /// </summary>
        private void AdicionarVinculo()
        {
            List<string> campos = new List<string>();
            campos.Add("DESCRICAO");
            campos.Add("NOTAS");
            campos.Add("STATUS");

            DAO.MDN_Table.CreateTempTable(campos);

            Visao.FO_AdicionarTeste vincular = new FO_AdicionarTeste();
            if (vincular.ShowDialog() == DialogResult.OK)
            {
                DbDataReader reader = DAO.MDN_Table.LerTabelaTemporaria(campos);

                while (reader.Read())
                {
                    Model.MD_Tabelatestes teste = new Model.MD_Tabelatestes(DataBase.Connection.GetIncrement(new DAO.MD_Tabelatestes().table.Table_Name));
                    teste.DAO.Descricao = reader["DESCRICAO"].ToString();
                    teste.DAO.Notas = reader["NOTAS"].ToString();
                    teste.DAO.Status = reader["STATUS"].ToString();

                    this.testesLista.Add(teste);
                    FillGrid(teste);
                }
            }

            DAO.MDN_Table.CreateTempTable(campos);
        }

        /// <summary>
        /// Método que remove o vínculo do campo com o módulo
        /// </summary>
        private void RemoverVinculo()
        {
            if (this.dgv_testes.SelectedRows.Count <= 0)
            {
                Message.MensagemAlerta("Selecione um dado no grid!");
            }
            else
            {
                this.testesLista.RemoveAt(this.dgv_testes.SelectedRows[0].Index);
                this.FillGrid();
            }
        }

        /// <summary>
        /// Método que preenche o formulário
        /// </summary>
        private void PreencheFormulario()
        {
            this.tbx_descricao.Text = this.testeCorrente.DAO.Descricao;
            this.tbx_notas.Text = this.testeCorrente.DAO.Descricao;
            this.cmb_modulos.SelectedValue = this.testeCorrente.DAO.Codigomodulo;
        }

        /// <summary>
        /// Método que valida se os campos obrigatórios foram preenchidos
        /// </summary>
        /// <returns>True - válidos; False - inválidos</returns>
        private bool ValidaCampos()
        {
            bool retorno = true;

            if (string.IsNullOrEmpty(this.tbx_descricao.Text))
            {
                Message.MensagemAlerta("Campo de descrição do teste vazio");
                this.tbx_descricao.Focus();
                retorno = false;
            }
            else if(this.cmb_modulos.SelectedIndex < 0)
            {
                Message.MensagemAlerta("Não foi selecionado o módulo que o teste é relacionado");
                this.cmb_modulos.Focus();
                retorno = false;
            }

            return retorno;
        }

        /// <summary>
        /// Método que confirma o formulário
        /// </summary>
        private void Confirmar()
        {
            if(this.tarefa == Util.Enumerator.Tarefa.VISUALIZANDO)
            {
                this.tarefa = Util.Enumerator.Tarefa.EDITANDO;
                this.IniciaForm();
            }
            else if (this.ValidaCampos())
            {
                if(testeCorrente == null)
                {
                    testeCorrente = new Model.MD_Teste(DataBase.Connection.GetIncrement(new DAO.MD_Testes().table.Table_Name), this.projetoCorrente);
                }
                else if (testeCorrente.DAO.Empty)
                {
                    testeCorrente = new Model.MD_Teste(DataBase.Connection.GetIncrement(new DAO.MD_Testes().table.Table_Name), this.projetoCorrente);
                }

                PreencheClasse();

                bool retorno = false;
                if (this.tarefa == Util.Enumerator.Tarefa.INCLUINDO)
                {
                    retorno = testeCorrente.DAO.Insert();
                }
                else
                {
                    retorno = testeCorrente.DAO.Update();
                }
                this.InserirTestes();

                if (retorno)
                {
                    Message.MensagemSucesso((tarefa == Util.Enumerator.Tarefa.INCLUINDO ? "Incluído" : "Alterado") + " com sucesso!");
                    this.tarefa = Util.Enumerator.Tarefa.VISUALIZANDO;
                    this.IniciaForm();
                    this.principal.CarregaTreeViewAutomaticamente();
                }
                else
                {
                    Message.MensagemErro("Erro ao cadastrar");
                }
            }
        }

        /// <summary>
        /// Método que insere os testes
        /// </summary>
        private void InserirTestes()
        {
            this.testeCorrente.ApagarVinculos();

            foreach(Model.MD_Tabelatestes teste in testesLista)
            {
                teste.DAO.Codigoteste = this.testeCorrente.DAO.Codigo;
                teste.DAO.Insert();
            }
        }

        /// <summary>
        /// Método que preenche a classe
        /// </summary>
        private void PreencheClasse()
        {
            this.testeCorrente.DAO.Codigomodulo = int.Parse(this.cmb_modulos.SelectedValue.ToString());
            this.testeCorrente.DAO.Descricao = this.tbx_descricao.Text;
            this.testeCorrente.DAO.Notas = this.tbx_notas.Text;
            this.testeCorrente.DAO.Datateste = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
        }

        /// <summary>
        /// Método que exclui o objeto
        /// </summary>
        private void Excluir()
        {
            if(this.tarefa == Util.Enumerator.Tarefa.VISUALIZANDO)
            {
                foreach (Model.MD_Tabelatestes teste in this.testesLista)
                {
                    teste.DAO.Delete();
                }

                if (this.testeCorrente.DAO.Delete())
                {
                    Message.MensagemSucesso("Excluído com sucesso!");
                    this.principal.CarregaTreeViewAutomaticamente();
                }
                else
                {
                    Message.MensagemErro("Erro ao excluir");
                }
            }
            else
            {
                if(this.tarefa == Util.Enumerator.Tarefa.EDITANDO)
                {
                    this.tarefa = Util.Enumerator.Tarefa.VISUALIZANDO;
                    this.IniciaForm();
                }
                else
                {
                    principal.FecharTela(Util.Enumerator.Telas.CADASTRO_TESTES);
                }
            }
        }

        #endregion Métodos
        
    }
}
