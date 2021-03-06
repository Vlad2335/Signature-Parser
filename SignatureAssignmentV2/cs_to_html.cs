using System;
using System.IO;
using System.Xml.Linq;
using System.Xml;

namespace SignatureAssignmentV2
{
    public class Cs_to_html
    {
        public void HtmlSite()
        {

            XmlTextReader xtr = new XmlTextReader("C:\\Users\\vlad.mastjulins\\source\\repos\\SignatureAssignmentV2\\SignatureAssignmentV2\\signature_info.xml");

            var file = XDocument.Load("C:\\Users\\vlad.mastjulins\\source\\repos\\SignatureAssignmentV2\\SignatureAssignmentV2\\signature_info.xml");

            var info = from signature in file.Root?.Descendants("row")
                       select new
                       {
                           Name = signature.Element("name").Value,
                           job = signature.Element("job_title").Value,
                           department = signature.Element("department").Value,
                           company = signature.Element("company").Value,
                           companyAdres = signature.Element("company_adres").Value,
                           telNumber = signature.Element("tel_nummer").Value,
                           email = signature.Element("email_adres").Value,
                           companySite = signature.Element("company_website").Value
                        };

            string html = "";
            foreach (var item in info) {

                html += "<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt;font-family:calibri;>"; // Finish this code

                html += "<tr>";
                html += "<th style='background-color: #B8D8FD;border: 1px solid #ccc'>" + item.telNumber + "</th>";
                html += "</tr>";

                html += "<tr>";
                html += "<th style'width:120px;border: 1px solid #ccc'>" + item.company + "</td>";
                html += "</tr>;";

                html += "</table>";

                // File.WriteAllText(Path.Combine(outputDirPath, generatedFilename), htmlStructure);
            }

            // HTML File Generator

            // If directory doesn't exist create it
             if (!Directory.Exists(@"C:\Users\vlad.mastjulins\source\repos\Signature Assignment\Signature Assignment\OutputFiles"))
                Directory.CreateDirectory(@"C:\Users\vlad.mastjulins\source\repos\Signature Assignment\Signature Assignment\OutputFiles");

            File.WriteAllText(Path.Combine(@"C:\Users\vlad.mastjulins\source\repos\Signature Assignment\Signature Assignment\OutputFiles", "index.html"), html);



            /*
             File.WriteAllText(@"C:\Users\vlad.mastjulins\source\repos\Signature Assignment\Signature Assignment\test.htm", html);
             Console.WriteLine("HTML File Created.");
            */

            Console.ReadLine();
            
        }
    }
}

