using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace Labbration_4
{
    public class Library
    {

        public BindingList<Book> BookList { get; private set; }
        public BindingList<DataSpel> SpelList { get; private set; }
        public BindingList<Filmer> MovieList { get; private set; }


        public Library()
        {
            BookList = new BindingList<Book>();
            SpelList = new BindingList<DataSpel>();
            MovieList = new BindingList<Filmer>();
        }
        /*
        
        public void SaveFile()
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("products");
            foreach (var book in BookList)
            {
                XmlElement element = doc.CreateElement("book");

                XmlElement price = doc.CreateElement("price");
                price.InnerText = book.Pris;
                element.AppendChild(price);

                XmlElement BoVale = doc.CreateElement("BoVale");
                BoVale.InnerText = book.BoVale.ToString();
                element.AppendChild(BoVale);



                root.AppendChild(element);


            }
            doc.AppendChild(root);
            doc.Save("ivandb.xml");
        }


        */
        

        public void LoadFile()
        {
            WebClient client = new WebClient();
            var text = client.DownloadString("https://hex.cse.kau.se/~jonavest/csharp-api");
            XmlDocument docC = new XmlDocument();
            docC.LoadXml(text);
            docC.Save("ivandb.xml");


           // XmlDocument doc = new XmlDocument();
           // docC.LoadXml(ivandb);
            foreach (XmlElement element in docC.FirstChild.ChildNodes)
            {
               // MessageBox.Show(element.InnerXml);
                var book = new Book();
                foreach (XmlElement elem in element.ChildNodes)
                    foreach (XmlElement el in elem.ChildNodes)
                    {
                    if(el.InnerText == "book")
                    MessageBox.Show(el.InnerXml);


                    if (elem.Name == "name")
                        book.Författare = elem.InnerText;
                    /*
                    if (elem.Name == "price")
                        book.Pris = elem.InnerText;
                    if (elem.Name == "format")
                        book.Format = elem.InnerText;
                    if (elem.Name == "genre")
                        book.Genre = elem.InnerText;
                    if (elem.Name == "language")
                        book.Språk = elem.InnerText;
                    if (elem.Name == "BoVale")
                        book.BoVale = bool.Parse(elem.InnerText);
                    */
                }
                BookList.Add(book);

            }
        }

        
        

        public void SaveFileMovie()
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("movies");
            foreach (var movie in MovieList)
            {
                XmlElement element = doc.CreateElement("movie");

                XmlElement Name = doc.CreateElement("Name");
                Name.InnerText = movie.Name;
                element.AppendChild(Name);

                XmlElement Pris = doc.CreateElement("Pris");
                Pris.InnerText = movie.Pris;
                element.AppendChild(Pris);

                XmlElement Format = doc.CreateElement("Format");
                Format.InnerText = movie.Format;
                element.AppendChild(Format);

                XmlElement Playtime = doc.CreateElement("Playtime");
                Playtime.InnerText = movie.Format;
                element.AppendChild(Format);

                XmlElement BoVale = doc.CreateElement("BoVale");
                BoVale.InnerText = movie.BoVale.ToString();
                element.AppendChild(BoVale);



                root.AppendChild(element);


            }
            doc.AppendChild(root);
            doc.Save("test.xml");
        }




    
        public void LoadFileMovie()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("test.xml");
            var root = doc.FirstChild;
            foreach (XmlElement element in root.ChildNodes)
            {
                var movie = new Filmer();
                foreach (XmlElement elem in element.ChildNodes)
                {
                    if (elem.Name == "Name")
                        movie.Name = elem.InnerText;
                    if (elem.Name == "Playtime")
                        movie.Playtime = elem.InnerText;
                    if (elem.Name == "Pris")
                        movie.Pris = elem.InnerText;
                    if (elem.Name == "Format")
                        movie.Format = elem.InnerText;
                    if (elem.Name == "BoVale")
                        movie.BoVale = bool.Parse(elem.InnerText);

                }
                MovieList.Add(movie);

            }
        }
        




        public void SaveFileGame()
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("games");
            foreach (var spel in SpelList)
            {
                XmlElement element = doc.CreateElement("game");

                XmlElement Name = doc.CreateElement("Name");
                Name.InnerText = spel.Name;
                element.AppendChild(Name);

                XmlElement Pris = doc.CreateElement("Pris");
                Pris.InnerText = spel.Pris;
                element.AppendChild(Pris);

                XmlElement Platform = doc.CreateElement("Platform");
                Platform.InnerText = spel.Platform;
                element.AppendChild(Platform);

                

                XmlElement BoVale = doc.CreateElement("BoVale");
                BoVale.InnerText = spel.BoVale.ToString();
                element.AppendChild(BoVale);



                root.AppendChild(element);


            }
            doc.AppendChild(root);
            doc.Save("ivandbGame.xml");
        }




        
        public void LoadFileGame()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("ivandbGame.xml");
            var root = doc.FirstChild;
            foreach (XmlElement element in root.ChildNodes)
            {
                var spel= new DataSpel();
                foreach (XmlElement elem in element.ChildNodes)
                {
                    if (elem.Name == "Name")
                        spel.Name = elem.InnerText;
                    if (elem.Name == "Pris")
                        spel.Pris = elem.InnerText;
                    if (elem.Name == "Platform")
                        spel.Platform = elem.InnerText;
                    if (elem.Name == "BoVale")
                        spel.BoVale = bool.Parse(elem.InnerText);

                }
                SpelList.Add(spel);

            }
        }

        


    }

}
