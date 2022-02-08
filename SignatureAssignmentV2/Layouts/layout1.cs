using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureAssignmentV2
{

        public class layout1
        {
            public void HtmlSite()
            {

                XmlTextReader xtr = new XmlTextReader(@"C:\Users\vlad.mastjulins\source\repos\SignatureAssignmentV2\SignatureAssignmentV2\Layouts\signature_data.xml");

                var file = XDocument.Load(@"C:\Users\vlad.mastjulins\source\repos\SignatureAssignmentV2\SignatureAssignmentV2\XML\signature_data.xml");


                var info = from signature in file.Root?.Descendants("row")
                           select new
                           {
                               Name = signature?.Element("name")?.Value,
                               styleName = signature?.Element("name")?.Attribute("styleName")?.Value, // Responsible for the style of the name


                               image = signature?.Element("image")?.Value,
                               imageStyle = signature?.Element("image")?.Attribute("imageStyle")?.Value, // Responsible for the style of imageStyle (Height & Width)
                               imageStyle1 = signature?.Element("image")?.Attribute("imageStyle2")?.Value, // Redundant, needs fix soon
                               Src = signature?.Element("image")?.Attribute("src")?.Value, // Responsible for reading Base64 images


                               job = signature?.Element("job_title")?.Value,
                               styleJob = signature?.Element("job_title")?.Attribute("styleJob")?.Value, // Responsible for the style of job_title


                               department = signature?.Element("department")?.Value,
                               styleDept = signature?.Element("department")?.Attribute("styleDept")?.Value, // Responsible for the style of department


                               company = signature?.Element("company")?.Value,
                               styleComp = signature?.Element("company")?.Attribute("styleComp")?.Value, // Responsible for the style of company 


                               companyAdres = signature?.Element("company_adres")?.Value,
                               styleCompAdr = signature?.Element("company_adres")?.Attribute("styleCompAdr")?.Value, // Responsible for the style of company_adres


                               telNumber = signature?.Element("tel_nummer")?.Value,
                               styleNumb = signature?.Element("tel_number")?.Attribute("styleNumb")?.Value, // Responsible for the style of tel_number


                               email = signature?.Element("email_adres")?.Value,
                               styleMail = signature?.Element("email_adres")?.Attribute("styleMail")?.Value, // Responsible for the style of email_adres


                               companySite = signature?.Element("company_website")?.Value,
                               styleCompWeb = signature?.Element("company_website")?.Attribute("styleCompWeb")?.Value // Responsible for the style of company_website


                           };

                string html = "<html>";

                foreach (var item in info)
                {

                    html += "<body> # <table cellpadding='5' cellspacing='0'>";

                    html += "<tr>";
                    html += "<td style='" + item.imageStyle1 + "'>" + "<img style='" + item.imageStyle + "' src=" + item.Src + "></img></td>#"; // Prints out image.
                    html += "</tr>";

                    html += "<tr>";
                    html += "<td style='" + item.styleName + "'>" + item.Name + "</td>#";
                    html += "</tr>";

                    html += "<tr>";
                    html += "<td style='" + item.styleJob + "'>" + item.job + "</td>#";
                    html += "</tr>";

                    html += "<tr>";
                    html += $"<td style='" + item.styleDept + "'>" + item.department + "</td>#";
                    html += "</tr>";

                    html += "<tr>";
                    html += "<td style='" + item.styleComp + "'>" + item.company + "</td>#";
                    html += "</tr>";

                    html += "<tr>";
                    html += "<td style='" + item.styleCompAdr + "'>" + item.companyAdres + "</td>#";
                    html += "</tr>";

                    html += "<tr>";
                    html += "<td style='" + item.styleMail + "'>" + item.email + "</td>#";
                    html += "</tr>";

                    html += "<tr>";
                    html += "<td style='" + item.styleCompWeb + "'>" + item.companySite + "</td>#";
                    html += "</tr>";


                    html += "</table> # </body> # </html>";

                }


                html = html.Replace("#", Environment.NewLine);

                /* ---------------------------------------------- HTML File Generator --------------------------------*/

                // If directory doesn't exist create it
                if (!Directory.Exists(@"C:\Users\vlad.mastjulins\source\repos\SignatureAssignmentV2\SignatureAssignmentV2\OutputFiles"))
                    Directory.CreateDirectory(@"C:\Users\vlad.mastjulins\source\repos\SignatureAssignmentV2\SignatureAssignmentV2\OutputFiles");

                File.WriteAllText(Path.Combine(@"C:\Users\vlad.mastjulins\source\repos\SignatureAssignmentV2\SignatureAssignmentV2\OutputFiles", "layout1.html"), html);
                // File.WriteAllText(Path.Combine(outputDirPath, generatedFilename), htmlStructure);



                Console.ReadLine();

            }
        }
    }

