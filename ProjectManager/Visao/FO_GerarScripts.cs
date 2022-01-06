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
    public partial class FO_GerarScripts : Form
    {
        #region Atributos e Propriedades

        /// <summary>
        /// Projeto do formulário
        /// </summary>
        Model.MD_Projeto projeto = null;

        /// <summary>
        /// tabela do formulario
        /// </summary>
        Model.MD_Tabela tabela = null;


        #endregion Atributos e Propriedades


        #region Eventos

        /// <summary>
        /// Evento lançado no clique do botão de informação sobre o diretório de saída
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_diretorio_Click(object sender, EventArgs e)
        {
            Visao.Message.MensagemInformacao("Diretório onde será salvo o(s) arquivo(s)");
        }

        /// <summary>
        /// Evento lançado no clique do botão de informações sobre o tipo de banco
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_tipoBanco_Click(object sender, EventArgs e)
        {
            Visao.Message.MensagemInformacao("Tipo de banco para criação do script");
        }

        /// <summary>
        /// Evento lançado no clique do botão de informação sobre o arquivo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_gerarArquivo_Click(object sender, EventArgs e)
        {
            Visao.Message.MensagemInformacao("Se selecionado será criado um arquivo para cada tabela do projeto. Se não for selcionado será criado apenas um arquivo com todos os comandos de criação");
        }

        /// <summary>
        /// Evento disparado no clique do botão folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_selecionaFolder_Click(object sender, EventArgs e)
        {
            this.OpenDirectoryFile();
        }

        /// <summary>
        /// Evento lançado no clique do botão ok
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
        /// <param name="projeto">Projeto para pegar as tabelas</param>
        public FO_GerarScripts(Model.MD_Projeto projeto)
        {
            this.projeto = projeto;
            InitializeComponent();
        }

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="projeto">Projeto para pegar as tabelas</param>
        public FO_GerarScripts(Model.MD_Projeto projeto, Model.MD_Tabela tabela)
        {
            this.projeto = projeto;
            this.tabela = tabela;
            InitializeComponent();
            ckb_gerarArquivo.Checked = true;
            ckb_gerarArquivo.Visible = this.btn_info_gerarArquivo.Visible = false;
        }

        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Método que abre diálogo para seleção do caminho das imagens
        /// </summary>
        private void OpenDirectoryFile()
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Selecione a pasta para salvar o arquivo";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.tbx_caminhoSaida.Text = dialog.SelectedPath.ToString();
            }
        }

        /// <summary>
        /// Método que valida se o formulário foi preenchido corretamente
        /// </summary>
        /// <returns></returns>
        private bool ValidaFormulario()
        {
            bool retorno = true;

            if(this.cmb_Tipobanco.SelectedIndex < 0)
            {
                Visao.Message.MensagemAlerta("Selecionar o tipo de banco");
                this.cmb_Tipobanco.Focus();
                retorno = false;
            }

            return retorno;
        }

        /// <summary>
        /// Método que confirma o formulário de criação
        /// </summary>
        private void Confirmar()
        {
            if (ValidaFormulario())
            {
                string diretorio = this.tbx_caminhoSaida.Text;
                Util.Enumerator.BancoDados type = this.cmb_Tipobanco.SelectedIndex == 0 ? Util.Enumerator.BancoDados.SQLite : Util.Enumerator.BancoDados.SQL_SERVER;
                bool gerarArquivos = ckb_gerarArquivo.Checked;

                if (string.IsNullOrEmpty(diretorio))
                {
                    diretorio = Util.Global.app_Script_directory;
                }

                bool worked = this.tabela == null ? Regras.ScriptBanco.CriarScript(projeto, type, !gerarArquivos, diretorio) : Regras.ScriptBanco.CriarScript(this.ListaTabelas(), type, !gerarArquivos, diretorio);
                if (worked)
                {
                    Visao.Message.MensagemSucesso(gerarArquivos ? "Os arquivos com os comandos foram criados com sucesso no diretório: " + diretorio : "O arquivo com os comandos foi criado na pasta " + diretorio);
                }
                else
                {
                    Visao.Message.MensagemErro("Erro ao gerar os arquivos");
                }
            }
        }

        /// <summary>
        /// Método que retorna a lista de tabelas
        /// </summary>
        /// <returns>Lista com as tabelas</returns>
        private List<Model.MD_Tabela> ListaTabelas()
        {
            List<Model.MD_Tabela> tabelas = new List<Model.MD_Tabela>();
            tabelas.Add(this.tabela);
            return tabelas;
        }

        #endregion Métodos

    }
}
