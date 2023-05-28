using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace RGR.Models
{
    public class SaverXML : ICollectionProjectSaver
    {
        public void SaveXML(Class_Project collection)
        {
            var contact = new XElement("project", new XElement("Name", collection.NameProject));
            var doc = new XDocument();

            if (File.Exists(@"..\..\..\all.xml"))
            {
                doc = XDocument.Load(@"..\..\..\all.xml");
                doc.Element("projects").Add(contact);
            }
            else
            {
                doc = new XDocument(new XElement("projects", contact));
            }
            doc.Save(@"..\..\..\all.xml");

            var contacter = new XElement("project", new XElement("Path", collection.Path));
            var doces = new XDocument();

            if (File.Exists(@"..\..\..\all.xml"))
            {
                doces = XDocument.Load(@"..\..\..\all.xml");
                doces.Element("projects").Add(contacter);
            }
            else
            {
                doces = new XDocument(new XElement("projects", contacter));
            }
            doces.Save(@"..\..\..\all.xml");
        }
    }
}
