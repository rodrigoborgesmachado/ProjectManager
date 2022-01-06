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
    public partial class UC_CadastroCampos : UserControl
    {
        #region Atributos e Propriedades

        /// <summary>
        /// Constrolador da tarefa que a tela está executando
        /// </summary>
        Util.Enumerator.Tarefa tarefa = Util.Enumerator.Tarefa.INCLUINDO;

        /// <summary>
        /// Controle da classe de campo da tela
        /// </summary>
        Model.MD_Campos campoCorrente;

        /// <summary>
        /// Controle da classe de tabela
        /// </summary>
        Model.MD_Tabela tabela;

        /// <summary>
        /// Controle da classe da tela principal
        /// </summary>
        FO_Principal principal;

        #endregion Atributos e Propriedades

        #region Eventos

        /// <summary>
        /// Evento disparado no clique do botão fechado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.principal.FecharTela(Util.Enumerator.Telas.CADASTRO_CAMPOS);
        }

        /// <summary>
        /// Evento lançado no botão excluir da tela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroCampos.btn_excluir_Click()", Util.Global.TipoLog.DETALHADO);

            this.Excluir();
        }

        /// <summary>
        /// Evento lançado no clique do botão confirmar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroCampos.btn_confirmar_Click()", Util.Global.TipoLog.DETALHADO);

            this.Confirmar();
        }

        /// <summary>
        /// Evento lançado no clique do botão de precisão do campo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_infoPrecisao_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroCampos.btn_infoPrecisao_Click()", Util.Global.TipoLog.DETALHADO);

            Message.MensagemInformacao("Precisão do campo!");
        }

        /// <summary>
        /// Evento lançado no clique do botão de tamanho do campo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_infoTamanho_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroCampos.btn_infoTamanho_Click()", Util.Global.TipoLog.DETALHADO);

            Message.MensagemInformacao("Tamanho do campo!");
        }

        /// <summary>
        /// Evento lançado no clique do botão de informação do campo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_campo_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroCampos.btn_info_campo_Click()", Util.Global.TipoLog.DETALHADO);

            Message.MensagemInformacao("Nome do campo!");
        }

        /// <summary>
        /// Evento lançado no clique do botão de domínio do campo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_dominio_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroCampos.btn_info_dominio_Click()", Util.Global.TipoLog.DETALHADO);

            Message.MensagemInformacao("Informação do tipo de dado que o campo representa (código, valor numérico, data)!");
        }

        /// <summary>
        /// Evento lançado no clique do botão de descrição do campo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_descrição_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroCampos.btn_info_descrição_Click()", Util.Global.TipoLog.DETALHADO);

            Message.MensagemInformacao("Qual a finalidade do campo!");
        }

        /// <summary>
        /// Evento lançado no clique do botão de informação da primary key
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_primarykey_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroCampos.btn_info_primarykey_Click()", Util.Global.TipoLog.DETALHADO);

            MessageBox.Show("Identifica se o campo é uma primary key (chave primária)!", "Informa");
        }

        /// <summary>
        /// Evento lançado no clique do botão de informação da not null
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_infonotnull_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroCampos.btn_infonotnull_Click()", Util.Global.TipoLog.DETALHADO);

            Message.MensagemInformacao("Identifica se o campo é uma Not NUll (não nulo)!");
        }

        /// <summary>
        /// Evento lançado no clique do botão de informação da unique
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_unique_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroCampos.btn_info_unique_Click()", Util.Global.TipoLog.DETALHADO);

            Message.MensagemInformacao("Identifica se o campo é uma unique (único)!");
        }

        /// <summary>
        /// Evento lançado no clique do botão de informação de check
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_check_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroCampos.btn_info_check_Click()", Util.Global.TipoLog.DETALHADO);

            Message.MensagemInformacao("Check do campo. Identifica alguma regra a se seguir quando o campo for preenchido/alterado!");
        }

        /// <summary>
        /// Evento lançado no clique do botão de informação de valor default
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_valorDefault_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroCampos.btn_info_valorDefault_Click()", Util.Global.TipoLog.DETALHADO);

            Message.MensagemInformacao("Valor padrão a ser colocado no campo!");
        }

        /// <summary>
        /// Evento lançado no clique do botão de informação de valor datatype
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_info_datatype_Click(object sender, EventArgs e)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroCampos.btn_info_datatype_Click()", Util.Global.TipoLog.DETALHADO);

            Message.MensagemInformacao("Tipo de dados que o campo armazena!");
        }

        /// <summary>
        /// Evento lançado no clique do botão copiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_copiar_descricao_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.tbx_descrição.Text);
        }

        /// <summary>
        /// Evento lançado no clique do botão copiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_copiar_dominio_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.tbx_dominio.Text);
        }

        /// <summary>
        /// Evento lançado no clique do botão copiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_copiar_campo_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.tbx_nomeCampo.Text);
        }

        #endregion Eventos

        #region Construtores

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="tarefa">Tarefa a ser efetuada pela tela</param>
        /// <param name="campo">Campo a ser visualizado/editado/excluído</param>
        /// <param name="principal">Tela principal para controle</param>
        public UC_CadastroCampos(Util.Enumerator.Tarefa tarefa, Model.MD_Campos campo, Model.MD_Tabela tabela, FO_Principal principal)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroCampos()", Util.Global.TipoLog.DETALHADO);

            this.tarefa = tarefa;
            this.campoCorrente = campo;
            this.tabela = tabela;
            this.principal = principal;
            this.InitializeComponent();
            this.InicializaUserControl();
        }

        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Método que inicializa o user control
        /// </summary>
        public void InicializaUserControl()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroCampos.InicializaUserControl()", Util.Global.TipoLog.DETALHADO);

            this.Dock = DockStyle.Fill;
            this.gpb_cadastroGeral.Text = "Cadastro de Campo - Tabela " + this.tabela.DAO.Nome + " - Projeto " + this.tabela.DAO.Projeto.Nome;
            this.CarregaComboDataTypes();
            this.CarregaLabelsBotoes();
        }

        /// <summary>
        /// Método que carrega o combo de data type
        /// </summary>
        private void CarregaComboDataTypes()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroCampos.CarregaComboDataTypes()", Util.Global.TipoLog.DETALHADO);

            string sentenca = new DAO.MD_TipoCampo().table.CreateCommandSQLTable();

            DataTable table = new DataTable();
            table.Load(DataBase.Connection.Select(sentenca));
            this.cmb_datatype.DataSource = table.DefaultView;

            this.cmb_datatype.DisplayMember = "NOME";
            this.cmb_datatype.ValueMember = "CODIGO";
            this.cmb_datatype.SelectedIndex = 0;
        }

        /// <summary>
        /// Método que carrega as labels da tela
        /// </summary>
        private void CarregaLabelsBotoes()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroCampos.CarregaLabelsBotoes()", Util.Global.TipoLog.DETALHADO);

            this.tbx_check.Text = string.Empty;
            this.tbx_default.Text = string.Empty;
            this.tbx_descrição.Text = string.Empty;
            this.tbx_dominio.Text = string.Empty;
            this.tbx_nomeCampo.Text = string.Empty;
            this.tbx_tamanho.Text = string.Empty;
            this.tbx_precisao.Text = string.Empty;

            this.ckb_notNull.Checked = false;
            this.ckb_primarykey.Checked = false;
            this.ckb_unique.Checked = false;

            switch (this.tarefa)
            {
                case Util.Enumerator.Tarefa.VISUALIZANDO:
                    this.CarregaVisualizando();
                    break;
                case Util.Enumerator.Tarefa.INCLUINDO:
                    this.CarregaIncluindo();
                    break;
                case Util.Enumerator.Tarefa.EDITANDO:
                    this.CarregaEditando();
                    break;
            }
        }

        /// <summary>
        /// Método que carrega as labels quando a tarefa é visualizar
        /// </summary>
        private void CarregaVisualizando()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroCampos.CarregaVisualizando()", Util.Global.TipoLog.DETALHADO);

            if (tarefa == Util.Enumerator.Tarefa.VISUALIZANDO)
            {
                this.CarregaObjeto();

                this.cmb_datatype.SelectedValue = this.campoCorrente.DAO.TipoCampo.Codigo;

                this.HabilitaEdicao(false);

                this.btn_confirmar.Text = "Alterar";
                this.btn_excluir.Text = "Excluir";
            }
        }

        /// <summary>
        /// Método que carrega as labels de acordo com o objeto
        /// </summary>
        private void CarregaObjeto()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroCampos.CarregaObjeto()", Util.Global.TipoLog.DETALHADO);

            this.tbx_check.Text = this.campoCorrente.DAO.Check;
            this.tbx_default.Text = (this.campoCorrente == null ? "" : (this.campoCorrente.DAO.Default == null ? "" : this.campoCorrente.DAO.Default.ToString()));
            this.tbx_descrição.Text = this.campoCorrente.DAO.Comentario;
            this.tbx_dominio.Text = this.campoCorrente.DAO.Dominio;
            this.tbx_nomeCampo.Text = this.campoCorrente.DAO.Nome;
            this.tbx_tamanho.Text = this.campoCorrente.DAO.Tamanho.ToString();
            this.tbx_precisao.Text = this.campoCorrente.DAO.Precisao.ToString();

            this.ckb_notNull.Checked = this.campoCorrente.DAO.NotNull;
            this.ckb_primarykey.Checked = this.campoCorrente.DAO.PrimaryKey;
            this.ckb_unique.Checked = this.campoCorrente.DAO.Unique;
        }

        /// <summary>
        /// Método que carrega a página quando se está incluindo
        /// </summary>
        private void CarregaIncluindo()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroCampos.CarregaIncluindo()", Util.Global.TipoLog.DETALHADO);

            if (this.tarefa == Util.Enumerator.Tarefa.INCLUINDO)
            {
                this.btn_confirmar.Text = "Confirmar";
                this.btn_excluir.Text = "Cancelar";
                this.HabilitaEdicao(true);
            }
        }

        /// <summary>
        /// Metodo que carrega a tela de maneira a editar o campo
        /// </summary>
        private void CarregaEditando()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroCampos.CarregaEditando()", Util.Global.TipoLog.DETALHADO);

            if (this.tarefa == Util.Enumerator.Tarefa.EDITANDO)
            {
                this.btn_confirmar.Text = "Confirmar";
                this.btn_excluir.Text = "Cancelar";

                this.CarregaObjeto();

                this.HabilitaEdicao(true);
            }
        }

        /// <summary>
        /// Método que habilita ou desabilita os campos para edição
        /// </summary>
        /// <param name="habilita">True - habilita os campos; False - desabilita os campos</param>
        private void HabilitaEdicao(bool habilita)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroCampos.HabilitaEdicao()", Util.Global.TipoLog.DETALHADO);

            this.tbx_check.Enabled = habilita;
            this.tbx_default.Enabled = habilita;
            this.tbx_descrição.Enabled = habilita;
            this.tbx_dominio.Enabled = habilita;
            this.tbx_nomeCampo.Enabled = habilita;
            this.tbx_precisao.Enabled = habilita;
            this.tbx_tamanho.Enabled = habilita;

            this.ckb_notNull.Enabled = habilita;
            this.ckb_primarykey.Enabled = habilita;
            this.ckb_unique.Enabled = habilita;

            this.cmb_datatype.Enabled = habilita;
        }

        /// <summary>
        /// Método que valida se o formulário foi preenchido corretamente
        /// </summary>
        /// <returns>True - Sucesso; False - Erro</returns>
        private bool ValidaCampos()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroCampos.ValidaCampos()", Util.Global.TipoLog.DETALHADO);

            bool retorno = true;
            string mensagem = string.Empty;

            if (string.IsNullOrEmpty(this.tbx_nomeCampo.Text))
            {
                this.tbx_nomeCampo.Focus();
                retorno = false;
                mensagem = "Campo \"CAMPO\" está vazio!";
            }
            if (this.cmb_datatype.SelectedIndex < 0)
            {
                this.cmb_datatype.Focus();
                retorno = false;
                mensagem = "Campo \"Data Type\" precisa ser selecionado!";
            }

            if (!string.IsNullOrEmpty(this.tbx_tamanho.Text))
            {
                int teste_int = 0;
                if (!int.TryParse(this.tbx_tamanho.Text, out teste_int))
                {
                    this.tbx_tamanho.Focus();
                    retorno = false;
                    mensagem = "Campo \"Tamanho\" deve ser preenchido com um valor inteiro!";
                }
            }

            if (!string.IsNullOrEmpty(this.tbx_precisao.Text))
            {
                decimal teste_decimal = 0;
                if (!decimal.TryParse(this.tbx_precisao.Text, out teste_decimal))
                {
                    this.tbx_precisao.Focus();
                    retorno = false;
                    mensagem = "Campo \"Tamanho\" deve ser preenchido com um valor inteiro!";
                }
            }

            if (!string.IsNullOrEmpty(mensagem))
            {
                Message.MensagemAlerta(mensagem);
            }

            return retorno;
        }

        /// <summary>
        /// Método que faz a confirmação 
        /// </summary>
        private void Confirmar()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroCampos.Confirmar()", Util.Global.TipoLog.DETALHADO);

            if (this.tarefa == Util.Enumerator.Tarefa.VISUALIZANDO)
            {
                this.tarefa = Util.Enumerator.Tarefa.EDITANDO;
                this.InicializaUserControl();
            }
            else
            {
                if (this.ValidaCampos())
                {
                    Model.MD_Campos campo = (this.tarefa == Util.Enumerator.Tarefa.EDITANDO ? this.campoCorrente : new Model.MD_Campos(DataBase.Connection.GetIncrement("CAMPOS"), this.tabela.DAO.Codigo, this.tabela.DAO.Projeto.Codigo));
                    this.CarregaDados(ref campo);

                    if (this.tarefa == Util.Enumerator.Tarefa.INCLUINDO && Model.MD_Campos.ExisteCampoTabela(tabela.DAO.Nome, campo.DAO.Nome, tabela.DAO.Projeto.Codigo)) 
                    {
                        Message.MensagemAlerta("O campo " + campo.DAO.Nome + " já exise na tabela " + tabela.DAO.Nome + "!");
                        return;
                    }

                    bool exec = this.tarefa == Util.Enumerator.Tarefa.EDITANDO ? campo.DAO.Update() : campo.DAO.Insert();

                    if (exec)
                    {
                        Message.MensagemSucesso((this.tarefa == Util.Enumerator.Tarefa.INCLUINDO ? "Incluído" : "Alterado") + " com sucesso!");

                        if(this.tarefa == Util.Enumerator.Tarefa.INCLUINDO)
                        {
                            if (Message.MensagemConfirmaçãoYesNo("Deseja cadastrar outro campo para a tabela?") == DialogResult.Yes)
                            {
                                this.tarefa = Util.Enumerator.Tarefa.INCLUINDO;
                                this.InicializaUserControl();
                                this.principal.CarregaTreeViewAutomaticamente();
                            }
                            else
                            {
                                this.tarefa = Util.Enumerator.Tarefa.VISUALIZANDO;
                                this.campoCorrente = campo;
                                this.InicializaUserControl();
                                this.principal.CarregaTreeViewAutomaticamente();
                            }
                        }
                        else
                        {
                            this.tarefa = Util.Enumerator.Tarefa.VISUALIZANDO;
                            this.campoCorrente = campo;
                            this.InicializaUserControl();
                            this.principal.CarregaTreeViewAutomaticamente();
                        }
                    }
                    else
                    {
                        Message.MensagemErro("Erro ao cadastrar!");
                    }
                }
            }
        }

        /// <summary>
        /// Método que carrega o objeto com os dados do formulário
        /// </summary>
        /// <param name="campo"></param>
        private void CarregaDados(ref Model.MD_Campos campo)
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroCampos.CarregaDados()", Util.Global.TipoLog.DETALHADO);

            campo.DAO.Check = this.tbx_check.Text;
            campo.DAO.Default = this.tbx_default.Text;
            campo.DAO.Comentario = this.tbx_descrição.Text;
            campo.DAO.Dominio = this.tbx_dominio.Text;
            campo.DAO.Nome = this.tbx_nomeCampo.Text;
            campo.DAO.TipoCampo = new Model.MD_TipoCampo(int.Parse(cmb_datatype.SelectedValue.ToString())).DAO;

            if (!string.IsNullOrEmpty(this.tbx_tamanho.Text))
            {
                campo.DAO.Tamanho = int.Parse(this.tbx_tamanho.Text);
            }
            if (!string.IsNullOrEmpty(this.tbx_precisao.Text))
            {
                campo.DAO.Precisao = decimal.Parse(this.tbx_precisao.Text);
            }

            campo.DAO.NotNull = this.ckb_notNull.Checked;
            campo.DAO.PrimaryKey = this.ckb_primarykey.Checked;
            campo.DAO.Unique = this.ckb_unique.Checked;
        }

        /// <summary>
        /// Método que define as tarefas de exclusão do campo
        /// </summary>
        private void Excluir()
        {
            Util.CL_Files.WriteOnTheLog("UC_CadastroCampos.Excluir()", Util.Global.TipoLog.DETALHADO);

            if (tarefa == Util.Enumerator.Tarefa.INCLUINDO)
            {
                principal.FecharTela(Util.Enumerator.Telas.CADASTRO_CAMPOS);
            }
            else if (tarefa == Util.Enumerator.Tarefa.EDITANDO)
            {
                this.tarefa = Util.Enumerator.Tarefa.VISUALIZANDO;
                this.InicializaUserControl();
            }
            else
            {
                if (Message.MensagemConfirmaçãoYesNo("Deseja excluir o campo?") == DialogResult.Yes)
                {
                    if (this.campoCorrente.DAO.Delete())
                    {
                        Message.MensagemSucesso("Excluído com sucesso!");
                        this.principal.CarregaTreeViewAutomaticamente();
                        principal.FecharTela(Util.Enumerator.Telas.CADASTRO_CAMPOS);
                    }
                    else
                    {
                        Message.MensagemErro("Erro ao excluir!");
                    }
                }
            }
        }

        #endregion Métodos
        
    }
}
