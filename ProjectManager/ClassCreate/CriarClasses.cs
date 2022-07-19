using ClassCreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCreate
{
    class CriarClasses
    {
        /// <summary>
        /// Método que cria as classes
        /// </summary>
        /// <param name="tabela"></param>
        /// <param name="mensagemErro"></param>
        /// <returns></returns>
        public static bool Criar(Model.MD_Tabela tabela, out string mensagemErro)
        {
            bool retorno = true;

            try
            {
                DAO.DAOClass dAOClass = new DAO.DAOClass(tabela);
                retorno &= dAOClass.CriarClasse(out mensagemErro);

                Models.ModelClass modelClass = new Models.ModelClass(tabela);
                retorno &= modelClass.CriarClasse(out mensagemErro);

                Entidade.EntidadeClass entidadeClass = new Entidade.EntidadeClass(tabela);
                retorno &= entidadeClass.CriarClasse(out mensagemErro);

                InterfaceRepository.InterfaceRepositoryClass interfaceRepositoryClass = new InterfaceRepository.InterfaceRepositoryClass(tabela);
                retorno &= interfaceRepositoryClass.CriarClasse(out mensagemErro);

                Repository.RepositoryClass repositoryClass = new Repository.RepositoryClass(tabela);
                retorno &= repositoryClass.CriarClasse(out mensagemErro);

                Controller.ControllerClass controllerClass = new Controller.ControllerClass(tabela);
                retorno &= controllerClass.CriarClasse(out mensagemErro);
            }
            catch (Exception ex)
            {
                mensagemErro = "Error: " + ex.Message;
                Util.CL_Files.WriteOnTheLog("Error: " + ex.Message, Util.Global.TipoLog.SIMPLES);
                retorno = false;
            }

            return retorno;
        }
    }
}
