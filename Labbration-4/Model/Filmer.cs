namespace Labbration_4
{
    public class Filmer
    {
        public int id { get; set; }
        public int stock { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public string format { get; set; }
        public int playtime { get; set; }
        public bool finished { get; internal set; }

        public Filmer()
        {
            finished = false;
        }

        public override string ToString()
        {
            return $"{name} {price}";
        }
    }
}