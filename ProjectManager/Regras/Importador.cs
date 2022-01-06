using Visao;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;
using System.Data.Common;

namespace Regras
{
    public static class Importador
    {
        /// <summary>
        /// Método que faz a importação dos arquivos JSON
        /// </summary>
        /// <param name="projeto">Código do projeto para associar os dados</param>
        /// <returns></returns>
        public static bool Importar(int projeto)
        {
            Util.CL_Files.WriteOnTheLog("Importador.Importar()", Util.Global.TipoLog.DETALHADO);

            try
            {
                ApagaArquivosExportacao();

                if(AbrirAplicacaoBancoDados())
                {
                    ImportarArquivos(projeto);
                }
            }
            catch (Exception e)
            {
                Util.CL_Files.WriteOnTheLog("Error: " + e.Message, Global.TipoLog.SIMPLES);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Método que apaga os arquivos json old
        /// </summary>
        private static void ApagaArquivosExportacao()
        {
            Util.CL_Files.WriteOnTheLog("Importador.ApagaArquivosExportacao()", Util.Global.TipoLog.DETALHADO);

            foreach (string file in Directory.GetFiles(Util.Global.app_exportacao_directory))
            {
                File.Delete(file);
            }
        }

        /// <summary>
        /// Método que abre a aplicação que faz cria os arquivos JSON de importação
        /// </summary>
        /// <returns>True - os arquivos foram gerados; False - os arquivos não foram gerados</returns>
        private static bool AbrirAplicacaoBancoDados()
        {
            Util.CL_Files.WriteOnTheLog("Importador.AbrirAplicacaoBancoDados()", Util.Global.TipoLog.DETALHADO);

            bool retorno = true;
            ///*
            System.Diagnostics.Process p = System.Diagnostics.Process.Start(Util.Global.app_IMPORT_file);
            while (!p.HasExited);

            retorno = VerificaArquivosCriados();
            //*/
            return retorno;
        }

        /// <summary>
        /// Método que valida se foram criados arquivos de impotação
        /// </summary>
        /// <returns></returns>
        private static bool VerificaArquivosCriados()
        {
            Util.CL_Files.WriteOnTheLog("Importador.VerificaArquivosCriados()", Util.Global.TipoLog.DETALHADO);

            bool retorno = true;

            retorno = Directory.GetFiles(Util.Global.app_exportacao_directory).Count() > 0;

            return retorno;
        }

        /// <summary>
        /// Método que faz a importação dos arquivos para o banco de dados
        /// </summary>
        private static void ImportarArquivos(int projeto)
        {
            Util.CL_Files.WriteOnTheLog("Importador.ImportarArquivos()", Util.Global.TipoLog.DETALHADO);

            List<Model.Tabela> tabelas = new List<Model.Tabela>();
            PreencheLista(ref tabelas);

            List<Model.Campo> campos = new List<Model.Campo>();
            PreencheLista(ref campos);

            List<Model.Relacionamento> relacionamentos = new List<Model.Relacionamento>();
            PreencheLista(ref relacionamentos);

            TratarImportacao(projeto, ref tabelas, ref campos, ref relacionamentos);

            tabelas.Clear();
            tabelas = null;

            campos.Clear();
            campos = null;

            relacionamentos.Clear();
            relacionamentos = null;

            CopiaArquivos();
        }

        /// <summary>
        /// Método que preenche a lista com as tabelas do arquivo JSON
        /// </summary>
        /// <param name="tabelas">Lista de tabelas a ser preenchida</param>
        private static void PreencheLista(ref List<Model.Tabela> tabelas)
        {
            Util.CL_Files.WriteOnTheLog("Importador.PreencheLista()", Util.Global.TipoLog.DETALHADO);

            if (!File.Exists(Global.app_exportacao_tabela_file))
                return;

            string json = string.Empty;
            foreach(string linha in File.ReadAllLines(Global.app_exportacao_tabela_file).ToList())
            {
                json += linha;
            }

            tabelas = JsonConvert.DeserializeObject<List<Model.Tabela>>(json);
        }

        /// <summary>
        /// Método que preenche a lista com os campos do arquivo JSON
        /// </summary>
        /// <param name="campos">Lista de campos a ser preenchida</param>
        private static void PreencheLista(ref List<Model.Campo> campos)
        {
            Util.CL_Files.WriteOnTheLog("Importador.PreencheLista()", Util.Global.TipoLog.DETALHADO);

            if (!File.Exists(Global.app_exportacao_tabela_file))
                return;

            string json = string.Empty;
            foreach (string linha in File.ReadAllLines(Global.app_exportacao_campos_file).ToList())
            {
                json += linha;
            }

            campos = JsonConvert.DeserializeObject<List<Model.Campo>>(json);
        }

        /// <summary>
        /// Método que preenche a lista com os relacionamentos do arquivo JSON
        /// </summary>
        /// <param name="relacionamentos">Lista de relacionamentos a ser preenchida</param>
        private static void PreencheLista(ref List<Model.Relacionamento> relacionamentos)
        {
            Util.CL_Files.WriteOnTheLog("Importador.PreencheLista()", Util.Global.TipoLog.DETALHADO);

            if (!File.Exists(Global.app_exportacao_tabela_file))
                return;

            string json = string.Empty;
            foreach (string linha in File.ReadAllLines(Global.app_exportacao_relacionamentos_file).ToList())
            {
                json += linha;
            }

            relacionamentos = JsonConvert.DeserializeObject<List<Model.Relacionamento>>(json);
        }

        /// <summary>
        /// Método que trata as tabelas de importação e coloca nas tabelas definitivas vinculando com o projeto
        /// </summary>
        /// <param name="projeto">Código do projeto a se vincular as tabelas</param>
        private static void TratarImportacao(int codigo, ref List<Model.Tabela> tabelas, ref List<Model.Campo> campos, ref List<Model.Relacionamento> relacionamentos)
        {
            Util.CL_Files.WriteOnTheLog("Importador.TratarImportacao()", Util.Global.TipoLog.DETALHADO);

            Model.MD_Projeto projeto = new Model.MD_Projeto(codigo);

            BarraDeCarregamento barraCarregamento = new BarraDeCarregamento(tabelas.Count(), "Importando Tabelas");
            barraCarregamento.Show();

            TratarTabelas(projeto, ref tabelas, ref barraCarregamento);

            barraCarregamento.Hide();
            barraCarregamento.Dispose();
            barraCarregamento = null;

            barraCarregamento = new BarraDeCarregamento(campos.Count(), "Importando Colunas");
            barraCarregamento.Show();

            TratarColunas(projeto, ref campos, ref barraCarregamento);

            barraCarregamento.Hide();
            barraCarregamento.Dispose();
            barraCarregamento = null;

            barraCarregamento = new BarraDeCarregamento(relacionamentos.Count(), "Importando Relacionamentos");

            barraCarregamento.Show();
            TratarRelacionamento(projeto, ref relacionamentos, ref barraCarregamento);
            projeto = null;
            barraCarregamento.Hide();
            barraCarregamento.Dispose();
            barraCarregamento = null;
        }

        /// <summary>
        /// Método que trata os relacionamentos
        /// </summary>
        /// <param name="projeto">Projeto ao qual o relacionamento pertence</param>
        /// <param name="relacionamentos">Relacionamentos a serem importadas para o projeto</param>
        private static void TratarRelacionamento(Model.MD_Projeto projeto, ref List<Model.Relacionamento> relacionamentos, ref BarraDeCarregamento barra)
        {
            Util.CL_Files.WriteOnTheLog("Importador.TratarRelacionamento()", Util.Global.TipoLog.DETALHADO);

            foreach (Model.Relacionamento r in relacionamentos)
            {
                barra.AvancaBarra(1);

                bool existe = false;
                int rCodigo = CodigoRelacionamento(r, projeto.DAO.Codigo, ref existe);
                Model.Tabela tabelaOrigemDesc = new Model.Tabela();
                tabelaOrigemDesc.nome = r.tabelaOrigem;

                Model.Tabela tabelaDestinoDesc = new Model.Tabela();
                tabelaDestinoDesc.nome = r.tabelaDestino;

                Model.Campo campoOrigemDesc = new Model.Campo();
                campoOrigemDesc.Name_Field = r.campoOrigem;
                campoOrigemDesc.Tabela = tabelaOrigemDesc.nome;

                Model.Campo campoDestinoDesc = new Model.Campo();
                campoDestinoDesc.Name_Field = r.campoDestino;
                campoDestinoDesc.Tabela = tabelaDestinoDesc.nome;

                bool x = true;
                Model.MD_Tabela tabelaOrigem = new Model.MD_Tabela(CodigoTabela(tabelaOrigemDesc, projeto.DAO.Codigo, ref x), projeto.DAO.Codigo);
                if (!x)
                {
                    tabelaOrigem.DAO.Insert();
                }

                Model.MD_Tabela tabelaDestino = new Model.MD_Tabela(CodigoTabela(tabelaDestinoDesc, projeto.DAO.Codigo, ref x), projeto.DAO.Codigo);
                if (!x)
                {
                    tabelaDestino.DAO.Insert();
                }

                Model.MD_Campos campoOrigem = new Model.MD_Campos(CodigoColuna(campoOrigemDesc, projeto.DAO.Codigo, ref x), tabelaOrigem.DAO.Codigo, tabelaOrigem.DAO.Projeto.Codigo);
                if (!x)
                {
                    campoOrigem.DAO.Insert();
                }

                Model.MD_Campos campoDestino = new Model.MD_Campos(CodigoColuna(campoDestinoDesc, projeto.DAO.Codigo, ref x), tabelaDestino.DAO.Codigo, tabelaDestino.DAO.Projeto.Codigo);
                if (!x)
                {
                    campoDestino.DAO.Insert();
                }

                Model.MD_Relacao relacao = new Model.MD_Relacao(rCodigo, projeto.DAO, tabelaOrigem.DAO, tabelaDestino.DAO, campoOrigem.DAO, campoDestino.DAO);

                relacao.DAO.NomeForeingKey = r.constraintName;

                if (existe)
                {
                    relacao.DAO.Update();
                }
                else
                {
                    relacao.DAO.Insert();
                }

                tabelaOrigemDesc = null;
                tabelaDestinoDesc = null;
                campoOrigemDesc = null;
                campoDestinoDesc = null;
                relacao = null;
                tabelaOrigem = null;
                tabelaDestino = null;
                campoOrigem = null;
                campoDestino = null;
            }
        }

        /// <summary>
        /// Método que retorna o código da tabela
        /// </summary>
        /// <param name="tabela">Nome da tabela</param>
        /// <returns>Código da tabela</returns>
        public static int CodigoRelacionamento(Model.Relacionamento relacionamento, int codigoProjeto, ref bool existe)
        {
            Util.CL_Files.WriteOnTheLog("Importador.CodigoRelacionamento()", Util.Global.TipoLog.DETALHADO);

            int codigo = -1;
            Model.Tabela tabelaOrigem = new Model.Tabela();
            tabelaOrigem.nome = relacionamento.tabelaOrigem;

            Model.Tabela tabelaDestino = new Model.Tabela();
            tabelaDestino.nome = relacionamento.tabelaDestino;

            Model.Campo campoOrigem = new Model.Campo();
            campoOrigem.Name_Field = relacionamento.campoOrigem;
            campoOrigem.Tabela = tabelaOrigem.nome;

            Model.Campo campoDestino = new Model.Campo();
            campoDestino.Name_Field = relacionamento.campoDestino;
            campoDestino.Tabela = tabelaDestino.nome;

            bool x = true;
            int codigoTabelaOrigem = CodigoTabela(tabelaOrigem, codigoProjeto,  ref x);
            int codigoTabelaDestino = CodigoTabela(tabelaDestino, codigoProjeto, ref x);
            int codigoCampoOrigem = CodigoColuna(campoOrigem, codigoProjeto, ref x);
            int codigoCampoDestino = CodigoColuna(campoDestino, codigoProjeto, ref x);

            string sentenca = ClassesGenericas.relacaoBase.DAO.table.CreateCommandSQLTable() + " WHERE TABELAORIGEM = " + codigoTabelaOrigem + " AND CAMPOORIGEM = " + codigoCampoOrigem + " AND TABELADESTINO = " + codigoTabelaDestino + " AND CAMPODESTINO = " + codigoCampoDestino;

            DbDataReader reader = DataBase.Connection.Select(sentenca);
            if (reader != null)
            {
                if (reader.Read())
                {
                    codigo = int.Parse(reader["CODIGO"].ToString());
                    existe = true;
                }
                else
                {
                    codigo = DataBase.Connection.GetIncrement("RELACAO");
                    existe = false;
                }
                reader.Close();
            }

            reader = null;
            tabelaOrigem = null;
            tabelaDestino = null;
            campoOrigem = null;
            campoDestino = null;

            return codigo;
        }

        /// <summary>
        /// Método que trata as tabelas
        /// </summary>
        /// <param name="projeto">Projeto ao qual a tabela pertence</param>
        /// <param name="tabelas">Tabelas a serem importadas para o projeto</param>
        private static void TratarColunas(Model.MD_Projeto projeto, ref List<Model.Campo> campos, ref BarraDeCarregamento barra)
        {
            Util.CL_Files.WriteOnTheLog("Importador.TratarColunas()", Util.Global.TipoLog.DETALHADO);

            foreach (Model.Campo c in campos)
            {
                barra.AvancaBarra(1);

                bool existe = false;
                int campoCodigo = CodigoColuna(c, projeto.DAO.Codigo, ref existe);
                Model.Tabela t = new Model.Tabela();
                t.nome = c.Tabela;

                bool x = true;

                Model.MD_Tabela tabela = new Model.MD_Tabela(CodigoTabela(t, projeto.DAO.Codigo, ref x), projeto.DAO.Codigo);
                Model.MD_Campos campo = new Model.MD_Campos(campoCodigo, tabela.DAO.Codigo, tabela.DAO.Projeto.Codigo);
                campo.DAO.Nome = c.Name_Field;
                campo.DAO.Default = c.ValueDefault;
                campo.DAO.NotNull = c.NotNull;
                campo.DAO.Precisao = c.Precision;
                campo.DAO.PrimaryKey = c.PrimaryKey;
                campo.DAO.Projeto = projeto.DAO;
                campo.DAO.Tamanho = c.Size;
                campo.DAO.TipoCampo = Model.MD_TipoCampo.RetornaTipoCampo(c.Type).DAO;
                campo.DAO.Unique = c.Unique;

                if (existe)
                {
                    campo.DAO.Update();
                }
                else
                {
                    campo.DAO.Insert();
                }
                campo = null;
                tabela = null;
            }
        }

        /// <summary>
        /// Método que retorna o código do campo
        /// </summary>
        /// <param name="campo">Nome do campo</param>
        /// <returns>Código do campo</returns>
        public static int CodigoColuna(Model.Campo campo, int codigoProjeto, ref bool existe)
        {
            Util.CL_Files.WriteOnTheLog("Importador.CodigoColuna()", Util.Global.TipoLog.DETALHADO);

            Model.Tabela tabela = new Model.Tabela();
            bool x = true;

            tabela.nome = campo.Tabela;
            int codigo = -1;
            string sentenca = ClassesGenericas.camposBase.DAO.table.CreateCommandSQLTable() + " WHERE NOME = '" + campo.Name_Field + "' AND CODIGOTABELA = " + CodigoTabela(tabela, codigoProjeto, ref x);
            tabela = null;

            DbDataReader reader = DataBase.Connection.Select(sentenca);
            if (reader != null)
            {
                if (reader.Read())
                {
                    codigo = int.Parse(reader["CODIGO"].ToString());
                    existe = true;
                }
                else
                {
                    codigo = DataBase.Connection.GetIncrement("CAMPOS");
                    existe = false;
                }
                reader.Close();
            }
            reader = null;

            return codigo;
        }

        /// <summary>
        /// Método que trata as tabelas
        /// </summary>
        /// <param name="projeto">Projeto ao qual a tabela pertence</param>
        /// <param name="tabelas">Tabelas a serem importadas para o projeto</param>
        private static void TratarTabelas(Model.MD_Projeto projeto, ref List<Model.Tabela> tabelas, ref BarraDeCarregamento barra)
        {
            Util.CL_Files.WriteOnTheLog("Importador.TratarTabelas()", Util.Global.TipoLog.DETALHADO);

            foreach (Model.Tabela t in tabelas)
            {
                barra.AvancaBarra(1);
                bool existe = false;
                int tableCodigo = CodigoTabela(t, projeto.DAO.Codigo, ref existe);

                Model.MD_Tabela tabela = new Model.MD_Tabela(tableCodigo, projeto.DAO.Codigo);
                tabela.DAO.Nome = t.nome;

                if (existe)
                {
                    tabela.DAO.Update();
                }
                else
                {
                    tabela.DAO.Insert();
                }
                tabela = null;
            }
        }

        /// <summary>
        /// Método que retorna o código da tabela
        /// </summary>
        /// <param name="tabela">Nome da tabela</param>
        /// <returns>Código da tabela</returns>
        public static int CodigoTabela(Model.Tabela tabela, int codigoProjeto, ref bool existe)
        {
            Util.CL_Files.WriteOnTheLog("Importador.CodigoTabela()", Util.Global.TipoLog.DETALHADO);

            int codigo = -1;
            string sentenca = ClassesGenericas.tabelaBase.DAO.table.CreateCommandSQLTable() + " WHERE NOME = '" + tabela.nome + "' AND PROJETO = " + codigoProjeto;
            

            DbDataReader reader = DataBase.Connection.Select(sentenca);
            if (reader != null)
            {
                if (reader.Read())
                {
                    codigo = int.Parse(reader["CODIGO"].ToString());
                    existe = true;    
                }
                else
                {
                    codigo = DataBase.Connection.GetIncrement("TABELA");
                    existe = false;
                }
                reader.Close();
            }
            reader = null;

            return codigo;
        }

        /// <summary>
        /// Método que copia os arquivos de exportação para importação
        /// </summary>
        public static void CopiaArquivos()
        {
            Util.CL_Files.WriteOnTheLog("Importador.CopiaArquivos()", Util.Global.TipoLog.DETALHADO);

            if (Directory.Exists(Global.app_importacao_directory))
                Directory.Delete(Global.app_importacao_directory, true);

            Directory.CreateDirectory(Global.app_importacao_directory);
            foreach(string file in Directory.GetFiles(Global.app_exportacao_directory))
            {
                FileInfo f = new FileInfo(file);
                File.Copy(file, Global.app_importacao_directory + f.Name);
            }
        }

    }
}
