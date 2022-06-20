﻿using System;
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
        WebClient client;
        XmlDocument doc;


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

                XmlElement Name = doc.CreateElement("Name");
                Name.InnerText = book.name;
                element.AppendChild(Name);

                XmlElement Språk = doc.CreateElement("Språk");
                Språk.InnerText = book.Språk;
                element.AppendChild(Språk);

                XmlElement Författare = doc.CreateElement("Författare");
                Författare.InnerText = book.Författare;
                element.AppendChild(Författare);

                XmlElement Pris = doc.CreateElement("Pris");
                Pris.InnerText = book.price;
                element.AppendChild(Pris);

                XmlElement Genre = doc.CreateElement("Genre");
                Genre.InnerText = book.genre;
                element.AppendChild(Genre);

                XmlElement Format = doc.CreateElement("Format");
                Format.InnerText = book.format;
                element.AppendChild(Format);

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
            XmlDocument doc = new XmlDocument();
            doc.Load("Backup.xml");
            var root = doc.FirstChild;
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                foreach (XmlElement el in node.ChildNodes)
                {
                    var book = new Book();
                    // foreach (XmlElement elem in el.FirstChild)
                    //   {
                    /*
                    foreach (XmlNode node in doc.DocumentElement.ChildNodes)
                    {
                        XmlNode node2 = node.ChildNodes.Item(1);

                    }
                    */

                    if(el.Name == "book")
                    {
                        foreach (XmlElement elem in el.ChildNodes)
                        {
                            if (elem.Name == "name")
                                book.name = elem.InnerText;
                            if (elem.Name == "Författare")
                                book.Författare = elem.InnerText;
                            if (elem.FirstChild.Name == "price")
                                book.price = elem.InnerText;
                            if (elem.FirstChild.Name == "format")
                                book.format = elem.InnerText;
                            if (elem.FirstChild.Name == "genre")
                                book.genre = elem.InnerText;
                            if (elem.FirstChild.Name == "Språk")
                                book.Språk = elem.InnerText;
                            if (elem.FirstChild.Name == "BoVale")
                                book.BoVale = bool.Parse(elem.InnerText);

                            //  }
                            BookList.Add(book);
                        }

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
