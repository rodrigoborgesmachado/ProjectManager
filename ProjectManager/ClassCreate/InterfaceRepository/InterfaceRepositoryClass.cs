using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreate.InterfaceRepository
{
    class InterfaceRepositoryClass : BaseClass
    {
        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="tabela"></param>
        public InterfaceRepositoryClass(Model.MD_Tabela tabela) : base(tabela)
        {

        }

        /// <summary>
        /// Método que faz a criação da base da classe
        /// </summary>
        /// <returns></returns>
        public override StringBuilder CriarBaseClasse()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("using DevtoolsAPI.Entity.Entidades.$[NAMESPACE];");
            builder.AppendLine("using System.Collections.Generic;");
            builder.AppendLine("");
            builder.AppendLine("namespace DevtoolsAPI.InterfaceRepository");
            builder.AppendLine("{");
            builder.AppendLine("    public interface $[NOMECLASSE]");
            builder.AppendLine("    {");
            builder.AppendLine("        /// <summary>");
            builder.AppendLine("        /// Método que busca a lista");
            builder.AppendLine("        /// </summary>");
            builder.AppendLine("        /// <returns></returns>");
            builder.AppendLine("        List<$[ENTIDADE]> Get();");
            builder.AppendLine("");
            builder.AppendLine("        /// <summary>");
            builder.AppendLine("        /// Método que busca o item");
            builder.AppendLine("        /// </summary>");
            builder.AppendLine("        /// <returns></returns>");
            builder.AppendLine("        $[ENTIDADE] Get($[CHAVEBUSCA]);");
            builder.AppendLine("");
            builder.AppendLine("        /// <summary>");
            builder.AppendLine("        /// Método que insere o item");
            builder.AppendLine("        /// </summary>");
            builder.AppendLine("        /// <param name=\"$[ENTIDADEVARIAVEL]\"></param>");
            builder.AppendLine("        /// <returns></returns>");
            builder.AppendLine("        $[ENTIDADE] Insere($[ENTIDADE] $[ENTIDADEVARIAVEL]);");
            builder.AppendLine("");
            builder.AppendLine("        /// <summary>");
            builder.AppendLine("        /// Método que atualiza o item");
            builder.AppendLine("        /// </summary>");
            builder.AppendLine("        /// <param name=\"$[ENTIDADEVARIAVEL]\"></param>");
            builder.AppendLine("        /// <returns></returns>");
            builder.AppendLine("        $[ENTIDADE] Atualiza($[ENTIDADE] $[ENTIDADEVARIAVEL]);");
            builder.AppendLine("");
            builder.AppendLine("        /// <summary>");
            builder.AppendLine("        /// Método que deleta o item");
            builder.AppendLine("        /// </summary>");
            builder.AppendLine("        /// <returns></returns>");
            builder.AppendLine("        bool Deleta($[CHAVEBUSCA]);");
            builder.AppendLine("    }");
            builder.AppendLine("}");

            return builder;
        }

        /// <summary>
        /// Método que cria a clase
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

                retorno = base.SalvaArquivo(Util.Global.app_classes_api_interface_repository_directory, RetornaNomeClasse(), texto, out mensagemErro);
            }
            catch (Exception e)
            {
                mensagemErro = $"Erro: {e.Message}";
                Util.CL_Files.WriteOnTheLog(mensagemErro, Util.Global.TipoLog.SIMPLES);
            }

            return retorno;
        }

        /// <summary>
        /// Método que cria o namespace
        /// </summary>
        /// <returns></returns>
        public override string CriarNameSpace()
        {
            return base.RetornaNomePropriedade(this.Tabela.DAO.Nome);
        }

        /// <summary>
        /// Método que monta o nome da classe
        /// </summary>
        /// <returns></returns>
        public override string RetornaNomeClasse()
        {
            return "I" + base.RetornaNomeClasse() + "Repository";
        }

        /// <summary>
        /// Método que monta o nome da variável
        /// </summary>
        /// <param name="nomeCampo"></param>
        /// <returns></returns>
        public override string RetornaNomeVariavel(string nomeCampo)
        {
            return RemoveSpecialCharacters(nomeCampo).ToLower();
        }

        /// <summary>
        /// Método que substitui os parâmetros
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
                Parametro = "$[ENTIDADE]",
                Valor = this.MontaNomeClasseEntidade()
            });

            retorno.Add(new KeyWords()
            {
                Parametro = "$[CHAVEBUSCA]",
                Valor = this.MontaParametrosVariaveis()
            });

            retorno.Add(new KeyWords()
            {
                Parametro = "$[ENTIDADEVARIAVEL]",
                Valor = this.RetornaNomeVariavel(this.MontaNomeClasseEntidade())
            });

            return retorno;
        }

        /// <summary>
        /// Método que monta os parâmetros das variáveis de busca
        /// </summary>
        /// <returns></returns>
        private string MontaParametrosVariaveis()
        {
            string retorno = new DAO.Construtor(this).MontaParametrosConstrutor().ToString();

            return retorno;
        }

        /// <summary>
        /// Método que monta o nome da classe da interface
        /// </summary>
        /// <returns></returns>
        private string MontaNomeClasseEntidade()
        {
            string retorno = new Entidade.EntidadeClass(this.Tabela).RetornaNomeClasse();

            return retorno;
        }
    }
}
