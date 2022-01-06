using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regras
{
    public static class TesteRelatorio
    {

        /// <summary>
        /// Método que cria o relatório de teste
        /// </summary>
        /// <param name="projeto">Projeto a capturar os testes</param>
        /// <returns>True - criado com sucesso; False - erro</returns>
        public static bool Criar(Model.MD_Projeto projeto)
        {
            bool retorno = true;

            try
            {
                string html = MontarBase();
                string texto = string.Empty;

                foreach(Model.MD_Teste teste in projeto.GetTestesProjeto())
                {
                    texto += RelatorioTeste(teste);
                    Model.MD_Modulos modulo = new Model.MD_Modulos(teste.DAO.Codigomodulo, teste.DAO.CodigoProjeto);

                    texto = texto.Replace("#NOMEMODULO", modulo.DAO.NomeModulo).Replace("#DATA", teste.DAO.Datateste).Replace("#NUMEROCAMPOS", modulo.Campos().Count.ToString()).Replace("#DESCRICAOMODULO", modulo.DAO.Descricao).Replace("#PASSOAPASSO", modulo.DAO.SequenciaAbertura).Replace("#DESCRICAODOSTESTES", teste.DAO.Descricao);
                }

                html = html.Replace("#TEXTO", texto);

                SalvarArquivo(html, "relatorio");
            }
            catch (Exception e)
            {
                Util.CL_Files.WriteOnTheLog("Error: " + e.Message, Util.Global.TipoLog.SIMPLES);
                retorno = false;
            }

            return retorno;
        }

        /// <summary>
        /// Método que salva o arquivo de relatório
        /// </summary>
        /// <param name="texto">Texto com html de relatório</param>
        private static void SalvarArquivo(string texto, string nome)
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

            if (File.Exists(Util.Global.app_rel_directory + nome + ".html"))
            {
                File.Delete(Util.Global.app_rel_directory + nome + ".html");
            }

            File.AppendAllText(Util.Global.app_rel_directory + nome + ".html", texto);
            System.Diagnostics.Process.Start(Util.Global.app_rel_directory + nome + ".html");

        }

        /// <summary>
        /// Método que cria o relatório de teste
        /// </summary>
        /// <param name="teste">Teste a ser criado o relatório</param>
        /// <returns>True - criado com sucesso; False - erro</returns>
        public static bool Criar(Model.MD_Teste teste)
        {
            bool retorno = true;

            try
            {
                string html = MontarBase();

                Model.MD_Modulos modulo = new Model.MD_Modulos(teste.DAO.Codigomodulo, teste.DAO.CodigoProjeto);

                html = html.Replace("#TEXTO", RelatorioTeste(teste)).Replace("#NOMEMODULO", modulo.DAO.NomeModulo).Replace("#DATA", teste.DAO.Datateste).Replace("#NUMEROCAMPOS", modulo.Campos().Count.ToString()).Replace("#DESCRICAOMODULO", modulo.DAO.Descricao).Replace("#PASSOAPASSO", modulo.DAO.SequenciaAbertura).Replace("#DESCRICAODOSTESTES", teste.DAO.Descricao);
                SalvarArquivo(html, modulo.DAO.NomeModulo);

            }
            catch (Exception e)
            {
                Util.CL_Files.WriteOnTheLog("Error: " + e.Message, Util.Global.TipoLog.SIMPLES);
                retorno = false;
            }

            return retorno;
        }

        /// <summary>
        /// Método que monta o relatório de teste
        /// </summary>
        /// <returns></returns>
        private static string RelatorioTeste(Model.MD_Teste teste)
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("        <div class=\"maincontent\">");
            builder.AppendLine("            <table width=\"100%\" cellpadding=\"0\" cellspacing=\"0\" border=\"0\">");
            builder.AppendLine("                <tbody>");
            builder.AppendLine("                    <tr>");
            builder.AppendLine("                        <td> ");
            builder.AppendLine("                            <font size=\"+1\">");
            builder.AppendLine("                                <b>Módulo - #NOMEMODULO</b>");
            builder.AppendLine("                            </font>");
            builder.AppendLine("                            <br>");
            builder.AppendLine("                            <font size=\"-1\" color=\"#777\">");
            builder.AppendLine("                                #NUMEROCAMPOS Campos envolvidos");
            builder.AppendLine("                            </font> ");
            builder.AppendLine("                        </td>");
            builder.AppendLine("                        <td align=\"right\">");
            builder.AppendLine("                            <font size=\"-1\">");
            builder.AppendLine("                                #DATA");
            builder.AppendLine("                            </font>");
            builder.AppendLine("                        </td>");
            builder.AppendLine("                    </tr>");
            builder.AppendLine("                </tbody>");
            builder.AppendLine("            </table>");
            builder.AppendLine("            <br>");
            builder.AppendLine("            <br>");
            builder.AppendLine("            <br>");
            builder.AppendLine("            <table width=\"100%\" cellpadding=\"0\" cellspacing=\"0\" border=\"0\" class=\"message\">");
            builder.AppendLine("                <tbody>");
            builder.AppendLine("                    <tr>");
            builder.AppendLine("                        <td>");
            builder.AppendLine("                            <font size=\"-1\">");
            builder.AppendLine("                                <b>Descrição do Módulo</b>");
            builder.AppendLine("                            </font>");
            builder.AppendLine("                        </td>");
            builder.AppendLine("                        <td align=\"right\">");
            builder.AppendLine("");
            builder.AppendLine("                        </td>");
            builder.AppendLine("                    </tr>");
            builder.AppendLine("                    <tr>");
            builder.AppendLine("                        <td colspan=\"2\">");
            builder.AppendLine("                            <table width=\"100%\" cellpadding=\"12\" cellspacing=\"0\" border=\"0\">");
            builder.AppendLine("                                <tbody>");
            builder.AppendLine("                                    <tr>");
            builder.AppendLine("                                        <td>");
            builder.AppendLine("                                            <div style=\"overflow: hidden;\">");
            builder.AppendLine("                                                <font size=\"-1\">");
            builder.AppendLine("                                                    <div dir=\"ltr\">");
            builder.AppendLine("                                                        #DESCRICAOMODULO");
            builder.AppendLine("                                                    </div>");
            builder.AppendLine("                                                </font>");
            builder.AppendLine("                                            </div>");
            builder.AppendLine("                                        </td>");
            builder.AppendLine("                                    </tr>");
            builder.AppendLine("                                </tbody>");
            builder.AppendLine("                            </table>");
            builder.AppendLine("                        </td>");
            builder.AppendLine("                    </tr>");
            builder.AppendLine("                </tbody>");
            builder.AppendLine("            </table>");
            builder.AppendLine("            <br>");
            builder.AppendLine("            <br>");
            builder.AppendLine("            <br>");
            builder.AppendLine("            <table width=\"100%\" cellpadding=\"0\" cellspacing=\"0\" border=\"0\" class=\"message\">");
            builder.AppendLine("                <tbody>");
            builder.AppendLine("                    <tr>");
            builder.AppendLine("                        <td>");
            builder.AppendLine("                            <font size=\"-1\">");
            builder.AppendLine("                                <b>Passo a Passo:</b>");
            builder.AppendLine("                            </font>");
            builder.AppendLine("                        </td>");
            builder.AppendLine("                    </tr>");
            builder.AppendLine("                    <tr>");
            builder.AppendLine("                        <td colspan=\"2\">");
            builder.AppendLine("                            <table width=\"100%\" cellpadding=\"12\" cellspacing=\"0\" border=\"0\">");
            builder.AppendLine("                                <tbody>");
            builder.AppendLine("                                    <tr>");
            builder.AppendLine("                                        <td>");
            builder.AppendLine("                                            <div style=\"overflow: hidden;\">");
            builder.AppendLine("                                                <font size=\"-1\">");
            builder.AppendLine("                                                    <div dir=\"ltr\">");
            builder.AppendLine("                                                        #PASSOAPASSO");
            builder.AppendLine("                                                    </div>");
            builder.AppendLine("                                                </font>");
            builder.AppendLine("                                            </div>");
            builder.AppendLine("                                        </td>");
            builder.AppendLine("                                    </tr>");
            builder.AppendLine("                                </tbody>");
            builder.AppendLine("                            </table>");
            builder.AppendLine("                        </td>");
            builder.AppendLine("                    </tr>");
            builder.AppendLine("                </tbody>");
            builder.AppendLine("            </table>");
            builder.AppendLine("            <br>");
            builder.AppendLine("            <br>");
            builder.AppendLine("            <br>");
            builder.AppendLine("            <table width=\"100%\" cellpadding=\"0\" cellspacing=\"0\" border=\"0\" class=\"message\">");
            builder.AppendLine("                <tbody>");
            builder.AppendLine("                    <tr>");
            builder.AppendLine("                        <td>");
            builder.AppendLine("                            <font size=\"-1\">");
            builder.AppendLine("                                <b>Descrição dos testes:</b>");
            builder.AppendLine("                            </font>");
            builder.AppendLine("                        </td>");
            builder.AppendLine("                    </tr>");
            builder.AppendLine("                    <tr>");
            builder.AppendLine("                        <td colspan=\"2\">");
            builder.AppendLine("                            <table width=\"100%\" cellpadding=\"12\" cellspacing=\"0\" border=\"0\">");
            builder.AppendLine("                                <tbody>");
            builder.AppendLine("                                    <tr>");
            builder.AppendLine("                                        <td>");
            builder.AppendLine("                                            <div style=\"overflow: hidden;\">");
            builder.AppendLine("                                                <font size=\"-1\">");
            builder.AppendLine("                                                    <div dir=\"ltr\">");
            builder.AppendLine("                                                        #DESCRICAODOSTESTES");
            builder.AppendLine("                                                    </div>");
            builder.AppendLine("                                                </font>");
            builder.AppendLine("                                            </div>");
            builder.AppendLine("                                        </td>");
            builder.AppendLine("                                    </tr>");
            builder.AppendLine("                                </tbody>");
            builder.AppendLine("                            </table>");
            builder.AppendLine("                        </td>");
            builder.AppendLine("                    </tr>");
            builder.AppendLine("                </tbody>");
            builder.AppendLine("            </table>");
            builder.AppendLine("            <br>");
            builder.AppendLine("            <br>");
            builder.AppendLine("            <br>");
            builder.AppendLine("            <table width=\"100%\" cellpadding=\"0\" cellspacing=\"0\" border=\"0\" class=\"message\">");
            builder.AppendLine("                <tbody>");
            builder.AppendLine("                    <tr>");
            builder.AppendLine("                        <td colspan=\"2\">");
            builder.AppendLine("                            <table width=\"100%\" cellpadding=\"12\" cellspacing=\"0\" border=\"0\">");
            builder.AppendLine("                                <tbody>");
            builder.AppendLine("                                    <tr>");
            builder.AppendLine("                                        <td>");
            builder.AppendLine("                                            <table width=\"100%\" cellpadding=\"0\" cellspacing=\"0\" border=\"0\" class=\"message\">");
            builder.AppendLine("                                                <tbody>");
            builder.AppendLine("                                                    <tr>");
            builder.AppendLine("                                                        <td>");
            builder.AppendLine("                                                            <font size=\"-1\">");
            builder.AppendLine("                                                                <b>Testes Efetuado:</b>");
            builder.AppendLine("                                                            </font>");
            builder.AppendLine("                                                        </td>");
            builder.AppendLine("                                                    </tr>");
            builder.AppendLine("                                                </tbody>");
            builder.AppendLine("                                            </table>");
            builder.AppendLine("                                            <br>");
            builder.AppendLine("                                            <br>");
            builder.AppendLine("                                            #TESTESESPECIFICOS                                ");
            builder.AppendLine("                                        </td>");
            builder.AppendLine("                                    </tr>");
            builder.AppendLine("                                </tbody>");
            builder.AppendLine("                            </table>");
            builder.AppendLine("                        </td>");
            builder.AppendLine("                    </tr>");
            builder.AppendLine("                </tbody>");
            builder.AppendLine("            </table>");
            builder.AppendLine("            <br>");
            builder.AppendLine("            <br>");
            builder.AppendLine("            <br>");
            builder.AppendLine("            <hr> ");
            builder.AppendLine("        </div>");

            return builder.ToString().Replace("#TESTESESPECIFICOS", MontaTestesEspeficicos(teste));
        }

        /// <summary>
        /// Método que preenche os casos de testes específicos
        /// </summary>
        /// <param name="teste"></param>
        /// <returns></returns>
        private static string MontaTestesEspeficicos(Model.MD_Teste teste)
        {
            string builder = string.Empty;

            builder =   " <table width=\"100%\" cellpadding=\"0\" cellspacing=\"0\" border=\"1\" class=\"message\">" +
                        "     <tbody>" +
                        "         <tr>" +
                        "             <td>" +
                        "                 <table width=\"100%\" cellpadding=\"12\" cellspacing=\"0\" border=\"0\">" +
                        "                     <tbody>" +
                        "                         <tr>" +
                        "                             <td>" +
                        "                                 <div style=\"overflow: hidden;\">" +
                        "                                     <font size=\"-1\">" +
                        "                                         <div dir=\"ltr\">" +
                        "                                             <b>" +
                        "												#TESTE" +
                        "											</b>#NOTAS" +
                        "                                         </div>" +
                        "                                     </font>" +
                        "                                 </div>" +
                        "                             </td>" +
                        "                         </tr>" +
                        "                     </tbody>" +
                        "                 </table>" +
                        "             </td>" +
                        "             <td width=\"70\" style=\"color:#COLOR\">" +
                        "                 <b>" +
                        "					#RESULTADO" +
                        "				</b>" +
                        "             </td>" +
                        "         </tr>" +
                        "     </tbody>" +
                        " </table>";

            string saida = string.Empty;

            foreach(Model.MD_Tabelatestes o in teste.RetornaListaTestes())
            {
                saida += builder.Replace("#TESTE", o.DAO.Descricao).Replace("#NOTAS", string.IsNullOrEmpty(o.DAO.Notas) ? "" : "<br><br><b>Notas<b><br>" + o.DAO.Notas).Replace("#COLOR", (o.DAO.Status.Equals("0") ? "red" : "green")).Replace("#RESULTADO", o.DAO.Status.Equals("0") ? "Erro":"Sucesso");
            }

            return saida;
        }

        /// <summary>
        /// Método que monta a base do html
        /// </summary>
        /// <returns></returns>
        private static string MontarBase()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine("<!DOCTYPE html PUBLIC \" -//W3C//DTD HTML 4.01//EN\" \"https://www.w3.org/TR/html4/strict.dtd\">");
            builder.AppendLine("<html lang=\"pt-BR\">");
            builder.AppendLine("");
            builder.AppendLine("<head>");
            builder.AppendLine("    <meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\">");
            builder.AppendLine("    <style type=\"text/css\" nonce=\"\">");
            builder.AppendLine("        body,");
            builder.AppendLine("        td,");
            builder.AppendLine("        div,");
            builder.AppendLine("        p,");
            builder.AppendLine("        a,");
            builder.AppendLine("        input {");
            builder.AppendLine("            font-family: arial, sans-serif;");
            builder.AppendLine("        }");
            builder.AppendLine("    </style>");
            builder.AppendLine("    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">");
            builder.AppendLine("    <title>Relatório de Testes</title>");
            builder.AppendLine("    <style type=\"text/css\" nonce=\"\">");
            builder.AppendLine("        body,");
            builder.AppendLine("        td {");
            builder.AppendLine("            font-size: 13px");
            builder.AppendLine("        }");
            builder.AppendLine("");
            builder.AppendLine("        a:link,");
            builder.AppendLine("        a:active {");
            builder.AppendLine("            color: #1155CC;");
            builder.AppendLine("            text-decoration: none");
            builder.AppendLine("        }");
            builder.AppendLine("");
            builder.AppendLine("        a:hover {");
            builder.AppendLine("            text-decoration: underline;");
            builder.AppendLine("            cursor: pointer");
            builder.AppendLine("        }");
            builder.AppendLine("");
            builder.AppendLine("        a:visited {");
            builder.AppendLine("            color: ##6611CC");
            builder.AppendLine("        }");
            builder.AppendLine("");
            builder.AppendLine("        img {");
            builder.AppendLine("            border: 0px");
            builder.AppendLine("        }");
            builder.AppendLine("");
            builder.AppendLine("        pre {");
            builder.AppendLine("            white-space: pre;");
            builder.AppendLine("            white-space: -moz-pre-wrap;");
            builder.AppendLine("            white-space: -o-pre-wrap;");
            builder.AppendLine("            white-space: pre-wrap;");
            builder.AppendLine("            word-wrap: break-word;");
            builder.AppendLine("            max-width: 800px;");
            builder.AppendLine("            overflow: auto;");
            builder.AppendLine("        }");
            builder.AppendLine("");
            builder.AppendLine("        .logo {");
            builder.AppendLine("            left: -7px;");
            builder.AppendLine("            position: relative;");
            builder.AppendLine("        }");
            builder.AppendLine("    </style>");
            builder.AppendLine("    <style type=\"text/css\"></style>");
            builder.AppendLine("</head>");
            builder.AppendLine("");
            builder.AppendLine("<body>");
            builder.AppendLine("    <div class=\"bodycontainer\" align=\"justify\">");
            builder.AppendLine("        <table width=\"100%\" cellpadding=\"0\" cellspacing=\"0\" border=\"0\">");
            builder.AppendLine("            <tbody>");
            builder.AppendLine("                <tr height=\"14px\">");
            builder.AppendLine("                    <td width=\"143\"> ");
            builder.AppendLine("                        <img src=\"./files/logonew.png\" width=\"100\" height=\"60\" alt=\"Gmail\" class=\"logo\">");
            builder.AppendLine("                            <b>SunSale System</b> ");
            builder.AppendLine("                    </td>");
            builder.AppendLine("                    <td align=\"right\">");
            builder.AppendLine("                        <font size=\"-1\" color=\"#777\">");
            builder.AppendLine("                            <b>SunSale System &lt;sunsalesystem@gmail.com&gt;</b>");
            builder.AppendLine("                        </font> ");
            builder.AppendLine("                    </td>");
            builder.AppendLine("                </tr>");
            builder.AppendLine("            </tbody>");
            builder.AppendLine("        </table>");
            builder.AppendLine("        <br>");
            builder.AppendLine("        <hr>");
            builder.AppendLine("        <div class=\"maincontent\">");
            builder.AppendLine("            <table width=\"100%\" cellpadding=\"0\" cellspacing=\"0\" border=\"0\">");
            builder.AppendLine("                <tbody>");
            builder.AppendLine("                    <tr>");
            builder.AppendLine("                        <td colspan=\"2\">");
            builder.AppendLine("                            <center>");
            builder.AppendLine("                                <font size=\"+2\">");
            builder.AppendLine("                                    <b>Relatório de teste</b>");
            builder.AppendLine("                                </font>");
            builder.AppendLine("                            </center>");
            builder.AppendLine("                            <br>");
            builder.AppendLine("                            <br>");
            builder.AppendLine("                        </td>");
            builder.AppendLine("                    </tr>");
            builder.AppendLine("                </tbody> ");
            builder.AppendLine("            </table> ");
            builder.AppendLine("        </div> ");
            builder.AppendLine("        #TEXTO");
            builder.AppendLine("    </div>");
            builder.AppendLine("    <script type=\"text/javascript\" nonce=\"\">");
            builder.AppendLine("        document.body.onload = function() {");
            builder.AppendLine("            document.body.offsetHeight;");
            builder.AppendLine("            window.print()");
            builder.AppendLine("        };");
            builder.AppendLine("    </script>");
            builder.AppendLine("</body>");
            builder.AppendLine("");
            builder.AppendLine("</html>");

            return builder.ToString();
        }
    }
}
