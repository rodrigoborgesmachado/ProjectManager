using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreate.DAO
{
    class CamposConstrutorClasse
    {
        public DAOClass daoClass { get; set; }

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="daoClass"></param>
        public CamposConstrutorClasse(DAOClass daoClass)
        {
            this.daoClass = daoClass;
        }

        /// <summary>
        /// Método que monta os campos do construtor principal
        /// </summary>
        /// <returns></returns>
        public StringBuilder MontaCamposConstrutorPrincipal()
        {
            StringBuilder builder = new StringBuilder();

            foreach(Model.MD_Campos campo in this.daoClass.Tabela.CamposDaTabela())
            {
                builder.AppendLine($"            this.table.Fields_Table.Add(new MDN_Campo(\"{campo.DAO.Nome.ToUpper()}\", {(campo.DAO.NotNull ? "true" : "false")}, {MontaDataType(campo)}, {MontaDefault(campo)}, {(campo.DAO.PrimaryKey ? "true" : "false")}, {(campo.DAO.Unique ? "true" : "false")}, {campo.DAO.Tamanho}, {campo.DAO.Precisao}));");
            }

            return builder;
        }

        /// <summary>
        /// Método que monta o data type
        /// </summary>
        /// <param name="campo"></param>
        /// <returns></returns>
        private string MontaDataType(Model.MD_Campos campo)
        {
            string retorno = string.Empty;

            switch (campo.TipoNucleo()) 
            {
                case Util.Enumerator.DataType.CHAR:
                    retorno = "Util.Enumerator.DataType.STRING";
                    break;
                case Util.Enumerator.DataType.DATE:
                    retorno = "Util.Enumerator.DataType.DATE";
                    break;
                case Util.Enumerator.DataType.DECIMAL:
                    retorno = "Util.Enumerator.DataType.DECIMAL";
                    break;
                case Util.Enumerator.DataType.INT:
                    retorno = "Util.Enumerator.DataType.INT";
                    break;
                case Util.Enumerator.DataType.STRING:
                    retorno = "Util.Enumerator.DataType.STRING";
                    break;
            }

            return retorno;
        }

        /// <summary>
        /// Método que cria o default
        /// </summary>
        /// <param name="campo"></param>
        /// <returns></returns>
        private string MontaDefault(Model.MD_Campos campo)
        {
            string retorno = string.Empty;

            if (!campo.DAO.NotNull)
            {
                return "null";
            }
            if(campo.DAO.Default == null)
            {
                return "\"\"";
            }

            switch (campo.TipoNucleo())
            {
                case Util.Enumerator.DataType.CHAR:
                    retorno = $"\"{campo.DAO.Default?.ToString()}\"";
                    break;
                case Util.Enumerator.DataType.DATE:
                    retorno = $"\"GETDATE()\"";
                    break;
                case Util.Enumerator.DataType.DECIMAL:
                    retorno = $"{campo.DAO.Default?.ToString()}";
                    break;
                case Util.Enumerator.DataType.INT:
                    retorno = $"{campo.DAO.Default?.ToString()}";
                    break;
                case Util.Enumerator.DataType.STRING:
                    retorno = $"\"{campo.DAO.Default?.ToString()}\"";
                    break;
            }

            return retorno;
        }
    }
}
