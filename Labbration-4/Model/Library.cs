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
        public BindingList<DataSpel> SpelList { get; private set; }
        public BindingList<Filmer> FilmList { get; private set; }

        public Library()
        {
            BookList = new BindingList<Book>();
            SpelList = new BindingList<DataSpel>();

    }

        public void SaveFileBook () 
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("books");
            foreach(var book in BookList)
            {
                XmlElement element = doc.CreateElement("book");

                XmlElement Name = doc.CreateElement("Name");
                Name.InnerText = book.Name;
                element.AppendChild(Name);

                XmlElement Språk = doc.CreateElement("Språk");
                Språk.InnerText = book.Språk;
                element.AppendChild(Språk);

                XmlElement Författare = doc.CreateElement("Författare");
                Författare.InnerText = book.Författare;
                element.AppendChild(Författare);

                XmlElement Pris = doc.CreateElement("Pris");
                Pris.InnerText = book.Pris;
                element.AppendChild(Pris);

                XmlElement Genre = doc.CreateElement("Genre");
                Genre.InnerText = book.Genre;
                element.AppendChild(Genre);

                XmlElement Format = doc.CreateElement("Format");
                Format.InnerText = book.Format;
                element.AppendChild(Format);

                XmlElement BoVale = doc.CreateElement("BoVale");
                BoVale.InnerText = book.BoVale.ToString();
                element.AppendChild(BoVale);



                root.AppendChild(element);


            }
            doc.AppendChild(root);
            doc.Save("IvanDB.xml");
        }

        public void SaveFileSpel()
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("spellek");
            foreach (var spel in SpelList)
            {
                XmlElement element = doc.CreateElement("spel");

                XmlElement Name = doc.CreateElement("Name");
                Name.InnerText = spel.Name;
                element.AppendChild(Name);


                XmlElement Pris = doc.CreateElement("Pris");
                Pris.InnerText = spel.Pris;
                element.AppendChild(Pris);

                XmlElement Plattform = doc.CreateElement("Plattform ");
                Plattform.InnerText = spel.Plattform;
                element.AppendChild(Plattform);


                XmlElement BoVale = doc.CreateElement("BoVale");
                BoVale.InnerText = spel.BoVale.ToString();
                element.AppendChild(BoVale);



                root.AppendChild(element);


            }
            doc.AppendChild(root);
            doc.Save("IvanDB.xml");

        }

        public void LoadFileSpel()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("IvanDB.xml");
            var root = doc.FirstChild;
            foreach (XmlElement element in root.ChildNodes)
            {
                var spel = new DataSpel();
                foreach (XmlElement elem in element.ChildNodes)
                {
                    if (elem.Name == "Name")
                        spel.Name = elem.InnerText;
                    if (elem.Name == "Pris")
                        spel.Pris = elem.InnerText;
                    if (elem.Name == "Plattform ")
                        spel.Plattform = elem.InnerText;
                    if (elem.Name == "BoVale")
                        spel.BoVale = bool.Parse(elem.InnerText);

                }
               
                   SpelList.Add(spel);
            }
            
        }

        public void LoadFile()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("IvanDB.xml");
            var root = doc.FirstChild;
            foreach(XmlElement element in root.ChildNodes)
            {
                var book = new Book();  
                foreach(XmlElement elem in element.ChildNodes)
                {
                    if(elem.Name == "Name")
                        book.Name = elem.InnerText;
                    if(elem.Name == "Författare")
                        book.Författare = elem.InnerText;
                    if( elem.Name == "Pris")
                        book.Pris = elem.InnerText;
                    if(elem.Name == "Format")
                        book.Format = elem.InnerText;
                    if(elem.Name == "Genre")
                        book.Genre = elem.InnerText;
                    if(elem.Name =="Språk")
                        book.Språk = elem.InnerText;
                    if (elem.Name == "BoVale")
                        book.BoVale = bool.Parse(elem.InnerText);

                }
                BookList.Add(book); 

            }
        }


        public void SaveFileFilm()
        {

        }


    }

}
