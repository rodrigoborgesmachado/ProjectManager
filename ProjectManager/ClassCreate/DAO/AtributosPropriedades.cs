using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreate.DAO
{
    class AtributosPropriedades
    {
        public DAOClass daoClass { get; set; }

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="daoClass"></param>
        public AtributosPropriedades(DAOClass daoClass)
        {
            this.daoClass = daoClass;
        }

        /// <summary>
        /// Método que cria os atributos e as propriedades
        /// </summary>
        /// <returns></returns>
        public StringBuilder MontaAtributosPropriedades()
        {
            StringBuilder builder = new StringBuilder();

            List<Model.MD_Campos> campos = daoClass.Tabela.CamposDaTabela();

            bool first = true;
            foreach(Model.MD_Campos campo in campos)
            {
                if (first)
                {
                    first = false;
                }
                else
                {
                    builder.AppendLine();
                }

                builder.AppendLine($"		private {daoClass.MontaTipoCampo(campo)} {daoClass.RetornaNomeVariavel(campo.DAO.Nome)};");
                builder.AppendLine("		/// <summary>");
                builder.AppendLine($"		/// [{campo.DAO.Nome.ToUpper()}] {campo.DAO.Comentario}");
                builder.AppendLine("		/// <summary>");
                builder.AppendLine($"		public {daoClass.MontaTipoCampo(campo)} {daoClass.RetornaNomePropriedade(campo.DAO.Nome)}");
                builder.AppendLine("		{");
                builder.AppendLine("		    get");
                builder.AppendLine("		    {");
                builder.AppendLine($"		        return this.{daoClass.RetornaNomeVariavel(campo.DAO.Nome)};");
                builder.AppendLine("		    }");
                builder.AppendLine("		    set");
                builder.AppendLine("		    {");
                builder.AppendLine($"		        this.{daoClass.RetornaNomeVariavel(campo.DAO.Nome)} = value;");
                builder.AppendLine("		    }");
                builder.AppendLine("		}");
            }

            return builder;
        }
    }
}
