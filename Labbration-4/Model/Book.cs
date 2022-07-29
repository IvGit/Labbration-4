using System;
namespace Labbration_4
{
    public class Book
    {
        public string id { get; set; }
        public string stock { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public string Författare { get; set; }
        public string genre { get; set; }
        public string format { get; set; }
        public string language { get; set; }
        public bool BoVale { get; internal set; }

        public Book()
        {
            BoVale = false;

        }






        public override string ToString()
        {


            return $"{language} {price}";
        }
    }
}