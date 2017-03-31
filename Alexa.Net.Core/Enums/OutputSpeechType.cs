namespace Alexa.Net.Core
{
    public sealed class OutputSpeechType
    {

        private readonly string name;
        private readonly int value;

        public static readonly OutputSpeechType Text = new OutputSpeechType(1, "Text");
        public static readonly OutputSpeechType SSML = new OutputSpeechType(2, "SSML");

        private OutputSpeechType(int value, string name)
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
