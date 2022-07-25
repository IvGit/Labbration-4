using System;
namespace Labbration_4
{
    public class Book
    {
        public int ID { get; set; }
        public int Total { get; set; }
        public string Name { get; set; }
        public string Pris { get; set; }
        public string Författare { get; set; }
        public string Genre { get; set; }
        public string Format { get; set; }
        public string Språk { get; set; }
        public bool BoVale { get; internal set; }

        public Book()
        {
            BoVale = false;

        }






        public override string ToString()
        {


            return $"{Språk} {Pris}";
        }
    }
}