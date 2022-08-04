using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
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
            XmlElement root = doc.CreateElement("books");
            foreach (var book in BookList)
            {
                XmlElement element = doc.CreateElement("book");

                XmlElement id = doc.CreateElement("id");
                id.InnerText = book.id.ToString();
                element.AppendChild(id);

                XmlElement name = doc.CreateElement("name");
                name.InnerText = book.name;
                element.AppendChild(name);

                XmlElement language = doc.CreateElement("language");
                language.InnerText = book.language;
                element.AppendChild(language);

                XmlElement Författare = doc.CreateElement("Författare");
                Författare.InnerText = book.Författare;
                element.AppendChild(Författare);

                XmlElement stock = doc.CreateElement("stock");
                stock.InnerText = book.stock.ToString();
                element.AppendChild(stock);

                XmlElement price = doc.CreateElement("price");
                price.InnerText = book.price.ToString();
                element.AppendChild(price);

                XmlElement genre = doc.CreateElement("genre");
                genre.InnerText = book.genre;
                element.AppendChild(genre);

                XmlElement format = doc.CreateElement("format");
                format.InnerText = book.format;
                element.AppendChild(format);

                XmlElement BoVale = doc.CreateElement("BoVale");
                BoVale.InnerText = book.BoVale.ToString();
                element.AppendChild(BoVale);



                root.AppendChild(element);


            }
            doc.AppendChild(root);
            doc.Save("Book.xml");
        }

        public void SaveFileMovie()
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("movies");
            foreach (var movie in MovieList)
            {
                XmlElement element = doc.CreateElement("movie");

                XmlElement id = doc.CreateElement("id");
                id.InnerText = movie.id.ToString();
                element.AppendChild(id);

                XmlElement stock = doc.CreateElement("stock");
                stock.InnerText = movie.stock.ToString();
                element.AppendChild(stock);

                XmlElement name = doc.CreateElement("name");
                name.InnerText = movie.name;
                element.AppendChild(name);

                XmlElement price = doc.CreateElement("price");
                price.InnerText = movie.price.ToString();
                element.AppendChild(price);

                XmlElement format = doc.CreateElement("format");
                format.InnerText = movie.format;
                element.AppendChild(format);

                XmlElement playtime = doc.CreateElement("playtime");
                playtime.InnerText = movie.playtime.ToString();
                element.AppendChild(playtime);

                XmlElement BoVale = doc.CreateElement("BoVale");
                BoVale.InnerText = movie.BoVale.ToString();
                element.AppendChild(BoVale);



                root.AppendChild(element);


            }
            doc.AppendChild(root);
            doc.Save("Movie.xml");
        }


        public void SaveFileGame()
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("games");
            foreach (var spel in SpelList)
            {
                XmlElement element = doc.CreateElement("game");

                XmlElement id = doc.CreateElement("id");
                id.InnerText = spel.id.ToString();
                element.AppendChild(id);

                XmlElement stock = doc.CreateElement("stock");
                stock.InnerText = spel.stock.ToString();
                element.AppendChild(stock);

                XmlElement name = doc.CreateElement("name");
                name.InnerText = spel.name;
                element.AppendChild(name);

                XmlElement price = doc.CreateElement("price");
                price.InnerText = spel.price.ToString();
                element.AppendChild(price);

                XmlElement platform = doc.CreateElement("platform");
                platform.InnerText = spel.platform;
                element.AppendChild(platform);

                

                XmlElement BoVale = doc.CreateElement("BoVale");
                BoVale.InnerText = spel.BoVale.ToString();
                element.AppendChild(BoVale);



                root.AppendChild(element);


            }
            doc.AppendChild(root);
            doc.Save("Game.xml");
        }
        /*
        /*
         * This is for Assignment-5
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
                                book.price =int.Parse(el.InnerText);
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
                                dataSpel.price = int.Parse( el.InnerText);
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

                    Filmer filmer = new Filmer();
                    if (ell.Name == "movie")
                    {
                        foreach (XmlElement el in ell.ChildNodes)
                        {
                            // MessageBox.Show(el.InnerXml);
                            if (el.Name == "id")
                            {
                                filmer.id = el.InnerText;
                            }

                            if (el.Name == "name")
                            {
                                filmer.name = el.InnerText;
                            }
                            if (el.Name == "price")
                            {
                                filmer.price = int.Parse(el.InnerText);
                            }
                            if (el.Name == "stock")
                            {
                                filmer.stock = el.InnerText;
                            }
                            if (el.Name == "format")
                            {
                                filmer.format = el.InnerText;
                            }
                            if (el.Name == "playtime")
                            {
                                filmer.playtime = int.Parse(el.InnerText);
                            }


                        }
                        MovieList.Add(filmer);
                    }

                }
            }
        }
        */
       
        public void LoadFileBooks()
        {

            XmlDocument doc = new XmlDocument();
            doc.Load("Book.xml");
            var root = doc.FirstChild;
            foreach (XmlElement element in root.ChildNodes)
            {
                var book = new Book();
                foreach (XmlElement elem in element.ChildNodes)
                {
                    if (elem.Name == "id")
                        book.id = int.Parse(elem.InnerText);
                    if (elem.Name == "stock")
                        book.stock = int.Parse(elem.InnerText);
                    if (elem.Name == "name")
                        book.name = elem.InnerText;
                    if (elem.Name == "Författare")
                        book.Författare = elem.InnerText;
                    if (elem.Name == "price")
                        book.price = int.Parse(elem.InnerText);
                    if (elem.Name == "format")
                        book.format = elem.InnerText;
                    if (elem.Name == "genre")
                        book.genre = elem.InnerText;
                    if (elem.Name == "language")
                        book.language = elem.InnerText;
                    if (elem.Name == "BoVale")
                        book.BoVale = bool.Parse(elem.InnerText);

                }
                BookList.Add(book);
                doc.AppendChild(root);
                doc.Save("Book.xml");

            }
        }

        public void LoadFileMovie()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Movie.xml");
            var root = doc.FirstChild;
            foreach (XmlElement element in root.ChildNodes)
            {
                var movie = new Filmer();
                foreach (XmlElement elem in element.ChildNodes)
                {
                    if (elem.Name == "id")
                       movie.id = int.Parse(elem.InnerText);
                    if (elem.Name == "stock")
                        movie.stock = int.Parse(elem.InnerText);
                    if (elem.Name == "name")
                        movie.name = elem.InnerText;
                    if (elem.Name == "playtime")
                        movie.playtime = int.Parse(elem.InnerText);
                    if (elem.Name == "price")
                        movie.price = int.Parse(elem.InnerText);
                    if (elem.Name == "format")
                        movie.format = elem.InnerText;
                    if (elem.Name == "BoVale")
                        movie.BoVale = bool.Parse(elem.InnerText);

                }
                MovieList.Add(movie);
                doc.AppendChild(root);
                doc.Save("Movie.xml");

            }
        }

        public void LoadFileGame()
        {
  
            XmlDocument doc = new XmlDocument();
            doc.Load("Game.xml");
            var root = doc.FirstChild;
            foreach (XmlElement element in root.ChildNodes)
            {
                var spel = new DataSpel();
                foreach (XmlElement elem in element.ChildNodes)
                {
                    if (elem.Name == "id")
                        spel.id = int.Parse(elem.InnerText);
                    if (elem.Name == "stock")
                        spel.stock = int.Parse(elem.InnerText);
                    if (elem.Name == "name")
                        spel.name = elem.InnerText;
                    if (elem.Name == "price")
                        spel.price = int.Parse(elem.InnerText);
                    if (elem.Name == "platform")
                        spel.platform = elem.InnerText;
                    if (elem.Name == "BoVale")
                        spel.BoVale = bool.Parse(elem.InnerText);

                }
                SpelList.Add(spel);
                doc.AppendChild(root);
                doc.Save("Game.xml");

            }
        }





    }

}
