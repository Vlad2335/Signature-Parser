using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureAssignmentV2.Parser
{
    internal class HtmlParser
    {
        public void GenerateHtmlFile()
        {
            string html = "<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt;font-family:calibri;>";

            html += "<tr>";
            html += "<th style='background-color: #B8D8FD;border: 1px solid #ccc'>""</th>";
            html += "</tr>";

            html += "<tr>";
            html += "<th style'width:120px;border: 1px solid #ccc'> </td>";
            html += "</tr>;";

            html += "</table>";
        }
    }
}
