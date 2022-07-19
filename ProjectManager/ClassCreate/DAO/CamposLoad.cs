using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreate.DAO
{
    class CamposLoad
    {
        public DAOClass daoClass { get; set; }

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="daoClass"></param>
        public CamposLoad(DAOClass daoClass)
        {
            this.daoClass = daoClass;
        }

        /// <summary>
        /// Método que monta os campos de igualdade
        /// </summary>
        /// <returns></returns>
        public StringBuilder MontaCampos()
        {
            StringBuilder builder = new StringBuilder();

            List<Model.MD_Campos> campos = this.daoClass.Tabela.CamposDaTabela().Where(c => !c.DAO.PrimaryKey).ToList();

            bool first = true;
            campos.ForEach(campo =>
            {
                if (first) first = false;
                else builder.Append("                ");

                switch (campo.TipoNucleo())
                {
                    case Util.Enumerator.DataType.CHAR:
                        builder.AppendLine($"this.{this.daoClass.RetornaNomePropriedade(campo.DAO.Nome)} = reader[\"{campo.DAO.Nome.ToUpper()}\"].ToString();");
                        break;
                    case Util.Enumerator.DataType.STRING:
                     builder.AppendLine($"this.{this.daoClass.RetornaNomePropriedade(campo.DAO.Nome)} = reader[\"{campo.DAO.Nome.ToUpper()}\"].ToString();");
                        break;
                    case Util.Enumerator.DataType.INT:
                     builder.AppendLine($"int.TryParse(reader[\"{campo.DAO.Nome.ToUpper()}\"].ToString(), out this.{this.daoClass.RetornaNomeVariavel(campo.DAO.Nome)});");
                        break;
                    case Util.Enumerator.DataType.DATE:
                        builder.AppendLine($"DateTime.TryParse(reader[\"{campo.DAO.Nome.ToUpper()}\"].ToString(), out this.{this.daoClass.RetornaNomeVariavel(campo.DAO.Nome)});");
                        break;
                    case Util.Enumerator.DataType.DECIMAL:
                        builder.AppendLine($"decimal.TryParse(reader[\"{campo.DAO.Nome.ToUpper()}\"].ToString(), out this.{this.daoClass.RetornaNomeVariavel(campo.DAO.Nome)});");
                        break;
                }
            });

            return builder;
        }
    }
}
