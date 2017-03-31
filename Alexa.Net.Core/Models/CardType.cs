namespace Alexa.Net.Core
{
    public sealed class CardType
    {

        private readonly string name;
        private readonly int value;

        public static readonly CardType Simple = new CardType(1, "Simple");
        public static readonly CardType Standard = new CardType(2, "Standard");
        public static readonly CardType LinkAccount = new CardType(3, "LinkAccount");

        private CardType(int value, string name)
        {
            this.name = name;
            this.value = value;
        }

        public override string ToString()
        {
            return name;
        }

    }
}
