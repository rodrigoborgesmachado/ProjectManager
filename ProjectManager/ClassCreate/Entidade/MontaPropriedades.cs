using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreate.Entidade
{
    class MontaPropriedades
    {
        public BaseClass daoClass { get; set; }

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="daoClass"></param>
        public MontaPropriedades(BaseClass daoClass)
        {
            this.daoClass = daoClass;
        }

        /// <summary>
        /// Método que monta as propriedades
        /// </summary>
        /// <returns></returns>
        public StringBuilder CriaPropriedades()
        {
            StringBuilder builder = new StringBuilder();

            foreach(Model.MD_Campos campo in this.daoClass.Tabela.CamposDaTabela())
            {
                builder.AppendLine($"        public {MontaTipoNome(campo)} " + "{ get; set; }");
            }

            return builder;
        }

        /// <summary>
        /// Método que cria o tipo e o nome do campo
        /// </summary>
        /// <param name="campo"></param>
        /// <returns></returns>
        private string MontaTipoNome(Model.MD_Campos campo)
        {
            string retorno = string.Empty;

            switch (campo.TipoNucleo())
            {
                case Util.Enumerator.DataType.CHAR:
                    retorno += $" string {this.daoClass.RetornaNomePropriedade(campo.DAO.Nome)}";
                    break;
                case Util.Enumerator.DataType.STRING:
                    retorno += $" string {this.daoClass.RetornaNomePropriedade(campo.DAO.Nome)}";
                    break;
                case Util.Enumerator.DataType.INT:
                    retorno += $" int {this.daoClass.RetornaNomePropriedade(campo.DAO.Nome)}";
                    break;
                case Util.Enumerator.DataType.DATE:
                    retorno += $" DateTime {this.daoClass.RetornaNomePropriedade(campo.DAO.Nome)}";
                    break;
                case Util.Enumerator.DataType.DECIMAL:
                    retorno += $" decimal {this.daoClass.RetornaNomePropriedade(campo.DAO.Nome)}";
                    break;
            }

            return retorno;
        }
    }
}
