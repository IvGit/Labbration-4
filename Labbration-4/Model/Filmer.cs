namespace Labbration_4
{
    public class Filmer
    {
        public string Name { get; set; }
        public string Pris { get; set; }
        public string Format { get; set; }
        public string Speltid { get; set; }
        public bool BoVale { get; internal set; }

        public Filmer()
        {
            BoVale = false;
        }

        public override string ToString()
        {
            return $"{Speltid} {Format}";
        }
    }
}