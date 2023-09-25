

namespace AttributesOefening
{
    internal class GetalString
    {
        public string Getal { get { input = string.Concat(output.Where(Char.IsDigit)); return input; } set { output = value; } }

        public string input;
        public string output;
        public GetalString() { }

        public GetalString(string getal) {
            this.Getal = getal;
        }

        public override string ToString()
        {
            return Getal;
        }
    }
}
