namespace Labbration_4
{
    public class Book
    {
        public string Språk { get; set; }
        public string Name { get; set; }
        public string Pris { get; set; }
        public string Författare { get; set; }
        public string Genre { get; set; }
        public string Format { get; set; }
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