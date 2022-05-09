namespace Labbration_4
{
    public class DataSpel
    {
        public string Name { get; set; }
        public string Platform { get; set; }
        public string Pris{ get; set; }
        public bool BoVale { get; internal set; }

        public DataSpel()
        {
            BoVale = false;
        }

        public override string ToString()
        {
            return $"{Pris} {Name}";
        }

    }
}