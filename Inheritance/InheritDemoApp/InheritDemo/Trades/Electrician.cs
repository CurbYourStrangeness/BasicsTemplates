namespace InheritDemo
{
    public class Electrician : Tradesman
    {
        public toolBelt wiring { get; set; } = toolBelt.soderer;

        public wireTypes wires { get; set; } = wireTypes.sixgaugefiftyfiveamp;

        public void rewire(string wireType, int wirecount)
        {

        }
    }
}
