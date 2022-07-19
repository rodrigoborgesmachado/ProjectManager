using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreate.DAO
{
    class WhereChavesPrimarias
    {
        public BaseClass daoClass { get; set; }

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="daoClass"></param>
        public WhereChavesPrimarias(BaseClass daoClass)
        {
            this.daoClass = daoClass;
        }

        /// <summary>
        /// Método que monta o where das chaves primárias
        /// </summary>
        /// <returns></returns>
        public string MontaWhereChavePrimaria()
        {
            string retorno = string.Empty;

            List<Model.MD_Campos> campos = this.daoClass.Tabela.CamposDaTabela().Where(c => c.DAO.PrimaryKey).ToList();

            bool first = true;
            foreach (Model.MD_Campos campo in campos)
            {
                if (first) first = false;
                else retorno += $" AND ";

                switch (campo.TipoNucleo())
                {
                    case Util.Enumerator.DataType.CHAR:
                        retorno += campo.DAO.Nome.ToUpper() + " = '{this." + this.daoClass.RetornaNomePropriedade(campo.DAO.Nome) + "}'";
                        break;
                    case Util.Enumerator.DataType.STRING:
                        retorno += campo.DAO.Nome.ToUpper() + " = '{this." + this.daoClass.RetornaNomePropriedade(campo.DAO.Nome) + "}'";
                        break;
                    case Util.Enumerator.DataType.INT:
                        retorno += campo.DAO.Nome.ToUpper() + " = {this." + this.daoClass.RetornaNomePropriedade(campo.DAO.Nome) + "}";
                        break;
                    case Util.Enumerator.DataType.DATE:
                        retorno += campo.DAO.Nome.ToUpper() + " = {this.MontaStringDateTimeFromDateTime(this." + this.daoClass.RetornaNomePropriedade(campo.DAO.Nome) + ")}";
                        break;
                    case Util.Enumerator.DataType.DECIMAL:
                        retorno += campo.DAO.Nome.ToUpper() + " = {this." + this.daoClass.RetornaNomePropriedade(campo.DAO.Nome) + "}";
                        break;
                }

            }

            return retorno;
        }

    }
}
