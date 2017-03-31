namespace Alexa.Net.Core
{
    public sealed class PlayerActivityType
    {

        private readonly string name;
        private readonly int value;

        public static readonly PlayerActivityType IDLE = new PlayerActivityType(1, "IDLE");
        public static readonly PlayerActivityType PAUSED = new PlayerActivityType(2, "PAUSED");
        public static readonly PlayerActivityType PLAYING = new PlayerActivityType(3, "PLAYING");
        public static readonly PlayerActivityType BUFFER_UNDERRUN = new PlayerActivityType(4, "BUFFER_UNDERRUN");
        public static readonly PlayerActivityType FINISHED = new PlayerActivityType(5, "FINISHED");
        public static readonly PlayerActivityType SSML = new PlayerActivityType(6, "STOPPED");

        private PlayerActivityType(int value, string name)
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
