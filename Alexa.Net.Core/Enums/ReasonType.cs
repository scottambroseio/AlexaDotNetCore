namespace Alexa.Net.Core
{
    public sealed class ReasonType
    {
        private readonly string name;
        private readonly int value;

        public static readonly ReasonType USER_INITIATED = new ReasonType(1, "USER_INITIATED");
        public static readonly ReasonType ERROR = new ReasonType(2, "ERROR");
        public static readonly ReasonType EXCEEDED_MAX_REPROMPTS = new ReasonType(3, "EXCEEDED_MAX_REPROMPTS");

        private ReasonType(int value, string name)
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
