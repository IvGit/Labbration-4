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
        
        
        public void SaveFile()
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("products");
            foreach (var book in BookList)
            {
                XmlElement element = doc.CreateElement("book");

                XmlElement price = doc.CreateElement("price");
                price.InnerText = book.price;
                element.AppendChild(price);

                XmlElement BoVale = doc.CreateElement("BoVale");
                BoVale.InnerText = book.BoVale.ToString();
                element.AppendChild(BoVale);



                root.AppendChild(element);


            }
            doc.AppendChild(root);
            doc.Save("ivandb.xml");
        }


        
        

        public void LoadFile()
        {
            WebClient client = new WebClient();
            var text = client.DownloadString("https://hex.cse.kau.se/~jonavest/csharp-api");
            XmlDocument docC = new XmlDocument();
            docC.LoadXml(text);
            docC.Save("Backup.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load("Backup.xml");


            foreach (XmlElement elemm in doc.FirstChild.ChildNodes)
            {
                foreach (XmlElement ell in elemm.ChildNodes)
                {
                    Book book = new Book();

                    if (ell.Name == "book")
                    {
                        foreach (XmlElement el in ell.ChildNodes)
                        {
                            // MessageBox.Show(el.InnerXml);
                            if (el.Name == "id")
                            {
                                book.id = el.InnerText;
                            }

                            if (el.Name == "name")
                            {
                                book.name = el.InnerText;
                            }
                            if (el.Name == "price")
                            {
                                book.price = el.InnerText;
                            }
                            if (el.Name == "genre")
                            {
                                book.genre = el.InnerText;
                            }
                            if (el.Name == "stock")
                            {
                                book.stock = el.InnerText;
                            }
                            if (el.Name == "format")
                            {
                                book.format = el.InnerText;
                            }

                            if (el.Name == "language")
                            {
                                book.language = el.InnerText;
                            }
                        }
                        BookList.Add(book);

                    }

                    DataSpel dataSpel = new DataSpel();
                    if (ell.Name == "game")
                    {
                        foreach (XmlElement el in ell.ChildNodes)
                        {
                            // MessageBox.Show(el.InnerXml);
                            if (el.Name == "id")
                            {
                                dataSpel.id = el.InnerText;
                            }

                            if (el.Name == "name")
                            {
                                dataSpel.name = el.InnerText;
                            }
                            if (el.Name == "price")
                            {
                                dataSpel.price = el.InnerText;
                            }
                            if (el.Name == "stock")
                            {
                                dataSpel.stock = el.InnerText;
                            }
                            if (el.Name == "platform")
                            {
                                dataSpel.platform = el.InnerText;
                            }

                           
                        }
                        SpelList.Add(dataSpel);

                    }

                }
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
                Name.InnerText = spel.name;
                element.AppendChild(Name);

                XmlElement Pris = doc.CreateElement("Pris");
                Pris.InnerText = spel.price;
                element.AppendChild(Pris);

                XmlElement Platform = doc.CreateElement("Platform");
                Platform.InnerText = spel.platform;
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
                    if (elem.Name == "name")
                        spel.name = elem.InnerText;
                    if (elem.Name == "price")
                        spel.price = elem.InnerText;
                    if (elem.Name == "platform")
                        spel.platform = elem.InnerText;
                    if (elem.Name == "BoVale")
                        spel.BoVale = bool.Parse(elem.InnerText);

                }
                SpelList.Add(spel);

            }
        }

        


    }

}
