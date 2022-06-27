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
    public partial class UC_Tabelas : UserControl
    {
        #region Atributos e Propriedades

        bool lockchanege = false;

        Model.MD_Projeto projeto = null;
        FO_Principal principal = null;

        List<Model.MD_Tabela> tabelas = new List<Model.MD_Tabela>();
        List<Model.MD_Campos> colunas = new List<Model.MD_Campos>();

        #endregion Atributos e Propriedades

        #region Eventos

        /// <summary>
        /// Evento lançado ao alterar a seleção no grid de tabelas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_tabelas_SelectionChanged(object sender, EventArgs e)
        {
            if (lockchanege) return;

            if(this.dgv_tabelas.SelectedRows.Count == 0)
            {
                Message.MensagemAlerta("Selecione um item no grid!");
                return;
            }

            Model.MD_Tabela tabela = this.tabelas[this.dgv_tabelas.SelectedRows[0].Index];

            this.FillGridColuna(tabela);
        }

        /// <summary>
        /// Evento lançado no clique da opção de fechar o formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.principal.FecharTela(Util.Enumerator.Telas.LISTAGEM_TABELAS);
        }

        /// <summary>
        /// Evento lançado no clique da opção de incluir campo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_incluir_campo_Click(object sender, EventArgs e)
        {
            if(this.dgv_tabelas.SelectedRows.Count == 0)
            {
                Message.MensagemAlerta("Selecione uma tabela");
                return;
            }

            Model.MD_Tabela tabela = this.tabelas[this.dgv_tabelas.SelectedRows[0].Index];
            this.principal.AbrirCadastroCampo(tabela, Util.Enumerator.Tarefa.INCLUINDO);
        }

        /// <summary>
        /// Evento lançado no clique da opção de remover campo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_remover_campo_Click(object sender, EventArgs e)
        {
            if(this.dgv_colunas.SelectedRows.Count == 0)
            {
                Message.MensagemAlerta("Selecione um item no grid");
                return;
            }

            Model.MD_Campos campo = this.colunas[this.dgv_colunas.SelectedRows[0].Index];
            if(Message.MensagemConfirmaçãoYesNo($"Realmente deseja excluir o campo {campo.DAO.Nome}?") == DialogResult.Yes)
            {
                if (campo.DAO.Delete())
                {
                    this.FillGridColuna(new Model.MD_Tabela(campo.DAO.Tabela.Codigo, projeto.DAO.Codigo));
                    Message.MensagemInformacao("Excluído com sucesso!");
                }
                else
                {
                    Message.MensagemErro("Erro ao excluir");
                }
            }
        }

        /// <summary>
        /// Evento lançado no clique da opção de editar o campo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_editar_campo_Click(object sender, EventArgs e)
        {
            if (this.dgv_tabelas.SelectedRows.Count == 0)
            {
                Message.MensagemAlerta("Selecione uma tabela");
                return;
            }
            if (this.dgv_colunas.SelectedRows.Count == 0)
            {
                Message.MensagemAlerta("Selecione um item no grid");
                return;
            }


            Model.MD_Tabela tabela = this.tabelas[this.dgv_tabelas.SelectedRows[0].Index];
            Model.MD_Campos campo = this.colunas[this.dgv_colunas.SelectedRows[0].Index];

            this.principal.AbrirCadastroCampo(tabela, Util.Enumerator.Tarefa.EDITANDO, campo);
        }

        /// <summary>
        /// Evento lançado no clique da opção de visualizar o campo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_visualizar_campo_Click(object sender, EventArgs e)
        {
            if (this.dgv_tabelas.SelectedRows.Count == 0)
            {
                Message.MensagemAlerta("Selecione uma tabela");
                return;
            }
            if (this.dgv_colunas.SelectedRows.Count == 0)
            {
                Message.MensagemAlerta("Selecione um item no grid");
                return;
            }


            Model.MD_Tabela tabela = this.tabelas[this.dgv_tabelas.SelectedRows[0].Index];
            Model.MD_Campos campo = this.colunas[this.dgv_colunas.SelectedRows[0].Index];

            this.principal.AbrirCadastroCampo(tabela, Util.Enumerator.Tarefa.VISUALIZANDO, campo);
        }

        /// <summary>
        /// Evento lançado no clique da opção de adicionar tabela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_adicionar_tabela_Click(object sender, EventArgs e)
        {
            this.principal.AbrirCadastroTabela(this.projeto, Util.Enumerator.Tarefa.INCLUINDO);
        }

        /// <summary>
        /// Evento lançado no clique da opção de remover tabela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_remover_tabela_Click(object sender, EventArgs e)
        {
            if (this.dgv_tabelas.SelectedRows.Count == 0)
            {
                Message.MensagemAlerta("Selecione um item no grid");
                return;
            }

            Model.MD_Tabela tabela = this.tabelas[this.dgv_tabelas.SelectedRows[0].Index];
            if (Message.MensagemConfirmaçãoYesNo($"Realmente deseja excluir a tabela {tabela.DAO.Nome}?") == DialogResult.Yes)
            {
                if (tabela.DAO.Delete())
                {
                    foreach(DAO.MD_Campos coluna in tabela.DAO.CamposDaTabela())
                    {
                        coluna.Delete();
                    }

                    this.FillGridTabela();
                    Message.MensagemInformacao("Excluído com sucesso!");
                }
                else
                {
                    Message.MensagemErro("Erro ao excluir");
                }
            }
        }

        /// <summary>
        /// Evento lançado no clique da opção de editar tabela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_editar_tabela_Click(object sender, EventArgs e)
        {
            if(this.dgv_tabelas.SelectedRows.Count == 0)
            {
                Message.MensagemAlerta("Selecione um item no grid");
                return;
            }

            Model.MD_Tabela tabela = this.tabelas[this.dgv_tabelas.SelectedRows[0].Index];
            this.principal.AbrirCadastroTabela(this.projeto, Util.Enumerator.Tarefa.EDITANDO, tabela);
        }

        /// <summary>
        /// Evento lançado no clique da opção de visualizar tabela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_visualizar_tabela_Click(object sender, EventArgs e)
        {
            if (this.dgv_tabelas.SelectedRows.Count == 0)
            {
                Message.MensagemAlerta("Selecione um item no grid");
                return;
            }

            Model.MD_Tabela tabela = this.tabelas[this.dgv_tabelas.SelectedRows[0].Index];
            this.principal.AbrirCadastroTabela(this.projeto, Util.Enumerator.Tarefa.VISUALIZANDO, tabela);
        }

        /// <summary>
        /// Evento lançado no clique da opção de geração de scripts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_gerarScripts_Click(object sender, EventArgs e)
        {
            if(Message.MensagemConfirmaçãoYesNo("Deseja gerar script de todas as tabelas?") == DialogResult.Yes)
            {
                this.principal.GerarScriptBD(this.projeto);
            }
            else
            {
                if (this.dgv_tabelas.SelectedRows.Count == 0)
                {
                    Message.MensagemAlerta("Selecione um item no grid");
                    return;
                }

                Model.MD_Tabela tabela = this.tabelas[this.dgv_tabelas.SelectedRows[0].Index];
                this.principal.GerarScriptBD(this.projeto, tabela);
            }
        }

        /// <summary>
        /// Evento lançado no clique da opção de gerar classes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_gerar_classes_Click(object sender, EventArgs e)
        {
            if (Message.MensagemConfirmaçãoYesNo("Deseja gerar classe de todas as tabelas?") == DialogResult.Yes)
            {
                this.principal.GerarClasses(this.projeto);
            }
            else
            {
                if (this.dgv_tabelas.SelectedRows.Count == 0)
                {
                    Message.MensagemAlerta("Selecione um item no grid");
                    return;
                }

                Model.MD_Tabela tabela = this.tabelas[this.dgv_tabelas.SelectedRows[0].Index];

                string mensagem = string.Empty;
                if(!this.principal.GerarClasse(tabela, ref mensagem))
                {
                    if (!string.IsNullOrEmpty(mensagem))
                    {
                        Message.MensagemErro(mensagem);
                    }
                }
            }
        }

        /// <summary>
        /// Evento lançado no clique da opção de recarregar as colunas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_recarregar_campos_Click(object sender, EventArgs e)
        {
            if(this.dgv_tabelas.SelectedRows.Count == 0)
            {
                Message.MensagemAlerta("Selecione uma tabela");
                return;
            }

            Model.MD_Tabela tabela = this.tabelas[this.dgv_tabelas.SelectedRows[0].Index];
            this.FillGridColuna(tabela);
        }

        /// <summary>
        /// Evento lançado no clique da opção de recarregar tabelas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_recarregar_tabelas_Click(object sender, EventArgs e)
        {
            this.FillGridTabela();
        }

        #endregion Eventos

        #region Construtores

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="projeto"></param>
        /// <param name="principal"></param>
        public UC_Tabelas(Model.MD_Projeto projeto, FO_Principal principal)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.projeto = projeto;
            this.principal = principal;

            this.grb_tabela.Text = $"Tabelas Projeto - {this.projeto.DAO.Codigo} - {this.projeto.DAO.Nome}";

            this.IniciaForm();
        }

        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Método que inica o formulário
        /// </summary>
        public void IniciaForm()
        {
            this.FillGridTabela();
        }

        /// <summary>
        /// Método que preenche as tabelas
        /// </summary>
        public void FillGridTabela()
        {
            lockchanege = true;

            this.tabelas = Model.MD_Tabela.GetTabelas(this.projeto.DAO.Codigo);
            BarraDeCarregamento barra = new BarraDeCarregamento(tabelas.Count, "Carregando tabelas");
            barra.Show();

            this.FillTabelas(this.tabelas, barra);

            barra.Dispose();
            lockchanege = false;

            if (this.dgv_tabelas.Rows.Count > 0)
                this.dgv_tabelas.Rows[0].Selected = true;
        }

        /// <summary>
        /// Método que carrega as tabelas
        /// </summary>
        /// <param name="tabelas"></param>
        private void FillTabelas(List<Model.MD_Tabela> tabelas, BarraDeCarregamento barra)
        {
            this.tabelas = tabelas;

            this.dgv_tabelas.Columns.Clear();
            this.dgv_tabelas.Rows.Clear();
            this.dgv_tabelas.MultiSelect = false;

            this.dgv_tabelas.Columns.Add("Tabela", "Tabela");
            this.dgv_tabelas.Columns.Add("Descricao", "Descricao");

            foreach (Model.MD_Tabela tabela in tabelas)
            {
                FillTabelas(tabela);
                barra.AvancaBarra(1);
            }

            for (int i = 0; i < this.dgv_tabelas.Columns.Count; i++)
            {
                this.dgv_tabelas.Columns[i].Width = 100;
                this.dgv_tabelas.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                this.dgv_tabelas.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        /// <summary>
        /// Método que preenche tabela
        /// </summary>
        /// <param name="tabela"></param>
        private void FillTabelas(Model.MD_Tabela tabela)
        {
            List<string> linhas = new List<string>();
            linhas.Add(tabela.DAO.Nome);
            linhas.Add(tabela.DAO.Descricao);

            this.dgv_tabelas.Rows.Add(linhas.ToArray());
        }

        /// <summary>
        /// Método que preenche as colunas
        /// </summary>
        /// <param name="campos"></param>
        public void FillGridColuna(Model.MD_Tabela tabela)
        {
            this.colunas = Model.MD_Campos.RetornaCamposTabela(tabela.DAO.Codigo, this.projeto.DAO.Codigo);

            BarraDeCarregamento barra = new BarraDeCarregamento(colunas.Count, "Carregando tabelas");
            barra.Show();

            this.FillColunas(this.colunas, barra);

            barra.Dispose();
        }

        /// <summary>
        /// Método que carrega as tabelas
        /// </summary>
        /// <param name="colunas"></param>
        private void FillColunas(List<Model.MD_Campos> colunas, BarraDeCarregamento barra)
        {
            this.colunas = colunas;

            this.dgv_colunas.Columns.Clear();
            this.dgv_colunas.Rows.Clear();
            this.dgv_colunas.MultiSelect = false;

            this.dgv_colunas.Columns.Add("Coluna", "Coluna");
            this.dgv_colunas.Columns.Add("Descrição", "Descrição");
            this.dgv_colunas.Columns.Add("NotNull", "NotNull");
            this.dgv_colunas.Columns.Add("PrimaryKey", "PrimaryKey");
            this.dgv_colunas.Columns.Add("Tipo", "Tipo");
            this.dgv_colunas.Columns.Add("Tamanho", "Tamanho");
            this.dgv_colunas.Columns.Add("Precisao", "Precisao");

            foreach (Model.MD_Campos campo in colunas)
            {
                FillColunas(campo);
                barra.AvancaBarra(1);
            }

            for (int i = 0; i < this.dgv_colunas.Columns.Count; i++)
            {
                this.dgv_colunas.Columns[i].Width = 100;
                this.dgv_colunas.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                this.dgv_colunas.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        /// <summary>
        /// Método que preenche tabela
        /// </summary>
        /// <param name="colunas"></param>
        private void FillColunas(Model.MD_Campos colunas)
        {
            List<string> linhas = new List<string>();
            linhas.Add(colunas.DAO.Nome);
            linhas.Add(colunas.DAO.Dominio);
            linhas.Add(colunas.DAO.NotNull ? "NotNull":"Nullable");
            linhas.Add(colunas.DAO.PrimaryKey ? "PrimaryKey": "");
            linhas.Add(colunas.DAO.TipoCampo.Nome);
            linhas.Add(colunas.DAO.Tamanho.ToString());
            linhas.Add(colunas.DAO.Precisao.ToString());

            this.dgv_colunas.Rows.Add(linhas.ToArray());
        }


        #endregion Métodos

    }
}
