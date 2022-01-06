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
    public partial class Principal : Form
    {
        #region Atributos e Propriedades

        #endregion Atributos e Propriedades

        #region Eventos

        /// <summary>
        /// Evento acionado no clique do botão de informação do servidor SQLIte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_infoDatabaseSLIte_Click(object sender, EventArgs e)
        {
            Message.MensagemInformacao("Banco a ser conectado a ser conectado!");
        }

        /// <summary>
        /// Evento acionado no clique do botão de informação do servidor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_servidorSqlServer_Click(object sender, EventArgs e)
        {
            Message.MensagemInformacao("Servidor a ser conectado!");
        }

        /// <summary>
        /// Evento acionado no clique do botão de informação da DataBase
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_DataBaseSqlServer_Click(object sender, EventArgs e)
        {
            Message.MensagemInformacao("Database a ser conectado!");
        }

        /// <summary>
        /// Evento acionado no clique do botão de informação do Usuário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_Usuario_SqlServer_Click(object sender, EventArgs e)
        {
            Message.MensagemInformacao("Usuário do banco de dados!");
        }

        /// <summary>
        /// Evento acionado no clique do botão de informação da senha
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_SenhaSqlServer_Click(object sender, EventArgs e)
        {
            Message.MensagemInformacao("Senha do banco de dados!");
        }

        /// <summary>
        /// Evento lançado no botão importar 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            this.ImportarSQLServer();
        }

        /// <summary>
        /// Evento lançado no botão importar SQLIte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_importarSQLIte_Click(object sender, EventArgs e)
        {
            this.ImportarSQLite();
        }

        /// <summary>
        /// Evento lançado no clque do botão de seleção de arquivos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_selectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog_f = new OpenFileDialog();
            dialog_f.Title = "Seleção do banco para alteração!";

            if (dialog_f.ShowDialog() == DialogResult.OK)
            {
                this.tbx_dataBaseSQLIte.Text = dialog_f.FileName.ToString();
            }
        }

        #endregion Eventos

        #region Construtores

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        public Principal()
        {
            this.InitializeComponent();
            this.InicializaForm();
        }

        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Método que inicializa o formulário
        /// </summary>
        private void InicializaForm()
        {

        }

        /// <summary>
        /// Método que valida os campos do formulário
        /// </summary>
        /// <returns>True - validado; false - errado</returns>
        private bool ValidaCamposSQLServer()
        {
            bool retorno = true;

            if (string.IsNullOrEmpty(this.tbx_servidorSqlServer.Text))
            {
                retorno = false;
                Message.MensagemAlerta("Campo servidor está vazio!");
                this.tbx_servidorSqlServer.Focus();
            }
            else if (string.IsNullOrEmpty(this.tbx_dataBaseSqlServer.Text))
            {
                retorno = false;
                Message.MensagemAlerta("Campo DataBase está vazio!");
                this.tbx_dataBaseSqlServer.Focus();
            }
            else if (string.IsNullOrEmpty(this.tbx_usuarioSQLServer.Text))
            {
                retorno = false;
                Message.MensagemAlerta("Campo usuário está vazio!");
                this.tbx_usuarioSQLServer.Focus();
            }
            else if (string.IsNullOrEmpty(this.tbx_senhaSqlServer.Text))
            {
                retorno = false;
                Message.MensagemAlerta("Campo senha está vazio!");
                this.tbx_senhaSqlServer.Focus();
            }

            return retorno;
        }

        /// <summary>
        /// Método que valida os campos do formulário
        /// </summary>
        /// <returns>True - validado; false - errado</returns>
        private bool ValidaCamposSQLite()
        {
            bool retorno = true;

            if (string.IsNullOrEmpty(this.tbx_dataBaseSQLIte.Text))
            {
                retorno = false;
                MessageBox.Show("Campo database está vazio!", "Alerta");
                this.tbx_servidorSqlServer.Focus();
            }

            return retorno;
        }

        /// <summary>
        /// Método que faz a importação das tabelas do banco de dados
        /// </summary>
        private void ImportarSQLServer()
        {
            if (this.ValidaCamposSQLServer())
            {
                string servidor = this.tbx_servidorSqlServer.Text;
                string database = this.tbx_dataBaseSqlServer.Text;
                string usuario = this.tbx_usuarioSQLServer.Text;
                string senha = this.tbx_senhaSqlServer.Text;

                string connection = "Data Source=" + servidor + ";User Id=" + usuario + ";Password=" + senha;

                if (DataBase.Connection.OpenConection(connection, Util.Enumerator.BancoDados.SQL_SERVER))
                {
                    if (DataBase.Connection.Execute("USE " + database))
                    {
                        if (Util.DocumentSQLServer.VerificaPermissao())
                        {
                            if (Util.DocumentSQLServer.Importar())
                            {
                                Message.MensagemSucesso("Importado com sucesso");
                            }
                            else
                            {
                                Message.MensagemErro("Não foi possível importar!");
                            }
                        }
                        else
                        {
                            Message.MensagemErro("Usuário não tem permissão no banco para buscar as tabelas!");
                        }
                    }
                    else
                    {
                        Message.MensagemErro("Não foi possível conectar na database!");
                    }
                }
                else
                {
                    Message.MensagemErro("Não foi possível conectar!");
                }
            }
        }

        /// <summary>
        /// Método que faz a importação das tabelas do banco de dados
        /// </summary>
        private void ImportarSQLite()
        {
            if (this.ValidaCamposSQLite())
            {
                string database = this.tbx_dataBaseSQLIte.Text;

                if (DataBase.Connection.OpenConection(database, Util.Enumerator.BancoDados.SQLite))
                {
                    if (Util.DocumentSQSLite.Importar())
                    {
                        Message.MensagemSucesso("Importado com sucesso!");
                    }
                    else
                    {
                        Message.MensagemSucesso("Não foi possível importar!");
                    }
                }
                else
                {
                    Message.MensagemSucesso("Não foi possível conectar!");
                }
            }
        }

        #endregion Métodos

    }
}
