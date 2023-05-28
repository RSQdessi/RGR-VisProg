//using DynamicData.Binding;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml;
//using System.Collections.ObjectModel;

//namespace RGR.Models
//{
//    public class LoaderXML : ICollectionProjectLoader
//    {
//        public IEnumerable<Class_Project> XML_Load()
//        {
//            ObservableCollection<Class_Project> Collection = new ObservableCollection<Class_Project>();
//            XmlDocument xDoc = new XmlDocument();
            
//            xDoc.Load(@"..\..\..\all.xml");
//            XmlElement? xRoot = xDoc.DocumentElement;

//            if (xRoot != null)
//            {
//                var i = 0;
//                foreach (XmlElement xnode in xRoot)
//                {
//                    foreach (XmlNode childnode in xnode.ChildNodes)
//                    {
//                        if (childnode.Name == "Name")
//                        {
//                            Collection[i].NameProject = childnode.InnerText;
//                        }
//                        if (childnode.Name == "Path")
//                        {
//                            Collection[i].Path = childnode.InnerText;
//                        }
//                        i++;
//                    }
                    
//                }
//                return Collection;
//            }

//            else
//            {
//                return Enumerable.Empty<Class_Project>();
//            }
//        }
//    }
//}
