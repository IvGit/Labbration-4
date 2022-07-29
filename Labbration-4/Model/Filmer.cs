namespace Labbration_4
{
    public class Filmer
    {
        public string id { get; set; }
        public string stock { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public string format { get; set; }
        public int playtime { get; set; }
        public bool BoVale { get; internal set; }

        public Filmer()
        {
            BoVale = false;
        }

        public override string ToString()
        {
            return $"{playtime} {format}";
        }
    }
}