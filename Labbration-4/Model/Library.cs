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
            doc.Save("ivandb.xml");
        }


        


        public void LoadFile()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("ivandb.xml");
            var root = doc.FirstChild;
            foreach (XmlElement element in root.ChildNodes)
            {
                var book = new Book();
                foreach (XmlElement elem in element.ChildNodes)
                {
                    if (elem.Name == "Name")
                        book.Name = elem.InnerText;
                    if (elem.Name == "Författare")
                        book.Författare = elem.InnerText;
                    if (elem.Name == "Pris")
                        book.Pris = elem.InnerText;
                    if (elem.Name == "Format")
                        book.Format = elem.InnerText;
                    if (elem.Name == "Genre")
                        book.Genre = elem.InnerText;
                    if (elem.Name == "Språk")
                        book.Språk = elem.InnerText;
                    if (elem.Name == "BoVale")
                        book.BoVale = bool.Parse(elem.InnerText);

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




    }

}




































/*
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
        FilmList = new BindingList<Filmer>();


}

    public void SaveFileBook() 
    {
        XmlDocument doc = new XmlDocument();
        XmlElement root = doc.CreateElement("books");
        foreach(var book in BookList)
        {
            XmlElement element = doc.CreateElement("book"); 

            XmlElement name = doc.CreateElement("name");
            name.InnerText = book.Name;
            element.AppendChild(name);

            XmlElement langauge = doc.CreateElement("langauge");
            langauge.InnerText = book.Langauge;
            element.AppendChild(langauge);


            XmlElement writer = doc.CreateElement("writer");
            writer.InnerText = book.Writer;
            element.AppendChild(writer);

            XmlElement price = doc.CreateElement("price");
            price.InnerText = book.Price;
            element.AppendChild(price);

            XmlElement genre = doc.CreateElement("genre");
            genre.InnerText = book.Genre;
            element.AppendChild(genre);

            XmlElement format = doc.CreateElement("format");
            format.InnerText = book.Format;
            element.AppendChild(format);

            XmlElement BoVale = doc.CreateElement("BoVale");
            BoVale.InnerText = book.BoVale.ToString();
            element.AppendChild(BoVale);



           root.AppendChild(element);

        }
        doc.AppendChild(root);
        doc.Save("IvanBD.xml");
    }


    public void LoadFileBook()
    {
        XmlDocument doc = new XmlDocument();
        doc.Load("IvanDB.xml");
        var root = doc.FirstChild;
        foreach (XmlElement element in root.ChildNodes)
        {
            var book = new Book();
            foreach (XmlElement elem in element.ChildNodes)
            {
                if (elem.Name == "name")
                    book.Name = elem.InnerText;
                if (elem.Name == "writer")
                    book.Writer = elem.InnerText;
                if (elem.Name == "price")
                    book.Price = elem.InnerText;
                if (elem.Name == "format")
                    book.Format = elem.InnerText;
                if (elem.Name == "genre")
                    book.Genre = elem.InnerText;
                if (elem.Name == "langauge")
                    book.Langauge = elem.InnerText;
                if (elem.Name == "BoVale")
                    book.BoVale = bool.Parse(elem.InnerText);

            }
            BookList.Add(book);

        }
    }
    /*
    public void SaveFileSpel()
    {
        XmlDocument doc = new XmlDocument();
        XmlElement root = doc.CreateElement("games");
        foreach (var spel in SpelList)
        {
            XmlElement element = doc.CreateElement("spel");

            XmlElement name = doc.CreateElement("name");
            name.InnerText = spel.name;
            element.AppendChild(name);


            XmlElement price = doc.CreateElement("price");
            price.InnerText = spel.price;
            element.AppendChild(price);

            XmlElement platform = doc.CreateElement("platform ");
            platform.InnerText = spel.platform;
            element.AppendChild(platform);


            XmlElement BoVale = doc.CreateElement("BoVale");
            BoVale.InnerText = spel.BoVale.ToString();
            element.AppendChild(BoVale);



            root.AppendChild(element);



        }
        doc.AppendChild(root);
        doc.Save("IvanDBGame.xml");

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
                if (elem.Name == "name")
                    spel.name = elem.InnerText;
                if (elem.Name == "price")
                    spel.price = elem.InnerText;
                if (elem.Name == "platform ")
                    spel.platform = elem.InnerText;
                if (elem.Name == "BoVale")
                    spel.BoVale = bool.Parse(elem.InnerText);

            }

               SpelList.Add(spel);
        }

    }




    public void SaveFileFilm()
    {
        XmlDocument doc = new XmlDocument();
        XmlElement root = doc.CreateElement("movies");
        foreach (var film in FilmList)
        {
            XmlElement element = doc.CreateElement("movie");

            XmlElement name = doc.CreateElement("name");
            name.InnerText = film.name;
            element.AppendChild(name);


            XmlElement price = doc.CreateElement("price");
            price.InnerText = film.price;
            element.AppendChild(price);

            XmlElement format = doc.CreateElement("format");
            format.InnerText = film.format;
            element.AppendChild(format);


            XmlElement BoVale = doc.CreateElement("BoVale");
            BoVale.InnerText = film.BoVale.ToString();
            element.AppendChild(BoVale);



            root.AppendChild(element);



        }
        doc.AppendChild(root);
        doc.Save("IvanDBMovie.xml");
    }

    public void LoadFileFilm()
    {
        XmlDocument doc = new XmlDocument();
        doc.Load("IvanDBMovie.xml");
        var root = doc.FirstChild;
        foreach (XmlElement element in root.ChildNodes)
        {
            var film = new Filmer();
            foreach (XmlElement elem in element.ChildNodes)
            {
                if (elem.Name == "name")
                    film.name = elem.InnerText;
                if (elem.Name == "price")
                    film.price = elem.InnerText;
                if (elem.Name == "playtime")
                    film.playtime = elem.InnerText;
                if (elem.Name == "format")
                    film.format = elem.InnerText;
                if (elem.Name == "BoVale")
                    film.BoVale = bool.Parse(elem.InnerText);

            }

            FilmList.Add(film);
        }
    }


}

}
*/