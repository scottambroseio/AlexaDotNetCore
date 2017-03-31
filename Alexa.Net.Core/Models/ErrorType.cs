namespace Alexa.Net.Core
{
    public class ErrorType
    {

        private readonly string name;
        private readonly int value;

        public static readonly ErrorType INVALID_RESPONSE = new ErrorType(1, "INVALID_RESPONSE");
        public static readonly ErrorType DEVICE_COMMUNICATION_ERROR = new ErrorType(2, "DEVICE_COMMUNICATION_ERROR");
        public static readonly ErrorType INTERNAL_ERROR = new ErrorType(3, "INTERNAL_ERROR");

        private ErrorType(int value, string name)
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
