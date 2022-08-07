namespace Labbration_4
{
    public class DataSpel
    {
        public int id { get; set; }
        public int stock { get; set; }
        public string name { get; set; }
        public string platform { get; set; }
        public int price { get; set; }
        public bool finished { get; internal set; }

        public DataSpel()
        {
            finished = false;
        }

        public override string ToString()
        {
            return $"{name} {price}";
        }

    }
}