using System;
namespace Labbration_4
{
    public class Book
    {
        public int id { get; set; }
        public int stock { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public string writer { get; set; }
        public string genre { get; set; }
        public string format { get; set; }
        public string language { get; set; }
        public bool finished { get; internal set; }

        public Book()
        {
            finished = false;

        }

        public override string ToString()
        {


            return $"{name} {price}";
        }
    }
}