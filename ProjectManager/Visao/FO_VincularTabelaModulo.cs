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
    public partial class FO_VincularTabelaModulo : Form
    {
        #region Atrigutoes e Propriedades

        /// <summary>
        /// Módulo a se adicionar as informações de relação
        /// </summary>
        Model.MD_Modulos modulo = null;

        bool lockchange = false;

        #endregion Atrigutoes e Propriedades

        #region Eventos

        /// <summary>
        /// Evento lançado no clique do botão de informação sobre a tabela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_nomeprojeto_Click(object sender, EventArgs e)
        {
            Message.MensagemInformacao("Tabela a vincular com o módulo");
        }

        /// <summary>
        /// Evento lançado no clique do botão de informação sobre o campo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Message.MensagemInformacao("Campo a vincular com o módulo");
        }

        /// <summary>
        /// Evento lançado na alteração de seleção da opção de todos os campos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ckb_todosCampos_CheckedChanged(object sender, EventArgs e)
        {
            this.ControlaCampos();
        }

        /// <summary>
        /// Evento lançado quando é selecionado outra opção no combo de tabelas 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmb_tables_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillCampos();
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
        /// <param name="modulo"></param>
        public FO_VincularTabelaModulo(Model.MD_Modulos modulo)
        {
            this.modulo = modulo;
            InitializeComponent();
            this.IniciaForm();
        }

        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Método que inicializa o formulário
        /// </summary>
        private void IniciaForm()
        {
            this.lbl_nomeModulo.Text = "Módulo - " + this.modulo.DAO.NomeModulo;
            this.FillTabelas();
        }

        /// <summary>
        /// Método que preenche o combo de tabelas
        /// </summary>
        private void FillTabelas()
        {
            lockchange = true;

            string sentenca = new DAO.MD_Tabela().table.CreateCommandSQLTable() + " WHERE Codigo NOT IN (SELECT CODIGOTABELA FROM TABELASMODULOS WHERE CODIGOMODULO = " + this.modulo.DAO.Codigo + ") AND PROJETO = " + this.modulo.DAO.Codigoprojeto;

            DataTable table = new DataTable();
            table.Load(DataBase.Connection.Select(sentenca));
            this.cmb_tables.DataSource = table.DefaultView;

            this.cmb_tables.DisplayMember = "NOME";
            this.cmb_tables.ValueMember = "CODIGO";
            lockchange = false;
            this.cmb_tables.SelectedIndex = 0;
        }

        /// <summary>
        /// Método que preenche o combo de campos
        /// </summary>
        private void FillCampos()
        {
            if (this.cmb_tables.SelectedIndex < 0 || lockchange)
                return;

            lockchange = true;

            string sentenca = new DAO.MD_Campos().table.CreateCommandSQLTable() + " WHERE Codigo NOT IN (SELECT CODIGOCAMPO FROM TABELASMODULOS WHERE CODIGOMODULO = " + this.modulo.DAO.Codigo + ") AND CODIGOTABELA = " + this.cmb_tables.SelectedValue.ToString();

            DataTable table = new DataTable();
            table.Load(DataBase.Connection.Select(sentenca));
            this.cmb_campos.DataSource = table.DefaultView;

            this.cmb_campos.DisplayMember = "NOME";
            this.cmb_campos.ValueMember = "CODIGO";
            this.cmb_campos.SelectedIndex = 0;

            lockchange = false; 
        }

        /// <summary>
        /// Método que controla a apresentação dos campos
        /// </summary>
        private void ControlaCampos()
        {
            this.cmb_campos.Enabled = this.lbl_campos.Enabled = !this.ckb_todosCampos.Checked;
        }

        /// <summary>
        /// Método que valida os campos
        /// </summary>
        /// <returns>True - válidos; False - inválidos</returns>
        private bool ValidaCampos()
        {
            bool retorno = true;

            if (this.cmb_tables.SelectedIndex < 0)
            {
                this.cmb_tables.Focus();
                Message.MensagemAlerta("Deve ser selecionado uma tabela");
                retorno = false;
            }
            else if (this.cmb_campos.SelectedIndex < 0 && !this.ckb_todosCampos.Checked)
            {
                this.cmb_campos.Focus();
                Message.MensagemAlerta("Deve ser selecionado uma tabela");
                retorno = false;
            }

            return retorno;
        }

        /// <summary>
        /// Método que confirma o formulário
        /// </summary>
        private void Confirmar()
        {
            if (ValidaCampos())
            {
                Model.MD_Tabela tabela = new Model.MD_Tabela(int.Parse(this.cmb_tables.SelectedValue.ToString()), this.modulo.DAO.Codigoprojeto);
                List<Model.MD_Campos> campos = new List<Model.MD_Campos>();

                if (!this.ckb_todosCampos.Checked)
                {
                    Model.MD_Campos campo = new Model.MD_Campos(int.Parse(this.cmb_campos.SelectedValue.ToString()), tabela.DAO.Codigo, tabela.DAO.Projeto.Codigo);
                    campos.Add(campo);
                }
                else
                {
                    foreach(Model.MD_Campos campo in tabela.CamposDaTabela())
                    {
                        campos.Add(campo);
                    }
                }

                if (InsereTemporaria(campos))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Dispose();
                }
                else
                {
                    Message.MensagemErro("Erro ao inserir");
                }
            }
        }

        /// <summary>
        /// Método que insere os dados na tabela temporária
        /// </summary>
        /// <param name="campos">Lista de campos a serem inseridos</param>
        /// <returns>True - </returns>
        private bool InsereTemporaria(List<Model.MD_Campos> campos)
        {
            bool retorno = true;

            try
            {
                string sentenca = " INSERT INTO " + Util.Global.tempTable + " (CODIGOCAMPO, CODIGOTABELA, CODIGOPROJETO) VALUES (#VALOR1, #VALOR2, #VALOR3)";

                foreach(Model.MD_Campos campo in campos)
                {
                    string execute = sentenca.Replace("#VALOR1", campo.DAO.Codigo.ToString()).Replace("#VALOR2", campo.DAO.Tabela.Codigo.ToString()).Replace("#VALOR3", campo.DAO.Projeto.Codigo.ToString());
                    DataBase.Connection.Insert(execute);
                }
            }
            catch(Exception e)
            {
                retorno = false;
                Util.CL_Files.WriteOnTheLog("Error: " + e.Message, Util.Global.TipoLog.SIMPLES);
            }

            return retorno;
        }

        #endregion Métodos

    }
}
