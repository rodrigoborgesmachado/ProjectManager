using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Model;
using Visao;
using DAO;
using Util;

namespace Regras
{
    public static class Backup
    {

        /// <summary>
        /// Método que busca o backup a partir do arquivo DER selecionado
        /// </summary>
        /// <param name="projeto">Projeto para importar os dados</param>
        /// <param name="fileInfo">Arquivo DER para busca dos dados</param>
        /// <param name="messageErro"></param>
        /// <returns></returns>
        public static bool BuscarBackup(Model.MD_Projeto projeto,FileInfo fileInfo, ref string messageErro)
        {
            Util.CL_Files.WriteOnTheLog("Backup.BuscarBackup()", Global.TipoLog.DETALHADO);

            try
            {
                List<MDN_Table> tables = MontaTabela(fileInfo.FullName);

                ResultadoTabelas(tables, projeto);
            }
            catch (Exception e)
            {
                Util.CL_Files.WriteOnTheLog("Error: " + e.Message, Global.TipoLog.SIMPLES);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Método que abre o arquivo DER, lê e identifica todas as tabelas e suas colunas
        /// </summary>
        /// <param name="diretorioFile"></param>
        /// <returns></returns>
        public static List<MDN_Table> MontaTabela(string diretorioFile)
        {
            Util.CL_Files.WriteOnTheLog("Backup.MontaTabela()", Util.Global.TipoLog.DETALHADO);

            List<MDN_Table> tabelas = new List<MDN_Table>();

            List<string> linhas = TextoArquivo(diretorioFile);

            BarraDeCarregamento barraDeCarregamento = new BarraDeCarregamento(linhas.Count, "Importando DER");
            barraDeCarregamento.Show();

            string nome_tabela = string.Empty;
            string tipo_coluna = string.Empty;
            string tabela = string.Empty;
            bool inTable = false;

            foreach (string linha in linhas)
            {
                barraDeCarregamento.AvancaBarra(1);

                if (linha.Contains("caption1"))
                {
                    nome_tabela = linha.Replace("<div class=\"caption1\">", "").Replace("</div>", "");
                }
                else if (linha.Contains("caption2"))
                {
                    tipo_coluna = linha.Replace("<div class=\"caption2\">", "").Replace("</div>", "");
                }
                else if (linha.Contains("table class=\"tabformat\""))
                {
                    inTable = true;
                }
                else if (inTable && tipo_coluna.ToUpper().Equals("COLUMNS"))
                {
                    if (linha.Contains("</table>"))
                    {
                        tabelas.Add(MontaConfiguracaoTabela(nome_tabela, tabela, barraDeCarregamento));
                        tabela = string.Empty;
                        inTable = false;
                        tipo_coluna = string.Empty;
                    }
                    else if (!string.IsNullOrEmpty(linha.Trim()))
                    {
                        tabela += linha;
                    }
                }
            }

            barraDeCarregamento.Dispose();
            barraDeCarregamento = null;

            linhas.Clear();
            linhas = null;

            return tabelas;
        }

        /// <summary>
        /// Método que lê o arquivo e coloca numa lista de string
        /// </summary>
        /// <param name="diretorio">diretório do arquivo</param>
        /// <returns>Lista com as linhas do arquivo</returns>
        private static List<string> TextoArquivo(string diretorio)
        {
            Util.CL_Files.WriteOnTheLog("Backup.TextoArquivo()", Util.Global.TipoLog.DETALHADO);

            List<string> retorno = new List<string>();

            Util.CL_Files file = new CL_Files(diretorio);
            retorno = file.ReadArchive();

            return retorno;
        }

        /// <summary>
        /// Método que monta a classe de tabela a partir da table criada
        /// </summary>
        /// <param name="nomeTabela"></param>
        /// <param name="tabela"></param>
        /// <returns></returns>
        private static MDN_Table MontaConfiguracaoTabela(string nomeTabela, string tabela, BarraDeCarregamento barra)
        {
            Util.CL_Files.WriteOnTheLog("Backup.MontaConfiguracaoTabela()", Util.Global.TipoLog.DETALHADO);

            MDN_Table table = new MDN_Table(nomeTabela);

            tabela = tabela.Replace("</td>", "");
            tabela = tabela.Replace("</tr>", "");
            tabela = tabela.Replace("<tr>", "|");

            List<string> linhas = tabela.Split('|').ToList();
            List<string> colunas = new List<string>();

            string lin = string.Empty;
            int numlinha = 0;
            foreach (string linha in linhas)
            {
                barra.AvancaBarra(1);
                lin = string.Empty;
                if (string.IsNullOrEmpty(linha.Trim()))
                {
                    continue;
                }

                if (numlinha == 0)
                {
                    numlinha++;
                    continue;
                }

                lin = linha.Replace("|", "");
                lin = lin.Replace("<td class=\"tabhead\" >", "|");
                lin = lin.Replace("<td class=\"tabhead\"  colspan=\"2\">", "|");
                lin = lin.Replace("<td class=\"tabhead\"  colspan=\"3\">", "|");
                lin = lin.Replace("<td class=\"tabhead\"  colspan=\"4\">", "|");
                lin = lin.Replace("<td class=\"tabhead\"  colspan=\"5\">", "|");

                lin = lin.Replace("<td class=\"tabdata\" >", "|");
                lin = lin.Replace("<td class=\"tabdata\"  colspan=\"1\">", "|");
                lin = lin.Replace("<td class=\"tabdata\"  colspan=\"2\">", "|");
                lin = lin.Replace("<td class=\"tabdata\"  colspan=\"3\">", "|");
                lin = lin.Replace("<td class=\"tabdata\"  colspan=\"4\">", "|");
                lin = lin.Replace("<td class=\"tabdata\"  colspan=\"5\">", "|");

                colunas = lin.Trim().Split('|').ToList();
                table.Fields_Table.Add(MontaColuna(colunas, barra));
            }

            return table;
        }

        /// <summary>
        /// Método que cria a coluna
        /// </summary>
        /// <param name="colunas">Colunas</param>
        /// <returns>Modelo de coluna</returns>
        private static MDN_Campo MontaColuna(List<string> colunas, BarraDeCarregamento barra)
        {
            Util.CL_Files.WriteOnTheLog("Backup.MontaColuna()", Util.Global.TipoLog.DETALHADO);

            MDN_Campo Campo = null;

            bool primarykey = false;
            bool notnull = false;
            bool unique = false;
            object obj = null;
            string colunaNome = "";
            Util.Enumerator.DataType type = Enumerator.DataType.INT;
            int size = 0;
            int precision = 0;

            int i = 0;
            foreach (string coluna in colunas)
            {
                barra.AvancaBarra(1);
                if (string.IsNullOrEmpty(coluna))
                {
                    continue;
                }

                coluna.Replace("|", "");

                string palavra = coluna.Trim();

                switch (i)
                {
                    case 0: //Key
                        primarykey = palavra.ToUpper().Equals("PK");
                        break;
                    case 1: //Column name
                        colunaNome = palavra;
                        break;
                    case 2: //Domain
                        break;
                    case 3: // Data type
                        if (palavra.ToUpper().Contains("VARCHAR"))
                        {
                            type = Enumerator.DataType.STRING;
                            size = int.Parse(palavra.Split('(')[1].Replace(")", "").ToString());
                        }
                        else if (palavra.ToUpper().Contains("TIMESTAMP"))
                        {
                            type = Enumerator.DataType.DATE;
                        }
                        else if (palavra.ToUpper().Contains("DECIMAL"))
                        {
                            type = Enumerator.DataType.DECIMAL;
                            size = int.Parse(palavra.Split('(')[1].ToString().Split(',')[0].ToString());
                            precision = int.Parse(palavra.Split('(')[1].ToString().Split(',')[1].Replace(")", "").ToString());
                        }
                        else if (palavra.ToUpper().Contains("CHAR"))
                        {
                            type = Enumerator.DataType.CHAR;
                            size = int.Parse(palavra.Split('(')[1].Replace(")", "").ToString());
                        }
                        else if (palavra.ToUpper().Contains("INTEGER"))
                        {
                            type = Enumerator.DataType.INT;
                        }
                        break;
                    case 4: // Not Null
                        if (palavra.ToUpper().Equals("YES"))
                        {
                            notnull = true;
                        }
                        break;
                    case 5: // Unique
                        if (palavra.ToUpper().Equals("YES"))
                        {
                            unique = true;
                        }
                        break;
                    case 6: // Check
                        break;
                    case 7: // Default
                        obj = palavra.Replace("'", "").ToString();
                        break;
                    case 8: // Comments
                        break;
                    case 9: // Notes
                        break;
                }

                i++;
            }

            Campo = new MDN_Campo(colunaNome, notnull, type, obj, primarykey, unique, size, precision);
            return Campo;
        }

        /// <summary>
        /// Método que processa as tabelas
        /// </summary>
        /// <param name="tables">tabelas de importação</param>
        /// <param name="projeto">projeto para importação</param>
        private static void ResultadoTabelas(List<MDN_Table> tables, Model.MD_Projeto projeto)
        {
            Util.CL_Files.WriteOnTheLog("Backup.ResultadoTabelas()", Util.Global.TipoLog.DETALHADO);

            foreach (MDN_Table table in tables)
            {
                Tabela tabela = new Tabela();
                tabela.nome = table.Table_Name;
                bool existe = false;

                int codigo = Importador.CodigoTabela(tabela, projeto.DAO.Codigo, ref existe);
                Model.MD_Tabela tabelaImport = new Model.MD_Tabela(codigo, projeto.DAO.Codigo);
                tabelaImport.DAO.Nome = tabela.nome;

                if (!existe)
                {
                    tabelaImport.DAO.Insert();
                }
                else
                {
                    tabelaImport.DAO.Update();
                }

                foreach (MDN_Campo campo in table.Fields_Table)
                {
                    Model.Campo field = new Campo();
                    field.Name_Field = campo.Name_Field;
                    field.NotNull = campo.NotNull;
                    field.Precision = campo.Precision;
                    field.PrimaryKey = campo.PrimaryKey;
                    field.Size = campo.Size;
                    field.Tabela = tabela.nome;
                    field.Type = campo.Type.ToString();
                    field.Unique = campo.Unique;
                    field.ValueDefault = campo.ValueDefault.ToString();

                    int codigoCampo = Importador.CodigoColuna(field, projeto.DAO.Codigo, ref existe);
                    Model.MD_Campos campoImportar = new Model.MD_Campos(codigoCampo, tabelaImport.DAO.Codigo, tabelaImport.DAO.Projeto.Codigo);
                    campoImportar.DAO.Nome = field.Name_Field;
                    campoImportar.DAO.Default = field.ValueDefault;
                    campoImportar.DAO.NotNull = field.NotNull;
                    campoImportar.DAO.Precisao = field.Precision;
                    campoImportar.DAO.PrimaryKey = field.PrimaryKey;
                    campoImportar.DAO.Projeto = projeto.DAO;
                    campoImportar.DAO.Tamanho = field.Size;
                    campoImportar.DAO.TipoCampo = Model.MD_TipoCampo.RetornaTipoCampo(field.Type).DAO;
                    campoImportar.DAO.Unique = field.Unique;

                    if (!existe)
                    {
                        campoImportar.DAO.Insert();
                    }
                    else
                    {
                        campoImportar.DAO.Update();
                    }
                }
            }
        }
    }
}
