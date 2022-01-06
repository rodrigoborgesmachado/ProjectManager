using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regras
{
    public static class ScriptBanco
    {

        /// <summary>
        /// Método principal para fazer a criação do script
        /// </summary>
        /// <param name="projeto">Projeto para capturar as tabelas</param>
        /// <param name="banco">Tipo de banco</param>
        /// <param name="apenasUmArquivo"></param>
        /// <param name="caminho"></param>
        /// <returns></returns>
        public static bool CriarScript(Model.MD_Projeto projeto, Util.Enumerator.BancoDados banco, bool apenasUmArquivo, string caminho = null)
        {
            List<Model.MD_Tabela> table = projeto.GetTabelasProjeto();
            return CriarScript(table, banco, apenasUmArquivo, caminho);
        }

        /// <summary>
        /// Método principal para fazer a criação do script
        /// </summary>
        /// <param name="tabelas">Tabelas que serão incluídas</param>
        /// <param name="banco">Tipo de banco para criar os scripts</param>
        /// <param name="apenasUmArquivo">Flag para verificar se é para criar apenas um arquivo</param>
        /// <param name="caminho">Caminho para salvar os scripts</param>
        /// <returns>True - gerado com sucesso; False: Gerado com erros</returns>
        public static bool CriarScript(List<Model.MD_Tabela> tabelas, Util.Enumerator.BancoDados banco, bool apenasUmArquivo, string caminho = null)
        {
            bool retorno = true;

            try
            {
                StringBuilder comandoGeral = new StringBuilder();
                StringBuilder builder = new StringBuilder();

                if (string.IsNullOrEmpty(caminho))
                {
                    caminho = Util.Global.app_Script_directory;
                }
                else
                {
                    caminho += "\\";
                }

                if (!Directory.Exists(caminho))
                {
                    Directory.CreateDirectory(caminho);
                }

                Visao.BarraDeCarregamento barra = new Visao.BarraDeCarregamento(tabelas.Count, "Gerando Script");
                barra.Show();

                foreach (Model.MD_Tabela table in tabelas)
                {
                    builder = new StringBuilder();
                    CriarCreate(table, ref builder);

                    if (!apenasUmArquivo)
                    {
                        caminho += table.DAO.Nome.ToUpper() + ".sql";

                        if (!SalvarArquivo(caminho, builder.ToString()))
                        {
                            retorno = false;
                        }
                    }
                    else
                    {
                        comandoGeral.AppendLine(builder.ToString());
                        comandoGeral.AppendLine(";");
                        comandoGeral.AppendLine("");
                    }

                    barra.AvancaBarra(1);
                }

                barra.Dispose();
                barra = null;
                caminho += "script.sql";

                if (apenasUmArquivo)
                {
                    if (!SalvarArquivo(caminho, comandoGeral.ToString()))
                    {
                        retorno = false;
                    }
                }
            }
            catch(Exception e)
            {
                Util.CL_Files.WriteOnTheLog("Erro: " + e.Message, Util.Global.TipoLog.SIMPLES);
                retorno = false;
            }

            return retorno;
        }

        /// <summary>
        /// Método que salva o arquivo de comando sql
        /// </summary>
        /// <param name="caminho"></param>
        /// <returns></returns>
        private static bool SalvarArquivo(string caminho, string texto)
        {
            bool retorno = true;

            try
            {
                File.AppendAllText(caminho, texto);
            }
            catch(Exception e)
            {
                Util.CL_Files.WriteOnTheLog("Erro: " + e.Message, Util.Global.TipoLog.SIMPLES);
                retorno = false;
            }

            return retorno;
        }

        /// <summary>
        /// Método que cria o create da tabela
        /// </summary>
        /// <param name="table">Tabela a ser preenchida</param>
        /// <param name="builder">Builder para criação do comando</param>
        private static void CriarCreate(Model.MD_Tabela table, ref StringBuilder builder)
        {
            try
            {
                DAO.MDN_Table tabela = MontaNucleo(table);
                builder = tabela.CreateTable(false);
            }
            catch(Exception e)
            {
                Util.CL_Files.WriteOnTheLog("Erro: " + e.Message, Util.Global.TipoLog.SIMPLES);
            }
        }

        /// <summary>
        /// Método que monta a tabela do núcleo a partir da tabela cadastrada
        /// </summary>
        /// <param name="table">Tabela a ser criada</param>
        /// <returns>Tabela do núcleo</returns>
        private static DAO.MDN_Table MontaNucleo(Model.MD_Tabela table)
        {
            DAO.MDN_Table tabela = new DAO.MDN_Table(table.DAO.Nome);
            tabela.Fields_Table = CamposTabela(table);
            return tabela;
        }

        /// <summary>
        /// Método que retorna a lista dos campos da tabela
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        private static List<DAO.MDN_Campo> CamposTabela(Model.MD_Tabela table)
        {
            List<DAO.MDN_Campo> campos = new List<DAO.MDN_Campo>();

            foreach (Model.MD_Campos campoModel in table.CamposDaTabela())
            {
                DAO.MDN_Campo campo = new DAO.MDN_Campo(campoModel.DAO.Nome, campoModel.DAO.NotNull, RetornaTipoCampo(campoModel), campoModel.DAO.Default, campoModel.DAO.PrimaryKey, campoModel.DAO.Unique, campoModel.DAO.Tamanho, int.Parse(campoModel.DAO.Precisao.ToString()));
                campos.Add(campo);
            }

            return campos;
        }

        /// <summary>
        /// Método que retorna o tipo de campo
        /// </summary>
        /// <param name="campo">CAmpo para resgatar o tipo</param>
        /// <returns>Tipo do campo</returns>
        private static Util.Enumerator.DataType RetornaTipoCampo(Model.MD_Campos campo)
        {
            Util.Enumerator.DataType tipo = campo.TipoNucleo();

            return tipo;
        }
    }
}
