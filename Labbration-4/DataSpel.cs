namespace Labbration_4
{
    public class DataSpel
    {
        public string Name { get; set; }
        public string Plattform { get; set; }
        public string Pris { get; set; }
        public bool BoVale { get; private set; }

        public DataSpel()
        {
            BoVale = false;
        }

        public override string ToString()
        {
            return $"{Plattform} {Name}";
        }

    }
}