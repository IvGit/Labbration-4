namespace Labbration_4
{
    public class Filmer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Pris { get; set; }
        public string Format { get; set; }
        public string Playtime { get; set; }
        public bool BoVale { get; internal set; }

        public Filmer()
        {
            BoVale = false;
        }

        public override string ToString()
        {
            return $"{Playtime} {Format}";
        }
    }
}