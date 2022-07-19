using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreate.Models
{
    class MontaDeDAOParaEntidade
    {
        public BaseClass daoClass { get; set; }

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="daoClass"></param>
        public MontaDeDAOParaEntidade(BaseClass daoClass)
        {
            this.daoClass = daoClass;
        }

        /// <summary>
        /// Método que monta os parâmetros do insert
        /// </summary>
        /// <returns></returns>
        public StringBuilder CriaParametros()
        {
            StringBuilder builder = new StringBuilder();

            List<Model.MD_Campos> campos = this.daoClass.Tabela.CamposDaTabela();

            int i = 0;
            foreach(Model.MD_Campos campo in campos)
            {
                if(i > 0)
                {
                    builder.Append("                    ");
                }

                builder.Append($"dao.{this.daoClass.RetornaNomePropriedade(campo.DAO.Nome)} = ");

                switch (campo.TipoNucleo())
                {
                    case Util.Enumerator.DataType.CHAR:
                        builder.Append($"reader[{campo.DAO.Nome.ToUpper()}].ToString()");
                        break;
                    case Util.Enumerator.DataType.STRING:
                        builder.Append($"reader[{campo.DAO.Nome.ToUpper()}].ToString()");
                        break;
                    case Util.Enumerator.DataType.INT:
                        builder.Append($"int.Parse(reader[{campo.DAO.Nome.ToUpper()}].ToString())");
                        break;
                    case Util.Enumerator.DataType.DATE:
                        builder.Append($"DateTime.Parse(reader[{campo.DAO.Nome.ToUpper()}].ToString())");
                        break;
                    case Util.Enumerator.DataType.DECIMAL:
                        builder.Append($"decimal.Parse(reader[{campo.DAO.Nome.ToUpper()}].ToString())");
                        break;
                }

                i++;
                if (i < campos.Count) builder.AppendLine(",");
                else builder.AppendLine();
            }

            return builder;
        }
    }
}
