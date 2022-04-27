using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Labbration_4
{
    public class Library
    {

        public BindingList<Book> BookList { get; private set; }

        public Library()
        {
            BookList = new BindingList<Book>();
        }

        public void saveFile()
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("books");
            foreach(var book in BookList)
            {
                XmlElement element = doc.CreateElement("book");
                XmlElement Namn = doc.CreateElement("Namn");
                Namn.InnerText = book.Name;
                element.AppendChild(Namn);

                root.AppendChild(element);


            }
            doc.AppendChild(root);
            doc.Save("IvanDB.xml");
        }
    }

}
