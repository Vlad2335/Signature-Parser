using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Text;
using static System.Console;

namespace SignatureAssignmentV2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            XmlTextReader xtr = new XmlTextReader(@"C:\Users\vlad.mastjulins\source\repos\SignatureAssignmentV2\SignatureAssignmentV2\XML\signature_data.xml");

            var file = XDocument.Load(@"C:\Users\vlad.mastjulins\source\repos\SignatureAssignmentV2\SignatureAssignmentV2\XML\signature_data.xml");

            var info = from signature in file.Root?.Descendants("row")
                       select new
                       {
                           Name = signature?.Element("name")?.Value,

                           image = signature?.Element("image")?.Value,

                           job = signature?.Element("job_title")?.Value,

                           department = signature?.Element("department")?.Value,

                           company = signature?.Element("company")?.Value,

                           companyAdres = signature?.Element("company_adres")?.Value,

                           telNumber = signature?.Element("tel_nummer")?.Value,

                           email = signature?.Element("email_adres")?.Value,

                           companySite = signature?.Element("company_website")?.Value
                       };




            foreach (var item in info)
            {
                
                Console.WriteLine(item.Name);
                Console.WriteLine(item.image);
                Console.WriteLine(item.job);
                Console.WriteLine(item.department);
                Console.WriteLine(item.company);
                Console.WriteLine(item.companyAdres);
                Console.WriteLine(item.telNumber);
                Console.WriteLine(item.email);
                Console.WriteLine(item.companySite);

            }


            Cs_to_html cls = new Cs_to_html(); // Links cs_to_html.cs to program.cs (Also Line 61)
            cls.HtmlSite();



        }
    }
}
