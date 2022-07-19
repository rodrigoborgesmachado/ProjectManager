using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreate.Models
{
    class MontaParametrosInsert
    {
        public BaseClass daoClass { get; set; }

        /// <summary>
        /// Construtor principal da classe
        /// </summary>
        /// <param name="daoClass"></param>
        public MontaParametrosInsert(BaseClass daoClass)
        {
            this.daoClass = daoClass;
        }

        /// <summary>
        /// Método que monta os parâmetros do insert
        /// </summary>
        /// <returns></returns>
        public StringBuilder CriaParametrosInsert()
        {
            StringBuilder builder = new StringBuilder();

            List<Model.MD_Campos> campos = this.daoClass.Tabela.CamposDaTabela();

            int i = 0;
            foreach(Model.MD_Campos campo in campos)
            {
                if(i > 0)
                {
                    builder.Append("                ");
                }

                builder.Append($"{this.daoClass.RetornaNomePropriedade(campo.DAO.Nome)} = novo.{this.daoClass.RetornaNomePropriedade(campo.DAO.Nome)}");

                i++;
                if (i < campos.Count) builder.AppendLine(",");
                else builder.AppendLine();
            }

            return builder;
        }
    }
}
