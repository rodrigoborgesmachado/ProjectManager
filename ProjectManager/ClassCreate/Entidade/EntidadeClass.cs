using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreate.Entidade
{
    class EntidadeClass : BaseClass
    {
        public EntidadeClass(Model.MD_Tabela tabela) : base(tabela)
        {

        }

        /// <summary>
        /// Método que cria a base da classe
        /// </summary>
        /// <returns></returns>
        public override StringBuilder CriarBaseClasse()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("using System;");
            builder.AppendLine("");
            builder.AppendLine("namespace DevtoolsAPI.Entity.Entidades.$[NAMESPACE]");
            builder.AppendLine("{");
            builder.AppendLine("    public class $[NOMECLASSE]");
            builder.AppendLine("    {");
            builder.AppendLine("$[PROPRIEDADES]");
            builder.AppendLine("    }");
            builder.AppendLine("}");

            return builder;
        }

        /// <summary>
        /// Método que cria a classe
        /// </summary>
        /// <param name="mensagemErro"></param>
        /// <returns></returns>
        public override bool CriarClasse(out string mensagemErro)
        {
            bool retorno = false;

            try
            {
                StringBuilder builder = this.CriarBaseClasse();
                List<KeyWords> parametros = this.CriarParametros();
                string texto = this.SubstituiParametros(builder.ToString(), parametros);

                retorno = base.SalvaArquivo(Util.Global.app_classes_api_entidade_directory, RetornaNomeClasse(), texto, out mensagemErro);
            }
            catch (Exception e)
            {
                mensagemErro = $"Erro: {e.Message}";
                Util.CL_Files.WriteOnTheLog(mensagemErro, Util.Global.TipoLog.SIMPLES);
            }

            return retorno;
        }

        /// <summary>
        /// Método que cria o nome do namespace
        /// </summary>
        /// <returns></returns>
        public override string CriarNameSpace()
        {
            return base.RetornaNomePropriedade(this.Tabela.DAO.Nome);
        }

        /// <summary>
        /// Método que cria os parâmetros
        /// </summary>
        /// <returns></returns>
        public override List<KeyWords> CriarParametros()
        {
            List<KeyWords> retorno = new List<KeyWords>();

            retorno.Add(new KeyWords()
            {
                Parametro = "$[NAMESPACE]",
                Valor = this.CriarNameSpace()
            });

            retorno.Add(new KeyWords()
            {
                Parametro = "$[NOMECLASSE]",
                Valor = this.RetornaNomeClasse()
            });

            retorno.Add(new KeyWords()
            {
                Parametro = "$[PROPRIEDADES]",
                Valor = this.MontaPropriedades()
            });

            return retorno;
        }

        /// <summary>
        /// Método que monta as propriedades
        /// </summary>
        /// <returns></returns>
        private string MontaPropriedades()
        {
            string retorno = new MontaPropriedades(this).CriaPropriedades().ToString();

            return retorno;
        }
    }
}
