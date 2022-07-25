namespace Labbration_4
{
    public class DataSpel
    {
        public string id { get; set; }
        public string name { get; set; }
        public string platform { get; set; }
        public string price{ get; set; }
        public bool BoVale { get; internal set; }
        public string stock { get;  set; }

        public DataSpel()
        {
            BoVale = false;
        }

        public override string ToString()
        {
            return $"{price} {name}";
        }

    }
}