using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regras
{
    public static class ModuloRelatorio
    {

        /// <summary>
        /// Método que cria o relatório do módulo
        /// </summary>
        /// <param name="modulo"></param>
        /// <returns>True - Cirado com sucesso; False - erro</returns>
        public static bool Criar(Model.MD_Projeto projeto)
        {
            bool retorno = true;

            try
            {
                string textoBase = string.Empty;
                textoBase = CriaBase();

                string textoModulos = string.Empty;

                foreach(Model.MD_Modulos modulo in projeto.GetModulosProjeto())
                {
                    textoModulos += TextoModulos(modulo);
                }

                textoBase = textoBase.Replace("#TEXTO", textoModulos);
                textoBase = textoBase.Replace("#NOMEMODULO", "Módulos");

                SalvarArquivo(textoBase, "Relatório de Módulos");
            }
            catch (Exception e)
            {
                Util.CL_Files.WriteOnTheLog("Error: " + e.Message, Util.Global.TipoLog.SIMPLES);
                retorno = false;
            }

            return retorno;
        }

        /// <summary>
        /// Método que cria o relatório do módulo
        /// </summary>
        /// <param name="modulo"></param>
        /// <returns>True - Cirado com sucesso; False - erro</returns>
        public static bool Criar(Model.MD_Modulos modulo)
        {
            bool retorno = true;

            try
            {
                string textoBase = string.Empty;
                textoBase = CriaBase();

                string textoModulos = string.Empty;
                textoModulos = TextoModulos(modulo);

                textoBase = textoBase.Replace("#TEXTO", textoModulos);
                textoBase = textoBase.Replace("#NOMEMODULO", modulo.DAO.NomeModulo);

                SalvarArquivo(textoBase, modulo.DAO.NomeModulo);
            }
            catch(Exception e)
            {
                Util.CL_Files.WriteOnTheLog("Error: " + e.Message, Util.Global.TipoLog.SIMPLES);
                retorno = false;
            }

            return retorno;
        }

        /// <summary>
        /// Método que salva o arquivo com o texto
        /// </summary>
        /// <param name="texto">Texto html para salvar o relatório</param>
        /// <param name="diretorio">Diretório para </param>
        private static void SalvarArquivo(string texto, string nomeModulo = null)
        {
            try
            {
                if (!Directory.Exists(Util.Global.app_rel_directory))
                {
                    Directory.CreateDirectory(Util.Global.app_rel_directory);
                }
                
                if (!Directory.Exists(Util.Global.app_Files_directory))
                {
                    Directory.CreateDirectory(Util.Global.app_Files_directory);
                }

                Util.CL_Files.CopyFile(Util.Global.app_Img_directory + "logonew.png", Util.Global.app_Files_directory + "logonew.png");

                if (string.IsNullOrEmpty(nomeModulo))
                {
                    nomeModulo = "relatorio";
                }

                string diretorio = Util.Global.app_rel_directory + nomeModulo + ".html";
                if (File.Exists(diretorio))
                {
                    File.Delete(diretorio);
                }

                File.AppendAllText(diretorio, texto);

                System.Diagnostics.Process.Start(diretorio);
            }
            catch (Exception e)
            {
                Util.CL_Files.WriteOnTheLog("Erro: " + e.Message, Util.Global.TipoLog.SIMPLES);
            }
        }

        /// <summary>
        /// Método que monta o texto do módulo
        /// </summary>
        /// <returns>String com o texto</returns>
        private static string TextoModulos(Model.MD_Modulos modulo)
        {
            string retorno = string.Empty;

            string nomeModulo = modulo.DAO.NomeModulo;
            string data = DateTime.Now.ToLongDateString();
            string numeroTabelas = modulo.Campos().Count.ToString();
            string descricao = modulo.DAO.Descricao;
            string passoPasso = modulo.DAO.SequenciaAbertura.Replace(":", "&rarr;");
            string tabelas = ResgataTabelas(modulo);

            retorno = "<div class=\"maincontent\"> " +
                        "    <table width=\"100%\" cellpadding=\"0\" cellspacing=\"0\" border=\"0\"> " +
                        "        <tbody> " +
                        "            <tr> " +
                        "                <td> " +
                        "                    <font size=\"+1\"> " +
                        "                    <b> " +
                        "                        Módulo - #NOMEMODULO " +
                        "                    </b> " +
                        "                    </font> " +
                        "                    <br> " +
                        "                    <font size=\"-1\" color=\"#777\"> " +
                        "                        #NUMEROTABELAS Campos envolvidos " +
                        "                    </font> " +
                        "                </td> " +
                        "                <td align=\"right\"><font size=\"-1\">#DATA</font></td> " +
                        "            </tr> " +
                        "        </tbody> " +
                        "    </table> " +
                        "    <br><br><br> " +
                        "    <table width=\"100%\" cellpadding=\"0\" cellspacing=\"0\" border=\"0\" class=\"message\"> " +
                        "        <tbody> " +
                        "            <tr> " +
                        "                <td><font size=\"-1\"><b>Descrição</b></font></td> " +
                        "                <td align=\"right\"></td> " +
                        "            </tr> " +
                        "            <tr> " +
                        "                <td colspan=\"2\"> " +
                        "                    <table width=\"100%\" cellpadding=\"12\" cellspacing=\"0\" border=\"0\"> " +
                        "                        <tbody> " +
                        "                            <tr> " +
                        "                                <td> " +
                        "                                    <div style=\"overflow: hidden;\"><font size=\"-1\"><div dir=\"ltr\">#DESCRICAO</font></div> " +
                        "                                </td> " +
                        "                            </tr> " +
                        "                        </tbody> " +
                        "                    </table> " +
                        "                </td> " +
                        "            </tr> " +
                        "        </tbody> " +
                        "    </table> " +
                        "    <br><br><br> " +
                        "    <table width=\"100%\" cellpadding=\"0\" cellspacing=\"0\" border=\"0\" class=\"message\"> " +
                        "        <tbody> " +
                        "            <tr> " +
                        "                <td><font size=\"-1\"><b>Passo a Passo:</b></font></td> " +
                        "            </tr> " +
                        "            <tr> " +
                        "                <td colspan=\"2\"> " +
                        "                    <table width=\"100%\" cellpadding=\"12\" cellspacing=\"0\" border=\"0\"> " +
                        "                        <tbody> " +
                        "                            <tr> " +
                        "                                <td> " +
                        "                                    <div style=\"overflow: hidden;\"><font size=\"-1\"><div dir=\"ltr\">#PASSOAPASSO</font></div> " +
                        "                                </td> " +
                        "                            </tr> " +
                        "                        </tbody> " +
                        "                    </table> " +
                        "                </td> " +
                        "            </tr> " +
                        "        </tbody> " +
                        "    </table> " +
                        "    <br><br><br> " +
                        "    <table width=\"100%\" cellpadding=\"0\" cellspacing=\"0\" border=\"0\" class=\"message\"> " +
                        "        <tbody> " +
                        "            <tr> " +
                        "                <td><font size=\"-1\"><b>Campos utilizadas no módulo:</b></font></td> " +
                        "            </tr> " +
                        "            #TABELAS " +
                        "        </tbody> " +
                        "    </table> " +
                        "    <br><br><br><hr> " +
                        "</div> ";

            retorno = retorno.Replace("#NOMEMODULO", nomeModulo);
            retorno = retorno.Replace("#NUMEROTABELAS", numeroTabelas);
            retorno = retorno.Replace("#DATA", data);
            retorno = retorno.Replace("#DESCRICAO", descricao);
            retorno = retorno.Replace("#PASSOAPASSO", passoPasso);
            retorno = retorno.Replace("#TABELAS", tabelas);

            return retorno;
        }

        /// <summary>
        /// Método que monta o html das tabelas
        /// </summary>
        /// <param name="modulo">Módulo para capturar as tabelas</param>
        /// <returns>string com html para montar o relatório</returns>
        private static string ResgataTabelas(Model.MD_Modulos modulo)
        {
            string retorno = string.Empty;

            string _base =  "<tr> " +
                            "    <td colspan=\"2\"> " +
                            "        <table width=\"100%\" cellpadding=\"12\" cellspacing=\"0\" border=\"0\"> " +
                            "            <tbody> " +
                            "                <tr> " +
                            "                    <td> " +
                            "                        <div style=\"overflow: hidden;\"><font size=\"-1\"><div dir=\"ltr\">#TABELA</font></div> " +
                            "                    </td> " +
                            "                </tr> " +
                            "            </tbody> " +
                            "        </table> " +
                            "    </td> " +
                            "</tr> ";

            foreach (Model.MD_Campos campo in modulo.Campos())
            {
                retorno += _base.Replace("#TABELA", "<b>" +campo.DAO.Tabela.Nome + "." + campo.DAO.Nome + "</b><br>Tabela: " + campo.DAO.Tabela.Descricao + "<br>Campo: " + campo.DAO.Comentario);
            }

            return retorno;
        }

        /// <summary>
        /// Método que cria a base do relatório
        /// </summary>
        /// <returns>texto com a base do relatório</returns>
        private static string CriaBase()
        {
            string retorno = string.Empty;

            retorno = " <!DOCTYPE html PUBLIC \" -//W3C//DTD HTML 4.01//EN\" \"https://www.w3.org/TR/html4/strict.dtd\"> " +
                      " <html lang=\"pt-BR\"> " +
                      " <head> " +
                      "     <meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\"> " +
                      "     <style type=\"text/css\" nonce=\"\"> " +
                      "         body, " +
                      "         td, " +
                      "         div, " +
                      "         p, " +
                      "         a, " +
                      "         input { " +
                      "             font-family: arial, sans-serif; " +
                      "         } " +
                      "     </style> " +
                      "     <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\"> " +
                      "     <title>Módulo - #NOMEMODULO</title> " +
                      "     <style type=\"text/css\" nonce=\"\"> " +
                      "         body, " +
                      "         td { " +
                      "             font-size: 13px " +
                      "         } " +
                      "          " +
                      "         a:link, " +
                      "         a:active { " +
                      "             color: #1155CC; " +
                      "             text-decoration: none " +
                      "         } " +
                      "          " +
                      "         a:hover { " +
                      "             text-decoration: underline; " +
                      "             cursor: pointer " +
                      "         } " +
                      "          " +
                      "         a:visited { " +
                      "             color: ##6611CC " +
                      "         } " +
                      "          " +
                      "         img { " +
                      "             border: 0px " +
                      "         } " +
                      "          " +
                      "         pre { " +
                      "             white-space: pre; " +
                      "             white-space: -moz-pre-wrap; " +
                      "             white-space: -o-pre-wrap; " +
                      "             white-space: pre-wrap; " +
                      "             word-wrap: break-word; " +
                      "             max-width: 800px; " +
                      "             overflow: auto; " +
                      "         } " +
                      "          " +
                      "         .logo { " +
                      "             left: -7px; " +
                      "             position: relative; " +
                      "         } " +
                      "     </style> " +
                      "     <style type=\"text/css\"></style> " +
                      " </head> " +
                      "  " +
                      " <body> " +
                      "     <div class=\"bodycontainer\" align=\"justify\"> " +
                      "         <table width=\"100%\" cellpadding=\"0\" cellspacing=\"0\" border=\"0\"> " +
                      "             <tbody> " +
                      "                 <tr height=\"14px\"> " +
                      "                     <td width=\"143\"> " +
                      "                         <img src=\"./files/logonew.png\" width=\"100\" height=\"60\" alt=\"Gmail\" class=\"logo\">  " +
                      "                         <b>SunSale System</b> " +
                      "                     </td> " +
                      "                     <td align=\"right\"><font size=\"-1\" color=\"#777\"> " +
                      "                         <b> " +
                      "                             SunSale System &lt;sunsalesystem@gmail.com&gt; " +
                      "                         </b> " +
                      "                         </font> " +
                      "                     </td> " +
                      "                 </tr> " +
                      "             </tbody> " +
                      "         </table> " +
                      "         <br> " +
                      "         <hr> " +
                      "		        #TEXTO" +
                      "          " +
                      "     </div> " +
                      "     <script type=\"text/javascript\" nonce=\"\"> " +
                      "         document.body.onload = function() { " +
                      " 			document.body.offsetHeight; " +
                      "             window.print() " +
                      "         }; " +
                      "     </script> " +
                      "     </body> " +
                      " </html> ";

            return retorno;
        }
    }
}
