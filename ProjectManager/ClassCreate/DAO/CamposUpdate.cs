using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreate.DAO
{
    class CamposUpdate
    {
        public DAOClass daoClass { get; set; }

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="daoClass"></param>
        public CamposUpdate(DAOClass daoClass)
        {
            this.daoClass = daoClass;
        }

        /// <summary>
        /// Método que monta os campos do update
        /// </summary>
        /// <returns></returns>
        public StringBuilder MontaCamposUpdate()
        {
            StringBuilder builder = new StringBuilder();

            List<Model.MD_Campos> campos = this.daoClass.Tabela.CamposDaTabela().Where(c => !c.DAO.PrimaryKey).ToList();

            int i = 0;
            foreach (Model.MD_Campos campo in campos)
            {
                if (i != 0) builder.Append("                       ");

                builder.Append($"$\"{campo.DAO.Nome.ToUpper()} = ");

                if (!campo.DAO.NotNull)
                {
                    switch (campo.TipoNucleo())
                    {
                        case Util.Enumerator.DataType.CHAR:
                            builder.Append("{(string.IsNullOrEmpty(this." + this.daoClass.RetornaNomePropriedade(campo.DAO.Nome) + ") ? \"NULL\" : $\"'{this." + this.daoClass.RetornaNomePropriedade(campo.DAO.Nome) + "}'\") }\"");
                            break;
                        case Util.Enumerator.DataType.STRING:
                            builder.Append("{(string.IsNullOrEmpty(this." + this.daoClass.RetornaNomePropriedade(campo.DAO.Nome) + ") ? \"NULL\" : $\"'{this." + this.daoClass.RetornaNomePropriedade(campo.DAO.Nome) + "}'\") }\"");
                            break;
                        case Util.Enumerator.DataType.INT:
                            builder.Append("{(this." + this.daoClass.RetornaNomePropriedade(campo.DAO.Nome) + " == int.MinValue ? \"NULL\" : $\"{this." + this.daoClass.RetornaNomePropriedade(campo.DAO.Nome) + "}\") }\"");
                            break;
                        case Util.Enumerator.DataType.DATE:
                            builder.Append("{(this." + this.daoClass.RetornaNomePropriedade(campo.DAO.Nome) + " == DateTime.MinValue ? \"NULL\" : $\"'{this.MontaStringDateTimeFromDateTime(this." + this.daoClass.RetornaNomePropriedade(campo.DAO.Nome) + ")}'\")}\"");
                            break;
                        case Util.Enumerator.DataType.DECIMAL:
                            builder.Append("{(this." + this.daoClass.RetornaNomePropriedade(campo.DAO.Nome) + " == decimal.MinValue ? \"NULL\" : $\"{this." + this.daoClass.RetornaNomePropriedade(campo.DAO.Nome) + "}\") }\"");
                            break;
                    }
                }
                else
                {
                    switch (campo.TipoNucleo())
                    {
                        case Util.Enumerator.DataType.CHAR:
                            builder.Append(" = $\"'{this." + this.daoClass.RetornaNomePropriedade(campo.DAO.Nome) +"}'\"");
                            break;
                        case Util.Enumerator.DataType.STRING:
                            builder.Append(" = $\"'{this." + this.daoClass.RetornaNomePropriedade(campo.DAO.Nome) +"}'\"");
                            break;
                        case Util.Enumerator.DataType.INT:
                            builder.Append(" = $\"{this." + this.daoClass.RetornaNomePropriedade(campo.DAO.Nome) +"}\"");
                            break;
                        case Util.Enumerator.DataType.DATE:
                            builder.Append(" = $\"'{this.MontaStringDateTimeFromDateTime(this." + this.daoClass.RetornaNomePropriedade(campo.DAO.Nome) + ")}'\"");
                            break;
                        case Util.Enumerator.DataType.DECIMAL:
                            builder.Append(" = $\"{this." + this.daoClass.RetornaNomePropriedade(campo.DAO.Nome) +"}\"");
                            break;
                    }
                }

                i++;
                if (i < campos.Count)
                {
                    builder.AppendLine(" + \", \" + ");
                }
                else
                {
                    builder.Append(" + ");
                }
            }

            return builder;
        }
    }
}
