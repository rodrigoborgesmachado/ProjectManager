using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreate
{
    abstract class BaseClass
    {
        #region Atributos e Propriedades
        /// <summary>
        /// Projeto para criar as classes
        /// </summary>
        public Model.MD_Tabela Tabela { get; set; }

        #endregion Atributos e Propriedades

        #region Construtores

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="tabela"></param>
        public BaseClass(Model.MD_Tabela tabela)
        {
            this.Tabela = tabela;
        }

        #endregion Construtores

        #region Métodos

        /// <summary>
        /// Método que cria o corpo da classe
        /// </summary>
        /// <returns></returns>
        public abstract StringBuilder CriarBaseClasse();

        /// <summary>
        /// Método que cria os parâmetros
        /// </summary>
        /// <returns></returns>
        public abstract List<KeyWords> CriarParametros();

        /// <summary>
        /// Método que cria o nome do nameSpace
        /// </summary>
        /// <returns></returns>
        public abstract string CriarNameSpace();

        /// <summary>
        /// Método que cria a classe
        /// </summary>
        /// <param name="mensagemErro"></param>
        /// <returns></returns>
        public abstract bool CriarClasse(out string mensagemErro);

        /// <summary>
        /// Método que salva o arquivo
        /// </summary>
        /// <param name="path"></param>
        /// <param name="nomeArquivo"></param>
        /// <param name="mensagemErro"></param>
        /// <returns></returns>
        public bool SalvaArquivo(string path, string nomeArquivo, string texto, out string mensagemErro)
        {
            bool retorno = false;
            mensagemErro = string.Empty;

            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                path += "\\" + this.RetornaNomeClasse();
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                string caminhoFull = path + "\\" + nomeArquivo + ".cs";

                if (File.Exists(caminhoFull))
                {
                    File.Delete(caminhoFull);
                }

                File.WriteAllText(caminhoFull, texto);
                retorno = true;
            }
            catch(Exception e)
            {
                mensagemErro = $"Erro: {e.Message}";
                Util.CL_Files.WriteOnTheLog(mensagemErro, Util.Global.TipoLog.SIMPLES);
            }

            return retorno;
        }

        /// <summary>
        /// Método que faz as substituições dos parâmetros por seus respectivos valores
        /// </summary>
        /// <param name="texto"></param>
        /// <param name="parametros"></param>
        /// <param name="valores"></param>
        /// <returns></returns>
        public string SubstituiParametros(string texto, List<KeyWords> parametros)
        {
            int i = 0;
            parametros.ForEach(param => 
            {
                texto = texto.Replace(param.Parametro, param.Valor);
                i++;
            });

            return texto;
        }

        /// <summary>
        /// Método que remove os caracteres especiais de uma string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string RemoveSpecialCharacters(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Método que cria o nome da classe
        /// </summary>
        /// <param name="nomeClasse"></param>
        /// <returns></returns>
        public virtual string RetornaNomeClasse()
        {
            string temp = RemoveSpecialCharacters(this.Tabela.DAO.Nome);
            return temp[0].ToString().ToUpper() + temp.ToLower().Substring(1);
        }

        /// <summary>
        /// Método que monta o nome da variável
        /// </summary>
        /// <param name="nomeCampo"></param>
        /// <returns></returns>
        public virtual string RetornaNomeVariavel(string nomeCampo)
        {
            return "_" + RemoveSpecialCharacters(nomeCampo).ToLower();
        }

        /// <summary>
        /// Método que retorna o nome da propriedade
        /// </summary>
        /// <param name="nomePropriedade"></param>
        /// <returns></returns>
        public virtual string RetornaNomePropriedade(string nomePropriedade)
        {
            string temp = RemoveSpecialCharacters(nomePropriedade);
            return temp[0].ToString().ToUpper() + temp.ToLower().Substring(1);
        }

        /// <summary>
        /// Método que monta o tipo do campo
        /// </summary>
        /// <param name="campo"></param>
        /// <returns></returns>
        public string MontaTipoCampo(Model.MD_Campos campo)
        {
            string retorno;

            switch (campo.TipoNucleo()) 
            {
                case Util.Enumerator.DataType.CHAR:
                    retorno = "string";
                    break;
                case Util.Enumerator.DataType.STRING:
                    retorno = "string";
                    break;
                case Util.Enumerator.DataType.INT:
                    retorno = "int";
                    break;
                case Util.Enumerator.DataType.DATE:
                    retorno = "DateTime";
                    break;
                case Util.Enumerator.DataType.DECIMAL:
                    retorno = "decimal";
                    break;
                default:
                    retorno = "string";
                    break;
            }

            return retorno;
        }

        #endregion Métodos
    }
}
