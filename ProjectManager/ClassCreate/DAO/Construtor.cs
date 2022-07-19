using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreate.DAO
{
    class Construtor
    {
        public BaseClass daoClass { get; set; }

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="daoClass"></param>
        public Construtor(BaseClass daoClass)
        {
            this.daoClass = daoClass;
        }

        /// <summary>
        /// Método que monta os parâmetros de entrada do contrutor
        /// </summary>
        /// <returns></returns>
        public string MontaParametrosConstrutor()
        {
            string retorno = string.Empty;

            List<Model.MD_Campos> campos = this.daoClass.Tabela.CamposDaTabela().Where(c => c.DAO.PrimaryKey).ToList();

            bool first = true;
            campos.ForEach(campo =>
            {
                if (first) first = false;
                else retorno += ", ";
                retorno += $"{this.daoClass.MontaTipoCampo(campo)} {this.daoClass.RetornaNomeVariavel(campo.DAO.Nome)}";
            });

            return retorno;
        }

        /// <summary>
        /// Método que monta as igualdades dos parâmetros no construtor principal
        /// </summary>
        /// <returns></returns>
        public string MontaIgualdadesConstrutor()
        {
            StringBuilder builder = new StringBuilder();

            List<Model.MD_Campos> campos = this.daoClass.Tabela.CamposDaTabela().Where(c => c.DAO.PrimaryKey).ToList();

            campos.ForEach(campo =>
            {
                builder.Append($"this.{this.daoClass.RetornaNomePropriedade(campo.DAO.Nome)} = {this.daoClass.RetornaNomeVariavel(campo.DAO.Nome)};");
            });

            return builder.ToString();
        }
    }
}
